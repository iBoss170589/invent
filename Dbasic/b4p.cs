// Decompiled with JetBrains decompiler
// Type: Dbasic.b4p
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using B4PSQL;
using bControls;
using Dbasic.EnhancedControls;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Dbasic
{
  public class b4p
  {
    public const double fixX = 1.0;
    public const double fixY = 1.0;
    public static CultureInfo cul = new CultureInfo("en-US", false);
    public CEnhancedForm mainForm;
    public CEnhancedForm shownForm;
    public Color transColor = Color.Violet;
    public SolidBrush foreBrush = new SolidBrush(Color.Violet);
    public CEnhancedObject CEnhancedObject;
    public CaseInsensitiveComparer caseNotCompare;
    public Comparer caseCompare;
    public CCompareNumbers numbersCompare;
    public bool quitFlag;
    public Hashtable htSubs = new Hashtable();
    public CHtControls htControls = new CHtControls();
    public ASCIIEncoding ae = new ASCIIEncoding();
    public string sender = "";
    public Hashtable htStreams = new Hashtable();
    private Other Other;
    private object[] localVars;
    private Random rnd = new Random();
    public string dateFormat;
    public string timeFormat;
    public string b4pdir;
    public static string cPPC;
    public Thread tdRunning;
    public Exception lastError;
    public static double scaleX = 1.0;
    public static double scaleY = 1.0;
    public static bool autoScale = false;
    public ArrayList alFormsDisplayOrder;
    public int screenY = 268;
    public int screenX = 238;
    public string icon = "";
    private string[] var__mainmodule_args;
    private CEnhancedForm __utilerias_canc;
    private CEnhancedButton __utilerias_cmdcbus;
    private CEnhancedButton __utilerias_cmdcanc2;
    private CEnhancedTextBox __utilerias_tart;
    private CEnhancedLabel __utilerias_ltcodigo;
    private CEnhancedButton __utilerias_cmdcanc1;
    private CEnhancedTable __utilerias_tblcanc;
    private CEnhancedMenu __utilerias_mnucantea;
    private CEnhancedForm __utilerias_partinven;
    private CEnhancedCombo __utilerias_cbomovfol;
    private CEnhancedTable __utilerias_fgprod;
    private CEnhancedMenu __utilerias_mnurelpar;
    private CEnhancedMenu __utilerias_mnutodos;
    private CEnhancedMenu __utilerias_mnuxfol;
    private CEnhancedMenu __utilerias_mnueliminar;
    private CEnhancedForm __utilerias_frmtea;
    private CEnhancedTextBox __utilerias_tfolio;
    private CEnhancedLabel __utilerias_label10;
    private CEnhancedButton __utilerias_btntea2;
    private CEnhancedButton __utilerias_btntea;
    private CEnhancedTextBox __utilerias_tporttea;
    private CEnhancedTextBox __utilerias_tbasetea;
    private CEnhancedLabel __utilerias_label5;
    private CEnhancedTextBox __utilerias_tpasstea;
    private CEnhancedLabel __utilerias_label4;
    private CEnhancedTextBox __utilerias_tusertea;
    private CEnhancedLabel __utilerias_label3;
    private CEnhancedLabel __utilerias_label2;
    private CEnhancedTextBox __utilerias_tservertea;
    private CEnhancedLabel __utilerias_label1;
    private CEnhancedForm __utilerias_inven;
    private CEnhancedPanel __utilerias_pnlcanfolio;
    private CEnhancedPanel __utilerias_pnltrans;
    private CEnhancedLabel __utilerias_ltarttrans;
    private CEnhancedButton __utilerias_btntrans;
    private CEnhancedLabel __utilerias_label9;
    private CEnhancedCombo __utilerias_cbocanfolio;
    private CEnhancedButton __utilerias_btncanfol2;
    private CEnhancedButton __utilerias_btncanfolio1;
    private CEnhancedLabel __utilerias_label8;
    private CEnhancedLabel __utilerias_label7;
    private CEnhancedTextBox __utilerias_tprod;
    private CEnhancedButton __utilerias_ltcantidad;
    private CEnhancedTable __utilerias_tbltea;
    private CEnhancedLabel __utilerias_ltfolio;
    private CEnhancedButton __utilerias_btnmainfolio;
    private CEnhancedLabel __utilerias_ltkit;
    private CEnhancedButton __utilerias_ltproducto;
    private CEnhancedTextBox __utilerias_tcant;
    private CEnhancedButton __utilerias_cmdaceptar;
    private CEnhancedMenu __utilerias_mnuarchivo;
    private CEnhancedMenu __utilerias_mnumov;
    private CEnhancedMenu __utilerias_mnuenviar;
    private CEnhancedMenu __utilerias_mnufin;
    private CEnhancedMenu __utilerias_mnucanc;
    private CEnhancedMenu __utilerias_mnucanfolio;
    private CEnhancedForm __utilerias_enviar;
    private CEnhancedLabel __utilerias_label6;
    private CEnhancedLabel __utilerias_label990;
    private CEnhancedCombo __utilerias_cbofol;
    private CEnhancedLabel __utilerias_ltenviar2;
    private CEnhancedLabel __utilerias_ltenviar1;
    private CEnhancedCheckBox __utilerias_chtodos;
    private CEnhancedLabel __utilerias_ltrutaenviar;
    private CEnhancedButton __utilerias_cmdsend2;
    private CEnhancedButton __utilerias_cmdsend1;
    private CEnhancedLabel __utilerias_ltenviar9;
    private CEnhancedForm __utilerias_importa;
    private CEnhancedCombo __utilerias_cbotiendadestino;
    private CEnhancedLabel __utilerias_ltserver9;
    private CEnhancedLabel __utilerias_ltimport11;
    private CEnhancedButton __utilerias_cmdimpor2;
    private CEnhancedButton __utilerias_cmdimpor1;
    private CEnhancedLabel __utilerias_ltdestino1;
    private CEnhancedCombo __utilerias_cbotiendaorigen;
    private CEnhancedLabel __utilerias_ltorigen1;
    private CEnhancedForm __mainmodule_prods;
    private CEnhancedButton __mainmodule_btnprods;
    private CEnhancedTable __mainmodule_tblprod;
    private CEnhancedForm __mainmodule_frmacceso;
    private CEnhancedTextBox __mainmodule_tlogin;
    private CEnhancedButton __mainmodule_btnlogin2;
    private CEnhancedButton __mainmodule_btnlogin1;
    private CEnhancedLabel __mainmodule_label39;
    private CEnhancedForm __mainmodule_usuarios;
    private CEnhancedTable __mainmodule_tbluser;
    private CEnhancedButton __mainmodule_btnusr3;
    private CEnhancedButton __mainmodule_btnusr2;
    private CEnhancedButton __mainmodule_btnusr1;
    private CEnhancedTextBox __mainmodule_tfolio;
    private CEnhancedTextBox __mainmodule_tserie;
    private CEnhancedCheckBox __mainmodule_chnivel;
    private CEnhancedTextBox __mainmodule_tclave;
    private CEnhancedTextBox __mainmodule_tnombre;
    private CEnhancedTextBox __mainmodule_tusu;
    private CEnhancedLabel __mainmodule_label14;
    private CEnhancedLabel __mainmodule_label12;
    private CEnhancedButton __mainmodule_btnnew;
    private CEnhancedLabel __mainmodule_label3;
    private CEnhancedLabel __mainmodule_label10;
    private CEnhancedLabel __mainmodule_label2;
    private CEnhancedForm __mainmodule_frmtraspasos;
    private CEnhancedButton __mainmodule_cmdimport2;
    private CEnhancedButton __mainmodule_cmdimport1;
    private CEnhancedCombo __mainmodule_cbotiendadestino;
    private CEnhancedLabel __mainmodule_label40;
    private CEnhancedCombo __mainmodule_cbotiendaorigen;
    private CEnhancedLabel __mainmodule_label36;
    private CEnhancedForm __mainmodule_frmexistencias;
    private CEnhancedLabel __mainmodule_lte;
    private CEnhancedLabel __mainmodule_ltdescr;
    private CEnhancedLabel __mainmodule_ltprec;
    private CEnhancedButton __mainmodule_btnsalexist;
    private CEnhancedTextBox __mainmodule_tprod;
    private CEnhancedLabel __mainmodule_label26;
    private CEnhancedForm __mainmodule_frmexistxlinea;
    private CEnhancedPanel __mainmodule_pnltoper;
    private CEnhancedButton __mainmodule_btntoperborrar;
    private CEnhancedLabel __mainmodule_ltstop;
    private CEnhancedButton __mainmodule_btntopercerrar;
    private CEnhancedTable __mainmodule_tbltoper;
    private CEnhancedButton __mainmodule_btntoper2;
    private CEnhancedButton __mainmodule_btntoper1;
    private CEnhancedTable __mainmodule_tblexisxlinea;
    private CEnhancedForm __mainmodule_invencan;
    private CEnhancedLabel __mainmodule_ltsumcan2;
    private CEnhancedLabel __mainmodule_ltsum2;
    private CEnhancedLabel __mainmodule_ltsumcan;
    private CEnhancedLabel __mainmodule_ltsum;
    private CEnhancedTextBox __mainmodule_tcodigo;
    private CEnhancedTable __mainmodule_tbcaninven;
    private CEnhancedButton __mainmodule_cmdinvc;
    private CEnhancedLabel __mainmodule_label27;
    private CEnhancedMenu __mainmodule_mnucanc0;
    private CEnhancedMenu __mainmodule_mnucan1;
    private CEnhancedMenu __mainmodule_mnuinvent;
    private CEnhancedMenu __mainmodule_mnusalircan;
    private CEnhancedForm __mainmodule_frmareas;
    private CEnhancedPanel __mainmodule_pnlareasseries;
    private CEnhancedCombo __mainmodule_cboseriesareas;
    private CEnhancedTextBox __mainmodule_tnotaarea;
    private CEnhancedLabel __mainmodule_label44;
    private CEnhancedLabel __mainmodule_ltseries;
    private CEnhancedButton __mainmodule_btnareaserie2;
    private CEnhancedButton __mainmodule_btnareaserie1;
    private CEnhancedLabel __mainmodule_label42;
    private CEnhancedTextBox __mainmodule_tareanombre;
    private CEnhancedLabel __mainmodule_ltarea;
    private CEnhancedButton __mainmodule_btnareagrabar;
    private CEnhancedButton __mainmodule_btneliminar;
    private CEnhancedButton __mainmodule_btnareanew;
    private CEnhancedButton __mainmodule_btnarea2;
    private CEnhancedTable __mainmodule_tblareas;
    private CEnhancedLabel __mainmodule_label43;
    private CEnhancedMenu __mainmodule_mnuarchivoareas;
    private CEnhancedMenu __mainmodule_mnuareas1;
    private CEnhancedMenu __mainmodule_mnuborrarareas;
    private CEnhancedForm __mainmodule_frmclientes;
    private CEnhancedTextBox __mainmodule_tcliente;
    private CEnhancedTable __mainmodule_tabla;
    private CEnhancedButton __mainmodule_cmdbuscar;
    private CEnhancedMenu __mainmodule_mnuctep;
    private CEnhancedMenu __mainmodule_mnucte1;
    private CEnhancedMenu __mainmodule_mnucte2;
    private CEnhancedMenu __mainmodule_mnucte3;
    private CEnhancedForm __mainmodule_gencompra;
    private CEnhancedCheckBox __mainmodule_chenviartodascompras;
    private CEnhancedCombo __mainmodule_cbocompra;
    private CEnhancedLabel __mainmodule_ltcomreg;
    private CEnhancedLabel __mainmodule_label34;
    private CEnhancedLabel __mainmodule_label31;
    private CEnhancedLabel __mainmodule_ltcomcant;
    private CEnhancedLabel __mainmodule_ltcomart;
    private CEnhancedLabel __mainmodule_label29;
    private CEnhancedLabel __mainmodule_ltconcepto;
    private CEnhancedLabel __mainmodule_ltfoliocompra;
    private CEnhancedButton __mainmodule_btnsalirgencompra;
    private CEnhancedButton __mainmodule_btngencompra;
    private CEnhancedForm __mainmodule_genpedido;
    private CEnhancedCheckBox __mainmodule_chenviartodospedidos;
    private CEnhancedButton __mainmodule_btnsalirpedido;
    private CEnhancedButton __mainmodule_btngenpedido;
    private CEnhancedCombo __mainmodule_cbopedido;
    private CEnhancedLabel __mainmodule_ltpedreg;
    private CEnhancedLabel __mainmodule_label49;
    private CEnhancedLabel __mainmodule_ltpedcant;
    private CEnhancedLabel __mainmodule_label47;
    private CEnhancedLabel __mainmodule_ltpedart;
    private CEnhancedLabel __mainmodule_label46;
    private CEnhancedLabel __mainmodule_label45;
    private CEnhancedForm __mainmodule_frmcomprasutils;
    private CEnhancedTable __mainmodule_tblcompras;
    private CEnhancedCombo __mainmodule_cboprovutils;
    private CEnhancedLabel __mainmodule_label37;
    private CEnhancedMenu __mainmodule_mnuarchivocompras;
    private CEnhancedMenu __mainmodule_mnucancelcompra;
    private CEnhancedMenu __mainmodule_mnucancelarpartidacompra;
    private CEnhancedMenu __mainmodule_mnusalirutilscompra;
    private CEnhancedForm __mainmodule_frmpedidosutils;
    private CEnhancedButton __mainmodule_btnsalped;
    private CEnhancedTable __mainmodule_tblpedidos;
    private CEnhancedCombo __mainmodule_cboclieutils;
    private CEnhancedLabel __mainmodule_label56;
    private CEnhancedMenu __mainmodule_mnuarchipedutils;
    private CEnhancedMenu __mainmodule_mnucanped;
    private CEnhancedMenu __mainmodule_mnueliped;
    private CEnhancedMenu __mainmodule_mnusalp;
    private CEnhancedForm __mainmodule_frmmenu;
    private CEnhancedPanel __mainmodule_pnlpedidos;
    private CEnhancedButton __mainmodule_btncteped2;
    private CEnhancedButton __mainmodule_btncteped1;
    private CEnhancedTextBox __mainmodule_tpedcte;
    private CEnhancedImageButton __mainmodule_btnokcte;
    private CEnhancedImageButton __mainmodule_btnbuscarcte;
    private CEnhancedLabel __mainmodule_ltnombrecte;
    private CEnhancedLabel __mainmodule_label50;
    private CEnhancedLabel __mainmodule_label48;
    private CEnhancedButton __mainmodule_btnpedido;
    private CEnhancedButton __mainmodule_btntraspasos;
    private CEnhancedButton __mainmodule_btnmenusalir;
    private CEnhancedButton __mainmodule_btnmenucompras;
    private CEnhancedButton __mainmodule_btnmenuinvent;
    private CEnhancedForm __mainmodule_invent;
    private CEnhancedPanel __mainmodule_pnlred;
    private CEnhancedLabel __mainmodule_lt2;
    private CEnhancedLabel __mainmodule_lt4;
    private CEnhancedLabel __mainmodule_lt3;
    private CEnhancedLabel __mainmodule_lt1;
    private CEnhancedTextBox __mainmodule_tarticulo;
    private CEnhancedTextBox __mainmodule_tuni;
    private CEnhancedCombo __mainmodule_cboareas;
    private CEnhancedLabel __mainmodule_label30;
    private CEnhancedLabel __mainmodule_ltartinv;
    private CEnhancedButton __mainmodule_btnred;
    private CEnhancedLabel __mainmodule_ltred;
    private CEnhancedLabel __mainmodule_ltfc;
    private CEnhancedLabel __mainmodule_ltsae;
    private CEnhancedLabel __mainmodule_ltinven;
    private CEnhancedButton __mainmodule_cmdinv;
    private CEnhancedLabel __mainmodule_ltinven2;
    private CEnhancedLabel __mainmodule_label25;
    private CEnhancedMenu __mainmodule_mnuarchivo;
    private CEnhancedMenu __mainmodule_menmov;
    private CEnhancedMenu __mainmodule_mensend;
    private CEnhancedMenu __mainmodule_mnuenviarsae;
    private CEnhancedMenu __mainmodule_mnupedido;
    private CEnhancedMenu __mainmodule_mnuopcionesped;
    private CEnhancedMenu __mainmodule_mnunewpedido;
    private CEnhancedMenu __mainmodule_mnucompra;
    private CEnhancedMenu __mainmodule_mnuutilscompras;
    private CEnhancedMenu __mainmodule_mnunuevacompra;
    private CEnhancedMenu __mainmodule_mnureenviar;
    private CEnhancedMenu __mainmodule_mnuexist;
    private CEnhancedMenu __mainmodule_mnutotal;
    private CEnhancedMenu __mainmodule_mnuexisxlinea;
    private CEnhancedMenu __mainmodule_mnuareas;
    private CEnhancedMenu __mainmodule_menfin;
    private CEnhancedForm __mainmodule_sqlserver;
    private CEnhancedCheckBox __mainmodule_chmatriz;
    private CEnhancedCheckBox __mainmodule_chmult;
    private CEnhancedTextBox __mainmodule_tremoto;
    private CEnhancedLabel __mainmodule_label9;
    private CEnhancedTextBox __mainmodule_tcorreo2;
    private CEnhancedTextBox __mainmodule_tcontrol;
    private CEnhancedTextBox __mainmodule_tlinea;
    private CEnhancedLabel __mainmodule_label4;
    private CEnhancedButton __mainmodule_btnsql3;
    private CEnhancedCombo __mainmodule_cboempresa1;
    private CEnhancedTextBox __mainmodule_tcorreo;
    private CEnhancedLabel __mainmodule_label20;
    private CEnhancedLabel __mainmodule_label19;
    private CEnhancedCombo __mainmodule_cboalm;
    private CEnhancedLabel __mainmodule_label18;
    private CEnhancedButton __mainmodule_btnsql2;
    private CEnhancedButton __mainmodule_btnsql1;
    private CEnhancedTextBox __mainmodule_tpuerto;
    private CEnhancedTextBox __mainmodule_tpasssql;
    private CEnhancedTextBox __mainmodule_tuser;
    private CEnhancedTextBox __mainmodule_tbase;
    private CEnhancedTextBox __mainmodule_tserver;
    private CEnhancedTextBox __mainmodule_tnombreemp;
    private CEnhancedLabel __mainmodule_label16;
    private CEnhancedLabel __mainmodule_label13;
    private CEnhancedLabel __mainmodule_label8;
    private CEnhancedLabel __mainmodule_label7;
    private CEnhancedLabel __mainmodule_label6;
    private CEnhancedLabel __mainmodule_label5;
    private CEnhancedLabel __mainmodule_ltsql1;
    private CEnhancedMenu __mainmodule_mnusql1;
    private CEnhancedMenu __mainmodule_mnusql2;
    private CEnhancedMenu __mainmodule_mnusql3;
    private CEnhancedMenu __mainmodule_mnusql4;
    private CEnhancedForm __mainmodule_frmseries;
    private CEnhancedCombo __mainmodule_cboempresapred;
    private CEnhancedLabel __mainmodule_label35;
    private CEnhancedTextBox __mainmodule_tserped;
    private CEnhancedLabel __mainmodule_label55;
    private CEnhancedTextBox __mainmodule_tfolped;
    private CEnhancedLabel __mainmodule_label54;
    private CEnhancedLabel __mainmodule_label53;
    private CEnhancedLabel __mainmodule_label52;
    private CEnhancedLabel __mainmodule_label17;
    private CEnhancedTextBox __mainmodule_tfoliocompra;
    private CEnhancedTextBox __mainmodule_tseriecompra;
    private CEnhancedLabel __mainmodule_label15;
    private CEnhancedButton __mainmodule_btnsalirseries;
    private CEnhancedButton __mainmodule_btnseries;
    private CEnhancedForm __mainmodule_main;
    private CEnhancedImage __mainmodule_image1;
    private CEnhancedLabel __mainmodule_label28;
    private CEnhancedCheckBox __mainmodule_chimportar;
    private CEnhancedCombo __mainmodule_cboempresa;
    private CEnhancedTextBox __mainmodule_tusuario;
    private CEnhancedTextBox __mainmodule_tpassword;
    private CEnhancedButton __mainmodule_btnaceptar;
    private CEnhancedButton __mainmodule_btnmain8;
    private CEnhancedLabel __mainmodule_ltsocial;
    private CEnhancedLabel __mainmodule_ltart;
    private CEnhancedLabel __mainmodule_ltsync;
    private CEnhancedLabel __mainmodule_label23;
    private CEnhancedLabel __mainmodule_label22;
    private CEnhancedLabel __mainmodule_label21;
    private CEnhancedForm __mainmodule_config;
    private CEnhancedButton __mainmodule_btncrearbase;
    private CEnhancedButton __mainmodule_btnareas;
    private CEnhancedButton __mainmodule_btncompactar;
    private CEnhancedButton __mainmodule_btntea;
    private CEnhancedCheckBox __mainmodule_chcaja;
    private CEnhancedButton __mainmodule_btnenviarinven;
    private CEnhancedLabel __mainmodule_ltllenar;
    private CEnhancedButton __mainmodule_btnutils;
    private CEnhancedButton __mainmodule_btnuser;
    private CEnhancedButton __mainmodule_btnsql;
    private CEnhancedButton __mainmodule_cmdvaciarinvent;
    private CEnhancedButton __mainmodule_cmdrutapcc;
    private CEnhancedForm __mainmodule_enviar;
    private CEnhancedLabel __mainmodule_label51;
    private CEnhancedTextBox __mainmodule_trutapc;
    private CEnhancedCheckBox __mainmodule_chenviarpc;
    private CEnhancedTimer __mainmodule_timer1;
    private CEnhancedLabel __mainmodule_ltnum;
    private CEnhancedCombo __mainmodule_cboconex;
    private CEnhancedLabel __mainmodule_ltsend2;
    private CEnhancedButton __mainmodule_cmdsend2;
    private CEnhancedButton __mainmodule_cmdsend1;
    private CEnhancedLabel __mainmodule_ltsend1;
    private CEnhancedForm __mainmodule_procminve;
    private CEnhancedLabel __mainmodule_ltpiezas;
    private CEnhancedLabel __mainmodule_label41;
    private CEnhancedLabel __mainmodule_ltserver;
    private CEnhancedLabel __mainmodule_ltmreg;
    private CEnhancedLabel __mainmodule_ltmcant;
    private CEnhancedLabel __mainmodule_lttipo;
    private CEnhancedRadioBtn __mainmodule_opminve3;
    private CEnhancedRadioBtn __mainmodule_opminve2;
    private CEnhancedRadioBtn __mainmodule_opminve1;
    private CEnhancedLabel __mainmodule_lalma;
    private CEnhancedLabel __mainmodule_label38;
    private CEnhancedLabel __mainmodule_label1;
    private CEnhancedTextBox __mainmodule_tconsal;
    private CEnhancedNumUpDown __mainmodule_numano;
    private CEnhancedNumUpDown __mainmodule_nummes;
    private CEnhancedNumUpDown __mainmodule_numdia;
    private CEnhancedLabel __mainmodule_label32;
    private CEnhancedLabel __mainmodule_label33;
    private CEnhancedLabel __mainmodule_ltmart;
    private CEnhancedTextBox __mainmodule_trefminve;
    private CEnhancedLabel __mainmodule_label24;
    private CEnhancedTextBox __mainmodule_tconm;
    private CEnhancedLabel __mainmodule_ltconm;
    private CEnhancedLabel __mainmodule_label11;
    private CEnhancedButton __mainmodule_btnexistminve;
    private CEnhancedButton __mainmodule_btngenerar;
    private CEnhancedMenu __mainmodule_mnuminve;
    private CEnhancedMenu __mainmodule_mnuminve1;
    private CEnhancedMenu __mainmodule_mnuacumulativo;
    private CEnhancedMenu __mainmodule_mnuactualizar;
    private CEnhancedMenu __mainmodule_mnuajustar;
    private CEnhancedMenu __mainmodule_mnuenviarsql;
    private CEnhancedMenu __mainmodule_mnutotalminve;
    private CEnhancedMenu __mainmodule_mnuexxlinea;
    private B4PSQL.Command __mainmodule_cmd;
    private Connection __mainmodule_con;
    private DataReader __mainmodule_reader;
    private FormLib.FormLib __mainmodule_flb;
    private MSSQL.MSSQL __mainmodule_msql1;
    private B4PSQL.Command __mainmodule_cmd2;
    private DataReader __mainmodule_reader2;
    private bList __mainmodule_listcte;
    private bListItem __mainmodule_item;
    private string[] var__mainmodule_fields;
    private string[] var__mainmodule_data;
    private string[] var__mainmodule_accounts;
    private string var__mainmodule_tipomov = "";
    private string var__mainmodule_empresa_origen = "";
    private string var__mainmodule_empresa_destino = "";
    private bool var__mainmodule_errfound;
    private bool var__mainmodule_existdb;
    private string var__mainmodule_sql = "";
    private int var__mainmodule_crow;
    private string var__mainmodule_wifilocation = "";
    private string var__mainmodule_port = "";
    private string var__mainmodule_userroot = "";
    private double var__mainmodule_rowcompra;
    private double var__mainmodule_multialmacen;
    private string var__mainmodule_serverlocal = "";
    private string var__mainmodule_serverremoto = "";
    private string var__mainmodule_base = "";
    private string var__mainmodule_usersql = "";
    private string var__mainmodule_passsql = "";
    private string var__mainmodule_portsql = "";
    private string var__mainmodule_empresa = "";
    private double var__mainmodule_almacen;
    private string var__mainmodule_ctrl_alm = "";
    private string var__mainmodule_correo = "";
    private string var__mainmodule_correo2 = "";
    private string var__mainmodule_nombreempresa = "";
    private string var__mainmodule_linea = "";
    private string var__mainmodule_isadmin = "";
    private string var__mainmodule_seriecompra = "";
    private string var__mainmodule_seriepedido = "";
    private double var__mainmodule_foliocompra;
    private double var__mainmodule_folioped;
    private double var__mainmodule_folio;
    private string var__mainmodule_seriefolio = "";
    private double var__mainmodule_sistema;
    private string var__mainmodule_serie = "";
    private string var__mainmodule_empresapred = "";
    private string var__mainmodule_tipoproc = "";
    private string var__mainmodule_servertea = "";
    private string var__mainmodule_basetea = "";
    private string var__mainmodule_usertea = "";
    private string var__mainmodule_passtea = "";
    private string var__mainmodule_porttea = "";
    private string var__mainmodule_process = "";
    private string var__mainmodule_rutapc = "";
    private string var__mainmodule_twifi = "";
    private int err_utilerias_cmdaceptar_click;
    private int err_utilerias_closeconexionsqlite;
    private int err_utilerias_tprod_keypress;
    private int err_utilerias_btncanfolio1_click;
    private int err_utilerias_mnumov_click;
    private int err_utilerias_mnufin_click;
    private int err_utilerias_mnucanfolio_click;
    private int err_utilerias_tart_keypress;
    private int err_utilerias_cmdcanc1_click;
    private int err_utilerias_enviar_show;
    private int err_utilerias_cmdsend1_click;
    private int err_utilerias_cmdimpor1_click;
    private int err_utilerias_importa_show;
    private int err_utilerias_cbotiendaorigen_selectionchanged;
    private int err_utilerias_loadmovsinv;
    private int err_utilerias_bart;
    private int err_utilerias_cbofol_selectionchanged;
    private int err_utilerias_cbotiendadestino_selectionchanged;
    private int err_mainmodule_app_start;
    private int err_mainmodule_creatablaarea;
    private int err_mainmodule_addfield;
    private int err_mainmodule_tblprod_selectionchanged;
    private int err_mainmodule_centra;
    private int err_mainmodule_config_show;
    private int err_mainmodule_enviar_show;
    private int err_mainmodule_cmdborrar_click;
    private int err_mainmodule_main_close;
    private int err_mainmodule_cmdinv_click;
    private int err_mainmodule_invent_show;
    private int err_mainmodule_tarticulo_keypress;
    private int err_mainmodule_importararticulos;
    private int err_mainmodule_importararticulosupdateexist;
    private int err_mainmodule_cmdvaciarinvent_click;
    private int err_mainmodule_vacu;
    private int err_mainmodule_menmov_click;
    private int err_mainmodule_mnucan1_click;
    private int err_mainmodule_tcodigo_keypress;
    private int err_mainmodule_bcodigo;
    private int err_mainmodule_btnsql1_click;
    private int err_mainmodule_cboempresa1_selectionchanged;
    private int err_mainmodule_cboimporta_selectionchanged;
    private int err_mainmodule_image1_click;
    private int err_mainmodule_usuarios_show;
    private int err_mainmodule_btnusr1_click;
    private int err_mainmodule_btnaceptar_click;
    private int err_mainmodule_btnsql3_click;
    private int err_mainmodule_tbluser_selectionchanged;
    private int err_mainmodule_cboempresa_selectionchanged;
    private int err_mainmodule_cierramsql;
    private int err_mainmodule_cierracontrans;
    private int err_mainmodule_btnusr2_click;
    private int err_mainmodule_btnutils_click;
    private int err_mainmodule_enviaraunapc;
    private int err_mainmodule_inventario_directo_proc_almacenado;
    private int err_mainmodule_inventario_acumulativo_proc_almacenado;
    private int err_mainmodule_inventario_directo;
    private int err_mainmodule_inventario_acumulativo;
    private int err_mainmodule_btngencompra_click;
    private int err_mainmodule_gencompra_show;
    private int err_mainmodule_mnureenviar_click;
    private int err_mainmodule_tprod_keypress;
    private int err_mainmodule_buscaexistencia;
    private int err_mainmodule_btnprods_click;
    private int err_mainmodule_mnuenviarsql_click;
    private int err_mainmodule_mnutotal_click;
    private int err_mainmodule_btncompactar_click;
    private int err_mainmodule_bk_txt;
    private int err_mainmodule_frmareas_show;
    private int err_mainmodule_tblareas_selectionchanged;
    private int err_mainmodule_btneliminar_click;
    private int err_mainmodule_desplegarareas;
    private int err_mainmodule_btnareagrabar_click;
    private int err_mainmodule_mnuborrarareas_click;
    private int err_mainmodule_btnareaserie1_click;
    private int err_mainmodule_btntoper1_click;
    private int err_mainmodule_btntoperborrar_click;
    private int err_mainmodule_cierrareader;
    private int err_mainmodule_btncrearbase_click;
    private int err_mainmodule_genpedido_show;
    private int err_mainmodule_frmpedidosutils_show;
    private int err_mainmodule_cboclieutils_selectionchanged;
    private int err_mainmodule_mnucanped_click;
    private int err_mainmodule_mnureenped_click;
    private int err_mainmodule_mnueliped_click;
    private int err_mainmodule_cmdbuscar_click;
    private int err_mainmodule_frmclientes_show;
    private int err_mainmodule_btnokcte_click;

    [STAThread]
    private static void Main(string[] args)
    {
      b4p b4p = new b4p(args);
    }

    private void AddRuntimeEvent(string name, string eventName, string subName)
    {
      if (this.htControls[(object) name] is IEnhancedControl)
        ((IEnhancedControl) this.htControls[(object) name]).AddRunTimeEvent(eventName, subName);
      else
        this.CEnhancedObject.AddRunTimeEvent(this.htControls[(object) name], name, eventName, subName);
    }

    public bool CompareEqual(string lSide, string rSide)
    {
      return lSide == "" && rSide == "0" || lSide == "0" && rSide == "" || lSide == rSide;
    }

    public bool LCompareEqual(string lSide, string rSide)
    {
      return lSide == "" && rSide == "0" || lSide == rSide;
    }

    public bool RCompareEqual(string lSide, string rSide)
    {
      return lSide == "0" && rSide == "" || lSide == rSide;
    }

    public bool ShowError(Exception ex, string subName)
    {
      Cursor.Current = Cursors.Default;
      if (this.quitFlag)
        return true;
      ArrayList arrayList = new ArrayList();
      foreach (DictionaryEntry htControl in (Hashtable) this.htControls)
      {
        object obj = htControl.Value;
        if (obj is System.Windows.Forms.Timer && ((System.Windows.Forms.Timer) obj).Enabled)
        {
          ((System.Windows.Forms.Timer) obj).Enabled = false;
          arrayList.Add(obj);
        }
      }
      if (MessageBox.Show("An error occurred on sub " + subName + ".\r\n\r\n" + ex.Message + "\r\nContinue?", "Basic4ppc", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.No)
      {
        this.quitFlag = true;
        if (this.mainForm != null)
          this.mainForm.Close();
        return true;
      }
      foreach (System.Windows.Forms.Timer timer in arrayList)
        timer.Enabled = true;
      return false;
    }

    public void CloseProgram()
    {
      this.quitFlag = true;
      this.shownForm = (CEnhancedForm) null;
      if (this.CEnhancedObject.htShemotAzamim != null)
        this.CEnhancedObject.htShemotAzamim.Clear();
      foreach (DictionaryEntry htStream in this.htStreams)
        ((IStream) htStream.Value).Close();
      this.htStreams.Clear();
      foreach (DictionaryEntry htControl in (Hashtable) this.htControls)
      {
        object obj = htControl.Value;
        if (obj is CEnhancedForm && obj != this.mainForm)
          ((Form) obj).Close();
        else if (obj is System.Windows.Forms.Timer)
          ((System.Windows.Forms.Timer) obj).Enabled = false;
        try
        {
          if (obj != null)
          {
            if (obj is IDisposable)
              ((IDisposable) obj).Dispose();
          }
        }
        catch
        {
        }
      }
      this.htControls.Clear();
      GC.Collect();
      Application.ExitThread();
      Cursor.Current = Cursors.Default;
    }

    public b4p(string[] args)
    {
      try
      {
        this.CEnhancedObject = new CEnhancedObject(this);
        this.Other = new Other(this);
        this.dateFormat = "MM/dd/yyyy";
        this.timeFormat = "HH:mm";
        this.tdRunning = Thread.CurrentThread;
        this.b4pdir = Application.StartupPath;
        b4p.cPPC = "false";
        this.alFormsDisplayOrder = new ArrayList();
        Thread.SetData(Thread.GetNamedDataSlot(nameof (cPPC)), (object) bool.Parse(b4p.cPPC));
        Thread.SetData(Thread.GetNamedDataSlot("optimized"), (object) true);
        Thread.SetData(Thread.GetNamedDataSlot(nameof (b4p)), (object) this);
        Thread.SetData(Thread.GetNamedDataSlot("version"), (object) 6.9);
        this.var__mainmodule_args = args;
        this.initialize();
        this._globals();
        this.__mainmodule_app_start();
        if (this.shownForm == null)
          return;
        Application.Run((Form) this.shownForm);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error loading program.\n" + ex.Message, "Basic4ppc", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
      }
    }

    private string _globals()
    {
      this.var__mainmodule_fields = new string[1];
      this.var__mainmodule_data = new string[1];
      this.var__mainmodule_accounts = new string[0];
      this.var__mainmodule_twifi = "0";
      return "";
    }

    private string __utilerias_frmtea_show()
    {
      try
      {
        this.__utilerias_tfolio.Text = this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul);
        this.__utilerias_tservertea.Text = this.var__mainmodule_servertea;
        this.__utilerias_tbasetea.Text = this.var__mainmodule_basetea;
        this.__utilerias_tusertea.Text = this.var__mainmodule_usertea;
        this.__utilerias_tpasstea.Text = this.var__mainmodule_passtea;
        this.__utilerias_tporttea.Text = this.var__mainmodule_porttea;
        this.__utilerias_label1.BringToFront();
        this.__utilerias_tservertea.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_frmtea_show");
        return "";
      }
    }

    private string __utilerias_btntea2_click()
    {
      try
      {
        this.__utilerias_frmtea.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_btntea2_click");
        return "";
      }
    }

    private string __utilerias_btntea_click()
    {
      try
      {
        if (this.Other.IsNumber(this.__utilerias_tfolio.Text).ToLower(b4p.cul) == "true")
        {
          string text = this.__utilerias_tfolio.Text;
          this.var__mainmodule_servertea = this.__utilerias_tservertea.Text;
          this.var__mainmodule_basetea = this.__utilerias_tbasetea.Text;
          this.var__mainmodule_usertea = this.__utilerias_tusertea.Text;
          this.var__mainmodule_passtea = this.__utilerias_tpasstea.Text;
          this.var__mainmodule_porttea = this.__utilerias_tporttea.Text;
          this.__mainmodule_cmd.CommandText = "UPDATE config SET server = '" + this.var__mainmodule_servertea + "', " + "base = '" + this.var__mainmodule_basetea + "', " + "User = '" + this.var__mainmodule_usertea + "', " + "pass = '" + this.var__mainmodule_passtea + "', port = '" + this.var__mainmodule_porttea + "', folio = " + text;
          this.__mainmodule_cmd.ExecuteNonQuery();
          ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__utilerias_frmtea.close();
          return "";
        }
        ((int) MessageBox.Show("El folio debe ser numérico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_btntea_click");
        return "";
      }
    }

    private string __utilerias_cmdaceptar_click()
    {
      string str1 = "";
      double num1 = 0.0;
      string str2 = "";
      string str3 = "";
      double num2 = 0.0;
      int num3 = 0;
      double num4 = 0.0;
      string str4 = "";
      int num5 = 0;
      string str5 = "";
      string str6 = "";
      bool flag = false;
      string format1 = "";
      string format2 = "";
      string s = "";
      string str7 = "";
      int num6 = 0;
      try
      {
        if (this.err_utilerias_cmdaceptar_click > 0)
        {
          str7 = (string) this.localVars[15];
          s = (string) this.localVars[14];
          format2 = (string) this.localVars[13];
          format1 = (string) this.localVars[12];
          flag = (bool) this.localVars[11];
          str6 = (string) this.localVars[10];
          str5 = (string) this.localVars[9];
          num5 = (int) this.localVars[8];
          str4 = (string) this.localVars[7];
          num4 = (double) this.localVars[6];
          num3 = (int) this.localVars[5];
          num2 = (double) this.localVars[4];
          str3 = (string) this.localVars[3];
          str2 = (string) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_utilerias_cmdaceptar_click == 1)
          {
            this.err_utilerias_cmdaceptar_click = 0;
            this.__utilerias_closeconexionsqlite();
            ((int) MessageBox.Show("Error en cmdAceptar.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num6 = 1;
        str4 = DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + "-" + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul)) + "-" + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul));
        s = this.__utilerias_tprod.Text.Length.ToString((IFormatProvider) b4p.cul);
        double num7 = -1.0;
        double num8 = 0.0;
        for (double num9 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); (num7 > 0.0 ? (num9 <= num8 ? 1 : 0) : (num9 >= num8 ? 1 : 0)) != 0; s = (num9 += num7).ToString((IFormatProvider) b4p.cul))
        {
          if (this.Other.SubString(this.__utilerias_tprod.Text, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), 1) != " ")
          {
            str1 = this.Other.SubString(this.__utilerias_tprod.Text, 0, (int) ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0));
            break;
          }
        }
        if (this.__utilerias_tcant.Text.Replace(" ", "").Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("Capture la cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.Other.IsNumber(this.__utilerias_tcant.Text) == "false")
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La cantidad de ser número", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = double.Parse(this.__utilerias_tcant.Text, (IFormatProvider) b4p.cul);
        if (num1 <= 0.0)
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La cantidad no debe ser cero o menor a cero", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (num1 > 5000.0)
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La cantidad no debe ser mayor a 5000", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (str1.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La clave del artículo no deben quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = double.Parse(this.__utilerias_tcant.Text, (IFormatProvider) b4p.cul);
        str5 = this.var__mainmodule_empresa_origen;
        str6 = this.var__mainmodule_empresa_destino;
        flag = bool.Parse("false");
        str7 = "SELECT articulo, descrip FROM prods WHERE articulo = '" + str1 + "' OR ";
        str7 = str7 + "clavealterna = '" + str1 + "'";
        this.__mainmodule_cmd.CommandText = str7;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          flag = bool.Parse("true");
          str1 = this.__mainmodule_reader.GetValue(0);
        }
        else
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\bocina.wav"));
          Thread.Sleep(2000);
          this.__utilerias_tprod.Focus();
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(flag.ToString().ToLower(b4p.cul), "false"))
        {
          this.__utilerias_tprod.Text = "";
          this.__utilerias_pnltrans.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__utilerias_ltarttrans.Text = str1;
          this.__utilerias_pnltrans.BringToFront();
          this.__utilerias_tcant.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__utilerias_tprod.Enabled = bool.Parse("false".ToLower(b4p.cul));
          return "";
        }
        str7 = "INSERT INTO movsinv (Folio, articulo, cantidad, tiendaorigen, tiendadestino, ";
        str7 = str7 + "cancelado, nuevo, descrip, tipo, sistema, status) VALUES('" + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul) + "','" + str1 + "','";
        str7 = str7 + num1.ToString((IFormatProvider) b4p.cul) + "','" + str5 + "','" + str6 + "','N','S','";
        str7 = str7 + this.var__mainmodule_seriefolio + "','" + this.var__mainmodule_process + "','" + this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul) + "',' ')";
        this.__mainmodule_cmd.CommandText = str7;
        this.__mainmodule_cmd.ExecuteNonQuery();
        flag = bool.Parse("true");
        this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\msgbox.wav"));
        if (flag.ToString().ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          this.__utilerias_loadmovsinv();
        this.__utilerias_tcant.Text = "1";
        this.__utilerias_tprod.Text = "";
        this.__utilerias_tprod.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num6 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cmdaceptar_click = num6;
          this.localVars = new object[16]
          {
            (object) str1,
            (object) num1,
            (object) str2,
            (object) str3,
            (object) num2,
            (object) num3,
            (object) num4,
            (object) str4,
            (object) num5,
            (object) str5,
            (object) str6,
            (object) flag,
            (object) format1,
            (object) format2,
            (object) s,
            (object) str7
          };
          return this.__utilerias_cmdaceptar_click();
        }
        this.ShowError(ex, "_utilerias_cmdaceptar_click");
        return "";
      }
    }

    private string __utilerias_closeconexionsqlite()
    {
      int num = 0;
      try
      {
        if (this.err_utilerias_closeconexionsqlite > 0 && this.err_utilerias_closeconexionsqlite == 1)
        {
          this.err_utilerias_closeconexionsqlite = 0;
          return "";
        }
        num = 1;
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_closeconexionsqlite = num;
          this.localVars = new object[0];
          return this.__utilerias_closeconexionsqlite();
        }
        this.ShowError(ex, "_utilerias_closeconexionsqlite");
        return "";
      }
    }

    private string __utilerias_tprod_keypress(string var__utilerias_key)
    {
      int num = 0;
      try
      {
        if (this.err_utilerias_tprod_keypress > 0 && this.err_utilerias_tprod_keypress == 1)
        {
          this.err_utilerias_tprod_keypress = 0;
          ((int) MessageBox.Show("Error en keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__utilerias_key, '\r'.ToString((IFormatProvider) b4p.cul)) || this.LCompareEqual(var__utilerias_key, '\n'.ToString((IFormatProvider) b4p.cul)))
          this.__utilerias_cmdaceptar_click();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_tprod_keypress = num;
          this.localVars = new object[0];
          return this.__utilerias_tprod_keypress(var__utilerias_key);
        }
        this.ShowError(ex, "_utilerias_tprod_keypress");
        return "";
      }
    }

    private string __utilerias_inven_show()
    {
      try
      {
        string lower;
        this.__utilerias_ltfolio.Text = (lower = "D5".ToLower(b4p.cul))[0] != 'd' ? this.var__mainmodule_folio.ToString(lower, (IFormatProvider) b4p.cul) : ((int) this.var__mainmodule_folio).ToString(lower, (IFormatProvider) b4p.cul);
        this.__utilerias_tcant.Text = "1";
        this.__utilerias_loadmovsinv();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_inven_show");
        return "";
      }
    }

    private string __utilerias_btncanfolio1_click()
    {
      double num1 = 0.0;
      string str = "";
      string format = "";
      int num2 = 0;
      try
      {
        if (this.err_utilerias_btncanfolio1_click > 0)
        {
          format = (string) this.localVars[2];
          str = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_utilerias_btncanfolio1_click == 1)
          {
            this.err_utilerias_btncanfolio1_click = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num2 = 1;
        if (this.__utilerias_cbocanfolio.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor selecione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = double.Parse(this.Other.SubString(this.__utilerias_cbocanfolio.Items[(int) (double) this.__utilerias_cbocanfolio.SelectedIndex].ToString(), 2, 5), (IFormatProvider) b4p.cul);
        str = "UPDATE movsinv SET cancelado = 'C' WHERE folio = " + num1.ToString((IFormatProvider) b4p.cul) + " AND tipo = '" + this.var__mainmodule_process + "'";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_cmd.ExecuteNonQuery();
        ++this.var__mainmodule_folio;
        this.__utilerias_ltfolio.Text = (format = "D5".ToLower(b4p.cul))[0] != 'd' ? this.var__mainmodule_folio.ToString(format, (IFormatProvider) b4p.cul) : ((int) this.var__mainmodule_folio).ToString(format, (IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El folio " + this.__utilerias_cbocanfolio.Items[(int) (double) this.__utilerias_cbocanfolio.SelectedIndex].ToString() + " se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__utilerias_pnlcanfolio.Visible = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_btncanfolio1_click = num2;
          this.localVars = new object[3]
          {
            (object) num1,
            (object) str,
            (object) format
          };
          return this.__utilerias_btncanfolio1_click();
        }
        this.ShowError(ex, "_utilerias_btncanfolio1_click");
        return "";
      }
    }

    private string __utilerias_btncanfol2_click()
    {
      try
      {
        this.__utilerias_pnlcanfolio.Visible = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_btncanfol2_click");
        return "";
      }
    }

    private string __utilerias_mnumov_click()
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        if (this.err_utilerias_mnumov_click > 0)
        {
          num1 = (int) this.localVars[0];
          if (this.err_utilerias_mnumov_click == 1)
          {
            this.err_utilerias_mnumov_click = 0;
            ((int) MessageBox.Show("Error en cmdMovs.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        this.__utilerias_partinven.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_mnumov_click = num2;
          this.localVars = new object[1]{ (object) num1 };
          return this.__utilerias_mnumov_click();
        }
        this.ShowError(ex, "_utilerias_mnumov_click");
        return "";
      }
    }

    private string __utilerias_mnuenviar_click()
    {
      try
      {
        this.__utilerias_enviar.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_mnuenviar_click");
        return "";
      }
    }

    private string __utilerias_mnufin_click()
    {
      string str = "";
      string format = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_mnufin_click > 0)
        {
          format = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_utilerias_mnufin_click == 1)
          {
            this.err_utilerias_mnufin_click = 0;
            ((int) MessageBox.Show("Error en errmnuFin_Click.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        str = "UPDATE movsinv SET status = 'C'";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_cmd.ExecuteNonQuery();
        ++this.var__mainmodule_folio;
        this.__utilerias_ltfolio.Text = (format = "D5".ToLower(b4p.cul))[0] != 'd' ? this.var__mainmodule_folio.ToString(format, (IFormatProvider) b4p.cul) : ((int) this.var__mainmodule_folio).ToString(format, (IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__utilerias_inven.close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_mnufin_click = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) format
          };
          return this.__utilerias_mnufin_click();
        }
        this.ShowError(ex, "_utilerias_mnufin_click");
        return "";
      }
    }

    private string __utilerias_mnucanc_click()
    {
      try
      {
        this.__utilerias_canc.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_mnucanc_click");
        return "";
      }
    }

    private string __utilerias_mnucanfolio_click()
    {
      string str = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_mnucanfolio_click > 0)
        {
          str = (string) this.localVars[0];
          if (this.err_utilerias_mnucanfolio_click == 1)
          {
            this.err_utilerias_mnucanfolio_click = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num = 1;
        this.__utilerias_pnlcanfolio.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__utilerias_pnlcanfolio.Top = 0;
        this.__utilerias_pnlcanfolio.Left = 0;
        this.__utilerias_pnlcanfolio.Height = 235;
        this.__utilerias_pnlcanfolio.Width = 240;
        str = "SELECT folio FROM movsinv WHERE nuevo = 'S' AND cancelado = 'N' AND tipo = '" + this.var__mainmodule_process + "' GROUP BY folio ORDER BY folio DESC";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__utilerias_cbocanfolio.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__utilerias_cbocanfolio.Items.Add((object) (this.var__mainmodule_process + " " + this.__mainmodule_reader.GetValue(0)));
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_mnucanfolio_click = num;
          this.localVars = new object[1]{ (object) str };
          return this.__utilerias_mnucanfolio_click();
        }
        this.ShowError(ex, "_utilerias_mnucanfolio_click");
        return "";
      }
    }

    private string __utilerias_canc_show()
    {
      try
      {
        this.__utilerias_tart.Text = "";
        this.__utilerias_tblcanc.dataTable.Clear();
        this.__utilerias_tblcanc.dataTable.AcceptChanges();
        this.__utilerias_tart.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_canc_show");
        return "";
      }
    }

    private string __utilerias_canc_close()
    {
      try
      {
        this.__utilerias_loadmovsinv();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_canc_close");
        return "";
      }
    }

    private string __utilerias_tart_keypress(string var__utilerias_key)
    {
      int num = 0;
      try
      {
        if (this.err_utilerias_tart_keypress > 0 && this.err_utilerias_tart_keypress == 1)
        {
          this.err_utilerias_tart_keypress = 0;
          ((int) MessageBox.Show("Error en tArt_keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__utilerias_key, '\r'.ToString((IFormatProvider) b4p.cul)))
          this.__utilerias_bart();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_tart_keypress = num;
          this.localVars = new object[0];
          return this.__utilerias_tart_keypress(var__utilerias_key);
        }
        this.ShowError(ex, "_utilerias_tart_keypress");
        return "";
      }
    }

    private string __utilerias_cmdcbus_click()
    {
      try
      {
        this.__utilerias_bart();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cmdcbus_click");
        return "";
      }
    }

    private string __utilerias_cmdcanc1_click()
    {
      string str1 = "";
      int num1 = 0;
      string lSide = "";
      string str2 = "";
      int num2 = 0;
      try
      {
        if (this.err_utilerias_cmdcanc1_click > 0)
        {
          str2 = (string) this.localVars[3];
          lSide = (string) this.localVars[2];
          num1 = (int) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_utilerias_cmdcanc1_click == 1)
          {
            this.err_utilerias_cmdcanc1_click = 0;
            this.__utilerias_closeconexionsqlite();
            ((int) MessageBox.Show("Error en cmdCanc1.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        if ((double) this.__utilerias_tblcanc.CurrentCell.RowNumber < 0.0)
        {
          ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = (int) (double) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, false);
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
        {
          ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if ((string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, true) == "Cancelado")
        {
          ((int) MessageBox.Show("Esta partida esta cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str1 = (string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, true) + " - ";
        str1 = str1 + (string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, true) + " - ";
        str1 += (string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, true);
        lSide = ((int) MessageBox.Show("Desea eliminar partida " + str1 + " ?", "Josefina", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        str2 = "UPDATE movsinv SET cancelado = 'C' WHERE id = " + num1.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = str2;
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("Partida cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) this.__utilerias_tblcanc.CurrentCell.RowNumber, "Cancelado");
        this.__utilerias_canc.close();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cmdcanc1_click = num2;
          this.localVars = new object[4]
          {
            (object) str1,
            (object) num1,
            (object) lSide,
            (object) str2
          };
          return this.__utilerias_cmdcanc1_click();
        }
        this.ShowError(ex, "_utilerias_cmdcanc1_click");
        return "";
      }
    }

    private string __utilerias_cmdcanc2_click()
    {
      try
      {
        this.__utilerias_canc.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cmdcanc2_click");
        return "";
      }
    }

    private string __utilerias_enviar_show()
    {
      string str = "";
      string format = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_enviar_show > 0)
        {
          format = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_utilerias_enviar_show == 1)
          {
            this.err_utilerias_enviar_show = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num = 1;
        if (this.LCompareEqual(this.var__mainmodule_process, "P"))
        {
          this.__utilerias_label5.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__utilerias_ltenviar2.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__utilerias_label6.Text = "Tienda origen:";
        }
        else
        {
          this.__utilerias_label5.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__utilerias_ltenviar2.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__utilerias_label6.Text = "Gen. Compra en:";
        }
        str = "SELECT folio FROM movsinv WHERE cancelado = 'N' AND nuevo = 'S' AND tipo = '" + this.var__mainmodule_process + "' GROUP BY folio ORDER BY folio DESC";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__utilerias_cbofol.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__utilerias_cbofol.Items.Add((object) (this.var__mainmodule_process + " " + ((format = "D5".ToLower(b4p.cul))[0] != 'd' ? double.Parse(this.__mainmodule_reader.GetValue(0), (IFormatProvider) b4p.cul).ToString(format, (IFormatProvider) b4p.cul) : ((int) double.Parse(this.__mainmodule_reader.GetValue(0), (IFormatProvider) b4p.cul)).ToString(format, (IFormatProvider) b4p.cul))));
        this.__mainmodule_reader.Close();
        this.__utilerias_ltrutaenviar.Text = this.var__mainmodule_rutapc;
        this.__utilerias_ltenviar9.BringToFront();
        this.__utilerias_cbofol.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_enviar_show = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) format
          };
          return this.__utilerias_enviar_show();
        }
        this.ShowError(ex, "_utilerias_enviar_show");
        return "";
      }
    }

    private string __utilerias_cmdsend1_click()
    {
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      double num1 = 0.0;
      string str5 = "";
      string str6 = "";
      double num2 = 0.0;
      double num3 = 0.0;
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string str10 = "";
      string str11 = "";
      string str12 = "";
      string str13 = "";
      double num4 = 0.0;
      string str14 = "";
      string str15 = "";
      string lSide1 = "";
      double num5 = 0.0;
      string lSide2 = "";
      string str16 = "";
      string connectiondata = "";
      string str17 = "";
      string str18 = "";
      string format1 = "";
      string format2 = "";
      string str19 = "";
      string str20 = "";
      string str21 = "";
      string query = "";
      string format3 = "";
      int num6 = 0;
      try
      {
        if (this.err_utilerias_cmdsend1_click > 0)
        {
          format3 = (string) this.localVars[32];
          query = (string) this.localVars[31];
          str21 = (string) this.localVars[30];
          str20 = (string) this.localVars[29];
          str19 = (string) this.localVars[28];
          format2 = (string) this.localVars[27];
          format1 = (string) this.localVars[26];
          str18 = (string) this.localVars[25];
          str17 = (string) this.localVars[24];
          connectiondata = (string) this.localVars[23];
          str16 = (string) this.localVars[22];
          lSide2 = (string) this.localVars[21];
          num5 = (double) this.localVars[20];
          lSide1 = (string) this.localVars[19];
          str15 = (string) this.localVars[18];
          str14 = (string) this.localVars[17];
          num4 = (double) this.localVars[16];
          str13 = (string) this.localVars[15];
          str12 = (string) this.localVars[14];
          str11 = (string) this.localVars[13];
          str10 = (string) this.localVars[12];
          str9 = (string) this.localVars[11];
          str8 = (string) this.localVars[10];
          str7 = (string) this.localVars[9];
          num3 = (double) this.localVars[8];
          num2 = (double) this.localVars[7];
          str6 = (string) this.localVars[6];
          str5 = (string) this.localVars[5];
          num1 = (double) this.localVars[4];
          str4 = (string) this.localVars[3];
          str3 = (string) this.localVars[2];
          str2 = (string) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_utilerias_cmdsend1_click == 1)
          {
            this.err_utilerias_cmdsend1_click = 0;
            this.__utilerias_closeconexionsqlite();
            this.htStreams.Add((object) "_utilerias_c5", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR1.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_utilerias_c5"]).WriteLine(query);
            if (this.htStreams.Contains((object) "_utilerias_c5"))
            {
              ((IStream) this.htStreams[(object) "_utilerias_c5"]).Close();
              this.htStreams.Remove((object) "_utilerias_c5");
              GC.Collect();
            }
            return "";
          }
        }
        num6 = 1;
        int num7 = (int) MessageBox.Show("Desea realizar movimiento al inventario?", "Josefina", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        lSide2 = num7.ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide2, "7"))
          return "";
        if (this.__utilerias_cbofol.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str16 = this.Other.SubString(this.__utilerias_cbofol.Items[(int) (double) this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5);
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        connectiondata = "Persist Security Info=False;Integrated Security=False;";
        connectiondata = connectiondata + "Server=" + this.var__mainmodule_servertea + "," + this.var__mainmodule_porttea;
        connectiondata = connectiondata + ";initial catalog=" + this.var__mainmodule_basetea;
        connectiondata = connectiondata + ";user id=" + this.var__mainmodule_usertea;
        connectiondata = connectiondata + ";password=" + this.var__mainmodule_passtea + ";";
        if (this.__mainmodule_msql1.Open(connectiondata).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          ((int) MessageBox.Show("1.Imposible conectar al servidor " + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str5 = this.Other.SubString(this.__utilerias_ltenviar1.Text, 0, 2);
        str6 = this.Other.SubString(this.__utilerias_ltenviar2.Text, 0, 2);
        str17 = "1";
        str18 = "1";
        str7 = DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul)) + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul));
        str14 = this.__utilerias_ltenviar1.Text;
        if (this.LCompareEqual(this.var__mainmodule_process, "P"))
          str15 = this.__utilerias_ltenviar2.Text;
        lSide1 = "NO";
        num5 = 0.0;
        str19 = "SELECT M.folio, M.articulo, SUM(M.cantidad), MAX(P.costo_prom), MAX(P.linea), ";
        str19 += "MAX(P.descrip), MAX(sistema), MAX(tiendaorigen), MAX(tiendadestino) ";
        str19 += "FROM movsinv M INNER JOIN prods P ON P.articulo = M.articulo ";
        str19 = str19 + "WHERE folio = " + str16 + " AND M.nuevo = 'S' AND cancelado = 'N' AND ";
        str19 = str19 + "M.tipo = '" + this.var__mainmodule_process + "' GROUP BY M.folio, M.articulo";
        this.__mainmodule_cmd.CommandText = str19;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str4 = this.__mainmodule_reader.GetValue(1);
          num1 = double.Parse(this.__mainmodule_reader.GetValue(2), (IFormatProvider) b4p.cul);
          num3 = double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
          str1 = this.__mainmodule_reader.GetValue(5);
          this.var__mainmodule_sistema = double.Parse(this.__mainmodule_reader.GetValue(6), (IFormatProvider) b4p.cul);
          str20 = this.__mainmodule_reader.GetValue(7);
          str21 = this.__mainmodule_reader.GetValue(8);
          if (num2 > 300.0)
            num2 = 0.0;
          if (num3 > 300.0)
            num3 = 0.0;
          query = "IF NOT EXISTS (SELECT folio FROM pda WHERE folio = " + str16 + " AND serie = '" + this.var__mainmodule_process;
          query = query + "' AND articulo = '" + str4 + "') INSERT INTO pda (sucentrega, sucsolicita, serie, folio, ";
          query += "f_entrega, f_recepcion, articulo, clv_alter, cantidad, costo, precio, cantrecibida, hora, estatus, ";
          query += "tiporecep, usuario, descrip, estado3, cancelado, estacion3, solicita, recibe, alm1, alm2) ";
          query = query + "VALUES ('" + str14 + "','" + str15 + "','" + this.var__mainmodule_process + "','" + str16 + "','" + str7 + "','";
          query = query + str7 + "','" + str4 + "','" + str4 + "','" + num1.ToString((IFormatProvider) b4p.cul);
          query = query + "','" + num3.ToString((IFormatProvider) b4p.cul) + "','0','0',' ','0','" + this.var__mainmodule_process + "','BODEGA','";
          query = query + str1 + "','0','N','" + this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul) + "','" + str20 + "','" + str21 + "','";
          query = query + str17 + "','" + str18 + "')";
          if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
          {
            this.htStreams.Add((object) "_utilerias_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\" + this.var__mainmodule_servertea + " TRASPASOS MOVS PDA.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_utilerias_c1"]).WriteLine(query);
            ((TextWriter) this.htStreams[(object) "_utilerias_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
            if (this.htStreams.Contains((object) "_utilerias_c1"))
            {
              ((IStream) this.htStreams[(object) "_utilerias_c1"]).Close();
              this.htStreams.Remove((object) "_utilerias_c1");
              GC.Collect();
            }
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            ((int) MessageBox.Show("Problema en tabla PDA en " + this.var__mainmodule_servertea + " en linea 735", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            lSide1 = "SI";
            break;
          }
          query = "UPDATE movsinv SET nuevo = 'T' WHERE folio = " + str16 + " AND tipo = '" + this.var__mainmodule_process + "'";
          this.__mainmodule_cmd2.CommandText = query;
          this.__mainmodule_cmd2.ExecuteNonQuery();
          ++num5;
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_msql1.Close();
        if (this.LCompareEqual(lSide1, "SI"))
          return "";
        ++this.var__mainmodule_folio;
        CEnhancedLabel utileriasLtfolio = this.__utilerias_ltfolio;
        string str22;
        if ((format3 = "D5".ToLower(b4p.cul))[0] == 'd')
        {
          num7 = (int) this.var__mainmodule_folio;
          str22 = num7.ToString(format3, (IFormatProvider) b4p.cul);
        }
        else
          str22 = this.var__mainmodule_folio.ToString(format3, (IFormatProvider) b4p.cul);
        utileriasLtfolio.Text = str22;
        this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.ExecuteNonQuery();
        num7 = (int) MessageBox.Show("ok registros procesados " + num5.ToString((IFormatProvider) b4p.cul) + " siguiente folio " + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul), "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        num7.ToString((IFormatProvider) b4p.cul);
        this.__utilerias_enviar.close();
        this.__utilerias_inven.close();
        return "";
      }
      catch (Exception ex)
      {
        if (num6 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cmdsend1_click = num6;
          this.localVars = new object[33]
          {
            (object) str1,
            (object) str2,
            (object) str3,
            (object) str4,
            (object) num1,
            (object) str5,
            (object) str6,
            (object) num2,
            (object) num3,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) str10,
            (object) str11,
            (object) str12,
            (object) str13,
            (object) num4,
            (object) str14,
            (object) str15,
            (object) lSide1,
            (object) num5,
            (object) lSide2,
            (object) str16,
            (object) connectiondata,
            (object) str17,
            (object) str18,
            (object) format1,
            (object) format2,
            (object) str19,
            (object) str20,
            (object) str21,
            (object) query,
            (object) format3
          };
          return this.__utilerias_cmdsend1_click();
        }
        this.ShowError(ex, "_utilerias_cmdsend1_click");
        return "";
      }
    }

    private string __utilerias_cmdsend2_click()
    {
      try
      {
        this.__utilerias_enviar.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cmdsend2_click");
        return "";
      }
    }

    private string __utilerias_cmdimpor1_click()
    {
      int num1 = 0;
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      double num2 = 0.0;
      string str6 = "";
      double num3 = 0.0;
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string str10 = "";
      string str11 = "";
      string str12 = "";
      string str13 = "";
      string str14 = "";
      string str15 = "";
      string str16 = "";
      string str17 = "";
      int num4 = 0;
      try
      {
        if (this.err_utilerias_cmdimpor1_click > 0)
        {
          str17 = (string) this.localVars[19];
          str16 = (string) this.localVars[18];
          str15 = (string) this.localVars[17];
          str14 = (string) this.localVars[16];
          str13 = (string) this.localVars[15];
          str12 = (string) this.localVars[14];
          str11 = (string) this.localVars[13];
          str10 = (string) this.localVars[12];
          str9 = (string) this.localVars[11];
          str8 = (string) this.localVars[10];
          str7 = (string) this.localVars[9];
          num3 = (double) this.localVars[8];
          str6 = (string) this.localVars[7];
          num2 = (double) this.localVars[6];
          str5 = (string) this.localVars[5];
          str4 = (string) this.localVars[4];
          str3 = (string) this.localVars[3];
          str2 = (string) this.localVars[2];
          str1 = (string) this.localVars[1];
          num1 = (int) this.localVars[0];
          if (this.err_utilerias_cmdimpor1_click == 1)
          {
            this.err_utilerias_cmdimpor1_click = 0;
            this.__utilerias_closeconexionsqlite();
            ((int) MessageBox.Show("Error en importar " + str12, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            this.htStreams.Add((object) "_utilerias_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVEN.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_utilerias_c1"]).WriteLine(str12);
            if (this.htStreams.Contains((object) "_utilerias_c1"))
            {
              ((IStream) this.htStreams[(object) "_utilerias_c1"]).Close();
              this.htStreams.Remove((object) "_utilerias_c1");
              GC.Collect();
            }
            return "";
          }
        }
        num4 = 1;
        if (this.__utilerias_cbotiendaorigen.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una sucursal origen", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__utilerias_cbotiendadestino.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una sucursal destino", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str11 = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[(int) (double) this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
        this.var__mainmodule_empresa_origen = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[(int) (double) this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
        this.var__mainmodule_empresa_destino = this.Other.SubString(this.__utilerias_cbotiendadestino.Items[(int) (double) this.__utilerias_cbotiendadestino.SelectedIndex].ToString(), 0, 2);
        str12 = "SELECT servidor, base, usuario, pass, puerto, nombre, ctrl_alm, almacen, ";
        str12 += "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '02'";
        this.__mainmodule_cmd.CommandText = str12;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str13 = this.__mainmodule_reader.GetValue(0);
          str14 = this.__mainmodule_reader.GetValue(1);
          str15 = this.__mainmodule_reader.GetValue(2);
          str16 = this.__mainmodule_reader.GetValue(3);
          str17 = this.__mainmodule_reader.GetValue(4);
        }
        else
        {
          str13 = "";
          str14 = "";
          str15 = "";
          str16 = "";
          str17 = "";
        }
        this.__mainmodule_reader.Close();
        this.__utilerias_ltserver9.Text = str13 + ", " + str14 + ", " + str15 + ", " + str16 + ", " + str17;
        this.__utilerias_ltimport11.Text = "";
        this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\button2.wav"));
        Thread.Sleep(2000);
        this.__utilerias_importa.close();
        this.__utilerias_inven.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num4 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cmdimpor1_click = num4;
          this.localVars = new object[20]
          {
            (object) num1,
            (object) str1,
            (object) str2,
            (object) str3,
            (object) str4,
            (object) str5,
            (object) num2,
            (object) str6,
            (object) num3,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) str10,
            (object) str11,
            (object) str12,
            (object) str13,
            (object) str14,
            (object) str15,
            (object) str16,
            (object) str17
          };
          return this.__utilerias_cmdimpor1_click();
        }
        this.ShowError(ex, "_utilerias_cmdimpor1_click");
        return "";
      }
    }

    private string __utilerias_cmdimpor2_click()
    {
      try
      {
        this.__utilerias_importa.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cmdimpor2_click");
        return "";
      }
    }

    private string __utilerias_importa_show()
    {
      string lSide = "";
      string s = "";
      int num1 = 0;
      try
      {
        if (this.err_utilerias_importa_show > 0)
        {
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_utilerias_importa_show == 1)
          {
            this.err_utilerias_importa_show = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num1 = 1;
        this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre FROM empresas ORDER BY empresa";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__utilerias_cbotiendaorigen.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          this.__utilerias_cbotiendaorigen.Items.Add((object) (this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1)));
        this.__mainmodule_reader.Close();
        if ((double) this.var__mainmodule_empresapred.Length > 0.0)
        {
          s = "0";
          double num2 = (double) this.__utilerias_cbotiendaorigen.Items.Count - 1.0;
          for (double num3 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider) b4p.cul))
          {
            lSide = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul)].ToString(), 0, 2);
            if (this.CompareEqual(lSide, this.var__mainmodule_empresapred))
            {
              this.__utilerias_cbotiendaorigen.SelectedIndex = s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul);
              break;
            }
          }
          this.__utilerias_cbotiendaorigen.Enabled = bool.Parse("false".ToLower(b4p.cul));
        }
        else
          this.__utilerias_cbotiendaorigen.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__utilerias_ltdestino1.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__utilerias_cbotiendadestino.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.var__mainmodule_process = "P";
        this.__utilerias_ltorigen1.BringToFront();
        this.__utilerias_cbotiendaorigen.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num1 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_importa_show = num1;
          this.localVars = new object[2]
          {
            (object) lSide,
            (object) s
          };
          return this.__utilerias_importa_show();
        }
        this.ShowError(ex, "_utilerias_importa_show");
        return "";
      }
    }

    private string __utilerias_cbotiendaorigen_selectionchanged(
      string var__utilerias_index,
      string var__utilerias_value)
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_cbotiendaorigen_selectionchanged > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_utilerias_cbotiendaorigen_selectionchanged == 1)
          {
            this.err_utilerias_cbotiendaorigen_selectionchanged = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num = 1;
        if (this.__utilerias_cbotiendaorigen.SelectedIndex.ToString((IFormatProvider) b4p.cul) != -1.0.ToString((IFormatProvider) b4p.cul))
        {
          lSide = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[(int) (double) this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
          this.__utilerias_cbotiendadestino.Items.Clear();
          this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre, multialmacen, servidor, base, usuario, pass FROM empresas ORDER BY empresa";
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            if (this.__utilerias_cbotiendaorigen.Items[(int) (double) this.__utilerias_cbotiendaorigen.SelectedIndex].ToString() != this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1))
              this.__utilerias_cbotiendadestino.Items.Add((object) (this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1)));
            if (this.LCompareEqual(lSide, this.__mainmodule_reader.GetValue(0)))
              this.__utilerias_ltimport11.Text = this.__mainmodule_reader.GetValue(3) + ", " + this.__mainmodule_reader.GetValue(4) + ", " + this.__mainmodule_reader.GetValue(5) + ", " + this.__mainmodule_reader.GetValue(6);
          }
          this.__mainmodule_reader.Close();
        }
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cbotiendaorigen_selectionchanged = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__utilerias_cbotiendaorigen_selectionchanged(var__utilerias_index, var__utilerias_value);
        }
        this.ShowError(ex, "_utilerias_cbotiendaorigen_selectionchanged");
        return "";
      }
    }

    private string __utilerias_loadmovsinv()
    {
      double num1 = 0.0;
      string str = "";
      string s = "";
      int num2 = 0;
      try
      {
        if (this.err_utilerias_loadmovsinv > 0)
        {
          s = (string) this.localVars[2];
          str = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_utilerias_loadmovsinv == 1)
          {
            this.err_utilerias_loadmovsinv = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num2 = 1;
        str = "SELECT M.articulo, P.descrip, SUM(M.cantidad) AS cant FROM movsinv M ";
        str += "LEFT JOIN prods P ON P.articulo = M.articulo WHERE ";
        str = str + "folio = " + this.var__mainmodule_folio.ToString((IFormatProvider) b4p.cul) + " AND M.nuevo = 'S' AND M.cancelado = 'N' ";
        str = str + "AND tipo = '" + this.var__mainmodule_process + "' GROUP BY M.articulo";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__utilerias_tbltea.dataTable.Clear();
        this.__utilerias_tbltea.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__utilerias_tbltea.AddRow(new object[0]);
          s = ((double) this.__utilerias_tbltea.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
          this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(2));
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_loadmovsinv = num2;
          this.localVars = new object[3]
          {
            (object) num1,
            (object) str,
            (object) s
          };
          return this.__utilerias_loadmovsinv();
        }
        this.ShowError(ex, "_utilerias_loadmovsinv");
        return "";
      }
    }

    private string __utilerias_bart()
    {
      string str1 = "";
      int row = 0;
      string str2 = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_bart > 0)
        {
          str2 = (string) this.localVars[2];
          row = (int) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_utilerias_bart == 1)
          {
            this.err_utilerias_bart = 0;
            this.__utilerias_closeconexionsqlite();
            ((int) MessageBox.Show("Error en BArt.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        str1 = this.__utilerias_tart.Text.Replace(" ", "");
        if (str1.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("La clave del articulo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str2 = "SELECT M.id, M.folio, M.articulo, P.descrip, M.cantidad, M.cancelado ";
        str2 += "FROM movsinv M INNER JOIN prods P ON P.articulo = M.articulo ";
        str2 = str2 + "WHERE (M.articulo = '" + str1 + "' OR clavealterna = '" + str1 + "') AND ";
        str2 = str2 + "folio = " + this.__utilerias_ltfolio.Text + " ORDER BY M.id";
        this.__mainmodule_cmd.CommandText = str2;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__utilerias_tblcanc.dataTable.Clear();
        this.__utilerias_tblcanc.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__utilerias_tblcanc.AddRow(new object[0]);
          row = (int) ((double) this.__utilerias_tblcanc.dataTable.DefaultView.Count - 1.0);
          this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(0));
          this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(1));
          this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(2));
          this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(3));
          if (this.__mainmodule_reader.GetValue(5) == "C")
            this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) row, "Cancelado");
          this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[5].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(4));
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_bart = num;
          this.localVars = new object[3]
          {
            (object) str1,
            (object) row,
            (object) str2
          };
          return this.__utilerias_bart();
        }
        this.ShowError(ex, "_utilerias_bart");
        return "";
      }
    }

    private string __utilerias_cbofol_selectionchanged(
      string var__utilerias_index,
      string var__utilerias_value)
    {
      double num1 = 0.0;
      string s = "";
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string lSide1 = "";
      string rSide1 = "";
      string lSide2 = "";
      string rSide2 = "";
      int num2 = 0;
      try
      {
        if (this.err_utilerias_cbofol_selectionchanged > 0)
        {
          rSide2 = (string) this.localVars[8];
          lSide2 = (string) this.localVars[7];
          rSide1 = (string) this.localVars[6];
          lSide1 = (string) this.localVars[5];
          str3 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          str1 = (string) this.localVars[2];
          s = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_utilerias_cbofol_selectionchanged == 1)
          {
            this.err_utilerias_cbofol_selectionchanged = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num2 = 1;
        if (this.__utilerias_cbofol.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        s = this.Other.SubString(this.__utilerias_cbofol.Items[(int) (double) this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5);
        if (this.Other.IsNumber(s) == "false")
          return "";
        num1 = double.Parse(this.Other.SubString(this.__utilerias_cbofol.Items[(int) (double) this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5), (IFormatProvider) b4p.cul);
        str1 = "SELECT tiendaorigen, tiendadestino FROM movsinv WHERE folio = " + num1.ToString((IFormatProvider) b4p.cul) + " AND tipo = '" + this.var__mainmodule_process + "'";
        this.__mainmodule_cmd.CommandText = str1;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str2 = this.__mainmodule_reader.GetValue(0);
          str3 = this.__mainmodule_reader.GetValue(1);
          this.__utilerias_ltenviar1.Text = str2;
          this.__utilerias_ltenviar2.Text = str3;
        }
        this.__mainmodule_reader.Close();
        str1 = "SELECT empresa, nombre, multialmacen FROM empresas";
        this.__mainmodule_cmd.CommandText = str1;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          lSide1 = this.__utilerias_ltenviar1.Text;
          rSide1 = this.__mainmodule_reader.GetValue(0);
          if (this.CompareEqual(lSide1, rSide1))
            this.__utilerias_ltenviar1.Text = this.__mainmodule_reader.GetValue(0) + " " + this.__mainmodule_reader.GetValue(1);
          lSide2 = this.__utilerias_ltenviar2.Text;
          rSide2 = this.__mainmodule_reader.GetValue(0);
          if (this.CompareEqual(lSide2, rSide2))
            this.__utilerias_ltenviar2.Text = this.__mainmodule_reader.GetValue(0) + " " + this.__mainmodule_reader.GetValue(1);
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cbofol_selectionchanged = num2;
          this.localVars = new object[9]
          {
            (object) num1,
            (object) s,
            (object) str1,
            (object) str2,
            (object) str3,
            (object) lSide1,
            (object) rSide1,
            (object) lSide2,
            (object) rSide2
          };
          return this.__utilerias_cbofol_selectionchanged(var__utilerias_index, var__utilerias_value);
        }
        this.ShowError(ex, "_utilerias_cbofol_selectionchanged");
        return "";
      }
    }

    private string __utilerias_cmdaceptar_keypress(string var__utilerias_key)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cmdaceptar_keypress");
        return "";
      }
    }

    private string __utilerias_btntrans_click()
    {
      try
      {
        this.__utilerias_pnltrans.Visible = bool.Parse("false".ToLower(b4p.cul));
        this.__utilerias_tcant.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__utilerias_tprod.Enabled = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_btntrans_click");
        return "";
      }
    }

    private string __utilerias_cbocanfolio_selectionchanged(
      string var__utilerias_index,
      string var__utilerias_value)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_cbocanfolio_selectionchanged");
        return "";
      }
    }

    private string __utilerias_cbotiendadestino_selectionchanged(
      string var__utilerias_index,
      string var__utilerias_value)
    {
      string str = "";
      int num = 0;
      try
      {
        if (this.err_utilerias_cbotiendadestino_selectionchanged > 0)
        {
          str = (string) this.localVars[0];
          if (this.err_utilerias_cbotiendadestino_selectionchanged == 1)
          {
            this.err_utilerias_cbotiendadestino_selectionchanged = 0;
            this.__utilerias_closeconexionsqlite();
            return "";
          }
        }
        num = 1;
        if (this.__utilerias_cbotiendadestino.SelectedIndex.ToString((IFormatProvider) b4p.cul) != -1.0.ToString((IFormatProvider) b4p.cul))
        {
          str = this.Other.SubString(this.__utilerias_cbotiendadestino.Items[(int) (double) this.__utilerias_cbotiendadestino.SelectedIndex].ToString(), 0, 2);
          this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre, multialmacen, servidor, base, usuario, pass  FROM empresas WHERE empresa = '" + str + "'";
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
            this.__utilerias_ltserver9.Text = this.__mainmodule_reader.GetValue(3) + ", " + this.__mainmodule_reader.GetValue(4) + ", " + this.__mainmodule_reader.GetValue(5) + ", " + this.__mainmodule_reader.GetValue(6);
          this.__mainmodule_reader.Close();
        }
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_utilerias_cbotiendadestino_selectionchanged = num;
          this.localVars = new object[1]{ (object) str };
          return this.__utilerias_cbotiendadestino_selectionchanged(var__utilerias_index, var__utilerias_value);
        }
        this.ShowError(ex, "_utilerias_cbotiendadestino_selectionchanged");
        return "";
      }
    }

    private string __utilerias_mnucantea_click()
    {
      try
      {
        this.__utilerias_cmdcanc1_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_mnucantea_click");
        return "";
      }
    }

    private string __utilerias_tcant_keypress(string var__utilerias_key)
    {
      try
      {
        if (this.LCompareEqual(var__utilerias_key, '\r'.ToString((IFormatProvider) b4p.cul)) || this.LCompareEqual(var__utilerias_key, '\n'.ToString((IFormatProvider) b4p.cul)))
          this.__utilerias_tprod.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_tcant_keypress");
        return "";
      }
    }

    private string __utilerias_partinven_show()
    {
      try
      {
        this.__utilerias_cbomovfol.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_utilerias_partinven_show");
        return "";
      }
    }

    private string __mainmodule_app_start()
    {
      double num1 = 0.0;
      string str = "";
      double num2 = 0.0;
      string format = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_app_start > 0)
        {
          format = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          str = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_app_start == 1)
          {
            this.err_mainmodule_app_start = 0;
            ((int) MessageBox.Show(": ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        this.dateFormat = "dd-mm-yyyy".ToLower(b4p.cul).Replace("m", "M");
        num3 = 1;
        this.var__mainmodule_process = "P";
        this.var__mainmodule_rutapc = " ";
        this.var__mainmodule_wifilocation = this.b4pdir + "\\inventmobile.db";
        if (File.Exists(Path.Combine(this.b4pdir, this.var__mainmodule_wifilocation)).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          ((int) MessageBox.Show("No existe la base de datos comuniquelo con el supervisor", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          if (this.mainForm != null)
            this.mainForm.Close();
          else
            this.CloseProgram();
          return "";
        }
        if (this.htControls[(object) "__mainmodule_con"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_con"]);
        this.__mainmodule_con = new Connection();
        this.htControls[(object) "__mainmodule_con"] = (object) this.__mainmodule_con;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_con] = (object) "__mainmodule_con";
        if (this.htControls[(object) "__mainmodule_reader"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_reader"]);
        this.__mainmodule_reader = new DataReader();
        this.htControls[(object) "__mainmodule_reader"] = (object) this.__mainmodule_reader;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_reader] = (object) "__mainmodule_reader";
        if (this.htControls[(object) "__mainmodule_reader2"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_reader2"]);
        this.__mainmodule_reader2 = new DataReader();
        this.htControls[(object) "__mainmodule_reader2"] = (object) this.__mainmodule_reader2;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_reader2] = (object) "__mainmodule_reader2";
        if (this.htControls[(object) "__mainmodule_cmd"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_cmd"]);
        this.__mainmodule_cmd = new B4PSQL.Command("", this.__mainmodule_con.Value);
        this.htControls[(object) "__mainmodule_cmd"] = (object) this.__mainmodule_cmd;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_cmd] = (object) "__mainmodule_cmd";
        if (this.htControls[(object) "__mainmodule_cmd2"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_cmd2"]);
        this.__mainmodule_cmd2 = new B4PSQL.Command("", this.__mainmodule_con.Value);
        this.htControls[(object) "__mainmodule_cmd2"] = (object) this.__mainmodule_cmd2;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_cmd2] = (object) "__mainmodule_cmd2";
        this.__mainmodule_con.Open("Data Source = " + this.var__mainmodule_wifilocation);
        if (this.htControls[(object) "__mainmodule_flb"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_flb"]);
        this.__mainmodule_flb = new FormLib.FormLib((Form) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "main"), (object) this);
        this.htControls[(object) "__mainmodule_flb"] = (object) this.__mainmodule_flb;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_flb] = (object) "__mainmodule_flb";
        this.__mainmodule_flb.SetPasswordTextBox((TextBox) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "tPassword"));
        this.__mainmodule_flb.SetPasswordTextBox((TextBox) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "tLogin"));
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtSocial"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtInven"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtSumCan2"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtSum2"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtE"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtPrec"), (int) (double) this.__mainmodule_flb.alCenter);
        this.__mainmodule_flb.SetFontStyle((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtInven"), bool.Parse("true".ToLower(b4p.cul)), bool.Parse("false".ToLower(b4p.cul)), bool.Parse("false".ToLower(b4p.cul)), bool.Parse("false".ToLower(b4p.cul)));
        this.__mainmodule_flb.ChangeFont((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "LtInven"), "Arial Black");
        this.__mainmodule_creatablaarea();
        this.__mainmodule_addfield();
        this.__mainmodule_cboempresa.Items.Clear();
        this.__mainmodule_cmd.CommandText = "SELECT empresa FROM empresas ORDER BY empresa";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_cboempresa.Items.Add((object) this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_cbotiendaorigen.Items.Add((object) this.__mainmodule_reader.GetValue(0));
        }
        this.__mainmodule_reader.Close();
        this.var__mainmodule_sistema = 1.0;
        this.var__mainmodule_seriefolio = "A";
        this.var__mainmodule_folioped = 1.0;
        this.var__mainmodule_empresapred = "";
        this.var__mainmodule_sql = "SELECT puerto, folio, port, server, base, user, pass, sistema, seriecompra, foliocompra, folioped, seriepedido, empresapred FROM config";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_port = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(0)).ToLower(b4p.cul) == "true") ? "1433" : this.__mainmodule_reader.GetValue(0);
          this.var__mainmodule_folio = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 1.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          this.var__mainmodule_servertea = this.__mainmodule_reader.GetValue(3);
          this.var__mainmodule_basetea = this.__mainmodule_reader.GetValue(4);
          this.var__mainmodule_usertea = this.__mainmodule_reader.GetValue(5);
          this.var__mainmodule_passtea = this.__mainmodule_reader.GetValue(6);
          this.var__mainmodule_porttea = this.__mainmodule_reader.GetValue(2);
          if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(7)).ToLower(b4p.cul) == "true")
            this.var__mainmodule_sistema = double.Parse(this.__mainmodule_reader.GetValue(7), (IFormatProvider) b4p.cul);
          this.var__mainmodule_seriecompra = this.__mainmodule_reader.GetValue(8);
          this.var__mainmodule_foliocompra = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(9)).ToLower(b4p.cul) == "true") ? 1.0 : double.Parse(this.__mainmodule_reader.GetValue(9), (IFormatProvider) b4p.cul);
          this.var__mainmodule_folioped = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(10)).ToLower(b4p.cul) == "true") ? 1.0 : double.Parse(this.__mainmodule_reader.GetValue(10), (IFormatProvider) b4p.cul);
          this.var__mainmodule_seriepedido = "" + this.__mainmodule_reader.GetValue(11);
          this.var__mainmodule_empresapred = "" + this.__mainmodule_reader.GetValue(12);
          if (this.LCompareEqual(this.var__mainmodule_empresapred, "Ninguna"))
            this.var__mainmodule_empresapred = "";
        }
        else
        {
          this.var__mainmodule_port = "COM5";
          this.var__mainmodule_folio = 1.0;
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul), "1"))
          this.__mainmodule_chcaja.Checked = bool.Parse("false".ToLower(b4p.cul));
        else
          this.__mainmodule_chcaja.Checked = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_pnlred.Top = 0;
        this.__mainmodule_pnlred.Left = 0;
        this.__mainmodule_pnlred.Height = 245;
        this.__mainmodule_pnlred.Width = 270;
        this.__mainmodule_tabla.TableStyles[0].HeaderBackColor = Color.FromArgb(100, 200, 222);
        this.__mainmodule_tabla.AddCol(typeof (string), "Clave", 37, false);
        this.__mainmodule_tabla.AddCol(typeof (string), "Nombre", 150, false);
        this.__mainmodule_tabla.AddCol(typeof (string), "R.F.C.", 50, false);
        this.__mainmodule_tabla.AddCol(typeof (string), "Dirección", 80, false);
        this.__mainmodule_tabla.AddCol(typeof (string), "Teléfono", 35, false);
        this.__mainmodule_tabla.AddCol(typeof (string), "Ciudad", 50, false);
        this.__mainmodule_pnlpedidos.Top = 0;
        this.__mainmodule_pnlpedidos.Left = 0;
        this.__mainmodule_pnlpedidos.Width = 240;
        this.__mainmodule_pnlpedidos.Height = 190;
        this.__utilerias_pnltrans.Top = 0;
        this.__utilerias_pnltrans.Left = 0;
        this.__utilerias_pnltrans.Height = 245;
        this.__utilerias_pnltrans.Width = 270;
        this.__mainmodule_tblprod.Top = 30;
        this.__mainmodule_tblprod.Left = 3;
        this.__mainmodule_tblprod.Height = 235;
        this.__mainmodule_tblprod.Width = 236;
        this.__mainmodule_tblprod.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tblprod.AddCol(typeof (string), "Articulo", 65, false);
        this.__mainmodule_tblprod.AddCol(typeof (string), "Descripción", 90, false);
        this.__mainmodule_tblprod.AddCol(typeof (string), "Exist", 40, false);
        this.__mainmodule_tblprod.AddCol(typeof (string), "Inv.Fisico", 40, false);
        this.__mainmodule_tbcaninven.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tbcaninven.AddCol(typeof (string), "id", 0, false);
        this.__mainmodule_tbcaninven.AddCol(typeof (string), "Usuario", 40, false);
        this.__mainmodule_tbcaninven.AddCol(typeof (string), "Articulo", 80, false);
        this.__mainmodule_tbcaninven.AddCol(typeof (string), "Cantidad", 50, false);
        this.__mainmodule_tbcaninven.AddCol(typeof (string), "Estado", 40, false);
        this.__mainmodule_tbluser.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tbluser.AddCol(typeof (string), "id", 0, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Usuario", 60, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Nombre", 120, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Contraseña", 60, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Nivel", 60, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Serie", 60, false);
        this.__mainmodule_tbluser.AddCol(typeof (string), "Folio", 70, false);
        this.__mainmodule_tblcompras.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tblcompras.AddCol(typeof (string), "Articulo", 50, false);
        this.__mainmodule_tblcompras.AddCol(typeof (string), "Descripción", 135, false);
        this.__mainmodule_tblcompras.AddCol(typeof (string), "Cant", 40, false);
        this.__mainmodule_tblpedidos.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tblpedidos.AddCol(typeof (string), "Articulo", 50, false);
        this.__mainmodule_tblpedidos.AddCol(typeof (string), "Descripción", 135, false);
        this.__mainmodule_tblpedidos.AddCol(typeof (string), "Cant", 40, false);
        this.__mainmodule_tblexisxlinea.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tblexisxlinea.AddCol(typeof (string), "No.", 35, false);
        this.__mainmodule_tblexisxlinea.AddCol(typeof (string), "Nombre", 100, false);
        this.__mainmodule_tblexisxlinea.AddCol(typeof (string), "Cant", 70, false);
        this.__utilerias_fgprod.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__utilerias_fgprod.AddCol(typeof (string), "Folio", 25, false);
        this.__utilerias_fgprod.AddCol(typeof (string), "Clave", 65, false);
        this.__utilerias_fgprod.AddCol(typeof (string), "Descripción", 160, false);
        this.__utilerias_fgprod.AddCol(typeof (string), "Cant.", 35, false);
        this.__utilerias_fgprod.AddCol(typeof (string), "id.", 0, false);
        this.__utilerias_tbltea.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__utilerias_tbltea.AddCol(typeof (string), "Articulo", 40, false);
        this.__utilerias_tbltea.AddCol(typeof (string), "Descripción", 135, false);
        this.__utilerias_tbltea.AddCol(typeof (string), "Cant.", 45, false);
        this.__utilerias_tblcanc.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__utilerias_tblcanc.AddCol(typeof (string), "id", 0, false);
        this.__utilerias_tblcanc.AddCol(typeof (string), "Folio", 30, false);
        this.__utilerias_tblcanc.AddCol(typeof (string), "Articulo", 40, false);
        this.__utilerias_tblcanc.AddCol(typeof (string), "Descripcion", 80, false);
        this.__utilerias_tblcanc.AddCol(typeof (string), "Estado", 40, false);
        this.__utilerias_tblcanc.AddCol(typeof (string), "Cantidad", 30, false);
        this.__mainmodule_tblareas.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tblareas.AddCol(typeof (string), "id", 35, false);
        this.__mainmodule_tblareas.AddCol(typeof (string), "Area", 0, false);
        this.__mainmodule_tblareas.AddCol(typeof (string), "Nombre", 160, false);
        this.__mainmodule_pnlareasseries.Top = 0;
        this.__mainmodule_pnlareasseries.Left = 0;
        this.__mainmodule_pnlareasseries.Width = 240;
        this.__mainmodule_pnlareasseries.Height = 195;
        this.__mainmodule_pnltoper.Top = 0;
        this.__mainmodule_pnltoper.Left = 0;
        this.__mainmodule_pnltoper.Width = 239;
        this.__mainmodule_pnltoper.Height = 246;
        this.__mainmodule_tbltoper.TableStyles[0].HeaderBackColor = Color.FromArgb(93, 194, (int) byte.MaxValue);
        this.__mainmodule_tbltoper.AddCol(typeof (string), "id", 0, false);
        this.__mainmodule_tbltoper.AddCol(typeof (string), "Articulo", 160, false);
        this.__mainmodule_tbltoper.AddCol(typeof (string), "Cant.", 40, false);
        num1 = 1.0;
        double num4 = 900.0;
        for (double num5 = num1; num5 <= num4; num1 = ++num5)
          this.__mainmodule_cboseriesareas.Items.Add((format = "D2".ToLower(b4p.cul))[0] != 'd' ? (object) num1.ToString(format, (IFormatProvider) b4p.cul) : (object) ((int) num1).ToString(format, (IFormatProvider) b4p.cul));
        if (this.htControls[(object) "__mainmodule_listcte"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_listcte"]);
        this.__mainmodule_listcte = new bList((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", (object) "frmClientes"));
        this.htControls[(object) "__mainmodule_listcte"] = (object) this.__mainmodule_listcte;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_listcte] = (object) "__mainmodule_listcte";
        this.__mainmodule_listcte.Click += new EventHandler(this.CEnhancedObject.MetapelEruim);
        if (this.htControls[(object) "__mainmodule_item"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_item"]);
        this.__mainmodule_item = new bListItem();
        this.htControls[(object) "__mainmodule_item"] = (object) this.__mainmodule_item;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_item] = (object) "__mainmodule_item";
        this.__mainmodule_main.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_app_start = num3;
          this.localVars = new object[4]
          {
            (object) num1,
            (object) str,
            (object) num2,
            (object) format
          };
          return this.__mainmodule_app_start();
        }
        this.ShowError(ex, "_mainmodule_app_start");
        return "";
      }
    }

    private string __mainmodule_creatablaarea()
    {
      string str = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_creatablaarea > 0)
        {
          str = (string) this.localVars[0];
          if (this.err_mainmodule_creatablaarea == 1)
          {
            this.err_mainmodule_creatablaarea = 0;
            return "";
          }
        }
        num = 1;
        str = "CREATE Table IF NOT EXISTS [areas] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[area] VARCHAR(5) NULL,[nombre] VARCHAR(40) NULL)";
        this.__mainmodule_cmd.CommandText = str;
        this.__mainmodule_cmd.ExecuteNonQuery();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_creatablaarea = num;
          this.localVars = new object[1]{ (object) str };
          return this.__mainmodule_creatablaarea();
        }
        this.ShowError(ex, "_mainmodule_creatablaarea");
        return "";
      }
    }

    private string __mainmodule_addfield()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_addfield > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_addfield == 1)
          {
            this.err_mainmodule_addfield = 0;
            return "";
          }
        }
        num = 1;
        this.var__mainmodule_sql = "PRAGMA table_info('minve')";
        lSide = "";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        lSide = "N";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          if (this.__mainmodule_reader.GetValue(1) == "idArea")
            lSide = "S";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(lSide, "N"))
        {
          this.__mainmodule_cmd.CommandText = "ALTER TABLE minve ADD COLUMN idArea Integer NULL";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        this.var__mainmodule_sql = "PRAGMA table_info('monsinv')";
        lSide = "";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        lSide = "N";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          if (this.__mainmodule_reader.GetValue(1) == "status")
            lSide = "S";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(lSide, "N"))
        {
          this.__mainmodule_cmd.CommandText = "ALTER TABLE movsinv ADD COLUMN status VARCHARA(1) default ' ' NULL";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        this.var__mainmodule_sql = "PRAGMA table_info('config')";
        lSide = "";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        lSide = "N";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          if (this.__mainmodule_reader.GetValue(1) == "empresapred")
            lSide = "S";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(lSide, "N"))
        {
          this.__mainmodule_cmd.CommandText = "ALTER TABLE config ADD COLUMN empresapred varchar(10) NULL";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_addfield = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_addfield();
        }
        this.ShowError(ex, "_mainmodule_addfield");
        return "";
      }
    }

    private string __mainmodule_timer1_tick()
    {
      try
      {
        this.var__mainmodule_twifi = ((this.var__mainmodule_twifi == "" ? 0.0 : double.Parse(this.var__mainmodule_twifi, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_timer1_tick");
        return "";
      }
    }

    private string __mainmodule_tblprod_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_tblprod_selectionchanged > 0 && this.err_mainmodule_tblprod_selectionchanged == 1)
        {
          this.err_mainmodule_tblprod_selectionchanged = 0;
          return "";
        }
        num = 1;
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tblprod_selectionchanged = num;
          this.localVars = new object[0];
          return this.__mainmodule_tblprod_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
        }
        this.ShowError(ex, "_mainmodule_tblprod_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_partinven_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_partinven_close");
        return "";
      }
    }

    private string __mainmodule_mnuenviar_click()
    {
      try
      {
        this.__mainmodule_enviar.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuenviar_click");
        return "";
      }
    }

    private string __mainmodule_centra(string var__mainmodule_fdato)
    {
      int count = 0;
      string original = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_centra > 0)
        {
          original = (string) this.localVars[1];
          count = (int) this.localVars[0];
          if (this.err_mainmodule_centra == 1)
          {
            this.err_mainmodule_centra = 0;
            return "";
          }
        }
        num = 1;
        count = (int) ((32.0 - (double) var__mainmodule_fdato.Length) / 2.0);
        original = "                                   ";
        return this.Other.SubString(original, 0, (int) (double) count) + var__mainmodule_fdato;
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_centra = num;
          this.localVars = new object[2]
          {
            (object) count,
            (object) original
          };
          return this.__mainmodule_centra(var__mainmodule_fdato);
        }
        this.ShowError(ex, "_mainmodule_centra");
        return "";
      }
    }

    private string __mainmodule_config_show()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_config_show > 0 && this.err_mainmodule_config_show == 1)
        {
          this.err_mainmodule_config_show = 0;
          return "";
        }
        num = 1;
        this.__mainmodule_tarticulo.BringToFront();
        this.__mainmodule_label25.BringToFront();
        this.__mainmodule_tuni.BringToFront();
        this.__mainmodule_btnsql.BringToFront();
        this.__mainmodule_label13.BringToFront();
        this.__mainmodule_cboempresa1.BringToFront();
        this.__mainmodule_cmdrutapcc.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_config_show = num;
          this.localVars = new object[0];
          return this.__mainmodule_config_show();
        }
        this.ShowError(ex, "_mainmodule_config_show");
        return "";
      }
    }

    private string __mainmodule_cmdrutapcc_click()
    {
      try
      {
        this.__mainmodule_config.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdrutapcc_click");
        return "";
      }
    }

    private string __mainmodule_cmdsend1_click()
    {
      string str1 = "";
      try
      {
        if (this.LCompareEqual(((int) MessageBox.Show("Desea enviar inventario ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVEN " + this.var__mainmodule_nombreempresa + ".txt"), false, Encoding.ASCII));
        string connectiondata = "Persist Security Info=False;Integrated Security=False;" + "Server=" + this.var__mainmodule_servertea + "," + this.var__mainmodule_porttea + ";initial catalog=INVENTMOBILE" + ";user id=" + this.var__mainmodule_usertea + ";password=" + this.var__mainmodule_passtea + ";";
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open(connectiondata).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          ((int) MessageBox.Show("1.Imposible conectar al servidor " + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        this.var__mainmodule_sql = "SELECT I.ctrl_alm, I.articulo, I.descrip, I.existencia, (SELECT exist FROM inven P WHERE ";
        this.var__mainmodule_sql += "P.articulo = i.articulo) FROM prods I ORDER BY descrip";
        this.var__mainmodule_sql = "SELECT articulo, cantidad FROM minve WHERE nuevo = 'S' AND cancelado = 'N'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine("Ctrl Alm,Almacen,Articulo,Descripcion,Inv. Fisico,Existencia SAE,Diferencias");
        string s1 = "0";
        string lSide = "no";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          string str2 = this.__mainmodule_reader.GetValue(0);
          double num = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          if (num > 0.0)
          {
            s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_ltnum.Text = "Procesando Regs:" + s1 + " por favor espere";
            string str3 = str2 + "," + num.ToString((IFormatProvider) b4p.cul);
            this.var__mainmodule_sql = "INSERT INTO INVENT (ALMACEN, CVE_ART, CANT) VALUES('" + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul) + "','" + str2 + "','" + num.ToString((IFormatProvider) b4p.cul) + "')";
            if (this.__mainmodule_msql1.ExecuteNonQuery(this.var__mainmodule_sql).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c2", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTMOBILE.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c2"]).WriteLine(this.var__mainmodule_sql);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c2"]).WriteLine(this.__mainmodule_msql1.LastError);
              if (this.htStreams.Contains((object) "_mainmodule_c2"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c2"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c2");
                GC.Collect();
              }
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              ((int) MessageBox.Show("Problema en tabla INVENTMOBILE en " + this.var__mainmodule_servertea + " en linea 376", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
              lSide = "si";
              break;
            }
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str3);
          }
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_msql1.Close();
        if (this.LCompareEqual(lSide, "si"))
        {
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          return "";
        }
        this.__mainmodule_msql1.Close();
        this.__mainmodule_cmd.CommandText = "UPDATE minve SET nuevo = 'N'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "SELECT articulo, exist FROM noencontrados WHERE exist > 0";
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(" ");
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(" ");
        str1 = "Articulos no encontrados";
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine("---,-----,------,Articulos no encontrados,------,-------,---------");
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        string s2 = "0";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          string str4 = this.__mainmodule_reader.GetValue(0);
          double num = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          if (num > 0.0)
          {
            s2 = ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_ltnum.Text = "Procesando Regs:" + s1 + " por favor espere";
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str4 + "," + num.ToString((IFormatProvider) b4p.cul));
          }
        }
        this.__mainmodule_reader.Close();
        if (this.htStreams.Contains((object) "_mainmodule_c1"))
        {
          ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
          this.htStreams.Remove((object) "_mainmodule_c1");
          GC.Collect();
        }
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        ((int) MessageBox.Show("Registros enviados " + s1, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdsend1_click");
        return "";
      }
    }

    private string __mainmodule_enviar_show()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_enviar_show > 0 && this.err_mainmodule_enviar_show == 1)
        {
          this.err_mainmodule_enviar_show = 0;
          ((int) MessageBox.Show("Problema detectado en Enviar_Show", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        this.__mainmodule_trutapc.Text = "\\\\" + this.var__mainmodule_serverlocal + "\\dacaspel";
        this.__mainmodule_ltsend1.Text = "Servidor:" + this.var__mainmodule_servertea;
        this.__mainmodule_ltsend2.Text = "Base:INVETMOBILE, TABLA:INVENT";
        this.__mainmodule_cmdsend1.BringToFront();
        this.__mainmodule_cmdsend2.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_enviar_show = num;
          this.localVars = new object[0];
          return this.__mainmodule_enviar_show();
        }
        this.ShowError(ex, "_mainmodule_enviar_show");
        return "";
      }
    }

    private string __mainmodule_cmdsend2_click()
    {
      try
      {
        this.__mainmodule_enviar.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdsend2_click");
        return "";
      }
    }

    private string __mainmodule_fgprod_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_fgprod_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_cmdborrar_click()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_cmdborrar_click > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_cmdborrar_click == 1)
          {
            this.err_mainmodule_cmdborrar_click = 0;
            ((int) MessageBox.Show("error en borrar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_tpassword.Text != "Gsorom09" && this.__mainmodule_tpassword.Text != "111222" && this.__mainmodule_tusuario.Text != "Administrador")
        {
          ((int) MessageBox.Show("Contraseña incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        lSide = ((int) MessageBox.Show("Desea vaciar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM minve";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("La tabla Invent se vacia satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cmdborrar_click = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_cmdborrar_click();
        }
        this.ShowError(ex, "_mainmodule_cmdborrar_click");
        return "";
      }
    }

    private string __mainmodule_btnmain8_click()
    {
      try
      {
        this.__mainmodule_con.Close();
        if (this.mainForm != null)
          this.mainForm.Close();
        else
          this.CloseProgram();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnmain8_click");
        return "";
      }
    }

    private string __mainmodule_main_close()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_main_close > 0 && this.err_mainmodule_main_close == 1)
        {
          this.err_mainmodule_main_close = 0;
          ((int) MessageBox.Show("Advertencia mnuMain_Close", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (((int) MessageBox.Show("Desea salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul) == "7")
          this.__mainmodule_main.cancelClose = true;
        else
          this.__mainmodule_con.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_main_close = num;
          this.localVars = new object[0];
          return this.__mainmodule_main_close();
        }
        this.ShowError(ex, "_mainmodule_main_close");
        return "";
      }
    }

    private string __mainmodule_btnmain5_click()
    {
      try
      {
        this.__mainmodule_config.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnmain5_click");
        return "";
      }
    }

    private string __mainmodule_button12_click()
    {
      try
      {
        this.__mainmodule_invent.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_button12_click");
        return "";
      }
    }

    private string __mainmodule_cmdinv_click()
    {
      string lSide1 = "";
      double num1 = 0.0;
      string str1 = "";
      string lSide2 = "";
      double num2 = 0.0;
      int num3 = 0;
      double num4 = 0.0;
      string str2 = "";
      int num5 = 0;
      string str3 = "";
      double num6 = 0.0;
      string format1 = "";
      string format2 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      int num7 = 0;
      try
      {
        if (this.err_mainmodule_cmdinv_click > 0)
        {
          str7 = (string) this.localVars[16];
          str6 = (string) this.localVars[15];
          str5 = (string) this.localVars[14];
          str4 = (string) this.localVars[13];
          format2 = (string) this.localVars[12];
          format1 = (string) this.localVars[11];
          num6 = (double) this.localVars[10];
          str3 = (string) this.localVars[9];
          num5 = (int) this.localVars[8];
          str2 = (string) this.localVars[7];
          num4 = (double) this.localVars[6];
          num3 = (int) this.localVars[5];
          num2 = (double) this.localVars[4];
          lSide2 = (string) this.localVars[3];
          str1 = (string) this.localVars[2];
          num1 = (double) this.localVars[1];
          lSide1 = (string) this.localVars[0];
          if (this.err_mainmodule_cmdinv_click == 1)
          {
            this.err_mainmodule_cmdinv_click = 0;
            this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
            this.__mainmodule_cierrareader();
            ((int) MessageBox.Show("Error en cmdInv.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num7 = 1;
        this.__mainmodule_tarticulo.Enabled = bool.Parse("false".ToLower(b4p.cul));
        str2 = DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + "-" + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Month).ToString(format1, (IFormatProvider) b4p.cul)) + "-" + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Day).ToString(format2, (IFormatProvider) b4p.cul));
        lSide1 = this.__mainmodule_tarticulo.Text;
        lSide1 = lSide1.Replace(" ", "");
        if (lSide1.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La clave del artículo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_tarticulo.Focus();
          return "";
        }
        if (this.LCompareEqual(lSide1, "111222") && this.LCompareEqual(this.var__mainmodule_isadmin, "true"))
        {
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_sqlserver.show();
          return "";
        }
        if (this.LCompareEqual(lSide1, "333444") && this.LCompareEqual(this.var__mainmodule_isadmin, "true"))
        {
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_usuarios.show();
          return "";
        }
        if (this.Other.IsNumber(this.__mainmodule_tuni.Text) == "false")
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La cantidad debe ser numerica", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_tarticulo.Focus();
          return "";
        }
        num1 = double.Parse(this.__mainmodule_tuni.Text, (IFormatProvider) b4p.cul);
        if (num1 < 0.0)
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\grito.wav"));
          Thread.Sleep(1000);
          ((int) MessageBox.Show("La cantidad no puede ser cero o menos a cero", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_tuni.Text = "1";
          this.__mainmodule_tuni.Focus();
          return "";
        }
        if (num1 > 5000.0)
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\bocina.wav"));
          Thread.Sleep(2000);
          ((int) MessageBox.Show("La cantidad no puede ser mayor a 5000", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_tuni.Text = "1";
          this.__mainmodule_tuni.Focus();
          return "";
        }
        str1 = "1";
        lSide2 = "0";
        lSide1 = lSide1.Replace(",", "");
        lSide1 = lSide1.Replace("'", "");
        this.var__mainmodule_sql = "SELECT articulo, descrip, costo_prom, uni_med FROM prods WHERE ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "articulo = '" + lSide1 + "' OR clavealterna = '" + lSide1 + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          lSide1 = this.__mainmodule_reader.GetValue(0);
          str4 = this.__mainmodule_reader.GetValue(2);
          str5 = this.__mainmodule_reader.GetValue(3);
          this.__mainmodule_ltinven2.Text = "[" + lSide1 + "] " + this.__mainmodule_reader.GetValue(1);
        }
        else
        {
          this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\bocina.wav"));
          Thread.Sleep(2000);
          this.__mainmodule_ltinven2.Text = "NO EXISTE [" + lSide1 + "]  ";
          this.__mainmodule_ltinven.Text = "";
          lSide2 = -99.0.ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras") && this.LCompareEqual(lSide2, -99.0.ToString((IFormatProvider) b4p.cul)))
        {
          this.__mainmodule_pnlred.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_ltartinv.Text = lSide1;
          this.__mainmodule_pnlred.BringToFront();
          this.__mainmodule_tarticulo.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_tuni.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_ltred.Focus();
          return "";
        }
        if (this.LCompareEqual(lSide2, -99.0.ToString((IFormatProvider) b4p.cul)))
        {
          this.__mainmodule_ltinven.Text = "";
          this.var__mainmodule_sql = "INSERT OR REPLACE INTO noencontrados (articulo, exist) ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "Select '" + lSide1 + "',";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "COALESCE((SELECT exist FROM noencontrados WHERE articulo = '" + lSide1 + "'), 0) + " + num1.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "SELECT articulo, exist FROM noencontrados WHERE articulo = '" + lSide1 + "'";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true" && this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true")
          {
            this.__mainmodule_ltinven.Text = this.__mainmodule_reader.GetValue(1);
            if (double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul) < 1000.0)
              this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
            else if (double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul) > 999.0 && double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul) < 10000.0)
              this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
            else
              this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
          }
          this.__mainmodule_reader.Close();
          this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_tarticulo.Text = "";
          this.__mainmodule_tarticulo.Focus();
          return "";
        }
        num6 = (double) this.__mainmodule_cboareas.SelectedIndex;
        if (num6 > -1.0)
        {
          str3 = this.__mainmodule_cboareas.Items[(int) (double) this.__mainmodule_cboareas.SelectedIndex].ToString();
          str3 = this.Other.SubString(str3, 0, 3);
          num6 = !(this.Other.IsNumber(str3).ToLower(b4p.cul) == "true") ? 0.0 : (str3 == "" ? 0.0 : double.Parse(str3, (IFormatProvider) b4p.cul));
        }
        else
          num6 = 0.0;
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
        {
          str6 = !this.LCompareEqual(this.var__mainmodule_seriecompra, "") ? this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul) : this.__mainmodule_replicate(" ", 20.0 - (double) this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul).Length) + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
          this.var__mainmodule_sql = "INSERT INTO compras (cve_doc, usuario, articulo, cant, alm1, cancelado, nuevo, status, clave, folio) VALUES('";
          this.var__mainmodule_sql = this.var__mainmodule_sql + str6 + "','" + this.var__mainmodule_userroot + "','" + lSide1 + "','" + num1.ToString((IFormatProvider) b4p.cul) + "','" + str1 + "','N','S','0','" + this.__mainmodule_lt2.Text + "','" + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul) + "')";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "SELECT articulo, sum(cant) FROM compras WHERE articulo = '" + lSide1 + "' AND ";
          this.var__mainmodule_sql += "nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true")
            {
              num1 = double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
              this.__mainmodule_ltinven.Text = num1.ToString((IFormatProvider) b4p.cul);
              if (num1 < 1000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else if (num1 > 999.0 && num1 < 10000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
            }
            this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide1 + "]  Ultima scaneada:" + num1.ToString((IFormatProvider) b4p.cul) + "    " + this.__mainmodule_reader.GetValue(1);
          }
          this.__mainmodule_reader.Close();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
        {
          this.var__mainmodule_sql = "INSERT OR REPLACE INTO inven (articulo, exist, costo_prom, uni_med, status) SELECT '" + lSide1 + "',";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "COALESCE((SELECT exist FROM inven WHERE articulo = '" + lSide1 + "'), 0) + " + num1.ToString((IFormatProvider) b4p.cul);
          this.var__mainmodule_sql = this.var__mainmodule_sql + "," + str4 + ",'" + str5 + "',0";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "INSERT INTO minve (usuario, articulo, cantidad, alm1, cancelado, nuevo, idArea) VALUES('";
          this.var__mainmodule_sql = this.var__mainmodule_sql + this.var__mainmodule_userroot + "','" + lSide1 + "','" + num1.ToString((IFormatProvider) b4p.cul) + "','" + str1 + "','N','S','" + num6.ToString((IFormatProvider) b4p.cul) + "')";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "SELECT articulo, SUM(cantidad) FROM minve WHERE articulo = '" + lSide1 + "'AND nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true")
            {
              num1 = double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
              this.__mainmodule_ltinven.Text = num1.ToString((IFormatProvider) b4p.cul);
              if (num1 < 1000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else if (num1 > 999.0 && num1 < 10000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
            }
            this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide1 + "]  Ultima scaneada:" + num1.ToString((IFormatProvider) b4p.cul) + "    " + this.__mainmodule_reader.GetValue(1);
          }
          this.__mainmodule_reader.Close();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
        {
          str6 = !this.LCompareEqual(this.var__mainmodule_seriecompra, "") ? this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul) : this.__mainmodule_replicate(" ", 20.0 - (double) str7.Length) + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
          this.var__mainmodule_sql = "INSERT INTO pedidos (cve_doc, usuario, articulo, cant, alm1, cancelado, nuevo, status, clave, folio) VALUES('";
          this.var__mainmodule_sql = this.var__mainmodule_sql + str6 + "','" + this.var__mainmodule_userroot + "','" + lSide1 + "','" + num1.ToString((IFormatProvider) b4p.cul) + "','" + str1 + "','N','S','0','" + this.__mainmodule_lt2.Text + "','" + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul) + "')";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "SELECT articulo, sum(cant) FROM pedidos WHERE articulo = '" + lSide1 + "' AND ";
          this.var__mainmodule_sql += "nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true")
            {
              num1 = double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
              this.__mainmodule_ltinven.Text = num1.ToString((IFormatProvider) b4p.cul);
              if (num1 < 1000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else if (num1 > 999.0 && num1 < 10000.0)
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
              else
                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
            }
            this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide1 + "]  Ultima scaneada:" + num1.ToString((IFormatProvider) b4p.cul) + "    " + this.__mainmodule_reader.GetValue(1);
          }
          this.__mainmodule_reader.Close();
        }
        this.__mainmodule_tuni.Text = "1";
        this.__mainmodule_tarticulo.Text = "";
        this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tarticulo.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num7 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cmdinv_click = num7;
          this.localVars = new object[17]
          {
            (object) lSide1,
            (object) num1,
            (object) str1,
            (object) lSide2,
            (object) num2,
            (object) num3,
            (object) num4,
            (object) str2,
            (object) num5,
            (object) str3,
            (object) num6,
            (object) format1,
            (object) format2,
            (object) str4,
            (object) str5,
            (object) str6,
            (object) str7
          };
          return this.__mainmodule_cmdinv_click();
        }
        this.ShowError(ex, "_mainmodule_cmdinv_click");
        return "";
      }
    }

    private string __mainmodule_mensend_click()
    {
      try
      {
        this.__mainmodule_enviar.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mensend_click");
        return "";
      }
    }

    private string __mainmodule_invent_show()
    {
      string format = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_invent_show > 0)
        {
          format = (string) this.localVars[0];
          if (this.err_mainmodule_invent_show == 1)
          {
            this.err_mainmodule_invent_show = 0;
            ((int) MessageBox.Show("Error en Invent_Show.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_label25.BringToFront();
        this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tuni.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tarticulo.BringToFront();
        this.__mainmodule_label25.BringToFront();
        this.__mainmodule_tuni.BringToFront();
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
        {
          this.__mainmodule_invent.Text = "Ordenes de compra";
          this.__mainmodule_ltfc.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_mnucompra.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_label30.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_cboareas.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt1.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt2.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt3.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt4.Visible = bool.Parse("false".ToLower(b4p.cul));
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
        {
          this.__mainmodule_invent.Text = "Inventario";
          this.__mainmodule_ltfc.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_mnucompra.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_label30.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_cboareas.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_lt1.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt2.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt3.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt4.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
            this.__mainmodule_cboareas.Items.Add((object) (((format = "D3".ToLower(b4p.cul))[0] != 'd' ? double.Parse(this.__mainmodule_reader.GetValue(0), (IFormatProvider) b4p.cul).ToString(format, (IFormatProvider) b4p.cul) : ((int) double.Parse(this.__mainmodule_reader.GetValue(0), (IFormatProvider) b4p.cul)).ToString(format, (IFormatProvider) b4p.cul)) + " " + this.__mainmodule_reader.GetValue(1)));
          this.__mainmodule_reader.Close();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
        {
          this.__mainmodule_invent.Text = "Pedidos";
          this.__mainmodule_ltfc.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_mnucompra.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_label30.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_cboareas.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_lt1.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_lt2.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_lt3.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_lt4.Visible = bool.Parse("true".ToLower(b4p.cul));
        }
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_tuni.Text = "1";
        this.__mainmodule_tarticulo.Text = "";
        this.__mainmodule_tarticulo.Focus();
        this.__mainmodule_tarticulo.Focus();
        this.__mainmodule_tarticulo.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_invent_show = num;
          this.localVars = new object[1]{ (object) format };
          return this.__mainmodule_invent_show();
        }
        this.ShowError(ex, "_mainmodule_invent_show");
        return "";
      }
    }

    private string __mainmodule_tarticulo_keypress(string var__mainmodule_key)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_tarticulo_keypress > 0 && this.err_mainmodule_tarticulo_keypress == 1)
        {
          this.err_mainmodule_tarticulo_keypress = 0;
          ((int) MessageBox.Show("Error en articulo keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__mainmodule_key, '\r'.ToString((IFormatProvider) b4p.cul)))
          this.__mainmodule_cmdinv_click();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tarticulo_keypress = num;
          this.localVars = new object[0];
          return this.__mainmodule_tarticulo_keypress(var__mainmodule_key);
        }
        this.ShowError(ex, "_mainmodule_tarticulo_keypress");
        return "";
      }
    }

    private string __mainmodule_importararticulos()
    {
      int num1 = 0;
      string str1 = "";
      string str2 = "";
      string connectiondata = "";
      string str3 = "";
      string str4 = "";
      string lSide = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string str10 = "";
      string str11 = "";
      string str12 = "";
      string str13 = "";
      string str14 = "";
      string str15 = "";
      string str16 = "";
      string str17 = "";
      string str18 = "";
      string str19 = "";
      string str20 = "";
      string str21 = "";
      string str22 = "";
      string str23 = "";
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_importararticulos > 0)
        {
          str23 = (string) this.localVars[25];
          str22 = (string) this.localVars[24];
          str21 = (string) this.localVars[23];
          str20 = (string) this.localVars[22];
          str19 = (string) this.localVars[21];
          str18 = (string) this.localVars[20];
          str17 = (string) this.localVars[19];
          str16 = (string) this.localVars[18];
          str15 = (string) this.localVars[17];
          str14 = (string) this.localVars[16];
          str13 = (string) this.localVars[15];
          str12 = (string) this.localVars[14];
          str11 = (string) this.localVars[13];
          str10 = (string) this.localVars[12];
          str9 = (string) this.localVars[11];
          str8 = (string) this.localVars[10];
          str7 = (string) this.localVars[9];
          str6 = (string) this.localVars[8];
          str5 = (string) this.localVars[7];
          lSide = (string) this.localVars[6];
          str4 = (string) this.localVars[5];
          str3 = (string) this.localVars[4];
          connectiondata = (string) this.localVars[3];
          str2 = (string) this.localVars[2];
          str1 = (string) this.localVars[1];
          num1 = (int) this.localVars[0];
          if (this.err_mainmodule_importararticulos == 1)
          {
            this.err_mainmodule_importararticulos = 0;
            this.__mainmodule_cierracontrans();
            ((int) MessageBox.Show("Error en importar paso " + str5 + "\r\n" + this.var__mainmodule_sql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR SQLITE.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str5 + "->" + this.var__mainmodule_sql);
            if (this.htStreams.Contains((object) "_mainmodule_c1"))
            {
              ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
              this.htStreams.Remove((object) "_mainmodule_c1");
              GC.Collect();
            }
            return "";
          }
        }
        num2 = 1;
        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
        this.__mainmodule_con.BeginTransaction();
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
          this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
          this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
          this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
          this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
          this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
          this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), (IFormatProvider) b4p.cul);
          this.var__mainmodule_correo = this.__mainmodule_reader.GetValue(7);
          this.var__mainmodule_nombreempresa = this.__mainmodule_reader.GetValue(8);
          this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(9);
          this.var__mainmodule_correo2 = this.__mainmodule_reader.GetValue(10);
        }
        else
        {
          this.var__mainmodule_serverlocal = "";
          this.var__mainmodule_base = "";
          this.var__mainmodule_usersql = "";
          this.var__mainmodule_passsql = "";
          this.var__mainmodule_portsql = "";
          this.var__mainmodule_ctrl_alm = "";
          this.var__mainmodule_almacen = 1.0;
          this.var__mainmodule_correo = "";
          this.var__mainmodule_correo2 = "";
          this.var__mainmodule_nombreempresa = "";
          this.var__mainmodule_linea = "";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul), "1"))
        {
          if (this.LCompareEqual(this.var__mainmodule_ctrl_alm, "") && this.LCompareEqual(this.var__mainmodule_linea, ""))
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, ULT_COSTO, UNI_MED, IMPUESTO1, IMPUESTO4, I.CVE_ESQIMPU, IMP1APLICA, IMP2APLICA, IMP3APLICA, IMP4APLICA, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "ISNULL((SELECT TOP 1 PRECIO FROM PRECIO_X_PROD" + this.var__mainmodule_empresa + " P WHERE P.CVE_ART = I.CVE_ART AND CVE_PRECIO = 1),0) AS P1, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "(SELECT TOP 1 CVE_ALTER FROM CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU";
          }
          else if (!this.LCompareEqual(this.var__mainmodule_ctrl_alm, "") && this.LCompareEqual(this.var__mainmodule_linea, ""))
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, ULT_COSTO, UNI_MED, IMPUESTO1, IMPUESTO4, I.CVE_ESQIMPU, IMP1APLICA, IMP2APLICA, IMP3APLICA, IMP4APLICA, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "ISNULL((SELECT TOP 1 PRECIO FROM PRECIO_X_PROD" + this.var__mainmodule_empresa + " P WHERE P.CVE_ART = I.CVE_ART AND CVE_PRECIO = 1),0) AS P1, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "(SELECT TOP 1 CVE_ALTER FROM CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE CTRL_ALM = '" + this.var__mainmodule_ctrl_alm + "'";
          }
          else
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, ULT_COSTO, UNI_MED, IMPUESTO1, IMPUESTO4, I.CVE_ESQIMPU, IMP1APLICA, IMP2APLICA, IMP3APLICA, IMP4APLICA, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "ISNULL((SELECT TOP 1 PRECIO FROM PRECIO_X_PROD" + this.var__mainmodule_empresa + " P WHERE P.CVE_ART = I.CVE_ART AND CVE_PRECIO = 1),0) AS P1, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "(SELECT TOP 1 CVE_ALTER FROM CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE LIN_PROD = '" + this.var__mainmodule_linea + "'";
          }
        }
        else
          this.var__mainmodule_sql = "SELECT PRODUCTO, DESCRIPCIO, LINEA, EXISTENCIA, CLVALTER1 FROM CATINVEN";
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        connectiondata = "Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + ",";
        connectiondata = connectiondata + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";";
        if (this.__mainmodule_msql1.Open(connectiondata).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          ((int) MessageBox.Show("Imposible conectarse al servidor\r\n" + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\SQLERROR.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(connectiondata);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.__mainmodule_msql1.Close();
          this.__mainmodule_con.EndTransaction();
          return "";
        }
        this.__mainmodule_cmd.CommandText = "DELETE FROM prods";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_ltart.Text = "Importando articulo por favor espere";
        num1 = 0;
        str4 = "0";
        lSide = "0";
        if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            str5 = "1";
            if (this.LCompareEqual(this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul), "1"))
            {
              str5 = "2";
              str1 = this.__mainmodule_msql1.ReadField("CVE_ART");
              str5 = "3";
              str2 = this.__mainmodule_msql1.ReadField("DESCR");
              str5 = "4";
              str2 = str2.Replace("'", " ");
              str5 = "5";
              str6 = this.__mainmodule_msql1.ReadField("EXIST");
              str5 = "6";
              str7 = this.__mainmodule_msql1.ReadField("CTRL_ALM");
              str5 = "7";
              str8 = this.__mainmodule_msql1.ReadField("LIN_PROD");
              str5 = "8";
              str3 = this.__mainmodule_msql1.ReadField("ALTERNA");
              str5 = "9";
              lSide = Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("ULT_COSTO"), (IFormatProvider) b4p.cul), 2).ToString((IFormatProvider) b4p.cul);
              str9 = !this.LCompareEqual(lSide, "0") ? lSide : Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("COSTO_PROM"), (IFormatProvider) b4p.cul), 2).ToString((IFormatProvider) b4p.cul);
              str5 = "10";
              str10 = this.__mainmodule_msql1.ReadField("UNI_MED");
              str5 = "11";
              str11 = this.__mainmodule_msql1.ReadField("IMPUESTO1");
              str5 = "12";
              str12 = this.__mainmodule_msql1.ReadField("IMPUESTO4");
              str5 = "13";
              str4 = Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("P1"), (IFormatProvider) b4p.cul), 2).ToString((IFormatProvider) b4p.cul);
              str13 = this.__mainmodule_msql1.ReadField("CVE_ESQIMPU");
              str14 = this.__mainmodule_msql1.ReadField("IMP1APLICA");
              str15 = this.__mainmodule_msql1.ReadField("IMP2APLICA");
              str16 = this.__mainmodule_msql1.ReadField("IMP3APLICA");
              str17 = this.__mainmodule_msql1.ReadField("IMP4APLICA");
            }
            else
            {
              str1 = this.__mainmodule_msql1.ReadField("PRODUCTO");
              str2 = this.__mainmodule_msql1.ReadField("DESCRIPCIO");
              str2 = str2.Replace("'", " ");
              str6 = this.__mainmodule_msql1.ReadField("EXISTENCIA");
              str7 = "";
              str8 = this.__mainmodule_msql1.ReadField("LINEA");
              str3 = this.__mainmodule_msql1.ReadField("CLVALTER1");
              str9 = "0";
              str10 = "0";
              str11 = "0";
              str12 = "0";
            }
            str5 = "14";
            str2 = str2.Replace("'", " ");
            num1 = (int) ((double) num1 + 1.0);
            this.__mainmodule_ltsync.Text = "Articulos: " + num1.ToString((IFormatProvider) b4p.cul);
            str1 = str1.Replace("'", "");
            str2 = str2.Replace("'", " ");
            str5 = "15";
            this.var__mainmodule_sql = "INSERT INTO prods (articulo, descrip, existencia, ctrl_alm, linea, clavealterna, costo_prom, precio1, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "uni_med, impu1, impu4, status, cve_esqimpu, imp1aplica, imp2aplica, imp3aplica, imp4aplica) VALUES('" + str1 + "','";
            this.var__mainmodule_sql = this.var__mainmodule_sql + str2 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str3 + "','";
            this.var__mainmodule_sql = this.var__mainmodule_sql + str9 + "','" + str4 + "','" + str10 + "','" + str11 + "','" + str12 + "','0','";
            this.var__mainmodule_sql = this.var__mainmodule_sql + str13 + "','" + str14 + "','" + str15 + "','" + str16 + "','" + str17 + "')";
            str5 = "16";
            this.__mainmodule_ltart.Text = num1.ToString((IFormatProvider) b4p.cul) + ". " + str1 + " - " + str2 + "(" + str5 + ")";
            this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
            this.__mainmodule_cmd.ExecuteNonQuery();
          }
          this.__mainmodule_ltsync.Text = "Articulo: " + num1.ToString((IFormatProvider) b4p.cul);
        }
        else
        {
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR1.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        str5 = "17";
        this.__mainmodule_cmd.CommandText = "DELETE FROM provs";
        this.__mainmodule_cmd.ExecuteNonQuery();
        str5 = "18";
        this.__mainmodule_ltart.Text = "Importando Proveedores por favor espere";
        if (this.__mainmodule_msql1.ExecuteQuery("SELECT CLAVE, NOMBRE FROM PROV" + this.var__mainmodule_empresa).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            str5 = "19";
            str18 = this.__mainmodule_msql1.ReadField("CLAVE");
            str19 = this.__mainmodule_msql1.ReadField("NOMBRE");
            str19 = str19.Replace("'", " ");
            this.var__mainmodule_sql = "INSERT INTO provs (clave, nombre) VALUES('" + str18 + "','" + str19 + "')";
            str5 = "20";
            this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
            this.__mainmodule_cmd.ExecuteNonQuery();
          }
        }
        else
        {
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR1.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        str5 = "18";
        this.__mainmodule_cmd.CommandText = "DELETE FROM clientes";
        this.__mainmodule_cmd.ExecuteNonQuery();
        str5 = "19";
        this.__mainmodule_ltart.Text = "Importando clientes por favor espere";
        if (this.__mainmodule_msql1.ExecuteQuery("SELECT CLAVE, NOMBRE, RFC, STATUS FROM CLIE" + this.var__mainmodule_empresa).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            str5 = "20";
            str18 = this.__mainmodule_msql1.ReadField("CLAVE");
            str19 = this.__mainmodule_msql1.ReadField("NOMBRE");
            str19 = str19.Replace("'", " ");
            str20 = this.__mainmodule_msql1.ReadField("RFC");
            str21 = this.__mainmodule_msql1.ReadField("STATUS");
            this.var__mainmodule_sql = "INSERT INTO clientes (clave, nombre, rfc, status) VALUES('" + str18 + "','" + str19 + "','" + str20 + "','" + str21 + "')";
            str5 = "21";
            this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
            this.__mainmodule_cmd.ExecuteNonQuery();
          }
        }
        else
        {
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR_CLIENTES.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        str5 = "22";
        this.__mainmodule_cmd.CommandText = "DELETE FROM conm";
        this.__mainmodule_cmd.ExecuteNonQuery();
        str5 = "23";
        if (this.__mainmodule_msql1.ExecuteQuery("SELECT CVE_CPTO, DESCR FROM CONM" + this.var__mainmodule_empresa).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            str22 = this.__mainmodule_msql1.ReadField("CVE_CPTO");
            str23 = this.__mainmodule_msql1.ReadField("DESCR");
            str5 = "24";
            this.var__mainmodule_sql = "INSERT INTO conm (num_cpto, descr) VALUES('" + str22 + "','" + str23 + "')";
            this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
            this.__mainmodule_cmd.ExecuteNonQuery();
            str5 = "25";
          }
        }
        else
        {
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR1.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_msql1.Close();
        str5 = "25";
        this.__mainmodule_ltart.Text = "";
        this.__mainmodule_con.EndTransaction();
        this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\button2.wav"));
        Thread.Sleep(2000);
        ((int) MessageBox.Show(num1.ToString((IFormatProvider) b4p.cul) + " OK Registros importados", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_importararticulos = num2;
          this.localVars = new object[26]
          {
            (object) num1,
            (object) str1,
            (object) str2,
            (object) connectiondata,
            (object) str3,
            (object) str4,
            (object) lSide,
            (object) str5,
            (object) str6,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) str10,
            (object) str11,
            (object) str12,
            (object) str13,
            (object) str14,
            (object) str15,
            (object) str16,
            (object) str17,
            (object) str18,
            (object) str19,
            (object) str20,
            (object) str21,
            (object) str22,
            (object) str23
          };
          return this.__mainmodule_importararticulos();
        }
        this.ShowError(ex, "_mainmodule_importararticulos");
        return "";
      }
    }

    private string __mainmodule_importararticulosupdateexist()
    {
      int num1 = 0;
      string lSide = "";
      string str1 = "";
      string connectiondata = "";
      string str2 = "";
      string str3 = "";
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_importararticulosupdateexist > 0)
        {
          str3 = (string) this.localVars[5];
          str2 = (string) this.localVars[4];
          connectiondata = (string) this.localVars[3];
          str1 = (string) this.localVars[2];
          lSide = (string) this.localVars[1];
          num1 = (int) this.localVars[0];
          if (this.err_mainmodule_importararticulosupdateexist == 1)
          {
            this.err_mainmodule_importararticulosupdateexist = 0;
            ((int) MessageBox.Show("Error al actualizar articulos  " + this.var__mainmodule_sql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
        this.__mainmodule_con.BeginTransaction();
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
          this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
          this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
          this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
          this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
          this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
          this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), (IFormatProvider) b4p.cul);
          this.var__mainmodule_correo = this.__mainmodule_reader.GetValue(7);
          this.var__mainmodule_nombreempresa = this.__mainmodule_reader.GetValue(8);
          this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(9);
          this.var__mainmodule_correo2 = this.__mainmodule_reader.GetValue(10);
        }
        else
        {
          this.var__mainmodule_serverlocal = "";
          this.var__mainmodule_base = "";
          this.var__mainmodule_usersql = "";
          this.var__mainmodule_passsql = "";
          this.var__mainmodule_portsql = "";
          this.var__mainmodule_ctrl_alm = "";
          this.var__mainmodule_almacen = 1.0;
          this.var__mainmodule_correo = "";
          this.var__mainmodule_correo2 = "";
          this.var__mainmodule_nombreempresa = "";
          this.var__mainmodule_linea = "";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul), "1"))
        {
          if (this.LCompareEqual(this.var__mainmodule_ctrl_alm, "") && this.LCompareEqual(this.var__mainmodule_linea, ""))
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, UNI_MED, ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "IMPUESTO1, IMPUESTO4, (SELECT TOP 1 CVE_ALTER FROM CVES_ALTER" + this.var__mainmodule_empresa + " A ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU";
          }
          else if (!this.LCompareEqual(this.var__mainmodule_ctrl_alm, "") && this.LCompareEqual(this.var__mainmodule_linea, ""))
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, UNI_MED, ";
            this.var__mainmodule_sql += "IMPUESTO1, IMPUESTO4, (SELECT TOP 1 CVE_ALTER FROM ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE CTRL_ALM = '" + this.var__mainmodule_ctrl_alm + "'";
          }
          else
          {
            this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, UNI_MED, ";
            this.var__mainmodule_sql += "IMPUESTO1, IMPUESTO4, (SELECT TOP 1 CVE_ALTER FROM ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
            this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE LIN_PROD = '" + this.var__mainmodule_linea + "'";
          }
        }
        else
        {
          this.var__mainmodule_sql = "SELECT PRODUCTO, DESCRIPCIO, LINEA, EXISTENCIA, CLVALTER1,  ";
          this.var__mainmodule_sql += "FROM CATINVEN";
        }
        this.var__mainmodule_errfound = bool.Parse("false");
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        connectiondata = "Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + ",";
        connectiondata = connectiondata + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";";
        if (this.__mainmodule_msql1.Open(connectiondata).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          ((int) MessageBox.Show("Imposible conectarse al servidor\r\n" + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          this.var__mainmodule_errfound = bool.Parse("true");
          this.__mainmodule_con.EndTransaction();
          return "";
        }
        num1 = 0;
        if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            if (this.LCompareEqual(this.var__mainmodule_sistema.ToString((IFormatProvider) b4p.cul), "1"))
            {
              lSide = this.__mainmodule_msql1.ReadField("CVE_ART");
              str3 = this.__mainmodule_msql1.ReadField("EXIST");
            }
            else
            {
              lSide = this.__mainmodule_msql1.ReadField("PRODUCTO");
              str3 = this.__mainmodule_msql1.ReadField("EXISTENCIA");
            }
            if (this.LCompareEqual(lSide, "GRP000127OL"))
              num1 = (int) (double) num1;
            num1 = (int) ((double) num1 + 1.0);
            this.__mainmodule_ltmart.Text = lSide;
            this.__mainmodule_ltmreg.Text = num1.ToString((IFormatProvider) b4p.cul);
            lSide = lSide.Replace("'", " ");
            this.var__mainmodule_sql = "UPDATE prods SET existencia = " + str3 + " WHERE articulo = '" + lSide + "'";
            this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
            this.__mainmodule_cmd.ExecuteNonQuery();
          }
        }
        else
        {
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\ERROR1.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_msql1.Close();
        this.__mainmodule_con.EndTransaction();
        this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\button2.wav"));
        Thread.Sleep(2000);
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_importararticulosupdateexist = num2;
          this.localVars = new object[6]
          {
            (object) num1,
            (object) lSide,
            (object) str1,
            (object) connectiondata,
            (object) str2,
            (object) str3
          };
          return this.__mainmodule_importararticulosupdateexist();
        }
        this.ShowError(ex, "_mainmodule_importararticulosupdateexist");
        return "";
      }
    }

    private string __mainmodule_mnurest_click()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnurest_click");
        return "";
      }
    }

    private string __mainmodule_cmdvaciarinvent_click()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_cmdvaciarinvent_click > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_cmdvaciarinvent_click == 1)
          {
            this.err_mainmodule_cmdvaciarinvent_click = 0;
            ((int) MessageBox.Show("error en borrar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_tusuario.Text != "Administrador" && this.__mainmodule_tpassword.Text != "sorom" && this.__mainmodule_tpassword.Text != "Gsorom09" && this.__mainmodule_tpassword.Text == "111222")
        {
          ((int) MessageBox.Show("Contraseña incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        lSide = ((int) MessageBox.Show("Desea vaciar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        lSide = ((int) MessageBox.Show("Se borrara toda la informacion tendra que volver a recibir. Desea cotinua?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_copiaarchivos();
        this.__mainmodule_cmd.CommandText = "DELETE FROM minve";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "DELETE FROM movsinv";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "DELETE FROM inven";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "DELETE FROM compras";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "DELETE FROM pedidos";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "UPDATE prods SET existencia = 0";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "DELETE FROM noencontrados";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_vacu();
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_ltinven2.Text = "";
        ((int) MessageBox.Show("La base de datos se vacio satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cmdvaciarinvent_click = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_cmdvaciarinvent_click();
        }
        this.ShowError(ex, "_mainmodule_cmdvaciarinvent_click");
        return "";
      }
    }

    private string __mainmodule_vacu()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_vacu > 0 && this.err_mainmodule_vacu == 1)
        {
          this.err_mainmodule_vacu = 0;
          return "";
        }
        num = 1;
        this.__mainmodule_cmd.CommandText = "VACUUM";
        this.__mainmodule_cmd.ExecuteNonQuery();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_vacu = num;
          this.localVars = new object[0];
          return this.__mainmodule_vacu();
        }
        this.ShowError(ex, "_mainmodule_vacu");
        return "";
      }
    }

    private string __mainmodule_copiaarchivos()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_copiaarchivos");
        return "";
      }
    }

    private string __mainmodule_copiaarchivos2()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_copiaarchivos2");
        return "";
      }
    }

    private string __mainmodule_menmov_click()
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_menmov_click > 0)
        {
          num1 = (int) this.localVars[0];
          if (this.err_mainmodule_menmov_click == 1)
          {
            this.err_mainmodule_menmov_click = 0;
            ((int) MessageBox.Show("Error en cmdMovs.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        this.__mainmodule_invencan.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_menmov_click = num2;
          this.localVars = new object[1]{ (object) num1 };
          return this.__mainmodule_menmov_click();
        }
        this.ShowError(ex, "_mainmodule_menmov_click");
        return "";
      }
    }

    private string __mainmodule_main_show()
    {
      try
      {
        this.__mainmodule_btnmain8.BringToFront();
        this.__mainmodule_cboempresa.BringToFront();
        this.__mainmodule_btnmain8.BringToFront();
        this.__mainmodule_label21.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_main_show");
        return "";
      }
    }

    private string __mainmodule_tuni_keypress(string var__mainmodule_key)
    {
      try
      {
        if (this.LCompareEqual(var__mainmodule_key, '\r'.ToString((IFormatProvider) b4p.cul)))
        {
          this.__mainmodule_cmdinv_click();
          this.__mainmodule_tarticulo.Focus();
        }
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tuni_keypress");
        return "";
      }
    }

    private string __mainmodule_tuni_gotfocus()
    {
      try
      {
        this.__mainmodule_tuni.SelectionStart = 0;
        this.__mainmodule_tuni.SelectionLength = (int) (double) this.__mainmodule_tuni.Text.Length;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tuni_gotfocus");
        return "";
      }
    }

    private string __mainmodule_mencan_click()
    {
      try
      {
        this.__mainmodule_invencan.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mencan_click");
        return "";
      }
    }

    private string __mainmodule_cmdinvensalir_click()
    {
      try
      {
        this.__mainmodule_invencan.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdinvensalir_click");
        return "";
      }
    }

    private string __mainmodule_mnucan1_click()
    {
      string str1 = "";
      int num1 = 0;
      double num2 = 0.0;
      string str2 = "";
      string lSide = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_mnucan1_click > 0)
        {
          lSide = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (int) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_mnucan1_click == 1)
          {
            this.err_mainmodule_mnucan1_click = 0;
            ((int) MessageBox.Show("Error en cmdInvenCanc", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        if (this.__mainmodule_tbcaninven.dataTable.DefaultView.Count.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = (int) (double) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, false);
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
        {
          ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if ((string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true) == "C")
        {
          ((int) MessageBox.Show("Esta partida esta cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num2 = !(this.Other.IsNumber((string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true)).ToLower(b4p.cul) == "true") ? 0.0 : (double) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, false);
        str2 = (string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true);
        str1 = "Usuario: " + (string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true) + "\r\n";
        str1 = str1 + "Articulo: " + str2 + "\r\n";
        str1 = str1 + "Cant: " + num2.ToString((IFormatProvider) b4p.cul);
        lSide = ((int) MessageBox.Show("Desea cancelar partida " + str1 + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
        {
          this.var__mainmodule_sql = "UPDATE compras SET cancelado = 'C' WHERE id = " + num1.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
        {
          this.var__mainmodule_sql = "UPDATE pedidos SET cancelado = 'C' WHERE id = " + num1.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
        {
          this.var__mainmodule_sql = "UPDATE minve SET cancelado = 'C' WHERE id = " + num1.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "UPDATE inven SET exist = exist - " + num2.ToString((IFormatProvider) b4p.cul) + " WHERE articulo = '" + str2 + "'";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        if (this.Other.IsNumber(this.__mainmodule_ltsum2.Text).ToLower(b4p.cul) == "true")
          this.__mainmodule_ltsum2.Text = (double.Parse(this.__mainmodule_ltsum2.Text, (IFormatProvider) b4p.cul) - num2).ToString((IFormatProvider) b4p.cul);
        if (this.Other.IsNumber(this.__mainmodule_ltsumcan2.Text).ToLower(b4p.cul) == "true")
          this.__mainmodule_ltsumcan2.Text = (double.Parse(this.__mainmodule_ltsumcan2.Text, (IFormatProvider) b4p.cul) + num2).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltinven.Text = "";
        ((int) MessageBox.Show("Partida cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) this.__mainmodule_tbcaninven.CurrentCell.RowNumber, "Cancelado");
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnucan1_click = num3;
          this.localVars = new object[5]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) str2,
            (object) lSide
          };
          return this.__mainmodule_mnucan1_click();
        }
        this.ShowError(ex, "_mainmodule_mnucan1_click");
        return "";
      }
    }

    private string __mainmodule_tcodigo_keypress(string var__mainmodule_key)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_tcodigo_keypress > 0 && this.err_mainmodule_tcodigo_keypress == 1)
        {
          this.err_mainmodule_tcodigo_keypress = 0;
          ((int) MessageBox.Show("Error en tCodigo_keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__mainmodule_key, '\r'.ToString((IFormatProvider) b4p.cul)))
          this.__mainmodule_bcodigo();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tcodigo_keypress = num;
          this.localVars = new object[0];
          return this.__mainmodule_tcodigo_keypress(var__mainmodule_key);
        }
        this.ShowError(ex, "_mainmodule_tcodigo_keypress");
        return "";
      }
    }

    private string __mainmodule_bcodigo()
    {
      string str1 = "";
      int row = 0;
      double num1 = 0.0;
      double num2 = 0.0;
      string str2 = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_bcodigo > 0)
        {
          str2 = (string) this.localVars[4];
          num2 = (double) this.localVars[3];
          num1 = (double) this.localVars[2];
          row = (int) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_bcodigo == 1)
          {
            this.err_mainmodule_bcodigo = 0;
            ((int) MessageBox.Show("Error en BCodigo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        str1 = this.__mainmodule_tcodigo.Text.Replace(" ", "");
        if (str1.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("La clave del articulo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_tbcaninven.AddRow(new object[0]);
        row = (int) ((double) this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - 1.0);
        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) row, str1);
        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) row, str1);
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
        {
          str2 = !this.LCompareEqual(this.var__mainmodule_seriecompra, "") ? this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul) : this.__mainmodule_replicate(" ", 20.0 - (double) this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul).Length) + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
          this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cant, M.cancelado ";
          this.var__mainmodule_sql += "FROM compras M INNER JOIN prods P ON P.articulo = M.articulo ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE (M.articulo = '" + str1 + "' OR clavealterna = '" + str1;
          this.var__mainmodule_sql = this.var__mainmodule_sql + "') AND cve_doc = '" + str2 + "' AND nuevo = 'S' ORDER BY id";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          this.__mainmodule_tbcaninven.dataTable.Clear();
          this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
          num1 = 0.0;
          num2 = 0.0;
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            this.__mainmodule_tbcaninven.AddRow(new object[0]);
            row = (int) ((double) this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - 1.0);
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(0));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(1));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(2));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(3));
            if (this.__mainmodule_reader.GetValue(4) == "N")
            {
              num1 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
            }
            else
            {
              num2 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
              this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) row, "Cancelado");
            }
          }
          this.__mainmodule_reader.Close();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
        {
          this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cantidad, M.cancelado FROM minve M ";
          this.var__mainmodule_sql += "INNER JOIN prods P ON P.articulo = M.articulo WHERE ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "(M.articulo = '" + str1 + "' OR clavealterna = '" + str1 + "') AND nuevo = 'S' ORDER BY id";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          this.__mainmodule_tbcaninven.dataTable.Clear();
          this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
          num1 = 0.0;
          num2 = 0.0;
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            this.__mainmodule_tbcaninven.AddRow(new object[0]);
            row = (int) ((double) this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - 1.0);
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(0));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(1));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(2));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(3));
            if (this.__mainmodule_reader.GetValue(4) == "N")
            {
              num1 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
            }
            else
            {
              num2 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
              this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) row, "Cancelado");
            }
          }
          this.__mainmodule_reader.Close();
        }
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
        {
          str2 = !this.LCompareEqual(this.var__mainmodule_seriepedido, "") ? this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul) : this.__mainmodule_replicate(" ", 20.0 - (double) this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul).Length) + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
          this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cant, M.cancelado ";
          this.var__mainmodule_sql += "FROM pedidos M INNER JOIN prods P ON P.articulo = M.articulo ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE (M.articulo = '" + str1 + "' OR clavealterna = '" + str1;
          this.var__mainmodule_sql = this.var__mainmodule_sql + "') AND cve_doc = '" + str2 + "' AND nuevo = 'S' ORDER BY id";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          this.__mainmodule_tbcaninven.dataTable.Clear();
          this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
          num1 = 0.0;
          num2 = 0.0;
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            this.__mainmodule_tbcaninven.AddRow(new object[0]);
            row = (int) ((double) this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - 1.0);
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(0));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(1));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(2));
            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, (int) (double) row, this.__mainmodule_reader.GetValue(3));
            if (this.__mainmodule_reader.GetValue(4) == "N")
            {
              num1 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
            }
            else
            {
              num2 += double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
              this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, (int) (double) row, "Cancelado");
            }
          }
          this.__mainmodule_reader.Close();
        }
        this.__mainmodule_ltsum2.Text = num1.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltsumcan2.Text = num2.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tcodigo.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_bcodigo = num3;
          this.localVars = new object[5]
          {
            (object) str1,
            (object) row,
            (object) num1,
            (object) num2,
            (object) str2
          };
          return this.__mainmodule_bcodigo();
        }
        this.ShowError(ex, "_mainmodule_bcodigo");
        return "";
      }
    }

    private string __mainmodule_invencan_show()
    {
      try
      {
        this.__mainmodule_label27.BringToFront();
        this.__mainmodule_tcodigo.BringToFront();
        this.__mainmodule_cmdinvc.BringToFront();
        this.__mainmodule_tbcaninven.dataTable.Clear();
        this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_invencan_show");
        return "";
      }
    }

    private string __mainmodule_sqlserver_show()
    {
      try
      {
        this.__mainmodule_tnombreemp.Text = "";
        this.__mainmodule_tserver.Text = "";
        this.__mainmodule_tremoto.Text = "";
        this.__mainmodule_tbase.Text = "";
        this.__mainmodule_tuser.Text = "";
        this.__mainmodule_tpasssql.Text = "";
        this.__mainmodule_tpuerto.Text = "";
        this.__mainmodule_cboempresa1.SelectedIndex = -1;
        this.__mainmodule_label13.BringToFront();
        this.__mainmodule_cboempresa1.BringToFront();
        this.__mainmodule_ltsql1.BringToFront();
        this.__mainmodule_tserver.BringToFront();
        this.__mainmodule_tremoto.BringToFront();
        this.__mainmodule_chmatriz.BringToFront();
        this.__mainmodule_tcorreo.Text = "";
        this.__mainmodule_tcorreo2.Text = "";
        this.__mainmodule_cboempresa1.Items.Clear();
        string s1 = "1";
        double num1 = 99.0;
        for (double num2 = s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul); num2 <= num1; s1 = (++num2).ToString((IFormatProvider) b4p.cul))
        {
          string lower;
          this.__mainmodule_cboempresa1.Items.Add((lower = "D2".ToLower(b4p.cul))[0] != 'd' ? (object) (s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(lower, (IFormatProvider) b4p.cul) : (object) (s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(lower, (IFormatProvider) b4p.cul));
        }
        this.__mainmodule_cboalm.Items.Clear();
        string s2 = "1";
        double num3 = 99.0;
        for (double num4 = s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul); num4 <= num3; s2 = (++num4).ToString((IFormatProvider) b4p.cul))
          this.__mainmodule_cboalm.Items.Add((object) s2);
        this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_sqlserver_show");
        return "";
      }
    }

    private string __mainmodule_btnsql1_click()
    {
      string str = "";
      string rSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btnsql1_click > 0)
        {
          rSide = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_mainmodule_btnsql1_click == 1)
          {
            this.err_mainmodule_btnsql1_click = 0;
            ((int) MessageBox.Show("Problema en btnSQL1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboempresa1.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_cboalm.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        rSide = this.__mainmodule_cboempresa1.Items[(int) (double) this.__mainmodule_cboempresa1.SelectedIndex].ToString();
        this.var__mainmodule_multialmacen = !(this.__mainmodule_chmult.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true") ? 0.0 : 1.0;
        this.var__mainmodule_sql = "INSERT OR REPLACE INTO empresas (nombre, empresa, servidor, base, usuario, pass, puerto, ctrl_alm, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "almacen, correo, linea, correo2, remoto, multialmacen) SELECT '" + this.__mainmodule_tnombreemp.Text + "','" + rSide + "','";
        this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tserver.Text + "','" + this.__mainmodule_tbase.Text + "','" + this.__mainmodule_tuser.Text + "','";
        this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tpasssql.Text + "','" + this.__mainmodule_tpuerto.Text + "','" + this.__mainmodule_tcontrol.Text + "','";
        this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_cboalm.Items[(int) (double) this.__mainmodule_cboalm.SelectedIndex].ToString() + "','" + this.__mainmodule_tcorreo.Text + "','";
        this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tlinea.Text + "','" + this.__mainmodule_tcorreo2.Text + "','" + this.__mainmodule_tremoto.Text + "','" + this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul) + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        if (this.CompareEqual(this.var__mainmodule_empresa, rSide))
        {
          this.var__mainmodule_serverlocal = this.__mainmodule_tserver.Text;
          this.var__mainmodule_base = this.__mainmodule_tbase.Text;
          this.var__mainmodule_usersql = this.__mainmodule_tuser.Text;
          this.var__mainmodule_passsql = this.__mainmodule_tpasssql.Text;
          this.var__mainmodule_portsql = this.__mainmodule_tpuerto.Text;
          this.var__mainmodule_ctrl_alm = this.__mainmodule_tcontrol.Text;
          this.var__mainmodule_almacen = double.Parse(this.__mainmodule_cboalm.Items[(int) (double) this.__mainmodule_cboalm.SelectedIndex].ToString(), (IFormatProvider) b4p.cul);
          this.var__mainmodule_correo = this.__mainmodule_tcorreo.Text;
          this.var__mainmodule_correo2 = this.__mainmodule_tcorreo2.Text;
          this.var__mainmodule_linea = this.__mainmodule_tlinea.Text;
        }
        ((int) MessageBox.Show("Los datos se grabaron satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_sqlserver.close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnsql1_click = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) rSide
          };
          return this.__mainmodule_btnsql1_click();
        }
        this.ShowError(ex, "_mainmodule_btnsql1_click");
        return "";
      }
    }

    private string __mainmodule_btnsql_click()
    {
      try
      {
        this.__mainmodule_sqlserver.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsql_click");
        return "";
      }
    }

    private string __mainmodule_btnsql2_click()
    {
      try
      {
        this.__mainmodule_sqlserver.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsql2_click");
        return "";
      }
    }

    private string __mainmodule_cboempresa1_selectionchanged(
      string var__mainmodule_index,
      string var__mainmodule_value)
    {
      string str1 = "";
      string str2 = "";
      string rSide = "";
      string s = "";
      int num1 = 0;
      try
      {
        if (this.err_mainmodule_cboempresa1_selectionchanged > 0)
        {
          s = (string) this.localVars[3];
          rSide = (string) this.localVars[2];
          str2 = (string) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_cboempresa1_selectionchanged == 1)
          {
            this.err_mainmodule_cboempresa1_selectionchanged = 0;
            ((int) MessageBox.Show("Problema detectado en cboEmpresa_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num1 = 1;
        if (this.LCompareEqual(var__mainmodule_index, -1.0.ToString((IFormatProvider) b4p.cul)))
          return "";
        str1 = this.__mainmodule_cboempresa1.Items[var__mainmodule_index == "" ? 0 : (int) double.Parse(var__mainmodule_index, (IFormatProvider) b4p.cul)].ToString();
        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, nombre, ctrl_alm, almacen, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, linea, correo2, remoto, multialmacen FROM empresas WHERE empresa = '" + str1 + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tserver.Text = this.__mainmodule_reader.GetValue(0);
          this.__mainmodule_tremoto.Text = this.__mainmodule_reader.GetValue(11);
          this.__mainmodule_tbase.Text = this.__mainmodule_reader.GetValue(1);
          this.__mainmodule_tuser.Text = this.__mainmodule_reader.GetValue(2);
          this.__mainmodule_tpasssql.Text = this.__mainmodule_reader.GetValue(3);
          this.__mainmodule_tpuerto.Text = this.__mainmodule_reader.GetValue(4);
          this.__mainmodule_tnombreemp.Text = this.__mainmodule_reader.GetValue(5);
          this.__mainmodule_tcontrol.Text = this.__mainmodule_reader.GetValue(6);
          rSide = this.__mainmodule_reader.GetValue(7);
          this.__mainmodule_tcorreo.Text = this.__mainmodule_reader.GetValue(8);
          this.__mainmodule_tlinea.Text = this.__mainmodule_reader.GetValue(9);
          this.__mainmodule_tcorreo2.Text = this.__mainmodule_reader.GetValue(10);
          if (this.__mainmodule_reader.GetValue(12) == "0")
          {
            this.__mainmodule_chmult.Checked = bool.Parse("false".ToLower(b4p.cul));
            this.__mainmodule_cboalm.SelectedIndex = 0;
            this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(b4p.cul));
          }
          else
          {
            this.__mainmodule_chmult.Checked = bool.Parse("true".ToLower(b4p.cul));
            this.__mainmodule_cboalm.Enabled = bool.Parse("true".ToLower(b4p.cul));
          }
        }
        else
        {
          this.__mainmodule_tserver.Text = "";
          this.__mainmodule_tremoto.Text = "";
          this.__mainmodule_tbase.Text = "";
          this.__mainmodule_tuser.Text = "";
          this.__mainmodule_tpasssql.Text = "";
          this.__mainmodule_tpuerto.Text = "";
          this.__mainmodule_tnombreemp.Text = "";
          this.__mainmodule_tcontrol.Text = "";
          this.__mainmodule_tlinea.Text = "";
          this.__mainmodule_tcorreo.Text = "";
          this.__mainmodule_tcorreo2.Text = "";
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "1"))
        {
          this.__mainmodule_cboalm.SelectedIndex = -1;
          s = "0";
          double num2 = (double) this.__mainmodule_cboalm.Items.Count - 1.0;
          for (double num3 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider) b4p.cul))
          {
            if (this.RCompareEqual(this.__mainmodule_cboalm.Items[s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul)].ToString(), rSide))
            {
              this.__mainmodule_cboalm.SelectedIndex = s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul);
              break;
            }
          }
        }
        this.__mainmodule_tnombreemp.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num1 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cboempresa1_selectionchanged = num1;
          this.localVars = new object[4]
          {
            (object) str1,
            (object) str2,
            (object) rSide,
            (object) s
          };
          return this.__mainmodule_cboempresa1_selectionchanged(var__mainmodule_index, var__mainmodule_value);
        }
        this.ShowError(ex, "_mainmodule_cboempresa1_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_cboimporta_selectionchanged(
      string var__mainmodule_index,
      string var__mainmodule_value)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_cboimporta_selectionchanged > 0 && this.err_mainmodule_cboimporta_selectionchanged == 1)
        {
          this.err_mainmodule_cboimporta_selectionchanged = 0;
          ((int) MessageBox.Show("Problema detectado en cboImporta_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__mainmodule_index, -1.0.ToString((IFormatProvider) b4p.cul)))
          return "";
        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, nombre ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
          this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
          this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
          this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
          this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
        }
        else
        {
          this.var__mainmodule_serverlocal = "";
          this.var__mainmodule_base = "";
          this.var__mainmodule_usersql = "";
          this.var__mainmodule_passsql = "";
          this.var__mainmodule_portsql = "";
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cboimporta_selectionchanged = num;
          this.localVars = new object[0];
          return this.__mainmodule_cboimporta_selectionchanged(var__mainmodule_index, var__mainmodule_value);
        }
        this.ShowError(ex, "_mainmodule_cboimporta_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_invencan_close()
    {
      try
      {
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_ltinven2.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_invencan_close");
        return "";
      }
    }

    private string __mainmodule_image1_click()
    {
      double num1 = 0.0;
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_image1_click > 0)
        {
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_image1_click == 1)
          {
            this.err_mainmodule_image1_click = 0;
            ((int) MessageBox.Show("Problema detectado en Image1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        if (this.__mainmodule_tpassword.Text == "sorom" || this.__mainmodule_tpassword.Text == "Gsorom09" || this.__mainmodule_tpassword.Text == "111222")
        {
          this.__mainmodule_config.show();
        }
        else
        {
          this.var__mainmodule_sql = "SELECT * FROM usuarios WHERE usuario = '" + this.__mainmodule_tusuario.Text;
          this.var__mainmodule_sql = this.var__mainmodule_sql + "' AND password = '" + this.__mainmodule_tpassword.Text + "' AND nivel = 1";
          num1 = 0.0;
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
            num1 = 1.0;
          this.__mainmodule_reader.Close();
          if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
          {
            ((int) MessageBox.Show("Usuario-contraseña incorrecta o sin derecho", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
          this.__mainmodule_config.show();
        }
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_image1_click = num2;
          this.localVars = new object[1]{ (object) num1 };
          return this.__mainmodule_image1_click();
        }
        this.ShowError(ex, "_mainmodule_image1_click");
        return "";
      }
    }

    private string __mainmodule_usuarios_show()
    {
      string lSide = "";
      string s = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_usuarios_show > 0)
        {
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_usuarios_show == 1)
          {
            this.err_mainmodule_usuarios_show = 0;
            ((int) MessageBox.Show("Problema detectado en cboImporta_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_tbluser.dataTable.Clear();
        this.__mainmodule_tbluser.dataTable.AcceptChanges();
        this.var__mainmodule_sql = "SELECT id, usuario, nombre, password, nivel, serie, folio FROM usuarios order by usuario";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tbluser.AddRow(new object[0]);
          s = ((double) this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(2));
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(3));
          lSide = this.__mainmodule_reader.GetValue(4);
          if (this.LCompareEqual(lSide, "1"))
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), "Administrador");
          else
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), "");
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(5));
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(6));
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_label2.BringToFront();
        this.__mainmodule_tusu.BringToFront();
        this.__mainmodule_btnnew.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_usuarios_show = num;
          this.localVars = new object[2]
          {
            (object) lSide,
            (object) s
          };
          return this.__mainmodule_usuarios_show();
        }
        this.ShowError(ex, "_mainmodule_usuarios_show");
        return "";
      }
    }

    private string __mainmodule_btnusr1_click()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      string s1 = "";
      string lSide = "";
      string s2 = "";
      string rSide = "";
      string s3 = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_btnusr1_click > 0)
        {
          s3 = (string) this.localVars[6];
          rSide = (string) this.localVars[5];
          s2 = (string) this.localVars[4];
          lSide = (string) this.localVars[3];
          s1 = (string) this.localVars[2];
          num2 = (double) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_btnusr1_click == 1)
          {
            this.err_mainmodule_btnusr1_click = 0;
            ((int) MessageBox.Show("Ocurrio un problema en btnUsr1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        if (this.__mainmodule_tusu.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor capture el usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_tnombre.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor capture el nombre del usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_tclave.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor capture la contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_tserie.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor capture la serie", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_tfolio.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor capture el folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.Other.IsNumber(this.__mainmodule_tfolio.Text) == "false")
        {
          ((int) MessageBox.Show("Por favor el folio debe numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        s1 = "0";
        num1 = 0.0;
        lSide = this.__mainmodule_tusu.Text;
        s2 = "0";
        double num4 = (double) this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0;
        for (double num5 = s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul); num5 <= num4; s2 = (++num5).ToString((IFormatProvider) b4p.cul))
        {
          rSide = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), true);
          if (this.CompareEqual(lSide, rSide))
          {
            num1 = 1.0;
            s1 = s2;
            break;
          }
        }
        num2 = !(this.__mainmodule_chnivel.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true") ? 0.0 : 1.0;
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
        {
          this.var__mainmodule_sql = "INSERT INTO usuarios (usuario, nombre, password, nivel, serie, folio) VALUES('" + this.__mainmodule_tusu.Text + "','";
          this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tnombre.Text + "','" + this.__mainmodule_tclave.Text + "','" + num2.ToString((IFormatProvider) b4p.cul) + "','" + this.__mainmodule_tserie.Text + "','" + this.__mainmodule_tfolio.Text + "')";
        }
        else
        {
          this.var__mainmodule_sql = "UPDATE usuarios SET nombre = '" + this.__mainmodule_tnombre.Text + "', password = '" + this.__mainmodule_tclave.Text;
          this.var__mainmodule_sql = this.var__mainmodule_sql + "', nivel = " + num2.ToString((IFormatProvider) b4p.cul) + ", serie = '" + this.__mainmodule_tserie.Text + "', folio = " + this.__mainmodule_tfolio.Text;
          this.var__mainmodule_sql = this.var__mainmodule_sql + " WHERE usuario = '" + this.__mainmodule_tusu.Text + "'";
        }
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
        {
          this.__mainmodule_tbluser.AddRow(new object[0]);
          s3 = ((double) this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), this.__mainmodule_tusu.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), this.__mainmodule_tnombre.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), this.__mainmodule_tclave.Text);
          if (this.LCompareEqual(num2.ToString((IFormatProvider) b4p.cul), "1"))
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), "Administrador");
          else
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), "");
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), this.__mainmodule_tserie.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul), this.__mainmodule_tfolio.Text);
        }
        else
        {
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), this.__mainmodule_tusu.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), this.__mainmodule_tnombre.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), this.__mainmodule_tclave.Text);
          if (this.LCompareEqual(num2.ToString((IFormatProvider) b4p.cul), "1"))
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), "Administrador");
          else
            this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), "");
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), this.__mainmodule_tserie.Text);
          this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), this.__mainmodule_tfolio.Text);
        }
        ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tusu.Text = "";
        this.__mainmodule_tnombre.Text = "";
        this.__mainmodule_tclave.Text = "";
        this.__mainmodule_tserie.Text = "";
        this.__mainmodule_tfolio.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnusr1_click = num3;
          this.localVars = new object[7]
          {
            (object) num1,
            (object) num2,
            (object) s1,
            (object) lSide,
            (object) s2,
            (object) rSide,
            (object) s3
          };
          return this.__mainmodule_btnusr1_click();
        }
        this.ShowError(ex, "_mainmodule_btnusr1_click");
        return "";
      }
    }

    private string __mainmodule_btnaceptar_click()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btnaceptar_click > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_btnaceptar_click == 1)
          {
            this.err_mainmodule_btnaceptar_click = 0;
            ((int) MessageBox.Show("Ocurrio un problema btnAceptar_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboempresa.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_tpassword.Text != "sorom" && this.__mainmodule_tpassword.Text != "Gsorom09" && this.__mainmodule_tpassword.Text != "111222")
        {
          this.var__mainmodule_sql = "SELECT nivel, serie, folio FROM usuarios WHERE usuario = '" + this.__mainmodule_tusuario.Text;
          this.var__mainmodule_sql = this.var__mainmodule_sql + "' AND password = '" + this.__mainmodule_tpassword.Text + "'";
          this.var__mainmodule_isadmin = "false";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            lSide = "1";
            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(0)).ToLower(b4p.cul) == "true" && this.__mainmodule_reader.GetValue(0) == "1")
              this.var__mainmodule_isadmin = "true";
          }
          else
            lSide = "0";
          this.__mainmodule_reader.Close();
          if (this.LCompareEqual(lSide, "0"))
          {
            this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + "\\alarma.wav"));
            Thread.Sleep(1500);
            ((int) MessageBox.Show("Usuario o contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
          this.var__mainmodule_userroot = this.__mainmodule_tusuario.Text;
        }
        else
        {
          this.var__mainmodule_userroot = "sorom";
          this.var__mainmodule_isadmin = "true";
        }
        this.var__mainmodule_empresa = this.__mainmodule_cboempresa.Items[(int) (double) this.__mainmodule_cboempresa.SelectedIndex].ToString();
        if (this.__mainmodule_chimportar.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_btnaceptar.Visible = bool.Parse("false".ToLower(b4p.cul));
          this.__mainmodule_btnmain8.Visible = bool.Parse("false".ToLower(b4p.cul));
          Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.__mainmodule_importararticulos();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.__mainmodule_btnaceptar.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_btnmain8.Visible = bool.Parse("true".ToLower(b4p.cul));
          this.__mainmodule_chimportar.Checked = bool.Parse("false".ToLower(b4p.cul));
        }
        this.__mainmodule_frmmenu.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnaceptar_click = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_btnaceptar_click();
        }
        this.ShowError(ex, "_mainmodule_btnaceptar_click");
        return "";
      }
    }

    private string __mainmodule_btnsql3_click()
    {
      string str = "";
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btnsql3_click > 0)
        {
          lSide = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_mainmodule_btnsql3_click == 1)
          {
            this.err_mainmodule_btnsql3_click = 0;
            ((int) MessageBox.Show("Problema detectado en btnSQL3_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboempresa1.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str = this.__mainmodule_cboempresa1.Items[(int) (double) this.__mainmodule_cboempresa1.SelectedIndex].ToString();
        lSide = ((int) MessageBox.Show("Realmente desea eliminar la empresa " + str + "?", "Eliminar empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM empresas WHERE empresa = '" + str + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_tserver.Text = "";
        this.__mainmodule_tbase.Text = "";
        this.__mainmodule_tuser.Text = "";
        this.__mainmodule_tpasssql.Text = "";
        this.__mainmodule_tpuerto.Text = "";
        this.__mainmodule_cboempresa1.SelectedIndex = -1;
        this.__mainmodule_cboalm.SelectedIndex = -1;
        ((int) MessageBox.Show("La empresa se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnsql3_click = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) lSide
          };
          return this.__mainmodule_btnsql3_click();
        }
        this.ShowError(ex, "_mainmodule_btnsql3_click");
        return "";
      }
    }

    private string __mainmodule_tbluser_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_tbluser_selectionchanged > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_tbluser_selectionchanged == 1)
          {
            this.err_mainmodule_tbluser_selectionchanged = 0;
            ((int) MessageBox.Show("Problema detectado en tblUser_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_tusu.Text = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        this.__mainmodule_tnombre.Text = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        this.__mainmodule_tclave.Text = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        lSide = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        if (this.LCompareEqual(lSide, "Administrador"))
          this.__mainmodule_chnivel.Checked = bool.Parse("true".ToLower(b4p.cul));
        else
          this.__mainmodule_chnivel.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_tserie.Text = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        this.__mainmodule_tfolio.Text = (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tbluser_selectionchanged = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_tbluser_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
        }
        this.ShowError(ex, "_mainmodule_tbluser_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_cboempresa_selectionchanged(
      string var__mainmodule_index,
      string var__mainmodule_value)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_cboempresa_selectionchanged > 0 && this.err_mainmodule_cboempresa_selectionchanged == 1)
        {
          this.err_mainmodule_cboempresa_selectionchanged = 0;
          ((int) MessageBox.Show("Problema detectadoi en Empresa_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.__mainmodule_cboempresa.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.var__mainmodule_empresa = this.__mainmodule_cboempresa.Items[(int) (double) this.__mainmodule_cboempresa.SelectedIndex].ToString();
        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2, multialmacen FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
          this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
          this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
          this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
          this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
          this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
          this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), (IFormatProvider) b4p.cul);
          this.var__mainmodule_correo = this.__mainmodule_reader.GetValue(7);
          this.var__mainmodule_nombreempresa = this.__mainmodule_reader.GetValue(8);
          this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(9);
          this.var__mainmodule_correo2 = this.__mainmodule_reader.GetValue(10);
          this.var__mainmodule_multialmacen = double.Parse(this.__mainmodule_reader.GetValue(11), (IFormatProvider) b4p.cul);
        }
        else
          this.var__mainmodule_nombreempresa = "";
        this.__mainmodule_reader.Close();
        this.__mainmodule_ltsocial.Text = this.var__mainmodule_nombreempresa;
        this.__mainmodule_tusuario.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cboempresa_selectionchanged = num;
          this.localVars = new object[0];
          return this.__mainmodule_cboempresa_selectionchanged(var__mainmodule_index, var__mainmodule_value);
        }
        this.ShowError(ex, "_mainmodule_cboempresa_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_cierramsql()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_cierramsql > 0 && this.err_mainmodule_cierramsql == 1)
        {
          this.err_mainmodule_cierramsql = 0;
          return "";
        }
        num = 1;
        this.__mainmodule_msql1.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cierramsql = num;
          this.localVars = new object[0];
          return this.__mainmodule_cierramsql();
        }
        this.ShowError(ex, "_mainmodule_cierramsql");
        return "";
      }
    }

    private string __mainmodule_cierracontrans()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_cierracontrans > 0 && this.err_mainmodule_cierracontrans == 1)
        {
          this.err_mainmodule_cierracontrans = 0;
          return "";
        }
        num = 1;
        this.__mainmodule_con.EndTransaction();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cierracontrans = num;
          this.localVars = new object[0];
          return this.__mainmodule_cierracontrans();
        }
        this.ShowError(ex, "_mainmodule_cierracontrans");
        return "";
      }
    }

    private string __mainmodule_tlinea_keypress(string var__mainmodule_key)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tlinea_keypress");
        return "";
      }
    }

    private string __mainmodule_btnuser_click()
    {
      try
      {
        this.__mainmodule_usuarios.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnuser_click");
        return "";
      }
    }

    private string __mainmodule_btnusr2_click()
    {
      string lSide = "";
      string s = "";
      int num1 = 0;
      try
      {
        if (this.err_mainmodule_btnusr2_click > 0)
        {
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_btnusr2_click == 1)
          {
            this.err_mainmodule_btnusr2_click = 0;
            ((int) MessageBox.Show("Ocurrio un problema en btnUsr2_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num1 = 1;
        if (this.__mainmodule_tusu.Text.Replace(" ", "") == "")
        {
          ((int) MessageBox.Show("Por favor espesifique el usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        lSide = ((int) MessageBox.Show("Realmente desea eliminar al usuario " + this.__mainmodule_tusu.Text + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM usuarios WHERE usuario = '" + this.__mainmodule_tusu.Text + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        s = "0";
        double num2 = (double) this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0;
        for (double num3 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider) b4p.cul))
        {
          if (this.__mainmodule_tusu.Text == (string) this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), true))
          {
            this.__mainmodule_tbluser.dataTable.DefaultView[s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul)].Delete();
            this.__mainmodule_tbluser.dataTable.AcceptChanges();
            break;
          }
        }
        ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tusu.Text = "";
        this.__mainmodule_tnombre.Text = "";
        this.__mainmodule_tclave.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num1 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnusr2_click = num1;
          this.localVars = new object[2]
          {
            (object) lSide,
            (object) s
          };
          return this.__mainmodule_btnusr2_click();
        }
        this.ShowError(ex, "_mainmodule_btnusr2_click");
        return "";
      }
    }

    private string __mainmodule_tusu_gotfocus()
    {
      try
      {
        this.__mainmodule_tusu.SelectionStart = 0;
        this.__mainmodule_tusu.SelectionLength = (int) (double) this.__mainmodule_tusu.Text.Length;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tusu_gotfocus");
        return "";
      }
    }

    private string __mainmodule_tnombre_gotfocus()
    {
      try
      {
        this.__mainmodule_tnombre.SelectionStart = 0;
        this.__mainmodule_tnombre.SelectionLength = (int) (double) this.__mainmodule_tnombre.Text.Length;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tnombre_gotfocus");
        return "";
      }
    }

    private string __mainmodule_tclave_gotfocus()
    {
      try
      {
        this.__mainmodule_tclave.SelectionStart = 0;
        this.__mainmodule_tclave.SelectionLength = (int) (double) this.__mainmodule_tclave.Text.Length;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tclave_gotfocus");
        return "";
      }
    }

    private string __mainmodule_btnusr3_click()
    {
      try
      {
        this.__mainmodule_usuarios.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnusr3_click");
        return "";
      }
    }

    private string __mainmodule_btnutils_click()
    {
      double num1 = 0.0;
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_btnutils_click > 0)
        {
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_btnutils_click == 1)
          {
            this.err_mainmodule_btnutils_click = 0;
            ((int) MessageBox.Show("Ocurrio un problema", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num2 = 1;
        this.__mainmodule_frmseries.show();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnutils_click = num2;
          this.localVars = new object[1]{ (object) num1 };
          return this.__mainmodule_btnutils_click();
        }
        this.ShowError(ex, "_mainmodule_btnutils_click");
        return "";
      }
    }

    private string __mainmodule_tarticulo_gotfocus()
    {
      try
      {
        this.__mainmodule_tarticulo.SelectionStart = 0;
        this.__mainmodule_tarticulo.SelectionLength = (int) (double) this.__mainmodule_tarticulo.Text.Length;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tarticulo_gotfocus");
        return "";
      }
    }

    private string __mainmodule_btnnew_click()
    {
      try
      {
        this.__mainmodule_chnivel.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_tusu.Text = "";
        this.__mainmodule_tnombre.Text = "";
        this.__mainmodule_tclave.Text = "";
        this.__mainmodule_tusu.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnnew_click");
        return "";
      }
    }

    private string __mainmodule_mnusalircan_click()
    {
      try
      {
        this.__mainmodule_invencan.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnusalircan_click");
        return "";
      }
    }

    private string __mainmodule_menfin_click()
    {
      try
      {
        this.__mainmodule_invent.close();
        this.__mainmodule_frmmenu.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_menfin_click");
        return "";
      }
    }

    private string __mainmodule_enviar_close()
    {
      try
      {
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_ltinven2.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_enviar_close");
        return "";
      }
    }

    private string __mainmodule_btnenviarinven_click()
    {
      try
      {
        this.__mainmodule_enviar.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnenviarinven_click");
        return "";
      }
    }

    private string __mainmodule_chcaja_click()
    {
      try
      {
        if (this.__mainmodule_chcaja.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_sql = "UPDATE config SET sistema = 0";
          this.var__mainmodule_sistema = 0.0;
        }
        else
        {
          this.var__mainmodule_sql = "UPDATE config SET sistema = 1";
          this.var__mainmodule_sistema = 1.0;
        }
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_chcaja_click");
        return "";
      }
    }

    private string __mainmodule_mnusql2_click()
    {
      try
      {
        this.__mainmodule_btnsql1_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnusql2_click");
        return "";
      }
    }

    private string __mainmodule_mnusql3_click()
    {
      try
      {
        this.__mainmodule_btnsql3_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnusql3_click");
        return "";
      }
    }

    private string __mainmodule_mnusql4_click()
    {
      try
      {
        this.__mainmodule_btnsql2_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnusql4_click");
        return "";
      }
    }

    private string __mainmodule_invent_close()
    {
      try
      {
        this.__mainmodule_bk_txt();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_invent_close");
        return "";
      }
    }

    private string __mainmodule_enviaraunapc(string var__mainmodule_farchivo)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_enviaraunapc > 0 && this.err_mainmodule_enviaraunapc == 1)
        {
          this.err_mainmodule_enviaraunapc = 0;
          return "";
        }
        num = 1;
        this.var__mainmodule_rutapc = this.__mainmodule_trutapc.Text;
        this.var__mainmodule_twifi = "0";
        this.__mainmodule_timer1.Interval = 800;
        this.__mainmodule_timer1.Enabled = bool.Parse("true".ToLower(b4p.cul));
        while (!(Directory.Exists(Path.Combine(this.b4pdir, this.var__mainmodule_rutapc)).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true") && !this.LCompareEqual(this.var__mainmodule_twifi, "32"))
          Application.DoEvents();
        File.Copy(Path.Combine(this.b4pdir, var__mainmodule_farchivo), Path.Combine(this.b4pdir, this.b4pdir + "\\INVENT" + DateTime.Now.Day.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Month.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + "_" + DateTime.Now.Hour.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Minute.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Second.ToString((IFormatProvider) b4p.cul) + ".CSV"), true);
        File.Copy(Path.Combine(this.b4pdir, var__mainmodule_farchivo), Path.Combine(this.b4pdir, this.var__mainmodule_rutapc + "\\INVENT" + DateTime.Now.Day.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Month.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + "_" + DateTime.Now.Hour.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Minute.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Second.ToString((IFormatProvider) b4p.cul) + ".CSV"), true);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_enviaraunapc = num;
          this.localVars = new object[0];
          return this.__mainmodule_enviaraunapc(var__mainmodule_farchivo);
        }
        this.ShowError(ex, "_mainmodule_enviaraunapc");
        return "";
      }
    }

    private string __mainmodule_mnuenviarsae_click()
    {
      try
      {
        this.__mainmodule_frmacceso.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuenviarsae_click");
        return "";
      }
    }

    private string __mainmodule_validacampo(
      string var__mainmodule_fcampo,
      string var__mainmodule_ftipo)
    {
      try
      {
        var__mainmodule_fcampo = var__mainmodule_fcampo.ToUpper(b4p.cul);
        if (!this.LCompareEqual(var__mainmodule_fcampo, "NULL"))
          return var__mainmodule_fcampo;
        return this.LCompareEqual(var__mainmodule_ftipo, "C") ? "" : "0";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_validacampo");
        return "";
      }
    }

    private string __mainmodule_btnexistminve_click()
    {
      try
      {
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_procminve.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnexistminve_click");
        return "";
      }
    }

    private string __mainmodule_procminve_show()
    {
      try
      {
        this.__mainmodule_btngenerar.BringToFront();
        this.__mainmodule_btnexistminve.BringToFront();
        this.__mainmodule_numdia.Value = (Decimal) (int) (double) DateTime.Now.Day;
        this.__mainmodule_nummes.Value = (Decimal) (int) (double) DateTime.Now.Month;
        this.__mainmodule_numano.Value = (Decimal) (int) (double) DateTime.Now.Year;
        if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "0"))
          this.__mainmodule_lalma.Text = "1";
        else
          this.__mainmodule_lalma.Text = this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
        string lower1;
        string lower2;
        this.__mainmodule_trefminve.Text = "II" + ((lower1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Day).ToString(lower1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Day).ToString(lower1, (IFormatProvider) b4p.cul)) + ((lower2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Month).ToString(lower2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Month).ToString(lower2, (IFormatProvider) b4p.cul)) + DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + "_AL" + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltserver.Text = this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ", " + this.var__mainmodule_base + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql;
        this.__mainmodule_btngenerar.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_opminve2.Checked = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_procminve_show");
        return "";
      }
    }

    private string __mainmodule_btngenerar_click()
    {
      try
      {
        if (this.__mainmodule_opminve3.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_inventario_acumulativo_proc_almacenado();
        else
          this.__mainmodule_inventario_directo_proc_almacenado();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btngenerar_click");
        return "";
      }
    }

    private string __mainmodule_inventario_directo_proc_almacenado()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      string str2 = "";
      string lSide1 = "";
      string str3 = "";
      double num4 = 0.0;
      string str4 = "";
      double num5 = 0.0;
      string lSide2 = "";
      string str5 = "";
      string format1 = "";
      string format2 = "";
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string str6 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string lSide3 = "";
      string query = "";
      int num6 = 0;
      try
      {
        if (this.err_mainmodule_inventario_directo_proc_almacenado > 0)
        {
          query = (string) this.localVars[22];
          lSide3 = (string) this.localVars[21];
          str9 = (string) this.localVars[20];
          str8 = (string) this.localVars[19];
          str7 = (string) this.localVars[18];
          str6 = (string) this.localVars[17];
          s3 = (string) this.localVars[16];
          s2 = (string) this.localVars[15];
          s1 = (string) this.localVars[14];
          format2 = (string) this.localVars[13];
          format1 = (string) this.localVars[12];
          str5 = (string) this.localVars[11];
          lSide2 = (string) this.localVars[10];
          num5 = (double) this.localVars[9];
          str4 = (string) this.localVars[8];
          num4 = (double) this.localVars[7];
          str3 = (string) this.localVars[6];
          lSide1 = (string) this.localVars[5];
          str2 = (string) this.localVars[4];
          num3 = (double) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_inventario_directo_proc_almacenado == 1)
          {
            this.err_mainmodule_inventario_directo_proc_almacenado = 0;
            this.__mainmodule_cierramsql();
            this.__mainmodule_cierrareader();
            ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num6 = 1;
        lSide2 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide2, "7"))
          return "";
        this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(b4p.cul));
        this.var__mainmodule_errfound = bool.Parse("false");
        this.__mainmodule_copiaarchivos2();
        this.__mainmodule_ltmreg.Text = "";
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\CONECT SQL ERROR.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          return "";
        }
        str5 = this.__mainmodule_trefminve.Text.Replace(" ", "");
        if (str5.Length.ToString((IFormatProvider) b4p.cul) == "0")
          str5 = "II" + this.__mainmodule_numano.Value.ToString((IFormatProvider) b4p.cul) + this.__mainmodule_nummes.Value.ToString((IFormatProvider) b4p.cul) + this.__mainmodule_numdia.Value.ToString((IFormatProvider) b4p.cul) + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Minute).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Minute).ToString(format1, (IFormatProvider) b4p.cul)) + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Second).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Second).ToString(format2, (IFormatProvider) b4p.cul));
        s1 = "0";
        s2 = "0";
        if (this.__mainmodule_opminve1.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.var__mainmodule_sql = "Select I.articulo, Max(P.existencia), Max(P.costo_prom), Max(P.uni_med), ";
          this.var__mainmodule_sql += "SUM(I.cantidad), Max(P.status), Max(P.descrip), Max(P.linea) FROM minve I ";
          this.var__mainmodule_sql += "LEFT JOIN prods P ON P.articulo = I.articulo ";
          this.var__mainmodule_sql += "WHERE I.nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo ORDER BY I.articulo";
        }
        else
        {
          this.var__mainmodule_sql = "SELECT I.articulo, I.existencia, I.costo_prom, I.uni_med, (SELECT exist FROM inven P WHERE ";
          this.var__mainmodule_sql += "P.articulo = i.articulo), status, descrip, linea FROM prods I ORDER BY descrip";
        }
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          lSide1 = this.__mainmodule_reader.GetValue(0);
          num1 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(b4p.cul) == "true")
          {
            num2 = double.Parse(this.__mainmodule_reader.GetValue(4), (IFormatProvider) b4p.cul);
            num3 = num2;
          }
          else
            num2 = 0.0;
          s3 = ((s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul)) + num2).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_ltmart.Text = lSide1;
          this.__mainmodule_ltmcant.Text = num2.ToString((IFormatProvider) b4p.cul);
          str6 = this.__mainmodule_reader.GetValue(2);
          str7 = this.__mainmodule_reader.GetValue(3);
          str8 = this.__mainmodule_reader.GetValue(6);
          this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(7);
          num4 = num1 - num2;
          str9 = num4 <= 0.0 ? this.__mainmodule_tconm.Text : this.__mainmodule_tconsal.Text;
          lSide3 = "0";
          if (this.__mainmodule_opminve1.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            num4 = num2;
            str9 = this.__mainmodule_tconm.Text;
            if (num2 > 0.0)
              lSide3 = "1";
          }
          else
            lSide3 = "1";
          if (this.LCompareEqual(lSide1, "CDN000160AC"))
            str4 = "";
          s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          if (num2 > 0.0)
            s2 = ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_ltmreg.Text = s2 + "/" + s1;
          this.__mainmodule_ltpiezas.Text = s3;
          if (this.LCompareEqual(lSide3, "1"))
          {
            num5 = 0.0;
            if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "1"))
              num5 = this.var__mainmodule_almacen;
            query = "EXECUTE Inve_desde_pda " + num2.ToString((IFormatProvider) b4p.cul) + "," + num5.ToString((IFormatProvider) b4p.cul) + "," + str6 + ",'";
            query = query + str5 + "','" + lSide1 + "','" + str8 + "','";
            query = query + this.var__mainmodule_linea + "','" + str7 + "'," + str6 + "," + str6 + ",1";
            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\PROCEDIMIENTO ALMACENADO.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError + "\r\n" + str9);
              if (this.htStreams.Contains((object) "_mainmodule_c1"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c1");
                GC.Collect();
              }
              this.__mainmodule_msql1.Close();
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              ((int) MessageBox.Show("Problema en el PROCEDIMIENTO ALMACENADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
              break;
            }
            if (this.__mainmodule_opminve1.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
            {
              this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide1 + "'";
              this.__mainmodule_cmd2.ExecuteNonQuery();
            }
          }
          else if (this.__mainmodule_opminve1.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide1 + "'";
            this.__mainmodule_cmd2.ExecuteNonQuery();
          }
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_msql1.Close();
        ((int) MessageBox.Show("ok Articulos procesados " + s1, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_bk_txt();
        this.__mainmodule_copiaarchivos2();
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num6 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_inventario_directo_proc_almacenado = num6;
          this.localVars = new object[23]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) num3,
            (object) str2,
            (object) lSide1,
            (object) str3,
            (object) num4,
            (object) str4,
            (object) num5,
            (object) lSide2,
            (object) str5,
            (object) format1,
            (object) format2,
            (object) s1,
            (object) s2,
            (object) s3,
            (object) str6,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) lSide3,
            (object) query
          };
          return this.__mainmodule_inventario_directo_proc_almacenado();
        }
        this.ShowError(ex, "_mainmodule_inventario_directo_proc_almacenado");
        return "";
      }
    }

    private string __mainmodule_inventario_acumulativo_proc_almacenado()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      string str2 = "";
      string lSide1 = "";
      string str3 = "";
      double num4 = 0.0;
      string str4 = "";
      double num5 = 0.0;
      double num6 = 0.0;
      string lSide2 = "";
      string str5 = "";
      string format1 = "";
      string format2 = "";
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string str6 = "";
      string str7 = "";
      string str8 = "";
      string lSide3 = "";
      string query = "";
      int num7 = 0;
      try
      {
        if (this.err_mainmodule_inventario_acumulativo_proc_almacenado > 0)
        {
          query = (string) this.localVars[22];
          lSide3 = (string) this.localVars[21];
          str8 = (string) this.localVars[20];
          str7 = (string) this.localVars[19];
          str6 = (string) this.localVars[18];
          s3 = (string) this.localVars[17];
          s2 = (string) this.localVars[16];
          s1 = (string) this.localVars[15];
          format2 = (string) this.localVars[14];
          format1 = (string) this.localVars[13];
          str5 = (string) this.localVars[12];
          lSide2 = (string) this.localVars[11];
          num6 = (double) this.localVars[10];
          num5 = (double) this.localVars[9];
          str4 = (string) this.localVars[8];
          num4 = (double) this.localVars[7];
          str3 = (string) this.localVars[6];
          lSide1 = (string) this.localVars[5];
          str2 = (string) this.localVars[4];
          num3 = (double) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_inventario_acumulativo_proc_almacenado == 1)
          {
            this.err_mainmodule_inventario_acumulativo_proc_almacenado = 0;
            this.__mainmodule_cierramsql();
            this.__mainmodule_cierrareader();
            ((int) MessageBox.Show("Problema al enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num7 = 1;
        lSide2 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide2, "7"))
          return "";
        this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(b4p.cul));
        this.var__mainmodule_errfound = bool.Parse("false");
        this.__mainmodule_copiaarchivos2();
        this.__mainmodule_ltmreg.Text = "";
        if (this.Other.IsNumber(this.__mainmodule_tconm.Text) == "false")
        {
          ((int) MessageBox.Show("El concepto es numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        str5 = this.__mainmodule_trefminve.Text.Replace(" ", "");
        if (str5.Length.ToString((IFormatProvider) b4p.cul) == "0")
          str5 = "II" + this.__mainmodule_numano.Value.ToString((IFormatProvider) b4p.cul) + this.__mainmodule_nummes.Value.ToString((IFormatProvider) b4p.cul) + this.__mainmodule_numdia.Value.ToString((IFormatProvider) b4p.cul) + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Minute).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Minute).ToString(format1, (IFormatProvider) b4p.cul)) + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) DateTime.Now.Second).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) DateTime.Now.Second).ToString(format2, (IFormatProvider) b4p.cul));
        s1 = "0";
        s2 = "0";
        this.var__mainmodule_sql = "Select I.articulo, Max(P.existencia), Max(P.costo_prom), Max(P.uni_med), ";
        this.var__mainmodule_sql += "SUM(I.cantidad), Max(P.status), Max(P.descrip), Max(P.linea) FROM minve I ";
        this.var__mainmodule_sql += "LEFT JOIN prods P ON P.articulo = I.articulo ";
        this.var__mainmodule_sql += "WHERE I.nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo ORDER BY I.articulo";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          lSide1 = this.__mainmodule_reader.GetValue(0);
          num1 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(b4p.cul) == "true")
          {
            num2 = double.Parse(this.__mainmodule_reader.GetValue(4), (IFormatProvider) b4p.cul);
            num3 = num2;
          }
          else
            num2 = 0.0;
          s3 = ((s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul)) + num2).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_ltmart.Text = lSide1;
          this.__mainmodule_ltmcant.Text = num2.ToString((IFormatProvider) b4p.cul);
          str6 = this.__mainmodule_reader.GetValue(2);
          str7 = this.__mainmodule_reader.GetValue(3);
          str8 = this.__mainmodule_reader.GetValue(6);
          this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(7);
          num4 = num1 - num2;
          lSide3 = "0";
          if (this.__mainmodule_opminve1.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            num4 = num2;
            if (num2 > 0.0)
              lSide3 = "1";
          }
          else
            lSide3 = "1";
          if (this.LCompareEqual(lSide1, "CDN000160AC"))
            str4 = "";
          num6 = double.Parse(this.__mainmodule_tconm.Text, (IFormatProvider) b4p.cul);
          s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          if (num2 > 0.0)
            s2 = ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_ltmreg.Text = s2 + "/" + s1;
          this.__mainmodule_ltpiezas.Text = s3;
          if (this.LCompareEqual(lSide3, "1"))
          {
            num5 = 0.0;
            if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "1"))
              num5 = this.var__mainmodule_almacen;
            query = "EXECUTE Inve_desde_pda_opcion2 " + num2.ToString((IFormatProvider) b4p.cul) + "," + num5.ToString((IFormatProvider) b4p.cul) + "," + str6 + "," + num6.ToString((IFormatProvider) b4p.cul) + ",'";
            query = query + str5 + "','" + lSide1 + "','" + str8 + "','";
            query = query + this.var__mainmodule_linea + "','" + str7 + "'," + str6 + "," + str6 + ",1";
            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\PROCEDIMIENTO ALMACENADO.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
              if (this.htStreams.Contains((object) "_mainmodule_c1"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c1");
                GC.Collect();
              }
              this.__mainmodule_msql1.Close();
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              ((int) MessageBox.Show("Problema en el PROCEDIMIENTO ALMACENADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
              break;
            }
            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide1 + "'";
            this.__mainmodule_cmd2.ExecuteNonQuery();
          }
          else
          {
            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide1 + "'";
            this.__mainmodule_cmd2.ExecuteNonQuery();
          }
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_msql1.Close();
        ((int) MessageBox.Show("ok Articulos procesados " + s1, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_bk_txt();
        this.__mainmodule_copiaarchivos2();
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num7 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_inventario_acumulativo_proc_almacenado = num7;
          this.localVars = new object[23]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) num3,
            (object) str2,
            (object) lSide1,
            (object) str3,
            (object) num4,
            (object) str4,
            (object) num5,
            (object) num6,
            (object) lSide2,
            (object) str5,
            (object) format1,
            (object) format2,
            (object) s1,
            (object) s2,
            (object) s3,
            (object) str6,
            (object) str7,
            (object) str8,
            (object) lSide3,
            (object) query
          };
          return this.__mainmodule_inventario_acumulativo_proc_almacenado();
        }
        this.ShowError(ex, "_mainmodule_inventario_acumulativo_proc_almacenado");
        return "";
      }
    }

    private string __mainmodule_inventario_directo()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      string str2 = "";
      string lSide1 = "";
      string str3 = "";
      double num4 = 0.0;
      string str4 = "";
      string lSide2 = "";
      string str5 = "";
      string format1 = "";
      string format2 = "";
      string str6 = "";
      string query = "";
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string format3 = "";
      string format4 = "";
      string str10 = "";
      string str11 = "";
      string str12 = "";
      string str13 = "";
      string str14 = "";
      string str15 = "";
      string str16 = "";
      string str17 = "";
      string str18 = "";
      string s4 = "";
      string lSide3 = "";
      string s5 = "";
      string str19 = "";
      string str20 = "";
      string str21 = "";
      string str22 = "";
      string str23 = "";
      string str24 = "";
      string str25 = "";
      string str26 = "";
      string lSide4 = "";
      int num5 = 0;
      try
      {
        if (this.err_mainmodule_inventario_directo > 0)
        {
          lSide4 = (string) this.localVars[43];
          str26 = (string) this.localVars[42];
          str25 = (string) this.localVars[41];
          str24 = (string) this.localVars[40];
          str23 = (string) this.localVars[39];
          str22 = (string) this.localVars[38];
          str21 = (string) this.localVars[37];
          str20 = (string) this.localVars[36];
          str19 = (string) this.localVars[35];
          s5 = (string) this.localVars[34];
          lSide3 = (string) this.localVars[33];
          s4 = (string) this.localVars[32];
          str18 = (string) this.localVars[31];
          str17 = (string) this.localVars[30];
          str16 = (string) this.localVars[29];
          str15 = (string) this.localVars[28];
          str14 = (string) this.localVars[27];
          str13 = (string) this.localVars[26];
          str12 = (string) this.localVars[25];
          str11 = (string) this.localVars[24];
          str10 = (string) this.localVars[23];
          format4 = (string) this.localVars[22];
          format3 = (string) this.localVars[21];
          str9 = (string) this.localVars[20];
          str8 = (string) this.localVars[19];
          str7 = (string) this.localVars[18];
          s3 = (string) this.localVars[17];
          s2 = (string) this.localVars[16];
          s1 = (string) this.localVars[15];
          query = (string) this.localVars[14];
          str6 = (string) this.localVars[13];
          format2 = (string) this.localVars[12];
          format1 = (string) this.localVars[11];
          str5 = (string) this.localVars[10];
          lSide2 = (string) this.localVars[9];
          str4 = (string) this.localVars[8];
          num4 = (double) this.localVars[7];
          str3 = (string) this.localVars[6];
          lSide1 = (string) this.localVars[5];
          str2 = (string) this.localVars[4];
          num3 = (double) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_inventario_directo == 1)
          {
            this.err_mainmodule_inventario_directo = 0;
            this.__mainmodule_cierramsql();
            ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num5 = 1;
        int num6 = (int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        lSide2 = num6.ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide2, "7"))
          return "";
        this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(b4p.cul));
        this.var__mainmodule_errfound = bool.Parse("false");
        this.__mainmodule_copiaarchivos2();
        this.__mainmodule_importararticulosupdateexist();
        this.__mainmodule_ltmreg.Text = "";
        if (this.LCompareEqual(this.var__mainmodule_errfound.ToString().ToLower(b4p.cul), "true"))
        {
          ((int) MessageBox.Show("Ocurrio un error al intentar obtener las existencias actualizasdas, proceso cancelado", "Enviar inventario", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str5 = this.__mainmodule_numano.Value.ToString((IFormatProvider) b4p.cul) + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) this.__mainmodule_nummes.Value).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) this.__mainmodule_nummes.Value).ToString(format1, (IFormatProvider) b4p.cul)) + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) this.__mainmodule_numdia.Value).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) this.__mainmodule_numdia.Value).ToString(format2, (IFormatProvider) b4p.cul));
        str6 = str5 + " " + new DateTime((long) (double) DateTime.Now.Ticks).ToString(this.timeFormat, (IFormatProvider) b4p.cul);
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        query = "SELECT TOP 1 NUM_MOV, CVE_FOLIO FROM MINVE" + this.var__mainmodule_empresa + " ORDER BY NUM_MOV DESC";
        if (this.__mainmodule_msql1.ExecuteQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_msql1.Advance();
          s1 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("CVE_FOLIO"), "C");
          double num7;
          if (this.Other.IsNumber(s1).ToLower(b4p.cul) == "true")
          {
            s2 = s1;
            num7 = (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0;
            s2 = num7.ToString((IFormatProvider) b4p.cul);
            s1 = s2;
          }
          else
            s1 = "1";
          s3 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("NUM_MOV"), "N");
          if (this.Other.IsNumber(s3).ToLower(b4p.cul) == "true")
          {
            num7 = (s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul)) + 1.0;
            s2 = num7.ToString((IFormatProvider) b4p.cul);
          }
          else
            s2 = "1";
          str7 = "M";
          str8 = "0";
          str9 = this.__mainmodule_trefminve.Text.Replace(" ", "");
          num6 = str9.Length;
          if (num6.ToString((IFormatProvider) b4p.cul) == "0")
          {
            string[] strArray1 = new string[6];
            strArray1[0] = "II";
            string[] strArray2 = strArray1;
            Decimal num8 = this.__mainmodule_numano.Value;
            string str27 = num8.ToString((IFormatProvider) b4p.cul);
            strArray2[1] = str27;
            string[] strArray3 = strArray1;
            num8 = this.__mainmodule_nummes.Value;
            string str28 = num8.ToString((IFormatProvider) b4p.cul);
            strArray3[2] = str28;
            string[] strArray4 = strArray1;
            num8 = this.__mainmodule_numdia.Value;
            string str29 = num8.ToString((IFormatProvider) b4p.cul);
            strArray4[3] = str29;
            string[] strArray5 = strArray1;
            string str30;
            if ((format3 = "D2".ToLower(b4p.cul))[0] == 'd')
            {
              num6 = (int) (double) DateTime.Now.Minute;
              str30 = num6.ToString(format3, (IFormatProvider) b4p.cul);
            }
            else
            {
              num7 = (double) DateTime.Now.Minute;
              str30 = num7.ToString(format3, (IFormatProvider) b4p.cul);
            }
            strArray5[4] = str30;
            string[] strArray6 = strArray1;
            string str31;
            if ((format4 = "D2".ToLower(b4p.cul))[0] == 'd')
            {
              num6 = (int) (double) DateTime.Now.Second;
              str31 = num6.ToString(format4, (IFormatProvider) b4p.cul);
            }
            else
            {
              num7 = (double) DateTime.Now.Second;
              str31 = num7.ToString(format4, (IFormatProvider) b4p.cul);
            }
            strArray6[5] = str31;
            str9 = string.Concat(strArray1);
          }
          str10 = "";
          str11 = "";
          str12 = "0";
          str13 = "0";
          str14 = "P";
          str15 = "1";
          str16 = "S";
          str17 = "N";
          str18 = "0";
          this.var__mainmodule_sql = "SELECT I.articulo, I.existencia, I.costo_prom, I.uni_med, (SELECT exist FROM inven P WHERE ";
          this.var__mainmodule_sql += "P.articulo = i.articulo), status FROM prods I WHERE status = 0 ORDER BY descrip";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          s4 = "0";
          bool flag;
          while (true)
          {
            flag = this.__mainmodule_reader.ReadNextRow();
            if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
            {
              Application.DoEvents();
              lSide1 = this.__mainmodule_reader.GetValue(0);
              num1 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
              if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(b4p.cul) == "true")
              {
                num2 = double.Parse(this.__mainmodule_reader.GetValue(4), (IFormatProvider) b4p.cul);
                num3 = num2;
              }
              else
                num2 = 0.0;
              lSide3 = this.__mainmodule_reader.GetValue(5);
              num7 = (s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul)) + num2;
              s5 = num7.ToString((IFormatProvider) b4p.cul);
              this.__mainmodule_ltmart.Text = lSide1;
              this.__mainmodule_ltmcant.Text = num2.ToString((IFormatProvider) b4p.cul);
              str19 = this.__mainmodule_reader.GetValue(2);
              str20 = "0";
              str21 = str19;
              str22 = str19;
              str23 = this.__mainmodule_reader.GetValue(3);
              num4 = num1 - num2;
              if (this.LCompareEqual(lSide1, "GRP000127OL"))
              {
                num7 = -1.0;
                str24 = num7.ToString((IFormatProvider) b4p.cul);
              }
              if (num4 > 0.0)
              {
                str25 = this.__mainmodule_tconsal.Text;
                num7 = -1.0;
                str24 = num7.ToString((IFormatProvider) b4p.cul);
                num7 = Math.Abs(num4);
                str26 = " - " + num7.ToString((IFormatProvider) b4p.cul);
              }
              else
              {
                str25 = this.__mainmodule_tconm.Text;
                str24 = "1";
                num7 = Math.Abs(num4);
                str26 = " + " + num7.ToString((IFormatProvider) b4p.cul);
              }
              lSide4 = "0";
              flag = this.__mainmodule_opminve1.Checked;
              if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
              {
                if (num2 > 0.0)
                  lSide4 = "1";
              }
              else
                lSide4 = "1";
              if (num2 > 0.0)
                str4 = "";
              if (this.LCompareEqual(lSide1, "ANI000018PL"))
                str4 = "";
              if (this.LCompareEqual(lSide4, "1"))
              {
                if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "1"))
                {
                  query = "UPDATE MULT" + this.var__mainmodule_empresa + " SET EXIST = " + num2.ToString((IFormatProvider) b4p.cul);
                  query = query + " WHERE CVE_ART = '" + lSide1 + "' AND CVE_ALM = " + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
                  flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
                  if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
                    break;
                }
                query = "UPDATE INVE" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) " + str26 + " WHERE CVE_ART = '" + lSide1 + "'";
                flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
                if (!(flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false"))
                {
                  num7 = Math.Abs(num4);
                  if (num7.ToString((IFormatProvider) b4p.cul) != "0" && this.LCompareEqual(lSide3, "0"))
                  {
                    this.__mainmodule_ltmreg.Text = s4 + "/" + s5;
                    num7 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) + 1.0;
                    s4 = num7.ToString((IFormatProvider) b4p.cul);
                    query = "INSERT INTO MINVE" + this.var__mainmodule_empresa + " (CVE_ART, ALMACEN, NUM_MOV, CVE_CPTO, VEND, ";
                    query += "FECHA_DOCU, TIPO_DOC, REFER, CLAVE_CLPV, CANT, CANT_COST, PRECIO, COSTO, ";
                    query += "REG_SERIE, UNI_VENTA, E_LTPD, EXISTENCIA, TIPO_PROD, FACTOR_CON, FECHAELAB, ";
                    query += "CVE_FOLIO, SIGNO, COSTEADO, COSTO_PROM_INI, COSTO_PROM_FIN, DESDE_INVE, ";
                    query = query + "MOV_ENLAZADO, AFEC_COI) Values('" + lSide1 + "','" + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
                    query = query + "','" + s2 + "','" + str25 + "','" + str11 + "','";
                    query = query + str5 + "','" + str7 + "','" + str9 + "','" + str10;
                    string[] strArray7 = new string[8];
                    strArray7[0] = query;
                    strArray7[1] = "','";
                    string[] strArray8 = strArray7;
                    num7 = Math.Abs(num4);
                    string str32 = num7.ToString((IFormatProvider) b4p.cul);
                    strArray8[2] = str32;
                    strArray7[3] = "','";
                    strArray7[4] = str20;
                    strArray7[5] = "','";
                    strArray7[6] = str8;
                    strArray7[7] = "','";
                    query = string.Concat(strArray7);
                    query = query + str19 + "','" + str12 + "','" + str23 + "','" + str13;
                    query = query + "','" + num2.ToString((IFormatProvider) b4p.cul) + "','";
                    query = query + str14 + "','" + str15 + "','" + str6 + "','";
                    query = query + s1 + "','" + str24 + "','" + str16 + "','" + str21 + "','";
                    query = query + str22 + "','" + str17 + "','" + str18 + "','S')";
                    flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
                    if (!(flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false"))
                    {
                      num7 = (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0;
                      s2 = num7.ToString((IFormatProvider) b4p.cul);
                    }
                    else
                      goto label_57;
                  }
                  this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide1 + "'";
                  this.__mainmodule_cmd2.ExecuteNonQuery();
                  this.__mainmodule_cmd2.CommandText = "UPDATE prods SET status = 1 WHERE articulo = '" + lSide1 + "'";
                  this.__mainmodule_cmd2.ExecuteNonQuery();
                }
                else
                  goto label_52;
              }
              else
              {
                this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide1 + "'";
                this.__mainmodule_cmd2.ExecuteNonQuery();
                this.__mainmodule_cmd2.CommandText = "UPDATE prods SET status = 1 WHERE articulo = '" + lSide1 + "'";
                this.__mainmodule_cmd2.ExecuteNonQuery();
              }
            }
            else
              goto label_64;
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO DIRECTO UPDATE MULT.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num6 = (int) MessageBox.Show("Problema detectado 2578", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num6.ToString((IFormatProvider) b4p.cul);
          return "";
label_52:
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO DIRECTO UPDATE INVEN.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num6 = (int) MessageBox.Show("Problema detectado 2581", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num6.ToString((IFormatProvider) b4p.cul);
          return "";
label_57:
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO DIRECTO MINVE.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num6 = (int) MessageBox.Show("Problema detectado 2621", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num6.ToString((IFormatProvider) b4p.cul);
          return "";
label_64:
          this.__mainmodule_reader.Close();
          if ((s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) > 0.0)
          {
            query = "UPDATE TBLCONTROL" + this.var__mainmodule_empresa + " SET ULT_CVE = (SELECT ISNULL(MAX(NUM_MOV),0) FROM MINVE" + this.var__mainmodule_empresa;
            query += ") WHERE ID_TABLA = 44";
            flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
            if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO DIRECTO TBLCONTROL2.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
              if (this.htStreams.Contains((object) "_mainmodule_c1"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c1");
                GC.Collect();
              }
              this.__mainmodule_msql1.Close();
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              num6 = (int) MessageBox.Show("Problema detectado 2647", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
              num6.ToString((IFormatProvider) b4p.cul);
              return "";
            }
          }
          this.__mainmodule_msql1.Close();
          num6 = (int) MessageBox.Show("ok Articulos procesados " + s4, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num6.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_copiaarchivos2();
          this.__mainmodule_ltinven2.Text = "";
          this.__mainmodule_ltinven.Text = "";
          return "";
        }
        this.__mainmodule_msql1.Close();
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        num6 = (int) MessageBox.Show("Problema detectado 1894", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        num6.ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num5 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_inventario_directo = num5;
          this.localVars = new object[44]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) num3,
            (object) str2,
            (object) lSide1,
            (object) str3,
            (object) num4,
            (object) str4,
            (object) lSide2,
            (object) str5,
            (object) format1,
            (object) format2,
            (object) str6,
            (object) query,
            (object) s1,
            (object) s2,
            (object) s3,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) format3,
            (object) format4,
            (object) str10,
            (object) str11,
            (object) str12,
            (object) str13,
            (object) str14,
            (object) str15,
            (object) str16,
            (object) str17,
            (object) str18,
            (object) s4,
            (object) lSide3,
            (object) s5,
            (object) str19,
            (object) str20,
            (object) str21,
            (object) str22,
            (object) str23,
            (object) str24,
            (object) str25,
            (object) str26,
            (object) lSide4
          };
          return this.__mainmodule_inventario_directo();
        }
        this.ShowError(ex, "_mainmodule_inventario_directo");
        return "";
      }
    }

    private string __mainmodule_inventario_acumulativo()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      string str2 = "";
      string lSide1 = "";
      string str3 = "";
      double num3 = 0.0;
      string str4 = "";
      string lSide2 = "";
      string str5 = "";
      string format1 = "";
      string format2 = "";
      string str6 = "";
      string query = "";
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string format3 = "";
      string format4 = "";
      string str10 = "";
      string str11 = "";
      string str12 = "";
      string str13 = "";
      string str14 = "";
      string str15 = "";
      string str16 = "";
      string str17 = "";
      string str18 = "";
      string s4 = "";
      string str19 = "";
      string str20 = "";
      string str21 = "";
      string str22 = "";
      string str23 = "";
      string str24 = "";
      string str25 = "";
      int num4 = 0;
      try
      {
        if (this.err_mainmodule_inventario_acumulativo > 0)
        {
          str25 = (string) this.localVars[38];
          str24 = (string) this.localVars[37];
          str23 = (string) this.localVars[36];
          str22 = (string) this.localVars[35];
          str21 = (string) this.localVars[34];
          str20 = (string) this.localVars[33];
          str19 = (string) this.localVars[32];
          s4 = (string) this.localVars[31];
          str18 = (string) this.localVars[30];
          str17 = (string) this.localVars[29];
          str16 = (string) this.localVars[28];
          str15 = (string) this.localVars[27];
          str14 = (string) this.localVars[26];
          str13 = (string) this.localVars[25];
          str12 = (string) this.localVars[24];
          str11 = (string) this.localVars[23];
          str10 = (string) this.localVars[22];
          format4 = (string) this.localVars[21];
          format3 = (string) this.localVars[20];
          str9 = (string) this.localVars[19];
          str8 = (string) this.localVars[18];
          str7 = (string) this.localVars[17];
          s3 = (string) this.localVars[16];
          s2 = (string) this.localVars[15];
          s1 = (string) this.localVars[14];
          query = (string) this.localVars[13];
          str6 = (string) this.localVars[12];
          format2 = (string) this.localVars[11];
          format1 = (string) this.localVars[10];
          str5 = (string) this.localVars[9];
          lSide2 = (string) this.localVars[8];
          str4 = (string) this.localVars[7];
          num3 = (double) this.localVars[6];
          str3 = (string) this.localVars[5];
          lSide1 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_inventario_acumulativo == 1)
          {
            this.err_mainmodule_inventario_acumulativo = 0;
            this.__mainmodule_cierramsql();
            ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num4 = 1;
        int num5 = (int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        lSide2 = num5.ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide2, "7"))
          return "";
        str5 = this.__mainmodule_numano.Value.ToString((IFormatProvider) b4p.cul) + ((format1 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) this.__mainmodule_nummes.Value).ToString(format1, (IFormatProvider) b4p.cul) : ((int) (double) this.__mainmodule_nummes.Value).ToString(format1, (IFormatProvider) b4p.cul)) + ((format2 = "D2".ToLower(b4p.cul))[0] != 'd' ? ((double) this.__mainmodule_numdia.Value).ToString(format2, (IFormatProvider) b4p.cul) : ((int) (double) this.__mainmodule_numdia.Value).ToString(format2, (IFormatProvider) b4p.cul));
        str6 = str5 + " " + new DateTime((long) (double) DateTime.Now.Ticks).ToString(this.timeFormat, (IFormatProvider) b4p.cul);
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        query = "SELECT TOP 1 NUM_MOV, CVE_FOLIO FROM MINVE" + this.var__mainmodule_empresa + " ORDER BY NUM_MOV DESC";
        if (this.__mainmodule_msql1.ExecuteQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_msql1.Advance();
          s1 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("CVE_FOLIO"), "C");
          if (this.Other.IsNumber(s1).ToLower(b4p.cul) == "true")
          {
            s2 = s1;
            s2 = ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
            s1 = s2;
          }
          else
            s1 = "1";
          s3 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("NUM_MOV"), "N");
          s2 = !(this.Other.IsNumber(s3).ToLower(b4p.cul) == "true") ? "1" : ((s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          str7 = "M";
          str8 = "0";
          str9 = this.__mainmodule_trefminve.Text.Replace(" ", "");
          if (str9.Length.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            string[] strArray1 = new string[6]
            {
              "II",
              this.__mainmodule_numano.Value.ToString((IFormatProvider) b4p.cul),
              null,
              null,
              null,
              null
            };
            string[] strArray2 = strArray1;
            Decimal num6 = this.__mainmodule_nummes.Value;
            string str26 = num6.ToString((IFormatProvider) b4p.cul);
            strArray2[2] = str26;
            string[] strArray3 = strArray1;
            num6 = this.__mainmodule_numdia.Value;
            string str27 = num6.ToString((IFormatProvider) b4p.cul);
            strArray3[3] = str27;
            string[] strArray4 = strArray1;
            string str28;
            if ((format3 = "D2".ToLower(b4p.cul))[0] == 'd')
            {
              num5 = (int) (double) DateTime.Now.Minute;
              str28 = num5.ToString(format3, (IFormatProvider) b4p.cul);
            }
            else
              str28 = ((double) DateTime.Now.Minute).ToString(format3, (IFormatProvider) b4p.cul);
            strArray4[4] = str28;
            string[] strArray5 = strArray1;
            string str29;
            if ((format4 = "D2".ToLower(b4p.cul))[0] == 'd')
            {
              num5 = (int) (double) DateTime.Now.Second;
              str29 = num5.ToString(format4, (IFormatProvider) b4p.cul);
            }
            else
              str29 = ((double) DateTime.Now.Second).ToString(format4, (IFormatProvider) b4p.cul);
            strArray5[5] = str29;
            str9 = string.Concat(strArray1);
          }
          str10 = "";
          str11 = "";
          str12 = "0";
          str13 = "0";
          str14 = "P";
          str15 = "1";
          str16 = "S";
          str17 = "N";
          str18 = "0";
          this.var__mainmodule_sql = "Select P.articulo, SUM(cantidad), Max(costo_prom), MAX(uni_med) FROM minve M ";
          this.var__mainmodule_sql += "INNER JOIN prods P ON P.articulo = M.articulo ";
          this.var__mainmodule_sql += "WHERE nuevo = 'S' AND cancelado <> 'C' GROUP BY P.articulo HAVING SUM(cantidad) > 0";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          s4 = "0";
          bool flag;
          while (true)
          {
            flag = this.__mainmodule_reader.ReadNextRow();
            if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
            {
              Application.DoEvents();
              lSide1 = this.__mainmodule_reader.GetValue(0);
              num2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
              this.__mainmodule_ltmart.Text = lSide1;
              this.__mainmodule_ltmcant.Text = num2.ToString((IFormatProvider) b4p.cul);
              this.__mainmodule_ltmreg.Text = s4;
              str19 = this.__mainmodule_reader.GetValue(2);
              str20 = "0";
              str21 = str19;
              str22 = str19;
              str23 = this.__mainmodule_reader.GetValue(3);
              num3 = num1 - num2;
              double num7;
              if (this.LCompareEqual(lSide1, "VIO000029OL"))
              {
                num7 = -1.0;
                str24 = num7.ToString((IFormatProvider) b4p.cul);
              }
              str25 = this.__mainmodule_tconm.Text;
              str24 = "1";
              num7 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) + 1.0;
              s4 = num7.ToString((IFormatProvider) b4p.cul);
              if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString((IFormatProvider) b4p.cul), "1"))
              {
                query = "UPDATE MULT" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) + " + num2.ToString((IFormatProvider) b4p.cul);
                query = query + " WHERE CVE_ART = '" + lSide1 + "' AND CVE_ALM = " + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
                flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
                if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
                  break;
              }
              query = "UPDATE INVE" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) + " + num2.ToString((IFormatProvider) b4p.cul) + " WHERE CVE_ART = '" + lSide1 + "'";
              flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
              if (!(flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false"))
              {
                query = "INSERT INTO MINVE" + this.var__mainmodule_empresa + " (CVE_ART, ALMACEN, NUM_MOV, CVE_CPTO, VEND, ";
                query += "FECHA_DOCU, TIPO_DOC, REFER, CLAVE_CLPV, CANT, CANT_COST, PRECIO, COSTO, ";
                query += "REG_SERIE, UNI_VENTA, E_LTPD, EXISTENCIA, TIPO_PROD, FACTOR_CON, FECHAELAB, ";
                query += "CVE_FOLIO, SIGNO, COSTEADO, COSTO_PROM_INI, COSTO_PROM_FIN, DESDE_INVE, ";
                query = query + "MOV_ENLAZADO, AFEC_COI) Values('" + lSide1 + "','" + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
                query = query + "','" + s2 + "','" + str25 + "','" + str11 + "','";
                query = query + str5 + "','" + str7 + "','" + str9 + "X','" + str10;
                query = query + "','" + num2.ToString((IFormatProvider) b4p.cul) + "','" + str20 + "','" + str8 + "','";
                query = query + str19 + "','" + str12 + "','" + str23 + "','" + str13;
                query = query + "',(SELECT EXIST FROM INVE" + this.var__mainmodule_empresa + " WHERE CVE_ART = '" + lSide1 + "'),'";
                query = query + str14 + "','" + str15 + "','" + str6 + "','";
                query = query + s1 + "','" + str24 + "','" + str16 + "','" + str21 + "','";
                query = query + str22 + "','" + str17 + "','" + str18 + "','S')";
                flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
                if (!(flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false"))
                {
                  num7 = (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0;
                  s2 = num7.ToString((IFormatProvider) b4p.cul);
                  this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide1 + "'";
                  this.__mainmodule_cmd2.ExecuteNonQuery();
                  this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide1 + "'";
                  this.__mainmodule_cmd2.ExecuteNonQuery();
                }
                else
                  goto label_36;
              }
              else
                goto label_32;
            }
            else
              goto label_41;
          }
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO_ACUMULATIVO MULT.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num5 = (int) MessageBox.Show("Problema detectado 1985", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num5.ToString((IFormatProvider) b4p.cul);
          return "";
label_32:
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO_ACUMULATIVO UPDATE INVEN.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num5 = (int) MessageBox.Show("Problema detectado 2568", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num5.ToString((IFormatProvider) b4p.cul);
          return "";
label_36:
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO_ACUMULATIVO MINVE.txt"), false, Encoding.UTF8));
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
          if (this.htStreams.Contains((object) "_mainmodule_c1"))
          {
            ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
            this.htStreams.Remove((object) "_mainmodule_c1");
            GC.Collect();
          }
          this.__mainmodule_msql1.Close();
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num5 = (int) MessageBox.Show("Problema detectado 2593", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num5.ToString((IFormatProvider) b4p.cul);
          return "";
label_41:
          this.__mainmodule_reader.Close();
          query = "UPDATE TBLCONTROL" + this.var__mainmodule_empresa + " SET ULT_CVE = (SELECT ISNULL(MAX(NUM_MOV),0) FROM MINVE" + this.var__mainmodule_empresa;
          query += ") WHERE ID_TABLA = 44";
          flag = this.__mainmodule_msql1.ExecuteNonQuery(query);
          if (flag.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
          {
            this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\INVENTARIO_ACUMULATIVO TBLCONTROL2.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
            if (this.htStreams.Contains((object) "_mainmodule_c1"))
            {
              ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
              this.htStreams.Remove((object) "_mainmodule_c1");
              GC.Collect();
            }
            this.__mainmodule_msql1.Close();
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            num5 = (int) MessageBox.Show("Problema detectado 2613", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            num5.ToString((IFormatProvider) b4p.cul);
            return "";
          }
          this.__mainmodule_msql1.Close();
          num5 = (int) MessageBox.Show("ok articulo procesados " + s4, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num5.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_ltinven2.Text = "";
          this.__mainmodule_ltinven.Text = "";
          this.__mainmodule_procminve.close();
          return "";
        }
        this.__mainmodule_msql1.Close();
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        ((int) MessageBox.Show("Problema detectado 1894", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num4 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_inventario_acumulativo = num4;
          this.localVars = new object[39]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) str2,
            (object) lSide1,
            (object) str3,
            (object) num3,
            (object) str4,
            (object) lSide2,
            (object) str5,
            (object) format1,
            (object) format2,
            (object) str6,
            (object) query,
            (object) s1,
            (object) s2,
            (object) s3,
            (object) str7,
            (object) str8,
            (object) str9,
            (object) format3,
            (object) format4,
            (object) str10,
            (object) str11,
            (object) str12,
            (object) str13,
            (object) str14,
            (object) str15,
            (object) str16,
            (object) str17,
            (object) str18,
            (object) s4,
            (object) str19,
            (object) str20,
            (object) str21,
            (object) str22,
            (object) str23,
            (object) str24,
            (object) str25
          };
          return this.__mainmodule_inventario_acumulativo();
        }
        this.ShowError(ex, "_mainmodule_inventario_acumulativo");
        return "";
      }
    }

    private string __mainmodule_mnucompra_click()
    {
      try
      {
        this.__mainmodule_gencompra.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnucompra_click");
        return "";
      }
    }

    private string __mainmodule_btnsalirgencompra_click()
    {
      try
      {
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        this.__mainmodule_gencompra.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsalirgencompra_click");
        return "";
      }
    }

    private string __mainmodule_btngencompra_click()
    {
      double num1 = 0.0;
      string str1 = "";
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      double num5 = 0.0;
      double num6 = 0.0;
      double num7 = 0.0;
      double num8 = 0.0;
      double num9 = 0.0;
      double num10 = 0.0;
      double num11 = 0.0;
      double num12 = 0.0;
      double num13 = 0.0;
      double num14 = 0.0;
      double num15 = 0.0;
      double num16 = 0.0;
      double num17 = 0.0;
      double num18 = 0.0;
      double num19 = 0.0;
      double num20 = 0.0;
      double num21 = 0.0;
      double num22 = 0.0;
      string str2 = "";
      double num23 = 0.0;
      string str3 = "";
      double num24 = 0.0;
      string str4 = "";
      string str5 = "";
      double num25 = 0.0;
      double num26 = 0.0;
      double num27 = 0.0;
      string str6 = "";
      double num28 = 0.0;
      string query1 = "";
      string str7 = "";
      string str8 = "";
      double num29 = 0.0;
      string str9 = "";
      string str10 = "";
      string str11 = "";
      string lSide = "";
      string str12 = "";
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string s4 = "";
      string s5 = "";
      string s6 = "";
      string s7 = "";
      string str13 = "";
      string s8 = "";
      string s9 = "";
      string str14 = "";
      string str15 = "";
      string str16 = "";
      string s10 = "";
      string s11 = "";
      string str17 = "";
      string str18 = "";
      string s12 = "";
      string str19 = "";
      string str20 = "";
      string str21 = "";
      string str22 = "";
      string str23 = "";
      string str24 = "";
      string str25 = "";
      string str26 = "";
      string s13 = "";
      string query2 = "";
      int num30 = 0;
      try
      {
        if (this.err_mainmodule_btngencompra_click > 0)
        {
          query2 = (string) this.localVars[70];
          s13 = (string) this.localVars[69];
          str26 = (string) this.localVars[68];
          str25 = (string) this.localVars[67];
          str24 = (string) this.localVars[66];
          str23 = (string) this.localVars[65];
          str22 = (string) this.localVars[64];
          str21 = (string) this.localVars[63];
          str20 = (string) this.localVars[62];
          str19 = (string) this.localVars[61];
          s12 = (string) this.localVars[60];
          str18 = (string) this.localVars[59];
          str17 = (string) this.localVars[58];
          s11 = (string) this.localVars[57];
          s10 = (string) this.localVars[56];
          str16 = (string) this.localVars[55];
          str15 = (string) this.localVars[54];
          str14 = (string) this.localVars[53];
          s9 = (string) this.localVars[52];
          s8 = (string) this.localVars[51];
          str13 = (string) this.localVars[50];
          s7 = (string) this.localVars[49];
          s6 = (string) this.localVars[48];
          s5 = (string) this.localVars[47];
          s4 = (string) this.localVars[46];
          s3 = (string) this.localVars[45];
          s2 = (string) this.localVars[44];
          s1 = (string) this.localVars[43];
          str12 = (string) this.localVars[42];
          lSide = (string) this.localVars[41];
          str11 = (string) this.localVars[40];
          str10 = (string) this.localVars[39];
          str9 = (string) this.localVars[38];
          num29 = (double) this.localVars[37];
          str8 = (string) this.localVars[36];
          str7 = (string) this.localVars[35];
          query1 = (string) this.localVars[34];
          num28 = (double) this.localVars[33];
          str6 = (string) this.localVars[32];
          num27 = (double) this.localVars[31];
          num26 = (double) this.localVars[30];
          num25 = (double) this.localVars[29];
          str5 = (string) this.localVars[28];
          str4 = (string) this.localVars[27];
          num24 = (double) this.localVars[26];
          str3 = (string) this.localVars[25];
          num23 = (double) this.localVars[24];
          str2 = (string) this.localVars[23];
          num22 = (double) this.localVars[22];
          num21 = (double) this.localVars[21];
          num20 = (double) this.localVars[20];
          num19 = (double) this.localVars[19];
          num18 = (double) this.localVars[18];
          num17 = (double) this.localVars[17];
          num16 = (double) this.localVars[16];
          num15 = (double) this.localVars[15];
          num14 = (double) this.localVars[14];
          num13 = (double) this.localVars[13];
          num12 = (double) this.localVars[12];
          num11 = (double) this.localVars[11];
          num10 = (double) this.localVars[10];
          num9 = (double) this.localVars[9];
          num8 = (double) this.localVars[8];
          num7 = (double) this.localVars[7];
          num6 = (double) this.localVars[6];
          num5 = (double) this.localVars[5];
          num4 = (double) this.localVars[4];
          num3 = (double) this.localVars[3];
          num2 = (double) this.localVars[2];
          str1 = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_btngencompra_click == 1)
          {
            this.err_mainmodule_btngencompra_click = 0;
            ((int) MessageBox.Show("Error en errbtnGenCompra", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num30 = 1;
        int num31 = (int) MessageBox.Show("Realmente desea generar compra?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        lSide = num31.ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        double num32;
        if (this.__mainmodule_chenviartodascompras.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str12 = "0";
          s1 = ((double) this.__mainmodule_cbocompra.Items.Count - 1.0).ToString((IFormatProvider) b4p.cul);
        }
        else
        {
          num31 = this.__mainmodule_cbocompra.SelectedIndex;
          string str27 = num31.ToString((IFormatProvider) b4p.cul);
          num32 = -1.0;
          string str28 = num32.ToString((IFormatProvider) b4p.cul);
          if (str27 == str28)
          {
            num31 = (int) MessageBox.Show("Por favor selecione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            num31.ToString((IFormatProvider) b4p.cul);
            return "";
          }
          num31 = this.__mainmodule_cbocompra.SelectedIndex;
          str12 = num31.ToString((IFormatProvider) b4p.cul);
          num31 = this.__mainmodule_cbocompra.SelectedIndex;
          s1 = num31.ToString((IFormatProvider) b4p.cul);
        }
        s2 = "0";
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num31 = (int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num31.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        s3 = str12;
        double num33 = s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul);
        double num34 = s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul);
        while (num34 <= num33)
        {
          str10 = !this.LCompareEqual(this.var__mainmodule_seriecompra, "") ? this.__mainmodule_cbocompra.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString() : this.__mainmodule_replicate(" ", 20.0 - (double) this.__mainmodule_cbocompra.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString().Length) + this.__mainmodule_cbocompra.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString();
          this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.costo_prom), MAX(P.uni_med), MAX(P.impu1), MAX(P.impu4), max(clave), ";
          this.var__mainmodule_sql += "ifnull(MAX(cve_esqimpu),0), ifnull(MAX(folio),0), ifnull(MAX(imp1aplica),0), ifnull(MAX(imp2aplica),0), ";
          this.var__mainmodule_sql += "ifnull(Max(imp3aplica),0), ifnull(Max(imp4aplica),0) ";
          this.var__mainmodule_sql += "FROM compras I INNER JOIN prods P ON P.articulo = I.articulo ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.nuevo = 'S' AND cve_doc = '" + str10 + "' AND cancelado = 'N' GROUP BY I.articulo";
          s4 = "0";
          s5 = "0";
          num1 = 1.0;
          s6 = "0";
          s7 = "0";
          str13 = "0";
          s7 = "0";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            num32 = (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0;
            s2 = num32.ToString((IFormatProvider) b4p.cul);
            s8 = this.__mainmodule_reader.GetValue(2);
            num32 = Math.Round(s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul), 2);
            s8 = num32.ToString((IFormatProvider) b4p.cul);
            s9 = "0";
            str14 = this.__mainmodule_reader.GetValue(0);
            num2 = double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
            num4 = 0.0;
            num32 = (s6 == "" ? 0.0 : double.Parse(s6, (IFormatProvider) b4p.cul)) + (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num2;
            s6 = num32.ToString((IFormatProvider) b4p.cul);
            num32 = (s7 == "" ? 0.0 : double.Parse(s7, (IFormatProvider) b4p.cul)) + (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num2;
            s7 = num32.ToString((IFormatProvider) b4p.cul);
            str13 = "0";
            str1 = str14;
            num3 = num2;
            num5 = s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul);
            str2 = "N";
            num6 = double.Parse(this.__mainmodule_reader.GetValue(4), (IFormatProvider) b4p.cul);
            num7 = 0.0;
            num8 = 0.0;
            num9 = double.Parse(this.__mainmodule_reader.GetValue(5), (IFormatProvider) b4p.cul);
            str11 = this.__mainmodule_reader.GetValue(6);
            str15 = this.__mainmodule_reader.GetValue(7);
            str16 = this.__mainmodule_reader.GetValue(8);
            num10 = double.Parse(this.__mainmodule_reader.GetValue(9), (IFormatProvider) b4p.cul);
            num11 = double.Parse(this.__mainmodule_reader.GetValue(10), (IFormatProvider) b4p.cul);
            num12 = double.Parse(this.__mainmodule_reader.GetValue(11), (IFormatProvider) b4p.cul);
            num13 = double.Parse(this.__mainmodule_reader.GetValue(12), (IFormatProvider) b4p.cul);
            num32 = (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num6 / 100.0;
            s10 = num32.ToString((IFormatProvider) b4p.cul);
            if (this.LCompareEqual(num13.ToString((IFormatProvider) b4p.cul), "1"))
            {
              num32 = ((s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) + (s10 == "" ? 0.0 : double.Parse(s10, (IFormatProvider) b4p.cul))) * num9 / 100.0;
              s11 = num32.ToString((IFormatProvider) b4p.cul);
            }
            else
            {
              num32 = (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num9 / 100.0;
              s11 = num32.ToString((IFormatProvider) b4p.cul);
            }
            num32 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) + (s10 == "" ? 0.0 : double.Parse(s10, (IFormatProvider) b4p.cul));
            s4 = num32.ToString((IFormatProvider) b4p.cul);
            num32 = (s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul)) + (s11 == "" ? 0.0 : double.Parse(s11, (IFormatProvider) b4p.cul));
            s5 = num32.ToString((IFormatProvider) b4p.cul);
            num14 = Math.Round(s10 == "" ? 0.0 : double.Parse(s10, (IFormatProvider) b4p.cul), 3);
            num15 = 0.0;
            num16 = 0.0;
            num17 = Math.Round(s11 == "" ? 0.0 : double.Parse(s11, (IFormatProvider) b4p.cul), 3);
            num18 = 0.0;
            num19 = 0.0;
            num20 = 0.0;
            num21 = 0.0;
            num22 = 0.0;
            num23 = 1.0;
            str4 = this.__mainmodule_reader.GetValue(3);
            num27 = 0.0;
            str17 = "0";
            num28 = (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num2 - (s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul)) * num2 * (s9 == "" ? 0.0 : double.Parse(s9, (IFormatProvider) b4p.cul)) / 100.0;
            num28 = Math.Round(num28, 3);
            query1 = "EXECUTE PDA_ORDEN_DE_COMPRA_PAR '" + str10 + "'," + num1.ToString((IFormatProvider) b4p.cul) + ",'" + str1 + "'," + num2.ToString((IFormatProvider) b4p.cul) + ",";
            query1 = query1 + num5.ToString((IFormatProvider) b4p.cul) + "," + num6.ToString((IFormatProvider) b4p.cul) + "," + num9.ToString((IFormatProvider) b4p.cul) + "," + num10.ToString((IFormatProvider) b4p.cul) + "," + num11.ToString((IFormatProvider) b4p.cul) + ",";
            query1 = query1 + num12.ToString((IFormatProvider) b4p.cul) + "," + num13.ToString((IFormatProvider) b4p.cul) + "," + num14.ToString((IFormatProvider) b4p.cul) + "," + num17.ToString((IFormatProvider) b4p.cul) + "," + str17 + ",'";
            query1 = query1 + str4 + "'," + num23.ToString((IFormatProvider) b4p.cul) + "," + num28.ToString((IFormatProvider) b4p.cul) + "," + str15;
            if (this.__mainmodule_msql1.ExecuteQuery(query1).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\PROC ALMACENADO COMPRAS PAR.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str7);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
              if (this.htStreams.Contains((object) "_mainmodule_c1"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c1");
                GC.Collect();
              }
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              num31 = (int) MessageBox.Show("Problema en el ALMACENADO COMPRAS PAR", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
              num31.ToString((IFormatProvider) b4p.cul);
              break;
            }
            ++num1;
            this.__mainmodule_ltcomart.Text = str14;
            this.__mainmodule_ltcomcant.Text = num2.ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_ltcomreg.Text = s2;
          }
          this.__mainmodule_reader.Close();
          str18 = "o";
          str13 = "0";
          s12 = s7;
          str19 = "O";
          num32 = Math.Round(s12 == "" ? 0.0 : double.Parse(s12, (IFormatProvider) b4p.cul), 3);
          str20 = num32.ToString((IFormatProvider) b4p.cul);
          num32 = Math.Round(s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul), 3);
          str21 = num32.ToString((IFormatProvider) b4p.cul);
          num32 = Math.Round(s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul), 3);
          str22 = num32.ToString((IFormatProvider) b4p.cul);
          str23 = "0";
          num32 = Math.Round((s12 == "" ? 0.0 : double.Parse(s12, (IFormatProvider) b4p.cul)) + (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) + (s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul)), 3);
          str24 = num32.ToString((IFormatProvider) b4p.cul);
          str25 = str13;
          str26 = "";
          num32 = (s13 == "" ? 0.0 : double.Parse(s13, (IFormatProvider) b4p.cul)) + 1.0;
          s13 = num32.ToString((IFormatProvider) b4p.cul);
          query2 = "EXECUTE PDA_ORDEN_DE_COMPRA '" + str18 + "','" + str10 + "','" + str11 + "','" + str19 + "','";
          query2 = query2 + str26 + "'," + str20 + "," + str21 + "," + str22 + "," + str25 + ",";
          query2 = query2 + str23 + "," + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul) + ",'" + this.var__mainmodule_seriecompra + "'," + str16 + "," + str24;
          if (this.__mainmodule_msql1.ExecuteNonQuery(query2).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
          {
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\COMPRAS CABEZA.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query2);
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
            if (this.htStreams.Contains((object) "_mainmodule_c1"))
            {
              ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
              this.htStreams.Remove((object) "_mainmodule_c1");
              GC.Collect();
            }
            num31 = (int) MessageBox.Show("Problema en el ALMACENADO ORDER DE COMPRA\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            num31.ToString((IFormatProvider) b4p.cul);
          }
          num32 = ++num34;
          s3 = num32.ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_msql1.Close();
        if ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) > 0.0)
        {
          ++this.var__mainmodule_foliocompra;
          this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = "UPDATE config SET foliocompra = " + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.__mainmodule_cmd.CommandText = !(this.__mainmodule_chenviartodascompras.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true") ? "UPDATE compras SET nuevo = 'N' WHERE cve_doc = '" + str10 + "'" : "UPDATE compras SET nuevo = 'N'";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        num31 = (int) MessageBox.Show("ok partidas enviadas " + s2, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        num31.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num30 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btngencompra_click = num30;
          this.localVars = new object[71]
          {
            (object) num1,
            (object) str1,
            (object) num2,
            (object) num3,
            (object) num4,
            (object) num5,
            (object) num6,
            (object) num7,
            (object) num8,
            (object) num9,
            (object) num10,
            (object) num11,
            (object) num12,
            (object) num13,
            (object) num14,
            (object) num15,
            (object) num16,
            (object) num17,
            (object) num18,
            (object) num19,
            (object) num20,
            (object) num21,
            (object) num22,
            (object) str2,
            (object) num23,
            (object) str3,
            (object) num24,
            (object) str4,
            (object) str5,
            (object) num25,
            (object) num26,
            (object) num27,
            (object) str6,
            (object) num28,
            (object) query1,
            (object) str7,
            (object) str8,
            (object) num29,
            (object) str9,
            (object) str10,
            (object) str11,
            (object) lSide,
            (object) str12,
            (object) s1,
            (object) s2,
            (object) s3,
            (object) s4,
            (object) s5,
            (object) s6,
            (object) s7,
            (object) str13,
            (object) s8,
            (object) s9,
            (object) str14,
            (object) str15,
            (object) str16,
            (object) s10,
            (object) s11,
            (object) str17,
            (object) str18,
            (object) s12,
            (object) str19,
            (object) str20,
            (object) str21,
            (object) str22,
            (object) str23,
            (object) str24,
            (object) str25,
            (object) str26,
            (object) s13,
            (object) query2
          };
          return this.__mainmodule_btngencompra_click();
        }
        this.ShowError(ex, "_mainmodule_btngencompra_click");
        return "";
      }
    }

    private string __mainmodule_gencompra_show()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_gencompra_show > 0 && this.err_mainmodule_gencompra_show == 1)
        {
          this.err_mainmodule_gencompra_show = 0;
          ((int) MessageBox.Show("Error en errGENCOMPRA", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        this.var__mainmodule_sql = "SELECT cve_doc FROM compras WHERE nuevo = 'S' AND cancelado = 'N' GROUP BY cve_doc";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_cbocompra.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_cbocompra.Items.Add((object) this.__mainmodule_reader.GetValue(0));
        this.__mainmodule_reader.Close();
        this.__mainmodule_ltconcepto.Text = "Concepto: 01 Compras";
        this.__mainmodule_btngencompra.BringToFront();
        this.__mainmodule_btnsalirgencompra.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_gencompra_show = num;
          this.localVars = new object[0];
          return this.__mainmodule_gencompra_show();
        }
        this.ShowError(ex, "_mainmodule_gencompra_show");
        return "";
      }
    }

    private string __mainmodule_replicate(
      string var__mainmodule_charadd,
      double var__mainmodule_totcharadd)
    {
      string str1 = "";
      string str2 = "";
      try
      {
        string s = "1";
        double num1 = var__mainmodule_totcharadd;
        for (double num2 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num2 <= num1; str2 = (++num2).ToString((IFormatProvider) b4p.cul))
          str1 += var__mainmodule_charadd;
        return str1;
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_replicate");
        return "";
      }
    }

    private string __mainmodule_mnureenviar_click()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnureenviar_click > 0 && this.err_mainmodule_mnureenviar_click == 1)
        {
          this.err_mainmodule_mnureenviar_click = 0;
          ((int) MessageBox.Show("Ocurrio un error", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        this.var__mainmodule_sql = "UPDATE inven SET status = 0";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "UPDATE minve SET nuevo = 'S'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "UPDATE prods SET status = 0";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El inventario esta listo para ser reenviado nuevamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnureenviar_click = num;
          this.localVars = new object[0];
          return this.__mainmodule_mnureenviar_click();
        }
        this.ShowError(ex, "_mainmodule_mnureenviar_click");
        return "";
      }
    }

    private string __mainmodule_tprod_keypress(string var__mainmodule_key)
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_tprod_keypress > 0 && this.err_mainmodule_tprod_keypress == 1)
        {
          this.err_mainmodule_tprod_keypress = 0;
          ((int) MessageBox.Show("Error en tProd keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        if (this.LCompareEqual(var__mainmodule_key, '\r'.ToString((IFormatProvider) b4p.cul)))
          this.__mainmodule_buscaexistencia();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tprod_keypress = num;
          this.localVars = new object[0];
          return this.__mainmodule_tprod_keypress(var__mainmodule_key);
        }
        this.ShowError(ex, "_mainmodule_tprod_keypress");
        return "";
      }
    }

    private string __mainmodule_buscaexistencia()
    {
      string s1 = "";
      string s2 = "";
      string s3 = "";
      string s4 = "";
      string s5 = "";
      string format = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_buscaexistencia > 0)
        {
          format = (string) this.localVars[5];
          s5 = (string) this.localVars[4];
          s4 = (string) this.localVars[3];
          s3 = (string) this.localVars[2];
          s2 = (string) this.localVars[1];
          s1 = (string) this.localVars[0];
          if (this.err_mainmodule_buscaexistencia == 1)
          {
            this.err_mainmodule_buscaexistencia = 0;
            ((int) MessageBox.Show("Error en BuscaExistencia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        this.var__mainmodule_sql = "SELECT EXIST, IMPUESTO1, IMPUESTO4, IMP1APLICA, IMP4APLICA, ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "(Select PRECIO FROM PRECIO_X_PROD" + this.var__mainmodule_empresa + " WHERE ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "CVE_ART = I.CVE_ART AND CVE_PRECIO = 1) As PREC1, DESCR FROM INVE" + this.var__mainmodule_empresa + " I ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " P ON P.CVE_ESQIMPU = I.CVE_ESQIMPU ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN CVES_ALTER" + this.var__mainmodule_empresa + " A ON A.CVE_ART = I.CVE_ART AND TIPO = 'N' ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.CVE_ART = '" + this.__mainmodule_tprod.Text + "' OR CVE_ALTER = '" + this.__mainmodule_tprod.Text + "'";
        if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          while (this.__mainmodule_msql1.Advance().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
          {
            Application.DoEvents();
            s1 = this.__mainmodule_msql1.ReadField("PREC1");
            s2 = this.__mainmodule_msql1.ReadField("IMPUESTO1");
            s3 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) * (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) / 100.0).ToString((IFormatProvider) b4p.cul);
            s4 = this.__mainmodule_msql1.ReadField("IMPUESTO4");
            s5 = !(this.__mainmodule_msql1.ReadField("IMP1APLICA") == "1") ? ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) * (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) / 100.0).ToString((IFormatProvider) b4p.cul) : (((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + (s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul))) * (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) / 100.0).ToString((IFormatProvider) b4p.cul);
            s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + (s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul)) + (s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul))).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_ltdescr.Text = this.__mainmodule_msql1.ReadField("DESCR");
            this.__mainmodule_lte.Text = "Exist.: " + this.__mainmodule_msql1.ReadField("EXIST");
            this.__mainmodule_ltprec.Text = "$ " + ((format = "N2".ToLower(b4p.cul))[0] != 'd' ? (s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(format, (IFormatProvider) b4p.cul) : (s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(format, (IFormatProvider) b4p.cul));
          }
        }
        else
        {
          this.__mainmodule_lte.Text = "0";
          ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_msql1.Close();
        this.__mainmodule_tprod.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_buscaexistencia = num;
          this.localVars = new object[6]
          {
            (object) s1,
            (object) s2,
            (object) s3,
            (object) s4,
            (object) s5,
            (object) format
          };
          return this.__mainmodule_buscaexistencia();
        }
        this.ShowError(ex, "_mainmodule_buscaexistencia");
        return "";
      }
    }

    private string __mainmodule_mnuexist_click()
    {
      try
      {
        this.__mainmodule_frmexistencias.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuexist_click");
        return "";
      }
    }

    private string __mainmodule_btnsalexist_click()
    {
      try
      {
        this.__mainmodule_frmexistencias.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsalexist_click");
        return "";
      }
    }

    private string __mainmodule_frmexistencias_show()
    {
      try
      {
        this.__mainmodule_label26.BringToFront();
        this.__mainmodule_tprod.BringToFront();
        this.__mainmodule_tprod.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmexistencias_show");
        return "";
      }
    }

    private string __mainmodule_btnseries_click()
    {
      try
      {
        if (this.Other.IsNumber(this.__mainmodule_tfoliocompra.Text) == "false")
        {
          ((int) MessageBox.Show("El folio debe contener un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.Other.IsNumber(this.__mainmodule_tfolped.Text) == "false")
        {
          ((int) MessageBox.Show("El folio del pedidos debe ser un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.Other.IsNumber(this.__mainmodule_tfoliocompra.Text) == "false")
        {
          ((int) MessageBox.Show("El folio de la compra debe ser un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_cboempresapred.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
          this.__mainmodule_cboempresapred.SelectedIndex = 0;
        this.var__mainmodule_empresapred = this.__mainmodule_cboempresapred.Items[(int) (double) this.__mainmodule_cboempresapred.SelectedIndex].ToString();
        this.var__mainmodule_sql = "UPDATE config SET seriecompra = '" + this.__mainmodule_tseriecompra.Text + "', foliocompra = " + this.__mainmodule_tfoliocompra.Text + ", seriepedido = '" + this.__mainmodule_tserped.Text + "', folioped = " + this.__mainmodule_tfolped.Text + ", empresapred = '" + this.var__mainmodule_empresapred + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_seriecompra = this.__mainmodule_tseriecompra.Text;
        this.var__mainmodule_foliocompra = double.Parse(this.__mainmodule_tfoliocompra.Text, (IFormatProvider) b4p.cul);
        this.var__mainmodule_seriepedido = this.__mainmodule_tserped.Text;
        this.var__mainmodule_folioped = double.Parse(this.__mainmodule_tfolped.Text, (IFormatProvider) b4p.cul);
        ((int) MessageBox.Show("Los datos se grabaron satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnseries_click");
        return "";
      }
    }

    private string __mainmodule_btnsalirseries_click()
    {
      try
      {
        this.__mainmodule_frmseries.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsalirseries_click");
        return "";
      }
    }

    private string __mainmodule_frmseries_show()
    {
      try
      {
        this.__mainmodule_tseriecompra.Text = this.var__mainmodule_seriecompra;
        this.__mainmodule_tfoliocompra.Text = this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tserped.Text = this.var__mainmodule_seriepedido;
        this.__mainmodule_tfolped.Text = this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cboempresapred.Items.Clear();
        this.__mainmodule_cboempresapred.Items.Add((object) "Ninguna");
        string s1 = "1";
        double num1 = 99.0;
        for (double num2 = s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul); num2 <= num1; s1 = (++num2).ToString((IFormatProvider) b4p.cul))
        {
          string lower;
          this.__mainmodule_cboempresapred.Items.Add((lower = "D2".ToLower(b4p.cul))[0] != 'd' ? (object) (s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(lower, (IFormatProvider) b4p.cul) : (object) (s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul)).ToString(lower, (IFormatProvider) b4p.cul));
        }
        if ((double) this.var__mainmodule_empresapred.Length > 0.0)
        {
          string s2 = "0";
          double num3 = 98.0;
          for (double num4 = s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul); num4 <= num3; s2 = (++num4).ToString((IFormatProvider) b4p.cul))
          {
            if (this.RCompareEqual(this.__mainmodule_cboempresapred.Items[s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul)].ToString(), this.var__mainmodule_empresapred))
            {
              this.__mainmodule_cboempresapred.SelectedIndex = s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul);
              break;
            }
          }
        }
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmseries_show");
        return "";
      }
    }

    private string __mainmodule_btnmenusalir_click()
    {
      try
      {
        this.__mainmodule_frmmenu.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnmenusalir_click");
        return "";
      }
    }

    private string __mainmodule_btnmenuinvent_click()
    {
      try
      {
        this.var__mainmodule_tipoproc = "invent";
        this.__mainmodule_invent.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnmenuinvent_click");
        return "";
      }
    }

    private string __mainmodule_btnmenucompras_click()
    {
      try
      {
        this.__mainmodule_pnlpedidos.BringToFront();
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tpedcte.Text = "";
        this.__mainmodule_ltnombrecte.Text = "";
        this.var__mainmodule_tipoproc = "compras";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnmenucompras_click");
        return "";
      }
    }

    private string __mainmodule_mnuutilscompras_click()
    {
      try
      {
        this.__mainmodule_frmcomprasutils.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuutilscompras_click");
        return "";
      }
    }

    private string __mainmodule_frmcomprasutils_show()
    {
      try
      {
        this.__mainmodule_tblcompras.dataTable.Clear();
        this.__mainmodule_tblcompras.dataTable.AcceptChanges();
        this.var__mainmodule_sql = "SELECT cve_doc, max(cancelado) FROM compras WHERE nuevo = 'S' GROUP BY cve_doc";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_cboprovutils.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          string str = !(this.__mainmodule_reader.GetValue(1) == "C") ? "" : "   Cancelado";
          this.__mainmodule_cboprovutils.Items.Add((object) (this.__mainmodule_reader.GetValue(0) + str));
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_label37.BringToFront();
        this.__mainmodule_cboprovutils.BringToFront();
        this.var__mainmodule_rowcompra = -1.0;
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmcomprasutils_show");
        return "";
      }
    }

    private string __mainmodule_cboprovutils_selectionchanged(
      string var__mainmodule_index,
      string var__mainmodule_value)
    {
      try
      {
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        string str = this.__mainmodule_cboprovutils.Items[(int) (double) this.__mainmodule_cboprovutils.SelectedIndex].ToString();
        this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.descrip) ";
        this.var__mainmodule_sql += "FROM compras I INNER JOIN prods P ON P.articulo = I.articulo ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE cve_doc = '" + str + "' AND nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_tblcompras.dataTable.Clear();
        this.__mainmodule_tblcompras.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tblcompras.AddRow(new object[0]);
          string s = ((double) this.__mainmodule_tblcompras.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(2));
          this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cboprovutils_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_mnureenviarcompra_click()
    {
      try
      {
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        string str = this.__mainmodule_cboprovutils.Items[(int) (double) this.__mainmodule_cboprovutils.SelectedIndex].ToString();
        if ((double) str.IndexOf("Cancelado", 1) > 0.0)
        {
          ((int) MessageBox.Show("El documento actualmente se encuentra cancelado no es posible reenviarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.LCompareEqual(((int) MessageBox.Show("Realmente desea re-marcar para reenviar el documento " + str + "?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_cmd.CommandText = "UPDATE compras SET nuevo = 'S' WHERE cve_doc = '" + str + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El documento puede ser enviado nuavamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnureenviarcompra_click");
        return "";
      }
    }

    private string __mainmodule_mnucancelcompra_click()
    {
      try
      {
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        string str = this.__mainmodule_cboprovutils.Items[(int) (double) this.__mainmodule_cboprovutils.SelectedIndex].ToString();
        if (this.LCompareEqual(((int) MessageBox.Show("Realmente desea cancelar la compra " + str + "?", "Cancelar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        if ((double) str.IndexOf("Cancelado", 1) > 0.0)
        {
          ((int) MessageBox.Show("El documento ya se encuentra cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_cmd.CommandText = "UPDATE compras SET cancelado = 'C' WHERE cve_doc = '" + str + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El documento se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnucancelcompra_click");
        return "";
      }
    }

    private string __mainmodule_cmdinvc_click()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdinvc_click");
        return "";
      }
    }

    private string __mainmodule_mnunuevacompra_click()
    {
      try
      {
        if (this.LCompareEqual(((int) MessageBox.Show("Realmente desea iniciar nueva compra?", "Folio siguiente " + this.var__mainmodule_seriecompra + (this.var__mainmodule_foliocompra + 1.0).ToString((IFormatProvider) b4p.cul), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        ++this.var__mainmodule_foliocompra;
        this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = "UPDATE config SET foliocompra = " + this.var__mainmodule_foliocompra.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_invent.close();
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tpedcte.Text = "";
        this.__mainmodule_ltnombrecte.Text = "";
        this.__mainmodule_tpedcte.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnunuevacompra_click");
        return "";
      }
    }

    private string __mainmodule_chmult_click()
    {
      try
      {
        if (this.__mainmodule_chmult.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_cboalm.Enabled = bool.Parse("true".ToLower(b4p.cul));
        }
        else
        {
          this.__mainmodule_cboalm.SelectedIndex = 0;
          this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(b4p.cul));
        }
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_chmult_click");
        return "";
      }
    }

    private string __mainmodule_prods_show()
    {
      try
      {
        this.__mainmodule_btnmenuinvent.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_prods_show");
        return "";
      }
    }

    private string __mainmodule_btnprods_click()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string lSide = "";
      string s1 = "";
      string s2 = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_btnprods_click > 0)
        {
          s2 = (string) this.localVars[8];
          s1 = (string) this.localVars[7];
          lSide = (string) this.localVars[6];
          str4 = (string) this.localVars[5];
          str3 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_btnprods_click == 1)
          {
            this.err_mainmodule_btnprods_click = 0;
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        lSide = ((int) MessageBox.Show("Este proceso puede tardar varios minutos, realmente desea continuar?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        this.var__mainmodule_sql = "SELECT I.articulo, I.descrip, I.existencia, (SELECT exist FROM inven P WHERE ";
        this.var__mainmodule_sql += "P.articulo = i.articulo) FROM prods I ORDER BY descrip";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        s1 = "0";
        this.__mainmodule_tblprod.dataTable.Clear();
        this.__mainmodule_tblprod.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          str3 = this.__mainmodule_reader.GetValue(0);
          num1 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(2), (IFormatProvider) b4p.cul);
          num2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(3)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(3), (IFormatProvider) b4p.cul);
          if (num2 > 0.0)
          {
            s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_tblprod.AddRow(new object[0]);
            s2 = ((double) this.__mainmodule_tblprod.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[0].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), str3);
            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[1].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[2].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), num1.ToString((IFormatProvider) b4p.cul));
            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[3].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), num2.ToString((IFormatProvider) b4p.cul));
          }
        }
        this.__mainmodule_reader.Close();
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        ((int) MessageBox.Show("ok Articulos " + s1, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnprods_click = num3;
          this.localVars = new object[9]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) str2,
            (object) str3,
            (object) str4,
            (object) lSide,
            (object) s1,
            (object) s2
          };
          return this.__mainmodule_btnprods_click();
        }
        this.ShowError(ex, "_mainmodule_btnprods_click");
        return "";
      }
    }

    private string __mainmodule_mnuinvent_click()
    {
      try
      {
        this.__mainmodule_prods.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuinvent_click");
        return "";
      }
    }

    private string __mainmodule_btnlogin2_click()
    {
      try
      {
        this.__mainmodule_frmacceso.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnlogin2_click");
        return "";
      }
    }

    private string __mainmodule_btnlogin1_click()
    {
      try
      {
        if (this.__mainmodule_tlogin.Text != "Gsorom09" && this.__mainmodule_tlogin.Text != "111222" && this.__mainmodule_tlogin.Text != "admin" && this.__mainmodule_tlogin.Text != "1212121212")
        {
          ((int) MessageBox.Show("Contraseña incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_frmacceso.close();
        this.__mainmodule_procminve.show();
        this.__mainmodule_tlogin.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnlogin1_click");
        return "";
      }
    }

    private string __mainmodule_mnuminve1_click()
    {
      try
      {
        this.__mainmodule_cmd.CommandText = "UPDATE inven SET status = 0";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "UPDATE minve SET nuevo = 'S'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "UPDATE prods SET status = 0";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("Los registros se remarcaron para su reenvio satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuminve1_click");
        return "";
      }
    }

    private string __mainmodule_tbcaninven_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tbcaninven_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_mnucancelarpartidacompra_click()
    {
      try
      {
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.var__mainmodule_rowcompra < 0.0)
        {
          ((int) MessageBox.Show("Por favor seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_cboprovutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        string str = this.__mainmodule_cboprovutils.Items[(int) (double) this.__mainmodule_cboprovutils.SelectedIndex].ToString();
        string cell = (string) this.__mainmodule_tblcompras.GetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[0].MappingName, (int) this.var__mainmodule_rowcompra, true);
        if (this.LCompareEqual(((int) MessageBox.Show("Realmente desea eliminar partida " + cell + "?", "Cancelar partida compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM compras WHERE cve_doc = '" + str + "' AND articulo = '" + cell + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("La partida se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.var__mainmodule_rowcompra = -1.0;
        this.__mainmodule_tblcompras.dataTable.Clear();
        this.__mainmodule_tblcompras.dataTable.AcceptChanges();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnucancelarpartidacompra_click");
        return "";
      }
    }

    private string __mainmodule_tblcompras_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        this.var__mainmodule_rowcompra = var__mainmodule_row == "" ? 0.0 : double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tblcompras_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_frmcomprasutils_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmcomprasutils_close");
        return "";
      }
    }

    private string __mainmodule_cmdimport1_click()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdimport1_click");
        return "";
      }
    }

    private string __mainmodule_btntraspasos_click()
    {
      string str1 = "";
      string str2 = "";
      try
      {
        this.var__mainmodule_sql = "SELECT tiendaorigen, tiendadestino from movsinv WHERE nuevo = 'S'  AND cancelado = 'N' AND status <> 'C' group by tiendaorigen, tiendadestino";
        this.var__mainmodule_empresa_origen = "";
        this.var__mainmodule_empresa_destino = "";
        int num = 0;
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str1 = this.__mainmodule_reader.GetValue(0);
          str2 = this.__mainmodule_reader.GetValue(1);
          num = 1;
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(num.ToString((IFormatProvider) b4p.cul), "0"))
        {
          this.var__mainmodule_empresa_origen = "";
          this.var__mainmodule_empresa_destino = "";
          this.__utilerias_importa.show();
        }
        else
        {
          this.var__mainmodule_empresa_origen = str1;
          this.var__mainmodule_empresa_destino = str2;
          this.__utilerias_inven.show();
        }
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btntraspasos_click");
        return "";
      }
    }

    private string __mainmodule_btntea_click()
    {
      try
      {
        this.__utilerias_frmtea.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btntea_click");
        return "";
      }
    }

    private string __mainmodule_cmdinv_keypress(string var__mainmodule_key)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_cmdinv_keypress");
        return "";
      }
    }

    private string __mainmodule_btnred_click()
    {
      try
      {
        this.__mainmodule_pnlred.Visible = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tuni.Enabled = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnred_click");
        return "";
      }
    }

    private string __mainmodule_mnuacumulativo_click()
    {
      try
      {
        this.__mainmodule_opminve3.Checked = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_opminve1.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_opminve2.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_lttipo.Text = "ACUMULATIVO";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuacumulativo_click");
        return "";
      }
    }

    private string __mainmodule_mnuactualizar_click()
    {
      try
      {
        this.__mainmodule_opminve3.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_opminve1.Checked = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_opminve2.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_lttipo.Text = "ACTUALIZAR";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuactualizar_click");
        return "";
      }
    }

    private string __mainmodule_mnuajustar_click()
    {
      try
      {
        this.__mainmodule_opminve3.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_opminve1.Checked = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_opminve2.Checked = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_lttipo.Text = "AJUSTAR";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuajustar_click");
        return "";
      }
    }

    private string __mainmodule_opminve3_click()
    {
      try
      {
        this.__mainmodule_lttipo.Text = "ACUMULATIVO";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_opminve3_click");
        return "";
      }
    }

    private string __mainmodule_opminve1_click()
    {
      try
      {
        this.__mainmodule_lttipo.Text = "ACTUALIZAR";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_opminve1_click");
        return "";
      }
    }

    private string __mainmodule_opminve2_click()
    {
      try
      {
        this.__mainmodule_lttipo.Text = "AJUSTAR";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_opminve2_click");
        return "";
      }
    }

    private string __mainmodule_mnuconsec_click()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuconsec_click");
        return "";
      }
    }

    private string __mainmodule_mnuenviarsql_click()
    {
      string lSide = "";
      string s = "";
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnuenviarsql_click > 0)
        {
          str4 = (string) this.localVars[5];
          str3 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          str1 = (string) this.localVars[2];
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_mnuenviarsql_click == 1)
          {
            this.err_mainmodule_mnuenviarsql_click = 0;
            this.__mainmodule_cierrareader();
            this.__mainmodule_cierramsql();
            ((int) MessageBox.Show("Error al enviar en mnuEnviarSQL_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        lSide = ((int) MessageBox.Show("Realmente desea enviar el inventario a SQL?", "Enviar Inventario a base INVENTMOBILE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_trefminve.Text = this.__mainmodule_trefminve.Text.Replace(" ", "");
        if (this.__mainmodule_trefminve.Text.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("Por favor capture la referencia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        this.__mainmodule_cmd.CommandText = "SELECT articulo, exist FROM inven";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        s = "0";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          str1 = this.__mainmodule_reader.GetValue(0);
          str2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? "0" : this.__mainmodule_reader.GetValue(1);
          this.__mainmodule_ltmart.Text = str1;
          this.__mainmodule_ltmcant.Text = str2;
          this.var__mainmodule_sql = "PROC_RECIBIR_INVENTMOBILE '" + this.__mainmodule_trefminve.Text + "','" + str1 + "'," + str2 + "," + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul);
          if (this.__mainmodule_msql1.ExecuteNonQuery(this.var__mainmodule_sql).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
          {
            this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\" + this.var__mainmodule_servertea + " INVENTMOBILE.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
            if (this.htStreams.Contains((object) "_mainmodule_c1"))
            {
              ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
              this.htStreams.Remove((object) "_mainmodule_c1");
              GC.Collect();
            }
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            ((int) MessageBox.Show("Problema en tabla INVENTMOBILE en " + this.var__mainmodule_servertea + " en linea 3901", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            break;
          }
          s = ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        str3 = "0";
        str4 = "0";
        this.var__mainmodule_sql = "Select count(*), sum(exist) FROM inven";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str3 = this.__mainmodule_reader.GetValue(0);
          str4 = this.__mainmodule_reader.GetValue(1);
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_msql1.Close();
        ((int) MessageBox.Show("Total artículos: " + s + ",   Total piezas escaneadas: " + str4 + ",  Total artículos escaneados: " + str3, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_copiaarchivos2();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnuenviarsql_click = num;
          this.localVars = new object[6]
          {
            (object) lSide,
            (object) s,
            (object) str1,
            (object) str2,
            (object) str3,
            (object) str4
          };
          return this.__mainmodule_mnuenviarsql_click();
        }
        this.ShowError(ex, "_mainmodule_mnuenviarsql_click");
        return "";
      }
    }

    private string __mainmodule_btngenerar_keypress(string var__mainmodule_key)
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btngenerar_keypress");
        return "";
      }
    }

    private string __mainmodule_mnutotal_click()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnutotal_click > 0 && this.err_mainmodule_mnutotal_click == 1)
        {
          this.err_mainmodule_mnutotal_click = 0;
          this.__mainmodule_cierrareader();
          return "";
        }
        num = 1;
        this.__mainmodule_cmd.CommandText = "SELECT SUM(exist), COUNT(*) FROM inven";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          ((int) MessageBox.Show("Partidas: " + this.__mainmodule_reader.GetValue(1) + ", Piezas: " + this.__mainmodule_reader.GetValue(0), "Total partidas", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnutotal_click = num;
          this.localVars = new object[0];
          return this.__mainmodule_mnutotal_click();
        }
        this.ShowError(ex, "_mainmodule_mnutotal_click");
        return "";
      }
    }

    private string __mainmodule_mnutotalminve_click()
    {
      try
      {
        this.__mainmodule_mnutotal_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnutotalminve_click");
        return "";
      }
    }

    private string __mainmodule_gencompra_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_gencompra_close");
        return "";
      }
    }

    private string __mainmodule_frmmenu_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmmenu_close");
        return "";
      }
    }

    private string __mainmodule_procminve_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_procminve_close");
        return "";
      }
    }

    private string __mainmodule_btncompactar_click()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btncompactar_click > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_btncompactar_click == 1)
          {
            this.err_mainmodule_btncompactar_click = 0;
            ((int) MessageBox.Show("error en borrar datos ErrbtnCompactar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        lSide = ((int) MessageBox.Show("Desea compactar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "VACUUM";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("La base de datos se compacto satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btncompactar_click = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_btncompactar_click();
        }
        this.ShowError(ex, "_mainmodule_btncompactar_click");
        return "";
      }
    }

    private string __mainmodule_frmexistxlinea_show()
    {
      try
      {
        if (this.LCompareEqual(this.var__mainmodule_tipomov, "lineas"))
        {
          this.__mainmodule_frmexistxlinea.Text = "Exist. X Linea";
          this.var__mainmodule_sql = "SELECT linea, sum(M.exist) FROM inven M ";
          this.var__mainmodule_sql += "LEFT JOIN prods P ON P.articulo = M.articulo WHERE estatus <> 'C' GROUP BY linea";
        }
        else
        {
          this.__mainmodule_frmexistxlinea.Text = "Exist. X Area";
          this.var__mainmodule_sql = "SELECT nombre, sum(M.cantidad) FROM minve M ";
          this.var__mainmodule_sql += "LEFT JOIN areas P ON P.id = M.idArea WHERE cancelado = 'N' GROUP BY nombre";
        }
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_tblexisxlinea.dataTable.Clear();
        this.__mainmodule_tblexisxlinea.dataTable.AcceptChanges();
        double num1 = 0.0;
        double num2 = 1.0;
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tblexisxlinea.AddRow(new object[0]);
          string s = ((double) this.__mainmodule_tblexisxlinea.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), num2.ToString((IFormatProvider) b4p.cul));
          this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
          ++num2;
          if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true")
            num1 += double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_tblexisxlinea.AddRow(new object[0]);
        string s1 = ((double) this.__mainmodule_tblexisxlinea.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), "Total piezas");
        this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[2].MappingName, s1 == "" ? 0 : (int) double.Parse(s1, (IFormatProvider) b4p.cul), num1.ToString((IFormatProvider) b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmexistxlinea_show");
        return "";
      }
    }

    private string __mainmodule_mnuexisxlinea_click()
    {
      try
      {
        this.var__mainmodule_tipomov = "lineas";
        this.__mainmodule_frmexistxlinea.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuexisxlinea_click");
        return "";
      }
    }

    private string __mainmodule_mnuexxlinea_click()
    {
      try
      {
        this.__mainmodule_frmexistxlinea.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuexxlinea_click");
        return "";
      }
    }

    private string __mainmodule_bk_txt()
    {
      string path2 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      string str1 = "";
      string str2 = "";
      string str3 = "";
      double num3 = 0.0;
      string s = "";
      int num4 = 0;
      try
      {
        if (this.err_mainmodule_bk_txt > 0)
        {
          s = (string) this.localVars[7];
          num3 = (double) this.localVars[6];
          str3 = (string) this.localVars[5];
          str2 = (string) this.localVars[4];
          str1 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          path2 = (string) this.localVars[0];
          if (this.err_mainmodule_bk_txt == 1)
          {
            this.err_mainmodule_bk_txt = 0;
            return "";
          }
        }
        num4 = 1;
        path2 = this.b4pdir + "\\BK\\inven" + DateTime.Now.Day.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Month.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Hour.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Minute.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Second.ToString((IFormatProvider) b4p.cul) + ".csv";
        this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, path2), false, Encoding.ASCII));
        this.var__mainmodule_sql = "SELECT articulo, exist FROM inven";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        str1 = "Articulo,cantidad";
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str1);
        s = "0";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          str2 = this.__mainmodule_reader.GetValue(0);
          num2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
          s = ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          str1 = str2 + "," + num2.ToString((IFormatProvider) b4p.cul);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str1);
        }
        this.__mainmodule_reader.Close();
        if (this.htStreams.Contains((object) "_mainmodule_c1"))
        {
          ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
          this.htStreams.Remove((object) "_mainmodule_c1");
          GC.Collect();
        }
        path2 = this.b4pdir + "\\BK\\minve" + DateTime.Now.Day.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Month.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Year.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Hour.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Minute.ToString((IFormatProvider) b4p.cul) + DateTime.Now.Second.ToString((IFormatProvider) b4p.cul) + ".csv";
        this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, path2), false, Encoding.ASCII));
        this.var__mainmodule_sql = "SELECT id, articulo, cantidad, idArea, cancelado FROM minve";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        str1 = "Articulo,cantidad,idArea,cancelado";
        ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str1);
        s = "0";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          str2 = this.__mainmodule_reader.GetValue(1);
          num2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(2), (IFormatProvider) b4p.cul);
          s = ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
          str1 = this.__mainmodule_reader.GetValue(0) + "," + str2 + "," + num2.ToString((IFormatProvider) b4p.cul) + "," + this.__mainmodule_reader.GetValue(3) + "," + this.__mainmodule_reader.GetValue(4);
          ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str1);
        }
        this.__mainmodule_reader.Close();
        if (this.htStreams.Contains((object) "_mainmodule_c1"))
        {
          ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
          this.htStreams.Remove((object) "_mainmodule_c1");
          GC.Collect();
        }
        return "";
      }
      catch (Exception ex)
      {
        if (num4 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_bk_txt = num4;
          this.localVars = new object[8]
          {
            (object) path2,
            (object) num1,
            (object) num2,
            (object) str1,
            (object) str2,
            (object) str3,
            (object) num3,
            (object) s
          };
          return this.__mainmodule_bk_txt();
        }
        this.ShowError(ex, "_mainmodule_bk_txt");
        return "";
      }
    }

    private string __mainmodule_frmareas_show()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      string s = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_frmareas_show > 0)
        {
          s = (string) this.localVars[2];
          num2 = (double) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_frmareas_show == 1)
          {
            this.err_mainmodule_frmareas_show = 0;
            ((int) MessageBox.Show("Error en errfrmAreas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        this.var__mainmodule_tipomov = "";
        this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_tblareas.dataTable.Clear();
        this.__mainmodule_tblareas.dataTable.AcceptChanges();
        num2 = 1.0;
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tblareas.AddRow(new object[0]);
          s = ((double) this.__mainmodule_tblareas.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), num2.ToString((IFormatProvider) b4p.cul));
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
          ++num2;
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_tareanombre.BringToFront();
        this.__mainmodule_btnarea2.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_frmareas_show = num3;
          this.localVars = new object[3]
          {
            (object) num1,
            (object) num2,
            (object) s
          };
          return this.__mainmodule_frmareas_show();
        }
        this.ShowError(ex, "_mainmodule_frmareas_show");
        return "";
      }
    }

    private string __mainmodule_tblareas_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_tblareas_selectionchanged > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_tblareas_selectionchanged == 1)
          {
            this.err_mainmodule_tblareas_selectionchanged = 0;
            ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_tblareas.dataTable.DefaultView.Count.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        lSide = (string) this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.__mainmodule_tblareas.CurrentCell.RowNumber, true);
        if (this.LCompareEqual(lSide, "0"))
        {
          ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.var__mainmodule_tipomov = "edit";
        this.__mainmodule_ltarea.Text = (string) this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        this.__mainmodule_tareanombre.Text = (string) this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul), true);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_tblareas_selectionchanged = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_tblareas_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
        }
        this.ShowError(ex, "_mainmodule_tblareas_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_btneliminar_click()
    {
      string str1 = "";
      int num1 = 0;
      double num2 = 0.0;
      string str2 = "";
      string str3 = "";
      string lSide = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_btneliminar_click > 0)
        {
          lSide = (string) this.localVars[5];
          str3 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (int) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_btneliminar_click == 1)
          {
            this.err_mainmodule_btneliminar_click = 0;
            ((int) MessageBox.Show("Error en errbtnEliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        this.var__mainmodule_tipomov = "";
        if (this.__mainmodule_tblareas.dataTable.DefaultView.Count.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num1 = (int) (double) this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.__mainmodule_tblareas.CurrentCell.RowNumber, false);
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "0"))
        {
          ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str3 = (string) this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.__mainmodule_tblareas.CurrentCell.RowNumber, true);
        lSide = ((int) MessageBox.Show("Desea borar el area " + str3 + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.var__mainmodule_sql = "DELETE FROM areas WHERE id = " + num1.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_desplegarareas();
        this.__mainmodule_tareanombre.Text = "";
        ((int) MessageBox.Show("Partida eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btneliminar_click = num3;
          this.localVars = new object[6]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) str2,
            (object) str3,
            (object) lSide
          };
          return this.__mainmodule_btneliminar_click();
        }
        this.ShowError(ex, "_mainmodule_btneliminar_click");
        return "";
      }
    }

    private string __mainmodule_desplegarareas()
    {
      string s1 = "";
      string s2 = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_desplegarareas > 0)
        {
          s2 = (string) this.localVars[1];
          s1 = (string) this.localVars[0];
          if (this.err_mainmodule_desplegarareas == 1)
          {
            this.err_mainmodule_desplegarareas = 0;
            ((int) MessageBox.Show("Problema detectado en ErrDesplegarAreas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_tblareas.dataTable.Clear();
        this.__mainmodule_tblareas.dataTable.AcceptChanges();
        s1 = "1";
        this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tblareas.AddRow(new object[0]);
          s2 = ((double) this.__mainmodule_tblareas.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[0].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), s1);
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
          s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_desplegarareas = num;
          this.localVars = new object[2]
          {
            (object) s1,
            (object) s2
          };
          return this.__mainmodule_desplegarareas();
        }
        this.ShowError(ex, "_mainmodule_desplegarareas");
        return "";
      }
    }

    private string __mainmodule_btnareagrabar_click()
    {
      double num1 = 0.0;
      string s = "";
      int num2 = 0;
      try
      {
        if (this.err_mainmodule_btnareagrabar_click > 0)
        {
          s = (string) this.localVars[1];
          num1 = (double) this.localVars[0];
          if (this.err_mainmodule_btnareagrabar_click == 1)
          {
            this.err_mainmodule_btnareagrabar_click = 0;
            return "";
          }
        }
        num2 = 1;
        s = this.__mainmodule_ltarea.Text;
        if (this.Other.IsNumber(s).ToLower(b4p.cul) == "true")
        {
          num1 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul);
        }
        else
        {
          this.var__mainmodule_tipomov = "alta";
          num1 = 0.0;
        }
        this.__mainmodule_cmd.CommandText = !this.LCompareEqual(this.var__mainmodule_tipomov, "alta") ? "UPDATE areas SET nombre = '" + this.__mainmodule_tareanombre.Text + "' WHERE id = " + num1.ToString((IFormatProvider) b4p.cul) : "INSERT INTO areas (nombre) values('" + this.__mainmodule_tareanombre.Text + "')";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_tipomov = "";
        ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_tareanombre.Text = "";
        this.__mainmodule_desplegarareas();
        return "";
      }
      catch (Exception ex)
      {
        if (num2 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnareagrabar_click = num2;
          this.localVars = new object[2]
          {
            (object) num1,
            (object) s
          };
          return this.__mainmodule_btnareagrabar_click();
        }
        this.ShowError(ex, "_mainmodule_btnareagrabar_click");
        return "";
      }
    }

    private string __mainmodule_btnareanew_click()
    {
      try
      {
        this.var__mainmodule_tipomov = "alta";
        this.__mainmodule_tareanombre.Text = "";
        this.__mainmodule_tareanombre.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnareanew_click");
        return "";
      }
    }

    private string __mainmodule_btnareas_click()
    {
      try
      {
        this.__mainmodule_frmareas.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnareas_click");
        return "";
      }
    }

    private string __mainmodule_btnarea2_click()
    {
      try
      {
        this.__mainmodule_frmareas.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnarea2_click");
        return "";
      }
    }

    private string __mainmodule_mnuareas_click()
    {
      try
      {
        this.var__mainmodule_tipomov = "areas";
        this.__mainmodule_frmexistxlinea.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuareas_click");
        return "";
      }
    }

    private string __mainmodule_mnuareas1_click()
    {
      try
      {
        this.__mainmodule_pnlareasseries.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_pnlareasseries.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuareas1_click");
        return "";
      }
    }

    private string __mainmodule_mnuborrarareas_click()
    {
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnuborrarareas_click > 0)
        {
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_mnuborrarareas_click == 1)
          {
            this.err_mainmodule_mnuborrarareas_click = 0;
            ((int) MessageBox.Show("Error en ErrmnuBorrarAreas_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        lSide = ((int) MessageBox.Show("Realmente desea borras las areas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM areas";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_tblareas.dataTable.Clear();
        this.__mainmodule_tblareas.dataTable.AcceptChanges();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnuborrarareas_click = num;
          this.localVars = new object[1]{ (object) lSide };
          return this.__mainmodule_mnuborrarareas_click();
        }
        this.ShowError(ex, "_mainmodule_mnuborrarareas_click");
        return "";
      }
    }

    private string __mainmodule_btnareaserie1_click()
    {
      string lSide = "";
      string s = "";
      string format = "";
      int num1 = 0;
      try
      {
        if (this.err_mainmodule_btnareaserie1_click > 0)
        {
          format = (string) this.localVars[2];
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_btnareaserie1_click == 1)
          {
            this.err_mainmodule_btnareaserie1_click = 0;
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            ((int) MessageBox.Show("Error en ErrmnuAreas1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num1 = 1;
        lSide = ((int) MessageBox.Show("Este proceso agregar areas enumeradas y eliminara las existentes, Realmente desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        if (this.__mainmodule_tnotaarea.Text.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          ((int) MessageBox.Show("Por favor capture el nuevo nombre de las areas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        this.__mainmodule_cmd.CommandText = "DELETE FROM areas";
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_cmd.CommandText = "UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='areas';";
        this.__mainmodule_cmd.ExecuteNonQuery();
        s = "0";
        double selectedIndex = (double) this.__mainmodule_cboseriesareas.SelectedIndex;
        for (double num2 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num2 <= selectedIndex; s = (++num2).ToString((IFormatProvider) b4p.cul))
        {
          this.__mainmodule_cmd.CommandText = "INSERT INTO areas (nombre) values('" + this.__mainmodule_tnotaarea.Text + " " + ((format = "D2".ToLower(b4p.cul))[0] != 'd' ? ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0).ToString(format, (IFormatProvider) b4p.cul) : ((int) ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul)) + 1.0)).ToString(format, (IFormatProvider) b4p.cul)) + "')";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        this.__mainmodule_desplegarareas();
        this.__mainmodule_pnlareasseries.Visible = bool.Parse("false".ToLower(b4p.cul));
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        return "";
      }
      catch (Exception ex)
      {
        if (num1 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnareaserie1_click = num1;
          this.localVars = new object[3]
          {
            (object) lSide,
            (object) s,
            (object) format
          };
          return this.__mainmodule_btnareaserie1_click();
        }
        this.ShowError(ex, "_mainmodule_btnareaserie1_click");
        return "";
      }
    }

    private string __mainmodule_btnareaserie2_click()
    {
      try
      {
        this.__mainmodule_pnlareasseries.Visible = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnareaserie2_click");
        return "";
      }
    }

    private string __mainmodule_btntoper1_click()
    {
      string str1 = "";
      double num1 = 0.0;
      double num2 = 0.0;
      string str2 = "";
      string s1 = "";
      string s2 = "";
      int num3 = 0;
      try
      {
        if (this.err_mainmodule_btntoper1_click > 0)
        {
          s2 = (string) this.localVars[5];
          s1 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          num2 = (double) this.localVars[2];
          num1 = (double) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_btntoper1_click == 1)
          {
            this.err_mainmodule_btntoper1_click = 0;
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num3 = 1;
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        str2 = (string) this.__mainmodule_tblexisxlinea.GetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, (int) (double) this.var__mainmodule_crow, true);
        this.__mainmodule_pnltoper.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.var__mainmodule_sql = "SELECT M.id, articulo, M.cantidad FROM minve M ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN areas P ON P.id = M.idArea WHERE nombre = '" + str2 + "' AND cancelado = 'N'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        s1 = "0";
        this.__mainmodule_tbltoper.dataTable.Clear();
        this.__mainmodule_tbltoper.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          Application.DoEvents();
          str1 = this.__mainmodule_reader.GetValue(1);
          num2 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(2), (IFormatProvider) b4p.cul);
          if (num2 > 0.0)
          {
            s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul)) + num2).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_tbltoper.AddRow(new object[0]);
            s2 = ((double) this.__mainmodule_tbltoper.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[0].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
            this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[1].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), str1);
            this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[2].MappingName, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul), num2.ToString((IFormatProvider) b4p.cul));
          }
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_ltstop.Text = "Piezas: " + s1;
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        return "";
      }
      catch (Exception ex)
      {
        if (num3 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btntoper1_click = num3;
          this.localVars = new object[6]
          {
            (object) str1,
            (object) num1,
            (object) num2,
            (object) str2,
            (object) s1,
            (object) s2
          };
          return this.__mainmodule_btntoper1_click();
        }
        this.ShowError(ex, "_mainmodule_btntoper1_click");
        return "";
      }
    }

    private string __mainmodule_tbltoper_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        this.var__mainmodule_crow = var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tbltoper_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_tblexisxlinea_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        this.var__mainmodule_crow = var__mainmodule_row == "" ? 0 : (int) double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tblexisxlinea_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_btntoperborrar_click()
    {
      string lSide = "";
      string s = "";
      string str1 = "";
      string str2 = "";
      string str3 = "";
      int num1 = 0;
      try
      {
        if (this.err_mainmodule_btntoperborrar_click > 0)
        {
          str3 = (string) this.localVars[4];
          str2 = (string) this.localVars[3];
          str1 = (string) this.localVars[2];
          s = (string) this.localVars[1];
          lSide = (string) this.localVars[0];
          if (this.err_mainmodule_btntoperborrar_click == 1)
          {
            this.err_mainmodule_btntoperborrar_click = 0;
            return "";
          }
        }
        num1 = 1;
        this.__mainmodule_pnltoper.Visible = bool.Parse("false".ToLower(b4p.cul));
        lSide = ((int) MessageBox.Show("Desea cancelar el area ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        s = "0";
        double num2 = (double) this.__mainmodule_tbltoper.dataTable.DefaultView.Count - 1.0;
        for (double num3 = s == "" ? 0.0 : double.Parse(s, (IFormatProvider) b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider) b4p.cul))
        {
          str1 = (string) this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), true);
          str2 = (string) this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), true);
          str3 = (string) this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), true);
          this.var__mainmodule_sql = "UPDATE minve SET cancelado = 'C' WHERE id = " + str1;
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.var__mainmodule_sql = "UPDATE inven SET exist = exist - " + str3 + " WHERE articulo = '" + str2 + "'";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        ((int) MessageBox.Show("El area se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num1 > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btntoperborrar_click = num1;
          this.localVars = new object[5]
          {
            (object) lSide,
            (object) s,
            (object) str1,
            (object) str2,
            (object) str3
          };
          return this.__mainmodule_btntoperborrar_click();
        }
        this.ShowError(ex, "_mainmodule_btntoperborrar_click");
        return "";
      }
    }

    private string __mainmodule_btntoper2_click()
    {
      try
      {
        this.__mainmodule_frmexistxlinea.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btntoper2_click");
        return "";
      }
    }

    private string __mainmodule_btntopercerrar_click()
    {
      try
      {
        this.__mainmodule_pnltoper.Visible = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btntopercerrar_click");
        return "";
      }
    }

    private string __mainmodule_cierrareader()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_cierrareader > 0 && this.err_mainmodule_cierrareader == 1)
        {
          this.err_mainmodule_cierrareader = 0;
          return "";
        }
        num = 1;
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cierrareader = num;
          this.localVars = new object[0];
          return this.__mainmodule_cierrareader();
        }
        this.ShowError(ex, "_mainmodule_cierrareader");
        return "";
      }
    }

    private string __mainmodule_btncrearbase_click()
    {
      string str = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btncrearbase_click > 0)
        {
          str = (string) this.localVars[0];
          if (this.err_mainmodule_btncrearbase_click == 1)
          {
            this.err_mainmodule_btncrearbase_click = 0;
            ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_con.Close();
        str = this.b4pdir + "\\dbim.db";
        this.__mainmodule_con.Open("Data Source = " + str);
        if (this.htControls[(object) "__mainmodule_cmd"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_cmd"]);
        this.__mainmodule_cmd = new B4PSQL.Command("", this.__mainmodule_con.Value);
        this.htControls[(object) "__mainmodule_cmd"] = (object) this.__mainmodule_cmd;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_cmd] = (object) "__mainmodule_cmd";
        this.var__mainmodule_sql = "CREATE TABLE [areas] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[area] VARCHAR(5) NULL,[nombre] VARCHAR(40) NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [compras] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[cve_doc] VARCHAR(20)  NULL,[articulo] VARCHAR(16)  NULL,[cant] NUMERIC  NULL,[alm1] NUMERIC  NULL,[nuevo] VARCHAR(1)  NULL,[status] VARCHAR(1)  NULL,[cancelado] VARCHAR(1)  NULL,[usuario] VARCHAR(15)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [config] ([puerto] varchar(6)  NULL,[bloqueo] varchar(1)  NULL,[despedida] TEXT  NULL,[encabezado] TEXT  NULL,[rutapc] TEXT  NULL,[folio] Integer  NULL,[folioInv] Integer  NULL,[sistema] Integer  NULL,[foliocompra] Integer  NULL,[seriecompra] VARCHAR(6)  NULL,[server] VARCHAR(40)  NULL,[base] VARCHAR(30)  NULL,[user] VARCHAR(15)  NULL,[pass] VARCHAR(15)  NULL,[port] VARCHAR(5)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [conm] ([num_cpto] Integer  NULL,[descr] VARCHAR(50)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [empresas] ([empresa] VARCHAR(2)  NULL PRIMARY KEY,[nombre] VARCHAR(30)  NULL,[servidor] VARCHAR(30)  NULL,[remoto] VARCHAR(30)  NULL,[base] VARCHAR(20)  NULL,[usuario] VARCHAR(12)  NULL,[pass] VARCHAR(12)  NULL,[puerto] VARCHAR(12)  NULL,[ctrl_alm] VARCHAR(10)  NULL,[almacen] Integer  NULL,[correo] VARCHAR(90)  NULL,[linea] VARCHAR(5)  NULL,[correo2] VARCHAR(90)  NULL,[multialmacen] Integer)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [inven] ([articulo] varchar(16)  PRIMARY KEY NULL,[exist] NUMERIC  Not NULL,[status] Integer  NULL,[costo_prom] FLOAT  NULL,[uni_med] VARCHAR(10)  NULL,[estatus] VARCHAR(1)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [minve] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[articulo] VARCHAR(16)  NULL,[cantidad] NUMERIC  NULL,[alm1] NUMERIC  NULL,[nuevo] VARCHAR(1)  NULL,[cancelado] VARCHAR(1)  NULL,[usuario] VARCHAR(15)  NULL, idArea Integer NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [movsinv] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[folio] NUMERIC  NULL,[tiendaorigen] VARCHAR(3)  NULL,[tiendadestino] VARCHAR(3)  NULL,[articulo] varchar(16)  NULL,[cantidad] NUMERIC  NULL,[nuevo] varchar(1)  NULL,[cancelado] VARCHAR(1)  NULL,[descrip] VARCHAR(5)  NULL,[tipo] VARCHAR(1)  NULL,[sistema] VARCHAR(10)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [noencontrados] ([articulo] varchar(16)  PRIMARY KEY NULL,[exist] NUMERIC Not NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [prods] ([articulo] varchar(16)  NULL,[descrip] varchar(60)  NULL,[existencia] NUMERIC  NULL,[almacen] NUMERIC  NULL,[clavealterna] varchar(16)  NULL,[ctrl_alm] VARCHAR(10)  NULL,[linea] VARCHAR(5)  NULL,[costo_prom] FLOAT  NULL,[uni_med] VARCHAR(5)  NULL,[impu1] FLOAT  NULL,[impu4] FLOAT  NULL,[status] Integer  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [provs] ([clave] VARCHAR(10)  NULL,[nombre] VARCHAR(60)  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.var__mainmodule_sql = "CREATE TABLE [usuarios] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[usuario] VARCHAR(20)  NULL,[password] VARCHAR(20)  NULL,[nombre] VARCHAR(60)  NULL,[serie] VARCHAR(5)  NULL,[folio] Integer  NULL,[nivel] Integer  NULL)";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_con.Close();
        if (this.mainForm != null)
          this.mainForm.Close();
        else
          this.CloseProgram();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btncrearbase_click = num;
          this.localVars = new object[1]{ (object) str };
          return this.__mainmodule_btncrearbase_click();
        }
        this.ShowError(ex, "_mainmodule_btncrearbase_click");
        return "";
      }
    }

    private string __mainmodule_frmmenu_show()
    {
      try
      {
        this.__mainmodule_btnmenuinvent.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmmenu_show");
        return "";
      }
    }

    private string __mainmodule_frmtraspasos_show()
    {
      try
      {
        this.__mainmodule_label36.BringToFront();
        this.__mainmodule_cbotiendaorigen.BringToFront();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_frmtraspasos_show");
        return "";
      }
    }

    private string __mainmodule_btnpedido_click()
    {
      try
      {
        this.__mainmodule_pnlpedidos.BringToFront();
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tpedcte.Text = "";
        this.__mainmodule_ltnombrecte.Text = "";
        this.var__mainmodule_tipoproc = "pedidos";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnpedido_click");
        return "";
      }
    }

    private string __mainmodule_mnunewpedido_click()
    {
      try
      {
        if (this.LCompareEqual(((int) MessageBox.Show("Realmente desea iniciar nuevo pedido?", "Folio siguiente " + this.var__mainmodule_seriepedido + (this.var__mainmodule_folioped + 1.0).ToString((IFormatProvider) b4p.cul), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        ++this.var__mainmodule_folioped;
        this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.CommandText = "UPDATE config SET folioped = " + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmd.ExecuteNonQuery();
        this.__mainmodule_invent.close();
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(b4p.cul));
        this.__mainmodule_tpedcte.Text = "";
        this.__mainmodule_ltnombrecte.Text = "";
        this.__mainmodule_tpedcte.Focus();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnunewpedido_click");
        return "";
      }
    }

    private string __mainmodule_genpedido_show()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_genpedido_show > 0 && this.err_mainmodule_genpedido_show == 1)
        {
          this.err_mainmodule_genpedido_show = 0;
          ((int) MessageBox.Show("Error en errerrGENPEDIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        this.var__mainmodule_sql = "SELECT cve_doc FROM pedidos WHERE nuevo = 'S' AND cancelado = 'N' GROUP BY cve_doc";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_cbopedido.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_cbopedido.Items.Add((object) this.__mainmodule_reader.GetValue(0));
        this.__mainmodule_reader.Close();
        this.__mainmodule_btngenpedido.BringToFront();
        this.__mainmodule_btnsalirpedido.BringToFront();
        this.__mainmodule_cbopedido.Focus();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_genpedido_show = num;
          this.localVars = new object[0];
          return this.__mainmodule_genpedido_show();
        }
        this.ShowError(ex, "_mainmodule_genpedido_show");
        return "";
      }
    }

    private string __mainmodule_btngenpedido_click()
    {
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      try
      {
        int num1 = (int) MessageBox.Show("Realmente desea generar pedido?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        if (this.LCompareEqual(num1.ToString((IFormatProvider) b4p.cul), "7"))
          return "";
        string str7 = "";
        string str8;
        string s1;
        if (this.__mainmodule_chenviartodospedidos.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str8 = "0";
          s1 = ((double) this.__mainmodule_cbopedido.Items.Count - 1.0).ToString((IFormatProvider) b4p.cul);
        }
        else
        {
          if (this.__mainmodule_cbopedido.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
          {
            ((int) MessageBox.Show("Por favor selecione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
          str8 = this.__mainmodule_cbopedido.SelectedIndex.ToString((IFormatProvider) b4p.cul);
          num1 = this.__mainmodule_cbopedido.SelectedIndex;
          s1 = num1.ToString((IFormatProvider) b4p.cul);
        }
        string s2 = "0";
        if (this.htControls[(object) "__mainmodule_msql1"] != null)
          this.CEnhancedObject.htShemotAzamim.Remove(this.htControls[(object) "__mainmodule_msql1"]);
        this.__mainmodule_msql1 = new MSSQL.MSSQL();
        this.htControls[(object) "__mainmodule_msql1"] = (object) this.__mainmodule_msql1;
        this.CEnhancedObject.htShemotAzamim[(object) this.__mainmodule_msql1] = (object) "__mainmodule_msql1";
        if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
        {
          Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
          num1 = (int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
          num1.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_msql1.Close();
          return "";
        }
        string s3 = str8;
        double num2 = s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider) b4p.cul);
        double num3 = s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider) b4p.cul);
        while (num3 <= num2)
        {
          str2 = !this.LCompareEqual(this.var__mainmodule_seriepedido, "") ? this.__mainmodule_cbopedido.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString() : this.__mainmodule_replicate(" ", 20.0 - (double) this.__mainmodule_cbopedido.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString().Length) + this.__mainmodule_cbopedido.Items[s3 == "" ? 0 : (int) double.Parse(s3, (IFormatProvider) b4p.cul)].ToString();
          double num4 = 1.0;
          string s4 = "0";
          str4 = "0";
          str5 = "0";
          string s5 = "0";
          string s6 = "0";
          string s7 = "0";
          this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.costo_prom), MAX(P.uni_med), MAX(P.impu1), MAX(P.impu4), MAX(P.precio1), MAX(clave), ";
          this.var__mainmodule_sql += "ifnull(MAX(cve_esqimpu),0), ifnull(max(folio),0), ifnull(max(imp1aplica),0), ifnull(max(imp2aplica),0), ";
          this.var__mainmodule_sql += "ifnull(Max(imp3aplica),0), ifnull(Max(imp4aplica),0) ";
          this.var__mainmodule_sql += "FROM pedidos I ";
          this.var__mainmodule_sql += "INNER JOIN prods P ON P.articulo = I.articulo WHERE ";
          this.var__mainmodule_sql = this.var__mainmodule_sql + "I.nuevo = 'S' AND cve_doc = '" + str2 + "' AND cancelado = 'N' GROUP BY I.articulo";
          this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
          this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
          double num5;
          while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          {
            num5 = (s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) + 1.0;
            s2 = num5.ToString((IFormatProvider) b4p.cul);
            string s8 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(b4p.cul) == "true") ? "0" : this.__mainmodule_reader.GetValue(2);
            str3 = this.__mainmodule_reader.GetValue(7);
            string str9 = this.__mainmodule_reader.GetValue(8);
            str6 = this.__mainmodule_reader.GetValue(9);
            double num6 = double.Parse(this.__mainmodule_reader.GetValue(10), (IFormatProvider) b4p.cul);
            double num7 = double.Parse(this.__mainmodule_reader.GetValue(11), (IFormatProvider) b4p.cul);
            double num8 = double.Parse(this.__mainmodule_reader.GetValue(12), (IFormatProvider) b4p.cul);
            double num9 = double.Parse(this.__mainmodule_reader.GetValue(13), (IFormatProvider) b4p.cul);
            num5 = Math.Round(s8 == "" ? 0.0 : double.Parse(s8, (IFormatProvider) b4p.cul), 2);
            string s9 = num5.ToString((IFormatProvider) b4p.cul);
            string s10 = "0";
            string str10 = this.__mainmodule_reader.GetValue(0);
            double num10 = double.Parse(this.__mainmodule_reader.GetValue(1), (IFormatProvider) b4p.cul);
            double num11 = !(this.Other.IsNumber(this.__mainmodule_reader.GetValue(6)).ToLower(b4p.cul) == "true") ? 0.0 : double.Parse(this.__mainmodule_reader.GetValue(6), (IFormatProvider) b4p.cul);
            num5 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider) b4p.cul)) + num11 * num10;
            s4 = num5.ToString((IFormatProvider) b4p.cul);
            num5 = (s5 == "" ? 0.0 : double.Parse(s5, (IFormatProvider) b4p.cul)) + num11 * num10;
            s5 = num5.ToString((IFormatProvider) b4p.cul);
            str5 = "0";
            string str11 = str10;
            double num12 = s9 == "" ? 0.0 : double.Parse(s9, (IFormatProvider) b4p.cul);
            double num13 = double.Parse(this.__mainmodule_reader.GetValue(4), (IFormatProvider) b4p.cul);
            double num14 = double.Parse(this.__mainmodule_reader.GetValue(5), (IFormatProvider) b4p.cul);
            num5 = num11 * num13 / 100.0;
            string s11 = num5.ToString((IFormatProvider) b4p.cul);
            string s12;
            if (this.LCompareEqual(num9.ToString((IFormatProvider) b4p.cul), "1"))
            {
              num5 = (num11 + (s11 == "" ? 0.0 : double.Parse(s11, (IFormatProvider) b4p.cul))) * num14 / 100.0;
              s12 = num5.ToString((IFormatProvider) b4p.cul);
            }
            else
            {
              num5 = num11 * num14 / 100.0;
              s12 = num5.ToString((IFormatProvider) b4p.cul);
            }
            num5 = (s6 == "" ? 0.0 : double.Parse(s6, (IFormatProvider) b4p.cul)) + (s11 == "" ? 0.0 : double.Parse(s11, (IFormatProvider) b4p.cul));
            s6 = num5.ToString((IFormatProvider) b4p.cul);
            num5 = (s7 == "" ? 0.0 : double.Parse(s7, (IFormatProvider) b4p.cul)) + (s12 == "" ? 0.0 : double.Parse(s12, (IFormatProvider) b4p.cul));
            s7 = num5.ToString((IFormatProvider) b4p.cul);
            double num15 = Math.Round(s11 == "" ? 0.0 : double.Parse(s11, (IFormatProvider) b4p.cul), 3);
            double num16 = Math.Round(s12 == "" ? 0.0 : double.Parse(s12, (IFormatProvider) b4p.cul), 3);
            double num17 = 1.0;
            string str12 = this.__mainmodule_reader.GetValue(3);
            string str13 = "0";
            double num18 = Math.Round(num11 * num10 - num11 * num10 * (s10 == "" ? 0.0 : double.Parse(s10, (IFormatProvider) b4p.cul)) / 100.0, 3);
            if (this.__mainmodule_msql1.ExecuteQuery("EXECUTE PDA_PEDIDOS_PART '" + str2 + "'," + num4.ToString((IFormatProvider) b4p.cul) + ",'" + str11 + "'," + num10.ToString((IFormatProvider) b4p.cul) + "," + num11.ToString((IFormatProvider) b4p.cul) + "," + num12.ToString((IFormatProvider) b4p.cul) + "," + num13.ToString((IFormatProvider) b4p.cul) + "," + num14.ToString((IFormatProvider) b4p.cul) + "," + num6.ToString((IFormatProvider) b4p.cul) + "," + num7.ToString((IFormatProvider) b4p.cul) + "," + num8.ToString((IFormatProvider) b4p.cul) + "," + num9.ToString((IFormatProvider) b4p.cul) + "," + num15.ToString((IFormatProvider) b4p.cul) + "," + num16.ToString((IFormatProvider) b4p.cul) + "," + str13 + ",'" + str12 + "'," + num17.ToString((IFormatProvider) b4p.cul) + "," + num18.ToString((IFormatProvider) b4p.cul) + "," + str9).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
            {
              this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\PROC ALMACENADO PEDIDOS PAR.txt"), false, Encoding.UTF8));
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(str1);
              ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
              if (this.htStreams.Contains((object) "_mainmodule_c1"))
              {
                ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
                this.htStreams.Remove((object) "_mainmodule_c1");
                GC.Collect();
              }
              Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
              num1 = (int) MessageBox.Show("Problema en el ALMACENADO PEDIDOS PAR\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
              num1.ToString((IFormatProvider) b4p.cul);
              break;
            }
            ++num4;
            this.__mainmodule_ltpedart.Text = str10;
            this.__mainmodule_ltpedcant.Text = num10.ToString((IFormatProvider) b4p.cul);
            this.__mainmodule_ltpedreg.Text = s2;
          }
          this.__mainmodule_reader.Close();
          string str14 = "P";
          string str15 = "0";
          string s13 = s5;
          string str16 = "O";
          num5 = Math.Round(s13 == "" ? 0.0 : double.Parse(s13, (IFormatProvider) b4p.cul), 3);
          string str17 = num5.ToString((IFormatProvider) b4p.cul);
          num5 = Math.Round(s6 == "" ? 0.0 : double.Parse(s6, (IFormatProvider) b4p.cul), 3);
          string str18 = num5.ToString((IFormatProvider) b4p.cul);
          num5 = Math.Round(s7 == "" ? 0.0 : double.Parse(s7, (IFormatProvider) b4p.cul), 3);
          string str19 = num5.ToString((IFormatProvider) b4p.cul);
          string str20 = "0";
          num5 = Math.Round((s13 == "" ? 0.0 : double.Parse(s13, (IFormatProvider) b4p.cul)) + (s6 == "" ? 0.0 : double.Parse(s6, (IFormatProvider) b4p.cul)) + (s7 == "" ? 0.0 : double.Parse(s7, (IFormatProvider) b4p.cul)), 3);
          string str21 = num5.ToString((IFormatProvider) b4p.cul);
          string str22 = str15;
          string str23 = "";
          string query = "EXECUTE PDA_PEDIDOS '" + str14 + "','" + str2 + "','" + str3 + "','" + str16 + "','" + str23 + "'," + str17 + "," + str18 + "," + str19 + "," + str22 + "," + str20 + "," + this.var__mainmodule_almacen.ToString((IFormatProvider) b4p.cul) + ",'" + this.var__mainmodule_seriepedido + "'," + str6 + "," + str21 + ",'" + str7 + "'";
          if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "false")
          {
            Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
            this.htStreams.Add((object) "_mainmodule_c1", (object) new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\PEDIDO CABEZA.txt"), false, Encoding.UTF8));
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(query);
            ((TextWriter) this.htStreams[(object) "_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
            if (this.htStreams.Contains((object) "_mainmodule_c1"))
            {
              ((IStream) this.htStreams[(object) "_mainmodule_c1"]).Close();
              this.htStreams.Remove((object) "_mainmodule_c1");
              GC.Collect();
            }
            num1 = (int) MessageBox.Show("Problema en el ALMACENADO PEDIDO CADENZA\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            num1.ToString((IFormatProvider) b4p.cul);
          }
          num5 = ++num3;
          s3 = num5.ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_msql1.Close();
        if ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider) b4p.cul)) > 0.0)
        {
          ++this.var__mainmodule_folioped;
          this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.CommandText = "UPDATE config SET folioped = " + this.var__mainmodule_folioped.ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_cmd.ExecuteNonQuery();
          this.__mainmodule_cmd.CommandText = !(this.__mainmodule_chenviartodospedidos.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true") ? "UPDATE pedidos SET nuevo = 'N' WHERE cve_doc = '" + str2 + "'" : "UPDATE pedidos SET nuevo = 'N'";
          this.__mainmodule_cmd.ExecuteNonQuery();
        }
        num1 = (int) MessageBox.Show("ok partidas enviadas " + s2, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        num1.ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_ltinven2.Text = "";
        this.__mainmodule_ltinven.Text = "";
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btngenpedido_click");
        return "";
      }
    }

    private string __mainmodule_mnupedido_click()
    {
      try
      {
        this.__mainmodule_genpedido.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnupedido_click");
        return "";
      }
    }

    private string __mainmodule_btnsalirpedido_click()
    {
      try
      {
        this.__mainmodule_genpedido.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsalirpedido_click");
        return "";
      }
    }

    private string __mainmodule_frmpedidosutils_show()
    {
      string str = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_frmpedidosutils_show > 0)
        {
          str = (string) this.localVars[0];
          if (this.err_mainmodule_frmpedidosutils_show == 1)
          {
            this.err_mainmodule_frmpedidosutils_show = 0;
            ((int) MessageBox.Show("Problema detectado en frmPedidosUtils", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        this.__mainmodule_tblpedidos.dataTable.Clear();
        this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
        this.var__mainmodule_sql = "SELECT cve_doc, max(cancelado) FROM pedidos WHERE nuevo = 'S' GROUP BY cve_doc";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_cboclieutils.Items.Clear();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str = !(this.__mainmodule_reader.GetValue(1) == "C") ? "" : "   Cancelado";
          this.__mainmodule_cboclieutils.Items.Add((object) (this.__mainmodule_reader.GetValue(0) + str));
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_label56.BringToFront();
        this.__mainmodule_cboclieutils.BringToFront();
        this.var__mainmodule_rowcompra = -1.0;
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_frmpedidosutils_show = num;
          this.localVars = new object[1]{ (object) str };
          return this.__mainmodule_frmpedidosutils_show();
        }
        this.ShowError(ex, "_mainmodule_frmpedidosutils_show");
        return "";
      }
    }

    private string __mainmodule_cboclieutils_selectionchanged(
      string var__mainmodule_index,
      string var__mainmodule_value)
    {
      string str = "";
      string s = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_cboclieutils_selectionchanged > 0)
        {
          s = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_mainmodule_cboclieutils_selectionchanged == 1)
          {
            this.err_mainmodule_cboclieutils_selectionchanged = 0;
            ((int) MessageBox.Show("Problema detectado en ClieUtils_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str = this.__mainmodule_cboclieutils.Items[(int) (double) this.__mainmodule_cboclieutils.SelectedIndex].ToString();
        this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.descrip) ";
        this.var__mainmodule_sql += "FROM pedidos I INNER JOIN prods P ON P.articulo = I.articulo ";
        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE cve_doc = '" + str + "' AND nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        this.__mainmodule_tblpedidos.dataTable.Clear();
        this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_tblpedidos.AddRow(new object[0]);
          s = ((double) this.__mainmodule_tblpedidos.dataTable.DefaultView.Count - 1.0).ToString((IFormatProvider) b4p.cul);
          this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[0].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(0));
          this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[1].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(2));
          this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[2].MappingName, s == "" ? 0 : (int) double.Parse(s, (IFormatProvider) b4p.cul), this.__mainmodule_reader.GetValue(1));
        }
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cboclieutils_selectionchanged = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) s
          };
          return this.__mainmodule_cboclieutils_selectionchanged(var__mainmodule_index, var__mainmodule_value);
        }
        this.ShowError(ex, "_mainmodule_cboclieutils_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_tblpedidos_selectionchanged(
      string var__mainmodule_colname,
      string var__mainmodule_row)
    {
      try
      {
        this.var__mainmodule_rowcompra = var__mainmodule_row == "" ? 0.0 : double.Parse(var__mainmodule_row, (IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tblpedidos_selectionchanged");
        return "";
      }
    }

    private string __mainmodule_mnucanped_click()
    {
      string str = "";
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnucanped_click > 0)
        {
          lSide = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_mainmodule_mnucanped_click == 1)
          {
            this.err_mainmodule_mnucanped_click = 0;
            ((int) MessageBox.Show("Problema detectado en ClieUtils_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str = this.__mainmodule_cboclieutils.Items[(int) (double) this.__mainmodule_cboclieutils.SelectedIndex].ToString();
        lSide = ((int) MessageBox.Show("Realmente desea cancelar el pedido " + str + "?", "Cancelar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        if ((double) str.IndexOf("Cancelado", 1) > 0.0)
        {
          ((int) MessageBox.Show("El documento ya se encuentra cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET cancelado = 'C' WHERE cve_doc = '" + str + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El documento se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnucanped_click = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) lSide
          };
          return this.__mainmodule_mnucanped_click();
        }
        this.ShowError(ex, "_mainmodule_mnucanped_click");
        return "";
      }
    }

    private string __mainmodule_mnureenped_click()
    {
      string str = "";
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnureenped_click > 0)
        {
          lSide = (string) this.localVars[1];
          str = (string) this.localVars[0];
          if (this.err_mainmodule_mnureenped_click == 1)
          {
            this.err_mainmodule_mnureenped_click = 0;
            ((int) MessageBox.Show("Problema detectado en mnuReenPed_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str = this.__mainmodule_cboclieutils.Items[(int) (double) this.__mainmodule_cboclieutils.SelectedIndex].ToString();
        if ((double) str.IndexOf("Cancelado", 1) > 0.0)
        {
          ((int) MessageBox.Show("El documento actualmente se encuentra cancelado no es posible reenviarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        lSide = ((int) MessageBox.Show("Realmente desea re-marcar para reenviar el documento " + str + "?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET nuevo = 'S' WHERE cve_doc = '" + str + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("El documento puede ser enviado nuavamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnureenped_click = num;
          this.localVars = new object[2]
          {
            (object) str,
            (object) lSide
          };
          return this.__mainmodule_mnureenped_click();
        }
        this.ShowError(ex, "_mainmodule_mnureenped_click");
        return "";
      }
    }

    private string __mainmodule_mnueliped_click()
    {
      string str1 = "";
      string str2 = "";
      string lSide = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_mnueliped_click > 0)
        {
          lSide = (string) this.localVars[2];
          str2 = (string) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_mnueliped_click == 1)
          {
            this.err_mainmodule_mnueliped_click = 0;
            ((int) MessageBox.Show("Problema detectado en mnuEliPed_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            return "";
          }
        }
        num = 1;
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.var__mainmodule_rowcompra < 0.0)
        {
          ((int) MessageBox.Show("Por favor seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        if (this.__mainmodule_cboclieutils.SelectedIndex.ToString((IFormatProvider) b4p.cul) == -1.0.ToString((IFormatProvider) b4p.cul))
        {
          ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        str1 = this.__mainmodule_cboclieutils.Items[(int) (double) this.__mainmodule_cboclieutils.SelectedIndex].ToString();
        str2 = (string) this.__mainmodule_tblpedidos.GetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[0].MappingName, (int) this.var__mainmodule_rowcompra, true);
        lSide = ((int) MessageBox.Show("Realmente desea eliminar partida " + str2 + "?", "Cancelar partida compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        if (this.LCompareEqual(lSide, "7"))
          return "";
        this.__mainmodule_cmd.CommandText = "DELETE FROM pedidos WHERE cve_doc = '" + str1 + "' AND articulo = '" + str2 + "'";
        this.__mainmodule_cmd.ExecuteNonQuery();
        ((int) MessageBox.Show("La partida se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.var__mainmodule_rowcompra = -1.0;
        this.__mainmodule_tblpedidos.dataTable.Clear();
        this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_mnueliped_click = num;
          this.localVars = new object[3]
          {
            (object) str1,
            (object) str2,
            (object) lSide
          };
          return this.__mainmodule_mnueliped_click();
        }
        this.ShowError(ex, "_mainmodule_mnueliped_click");
        return "";
      }
    }

    private string __mainmodule_mnuopcionesped_click()
    {
      try
      {
        this.__mainmodule_frmpedidosutils.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_mnuopcionesped_click");
        return "";
      }
    }

    private string __mainmodule_btnsalped_click()
    {
      try
      {
        this.__mainmodule_frmpedidosutils.close();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnsalped_click");
        return "";
      }
    }

    private string __mainmodule_cmdbuscar_click()
    {
      string str1 = "";
      string str2 = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_cmdbuscar_click > 0)
        {
          str2 = (string) this.localVars[1];
          str1 = (string) this.localVars[0];
          if (this.err_mainmodule_cmdbuscar_click == 1)
          {
            this.err_mainmodule_cmdbuscar_click = 0;
            return "";
          }
        }
        num = 1;
        Cursor.Current = bool.Parse("true".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        this.__mainmodule_cmdbuscar.Enabled = bool.Parse("false".ToLower(b4p.cul));
        str1 = this.__mainmodule_tcliente.Text;
        if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
        {
          if (str1.Length.ToString((IFormatProvider) b4p.cul) == "0")
          {
            this.var__mainmodule_sql = "SELECT clave, nombre FROM clientes ORDER BY nombre LIMIT 40";
          }
          else
          {
            this.var__mainmodule_sql = "SELECT clave, nombre FROM clientes WHERE clave LIKE '%" + str1 + "%' OR nombre LIKE '%" + str1 + "%'";
            this.var__mainmodule_sql += " ORDER BY nombre LIMIT 40";
          }
        }
        else if (str1.Length.ToString((IFormatProvider) b4p.cul) == "0")
        {
          this.var__mainmodule_sql = "SELECT clave, nombre FROM provs ORDER BY nombre LIMIT 40";
        }
        else
        {
          this.var__mainmodule_sql = "SELECT clave, nombre FROM provs WHERE clave LIKE '%" + str1 + "%' OR nombre LIKE '%" + str1 + "%'";
          this.var__mainmodule_sql += " ORDER BY nombre LIMIT 40";
        }
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_listcte.BringToFront();
        this.__mainmodule_listcte.Focus();
        this.__mainmodule_listcte.Clear();
        this.__mainmodule_listcte.Refresh();
        this.__mainmodule_listcte.SuspendLayout();
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        str2 = "0";
        while (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          str1 = this.__mainmodule_reader.GetValue(1);
          this.__mainmodule_item.CreateNew();
          this.__mainmodule_item.Text = this.__mainmodule_reader.GetValue(0) + " " + this.Other.SubString(this.__mainmodule_reader.GetValue(1), 0, 22);
          this.__mainmodule_item.Tag = this.__mainmodule_reader.GetValue(0);
          this.__mainmodule_item.BackColor1 = -10496;
          this.__mainmodule_item.ForeColor = -16777216;
          this.__mainmodule_item.FontSize = 9f;
          this.__mainmodule_item.Font = "Courier New";
          this.__mainmodule_listcte.Add((_listItem) this.__mainmodule_item.Value);
          str2 = ((str2 == "" ? 0.0 : double.Parse(str2, (IFormatProvider) b4p.cul)) + 1.0).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        this.__mainmodule_listcte.ResumeLayout();
        this.var__mainmodule_crow = -1;
        Cursor.Current = bool.Parse("false".ToLower(b4p.cul)) ? Cursors.WaitCursor : Cursors.Default;
        if (this.LCompareEqual(str2, "0"))
          ((int) MessageBox.Show("No se encontraron coinsidencias de clientes", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_cmdbuscar.Enabled = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_cmdbuscar_click = num;
          this.localVars = new object[2]
          {
            (object) str1,
            (object) str2
          };
          return this.__mainmodule_cmdbuscar_click();
        }
        this.ShowError(ex, "_mainmodule_cmdbuscar_click");
        return "";
      }
    }

    private string __mainmodule_btnbuscarcte_click()
    {
      try
      {
        this.__mainmodule_frmclientes.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnbuscarcte_click");
        return "";
      }
    }

    private string __mainmodule_btncteped1_click()
    {
      try
      {
        if (this.__mainmodule_tpedcte.Text == "")
        {
          if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
            ((int) MessageBox.Show("Por favor seleccione un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          else
            ((int) MessageBox.Show("Por favor seleccione un proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        string s1 = this.__mainmodule_tpedcte.Text.Replace(" ", "");
        if (this.Other.IsNumber(s1).ToLower(b4p.cul) == "true")
        {
          string s2 = (10.0 - (double) s1.Length).ToString((IFormatProvider) b4p.cul);
          s1 = this.Other.SubString("@@@@@@@@@@", 1, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul)).Replace("@", " ") + s1;
        }
        this.__mainmodule_tpedcte.Text = s1;
        this.var__mainmodule_sql = !this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos") ? "SELECT nombre FROM provs WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'" : "SELECT nombre, status FROM clientes WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
        string lSide = "false";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
        {
          this.__mainmodule_ltnombrecte.Text = this.__mainmodule_reader.GetValue(0);
          if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
          {
            if (this.__mainmodule_reader.GetValue(1) == "S")
              ((int) MessageBox.Show("El cliente esta SUSPENDIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
            if (this.__mainmodule_reader.GetValue(1) == "M")
              ((int) MessageBox.Show("Cliente MOROSO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          }
        }
        else
        {
          lSide = "true";
          if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
            ((int) MessageBox.Show("Cliente inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          else
            ((int) MessageBox.Show("Proveedor inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        }
        this.__mainmodule_reader.Close();
        if (this.LCompareEqual(lSide, "true"))
          return "";
        this.__mainmodule_lt2.Text = this.__mainmodule_tpedcte.Text;
        this.__mainmodule_lt4.Text = this.__mainmodule_ltnombrecte.Text;
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("false".ToLower(b4p.cul));
        this.__mainmodule_invent.show();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btncteped1_click");
        return "";
      }
    }

    private string __mainmodule_btncteped2_click()
    {
      try
      {
        this.__mainmodule_tpedcte.Text = "";
        this.__mainmodule_ltnombrecte.Text = "";
        this.__mainmodule_pnlpedidos.Visible = bool.Parse("false".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btncteped2_click");
        return "";
      }
    }

    private string __mainmodule_listcte_click()
    {
      try
      {
        this.__mainmodule_item.Value = (_pictureListItem) this.__mainmodule_listcte.ClickedItem;
        this.__mainmodule_tpedcte.Text = this.__mainmodule_item.Tag;
        this.__mainmodule_ltnombrecte.Text = "";
        this.__mainmodule_frmclientes.close();
        this.__mainmodule_btnokcte_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_listcte_click");
        return "";
      }
    }

    private string __mainmodule_frmclientes_show()
    {
      int num = 0;
      try
      {
        if (this.err_mainmodule_frmclientes_show > 0 && this.err_mainmodule_frmclientes_show == 1)
        {
          this.err_mainmodule_frmclientes_show = 0;
          ((int) MessageBox.Show("Ocurrio un error en errfrmClientes", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
          return "";
        }
        num = 1;
        this.__mainmodule_tcliente.Text = "";
        this.__mainmodule_tcliente.BringToFront();
        this.__mainmodule_cmdbuscar.BringToFront();
        this.__mainmodule_listcte.Clear();
        this.__mainmodule_listcte.ItemHeight = 20;
        this.__mainmodule_listcte.Top = (int) ((double) (this.__mainmodule_tcliente.Top / 1) + (double) (this.__mainmodule_tcliente.Height / 1) + 2.0);
        this.__mainmodule_listcte.Left = 0;
        this.__mainmodule_listcte.Width = (int) (double) this.screenX;
        this.__mainmodule_listcte.BackColor = -8093052;
        this.__mainmodule_listcte.Height = (int) ((double) this.screenY - ((double) (this.__mainmodule_tcliente.Top / 1) + (double) (this.__mainmodule_tcliente.Height / 1) + 4.0));
        this.__mainmodule_listcte.BackColor = -8093052;
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_frmclientes_show = num;
          this.localVars = new object[0];
          return this.__mainmodule_frmclientes_show();
        }
        this.ShowError(ex, "_mainmodule_frmclientes_show");
        return "";
      }
    }

    private string __mainmodule_btnokcte_click()
    {
      string s1 = "";
      string s2 = "";
      string original = "";
      string str = "";
      int num = 0;
      try
      {
        if (this.err_mainmodule_btnokcte_click > 0)
        {
          str = (string) this.localVars[3];
          original = (string) this.localVars[2];
          s2 = (string) this.localVars[1];
          s1 = (string) this.localVars[0];
          if (this.err_mainmodule_btnokcte_click == 1)
          {
            this.err_mainmodule_btnokcte_click = 0;
            return "";
          }
        }
        num = 1;
        s1 = this.__mainmodule_tpedcte.Text.Replace(" ", "");
        if (this.Other.IsNumber(s1).ToLower(b4p.cul) == "true")
        {
          s2 = (10.0 - (double) s1.Length).ToString((IFormatProvider) b4p.cul);
          original = "@@@@@@@@@@";
          str = this.Other.SubString(original, 1, s2 == "" ? 0 : (int) double.Parse(s2, (IFormatProvider) b4p.cul));
          s1 = str.Replace("@", " ") + s1;
        }
        this.__mainmodule_tpedcte.Text = s1;
        this.var__mainmodule_sql = !this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos") ? "SELECT nombre FROM provs WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'" : "SELECT nombre FROM clientes WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
        if (this.__mainmodule_reader.ReadNextRow().ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_ltnombrecte.Text = this.__mainmodule_reader.GetValue(0);
        else if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
          ((int) MessageBox.Show("Cliente inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        else
          ((int) MessageBox.Show("Proveedor inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider) b4p.cul);
        this.__mainmodule_reader.Close();
        return "";
      }
      catch (Exception ex)
      {
        if (num > 0)
        {
          this.lastError = ex;
          this.err_mainmodule_btnokcte_click = num;
          this.localVars = new object[4]
          {
            (object) s1,
            (object) s2,
            (object) original,
            (object) str
          };
          return this.__mainmodule_btnokcte_click();
        }
        this.ShowError(ex, "_mainmodule_btnokcte_click");
        return "";
      }
    }

    private string __mainmodule_tpedcte_keypress(string var__mainmodule_key)
    {
      try
      {
        if (this.LCompareEqual(var__mainmodule_key, '\r'.ToString((IFormatProvider) b4p.cul)) || this.LCompareEqual(var__mainmodule_key, '\n'.ToString((IFormatProvider) b4p.cul)))
          this.__mainmodule_btnokcte_click();
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_tpedcte_keypress");
        return "";
      }
    }

    private string __mainmodule_btnbuscarcte_buttondown()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_btnbuscarcte_buttondown");
        return "";
      }
    }

    private string __mainmodule_chenviartodospedidos_click()
    {
      try
      {
        if (this.__mainmodule_chenviartodospedidos.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_cbopedido.Enabled = bool.Parse("false".ToLower(b4p.cul));
        else
          this.__mainmodule_cbopedido.Enabled = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_chenviartodospedidos_click");
        return "";
      }
    }

    private string __mainmodule_chenviartodascompras_click()
    {
      try
      {
        if (this.__mainmodule_chenviartodascompras.Checked.ToString((IFormatProvider) b4p.cul).ToLower(b4p.cul) == "true")
          this.__mainmodule_cbocompra.Enabled = bool.Parse("false".ToLower(b4p.cul));
        else
          this.__mainmodule_cbocompra.Enabled = bool.Parse("true".ToLower(b4p.cul));
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_chenviartodascompras_click");
        return "";
      }
    }

    private string __mainmodule_config_close()
    {
      try
      {
        return "";
      }
      catch (Exception ex)
      {
        this.ShowError(ex, "_mainmodule_config_close");
        return "";
      }
    }

    private void initialize()
    {
      this.htSubs.Add((object) "__mainmodule_config_close", (object) new b4p.del0(this.__mainmodule_config_close));
      this.htSubs.Add((object) "__mainmodule_chenviartodascompras_click", (object) new b4p.del0(this.__mainmodule_chenviartodascompras_click));
      this.htSubs.Add((object) "__mainmodule_chenviartodospedidos_click", (object) new b4p.del0(this.__mainmodule_chenviartodospedidos_click));
      this.htSubs.Add((object) "__mainmodule_btnbuscarcte_buttondown", (object) new b4p.del0(this.__mainmodule_btnbuscarcte_buttondown));
      this.htSubs.Add((object) "__mainmodule_tpedcte_keypress", (object) new b4p.del1(this.__mainmodule_tpedcte_keypress));
      this.htSubs.Add((object) "__mainmodule_btnokcte_click", (object) new b4p.del0(this.__mainmodule_btnokcte_click));
      this.htSubs.Add((object) "__mainmodule_frmclientes_show", (object) new b4p.del0(this.__mainmodule_frmclientes_show));
      this.htSubs.Add((object) "__mainmodule_listcte_click", (object) new b4p.del0(this.__mainmodule_listcte_click));
      this.htSubs.Add((object) "__mainmodule_btncteped2_click", (object) new b4p.del0(this.__mainmodule_btncteped2_click));
      this.htSubs.Add((object) "__mainmodule_btncteped1_click", (object) new b4p.del0(this.__mainmodule_btncteped1_click));
      this.htSubs.Add((object) "__mainmodule_btnbuscarcte_click", (object) new b4p.del0(this.__mainmodule_btnbuscarcte_click));
      this.htSubs.Add((object) "__mainmodule_cmdbuscar_click", (object) new b4p.del0(this.__mainmodule_cmdbuscar_click));
      this.htSubs.Add((object) "__mainmodule_btnsalped_click", (object) new b4p.del0(this.__mainmodule_btnsalped_click));
      this.htSubs.Add((object) "__mainmodule_mnuopcionesped_click", (object) new b4p.del0(this.__mainmodule_mnuopcionesped_click));
      this.htSubs.Add((object) "__mainmodule_mnueliped_click", (object) new b4p.del0(this.__mainmodule_mnueliped_click));
      this.htSubs.Add((object) "__mainmodule_mnureenped_click", (object) new b4p.del0(this.__mainmodule_mnureenped_click));
      this.htSubs.Add((object) "__mainmodule_mnucanped_click", (object) new b4p.del0(this.__mainmodule_mnucanped_click));
      this.htSubs.Add((object) "__mainmodule_tblpedidos_selectionchanged", (object) new b4p.del2(this.__mainmodule_tblpedidos_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_cboclieutils_selectionchanged", (object) new b4p.del2(this.__mainmodule_cboclieutils_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_frmpedidosutils_show", (object) new b4p.del0(this.__mainmodule_frmpedidosutils_show));
      this.htSubs.Add((object) "__mainmodule_btnsalirpedido_click", (object) new b4p.del0(this.__mainmodule_btnsalirpedido_click));
      this.htSubs.Add((object) "__mainmodule_mnupedido_click", (object) new b4p.del0(this.__mainmodule_mnupedido_click));
      this.htSubs.Add((object) "__mainmodule_btngenpedido_click", (object) new b4p.del0(this.__mainmodule_btngenpedido_click));
      this.htSubs.Add((object) "__mainmodule_genpedido_show", (object) new b4p.del0(this.__mainmodule_genpedido_show));
      this.htSubs.Add((object) "__mainmodule_mnunewpedido_click", (object) new b4p.del0(this.__mainmodule_mnunewpedido_click));
      this.htSubs.Add((object) "__mainmodule_btnpedido_click", (object) new b4p.del0(this.__mainmodule_btnpedido_click));
      this.htSubs.Add((object) "__mainmodule_frmtraspasos_show", (object) new b4p.del0(this.__mainmodule_frmtraspasos_show));
      this.htSubs.Add((object) "__mainmodule_frmmenu_show", (object) new b4p.del0(this.__mainmodule_frmmenu_show));
      this.htSubs.Add((object) "__mainmodule_btncrearbase_click", (object) new b4p.del0(this.__mainmodule_btncrearbase_click));
      this.htSubs.Add((object) "__mainmodule_cierrareader", (object) new b4p.del0(this.__mainmodule_cierrareader));
      this.htSubs.Add((object) "__mainmodule_btntopercerrar_click", (object) new b4p.del0(this.__mainmodule_btntopercerrar_click));
      this.htSubs.Add((object) "__mainmodule_btntoper2_click", (object) new b4p.del0(this.__mainmodule_btntoper2_click));
      this.htSubs.Add((object) "__mainmodule_btntoperborrar_click", (object) new b4p.del0(this.__mainmodule_btntoperborrar_click));
      this.htSubs.Add((object) "__mainmodule_tblexisxlinea_selectionchanged", (object) new b4p.del2(this.__mainmodule_tblexisxlinea_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_tbltoper_selectionchanged", (object) new b4p.del2(this.__mainmodule_tbltoper_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_btntoper1_click", (object) new b4p.del0(this.__mainmodule_btntoper1_click));
      this.htSubs.Add((object) "__mainmodule_btnareaserie2_click", (object) new b4p.del0(this.__mainmodule_btnareaserie2_click));
      this.htSubs.Add((object) "__mainmodule_btnareaserie1_click", (object) new b4p.del0(this.__mainmodule_btnareaserie1_click));
      this.htSubs.Add((object) "__mainmodule_mnuborrarareas_click", (object) new b4p.del0(this.__mainmodule_mnuborrarareas_click));
      this.htSubs.Add((object) "__mainmodule_mnuareas1_click", (object) new b4p.del0(this.__mainmodule_mnuareas1_click));
      this.htSubs.Add((object) "__mainmodule_mnuareas_click", (object) new b4p.del0(this.__mainmodule_mnuareas_click));
      this.htSubs.Add((object) "__mainmodule_btnarea2_click", (object) new b4p.del0(this.__mainmodule_btnarea2_click));
      this.htSubs.Add((object) "__mainmodule_btnareas_click", (object) new b4p.del0(this.__mainmodule_btnareas_click));
      this.htSubs.Add((object) "__mainmodule_btnareanew_click", (object) new b4p.del0(this.__mainmodule_btnareanew_click));
      this.htSubs.Add((object) "__mainmodule_btnareagrabar_click", (object) new b4p.del0(this.__mainmodule_btnareagrabar_click));
      this.htSubs.Add((object) "__mainmodule_desplegarareas", (object) new b4p.del0(this.__mainmodule_desplegarareas));
      this.htSubs.Add((object) "__mainmodule_btneliminar_click", (object) new b4p.del0(this.__mainmodule_btneliminar_click));
      this.htSubs.Add((object) "__mainmodule_tblareas_selectionchanged", (object) new b4p.del2(this.__mainmodule_tblareas_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_frmareas_show", (object) new b4p.del0(this.__mainmodule_frmareas_show));
      this.htSubs.Add((object) "__mainmodule_bk_txt", (object) new b4p.del0(this.__mainmodule_bk_txt));
      this.htSubs.Add((object) "__mainmodule_mnuexxlinea_click", (object) new b4p.del0(this.__mainmodule_mnuexxlinea_click));
      this.htSubs.Add((object) "__mainmodule_mnuexisxlinea_click", (object) new b4p.del0(this.__mainmodule_mnuexisxlinea_click));
      this.htSubs.Add((object) "__mainmodule_frmexistxlinea_show", (object) new b4p.del0(this.__mainmodule_frmexistxlinea_show));
      this.htSubs.Add((object) "__mainmodule_btncompactar_click", (object) new b4p.del0(this.__mainmodule_btncompactar_click));
      this.htSubs.Add((object) "__mainmodule_procminve_close", (object) new b4p.del0(this.__mainmodule_procminve_close));
      this.htSubs.Add((object) "__mainmodule_frmmenu_close", (object) new b4p.del0(this.__mainmodule_frmmenu_close));
      this.htSubs.Add((object) "__mainmodule_gencompra_close", (object) new b4p.del0(this.__mainmodule_gencompra_close));
      this.htSubs.Add((object) "__mainmodule_mnutotalminve_click", (object) new b4p.del0(this.__mainmodule_mnutotalminve_click));
      this.htSubs.Add((object) "__mainmodule_mnutotal_click", (object) new b4p.del0(this.__mainmodule_mnutotal_click));
      this.htSubs.Add((object) "__mainmodule_btngenerar_keypress", (object) new b4p.del1(this.__mainmodule_btngenerar_keypress));
      this.htSubs.Add((object) "__mainmodule_mnuenviarsql_click", (object) new b4p.del0(this.__mainmodule_mnuenviarsql_click));
      this.htSubs.Add((object) "__mainmodule_mnuconsec_click", (object) new b4p.del0(this.__mainmodule_mnuconsec_click));
      this.htSubs.Add((object) "__mainmodule_opminve2_click", (object) new b4p.del0(this.__mainmodule_opminve2_click));
      this.htSubs.Add((object) "__mainmodule_opminve1_click", (object) new b4p.del0(this.__mainmodule_opminve1_click));
      this.htSubs.Add((object) "__mainmodule_opminve3_click", (object) new b4p.del0(this.__mainmodule_opminve3_click));
      this.htSubs.Add((object) "__mainmodule_mnuajustar_click", (object) new b4p.del0(this.__mainmodule_mnuajustar_click));
      this.htSubs.Add((object) "__mainmodule_mnuactualizar_click", (object) new b4p.del0(this.__mainmodule_mnuactualizar_click));
      this.htSubs.Add((object) "__mainmodule_mnuacumulativo_click", (object) new b4p.del0(this.__mainmodule_mnuacumulativo_click));
      this.htSubs.Add((object) "__mainmodule_btnred_click", (object) new b4p.del0(this.__mainmodule_btnred_click));
      this.htSubs.Add((object) "__mainmodule_cmdinv_keypress", (object) new b4p.del1(this.__mainmodule_cmdinv_keypress));
      this.htSubs.Add((object) "__mainmodule_btntea_click", (object) new b4p.del0(this.__mainmodule_btntea_click));
      this.htSubs.Add((object) "__mainmodule_btntraspasos_click", (object) new b4p.del0(this.__mainmodule_btntraspasos_click));
      this.htSubs.Add((object) "__mainmodule_cmdimport1_click", (object) new b4p.del0(this.__mainmodule_cmdimport1_click));
      this.htSubs.Add((object) "__mainmodule_frmcomprasutils_close", (object) new b4p.del0(this.__mainmodule_frmcomprasutils_close));
      this.htSubs.Add((object) "__mainmodule_tblcompras_selectionchanged", (object) new b4p.del2(this.__mainmodule_tblcompras_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_mnucancelarpartidacompra_click", (object) new b4p.del0(this.__mainmodule_mnucancelarpartidacompra_click));
      this.htSubs.Add((object) "__mainmodule_tbcaninven_selectionchanged", (object) new b4p.del2(this.__mainmodule_tbcaninven_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_mnuminve1_click", (object) new b4p.del0(this.__mainmodule_mnuminve1_click));
      this.htSubs.Add((object) "__mainmodule_btnlogin1_click", (object) new b4p.del0(this.__mainmodule_btnlogin1_click));
      this.htSubs.Add((object) "__mainmodule_btnlogin2_click", (object) new b4p.del0(this.__mainmodule_btnlogin2_click));
      this.htSubs.Add((object) "__mainmodule_mnuinvent_click", (object) new b4p.del0(this.__mainmodule_mnuinvent_click));
      this.htSubs.Add((object) "__mainmodule_btnprods_click", (object) new b4p.del0(this.__mainmodule_btnprods_click));
      this.htSubs.Add((object) "__mainmodule_prods_show", (object) new b4p.del0(this.__mainmodule_prods_show));
      this.htSubs.Add((object) "__mainmodule_chmult_click", (object) new b4p.del0(this.__mainmodule_chmult_click));
      this.htSubs.Add((object) "__mainmodule_mnunuevacompra_click", (object) new b4p.del0(this.__mainmodule_mnunuevacompra_click));
      this.htSubs.Add((object) "__mainmodule_cmdinvc_click", (object) new b4p.del0(this.__mainmodule_cmdinvc_click));
      this.htSubs.Add((object) "__mainmodule_mnucancelcompra_click", (object) new b4p.del0(this.__mainmodule_mnucancelcompra_click));
      this.htSubs.Add((object) "__mainmodule_mnureenviarcompra_click", (object) new b4p.del0(this.__mainmodule_mnureenviarcompra_click));
      this.htSubs.Add((object) "__mainmodule_cboprovutils_selectionchanged", (object) new b4p.del2(this.__mainmodule_cboprovutils_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_frmcomprasutils_show", (object) new b4p.del0(this.__mainmodule_frmcomprasutils_show));
      this.htSubs.Add((object) "__mainmodule_mnuutilscompras_click", (object) new b4p.del0(this.__mainmodule_mnuutilscompras_click));
      this.htSubs.Add((object) "__mainmodule_btnmenucompras_click", (object) new b4p.del0(this.__mainmodule_btnmenucompras_click));
      this.htSubs.Add((object) "__mainmodule_btnmenuinvent_click", (object) new b4p.del0(this.__mainmodule_btnmenuinvent_click));
      this.htSubs.Add((object) "__mainmodule_btnmenusalir_click", (object) new b4p.del0(this.__mainmodule_btnmenusalir_click));
      this.htSubs.Add((object) "__mainmodule_frmseries_show", (object) new b4p.del0(this.__mainmodule_frmseries_show));
      this.htSubs.Add((object) "__mainmodule_btnsalirseries_click", (object) new b4p.del0(this.__mainmodule_btnsalirseries_click));
      this.htSubs.Add((object) "__mainmodule_btnseries_click", (object) new b4p.del0(this.__mainmodule_btnseries_click));
      this.htSubs.Add((object) "__mainmodule_frmexistencias_show", (object) new b4p.del0(this.__mainmodule_frmexistencias_show));
      this.htSubs.Add((object) "__mainmodule_btnsalexist_click", (object) new b4p.del0(this.__mainmodule_btnsalexist_click));
      this.htSubs.Add((object) "__mainmodule_mnuexist_click", (object) new b4p.del0(this.__mainmodule_mnuexist_click));
      this.htSubs.Add((object) "__mainmodule_buscaexistencia", (object) new b4p.del0(this.__mainmodule_buscaexistencia));
      this.htSubs.Add((object) "__mainmodule_tprod_keypress", (object) new b4p.del1(this.__mainmodule_tprod_keypress));
      this.htSubs.Add((object) "__mainmodule_mnureenviar_click", (object) new b4p.del0(this.__mainmodule_mnureenviar_click));
      this.htSubs.Add((object) "__mainmodule_gencompra_show", (object) new b4p.del0(this.__mainmodule_gencompra_show));
      this.htSubs.Add((object) "__mainmodule_btngencompra_click", (object) new b4p.del0(this.__mainmodule_btngencompra_click));
      this.htSubs.Add((object) "__mainmodule_btnsalirgencompra_click", (object) new b4p.del0(this.__mainmodule_btnsalirgencompra_click));
      this.htSubs.Add((object) "__mainmodule_mnucompra_click", (object) new b4p.del0(this.__mainmodule_mnucompra_click));
      this.htSubs.Add((object) "__mainmodule_inventario_acumulativo", (object) new b4p.del0(this.__mainmodule_inventario_acumulativo));
      this.htSubs.Add((object) "__mainmodule_inventario_directo", (object) new b4p.del0(this.__mainmodule_inventario_directo));
      this.htSubs.Add((object) "__mainmodule_inventario_acumulativo_proc_almacenado", (object) new b4p.del0(this.__mainmodule_inventario_acumulativo_proc_almacenado));
      this.htSubs.Add((object) "__mainmodule_inventario_directo_proc_almacenado", (object) new b4p.del0(this.__mainmodule_inventario_directo_proc_almacenado));
      this.htSubs.Add((object) "__mainmodule_btngenerar_click", (object) new b4p.del0(this.__mainmodule_btngenerar_click));
      this.htSubs.Add((object) "__mainmodule_procminve_show", (object) new b4p.del0(this.__mainmodule_procminve_show));
      this.htSubs.Add((object) "__mainmodule_btnexistminve_click", (object) new b4p.del0(this.__mainmodule_btnexistminve_click));
      this.htSubs.Add((object) "__mainmodule_validacampo", (object) new b4p.del2(this.__mainmodule_validacampo));
      this.htSubs.Add((object) "__mainmodule_mnuenviarsae_click", (object) new b4p.del0(this.__mainmodule_mnuenviarsae_click));
      this.htSubs.Add((object) "__mainmodule_enviaraunapc", (object) new b4p.del1(this.__mainmodule_enviaraunapc));
      this.htSubs.Add((object) "__mainmodule_invent_close", (object) new b4p.del0(this.__mainmodule_invent_close));
      this.htSubs.Add((object) "__mainmodule_mnusql4_click", (object) new b4p.del0(this.__mainmodule_mnusql4_click));
      this.htSubs.Add((object) "__mainmodule_mnusql3_click", (object) new b4p.del0(this.__mainmodule_mnusql3_click));
      this.htSubs.Add((object) "__mainmodule_mnusql2_click", (object) new b4p.del0(this.__mainmodule_mnusql2_click));
      this.htSubs.Add((object) "__mainmodule_chcaja_click", (object) new b4p.del0(this.__mainmodule_chcaja_click));
      this.htSubs.Add((object) "__mainmodule_btnenviarinven_click", (object) new b4p.del0(this.__mainmodule_btnenviarinven_click));
      this.htSubs.Add((object) "__mainmodule_enviar_close", (object) new b4p.del0(this.__mainmodule_enviar_close));
      this.htSubs.Add((object) "__mainmodule_menfin_click", (object) new b4p.del0(this.__mainmodule_menfin_click));
      this.htSubs.Add((object) "__mainmodule_mnusalircan_click", (object) new b4p.del0(this.__mainmodule_mnusalircan_click));
      this.htSubs.Add((object) "__mainmodule_btnnew_click", (object) new b4p.del0(this.__mainmodule_btnnew_click));
      this.htSubs.Add((object) "__mainmodule_tarticulo_gotfocus", (object) new b4p.del0(this.__mainmodule_tarticulo_gotfocus));
      this.htSubs.Add((object) "__mainmodule_btnutils_click", (object) new b4p.del0(this.__mainmodule_btnutils_click));
      this.htSubs.Add((object) "__mainmodule_btnusr3_click", (object) new b4p.del0(this.__mainmodule_btnusr3_click));
      this.htSubs.Add((object) "__mainmodule_tclave_gotfocus", (object) new b4p.del0(this.__mainmodule_tclave_gotfocus));
      this.htSubs.Add((object) "__mainmodule_tnombre_gotfocus", (object) new b4p.del0(this.__mainmodule_tnombre_gotfocus));
      this.htSubs.Add((object) "__mainmodule_tusu_gotfocus", (object) new b4p.del0(this.__mainmodule_tusu_gotfocus));
      this.htSubs.Add((object) "__mainmodule_btnusr2_click", (object) new b4p.del0(this.__mainmodule_btnusr2_click));
      this.htSubs.Add((object) "__mainmodule_btnuser_click", (object) new b4p.del0(this.__mainmodule_btnuser_click));
      this.htSubs.Add((object) "__mainmodule_tlinea_keypress", (object) new b4p.del1(this.__mainmodule_tlinea_keypress));
      this.htSubs.Add((object) "__mainmodule_cierracontrans", (object) new b4p.del0(this.__mainmodule_cierracontrans));
      this.htSubs.Add((object) "__mainmodule_cierramsql", (object) new b4p.del0(this.__mainmodule_cierramsql));
      this.htSubs.Add((object) "__mainmodule_cboempresa_selectionchanged", (object) new b4p.del2(this.__mainmodule_cboempresa_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_tbluser_selectionchanged", (object) new b4p.del2(this.__mainmodule_tbluser_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_btnsql3_click", (object) new b4p.del0(this.__mainmodule_btnsql3_click));
      this.htSubs.Add((object) "__mainmodule_btnaceptar_click", (object) new b4p.del0(this.__mainmodule_btnaceptar_click));
      this.htSubs.Add((object) "__mainmodule_btnusr1_click", (object) new b4p.del0(this.__mainmodule_btnusr1_click));
      this.htSubs.Add((object) "__mainmodule_usuarios_show", (object) new b4p.del0(this.__mainmodule_usuarios_show));
      this.htSubs.Add((object) "__mainmodule_image1_click", (object) new b4p.del0(this.__mainmodule_image1_click));
      this.htSubs.Add((object) "__mainmodule_invencan_close", (object) new b4p.del0(this.__mainmodule_invencan_close));
      this.htSubs.Add((object) "__mainmodule_cboimporta_selectionchanged", (object) new b4p.del2(this.__mainmodule_cboimporta_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_cboempresa1_selectionchanged", (object) new b4p.del2(this.__mainmodule_cboempresa1_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_btnsql2_click", (object) new b4p.del0(this.__mainmodule_btnsql2_click));
      this.htSubs.Add((object) "__mainmodule_btnsql_click", (object) new b4p.del0(this.__mainmodule_btnsql_click));
      this.htSubs.Add((object) "__mainmodule_btnsql1_click", (object) new b4p.del0(this.__mainmodule_btnsql1_click));
      this.htSubs.Add((object) "__mainmodule_sqlserver_show", (object) new b4p.del0(this.__mainmodule_sqlserver_show));
      this.htSubs.Add((object) "__mainmodule_invencan_show", (object) new b4p.del0(this.__mainmodule_invencan_show));
      this.htSubs.Add((object) "__mainmodule_bcodigo", (object) new b4p.del0(this.__mainmodule_bcodigo));
      this.htSubs.Add((object) "__mainmodule_tcodigo_keypress", (object) new b4p.del1(this.__mainmodule_tcodigo_keypress));
      this.htSubs.Add((object) "__mainmodule_mnucan1_click", (object) new b4p.del0(this.__mainmodule_mnucan1_click));
      this.htSubs.Add((object) "__mainmodule_cmdinvensalir_click", (object) new b4p.del0(this.__mainmodule_cmdinvensalir_click));
      this.htSubs.Add((object) "__mainmodule_mencan_click", (object) new b4p.del0(this.__mainmodule_mencan_click));
      this.htSubs.Add((object) "__mainmodule_tuni_gotfocus", (object) new b4p.del0(this.__mainmodule_tuni_gotfocus));
      this.htSubs.Add((object) "__mainmodule_tuni_keypress", (object) new b4p.del1(this.__mainmodule_tuni_keypress));
      this.htSubs.Add((object) "__mainmodule_main_show", (object) new b4p.del0(this.__mainmodule_main_show));
      this.htSubs.Add((object) "__mainmodule_menmov_click", (object) new b4p.del0(this.__mainmodule_menmov_click));
      this.htSubs.Add((object) "__mainmodule_copiaarchivos2", (object) new b4p.del0(this.__mainmodule_copiaarchivos2));
      this.htSubs.Add((object) "__mainmodule_copiaarchivos", (object) new b4p.del0(this.__mainmodule_copiaarchivos));
      this.htSubs.Add((object) "__mainmodule_vacu", (object) new b4p.del0(this.__mainmodule_vacu));
      this.htSubs.Add((object) "__mainmodule_cmdvaciarinvent_click", (object) new b4p.del0(this.__mainmodule_cmdvaciarinvent_click));
      this.htSubs.Add((object) "__mainmodule_mnurest_click", (object) new b4p.del0(this.__mainmodule_mnurest_click));
      this.htSubs.Add((object) "__mainmodule_importararticulosupdateexist", (object) new b4p.del0(this.__mainmodule_importararticulosupdateexist));
      this.htSubs.Add((object) "__mainmodule_importararticulos", (object) new b4p.del0(this.__mainmodule_importararticulos));
      this.htSubs.Add((object) "__mainmodule_tarticulo_keypress", (object) new b4p.del1(this.__mainmodule_tarticulo_keypress));
      this.htSubs.Add((object) "__mainmodule_invent_show", (object) new b4p.del0(this.__mainmodule_invent_show));
      this.htSubs.Add((object) "__mainmodule_mensend_click", (object) new b4p.del0(this.__mainmodule_mensend_click));
      this.htSubs.Add((object) "__mainmodule_cmdinv_click", (object) new b4p.del0(this.__mainmodule_cmdinv_click));
      this.htSubs.Add((object) "__mainmodule_button12_click", (object) new b4p.del0(this.__mainmodule_button12_click));
      this.htSubs.Add((object) "__mainmodule_btnmain5_click", (object) new b4p.del0(this.__mainmodule_btnmain5_click));
      this.htSubs.Add((object) "__mainmodule_main_close", (object) new b4p.del0(this.__mainmodule_main_close));
      this.htSubs.Add((object) "__mainmodule_btnmain8_click", (object) new b4p.del0(this.__mainmodule_btnmain8_click));
      this.htSubs.Add((object) "__mainmodule_cmdborrar_click", (object) new b4p.del0(this.__mainmodule_cmdborrar_click));
      this.htSubs.Add((object) "__mainmodule_fgprod_selectionchanged", (object) new b4p.del2(this.__mainmodule_fgprod_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_cmdsend2_click", (object) new b4p.del0(this.__mainmodule_cmdsend2_click));
      this.htSubs.Add((object) "__mainmodule_enviar_show", (object) new b4p.del0(this.__mainmodule_enviar_show));
      this.htSubs.Add((object) "__mainmodule_cmdsend1_click", (object) new b4p.del0(this.__mainmodule_cmdsend1_click));
      this.htSubs.Add((object) "__mainmodule_cmdrutapcc_click", (object) new b4p.del0(this.__mainmodule_cmdrutapcc_click));
      this.htSubs.Add((object) "__mainmodule_config_show", (object) new b4p.del0(this.__mainmodule_config_show));
      this.htSubs.Add((object) "__mainmodule_centra", (object) new b4p.del1(this.__mainmodule_centra));
      this.htSubs.Add((object) "__mainmodule_mnuenviar_click", (object) new b4p.del0(this.__mainmodule_mnuenviar_click));
      this.htSubs.Add((object) "__mainmodule_partinven_close", (object) new b4p.del0(this.__mainmodule_partinven_close));
      this.htSubs.Add((object) "__mainmodule_tblprod_selectionchanged", (object) new b4p.del2(this.__mainmodule_tblprod_selectionchanged));
      this.htSubs.Add((object) "__mainmodule_timer1_tick", (object) new b4p.del0(this.__mainmodule_timer1_tick));
      this.htSubs.Add((object) "__mainmodule_addfield", (object) new b4p.del0(this.__mainmodule_addfield));
      this.htSubs.Add((object) "__mainmodule_creatablaarea", (object) new b4p.del0(this.__mainmodule_creatablaarea));
      this.htSubs.Add((object) "__mainmodule_app_start", (object) new b4p.del0(this.__mainmodule_app_start));
      this.htSubs.Add((object) "__utilerias_partinven_show", (object) new b4p.del0(this.__utilerias_partinven_show));
      this.htSubs.Add((object) "__utilerias_tcant_keypress", (object) new b4p.del1(this.__utilerias_tcant_keypress));
      this.htSubs.Add((object) "__utilerias_mnucantea_click", (object) new b4p.del0(this.__utilerias_mnucantea_click));
      this.htSubs.Add((object) "__utilerias_cbotiendadestino_selectionchanged", (object) new b4p.del2(this.__utilerias_cbotiendadestino_selectionchanged));
      this.htSubs.Add((object) "__utilerias_cbocanfolio_selectionchanged", (object) new b4p.del2(this.__utilerias_cbocanfolio_selectionchanged));
      this.htSubs.Add((object) "__utilerias_btntrans_click", (object) new b4p.del0(this.__utilerias_btntrans_click));
      this.htSubs.Add((object) "__utilerias_cmdaceptar_keypress", (object) new b4p.del1(this.__utilerias_cmdaceptar_keypress));
      this.htSubs.Add((object) "__utilerias_cbofol_selectionchanged", (object) new b4p.del2(this.__utilerias_cbofol_selectionchanged));
      this.htSubs.Add((object) "__utilerias_bart", (object) new b4p.del0(this.__utilerias_bart));
      this.htSubs.Add((object) "__utilerias_loadmovsinv", (object) new b4p.del0(this.__utilerias_loadmovsinv));
      this.htSubs.Add((object) "__utilerias_cbotiendaorigen_selectionchanged", (object) new b4p.del2(this.__utilerias_cbotiendaorigen_selectionchanged));
      this.htSubs.Add((object) "__utilerias_importa_show", (object) new b4p.del0(this.__utilerias_importa_show));
      this.htSubs.Add((object) "__utilerias_cmdimpor2_click", (object) new b4p.del0(this.__utilerias_cmdimpor2_click));
      this.htSubs.Add((object) "__utilerias_cmdimpor1_click", (object) new b4p.del0(this.__utilerias_cmdimpor1_click));
      this.htSubs.Add((object) "__utilerias_cmdsend2_click", (object) new b4p.del0(this.__utilerias_cmdsend2_click));
      this.htSubs.Add((object) "__utilerias_cmdsend1_click", (object) new b4p.del0(this.__utilerias_cmdsend1_click));
      this.htSubs.Add((object) "__utilerias_enviar_show", (object) new b4p.del0(this.__utilerias_enviar_show));
      this.htSubs.Add((object) "__utilerias_cmdcanc2_click", (object) new b4p.del0(this.__utilerias_cmdcanc2_click));
      this.htSubs.Add((object) "__utilerias_cmdcanc1_click", (object) new b4p.del0(this.__utilerias_cmdcanc1_click));
      this.htSubs.Add((object) "__utilerias_cmdcbus_click", (object) new b4p.del0(this.__utilerias_cmdcbus_click));
      this.htSubs.Add((object) "__utilerias_tart_keypress", (object) new b4p.del1(this.__utilerias_tart_keypress));
      this.htSubs.Add((object) "__utilerias_canc_close", (object) new b4p.del0(this.__utilerias_canc_close));
      this.htSubs.Add((object) "__utilerias_canc_show", (object) new b4p.del0(this.__utilerias_canc_show));
      this.htSubs.Add((object) "__utilerias_mnucanfolio_click", (object) new b4p.del0(this.__utilerias_mnucanfolio_click));
      this.htSubs.Add((object) "__utilerias_mnucanc_click", (object) new b4p.del0(this.__utilerias_mnucanc_click));
      this.htSubs.Add((object) "__utilerias_mnufin_click", (object) new b4p.del0(this.__utilerias_mnufin_click));
      this.htSubs.Add((object) "__utilerias_mnuenviar_click", (object) new b4p.del0(this.__utilerias_mnuenviar_click));
      this.htSubs.Add((object) "__utilerias_mnumov_click", (object) new b4p.del0(this.__utilerias_mnumov_click));
      this.htSubs.Add((object) "__utilerias_btncanfol2_click", (object) new b4p.del0(this.__utilerias_btncanfol2_click));
      this.htSubs.Add((object) "__utilerias_btncanfolio1_click", (object) new b4p.del0(this.__utilerias_btncanfolio1_click));
      this.htSubs.Add((object) "__utilerias_inven_show", (object) new b4p.del0(this.__utilerias_inven_show));
      this.htSubs.Add((object) "__utilerias_tprod_keypress", (object) new b4p.del1(this.__utilerias_tprod_keypress));
      this.htSubs.Add((object) "__utilerias_closeconexionsqlite", (object) new b4p.del0(this.__utilerias_closeconexionsqlite));
      this.htSubs.Add((object) "__utilerias_cmdaceptar_click", (object) new b4p.del0(this.__utilerias_cmdaceptar_click));
      this.htSubs.Add((object) "__utilerias_btntea_click", (object) new b4p.del0(this.__utilerias_btntea_click));
      this.htSubs.Add((object) "__utilerias_btntea2_click", (object) new b4p.del0(this.__utilerias_btntea2_click));
      this.htSubs.Add((object) "__utilerias_frmtea_show", (object) new b4p.del0(this.__utilerias_frmtea_show));
      this.screenX = 240;
      this.screenY = 268;
      this.icon = "INVEN1.ico";
      this.__utilerias_canc = new CEnhancedForm(this);
      this.__utilerias_canc.name = "__utilerias_canc";
      this.__utilerias_canc.Text = "Cancelaciones";
      this.__utilerias_canc.BackColor = Color.FromArgb(-1389077);
      this.__utilerias_canc.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_canc.BackColor), 0, 0, this.__utilerias_canc.Width, this.__utilerias_canc.Height);
      this.__utilerias_canc.AddEvents();
      this.htControls.Add((object) "__utilerias_canc", (object) this.__utilerias_canc);
      this.__utilerias_cmdcbus = new CEnhancedButton(this);
      this.__utilerias_cmdcbus.name = "__utilerias_cmdcbus";
      this.__utilerias_cmdcbus.Left = 201;
      this.__utilerias_cmdcbus.Top = 6;
      this.__utilerias_cmdcbus.Width = 36;
      this.__utilerias_cmdcbus.Height = 21;
      this.__utilerias_cmdcbus.Text = "......";
      this.__utilerias_cmdcbus.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdcbus.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdcbus.Enabled = true;
      this.__utilerias_cmdcbus.Visible = true;
      this.__utilerias_cmdcbus.Font = new Font(this.__utilerias_cmdcbus.Font.Name, 11f, this.__utilerias_cmdcbus.Font.Style);
      this.__utilerias_cmdcbus.AddEvents();
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_cmdcbus);
      this.htControls.Add((object) "__utilerias_cmdcbus", (object) this.__utilerias_cmdcbus);
      this.__utilerias_cmdcanc2 = new CEnhancedButton(this);
      this.__utilerias_cmdcanc2.name = "__utilerias_cmdcanc2";
      this.__utilerias_cmdcanc2.Left = 161;
      this.__utilerias_cmdcanc2.Top = 240;
      this.__utilerias_cmdcanc2.Width = 62;
      this.__utilerias_cmdcanc2.Height = 26;
      this.__utilerias_cmdcanc2.Text = "Salir";
      this.__utilerias_cmdcanc2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdcanc2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdcanc2.Enabled = true;
      this.__utilerias_cmdcanc2.Visible = true;
      this.__utilerias_cmdcanc2.Font = new Font(this.__utilerias_cmdcanc2.Font.Name, 9f, this.__utilerias_cmdcanc2.Font.Style);
      this.__utilerias_cmdcanc2.AddEvents();
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_cmdcanc2);
      this.htControls.Add((object) "__utilerias_cmdcanc2", (object) this.__utilerias_cmdcanc2);
      this.__utilerias_tart = new CEnhancedTextBox(this);
      this.__utilerias_tart.name = "__utilerias_tart";
      this.__utilerias_tart.Left = 52;
      this.__utilerias_tart.Top = 7;
      this.__utilerias_tart.Width = 147;
      this.__utilerias_tart.Text = "";
      this.__utilerias_tart.BackColor = Color.FromArgb(-1);
      this.__utilerias_tart.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tart.Enabled = true;
      this.__utilerias_tart.Visible = true;
      this.__utilerias_tart.Height = 22;
      this.__utilerias_tart.Font = new Font(this.__utilerias_tart.Font.Name, 9f, this.__utilerias_tart.Font.Style);
      this.__utilerias_tart.multiline = false;
      this.__utilerias_tart.AddEvents();
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_tart);
      this.htControls.Add((object) "__utilerias_tart", (object) this.__utilerias_tart);
      this.__utilerias_ltcodigo = new CEnhancedLabel(this);
      this.__utilerias_ltcodigo.name = "__utilerias_ltcodigo";
      this.__utilerias_ltcodigo.Left = 5;
      this.__utilerias_ltcodigo.Top = 10;
      this.__utilerias_ltcodigo.Width = 50;
      this.__utilerias_ltcodigo.Height = 18;
      this.__utilerias_ltcodigo.Text = "Articulo";
      this.__utilerias_ltcodigo.BackColor = Color.FromArgb(-1389077);
      this.__utilerias_ltcodigo.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltcodigo.MyEnabled = true;
      this.__utilerias_ltcodigo.Visible = true;
      this.__utilerias_ltcodigo.Transparent = false;
      this.__utilerias_ltcodigo.Font = new Font(this.__utilerias_ltcodigo.Font.Name, 9f, this.__utilerias_ltcodigo.Font.Style);
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_ltcodigo);
      this.htControls.Add((object) "__utilerias_ltcodigo", (object) this.__utilerias_ltcodigo);
      this.__utilerias_cmdcanc1 = new CEnhancedButton(this);
      this.__utilerias_cmdcanc1.name = "__utilerias_cmdcanc1";
      this.__utilerias_cmdcanc1.Left = 8;
      this.__utilerias_cmdcanc1.Top = 240;
      this.__utilerias_cmdcanc1.Width = 120;
      this.__utilerias_cmdcanc1.Height = 26;
      this.__utilerias_cmdcanc1.Text = "Cancelar partida";
      this.__utilerias_cmdcanc1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdcanc1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdcanc1.Enabled = true;
      this.__utilerias_cmdcanc1.Visible = true;
      this.__utilerias_cmdcanc1.Font = new Font(this.__utilerias_cmdcanc1.Font.Name, 9f, this.__utilerias_cmdcanc1.Font.Style);
      this.__utilerias_cmdcanc1.AddEvents();
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_cmdcanc1);
      this.htControls.Add((object) "__utilerias_cmdcanc1", (object) this.__utilerias_cmdcanc1);
      this.__utilerias_tblcanc = new CEnhancedTable(this, "__utilerias_tblcanc");
      this.__utilerias_tblcanc.name = "__utilerias_tblcanc";
      this.__utilerias_tblcanc.Left = 0;
      this.__utilerias_tblcanc.Top = 35;
      this.__utilerias_tblcanc.Width = 240;
      this.__utilerias_tblcanc.Height = 150;
      this.__utilerias_tblcanc.Text = "";
      this.__utilerias_tblcanc.propColor = Color.FromArgb(-657931);
      this.__utilerias_tblcanc.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tblcanc.Enabled = true;
      this.__utilerias_tblcanc.Visible = true;
      this.__utilerias_tblcanc.Font = new Font(this.__utilerias_tblcanc.Font.Name, 9f, this.__utilerias_tblcanc.Font.Style);
      this.__utilerias_tblcanc.AddEvents();
      this.__utilerias_canc.Controls.Add((Control) this.__utilerias_tblcanc);
      this.htControls.Add((object) "__utilerias_tblcanc", (object) this.__utilerias_tblcanc);
      this.__utilerias_mnucantea = new CEnhancedMenu(this);
      this.__utilerias_mnucantea.name = "__utilerias_mnucantea";
      this.__utilerias_mnucantea.Text = "Cancelar partida";
      this.__utilerias_mnucantea.Enabled = true;
      this.__utilerias_mnucantea.Checked = false;
      this.__utilerias_mnucantea.AddToObject("__utilerias_canc");
      this.__utilerias_mnucantea.AddEvents();
      this.htControls.Add((object) "__utilerias_mnucantea", (object) this.__utilerias_mnucantea);
      this.__utilerias_partinven = new CEnhancedForm(this);
      this.__utilerias_partinven.name = "__utilerias_partinven";
      this.__utilerias_partinven.Text = "Relacion de partidas";
      this.__utilerias_partinven.BackColor = Color.FromArgb(-66313);
      this.__utilerias_partinven.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_partinven.BackColor), 0, 0, this.__utilerias_partinven.Width, this.__utilerias_partinven.Height);
      this.__utilerias_partinven.AddEvents();
      this.htControls.Add((object) "__utilerias_partinven", (object) this.__utilerias_partinven);
      this.__utilerias_cbomovfol = new CEnhancedCombo(this);
      this.__utilerias_cbomovfol.name = "__utilerias_cbomovfol";
      this.__utilerias_cbomovfol.Left = 80;
      this.__utilerias_cbomovfol.Top = 4;
      this.__utilerias_cbomovfol.Width = 78;
      this.__utilerias_cbomovfol.Height = 22;
      this.__utilerias_cbomovfol.Text = "";
      this.__utilerias_cbomovfol.BackColor = Color.FromArgb(-1);
      this.__utilerias_cbomovfol.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cbomovfol.Enabled = true;
      this.__utilerias_cbomovfol.Visible = false;
      this.__utilerias_cbomovfol.Font = new Font(this.__utilerias_cbomovfol.Font.Name, 9f, this.__utilerias_cbomovfol.Font.Style);
      this.__utilerias_partinven.Controls.Add((Control) this.__utilerias_cbomovfol);
      this.htControls.Add((object) "__utilerias_cbomovfol", (object) this.__utilerias_cbomovfol);
      this.__utilerias_cbomovfol.AddEvents();
      this.__utilerias_fgprod = new CEnhancedTable(this, "__utilerias_fgprod");
      this.__utilerias_fgprod.name = "__utilerias_fgprod";
      this.__utilerias_fgprod.Left = 0;
      this.__utilerias_fgprod.Top = 30;
      this.__utilerias_fgprod.Width = 240;
      this.__utilerias_fgprod.Height = 234;
      this.__utilerias_fgprod.Text = "";
      this.__utilerias_fgprod.propColor = Color.FromArgb(-657931);
      this.__utilerias_fgprod.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_fgprod.Enabled = true;
      this.__utilerias_fgprod.Visible = true;
      this.__utilerias_fgprod.Font = new Font(this.__utilerias_fgprod.Font.Name, 8f, this.__utilerias_fgprod.Font.Style);
      this.__utilerias_fgprod.AddEvents();
      this.__utilerias_partinven.Controls.Add((Control) this.__utilerias_fgprod);
      this.htControls.Add((object) "__utilerias_fgprod", (object) this.__utilerias_fgprod);
      this.__utilerias_mnurelpar = new CEnhancedMenu(this);
      this.__utilerias_mnurelpar.name = "__utilerias_mnurelpar";
      this.__utilerias_mnurelpar.Text = "Archivo";
      this.__utilerias_mnurelpar.Enabled = true;
      this.__utilerias_mnurelpar.Checked = false;
      this.__utilerias_mnurelpar.AddToObject("__utilerias_partinven");
      this.__utilerias_mnurelpar.AddEvents();
      this.htControls.Add((object) "__utilerias_mnurelpar", (object) this.__utilerias_mnurelpar);
      this.__utilerias_mnutodos = new CEnhancedMenu(this);
      this.__utilerias_mnutodos.name = "__utilerias_mnutodos";
      this.__utilerias_mnutodos.Text = "Todas";
      this.__utilerias_mnutodos.Enabled = true;
      this.__utilerias_mnutodos.Checked = false;
      this.__utilerias_mnutodos.AddToObject("__utilerias_mnurelpar");
      this.__utilerias_mnutodos.AddEvents();
      this.htControls.Add((object) "__utilerias_mnutodos", (object) this.__utilerias_mnutodos);
      this.__utilerias_mnuxfol = new CEnhancedMenu(this);
      this.__utilerias_mnuxfol.name = "__utilerias_mnuxfol";
      this.__utilerias_mnuxfol.Text = "Folio";
      this.__utilerias_mnuxfol.Enabled = true;
      this.__utilerias_mnuxfol.Checked = false;
      this.__utilerias_mnuxfol.AddToObject("__utilerias_mnurelpar");
      this.__utilerias_mnuxfol.AddEvents();
      this.htControls.Add((object) "__utilerias_mnuxfol", (object) this.__utilerias_mnuxfol);
      this.__utilerias_mnueliminar = new CEnhancedMenu(this);
      this.__utilerias_mnueliminar.name = "__utilerias_mnueliminar";
      this.__utilerias_mnueliminar.Text = "Eliminar";
      this.__utilerias_mnueliminar.Enabled = true;
      this.__utilerias_mnueliminar.Checked = false;
      this.__utilerias_mnueliminar.AddToObject("__utilerias_mnurelpar");
      this.__utilerias_mnueliminar.AddEvents();
      this.htControls.Add((object) "__utilerias_mnueliminar", (object) this.__utilerias_mnueliminar);
      this.__utilerias_frmtea = new CEnhancedForm(this);
      this.__utilerias_frmtea.name = "__utilerias_frmtea";
      this.__utilerias_frmtea.Text = "Conexion TEA";
      this.__utilerias_frmtea.BackColor = Color.FromArgb(-66313);
      this.__utilerias_frmtea.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_frmtea.BackColor), 0, 0, this.__utilerias_frmtea.Width, this.__utilerias_frmtea.Height);
      this.__utilerias_frmtea.AddEvents();
      this.htControls.Add((object) "__utilerias_frmtea", (object) this.__utilerias_frmtea);
      this.__utilerias_tfolio = new CEnhancedTextBox(this);
      this.__utilerias_tfolio.name = "__utilerias_tfolio";
      this.__utilerias_tfolio.Left = 165;
      this.__utilerias_tfolio.Top = 105;
      this.__utilerias_tfolio.Width = 70;
      this.__utilerias_tfolio.Text = "";
      this.__utilerias_tfolio.BackColor = Color.FromArgb(-1);
      this.__utilerias_tfolio.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tfolio.Enabled = true;
      this.__utilerias_tfolio.Visible = true;
      this.__utilerias_tfolio.Height = 22;
      this.__utilerias_tfolio.Font = new Font(this.__utilerias_tfolio.Font.Name, 9f, this.__utilerias_tfolio.Font.Style);
      this.__utilerias_tfolio.multiline = false;
      this.__utilerias_tfolio.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tfolio);
      this.htControls.Add((object) "__utilerias_tfolio", (object) this.__utilerias_tfolio);
      this.__utilerias_label10 = new CEnhancedLabel(this);
      this.__utilerias_label10.name = "__utilerias_label10";
      this.__utilerias_label10.Left = 135;
      this.__utilerias_label10.Top = 105;
      this.__utilerias_label10.Width = 35;
      this.__utilerias_label10.Height = 20;
      this.__utilerias_label10.Text = "Folio";
      this.__utilerias_label10.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label10.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label10.MyEnabled = true;
      this.__utilerias_label10.Visible = true;
      this.__utilerias_label10.Transparent = false;
      this.__utilerias_label10.Font = new Font(this.__utilerias_label10.Font.Name, 9f, this.__utilerias_label10.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label10);
      this.htControls.Add((object) "__utilerias_label10", (object) this.__utilerias_label10);
      this.__utilerias_btntea2 = new CEnhancedButton(this);
      this.__utilerias_btntea2.name = "__utilerias_btntea2";
      this.__utilerias_btntea2.Left = 126;
      this.__utilerias_btntea2.Top = 145;
      this.__utilerias_btntea2.Width = 80;
      this.__utilerias_btntea2.Height = 31;
      this.__utilerias_btntea2.Text = "Cancelar";
      this.__utilerias_btntea2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btntea2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btntea2.Enabled = true;
      this.__utilerias_btntea2.Visible = true;
      this.__utilerias_btntea2.Font = new Font(this.__utilerias_btntea2.Font.Name, 9f, this.__utilerias_btntea2.Font.Style);
      this.__utilerias_btntea2.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_btntea2);
      this.htControls.Add((object) "__utilerias_btntea2", (object) this.__utilerias_btntea2);
      this.__utilerias_btntea = new CEnhancedButton(this);
      this.__utilerias_btntea.name = "__utilerias_btntea";
      this.__utilerias_btntea.Left = 24;
      this.__utilerias_btntea.Top = 145;
      this.__utilerias_btntea.Width = 80;
      this.__utilerias_btntea.Height = 31;
      this.__utilerias_btntea.Text = "Aceptar";
      this.__utilerias_btntea.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btntea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btntea.Enabled = true;
      this.__utilerias_btntea.Visible = true;
      this.__utilerias_btntea.Font = new Font(this.__utilerias_btntea.Font.Name, 9f, this.__utilerias_btntea.Font.Style);
      this.__utilerias_btntea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_btntea);
      this.htControls.Add((object) "__utilerias_btntea", (object) this.__utilerias_btntea);
      this.__utilerias_tporttea = new CEnhancedTextBox(this);
      this.__utilerias_tporttea.name = "__utilerias_tporttea";
      this.__utilerias_tporttea.Left = 56;
      this.__utilerias_tporttea.Top = 105;
      this.__utilerias_tporttea.Width = 61;
      this.__utilerias_tporttea.Text = "";
      this.__utilerias_tporttea.BackColor = Color.FromArgb(-1);
      this.__utilerias_tporttea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tporttea.Enabled = true;
      this.__utilerias_tporttea.Visible = true;
      this.__utilerias_tporttea.Height = 22;
      this.__utilerias_tporttea.Font = new Font(this.__utilerias_tporttea.Font.Name, 9f, this.__utilerias_tporttea.Font.Style);
      this.__utilerias_tporttea.multiline = false;
      this.__utilerias_tporttea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tporttea);
      this.htControls.Add((object) "__utilerias_tporttea", (object) this.__utilerias_tporttea);
      this.__utilerias_tbasetea = new CEnhancedTextBox(this);
      this.__utilerias_tbasetea.name = "__utilerias_tbasetea";
      this.__utilerias_tbasetea.Left = 56;
      this.__utilerias_tbasetea.Top = 33;
      this.__utilerias_tbasetea.Width = 180;
      this.__utilerias_tbasetea.Text = "";
      this.__utilerias_tbasetea.BackColor = Color.FromArgb(-1);
      this.__utilerias_tbasetea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tbasetea.Enabled = true;
      this.__utilerias_tbasetea.Visible = true;
      this.__utilerias_tbasetea.Height = 22;
      this.__utilerias_tbasetea.Font = new Font(this.__utilerias_tbasetea.Font.Name, 9f, this.__utilerias_tbasetea.Font.Style);
      this.__utilerias_tbasetea.multiline = false;
      this.__utilerias_tbasetea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tbasetea);
      this.htControls.Add((object) "__utilerias_tbasetea", (object) this.__utilerias_tbasetea);
      this.__utilerias_label5 = new CEnhancedLabel(this);
      this.__utilerias_label5.name = "__utilerias_label5";
      this.__utilerias_label5.Left = 3;
      this.__utilerias_label5.Top = 105;
      this.__utilerias_label5.Width = 55;
      this.__utilerias_label5.Height = 25;
      this.__utilerias_label5.Text = "Puerto";
      this.__utilerias_label5.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label5.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label5.MyEnabled = true;
      this.__utilerias_label5.Visible = true;
      this.__utilerias_label5.Transparent = false;
      this.__utilerias_label5.Font = new Font(this.__utilerias_label5.Font.Name, 9f, this.__utilerias_label5.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label5);
      this.htControls.Add((object) "__utilerias_label5", (object) this.__utilerias_label5);
      this.__utilerias_tpasstea = new CEnhancedTextBox(this);
      this.__utilerias_tpasstea.name = "__utilerias_tpasstea";
      this.__utilerias_tpasstea.Left = 56;
      this.__utilerias_tpasstea.Top = 81;
      this.__utilerias_tpasstea.Width = 135;
      this.__utilerias_tpasstea.Text = "";
      this.__utilerias_tpasstea.BackColor = Color.FromArgb(-1);
      this.__utilerias_tpasstea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tpasstea.Enabled = true;
      this.__utilerias_tpasstea.Visible = true;
      this.__utilerias_tpasstea.Height = 22;
      this.__utilerias_tpasstea.Font = new Font(this.__utilerias_tpasstea.Font.Name, 9f, this.__utilerias_tpasstea.Font.Style);
      this.__utilerias_tpasstea.multiline = false;
      this.__utilerias_tpasstea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tpasstea);
      this.htControls.Add((object) "__utilerias_tpasstea", (object) this.__utilerias_tpasstea);
      this.__utilerias_label4 = new CEnhancedLabel(this);
      this.__utilerias_label4.name = "__utilerias_label4";
      this.__utilerias_label4.Left = 3;
      this.__utilerias_label4.Top = 81;
      this.__utilerias_label4.Width = 55;
      this.__utilerias_label4.Height = 25;
      this.__utilerias_label4.Text = "Contra.";
      this.__utilerias_label4.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label4.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label4.MyEnabled = true;
      this.__utilerias_label4.Visible = true;
      this.__utilerias_label4.Transparent = false;
      this.__utilerias_label4.Font = new Font(this.__utilerias_label4.Font.Name, 9f, this.__utilerias_label4.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label4);
      this.htControls.Add((object) "__utilerias_label4", (object) this.__utilerias_label4);
      this.__utilerias_tusertea = new CEnhancedTextBox(this);
      this.__utilerias_tusertea.name = "__utilerias_tusertea";
      this.__utilerias_tusertea.Left = 56;
      this.__utilerias_tusertea.Top = 57;
      this.__utilerias_tusertea.Width = 135;
      this.__utilerias_tusertea.Text = "";
      this.__utilerias_tusertea.BackColor = Color.FromArgb(-1);
      this.__utilerias_tusertea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tusertea.Enabled = true;
      this.__utilerias_tusertea.Visible = true;
      this.__utilerias_tusertea.Height = 22;
      this.__utilerias_tusertea.Font = new Font(this.__utilerias_tusertea.Font.Name, 9f, this.__utilerias_tusertea.Font.Style);
      this.__utilerias_tusertea.multiline = false;
      this.__utilerias_tusertea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tusertea);
      this.htControls.Add((object) "__utilerias_tusertea", (object) this.__utilerias_tusertea);
      this.__utilerias_label3 = new CEnhancedLabel(this);
      this.__utilerias_label3.name = "__utilerias_label3";
      this.__utilerias_label3.Left = 3;
      this.__utilerias_label3.Top = 57;
      this.__utilerias_label3.Width = 55;
      this.__utilerias_label3.Height = 25;
      this.__utilerias_label3.Text = "Usuario";
      this.__utilerias_label3.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label3.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label3.MyEnabled = true;
      this.__utilerias_label3.Visible = true;
      this.__utilerias_label3.Transparent = false;
      this.__utilerias_label3.Font = new Font(this.__utilerias_label3.Font.Name, 9f, this.__utilerias_label3.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label3);
      this.htControls.Add((object) "__utilerias_label3", (object) this.__utilerias_label3);
      this.__utilerias_label2 = new CEnhancedLabel(this);
      this.__utilerias_label2.name = "__utilerias_label2";
      this.__utilerias_label2.Left = 3;
      this.__utilerias_label2.Top = 33;
      this.__utilerias_label2.Width = 55;
      this.__utilerias_label2.Height = 25;
      this.__utilerias_label2.Text = "Base";
      this.__utilerias_label2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label2.MyEnabled = true;
      this.__utilerias_label2.Visible = true;
      this.__utilerias_label2.Transparent = false;
      this.__utilerias_label2.Font = new Font(this.__utilerias_label2.Font.Name, 9f, this.__utilerias_label2.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label2);
      this.htControls.Add((object) "__utilerias_label2", (object) this.__utilerias_label2);
      this.__utilerias_tservertea = new CEnhancedTextBox(this);
      this.__utilerias_tservertea.name = "__utilerias_tservertea";
      this.__utilerias_tservertea.Left = 56;
      this.__utilerias_tservertea.Top = 9;
      this.__utilerias_tservertea.Width = 180;
      this.__utilerias_tservertea.Text = "";
      this.__utilerias_tservertea.BackColor = Color.FromArgb(-1);
      this.__utilerias_tservertea.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tservertea.Enabled = true;
      this.__utilerias_tservertea.Visible = true;
      this.__utilerias_tservertea.Height = 22;
      this.__utilerias_tservertea.Font = new Font(this.__utilerias_tservertea.Font.Name, 9f, this.__utilerias_tservertea.Font.Style);
      this.__utilerias_tservertea.multiline = false;
      this.__utilerias_tservertea.AddEvents();
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_tservertea);
      this.htControls.Add((object) "__utilerias_tservertea", (object) this.__utilerias_tservertea);
      this.__utilerias_label1 = new CEnhancedLabel(this);
      this.__utilerias_label1.name = "__utilerias_label1";
      this.__utilerias_label1.Left = 3;
      this.__utilerias_label1.Top = 9;
      this.__utilerias_label1.Width = 55;
      this.__utilerias_label1.Height = 25;
      this.__utilerias_label1.Text = "Servidor";
      this.__utilerias_label1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_label1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label1.MyEnabled = true;
      this.__utilerias_label1.Visible = true;
      this.__utilerias_label1.Transparent = false;
      this.__utilerias_label1.Font = new Font(this.__utilerias_label1.Font.Name, 9f, this.__utilerias_label1.Font.Style);
      this.__utilerias_frmtea.Controls.Add((Control) this.__utilerias_label1);
      this.htControls.Add((object) "__utilerias_label1", (object) this.__utilerias_label1);
      this.__utilerias_inven = new CEnhancedForm(this);
      this.__utilerias_inven.name = "__utilerias_inven";
      this.__utilerias_inven.Text = "Transferencias";
      this.__utilerias_inven.BackColor = Color.FromArgb(-16744256);
      this.__utilerias_inven.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_inven.BackColor), 0, 0, this.__utilerias_inven.Width, this.__utilerias_inven.Height);
      this.__utilerias_inven.AddEvents();
      this.htControls.Add((object) "__utilerias_inven", (object) this.__utilerias_inven);
      this.__utilerias_pnlcanfolio = new CEnhancedPanel(this);
      this.__utilerias_pnlcanfolio.name = "__utilerias_pnlcanfolio";
      this.__utilerias_pnlcanfolio.Left = 200;
      this.__utilerias_pnlcanfolio.Top = 15;
      this.__utilerias_pnlcanfolio.Width = 215;
      this.__utilerias_pnlcanfolio.Height = 40;
      this.__utilerias_pnlcanfolio.BackColor = Color.FromArgb(-8355585);
      this.__utilerias_pnlcanfolio.Enabled = true;
      this.__utilerias_pnlcanfolio.Visible = false;
      this.__utilerias_pnlcanfolio.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_pnlcanfolio);
      this.htControls.Add((object) "__utilerias_pnlcanfolio", (object) this.__utilerias_pnlcanfolio);
      this.__utilerias_pnltrans = new CEnhancedPanel(this);
      this.__utilerias_pnltrans.name = "__utilerias_pnltrans";
      this.__utilerias_pnltrans.Left = 140;
      this.__utilerias_pnltrans.Top = 175;
      this.__utilerias_pnltrans.Width = (int) byte.MaxValue;
      this.__utilerias_pnltrans.Height = 120;
      this.__utilerias_pnltrans.BackColor = Color.FromArgb(-65536);
      this.__utilerias_pnltrans.Enabled = true;
      this.__utilerias_pnltrans.Visible = false;
      this.__utilerias_pnltrans.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_pnltrans);
      this.htControls.Add((object) "__utilerias_pnltrans", (object) this.__utilerias_pnltrans);
      this.__utilerias_ltarttrans = new CEnhancedLabel(this);
      this.__utilerias_ltarttrans.name = "__utilerias_ltarttrans";
      this.__utilerias_ltarttrans.Left = 5;
      this.__utilerias_ltarttrans.Top = 70;
      this.__utilerias_ltarttrans.Width = 245;
      this.__utilerias_ltarttrans.Height = 20;
      this.__utilerias_ltarttrans.Text = "";
      this.__utilerias_ltarttrans.BackColor = Color.FromArgb(-65536);
      this.__utilerias_ltarttrans.ForeColor = Color.FromArgb(-1);
      this.__utilerias_ltarttrans.MyEnabled = true;
      this.__utilerias_ltarttrans.Visible = true;
      this.__utilerias_ltarttrans.Transparent = false;
      this.__utilerias_ltarttrans.Font = new Font(this.__utilerias_ltarttrans.Font.Name, 12f, this.__utilerias_ltarttrans.Font.Style);
      this.__utilerias_pnltrans.Controls.Add((Control) this.__utilerias_ltarttrans);
      this.htControls.Add((object) "__utilerias_ltarttrans", (object) this.__utilerias_ltarttrans);
      this.__utilerias_btntrans = new CEnhancedButton(this);
      this.__utilerias_btntrans.name = "__utilerias_btntrans";
      this.__utilerias_btntrans.Left = 60;
      this.__utilerias_btntrans.Top = 105;
      this.__utilerias_btntrans.Width = 145;
      this.__utilerias_btntrans.Height = 35;
      this.__utilerias_btntrans.Text = "Aceptar";
      this.__utilerias_btntrans.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btntrans.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btntrans.Enabled = true;
      this.__utilerias_btntrans.Visible = true;
      this.__utilerias_btntrans.Font = new Font(this.__utilerias_btntrans.Font.Name, 9f, this.__utilerias_btntrans.Font.Style);
      this.__utilerias_btntrans.AddEvents();
      this.__utilerias_pnltrans.Controls.Add((Control) this.__utilerias_btntrans);
      this.htControls.Add((object) "__utilerias_btntrans", (object) this.__utilerias_btntrans);
      this.__utilerias_label9 = new CEnhancedLabel(this);
      this.__utilerias_label9.name = "__utilerias_label9";
      this.__utilerias_label9.Left = 20;
      this.__utilerias_label9.Top = 15;
      this.__utilerias_label9.Width = 230;
      this.__utilerias_label9.Height = 75;
      this.__utilerias_label9.Text = "        LA CLAVE DEL ARTICULO NO EXISTE";
      this.__utilerias_label9.BackColor = Color.FromArgb(-1);
      this.__utilerias_label9.ForeColor = Color.FromArgb(-1);
      this.__utilerias_label9.MyEnabled = true;
      this.__utilerias_label9.Visible = true;
      this.__utilerias_label9.Transparent = true;
      this.__utilerias_label9.Font = new Font(this.__utilerias_label9.Font.Name, 14f, this.__utilerias_label9.Font.Style);
      this.__utilerias_pnltrans.Controls.Add((Control) this.__utilerias_label9);
      this.htControls.Add((object) "__utilerias_label9", (object) this.__utilerias_label9);
      this.__utilerias_cbocanfolio = new CEnhancedCombo(this);
      this.__utilerias_cbocanfolio.name = "__utilerias_cbocanfolio";
      this.__utilerias_cbocanfolio.Left = 65;
      this.__utilerias_cbocanfolio.Top = 55;
      this.__utilerias_cbocanfolio.Width = 90;
      this.__utilerias_cbocanfolio.Height = 22;
      this.__utilerias_cbocanfolio.Text = "";
      this.__utilerias_cbocanfolio.BackColor = Color.FromArgb(-1);
      this.__utilerias_cbocanfolio.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cbocanfolio.Enabled = true;
      this.__utilerias_cbocanfolio.Visible = true;
      this.__utilerias_cbocanfolio.Font = new Font(this.__utilerias_cbocanfolio.Font.Name, 9f, this.__utilerias_cbocanfolio.Font.Style);
      this.__utilerias_pnlcanfolio.Controls.Add((Control) this.__utilerias_cbocanfolio);
      this.htControls.Add((object) "__utilerias_cbocanfolio", (object) this.__utilerias_cbocanfolio);
      this.__utilerias_cbocanfolio.AddEvents();
      this.__utilerias_btncanfol2 = new CEnhancedButton(this);
      this.__utilerias_btncanfol2.name = "__utilerias_btncanfol2";
      this.__utilerias_btncanfol2.Left = 135;
      this.__utilerias_btncanfol2.Top = 130;
      this.__utilerias_btncanfol2.Width = 90;
      this.__utilerias_btncanfol2.Height = 30;
      this.__utilerias_btncanfol2.Text = "Salir";
      this.__utilerias_btncanfol2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btncanfol2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btncanfol2.Enabled = true;
      this.__utilerias_btncanfol2.Visible = true;
      this.__utilerias_btncanfol2.Font = new Font(this.__utilerias_btncanfol2.Font.Name, 9f, this.__utilerias_btncanfol2.Font.Style);
      this.__utilerias_btncanfol2.AddEvents();
      this.__utilerias_pnlcanfolio.Controls.Add((Control) this.__utilerias_btncanfol2);
      this.htControls.Add((object) "__utilerias_btncanfol2", (object) this.__utilerias_btncanfol2);
      this.__utilerias_btncanfolio1 = new CEnhancedButton(this);
      this.__utilerias_btncanfolio1.name = "__utilerias_btncanfolio1";
      this.__utilerias_btncanfolio1.Left = 30;
      this.__utilerias_btncanfolio1.Top = 130;
      this.__utilerias_btncanfolio1.Width = 90;
      this.__utilerias_btncanfolio1.Height = 30;
      this.__utilerias_btncanfolio1.Text = "Aceptar";
      this.__utilerias_btncanfolio1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btncanfolio1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btncanfolio1.Enabled = true;
      this.__utilerias_btncanfolio1.Visible = true;
      this.__utilerias_btncanfolio1.Font = new Font(this.__utilerias_btncanfolio1.Font.Name, 9f, this.__utilerias_btncanfolio1.Font.Style);
      this.__utilerias_btncanfolio1.AddEvents();
      this.__utilerias_pnlcanfolio.Controls.Add((Control) this.__utilerias_btncanfolio1);
      this.htControls.Add((object) "__utilerias_btncanfolio1", (object) this.__utilerias_btncanfolio1);
      this.__utilerias_label8 = new CEnhancedLabel(this);
      this.__utilerias_label8.name = "__utilerias_label8";
      this.__utilerias_label8.Left = 55;
      this.__utilerias_label8.Top = 30;
      this.__utilerias_label8.Width = 125;
      this.__utilerias_label8.Height = 25;
      this.__utilerias_label8.Text = "Selecciones folio";
      this.__utilerias_label8.BackColor = Color.FromArgb(-8355585);
      this.__utilerias_label8.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label8.MyEnabled = true;
      this.__utilerias_label8.Visible = true;
      this.__utilerias_label8.Transparent = false;
      this.__utilerias_label8.Font = new Font(this.__utilerias_label8.Font.Name, 9f, this.__utilerias_label8.Font.Style);
      this.__utilerias_pnlcanfolio.Controls.Add((Control) this.__utilerias_label8);
      this.htControls.Add((object) "__utilerias_label8", (object) this.__utilerias_label8);
      this.__utilerias_label7 = new CEnhancedLabel(this);
      this.__utilerias_label7.name = "__utilerias_label7";
      this.__utilerias_label7.Left = 50;
      this.__utilerias_label7.Top = 5;
      this.__utilerias_label7.Width = 155;
      this.__utilerias_label7.Height = 25;
      this.__utilerias_label7.Text = "Cancelacion folio";
      this.__utilerias_label7.BackColor = Color.FromArgb(-8355585);
      this.__utilerias_label7.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label7.MyEnabled = true;
      this.__utilerias_label7.Visible = true;
      this.__utilerias_label7.Transparent = false;
      this.__utilerias_label7.Font = new Font(this.__utilerias_label7.Font.Name, 12f, this.__utilerias_label7.Font.Style);
      this.__utilerias_pnlcanfolio.Controls.Add((Control) this.__utilerias_label7);
      this.htControls.Add((object) "__utilerias_label7", (object) this.__utilerias_label7);
      this.__utilerias_tprod = new CEnhancedTextBox(this);
      this.__utilerias_tprod.name = "__utilerias_tprod";
      this.__utilerias_tprod.Left = 65;
      this.__utilerias_tprod.Top = 47;
      this.__utilerias_tprod.Width = 172;
      this.__utilerias_tprod.Text = "";
      this.__utilerias_tprod.BackColor = Color.FromArgb(-1);
      this.__utilerias_tprod.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tprod.Enabled = true;
      this.__utilerias_tprod.Visible = true;
      this.__utilerias_tprod.Height = 22;
      this.__utilerias_tprod.Font = new Font(this.__utilerias_tprod.Font.Name, 9f, this.__utilerias_tprod.Font.Style);
      this.__utilerias_tprod.multiline = false;
      this.__utilerias_tprod.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_tprod);
      this.htControls.Add((object) "__utilerias_tprod", (object) this.__utilerias_tprod);
      this.__utilerias_ltcantidad = new CEnhancedButton(this);
      this.__utilerias_ltcantidad.name = "__utilerias_ltcantidad";
      this.__utilerias_ltcantidad.Left = 2;
      this.__utilerias_ltcantidad.Top = 20;
      this.__utilerias_ltcantidad.Width = 62;
      this.__utilerias_ltcantidad.Height = 25;
      this.__utilerias_ltcantidad.Text = "Cantidad:";
      this.__utilerias_ltcantidad.BackColor = Color.FromArgb(-66313);
      this.__utilerias_ltcantidad.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltcantidad.Enabled = true;
      this.__utilerias_ltcantidad.Visible = true;
      this.__utilerias_ltcantidad.Font = new Font(this.__utilerias_ltcantidad.Font.Name, 8f, this.__utilerias_ltcantidad.Font.Style);
      this.__utilerias_ltcantidad.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_ltcantidad);
      this.htControls.Add((object) "__utilerias_ltcantidad", (object) this.__utilerias_ltcantidad);
      this.__utilerias_tbltea = new CEnhancedTable(this, "__utilerias_tbltea");
      this.__utilerias_tbltea.name = "__utilerias_tbltea";
      this.__utilerias_tbltea.Left = 1;
      this.__utilerias_tbltea.Top = 70;
      this.__utilerias_tbltea.Width = 237;
      this.__utilerias_tbltea.Height = 125;
      this.__utilerias_tbltea.Text = "";
      this.__utilerias_tbltea.propColor = Color.FromArgb(-657931);
      this.__utilerias_tbltea.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tbltea.Enabled = true;
      this.__utilerias_tbltea.Visible = true;
      this.__utilerias_tbltea.Font = new Font(this.__utilerias_tbltea.Font.Name, 8f, this.__utilerias_tbltea.Font.Style);
      this.__utilerias_tbltea.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_tbltea);
      this.htControls.Add((object) "__utilerias_tbltea", (object) this.__utilerias_tbltea);
      this.__utilerias_ltfolio = new CEnhancedLabel(this);
      this.__utilerias_ltfolio.name = "__utilerias_ltfolio";
      this.__utilerias_ltfolio.Left = 150;
      this.__utilerias_ltfolio.Top = 1;
      this.__utilerias_ltfolio.Width = 90;
      this.__utilerias_ltfolio.Height = 19;
      this.__utilerias_ltfolio.Text = "";
      this.__utilerias_ltfolio.BackColor = Color.FromArgb(-16777216);
      this.__utilerias_ltfolio.ForeColor = Color.FromArgb(-16711936);
      this.__utilerias_ltfolio.MyEnabled = true;
      this.__utilerias_ltfolio.Visible = true;
      this.__utilerias_ltfolio.Transparent = false;
      this.__utilerias_ltfolio.Font = new Font(this.__utilerias_ltfolio.Font.Name, 10f, this.__utilerias_ltfolio.Font.Style);
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_ltfolio);
      this.htControls.Add((object) "__utilerias_ltfolio", (object) this.__utilerias_ltfolio);
      this.__utilerias_btnmainfolio = new CEnhancedButton(this);
      this.__utilerias_btnmainfolio.name = "__utilerias_btnmainfolio";
      this.__utilerias_btnmainfolio.Left = 100;
      this.__utilerias_btnmainfolio.Top = 1;
      this.__utilerias_btnmainfolio.Width = 45;
      this.__utilerias_btnmainfolio.Height = 19;
      this.__utilerias_btnmainfolio.Text = "Folio:";
      this.__utilerias_btnmainfolio.BackColor = Color.FromArgb(-66313);
      this.__utilerias_btnmainfolio.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_btnmainfolio.Enabled = true;
      this.__utilerias_btnmainfolio.Visible = true;
      this.__utilerias_btnmainfolio.Font = new Font(this.__utilerias_btnmainfolio.Font.Name, 8f, this.__utilerias_btnmainfolio.Font.Style);
      this.__utilerias_btnmainfolio.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_btnmainfolio);
      this.htControls.Add((object) "__utilerias_btnmainfolio", (object) this.__utilerias_btnmainfolio);
      this.__utilerias_ltkit = new CEnhancedLabel(this);
      this.__utilerias_ltkit.name = "__utilerias_ltkit";
      this.__utilerias_ltkit.Left = 115;
      this.__utilerias_ltkit.Top = 90;
      this.__utilerias_ltkit.Width = 43;
      this.__utilerias_ltkit.Height = 20;
      this.__utilerias_ltkit.Text = "Kit";
      this.__utilerias_ltkit.BackColor = Color.FromArgb(-3679238);
      this.__utilerias_ltkit.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltkit.MyEnabled = true;
      this.__utilerias_ltkit.Visible = false;
      this.__utilerias_ltkit.Transparent = false;
      this.__utilerias_ltkit.Font = new Font(this.__utilerias_ltkit.Font.Name, 10f, this.__utilerias_ltkit.Font.Style);
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_ltkit);
      this.htControls.Add((object) "__utilerias_ltkit", (object) this.__utilerias_ltkit);
      this.__utilerias_ltproducto = new CEnhancedButton(this);
      this.__utilerias_ltproducto.name = "__utilerias_ltproducto";
      this.__utilerias_ltproducto.Left = 2;
      this.__utilerias_ltproducto.Top = 47;
      this.__utilerias_ltproducto.Width = 62;
      this.__utilerias_ltproducto.Height = 22;
      this.__utilerias_ltproducto.Text = "Articulo:";
      this.__utilerias_ltproducto.BackColor = Color.FromArgb(-66313);
      this.__utilerias_ltproducto.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltproducto.Enabled = true;
      this.__utilerias_ltproducto.Visible = true;
      this.__utilerias_ltproducto.Font = new Font(this.__utilerias_ltproducto.Font.Name, 8f, this.__utilerias_ltproducto.Font.Style);
      this.__utilerias_ltproducto.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_ltproducto);
      this.htControls.Add((object) "__utilerias_ltproducto", (object) this.__utilerias_ltproducto);
      this.__utilerias_tcant = new CEnhancedTextBox(this);
      this.__utilerias_tcant.name = "__utilerias_tcant";
      this.__utilerias_tcant.Left = 65;
      this.__utilerias_tcant.Top = 20;
      this.__utilerias_tcant.Width = 50;
      this.__utilerias_tcant.Text = "";
      this.__utilerias_tcant.BackColor = Color.FromArgb(-1);
      this.__utilerias_tcant.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_tcant.Enabled = true;
      this.__utilerias_tcant.Visible = true;
      this.__utilerias_tcant.Height = 25;
      this.__utilerias_tcant.Font = new Font(this.__utilerias_tcant.Font.Name, 10f, this.__utilerias_tcant.Font.Style);
      this.__utilerias_tcant.multiline = false;
      this.__utilerias_tcant.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_tcant);
      this.htControls.Add((object) "__utilerias_tcant", (object) this.__utilerias_tcant);
      this.__utilerias_cmdaceptar = new CEnhancedButton(this);
      this.__utilerias_cmdaceptar.name = "__utilerias_cmdaceptar";
      this.__utilerias_cmdaceptar.Left = 166;
      this.__utilerias_cmdaceptar.Top = 20;
      this.__utilerias_cmdaceptar.Width = 70;
      this.__utilerias_cmdaceptar.Height = 25;
      this.__utilerias_cmdaceptar.Text = "Aceptar";
      this.__utilerias_cmdaceptar.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdaceptar.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdaceptar.Enabled = true;
      this.__utilerias_cmdaceptar.Visible = false;
      this.__utilerias_cmdaceptar.Font = new Font(this.__utilerias_cmdaceptar.Font.Name, 8f, this.__utilerias_cmdaceptar.Font.Style);
      this.__utilerias_cmdaceptar.AddEvents();
      this.__utilerias_inven.Controls.Add((Control) this.__utilerias_cmdaceptar);
      this.htControls.Add((object) "__utilerias_cmdaceptar", (object) this.__utilerias_cmdaceptar);
      this.__utilerias_mnuarchivo = new CEnhancedMenu(this);
      this.__utilerias_mnuarchivo.name = "__utilerias_mnuarchivo";
      this.__utilerias_mnuarchivo.Text = "Archivo";
      this.__utilerias_mnuarchivo.Enabled = true;
      this.__utilerias_mnuarchivo.Checked = false;
      this.__utilerias_mnuarchivo.AddToObject("__utilerias_inven");
      this.__utilerias_mnuarchivo.AddEvents();
      this.htControls.Add((object) "__utilerias_mnuarchivo", (object) this.__utilerias_mnuarchivo);
      this.__utilerias_mnumov = new CEnhancedMenu(this);
      this.__utilerias_mnumov.name = "__utilerias_mnumov";
      this.__utilerias_mnumov.Text = "Movimientos";
      this.__utilerias_mnumov.Enabled = true;
      this.__utilerias_mnumov.Checked = false;
      this.__utilerias_mnumov.AddToObject("__utilerias_mnuarchivo");
      this.__utilerias_mnumov.AddEvents();
      this.htControls.Add((object) "__utilerias_mnumov", (object) this.__utilerias_mnumov);
      this.__utilerias_mnuenviar = new CEnhancedMenu(this);
      this.__utilerias_mnuenviar.name = "__utilerias_mnuenviar";
      this.__utilerias_mnuenviar.Text = "Generar movimiento";
      this.__utilerias_mnuenviar.Enabled = true;
      this.__utilerias_mnuenviar.Checked = false;
      this.__utilerias_mnuenviar.AddToObject("__utilerias_mnuarchivo");
      this.__utilerias_mnuenviar.AddEvents();
      this.htControls.Add((object) "__utilerias_mnuenviar", (object) this.__utilerias_mnuenviar);
      this.__utilerias_mnufin = new CEnhancedMenu(this);
      this.__utilerias_mnufin.name = "__utilerias_mnufin";
      this.__utilerias_mnufin.Text = "Finalizar movimiento";
      this.__utilerias_mnufin.Enabled = true;
      this.__utilerias_mnufin.Checked = false;
      this.__utilerias_mnufin.AddToObject("__utilerias_mnuarchivo");
      this.__utilerias_mnufin.AddEvents();
      this.htControls.Add((object) "__utilerias_mnufin", (object) this.__utilerias_mnufin);
      this.__utilerias_mnucanc = new CEnhancedMenu(this);
      this.__utilerias_mnucanc.name = "__utilerias_mnucanc";
      this.__utilerias_mnucanc.Text = "Cancelar partida";
      this.__utilerias_mnucanc.Enabled = true;
      this.__utilerias_mnucanc.Checked = false;
      this.__utilerias_mnucanc.AddToObject("__utilerias_mnuarchivo");
      this.__utilerias_mnucanc.AddEvents();
      this.htControls.Add((object) "__utilerias_mnucanc", (object) this.__utilerias_mnucanc);
      this.__utilerias_mnucanfolio = new CEnhancedMenu(this);
      this.__utilerias_mnucanfolio.name = "__utilerias_mnucanfolio";
      this.__utilerias_mnucanfolio.Text = "Cancelar folio";
      this.__utilerias_mnucanfolio.Enabled = true;
      this.__utilerias_mnucanfolio.Checked = false;
      this.__utilerias_mnucanfolio.AddToObject("__utilerias_mnuarchivo");
      this.__utilerias_mnucanfolio.AddEvents();
      this.htControls.Add((object) "__utilerias_mnucanfolio", (object) this.__utilerias_mnucanfolio);
      this.__utilerias_enviar = new CEnhancedForm(this);
      this.__utilerias_enviar.name = "__utilerias_enviar";
      this.__utilerias_enviar.Text = "Enviar Movimiento";
      this.__utilerias_enviar.BackColor = Color.FromArgb(-1291);
      this.__utilerias_enviar.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_enviar.BackColor), 0, 0, this.__utilerias_enviar.Width, this.__utilerias_enviar.Height);
      this.__utilerias_enviar.AddEvents();
      this.htControls.Add((object) "__utilerias_enviar", (object) this.__utilerias_enviar);
      this.__utilerias_label6 = new CEnhancedLabel(this);
      this.__utilerias_label6.name = "__utilerias_label6";
      this.__utilerias_label6.Left = 2;
      this.__utilerias_label6.Top = 45;
      this.__utilerias_label6.Width = 230;
      this.__utilerias_label6.Height = 15;
      this.__utilerias_label6.Text = "Sucursal origen:";
      this.__utilerias_label6.BackColor = Color.FromArgb(-8323200);
      this.__utilerias_label6.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label6.MyEnabled = true;
      this.__utilerias_label6.Visible = true;
      this.__utilerias_label6.Transparent = false;
      this.__utilerias_label6.Font = new Font(this.__utilerias_label6.Font.Name, 8f, this.__utilerias_label6.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_label6);
      this.htControls.Add((object) "__utilerias_label6", (object) this.__utilerias_label6);
      this.__utilerias_label990 = new CEnhancedLabel(this);
      this.__utilerias_label990.name = "__utilerias_label990";
      this.__utilerias_label990.Left = 2;
      this.__utilerias_label990.Top = 82;
      this.__utilerias_label990.Width = 230;
      this.__utilerias_label990.Height = 15;
      this.__utilerias_label990.Text = "Sucursal destino:";
      this.__utilerias_label990.BackColor = Color.FromArgb(-8323200);
      this.__utilerias_label990.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_label990.MyEnabled = true;
      this.__utilerias_label990.Visible = true;
      this.__utilerias_label990.Transparent = false;
      this.__utilerias_label990.Font = new Font(this.__utilerias_label990.Font.Name, 8f, this.__utilerias_label990.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_label990);
      this.htControls.Add((object) "__utilerias_label990", (object) this.__utilerias_label990);
      this.__utilerias_cbofol = new CEnhancedCombo(this);
      this.__utilerias_cbofol.name = "__utilerias_cbofol";
      this.__utilerias_cbofol.Left = 124;
      this.__utilerias_cbofol.Top = 13;
      this.__utilerias_cbofol.Width = 100;
      this.__utilerias_cbofol.Height = 25;
      this.__utilerias_cbofol.Text = "";
      this.__utilerias_cbofol.BackColor = Color.FromArgb(-1);
      this.__utilerias_cbofol.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cbofol.Enabled = true;
      this.__utilerias_cbofol.Visible = true;
      this.__utilerias_cbofol.Font = new Font(this.__utilerias_cbofol.Font.Name, 10f, this.__utilerias_cbofol.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_cbofol);
      this.htControls.Add((object) "__utilerias_cbofol", (object) this.__utilerias_cbofol);
      this.__utilerias_cbofol.AddEvents();
      this.__utilerias_ltenviar2 = new CEnhancedLabel(this);
      this.__utilerias_ltenviar2.name = "__utilerias_ltenviar2";
      this.__utilerias_ltenviar2.Left = 2;
      this.__utilerias_ltenviar2.Top = 98;
      this.__utilerias_ltenviar2.Width = 230;
      this.__utilerias_ltenviar2.Height = 20;
      this.__utilerias_ltenviar2.Text = "";
      this.__utilerias_ltenviar2.BackColor = Color.FromArgb(-3873106);
      this.__utilerias_ltenviar2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltenviar2.MyEnabled = true;
      this.__utilerias_ltenviar2.Visible = true;
      this.__utilerias_ltenviar2.Transparent = false;
      this.__utilerias_ltenviar2.Font = new Font(this.__utilerias_ltenviar2.Font.Name, 9f, this.__utilerias_ltenviar2.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_ltenviar2);
      this.htControls.Add((object) "__utilerias_ltenviar2", (object) this.__utilerias_ltenviar2);
      this.__utilerias_ltenviar1 = new CEnhancedLabel(this);
      this.__utilerias_ltenviar1.name = "__utilerias_ltenviar1";
      this.__utilerias_ltenviar1.Left = 2;
      this.__utilerias_ltenviar1.Top = 61;
      this.__utilerias_ltenviar1.Width = 230;
      this.__utilerias_ltenviar1.Height = 20;
      this.__utilerias_ltenviar1.Text = "";
      this.__utilerias_ltenviar1.BackColor = Color.FromArgb(-3873106);
      this.__utilerias_ltenviar1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltenviar1.MyEnabled = true;
      this.__utilerias_ltenviar1.Visible = true;
      this.__utilerias_ltenviar1.Transparent = false;
      this.__utilerias_ltenviar1.Font = new Font(this.__utilerias_ltenviar1.Font.Name, 9f, this.__utilerias_ltenviar1.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_ltenviar1);
      this.htControls.Add((object) "__utilerias_ltenviar1", (object) this.__utilerias_ltenviar1);
      this.__utilerias_chtodos = new CEnhancedCheckBox(this);
      this.__utilerias_chtodos.name = "__utilerias_chtodos";
      this.__utilerias_chtodos.Left = 155;
      this.__utilerias_chtodos.Top = 230;
      this.__utilerias_chtodos.Width = 85;
      this.__utilerias_chtodos.Height = 25;
      this.__utilerias_chtodos.Text = "Todos";
      this.__utilerias_chtodos.BackColor = Color.FromArgb(-1291);
      this.__utilerias_chtodos.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_chtodos.Enabled = true;
      this.__utilerias_chtodos.Visible = false;
      this.__utilerias_chtodos.Checked = false;
      this.__utilerias_chtodos.Font = new Font(this.__utilerias_chtodos.Font.Name, 9f, this.__utilerias_chtodos.Font.Style);
      this.__utilerias_chtodos.AddEvents();
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_chtodos);
      this.htControls.Add((object) "__utilerias_chtodos", (object) this.__utilerias_chtodos);
      this.__utilerias_ltrutaenviar = new CEnhancedLabel(this);
      this.__utilerias_ltrutaenviar.name = "__utilerias_ltrutaenviar";
      this.__utilerias_ltrutaenviar.Left = 5;
      this.__utilerias_ltrutaenviar.Top = 198;
      this.__utilerias_ltrutaenviar.Width = 229;
      this.__utilerias_ltrutaenviar.Height = 20;
      this.__utilerias_ltrutaenviar.Text = "";
      this.__utilerias_ltrutaenviar.BackColor = Color.FromArgb(-1291);
      this.__utilerias_ltrutaenviar.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltrutaenviar.MyEnabled = true;
      this.__utilerias_ltrutaenviar.Visible = true;
      this.__utilerias_ltrutaenviar.Transparent = false;
      this.__utilerias_ltrutaenviar.Font = new Font(this.__utilerias_ltrutaenviar.Font.Name, 8f, this.__utilerias_ltrutaenviar.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_ltrutaenviar);
      this.htControls.Add((object) "__utilerias_ltrutaenviar", (object) this.__utilerias_ltrutaenviar);
      this.__utilerias_cmdsend2 = new CEnhancedButton(this);
      this.__utilerias_cmdsend2.name = "__utilerias_cmdsend2";
      this.__utilerias_cmdsend2.Left = 140;
      this.__utilerias_cmdsend2.Top = 150;
      this.__utilerias_cmdsend2.Width = 80;
      this.__utilerias_cmdsend2.Height = 35;
      this.__utilerias_cmdsend2.Text = "Cancelar";
      this.__utilerias_cmdsend2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdsend2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdsend2.Enabled = true;
      this.__utilerias_cmdsend2.Visible = true;
      this.__utilerias_cmdsend2.Font = new Font(this.__utilerias_cmdsend2.Font.Name, 9f, this.__utilerias_cmdsend2.Font.Style);
      this.__utilerias_cmdsend2.AddEvents();
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_cmdsend2);
      this.htControls.Add((object) "__utilerias_cmdsend2", (object) this.__utilerias_cmdsend2);
      this.__utilerias_cmdsend1 = new CEnhancedButton(this);
      this.__utilerias_cmdsend1.name = "__utilerias_cmdsend1";
      this.__utilerias_cmdsend1.Left = 25;
      this.__utilerias_cmdsend1.Top = 150;
      this.__utilerias_cmdsend1.Width = 80;
      this.__utilerias_cmdsend1.Height = 35;
      this.__utilerias_cmdsend1.Text = "Enviar";
      this.__utilerias_cmdsend1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdsend1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdsend1.Enabled = true;
      this.__utilerias_cmdsend1.Visible = true;
      this.__utilerias_cmdsend1.Font = new Font(this.__utilerias_cmdsend1.Font.Name, 9f, this.__utilerias_cmdsend1.Font.Style);
      this.__utilerias_cmdsend1.AddEvents();
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_cmdsend1);
      this.htControls.Add((object) "__utilerias_cmdsend1", (object) this.__utilerias_cmdsend1);
      this.__utilerias_ltenviar9 = new CEnhancedLabel(this);
      this.__utilerias_ltenviar9.name = "__utilerias_ltenviar9";
      this.__utilerias_ltenviar9.Left = 77;
      this.__utilerias_ltenviar9.Top = 17;
      this.__utilerias_ltenviar9.Width = 40;
      this.__utilerias_ltenviar9.Height = 20;
      this.__utilerias_ltenviar9.Text = "Folio:";
      this.__utilerias_ltenviar9.BackColor = Color.FromArgb(-1291);
      this.__utilerias_ltenviar9.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltenviar9.MyEnabled = true;
      this.__utilerias_ltenviar9.Visible = true;
      this.__utilerias_ltenviar9.Transparent = false;
      this.__utilerias_ltenviar9.Font = new Font(this.__utilerias_ltenviar9.Font.Name, 9f, this.__utilerias_ltenviar9.Font.Style);
      this.__utilerias_enviar.Controls.Add((Control) this.__utilerias_ltenviar9);
      this.htControls.Add((object) "__utilerias_ltenviar9", (object) this.__utilerias_ltenviar9);
      this.__utilerias_importa = new CEnhancedForm(this);
      this.__utilerias_importa.name = "__utilerias_importa";
      this.__utilerias_importa.Text = "Traspasos";
      this.__utilerias_importa.BackColor = Color.FromArgb(-66313);
      this.__utilerias_importa.graphics.FillRectangle((Brush) new SolidBrush(this.__utilerias_importa.BackColor), 0, 0, this.__utilerias_importa.Width, this.__utilerias_importa.Height);
      this.__utilerias_importa.AddEvents();
      this.htControls.Add((object) "__utilerias_importa", (object) this.__utilerias_importa);
      this.__utilerias_cbotiendadestino = new CEnhancedCombo(this);
      this.__utilerias_cbotiendadestino.name = "__utilerias_cbotiendadestino";
      this.__utilerias_cbotiendadestino.Left = 50;
      this.__utilerias_cbotiendadestino.Top = 50;
      this.__utilerias_cbotiendadestino.Width = 170;
      this.__utilerias_cbotiendadestino.Height = 22;
      this.__utilerias_cbotiendadestino.Text = "";
      this.__utilerias_cbotiendadestino.BackColor = Color.FromArgb(-1);
      this.__utilerias_cbotiendadestino.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cbotiendadestino.Enabled = true;
      this.__utilerias_cbotiendadestino.Visible = true;
      this.__utilerias_cbotiendadestino.Font = new Font(this.__utilerias_cbotiendadestino.Font.Name, 9f, this.__utilerias_cbotiendadestino.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_cbotiendadestino);
      this.htControls.Add((object) "__utilerias_cbotiendadestino", (object) this.__utilerias_cbotiendadestino);
      this.__utilerias_cbotiendadestino.AddEvents();
      this.__utilerias_ltserver9 = new CEnhancedLabel(this);
      this.__utilerias_ltserver9.name = "__utilerias_ltserver9";
      this.__utilerias_ltserver9.Left = -1;
      this.__utilerias_ltserver9.Top = 169;
      this.__utilerias_ltserver9.Width = 245;
      this.__utilerias_ltserver9.Height = 20;
      this.__utilerias_ltserver9.Text = "";
      this.__utilerias_ltserver9.BackColor = Color.FromArgb(-16744193);
      this.__utilerias_ltserver9.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltserver9.MyEnabled = true;
      this.__utilerias_ltserver9.Visible = true;
      this.__utilerias_ltserver9.Transparent = false;
      this.__utilerias_ltserver9.Font = new Font(this.__utilerias_ltserver9.Font.Name, 8f, this.__utilerias_ltserver9.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_ltserver9);
      this.htControls.Add((object) "__utilerias_ltserver9", (object) this.__utilerias_ltserver9);
      this.__utilerias_ltimport11 = new CEnhancedLabel(this);
      this.__utilerias_ltimport11.name = "__utilerias_ltimport11";
      this.__utilerias_ltimport11.Left = -1;
      this.__utilerias_ltimport11.Top = 148;
      this.__utilerias_ltimport11.Width = 242;
      this.__utilerias_ltimport11.Height = 20;
      this.__utilerias_ltimport11.Text = "";
      this.__utilerias_ltimport11.BackColor = Color.FromArgb(-16744256);
      this.__utilerias_ltimport11.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltimport11.MyEnabled = true;
      this.__utilerias_ltimport11.Visible = true;
      this.__utilerias_ltimport11.Transparent = false;
      this.__utilerias_ltimport11.Font = new Font(this.__utilerias_ltimport11.Font.Name, 8f, this.__utilerias_ltimport11.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_ltimport11);
      this.htControls.Add((object) "__utilerias_ltimport11", (object) this.__utilerias_ltimport11);
      this.__utilerias_cmdimpor2 = new CEnhancedButton(this);
      this.__utilerias_cmdimpor2.name = "__utilerias_cmdimpor2";
      this.__utilerias_cmdimpor2.Left = 135;
      this.__utilerias_cmdimpor2.Top = 100;
      this.__utilerias_cmdimpor2.Width = 85;
      this.__utilerias_cmdimpor2.Height = 30;
      this.__utilerias_cmdimpor2.Text = "Cancelar";
      this.__utilerias_cmdimpor2.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdimpor2.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdimpor2.Enabled = true;
      this.__utilerias_cmdimpor2.Visible = true;
      this.__utilerias_cmdimpor2.Font = new Font(this.__utilerias_cmdimpor2.Font.Name, 9f, this.__utilerias_cmdimpor2.Font.Style);
      this.__utilerias_cmdimpor2.AddEvents();
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_cmdimpor2);
      this.htControls.Add((object) "__utilerias_cmdimpor2", (object) this.__utilerias_cmdimpor2);
      this.__utilerias_cmdimpor1 = new CEnhancedButton(this);
      this.__utilerias_cmdimpor1.name = "__utilerias_cmdimpor1";
      this.__utilerias_cmdimpor1.Left = 25;
      this.__utilerias_cmdimpor1.Top = 100;
      this.__utilerias_cmdimpor1.Width = 85;
      this.__utilerias_cmdimpor1.Height = 30;
      this.__utilerias_cmdimpor1.Text = "Iniciar";
      this.__utilerias_cmdimpor1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_cmdimpor1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cmdimpor1.Enabled = true;
      this.__utilerias_cmdimpor1.Visible = true;
      this.__utilerias_cmdimpor1.Font = new Font(this.__utilerias_cmdimpor1.Font.Name, 9f, this.__utilerias_cmdimpor1.Font.Style);
      this.__utilerias_cmdimpor1.AddEvents();
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_cmdimpor1);
      this.htControls.Add((object) "__utilerias_cmdimpor1", (object) this.__utilerias_cmdimpor1);
      this.__utilerias_ltdestino1 = new CEnhancedLabel(this);
      this.__utilerias_ltdestino1.name = "__utilerias_ltdestino1";
      this.__utilerias_ltdestino1.Left = 2;
      this.__utilerias_ltdestino1.Top = 51;
      this.__utilerias_ltdestino1.Width = 55;
      this.__utilerias_ltdestino1.Height = 20;
      this.__utilerias_ltdestino1.Text = "Destino:";
      this.__utilerias_ltdestino1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_ltdestino1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltdestino1.MyEnabled = true;
      this.__utilerias_ltdestino1.Visible = true;
      this.__utilerias_ltdestino1.Transparent = false;
      this.__utilerias_ltdestino1.Font = new Font(this.__utilerias_ltdestino1.Font.Name, 9f, this.__utilerias_ltdestino1.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_ltdestino1);
      this.htControls.Add((object) "__utilerias_ltdestino1", (object) this.__utilerias_ltdestino1);
      this.__utilerias_cbotiendaorigen = new CEnhancedCombo(this);
      this.__utilerias_cbotiendaorigen.name = "__utilerias_cbotiendaorigen";
      this.__utilerias_cbotiendaorigen.Left = 50;
      this.__utilerias_cbotiendaorigen.Top = 4;
      this.__utilerias_cbotiendaorigen.Width = 170;
      this.__utilerias_cbotiendaorigen.Height = 22;
      this.__utilerias_cbotiendaorigen.Text = "";
      this.__utilerias_cbotiendaorigen.BackColor = Color.FromArgb(-1);
      this.__utilerias_cbotiendaorigen.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_cbotiendaorigen.Enabled = false;
      this.__utilerias_cbotiendaorigen.Visible = true;
      this.__utilerias_cbotiendaorigen.Font = new Font(this.__utilerias_cbotiendaorigen.Font.Name, 9f, this.__utilerias_cbotiendaorigen.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_cbotiendaorigen);
      this.htControls.Add((object) "__utilerias_cbotiendaorigen", (object) this.__utilerias_cbotiendaorigen);
      this.__utilerias_cbotiendaorigen.AddEvents();
      this.__utilerias_ltorigen1 = new CEnhancedLabel(this);
      this.__utilerias_ltorigen1.name = "__utilerias_ltorigen1";
      this.__utilerias_ltorigen1.Left = 2;
      this.__utilerias_ltorigen1.Top = 5;
      this.__utilerias_ltorigen1.Width = 55;
      this.__utilerias_ltorigen1.Height = 20;
      this.__utilerias_ltorigen1.Text = "Origen:";
      this.__utilerias_ltorigen1.BackColor = Color.FromArgb(-66313);
      this.__utilerias_ltorigen1.ForeColor = Color.FromArgb(-16777216);
      this.__utilerias_ltorigen1.MyEnabled = true;
      this.__utilerias_ltorigen1.Visible = true;
      this.__utilerias_ltorigen1.Transparent = false;
      this.__utilerias_ltorigen1.Font = new Font(this.__utilerias_ltorigen1.Font.Name, 9f, this.__utilerias_ltorigen1.Font.Style);
      this.__utilerias_importa.Controls.Add((Control) this.__utilerias_ltorigen1);
      this.htControls.Add((object) "__utilerias_ltorigen1", (object) this.__utilerias_ltorigen1);
      this.__mainmodule_prods = new CEnhancedForm(this);
      this.__mainmodule_prods.name = "__mainmodule_prods";
      this.__mainmodule_prods.Text = "Seleccione articulo";
      this.__mainmodule_prods.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_prods.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_prods.BackColor), 0, 0, this.__mainmodule_prods.Width, this.__mainmodule_prods.Height);
      this.__mainmodule_prods.AddEvents();
      this.htControls.Add((object) "__mainmodule_prods", (object) this.__mainmodule_prods);
      this.__mainmodule_btnprods = new CEnhancedButton(this);
      this.__mainmodule_btnprods.name = "__mainmodule_btnprods";
      this.__mainmodule_btnprods.Left = 3;
      this.__mainmodule_btnprods.Top = 2;
      this.__mainmodule_btnprods.Width = 75;
      this.__mainmodule_btnprods.Height = 23;
      this.__mainmodule_btnprods.Text = "Aceptar";
      this.__mainmodule_btnprods.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnprods.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnprods.Enabled = true;
      this.__mainmodule_btnprods.Visible = true;
      this.__mainmodule_btnprods.Font = new Font(this.__mainmodule_btnprods.Font.Name, 9f, this.__mainmodule_btnprods.Font.Style);
      this.__mainmodule_btnprods.AddEvents();
      this.__mainmodule_prods.Controls.Add((Control) this.__mainmodule_btnprods);
      this.htControls.Add((object) "__mainmodule_btnprods", (object) this.__mainmodule_btnprods);
      this.__mainmodule_tblprod = new CEnhancedTable(this, "__mainmodule_tblprod");
      this.__mainmodule_tblprod.name = "__mainmodule_tblprod";
      this.__mainmodule_tblprod.Left = 3;
      this.__mainmodule_tblprod.Top = 30;
      this.__mainmodule_tblprod.Width = 236;
      this.__mainmodule_tblprod.Height = 235;
      this.__mainmodule_tblprod.Text = "";
      this.__mainmodule_tblprod.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tblprod.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tblprod.Enabled = true;
      this.__mainmodule_tblprod.Visible = true;
      this.__mainmodule_tblprod.Font = new Font(this.__mainmodule_tblprod.Font.Name, 8f, this.__mainmodule_tblprod.Font.Style);
      this.__mainmodule_tblprod.AddEvents();
      this.__mainmodule_prods.Controls.Add((Control) this.__mainmodule_tblprod);
      this.htControls.Add((object) "__mainmodule_tblprod", (object) this.__mainmodule_tblprod);
      this.__mainmodule_frmacceso = new CEnhancedForm(this);
      this.__mainmodule_frmacceso.name = "__mainmodule_frmacceso";
      this.__mainmodule_frmacceso.Text = "Acceso";
      this.__mainmodule_frmacceso.BackColor = Color.FromArgb(-4930050);
      this.__mainmodule_frmacceso.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmacceso.BackColor), 0, 0, this.__mainmodule_frmacceso.Width, this.__mainmodule_frmacceso.Height);
      this.__mainmodule_frmacceso.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmacceso", (object) this.__mainmodule_frmacceso);
      this.__mainmodule_tlogin = new CEnhancedTextBox(this);
      this.__mainmodule_tlogin.name = "__mainmodule_tlogin";
      this.__mainmodule_tlogin.Left = 60;
      this.__mainmodule_tlogin.Top = 40;
      this.__mainmodule_tlogin.Width = 120;
      this.__mainmodule_tlogin.Text = "";
      this.__mainmodule_tlogin.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tlogin.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tlogin.Enabled = true;
      this.__mainmodule_tlogin.Visible = true;
      this.__mainmodule_tlogin.Height = 25;
      this.__mainmodule_tlogin.Font = new Font(this.__mainmodule_tlogin.Font.Name, 10f, this.__mainmodule_tlogin.Font.Style);
      this.__mainmodule_tlogin.multiline = false;
      this.__mainmodule_tlogin.AddEvents();
      this.__mainmodule_frmacceso.Controls.Add((Control) this.__mainmodule_tlogin);
      this.htControls.Add((object) "__mainmodule_tlogin", (object) this.__mainmodule_tlogin);
      this.__mainmodule_btnlogin2 = new CEnhancedButton(this);
      this.__mainmodule_btnlogin2.name = "__mainmodule_btnlogin2";
      this.__mainmodule_btnlogin2.Left = 120;
      this.__mainmodule_btnlogin2.Top = 85;
      this.__mainmodule_btnlogin2.Width = 90;
      this.__mainmodule_btnlogin2.Height = 30;
      this.__mainmodule_btnlogin2.Text = "Cancelar";
      this.__mainmodule_btnlogin2.BackColor = Color.FromArgb(-777);
      this.__mainmodule_btnlogin2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnlogin2.Enabled = true;
      this.__mainmodule_btnlogin2.Visible = true;
      this.__mainmodule_btnlogin2.Font = new Font(this.__mainmodule_btnlogin2.Font.Name, 9f, this.__mainmodule_btnlogin2.Font.Style);
      this.__mainmodule_btnlogin2.AddEvents();
      this.__mainmodule_frmacceso.Controls.Add((Control) this.__mainmodule_btnlogin2);
      this.htControls.Add((object) "__mainmodule_btnlogin2", (object) this.__mainmodule_btnlogin2);
      this.__mainmodule_btnlogin1 = new CEnhancedButton(this);
      this.__mainmodule_btnlogin1.name = "__mainmodule_btnlogin1";
      this.__mainmodule_btnlogin1.Left = 25;
      this.__mainmodule_btnlogin1.Top = 85;
      this.__mainmodule_btnlogin1.Width = 90;
      this.__mainmodule_btnlogin1.Height = 30;
      this.__mainmodule_btnlogin1.Text = "Aceptar";
      this.__mainmodule_btnlogin1.BackColor = Color.FromArgb(-777);
      this.__mainmodule_btnlogin1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnlogin1.Enabled = true;
      this.__mainmodule_btnlogin1.Visible = true;
      this.__mainmodule_btnlogin1.Font = new Font(this.__mainmodule_btnlogin1.Font.Name, 9f, this.__mainmodule_btnlogin1.Font.Style);
      this.__mainmodule_btnlogin1.AddEvents();
      this.__mainmodule_frmacceso.Controls.Add((Control) this.__mainmodule_btnlogin1);
      this.htControls.Add((object) "__mainmodule_btnlogin1", (object) this.__mainmodule_btnlogin1);
      this.__mainmodule_label39 = new CEnhancedLabel(this);
      this.__mainmodule_label39.name = "__mainmodule_label39";
      this.__mainmodule_label39.Left = 55;
      this.__mainmodule_label39.Top = 10;
      this.__mainmodule_label39.Width = 140;
      this.__mainmodule_label39.Height = 20;
      this.__mainmodule_label39.Text = "Acceso y autorizacion";
      this.__mainmodule_label39.BackColor = Color.FromArgb(-4930050);
      this.__mainmodule_label39.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label39.MyEnabled = true;
      this.__mainmodule_label39.Visible = true;
      this.__mainmodule_label39.Transparent = false;
      this.__mainmodule_label39.Font = new Font(this.__mainmodule_label39.Font.Name, 9f, this.__mainmodule_label39.Font.Style);
      this.__mainmodule_frmacceso.Controls.Add((Control) this.__mainmodule_label39);
      this.htControls.Add((object) "__mainmodule_label39", (object) this.__mainmodule_label39);
      this.__mainmodule_usuarios = new CEnhancedForm(this);
      this.__mainmodule_usuarios.name = "__mainmodule_usuarios";
      this.__mainmodule_usuarios.Text = "Usuarios";
      this.__mainmodule_usuarios.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_usuarios.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_usuarios.BackColor), 0, 0, this.__mainmodule_usuarios.Width, this.__mainmodule_usuarios.Height);
      this.__mainmodule_usuarios.AddEvents();
      this.htControls.Add((object) "__mainmodule_usuarios", (object) this.__mainmodule_usuarios);
      this.__mainmodule_tbluser = new CEnhancedTable(this, "__mainmodule_tbluser");
      this.__mainmodule_tbluser.name = "__mainmodule_tbluser";
      this.__mainmodule_tbluser.Left = 1;
      this.__mainmodule_tbluser.Top = 136;
      this.__mainmodule_tbluser.Width = 237;
      this.__mainmodule_tbluser.Height = 130;
      this.__mainmodule_tbluser.Text = "";
      this.__mainmodule_tbluser.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tbluser.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tbluser.Enabled = true;
      this.__mainmodule_tbluser.Visible = true;
      this.__mainmodule_tbluser.Font = new Font(this.__mainmodule_tbluser.Font.Name, 9f, this.__mainmodule_tbluser.Font.Style);
      this.__mainmodule_tbluser.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tbluser);
      this.htControls.Add((object) "__mainmodule_tbluser", (object) this.__mainmodule_tbluser);
      this.__mainmodule_btnusr3 = new CEnhancedButton(this);
      this.__mainmodule_btnusr3.name = "__mainmodule_btnusr3";
      this.__mainmodule_btnusr3.Left = 165;
      this.__mainmodule_btnusr3.Top = 106;
      this.__mainmodule_btnusr3.Width = 65;
      this.__mainmodule_btnusr3.Height = 25;
      this.__mainmodule_btnusr3.Text = "Salir";
      this.__mainmodule_btnusr3.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnusr3.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnusr3.Enabled = true;
      this.__mainmodule_btnusr3.Visible = true;
      this.__mainmodule_btnusr3.Font = new Font(this.__mainmodule_btnusr3.Font.Name, 9f, this.__mainmodule_btnusr3.Font.Style);
      this.__mainmodule_btnusr3.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_btnusr3);
      this.htControls.Add((object) "__mainmodule_btnusr3", (object) this.__mainmodule_btnusr3);
      this.__mainmodule_btnusr2 = new CEnhancedButton(this);
      this.__mainmodule_btnusr2.name = "__mainmodule_btnusr2";
      this.__mainmodule_btnusr2.Left = 81;
      this.__mainmodule_btnusr2.Top = 106;
      this.__mainmodule_btnusr2.Width = 65;
      this.__mainmodule_btnusr2.Height = 25;
      this.__mainmodule_btnusr2.Text = "Eliminar";
      this.__mainmodule_btnusr2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnusr2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnusr2.Enabled = true;
      this.__mainmodule_btnusr2.Visible = true;
      this.__mainmodule_btnusr2.Font = new Font(this.__mainmodule_btnusr2.Font.Name, 9f, this.__mainmodule_btnusr2.Font.Style);
      this.__mainmodule_btnusr2.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_btnusr2);
      this.htControls.Add((object) "__mainmodule_btnusr2", (object) this.__mainmodule_btnusr2);
      this.__mainmodule_btnusr1 = new CEnhancedButton(this);
      this.__mainmodule_btnusr1.name = "__mainmodule_btnusr1";
      this.__mainmodule_btnusr1.Left = 6;
      this.__mainmodule_btnusr1.Top = 106;
      this.__mainmodule_btnusr1.Width = 55;
      this.__mainmodule_btnusr1.Height = 25;
      this.__mainmodule_btnusr1.Text = "Grabar";
      this.__mainmodule_btnusr1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnusr1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnusr1.Enabled = true;
      this.__mainmodule_btnusr1.Visible = true;
      this.__mainmodule_btnusr1.Font = new Font(this.__mainmodule_btnusr1.Font.Name, 9f, this.__mainmodule_btnusr1.Font.Style);
      this.__mainmodule_btnusr1.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_btnusr1);
      this.htControls.Add((object) "__mainmodule_btnusr1", (object) this.__mainmodule_btnusr1);
      this.__mainmodule_tfolio = new CEnhancedTextBox(this);
      this.__mainmodule_tfolio.name = "__mainmodule_tfolio";
      this.__mainmodule_tfolio.Left = 145;
      this.__mainmodule_tfolio.Top = 75;
      this.__mainmodule_tfolio.Width = 90;
      this.__mainmodule_tfolio.Text = "";
      this.__mainmodule_tfolio.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tfolio.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tfolio.Enabled = true;
      this.__mainmodule_tfolio.Visible = true;
      this.__mainmodule_tfolio.Height = 22;
      this.__mainmodule_tfolio.Font = new Font(this.__mainmodule_tfolio.Font.Name, 9f, this.__mainmodule_tfolio.Font.Style);
      this.__mainmodule_tfolio.multiline = false;
      this.__mainmodule_tfolio.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tfolio);
      this.htControls.Add((object) "__mainmodule_tfolio", (object) this.__mainmodule_tfolio);
      this.__mainmodule_tserie = new CEnhancedTextBox(this);
      this.__mainmodule_tserie.name = "__mainmodule_tserie";
      this.__mainmodule_tserie.Left = 55;
      this.__mainmodule_tserie.Top = 76;
      this.__mainmodule_tserie.Width = 52;
      this.__mainmodule_tserie.Text = "";
      this.__mainmodule_tserie.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tserie.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tserie.Enabled = true;
      this.__mainmodule_tserie.Visible = true;
      this.__mainmodule_tserie.Height = 22;
      this.__mainmodule_tserie.Font = new Font(this.__mainmodule_tserie.Font.Name, 9f, this.__mainmodule_tserie.Font.Style);
      this.__mainmodule_tserie.multiline = false;
      this.__mainmodule_tserie.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tserie);
      this.htControls.Add((object) "__mainmodule_tserie", (object) this.__mainmodule_tserie);
      this.__mainmodule_chnivel = new CEnhancedCheckBox(this);
      this.__mainmodule_chnivel.name = "__mainmodule_chnivel";
      this.__mainmodule_chnivel.Left = 153;
      this.__mainmodule_chnivel.Top = 50;
      this.__mainmodule_chnivel.Width = 87;
      this.__mainmodule_chnivel.Height = 20;
      this.__mainmodule_chnivel.Text = "Administrador";
      this.__mainmodule_chnivel.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_chnivel.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chnivel.Enabled = true;
      this.__mainmodule_chnivel.Visible = true;
      this.__mainmodule_chnivel.Checked = false;
      this.__mainmodule_chnivel.Font = new Font(this.__mainmodule_chnivel.Font.Name, 8f, this.__mainmodule_chnivel.Font.Style);
      this.__mainmodule_chnivel.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_chnivel);
      this.htControls.Add((object) "__mainmodule_chnivel", (object) this.__mainmodule_chnivel);
      this.__mainmodule_tclave = new CEnhancedTextBox(this);
      this.__mainmodule_tclave.name = "__mainmodule_tclave";
      this.__mainmodule_tclave.Left = 67;
      this.__mainmodule_tclave.Top = 50;
      this.__mainmodule_tclave.Width = 85;
      this.__mainmodule_tclave.Text = "";
      this.__mainmodule_tclave.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tclave.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tclave.Enabled = true;
      this.__mainmodule_tclave.Visible = true;
      this.__mainmodule_tclave.Height = 22;
      this.__mainmodule_tclave.Font = new Font(this.__mainmodule_tclave.Font.Name, 9f, this.__mainmodule_tclave.Font.Style);
      this.__mainmodule_tclave.multiline = false;
      this.__mainmodule_tclave.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tclave);
      this.htControls.Add((object) "__mainmodule_tclave", (object) this.__mainmodule_tclave);
      this.__mainmodule_tnombre = new CEnhancedTextBox(this);
      this.__mainmodule_tnombre.name = "__mainmodule_tnombre";
      this.__mainmodule_tnombre.Left = 55;
      this.__mainmodule_tnombre.Top = 25;
      this.__mainmodule_tnombre.Width = 180;
      this.__mainmodule_tnombre.Text = "";
      this.__mainmodule_tnombre.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tnombre.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tnombre.Enabled = true;
      this.__mainmodule_tnombre.Visible = true;
      this.__mainmodule_tnombre.Height = 22;
      this.__mainmodule_tnombre.Font = new Font(this.__mainmodule_tnombre.Font.Name, 9f, this.__mainmodule_tnombre.Font.Style);
      this.__mainmodule_tnombre.multiline = false;
      this.__mainmodule_tnombre.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tnombre);
      this.htControls.Add((object) "__mainmodule_tnombre", (object) this.__mainmodule_tnombre);
      this.__mainmodule_tusu = new CEnhancedTextBox(this);
      this.__mainmodule_tusu.name = "__mainmodule_tusu";
      this.__mainmodule_tusu.Left = 55;
      this.__mainmodule_tusu.Top = 2;
      this.__mainmodule_tusu.Width = 122;
      this.__mainmodule_tusu.Text = "";
      this.__mainmodule_tusu.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tusu.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tusu.Enabled = true;
      this.__mainmodule_tusu.Visible = true;
      this.__mainmodule_tusu.Height = 22;
      this.__mainmodule_tusu.Font = new Font(this.__mainmodule_tusu.Font.Name, 9f, this.__mainmodule_tusu.Font.Style);
      this.__mainmodule_tusu.multiline = false;
      this.__mainmodule_tusu.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_tusu);
      this.htControls.Add((object) "__mainmodule_tusu", (object) this.__mainmodule_tusu);
      this.__mainmodule_label14 = new CEnhancedLabel(this);
      this.__mainmodule_label14.name = "__mainmodule_label14";
      this.__mainmodule_label14.Left = 108;
      this.__mainmodule_label14.Top = 78;
      this.__mainmodule_label14.Width = 40;
      this.__mainmodule_label14.Height = 20;
      this.__mainmodule_label14.Text = "Folio:";
      this.__mainmodule_label14.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label14.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label14.MyEnabled = true;
      this.__mainmodule_label14.Visible = true;
      this.__mainmodule_label14.Transparent = false;
      this.__mainmodule_label14.Font = new Font(this.__mainmodule_label14.Font.Name, 9f, this.__mainmodule_label14.Font.Style);
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_label14);
      this.htControls.Add((object) "__mainmodule_label14", (object) this.__mainmodule_label14);
      this.__mainmodule_label12 = new CEnhancedLabel(this);
      this.__mainmodule_label12.name = "__mainmodule_label12";
      this.__mainmodule_label12.Left = 5;
      this.__mainmodule_label12.Top = 76;
      this.__mainmodule_label12.Width = 45;
      this.__mainmodule_label12.Height = 20;
      this.__mainmodule_label12.Text = "Serie:";
      this.__mainmodule_label12.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label12.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label12.MyEnabled = true;
      this.__mainmodule_label12.Visible = true;
      this.__mainmodule_label12.Transparent = false;
      this.__mainmodule_label12.Font = new Font(this.__mainmodule_label12.Font.Name, 9f, this.__mainmodule_label12.Font.Style);
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_label12);
      this.htControls.Add((object) "__mainmodule_label12", (object) this.__mainmodule_label12);
      this.__mainmodule_btnnew = new CEnhancedButton(this);
      this.__mainmodule_btnnew.name = "__mainmodule_btnnew";
      this.__mainmodule_btnnew.Left = 180;
      this.__mainmodule_btnnew.Top = 2;
      this.__mainmodule_btnnew.Width = 36;
      this.__mainmodule_btnnew.Height = 20;
      this.__mainmodule_btnnew.Text = "...";
      this.__mainmodule_btnnew.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnnew.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnnew.Enabled = true;
      this.__mainmodule_btnnew.Visible = true;
      this.__mainmodule_btnnew.Font = new Font(this.__mainmodule_btnnew.Font.Name, 9f, this.__mainmodule_btnnew.Font.Style);
      this.__mainmodule_btnnew.AddEvents();
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_btnnew);
      this.htControls.Add((object) "__mainmodule_btnnew", (object) this.__mainmodule_btnnew);
      this.__mainmodule_label3 = new CEnhancedLabel(this);
      this.__mainmodule_label3.name = "__mainmodule_label3";
      this.__mainmodule_label3.Left = 1;
      this.__mainmodule_label3.Top = 26;
      this.__mainmodule_label3.Width = 52;
      this.__mainmodule_label3.Height = 20;
      this.__mainmodule_label3.Text = "Nombre:";
      this.__mainmodule_label3.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label3.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label3.MyEnabled = true;
      this.__mainmodule_label3.Visible = true;
      this.__mainmodule_label3.Transparent = false;
      this.__mainmodule_label3.Font = new Font(this.__mainmodule_label3.Font.Name, 9f, this.__mainmodule_label3.Font.Style);
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_label3);
      this.htControls.Add((object) "__mainmodule_label3", (object) this.__mainmodule_label3);
      this.__mainmodule_label10 = new CEnhancedLabel(this);
      this.__mainmodule_label10.name = "__mainmodule_label10";
      this.__mainmodule_label10.Left = 1;
      this.__mainmodule_label10.Top = 49;
      this.__mainmodule_label10.Width = 70;
      this.__mainmodule_label10.Height = 20;
      this.__mainmodule_label10.Text = "Contraseña:";
      this.__mainmodule_label10.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label10.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label10.MyEnabled = true;
      this.__mainmodule_label10.Visible = true;
      this.__mainmodule_label10.Transparent = false;
      this.__mainmodule_label10.Font = new Font(this.__mainmodule_label10.Font.Name, 9f, this.__mainmodule_label10.Font.Style);
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_label10);
      this.htControls.Add((object) "__mainmodule_label10", (object) this.__mainmodule_label10);
      this.__mainmodule_label2 = new CEnhancedLabel(this);
      this.__mainmodule_label2.name = "__mainmodule_label2";
      this.__mainmodule_label2.Left = 1;
      this.__mainmodule_label2.Top = 3;
      this.__mainmodule_label2.Width = 54;
      this.__mainmodule_label2.Height = 20;
      this.__mainmodule_label2.Text = "Usuario:";
      this.__mainmodule_label2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label2.MyEnabled = true;
      this.__mainmodule_label2.Visible = true;
      this.__mainmodule_label2.Transparent = false;
      this.__mainmodule_label2.Font = new Font(this.__mainmodule_label2.Font.Name, 9f, this.__mainmodule_label2.Font.Style);
      this.__mainmodule_usuarios.Controls.Add((Control) this.__mainmodule_label2);
      this.htControls.Add((object) "__mainmodule_label2", (object) this.__mainmodule_label2);
      this.__mainmodule_frmtraspasos = new CEnhancedForm(this);
      this.__mainmodule_frmtraspasos.name = "__mainmodule_frmtraspasos";
      this.__mainmodule_frmtraspasos.Text = "Traspasos";
      this.__mainmodule_frmtraspasos.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmtraspasos.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmtraspasos.BackColor), 0, 0, this.__mainmodule_frmtraspasos.Width, this.__mainmodule_frmtraspasos.Height);
      this.__mainmodule_frmtraspasos.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmtraspasos", (object) this.__mainmodule_frmtraspasos);
      this.__mainmodule_cmdimport2 = new CEnhancedButton(this);
      this.__mainmodule_cmdimport2.name = "__mainmodule_cmdimport2";
      this.__mainmodule_cmdimport2.Left = 130;
      this.__mainmodule_cmdimport2.Top = 130;
      this.__mainmodule_cmdimport2.Width = 85;
      this.__mainmodule_cmdimport2.Height = 35;
      this.__mainmodule_cmdimport2.Text = "Cancelar";
      this.__mainmodule_cmdimport2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdimport2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdimport2.Enabled = true;
      this.__mainmodule_cmdimport2.Visible = true;
      this.__mainmodule_cmdimport2.Font = new Font(this.__mainmodule_cmdimport2.Font.Name, 9f, this.__mainmodule_cmdimport2.Font.Style);
      this.__mainmodule_cmdimport2.AddEvents();
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_cmdimport2);
      this.htControls.Add((object) "__mainmodule_cmdimport2", (object) this.__mainmodule_cmdimport2);
      this.__mainmodule_cmdimport1 = new CEnhancedButton(this);
      this.__mainmodule_cmdimport1.name = "__mainmodule_cmdimport1";
      this.__mainmodule_cmdimport1.Left = 30;
      this.__mainmodule_cmdimport1.Top = 130;
      this.__mainmodule_cmdimport1.Width = 85;
      this.__mainmodule_cmdimport1.Height = 35;
      this.__mainmodule_cmdimport1.Text = "Iniciar";
      this.__mainmodule_cmdimport1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdimport1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdimport1.Enabled = true;
      this.__mainmodule_cmdimport1.Visible = true;
      this.__mainmodule_cmdimport1.Font = new Font(this.__mainmodule_cmdimport1.Font.Name, 9f, this.__mainmodule_cmdimport1.Font.Style);
      this.__mainmodule_cmdimport1.AddEvents();
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_cmdimport1);
      this.htControls.Add((object) "__mainmodule_cmdimport1", (object) this.__mainmodule_cmdimport1);
      this.__mainmodule_cbotiendadestino = new CEnhancedCombo(this);
      this.__mainmodule_cbotiendadestino.name = "__mainmodule_cbotiendadestino";
      this.__mainmodule_cbotiendadestino.Left = 60;
      this.__mainmodule_cbotiendadestino.Top = 45;
      this.__mainmodule_cbotiendadestino.Width = 170;
      this.__mainmodule_cbotiendadestino.Height = 22;
      this.__mainmodule_cbotiendadestino.Text = "";
      this.__mainmodule_cbotiendadestino.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cbotiendadestino.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cbotiendadestino.Enabled = true;
      this.__mainmodule_cbotiendadestino.Visible = true;
      this.__mainmodule_cbotiendadestino.Font = new Font(this.__mainmodule_cbotiendadestino.Font.Name, 9f, this.__mainmodule_cbotiendadestino.Font.Style);
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_cbotiendadestino);
      this.htControls.Add((object) "__mainmodule_cbotiendadestino", (object) this.__mainmodule_cbotiendadestino);
      this.__mainmodule_cbotiendadestino.AddEvents();
      this.__mainmodule_label40 = new CEnhancedLabel(this);
      this.__mainmodule_label40.name = "__mainmodule_label40";
      this.__mainmodule_label40.Left = 1;
      this.__mainmodule_label40.Top = 44;
      this.__mainmodule_label40.Width = 60;
      this.__mainmodule_label40.Height = 25;
      this.__mainmodule_label40.Text = "Destino:";
      this.__mainmodule_label40.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label40.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label40.MyEnabled = true;
      this.__mainmodule_label40.Visible = true;
      this.__mainmodule_label40.Transparent = false;
      this.__mainmodule_label40.Font = new Font(this.__mainmodule_label40.Font.Name, 9f, this.__mainmodule_label40.Font.Style);
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_label40);
      this.htControls.Add((object) "__mainmodule_label40", (object) this.__mainmodule_label40);
      this.__mainmodule_cbotiendaorigen = new CEnhancedCombo(this);
      this.__mainmodule_cbotiendaorigen.name = "__mainmodule_cbotiendaorigen";
      this.__mainmodule_cbotiendaorigen.Left = 60;
      this.__mainmodule_cbotiendaorigen.Top = 5;
      this.__mainmodule_cbotiendaorigen.Width = 170;
      this.__mainmodule_cbotiendaorigen.Height = 22;
      this.__mainmodule_cbotiendaorigen.Text = "";
      this.__mainmodule_cbotiendaorigen.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cbotiendaorigen.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cbotiendaorigen.Enabled = true;
      this.__mainmodule_cbotiendaorigen.Visible = true;
      this.__mainmodule_cbotiendaorigen.Font = new Font(this.__mainmodule_cbotiendaorigen.Font.Name, 9f, this.__mainmodule_cbotiendaorigen.Font.Style);
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_cbotiendaorigen);
      this.htControls.Add((object) "__mainmodule_cbotiendaorigen", (object) this.__mainmodule_cbotiendaorigen);
      this.__mainmodule_cbotiendaorigen.AddEvents();
      this.__mainmodule_label36 = new CEnhancedLabel(this);
      this.__mainmodule_label36.name = "__mainmodule_label36";
      this.__mainmodule_label36.Left = 1;
      this.__mainmodule_label36.Top = 4;
      this.__mainmodule_label36.Width = 60;
      this.__mainmodule_label36.Height = 25;
      this.__mainmodule_label36.Text = "Origen:";
      this.__mainmodule_label36.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label36.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label36.MyEnabled = true;
      this.__mainmodule_label36.Visible = true;
      this.__mainmodule_label36.Transparent = false;
      this.__mainmodule_label36.Font = new Font(this.__mainmodule_label36.Font.Name, 9f, this.__mainmodule_label36.Font.Style);
      this.__mainmodule_frmtraspasos.Controls.Add((Control) this.__mainmodule_label36);
      this.htControls.Add((object) "__mainmodule_label36", (object) this.__mainmodule_label36);
      this.__mainmodule_frmexistencias = new CEnhancedForm(this);
      this.__mainmodule_frmexistencias.name = "__mainmodule_frmexistencias";
      this.__mainmodule_frmexistencias.Text = "Existencias Remota SAE6";
      this.__mainmodule_frmexistencias.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmexistencias.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmexistencias.BackColor), 0, 0, this.__mainmodule_frmexistencias.Width, this.__mainmodule_frmexistencias.Height);
      this.__mainmodule_frmexistencias.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmexistencias", (object) this.__mainmodule_frmexistencias);
      this.__mainmodule_lte = new CEnhancedLabel(this);
      this.__mainmodule_lte.name = "__mainmodule_lte";
      this.__mainmodule_lte.Left = 2;
      this.__mainmodule_lte.Top = 110;
      this.__mainmodule_lte.Width = 134;
      this.__mainmodule_lte.Height = 30;
      this.__mainmodule_lte.Text = "";
      this.__mainmodule_lte.BackColor = Color.FromArgb(-397360);
      this.__mainmodule_lte.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lte.MyEnabled = true;
      this.__mainmodule_lte.Visible = true;
      this.__mainmodule_lte.Transparent = false;
      this.__mainmodule_lte.Font = new Font(this.__mainmodule_lte.Font.Name, 14f, this.__mainmodule_lte.Font.Style);
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_lte);
      this.htControls.Add((object) "__mainmodule_lte", (object) this.__mainmodule_lte);
      this.__mainmodule_ltdescr = new CEnhancedLabel(this);
      this.__mainmodule_ltdescr.name = "__mainmodule_ltdescr";
      this.__mainmodule_ltdescr.Left = 2;
      this.__mainmodule_ltdescr.Top = 50;
      this.__mainmodule_ltdescr.Width = 235;
      this.__mainmodule_ltdescr.Height = 55;
      this.__mainmodule_ltdescr.Text = "";
      this.__mainmodule_ltdescr.BackColor = Color.FromArgb(-397360);
      this.__mainmodule_ltdescr.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltdescr.MyEnabled = true;
      this.__mainmodule_ltdescr.Visible = true;
      this.__mainmodule_ltdescr.Transparent = false;
      this.__mainmodule_ltdescr.Font = new Font(this.__mainmodule_ltdescr.Font.Name, 10f, this.__mainmodule_ltdescr.Font.Style);
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_ltdescr);
      this.htControls.Add((object) "__mainmodule_ltdescr", (object) this.__mainmodule_ltdescr);
      this.__mainmodule_ltprec = new CEnhancedLabel(this);
      this.__mainmodule_ltprec.name = "__mainmodule_ltprec";
      this.__mainmodule_ltprec.Left = 137;
      this.__mainmodule_ltprec.Top = 110;
      this.__mainmodule_ltprec.Width = 100;
      this.__mainmodule_ltprec.Height = 30;
      this.__mainmodule_ltprec.Text = "";
      this.__mainmodule_ltprec.BackColor = Color.FromArgb(-397360);
      this.__mainmodule_ltprec.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltprec.MyEnabled = true;
      this.__mainmodule_ltprec.Visible = true;
      this.__mainmodule_ltprec.Transparent = false;
      this.__mainmodule_ltprec.Font = new Font(this.__mainmodule_ltprec.Font.Name, 14f, this.__mainmodule_ltprec.Font.Style);
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_ltprec);
      this.htControls.Add((object) "__mainmodule_ltprec", (object) this.__mainmodule_ltprec);
      this.__mainmodule_btnsalexist = new CEnhancedButton(this);
      this.__mainmodule_btnsalexist.name = "__mainmodule_btnsalexist";
      this.__mainmodule_btnsalexist.Left = 155;
      this.__mainmodule_btnsalexist.Top = 145;
      this.__mainmodule_btnsalexist.Width = 75;
      this.__mainmodule_btnsalexist.Height = 30;
      this.__mainmodule_btnsalexist.Text = "Salir";
      this.__mainmodule_btnsalexist.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsalexist.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsalexist.Enabled = true;
      this.__mainmodule_btnsalexist.Visible = true;
      this.__mainmodule_btnsalexist.Font = new Font(this.__mainmodule_btnsalexist.Font.Name, 9f, this.__mainmodule_btnsalexist.Font.Style);
      this.__mainmodule_btnsalexist.AddEvents();
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_btnsalexist);
      this.htControls.Add((object) "__mainmodule_btnsalexist", (object) this.__mainmodule_btnsalexist);
      this.__mainmodule_tprod = new CEnhancedTextBox(this);
      this.__mainmodule_tprod.name = "__mainmodule_tprod";
      this.__mainmodule_tprod.Left = 5;
      this.__mainmodule_tprod.Top = 20;
      this.__mainmodule_tprod.Width = 210;
      this.__mainmodule_tprod.Text = "";
      this.__mainmodule_tprod.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tprod.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tprod.Enabled = true;
      this.__mainmodule_tprod.Visible = true;
      this.__mainmodule_tprod.Height = 25;
      this.__mainmodule_tprod.Font = new Font(this.__mainmodule_tprod.Font.Name, 10f, this.__mainmodule_tprod.Font.Style);
      this.__mainmodule_tprod.multiline = false;
      this.__mainmodule_tprod.AddEvents();
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_tprod);
      this.htControls.Add((object) "__mainmodule_tprod", (object) this.__mainmodule_tprod);
      this.__mainmodule_label26 = new CEnhancedLabel(this);
      this.__mainmodule_label26.name = "__mainmodule_label26";
      this.__mainmodule_label26.Left = 5;
      this.__mainmodule_label26.Top = 2;
      this.__mainmodule_label26.Width = 75;
      this.__mainmodule_label26.Height = 20;
      this.__mainmodule_label26.Text = "Articulo";
      this.__mainmodule_label26.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label26.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label26.MyEnabled = true;
      this.__mainmodule_label26.Visible = true;
      this.__mainmodule_label26.Transparent = false;
      this.__mainmodule_label26.Font = new Font(this.__mainmodule_label26.Font.Name, 9f, this.__mainmodule_label26.Font.Style);
      this.__mainmodule_frmexistencias.Controls.Add((Control) this.__mainmodule_label26);
      this.htControls.Add((object) "__mainmodule_label26", (object) this.__mainmodule_label26);
      this.__mainmodule_frmexistxlinea = new CEnhancedForm(this);
      this.__mainmodule_frmexistxlinea.name = "__mainmodule_frmexistxlinea";
      this.__mainmodule_frmexistxlinea.Text = "Exist. X Linea";
      this.__mainmodule_frmexistxlinea.BackColor = Color.FromArgb(-66569);
      this.__mainmodule_frmexistxlinea.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmexistxlinea.BackColor), 0, 0, this.__mainmodule_frmexistxlinea.Width, this.__mainmodule_frmexistxlinea.Height);
      this.__mainmodule_frmexistxlinea.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmexistxlinea", (object) this.__mainmodule_frmexistxlinea);
      this.__mainmodule_pnltoper = new CEnhancedPanel(this);
      this.__mainmodule_pnltoper.name = "__mainmodule_pnltoper";
      this.__mainmodule_pnltoper.Left = 158;
      this.__mainmodule_pnltoper.Top = -10;
      this.__mainmodule_pnltoper.Width = 239;
      this.__mainmodule_pnltoper.Height = 253;
      this.__mainmodule_pnltoper.BackColor = Color.FromArgb(-1);
      this.__mainmodule_pnltoper.Enabled = true;
      this.__mainmodule_pnltoper.Visible = false;
      this.__mainmodule_pnltoper.AddEvents();
      this.__mainmodule_frmexistxlinea.Controls.Add((Control) this.__mainmodule_pnltoper);
      this.htControls.Add((object) "__mainmodule_pnltoper", (object) this.__mainmodule_pnltoper);
      this.__mainmodule_btntoperborrar = new CEnhancedButton(this);
      this.__mainmodule_btntoperborrar.name = "__mainmodule_btntoperborrar";
      this.__mainmodule_btntoperborrar.Left = 19;
      this.__mainmodule_btntoperborrar.Top = 200;
      this.__mainmodule_btntoperborrar.Width = 75;
      this.__mainmodule_btntoperborrar.Height = 23;
      this.__mainmodule_btntoperborrar.Text = "Borrar ";
      this.__mainmodule_btntoperborrar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntoperborrar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntoperborrar.Enabled = true;
      this.__mainmodule_btntoperborrar.Visible = true;
      this.__mainmodule_btntoperborrar.Font = new Font(this.__mainmodule_btntoperborrar.Font.Name, 9f, this.__mainmodule_btntoperborrar.Font.Style);
      this.__mainmodule_btntoperborrar.AddEvents();
      this.__mainmodule_pnltoper.Controls.Add((Control) this.__mainmodule_btntoperborrar);
      this.htControls.Add((object) "__mainmodule_btntoperborrar", (object) this.__mainmodule_btntoperborrar);
      this.__mainmodule_ltstop = new CEnhancedLabel(this);
      this.__mainmodule_ltstop.name = "__mainmodule_ltstop";
      this.__mainmodule_ltstop.Left = 162;
      this.__mainmodule_ltstop.Top = 171;
      this.__mainmodule_ltstop.Width = 75;
      this.__mainmodule_ltstop.Height = 25;
      this.__mainmodule_ltstop.Text = "";
      this.__mainmodule_ltstop.BackColor = Color.FromArgb(-1);
      this.__mainmodule_ltstop.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltstop.MyEnabled = true;
      this.__mainmodule_ltstop.Visible = true;
      this.__mainmodule_ltstop.Transparent = false;
      this.__mainmodule_ltstop.Font = new Font(this.__mainmodule_ltstop.Font.Name, 9f, this.__mainmodule_ltstop.Font.Style);
      this.__mainmodule_pnltoper.Controls.Add((Control) this.__mainmodule_ltstop);
      this.htControls.Add((object) "__mainmodule_ltstop", (object) this.__mainmodule_ltstop);
      this.__mainmodule_btntopercerrar = new CEnhancedButton(this);
      this.__mainmodule_btntopercerrar.name = "__mainmodule_btntopercerrar";
      this.__mainmodule_btntopercerrar.Left = 115;
      this.__mainmodule_btntopercerrar.Top = 198;
      this.__mainmodule_btntopercerrar.Width = 75;
      this.__mainmodule_btntopercerrar.Height = 23;
      this.__mainmodule_btntopercerrar.Text = "Salir";
      this.__mainmodule_btntopercerrar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntopercerrar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntopercerrar.Enabled = true;
      this.__mainmodule_btntopercerrar.Visible = true;
      this.__mainmodule_btntopercerrar.Font = new Font(this.__mainmodule_btntopercerrar.Font.Name, 9f, this.__mainmodule_btntopercerrar.Font.Style);
      this.__mainmodule_btntopercerrar.AddEvents();
      this.__mainmodule_pnltoper.Controls.Add((Control) this.__mainmodule_btntopercerrar);
      this.htControls.Add((object) "__mainmodule_btntopercerrar", (object) this.__mainmodule_btntopercerrar);
      this.__mainmodule_tbltoper = new CEnhancedTable(this, "__mainmodule_tbltoper");
      this.__mainmodule_tbltoper.name = "__mainmodule_tbltoper";
      this.__mainmodule_tbltoper.Left = 3;
      this.__mainmodule_tbltoper.Top = 4;
      this.__mainmodule_tbltoper.Width = 234;
      this.__mainmodule_tbltoper.Height = 165;
      this.__mainmodule_tbltoper.Text = "";
      this.__mainmodule_tbltoper.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tbltoper.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tbltoper.Enabled = true;
      this.__mainmodule_tbltoper.Visible = true;
      this.__mainmodule_tbltoper.Font = new Font(this.__mainmodule_tbltoper.Font.Name, 9f, this.__mainmodule_tbltoper.Font.Style);
      this.__mainmodule_tbltoper.AddEvents();
      this.__mainmodule_pnltoper.Controls.Add((Control) this.__mainmodule_tbltoper);
      this.htControls.Add((object) "__mainmodule_tbltoper", (object) this.__mainmodule_tbltoper);
      this.__mainmodule_btntoper2 = new CEnhancedButton(this);
      this.__mainmodule_btntoper2.name = "__mainmodule_btntoper2";
      this.__mainmodule_btntoper2.Left = 105;
      this.__mainmodule_btntoper2.Top = 215;
      this.__mainmodule_btntoper2.Width = 75;
      this.__mainmodule_btntoper2.Height = 25;
      this.__mainmodule_btntoper2.Text = "Salir";
      this.__mainmodule_btntoper2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntoper2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntoper2.Enabled = true;
      this.__mainmodule_btntoper2.Visible = true;
      this.__mainmodule_btntoper2.Font = new Font(this.__mainmodule_btntoper2.Font.Name, 9f, this.__mainmodule_btntoper2.Font.Style);
      this.__mainmodule_btntoper2.AddEvents();
      this.__mainmodule_frmexistxlinea.Controls.Add((Control) this.__mainmodule_btntoper2);
      this.htControls.Add((object) "__mainmodule_btntoper2", (object) this.__mainmodule_btntoper2);
      this.__mainmodule_btntoper1 = new CEnhancedButton(this);
      this.__mainmodule_btntoper1.name = "__mainmodule_btntoper1";
      this.__mainmodule_btntoper1.Left = 15;
      this.__mainmodule_btntoper1.Top = 215;
      this.__mainmodule_btntoper1.Width = 75;
      this.__mainmodule_btntoper1.Height = 25;
      this.__mainmodule_btntoper1.Text = "Partidas";
      this.__mainmodule_btntoper1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntoper1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntoper1.Enabled = true;
      this.__mainmodule_btntoper1.Visible = true;
      this.__mainmodule_btntoper1.Font = new Font(this.__mainmodule_btntoper1.Font.Name, 9f, this.__mainmodule_btntoper1.Font.Style);
      this.__mainmodule_btntoper1.AddEvents();
      this.__mainmodule_frmexistxlinea.Controls.Add((Control) this.__mainmodule_btntoper1);
      this.htControls.Add((object) "__mainmodule_btntoper1", (object) this.__mainmodule_btntoper1);
      this.__mainmodule_tblexisxlinea = new CEnhancedTable(this, "__mainmodule_tblexisxlinea");
      this.__mainmodule_tblexisxlinea.name = "__mainmodule_tblexisxlinea";
      this.__mainmodule_tblexisxlinea.Left = 1;
      this.__mainmodule_tblexisxlinea.Top = 1;
      this.__mainmodule_tblexisxlinea.Width = 240;
      this.__mainmodule_tblexisxlinea.Height = 190;
      this.__mainmodule_tblexisxlinea.Text = "";
      this.__mainmodule_tblexisxlinea.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tblexisxlinea.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tblexisxlinea.Enabled = true;
      this.__mainmodule_tblexisxlinea.Visible = true;
      this.__mainmodule_tblexisxlinea.Font = new Font(this.__mainmodule_tblexisxlinea.Font.Name, 9f, this.__mainmodule_tblexisxlinea.Font.Style);
      this.__mainmodule_tblexisxlinea.AddEvents();
      this.__mainmodule_frmexistxlinea.Controls.Add((Control) this.__mainmodule_tblexisxlinea);
      this.htControls.Add((object) "__mainmodule_tblexisxlinea", (object) this.__mainmodule_tblexisxlinea);
      this.__mainmodule_invencan = new CEnhancedForm(this);
      this.__mainmodule_invencan.name = "__mainmodule_invencan";
      this.__mainmodule_invencan.Text = "Consultas";
      this.__mainmodule_invencan.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_invencan.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_invencan.BackColor), 0, 0, this.__mainmodule_invencan.Width, this.__mainmodule_invencan.Height);
      this.__mainmodule_invencan.AddEvents();
      this.htControls.Add((object) "__mainmodule_invencan", (object) this.__mainmodule_invencan);
      this.__mainmodule_ltsumcan2 = new CEnhancedLabel(this);
      this.__mainmodule_ltsumcan2.name = "__mainmodule_ltsumcan2";
      this.__mainmodule_ltsumcan2.Left = 189;
      this.__mainmodule_ltsumcan2.Top = 168;
      this.__mainmodule_ltsumcan2.Width = 50;
      this.__mainmodule_ltsumcan2.Height = 20;
      this.__mainmodule_ltsumcan2.Text = "";
      this.__mainmodule_ltsumcan2.BackColor = Color.FromArgb(-474893);
      this.__mainmodule_ltsumcan2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsumcan2.MyEnabled = true;
      this.__mainmodule_ltsumcan2.Visible = true;
      this.__mainmodule_ltsumcan2.Transparent = false;
      this.__mainmodule_ltsumcan2.Font = new Font(this.__mainmodule_ltsumcan2.Font.Name, 10f, this.__mainmodule_ltsumcan2.Font.Style);
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_ltsumcan2);
      this.htControls.Add((object) "__mainmodule_ltsumcan2", (object) this.__mainmodule_ltsumcan2);
      this.__mainmodule_ltsum2 = new CEnhancedLabel(this);
      this.__mainmodule_ltsum2.name = "__mainmodule_ltsum2";
      this.__mainmodule_ltsum2.Left = 59;
      this.__mainmodule_ltsum2.Top = 168;
      this.__mainmodule_ltsum2.Width = 55;
      this.__mainmodule_ltsum2.Height = 20;
      this.__mainmodule_ltsum2.Text = "";
      this.__mainmodule_ltsum2.BackColor = Color.FromArgb(-474893);
      this.__mainmodule_ltsum2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsum2.MyEnabled = true;
      this.__mainmodule_ltsum2.Visible = true;
      this.__mainmodule_ltsum2.Transparent = false;
      this.__mainmodule_ltsum2.Font = new Font(this.__mainmodule_ltsum2.Font.Name, 10f, this.__mainmodule_ltsum2.Font.Style);
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_ltsum2);
      this.htControls.Add((object) "__mainmodule_ltsum2", (object) this.__mainmodule_ltsum2);
      this.__mainmodule_ltsumcan = new CEnhancedLabel(this);
      this.__mainmodule_ltsumcan.name = "__mainmodule_ltsumcan";
      this.__mainmodule_ltsumcan.Left = 116;
      this.__mainmodule_ltsumcan.Top = 168;
      this.__mainmodule_ltsumcan.Width = 72;
      this.__mainmodule_ltsumcan.Height = 20;
      this.__mainmodule_ltsumcan.Text = "Cancelados";
      this.__mainmodule_ltsumcan.BackColor = Color.FromArgb(-474893);
      this.__mainmodule_ltsumcan.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsumcan.MyEnabled = true;
      this.__mainmodule_ltsumcan.Visible = true;
      this.__mainmodule_ltsumcan.Transparent = false;
      this.__mainmodule_ltsumcan.Font = new Font(this.__mainmodule_ltsumcan.Font.Name, 9f, this.__mainmodule_ltsumcan.Font.Style);
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_ltsumcan);
      this.htControls.Add((object) "__mainmodule_ltsumcan", (object) this.__mainmodule_ltsumcan);
      this.__mainmodule_ltsum = new CEnhancedLabel(this);
      this.__mainmodule_ltsum.name = "__mainmodule_ltsum";
      this.__mainmodule_ltsum.Left = 2;
      this.__mainmodule_ltsum.Top = 168;
      this.__mainmodule_ltsum.Width = 56;
      this.__mainmodule_ltsum.Height = 20;
      this.__mainmodule_ltsum.Text = "Cantidad:";
      this.__mainmodule_ltsum.BackColor = Color.FromArgb(-474893);
      this.__mainmodule_ltsum.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsum.MyEnabled = true;
      this.__mainmodule_ltsum.Visible = true;
      this.__mainmodule_ltsum.Transparent = false;
      this.__mainmodule_ltsum.Font = new Font(this.__mainmodule_ltsum.Font.Name, 9f, this.__mainmodule_ltsum.Font.Style);
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_ltsum);
      this.htControls.Add((object) "__mainmodule_ltsum", (object) this.__mainmodule_ltsum);
      this.__mainmodule_tcodigo = new CEnhancedTextBox(this);
      this.__mainmodule_tcodigo.name = "__mainmodule_tcodigo";
      this.__mainmodule_tcodigo.Left = 63;
      this.__mainmodule_tcodigo.Top = 20;
      this.__mainmodule_tcodigo.Width = 145;
      this.__mainmodule_tcodigo.Text = "";
      this.__mainmodule_tcodigo.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tcodigo.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tcodigo.Enabled = true;
      this.__mainmodule_tcodigo.Visible = true;
      this.__mainmodule_tcodigo.Height = 22;
      this.__mainmodule_tcodigo.Font = new Font(this.__mainmodule_tcodigo.Font.Name, 9f, this.__mainmodule_tcodigo.Font.Style);
      this.__mainmodule_tcodigo.multiline = false;
      this.__mainmodule_tcodigo.AddEvents();
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_tcodigo);
      this.htControls.Add((object) "__mainmodule_tcodigo", (object) this.__mainmodule_tcodigo);
      this.__mainmodule_tbcaninven = new CEnhancedTable(this, "__mainmodule_tbcaninven");
      this.__mainmodule_tbcaninven.name = "__mainmodule_tbcaninven";
      this.__mainmodule_tbcaninven.Left = 2;
      this.__mainmodule_tbcaninven.Top = 43;
      this.__mainmodule_tbcaninven.Width = 238;
      this.__mainmodule_tbcaninven.Height = 125;
      this.__mainmodule_tbcaninven.Text = "";
      this.__mainmodule_tbcaninven.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tbcaninven.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tbcaninven.Enabled = true;
      this.__mainmodule_tbcaninven.Visible = true;
      this.__mainmodule_tbcaninven.Font = new Font(this.__mainmodule_tbcaninven.Font.Name, 9f, this.__mainmodule_tbcaninven.Font.Style);
      this.__mainmodule_tbcaninven.AddEvents();
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_tbcaninven);
      this.htControls.Add((object) "__mainmodule_tbcaninven", (object) this.__mainmodule_tbcaninven);
      this.__mainmodule_cmdinvc = new CEnhancedButton(this);
      this.__mainmodule_cmdinvc.name = "__mainmodule_cmdinvc";
      this.__mainmodule_cmdinvc.Left = 209;
      this.__mainmodule_cmdinvc.Top = 20;
      this.__mainmodule_cmdinvc.Width = 27;
      this.__mainmodule_cmdinvc.Height = 20;
      this.__mainmodule_cmdinvc.Text = "::::";
      this.__mainmodule_cmdinvc.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdinvc.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdinvc.Enabled = true;
      this.__mainmodule_cmdinvc.Visible = true;
      this.__mainmodule_cmdinvc.Font = new Font(this.__mainmodule_cmdinvc.Font.Name, 9f, this.__mainmodule_cmdinvc.Font.Style);
      this.__mainmodule_cmdinvc.AddEvents();
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_cmdinvc);
      this.htControls.Add((object) "__mainmodule_cmdinvc", (object) this.__mainmodule_cmdinvc);
      this.__mainmodule_label27 = new CEnhancedLabel(this);
      this.__mainmodule_label27.name = "__mainmodule_label27";
      this.__mainmodule_label27.Left = 7;
      this.__mainmodule_label27.Top = 20;
      this.__mainmodule_label27.Width = 49;
      this.__mainmodule_label27.Height = 20;
      this.__mainmodule_label27.Text = "Articulo";
      this.__mainmodule_label27.BackColor = Color.FromArgb(-474893);
      this.__mainmodule_label27.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label27.MyEnabled = true;
      this.__mainmodule_label27.Visible = true;
      this.__mainmodule_label27.Transparent = true;
      this.__mainmodule_label27.Font = new Font(this.__mainmodule_label27.Font.Name, 9f, this.__mainmodule_label27.Font.Style);
      this.__mainmodule_invencan.Controls.Add((Control) this.__mainmodule_label27);
      this.htControls.Add((object) "__mainmodule_label27", (object) this.__mainmodule_label27);
      this.__mainmodule_mnucanc0 = new CEnhancedMenu(this);
      this.__mainmodule_mnucanc0.name = "__mainmodule_mnucanc0";
      this.__mainmodule_mnucanc0.Text = "Menu";
      this.__mainmodule_mnucanc0.Enabled = true;
      this.__mainmodule_mnucanc0.Checked = false;
      this.__mainmodule_mnucanc0.AddToObject("__mainmodule_invencan");
      this.__mainmodule_mnucanc0.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucanc0", (object) this.__mainmodule_mnucanc0);
      this.__mainmodule_mnucan1 = new CEnhancedMenu(this);
      this.__mainmodule_mnucan1.name = "__mainmodule_mnucan1";
      this.__mainmodule_mnucan1.Text = "Cancelar";
      this.__mainmodule_mnucan1.Enabled = true;
      this.__mainmodule_mnucan1.Checked = false;
      this.__mainmodule_mnucan1.AddToObject("__mainmodule_mnucanc0");
      this.__mainmodule_mnucan1.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucan1", (object) this.__mainmodule_mnucan1);
      this.__mainmodule_mnuinvent = new CEnhancedMenu(this);
      this.__mainmodule_mnuinvent.name = "__mainmodule_mnuinvent";
      this.__mainmodule_mnuinvent.Text = "Inventario";
      this.__mainmodule_mnuinvent.Enabled = true;
      this.__mainmodule_mnuinvent.Checked = false;
      this.__mainmodule_mnuinvent.AddToObject("__mainmodule_mnucanc0");
      this.__mainmodule_mnuinvent.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuinvent", (object) this.__mainmodule_mnuinvent);
      this.__mainmodule_mnusalircan = new CEnhancedMenu(this);
      this.__mainmodule_mnusalircan.name = "__mainmodule_mnusalircan";
      this.__mainmodule_mnusalircan.Text = "Salir";
      this.__mainmodule_mnusalircan.Enabled = true;
      this.__mainmodule_mnusalircan.Checked = false;
      this.__mainmodule_mnusalircan.AddToObject("__mainmodule_mnucanc0");
      this.__mainmodule_mnusalircan.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusalircan", (object) this.__mainmodule_mnusalircan);
      this.__mainmodule_frmareas = new CEnhancedForm(this);
      this.__mainmodule_frmareas.name = "__mainmodule_frmareas";
      this.__mainmodule_frmareas.Text = "Areas";
      this.__mainmodule_frmareas.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmareas.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmareas.BackColor), 0, 0, this.__mainmodule_frmareas.Width, this.__mainmodule_frmareas.Height);
      this.__mainmodule_frmareas.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmareas", (object) this.__mainmodule_frmareas);
      this.__mainmodule_pnlareasseries = new CEnhancedPanel(this);
      this.__mainmodule_pnlareasseries.name = "__mainmodule_pnlareasseries";
      this.__mainmodule_pnlareasseries.Left = 20;
      this.__mainmodule_pnlareasseries.Top = 189;
      this.__mainmodule_pnlareasseries.Width = 241;
      this.__mainmodule_pnlareasseries.Height = 189;
      this.__mainmodule_pnlareasseries.BackColor = Color.FromArgb(-7625730);
      this.__mainmodule_pnlareasseries.Enabled = true;
      this.__mainmodule_pnlareasseries.Visible = false;
      this.__mainmodule_pnlareasseries.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_pnlareasseries);
      this.htControls.Add((object) "__mainmodule_pnlareasseries", (object) this.__mainmodule_pnlareasseries);
      this.__mainmodule_cboseriesareas = new CEnhancedCombo(this);
      this.__mainmodule_cboseriesareas.name = "__mainmodule_cboseriesareas";
      this.__mainmodule_cboseriesareas.Left = 156;
      this.__mainmodule_cboseriesareas.Top = 59;
      this.__mainmodule_cboseriesareas.Width = 60;
      this.__mainmodule_cboseriesareas.Height = 25;
      this.__mainmodule_cboseriesareas.Text = "";
      this.__mainmodule_cboseriesareas.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboseriesareas.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboseriesareas.Enabled = true;
      this.__mainmodule_cboseriesareas.Visible = true;
      this.__mainmodule_cboseriesareas.Font = new Font(this.__mainmodule_cboseriesareas.Font.Name, 10f, this.__mainmodule_cboseriesareas.Font.Style);
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_cboseriesareas);
      this.htControls.Add((object) "__mainmodule_cboseriesareas", (object) this.__mainmodule_cboseriesareas);
      this.__mainmodule_cboseriesareas.AddEvents();
      this.__mainmodule_tnotaarea = new CEnhancedTextBox(this);
      this.__mainmodule_tnotaarea.name = "__mainmodule_tnotaarea";
      this.__mainmodule_tnotaarea.Left = 4;
      this.__mainmodule_tnotaarea.Top = 27;
      this.__mainmodule_tnotaarea.Width = 223;
      this.__mainmodule_tnotaarea.Text = "";
      this.__mainmodule_tnotaarea.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tnotaarea.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tnotaarea.Enabled = true;
      this.__mainmodule_tnotaarea.Visible = true;
      this.__mainmodule_tnotaarea.Height = 22;
      this.__mainmodule_tnotaarea.Font = new Font(this.__mainmodule_tnotaarea.Font.Name, 9f, this.__mainmodule_tnotaarea.Font.Style);
      this.__mainmodule_tnotaarea.multiline = false;
      this.__mainmodule_tnotaarea.AddEvents();
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_tnotaarea);
      this.htControls.Add((object) "__mainmodule_tnotaarea", (object) this.__mainmodule_tnotaarea);
      this.__mainmodule_label44 = new CEnhancedLabel(this);
      this.__mainmodule_label44.name = "__mainmodule_label44";
      this.__mainmodule_label44.Left = 4;
      this.__mainmodule_label44.Top = 61;
      this.__mainmodule_label44.Width = 154;
      this.__mainmodule_label44.Height = 20;
      this.__mainmodule_label44.Text = "No. de registros a agregar:";
      this.__mainmodule_label44.BackColor = Color.FromArgb(-7625730);
      this.__mainmodule_label44.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label44.MyEnabled = true;
      this.__mainmodule_label44.Visible = true;
      this.__mainmodule_label44.Transparent = false;
      this.__mainmodule_label44.Font = new Font(this.__mainmodule_label44.Font.Name, 9f, this.__mainmodule_label44.Font.Style);
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_label44);
      this.htControls.Add((object) "__mainmodule_label44", (object) this.__mainmodule_label44);
      this.__mainmodule_ltseries = new CEnhancedLabel(this);
      this.__mainmodule_ltseries.name = "__mainmodule_ltseries";
      this.__mainmodule_ltseries.Left = 1;
      this.__mainmodule_ltseries.Top = 143;
      this.__mainmodule_ltseries.Width = 236;
      this.__mainmodule_ltseries.Height = 49;
      this.__mainmodule_ltseries.Text = "Se agregaran series con la  descripcion indicada en forma consecutiva y se borrara las existentes";
      this.__mainmodule_ltseries.BackColor = Color.FromArgb(-7625730);
      this.__mainmodule_ltseries.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltseries.MyEnabled = true;
      this.__mainmodule_ltseries.Visible = true;
      this.__mainmodule_ltseries.Transparent = false;
      this.__mainmodule_ltseries.Font = new Font(this.__mainmodule_ltseries.Font.Name, 9f, this.__mainmodule_ltseries.Font.Style);
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_ltseries);
      this.htControls.Add((object) "__mainmodule_ltseries", (object) this.__mainmodule_ltseries);
      this.__mainmodule_btnareaserie2 = new CEnhancedButton(this);
      this.__mainmodule_btnareaserie2.name = "__mainmodule_btnareaserie2";
      this.__mainmodule_btnareaserie2.Left = 123;
      this.__mainmodule_btnareaserie2.Top = 100;
      this.__mainmodule_btnareaserie2.Width = 95;
      this.__mainmodule_btnareaserie2.Height = 30;
      this.__mainmodule_btnareaserie2.Text = "Cancelar";
      this.__mainmodule_btnareaserie2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnareaserie2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnareaserie2.Enabled = true;
      this.__mainmodule_btnareaserie2.Visible = true;
      this.__mainmodule_btnareaserie2.Font = new Font(this.__mainmodule_btnareaserie2.Font.Name, 9f, this.__mainmodule_btnareaserie2.Font.Style);
      this.__mainmodule_btnareaserie2.AddEvents();
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_btnareaserie2);
      this.htControls.Add((object) "__mainmodule_btnareaserie2", (object) this.__mainmodule_btnareaserie2);
      this.__mainmodule_btnareaserie1 = new CEnhancedButton(this);
      this.__mainmodule_btnareaserie1.name = "__mainmodule_btnareaserie1";
      this.__mainmodule_btnareaserie1.Left = 12;
      this.__mainmodule_btnareaserie1.Top = 100;
      this.__mainmodule_btnareaserie1.Width = 95;
      this.__mainmodule_btnareaserie1.Height = 30;
      this.__mainmodule_btnareaserie1.Text = "Agregar";
      this.__mainmodule_btnareaserie1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnareaserie1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnareaserie1.Enabled = true;
      this.__mainmodule_btnareaserie1.Visible = true;
      this.__mainmodule_btnareaserie1.Font = new Font(this.__mainmodule_btnareaserie1.Font.Name, 9f, this.__mainmodule_btnareaserie1.Font.Style);
      this.__mainmodule_btnareaserie1.AddEvents();
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_btnareaserie1);
      this.htControls.Add((object) "__mainmodule_btnareaserie1", (object) this.__mainmodule_btnareaserie1);
      this.__mainmodule_label42 = new CEnhancedLabel(this);
      this.__mainmodule_label42.name = "__mainmodule_label42";
      this.__mainmodule_label42.Left = 4;
      this.__mainmodule_label42.Top = 7;
      this.__mainmodule_label42.Width = 95;
      this.__mainmodule_label42.Height = 20;
      this.__mainmodule_label42.Text = "Nombre Area:";
      this.__mainmodule_label42.BackColor = Color.FromArgb(-7625730);
      this.__mainmodule_label42.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label42.MyEnabled = true;
      this.__mainmodule_label42.Visible = true;
      this.__mainmodule_label42.Transparent = false;
      this.__mainmodule_label42.Font = new Font(this.__mainmodule_label42.Font.Name, 9f, this.__mainmodule_label42.Font.Style);
      this.__mainmodule_pnlareasseries.Controls.Add((Control) this.__mainmodule_label42);
      this.htControls.Add((object) "__mainmodule_label42", (object) this.__mainmodule_label42);
      this.__mainmodule_tareanombre = new CEnhancedTextBox(this);
      this.__mainmodule_tareanombre.name = "__mainmodule_tareanombre";
      this.__mainmodule_tareanombre.Left = 47;
      this.__mainmodule_tareanombre.Top = 33;
      this.__mainmodule_tareanombre.Width = 150;
      this.__mainmodule_tareanombre.Text = "";
      this.__mainmodule_tareanombre.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tareanombre.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tareanombre.Enabled = true;
      this.__mainmodule_tareanombre.Visible = true;
      this.__mainmodule_tareanombre.Height = 22;
      this.__mainmodule_tareanombre.Font = new Font(this.__mainmodule_tareanombre.Font.Name, 9f, this.__mainmodule_tareanombre.Font.Style);
      this.__mainmodule_tareanombre.multiline = false;
      this.__mainmodule_tareanombre.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_tareanombre);
      this.htControls.Add((object) "__mainmodule_tareanombre", (object) this.__mainmodule_tareanombre);
      this.__mainmodule_ltarea = new CEnhancedLabel(this);
      this.__mainmodule_ltarea.name = "__mainmodule_ltarea";
      this.__mainmodule_ltarea.Left = 198;
      this.__mainmodule_ltarea.Top = 35;
      this.__mainmodule_ltarea.Width = 46;
      this.__mainmodule_ltarea.Height = 20;
      this.__mainmodule_ltarea.Text = "Nombre area";
      this.__mainmodule_ltarea.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltarea.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltarea.MyEnabled = true;
      this.__mainmodule_ltarea.Visible = true;
      this.__mainmodule_ltarea.Transparent = false;
      this.__mainmodule_ltarea.Font = new Font(this.__mainmodule_ltarea.Font.Name, 9f, this.__mainmodule_ltarea.Font.Style);
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_ltarea);
      this.htControls.Add((object) "__mainmodule_ltarea", (object) this.__mainmodule_ltarea);
      this.__mainmodule_btnareagrabar = new CEnhancedButton(this);
      this.__mainmodule_btnareagrabar.name = "__mainmodule_btnareagrabar";
      this.__mainmodule_btnareagrabar.Left = 180;
      this.__mainmodule_btnareagrabar.Top = 58;
      this.__mainmodule_btnareagrabar.Width = 50;
      this.__mainmodule_btnareagrabar.Height = 22;
      this.__mainmodule_btnareagrabar.Text = "Grabar";
      this.__mainmodule_btnareagrabar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnareagrabar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnareagrabar.Enabled = true;
      this.__mainmodule_btnareagrabar.Visible = true;
      this.__mainmodule_btnareagrabar.Font = new Font(this.__mainmodule_btnareagrabar.Font.Name, 9f, this.__mainmodule_btnareagrabar.Font.Style);
      this.__mainmodule_btnareagrabar.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_btnareagrabar);
      this.htControls.Add((object) "__mainmodule_btnareagrabar", (object) this.__mainmodule_btnareagrabar);
      this.__mainmodule_btneliminar = new CEnhancedButton(this);
      this.__mainmodule_btneliminar.name = "__mainmodule_btneliminar";
      this.__mainmodule_btneliminar.Left = 115;
      this.__mainmodule_btneliminar.Top = 58;
      this.__mainmodule_btneliminar.Width = 50;
      this.__mainmodule_btneliminar.Height = 22;
      this.__mainmodule_btneliminar.Text = "Borrar";
      this.__mainmodule_btneliminar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btneliminar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btneliminar.Enabled = true;
      this.__mainmodule_btneliminar.Visible = true;
      this.__mainmodule_btneliminar.Font = new Font(this.__mainmodule_btneliminar.Font.Name, 9f, this.__mainmodule_btneliminar.Font.Style);
      this.__mainmodule_btneliminar.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_btneliminar);
      this.htControls.Add((object) "__mainmodule_btneliminar", (object) this.__mainmodule_btneliminar);
      this.__mainmodule_btnareanew = new CEnhancedButton(this);
      this.__mainmodule_btnareanew.name = "__mainmodule_btnareanew";
      this.__mainmodule_btnareanew.Left = 51;
      this.__mainmodule_btnareanew.Top = 58;
      this.__mainmodule_btnareanew.Width = 50;
      this.__mainmodule_btnareanew.Height = 22;
      this.__mainmodule_btnareanew.Text = "Nuevo";
      this.__mainmodule_btnareanew.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnareanew.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnareanew.Enabled = true;
      this.__mainmodule_btnareanew.Visible = true;
      this.__mainmodule_btnareanew.Font = new Font(this.__mainmodule_btnareanew.Font.Name, 9f, this.__mainmodule_btnareanew.Font.Style);
      this.__mainmodule_btnareanew.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_btnareanew);
      this.htControls.Add((object) "__mainmodule_btnareanew", (object) this.__mainmodule_btnareanew);
      this.__mainmodule_btnarea2 = new CEnhancedButton(this);
      this.__mainmodule_btnarea2.name = "__mainmodule_btnarea2";
      this.__mainmodule_btnarea2.Left = 175;
      this.__mainmodule_btnarea2.Top = 2;
      this.__mainmodule_btnarea2.Width = 61;
      this.__mainmodule_btnarea2.Height = 27;
      this.__mainmodule_btnarea2.Text = "Salir";
      this.__mainmodule_btnarea2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnarea2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnarea2.Enabled = true;
      this.__mainmodule_btnarea2.Visible = true;
      this.__mainmodule_btnarea2.Font = new Font(this.__mainmodule_btnarea2.Font.Name, 9f, this.__mainmodule_btnarea2.Font.Style);
      this.__mainmodule_btnarea2.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_btnarea2);
      this.htControls.Add((object) "__mainmodule_btnarea2", (object) this.__mainmodule_btnarea2);
      this.__mainmodule_tblareas = new CEnhancedTable(this, "__mainmodule_tblareas");
      this.__mainmodule_tblareas.name = "__mainmodule_tblareas";
      this.__mainmodule_tblareas.Left = 1;
      this.__mainmodule_tblareas.Top = 81;
      this.__mainmodule_tblareas.Width = 237;
      this.__mainmodule_tblareas.Height = 112;
      this.__mainmodule_tblareas.Text = "";
      this.__mainmodule_tblareas.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tblareas.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tblareas.Enabled = true;
      this.__mainmodule_tblareas.Visible = true;
      this.__mainmodule_tblareas.Font = new Font(this.__mainmodule_tblareas.Font.Name, 9f, this.__mainmodule_tblareas.Font.Style);
      this.__mainmodule_tblareas.AddEvents();
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_tblareas);
      this.htControls.Add((object) "__mainmodule_tblareas", (object) this.__mainmodule_tblareas);
      this.__mainmodule_label43 = new CEnhancedLabel(this);
      this.__mainmodule_label43.name = "__mainmodule_label43";
      this.__mainmodule_label43.Left = 1;
      this.__mainmodule_label43.Top = 36;
      this.__mainmodule_label43.Width = 55;
      this.__mainmodule_label43.Height = 18;
      this.__mainmodule_label43.Text = "Nombre";
      this.__mainmodule_label43.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label43.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label43.MyEnabled = true;
      this.__mainmodule_label43.Visible = true;
      this.__mainmodule_label43.Transparent = false;
      this.__mainmodule_label43.Font = new Font(this.__mainmodule_label43.Font.Name, 9f, this.__mainmodule_label43.Font.Style);
      this.__mainmodule_frmareas.Controls.Add((Control) this.__mainmodule_label43);
      this.htControls.Add((object) "__mainmodule_label43", (object) this.__mainmodule_label43);
      this.__mainmodule_mnuarchivoareas = new CEnhancedMenu(this);
      this.__mainmodule_mnuarchivoareas.name = "__mainmodule_mnuarchivoareas";
      this.__mainmodule_mnuarchivoareas.Text = "Archivo";
      this.__mainmodule_mnuarchivoareas.Enabled = true;
      this.__mainmodule_mnuarchivoareas.Checked = false;
      this.__mainmodule_mnuarchivoareas.AddToObject("__mainmodule_frmareas");
      this.__mainmodule_mnuarchivoareas.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuarchivoareas", (object) this.__mainmodule_mnuarchivoareas);
      this.__mainmodule_mnuareas1 = new CEnhancedMenu(this);
      this.__mainmodule_mnuareas1.name = "__mainmodule_mnuareas1";
      this.__mainmodule_mnuareas1.Text = "Agregar areas";
      this.__mainmodule_mnuareas1.Enabled = true;
      this.__mainmodule_mnuareas1.Checked = false;
      this.__mainmodule_mnuareas1.AddToObject("__mainmodule_mnuarchivoareas");
      this.__mainmodule_mnuareas1.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuareas1", (object) this.__mainmodule_mnuareas1);
      this.__mainmodule_mnuborrarareas = new CEnhancedMenu(this);
      this.__mainmodule_mnuborrarareas.name = "__mainmodule_mnuborrarareas";
      this.__mainmodule_mnuborrarareas.Text = "Borrar Areas";
      this.__mainmodule_mnuborrarareas.Enabled = true;
      this.__mainmodule_mnuborrarareas.Checked = false;
      this.__mainmodule_mnuborrarareas.AddToObject("__mainmodule_mnuarchivoareas");
      this.__mainmodule_mnuborrarareas.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuborrarareas", (object) this.__mainmodule_mnuborrarareas);
      this.__mainmodule_frmclientes = new CEnhancedForm(this);
      this.__mainmodule_frmclientes.name = "__mainmodule_frmclientes";
      this.__mainmodule_frmclientes.Text = "Clientes";
      this.__mainmodule_frmclientes.BackColor = Color.FromArgb(-8344071);
      this.__mainmodule_frmclientes.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmclientes.BackColor), 0, 0, this.__mainmodule_frmclientes.Width, this.__mainmodule_frmclientes.Height);
      this.__mainmodule_frmclientes.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmclientes", (object) this.__mainmodule_frmclientes);
      this.__mainmodule_tcliente = new CEnhancedTextBox(this);
      this.__mainmodule_tcliente.name = "__mainmodule_tcliente";
      this.__mainmodule_tcliente.Left = 1;
      this.__mainmodule_tcliente.Top = 4;
      this.__mainmodule_tcliente.Width = 175;
      this.__mainmodule_tcliente.Text = "";
      this.__mainmodule_tcliente.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tcliente.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tcliente.Enabled = true;
      this.__mainmodule_tcliente.Visible = true;
      this.__mainmodule_tcliente.Height = 22;
      this.__mainmodule_tcliente.Font = new Font(this.__mainmodule_tcliente.Font.Name, 9f, this.__mainmodule_tcliente.Font.Style);
      this.__mainmodule_tcliente.multiline = false;
      this.__mainmodule_tcliente.AddEvents();
      this.__mainmodule_frmclientes.Controls.Add((Control) this.__mainmodule_tcliente);
      this.htControls.Add((object) "__mainmodule_tcliente", (object) this.__mainmodule_tcliente);
      this.__mainmodule_tabla = new CEnhancedTable(this, "__mainmodule_tabla");
      this.__mainmodule_tabla.name = "__mainmodule_tabla";
      this.__mainmodule_tabla.Left = 0;
      this.__mainmodule_tabla.Top = 30;
      this.__mainmodule_tabla.Width = 238;
      this.__mainmodule_tabla.Height = 235;
      this.__mainmodule_tabla.Text = "";
      this.__mainmodule_tabla.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tabla.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tabla.Enabled = true;
      this.__mainmodule_tabla.Visible = false;
      this.__mainmodule_tabla.Font = new Font(this.__mainmodule_tabla.Font.Name, 9f, this.__mainmodule_tabla.Font.Style);
      this.__mainmodule_tabla.AddEvents();
      this.__mainmodule_frmclientes.Controls.Add((Control) this.__mainmodule_tabla);
      this.htControls.Add((object) "__mainmodule_tabla", (object) this.__mainmodule_tabla);
      this.__mainmodule_cmdbuscar = new CEnhancedButton(this);
      this.__mainmodule_cmdbuscar.name = "__mainmodule_cmdbuscar";
      this.__mainmodule_cmdbuscar.Left = 185;
      this.__mainmodule_cmdbuscar.Top = 3;
      this.__mainmodule_cmdbuscar.Width = 48;
      this.__mainmodule_cmdbuscar.Height = 25;
      this.__mainmodule_cmdbuscar.Text = "Buscar";
      this.__mainmodule_cmdbuscar.BackColor = Color.FromArgb(-197899);
      this.__mainmodule_cmdbuscar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdbuscar.Enabled = true;
      this.__mainmodule_cmdbuscar.Visible = true;
      this.__mainmodule_cmdbuscar.Font = new Font(this.__mainmodule_cmdbuscar.Font.Name, 8f, this.__mainmodule_cmdbuscar.Font.Style);
      this.__mainmodule_cmdbuscar.AddEvents();
      this.__mainmodule_frmclientes.Controls.Add((Control) this.__mainmodule_cmdbuscar);
      this.htControls.Add((object) "__mainmodule_cmdbuscar", (object) this.__mainmodule_cmdbuscar);
      this.__mainmodule_mnuctep = new CEnhancedMenu(this);
      this.__mainmodule_mnuctep.name = "__mainmodule_mnuctep";
      this.__mainmodule_mnuctep.Text = "Archivo";
      this.__mainmodule_mnuctep.Enabled = true;
      this.__mainmodule_mnuctep.Checked = false;
      this.__mainmodule_mnuctep.AddToObject("__mainmodule_frmclientes");
      this.__mainmodule_mnuctep.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuctep", (object) this.__mainmodule_mnuctep);
      this.__mainmodule_mnucte1 = new CEnhancedMenu(this);
      this.__mainmodule_mnucte1.name = "__mainmodule_mnucte1";
      this.__mainmodule_mnucte1.Text = "Alta de cliente";
      this.__mainmodule_mnucte1.Enabled = true;
      this.__mainmodule_mnucte1.Checked = false;
      this.__mainmodule_mnucte1.AddToObject("__mainmodule_mnuctep");
      this.__mainmodule_mnucte1.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucte1", (object) this.__mainmodule_mnucte1);
      this.__mainmodule_mnucte2 = new CEnhancedMenu(this);
      this.__mainmodule_mnucte2.name = "__mainmodule_mnucte2";
      this.__mainmodule_mnucte2.Text = "Teclado";
      this.__mainmodule_mnucte2.Enabled = true;
      this.__mainmodule_mnucte2.Checked = false;
      this.__mainmodule_mnucte2.AddToObject("__mainmodule_mnuctep");
      this.__mainmodule_mnucte2.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucte2", (object) this.__mainmodule_mnucte2);
      this.__mainmodule_mnucte3 = new CEnhancedMenu(this);
      this.__mainmodule_mnucte3.name = "__mainmodule_mnucte3";
      this.__mainmodule_mnucte3.Text = "Salir";
      this.__mainmodule_mnucte3.Enabled = true;
      this.__mainmodule_mnucte3.Checked = false;
      this.__mainmodule_mnucte3.AddToObject("__mainmodule_mnuctep");
      this.__mainmodule_mnucte3.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucte3", (object) this.__mainmodule_mnucte3);
      this.__mainmodule_gencompra = new CEnhancedForm(this);
      this.__mainmodule_gencompra.name = "__mainmodule_gencompra";
      this.__mainmodule_gencompra.Text = "Generar compra";
      this.__mainmodule_gencompra.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_gencompra.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_gencompra.BackColor), 0, 0, this.__mainmodule_gencompra.Width, this.__mainmodule_gencompra.Height);
      this.__mainmodule_gencompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_gencompra", (object) this.__mainmodule_gencompra);
      this.__mainmodule_chenviartodascompras = new CEnhancedCheckBox(this);
      this.__mainmodule_chenviartodascompras.name = "__mainmodule_chenviartodascompras";
      this.__mainmodule_chenviartodascompras.Left = 10;
      this.__mainmodule_chenviartodascompras.Top = 90;
      this.__mainmodule_chenviartodascompras.Width = 215;
      this.__mainmodule_chenviartodascompras.Height = 25;
      this.__mainmodule_chenviartodascompras.Text = "Enviar todos los documentos";
      this.__mainmodule_chenviartodascompras.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_chenviartodascompras.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chenviartodascompras.Enabled = true;
      this.__mainmodule_chenviartodascompras.Visible = true;
      this.__mainmodule_chenviartodascompras.Checked = false;
      this.__mainmodule_chenviartodascompras.Font = new Font(this.__mainmodule_chenviartodascompras.Font.Name, 9f, this.__mainmodule_chenviartodascompras.Font.Style);
      this.__mainmodule_chenviartodascompras.AddEvents();
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_chenviartodascompras);
      this.htControls.Add((object) "__mainmodule_chenviartodascompras", (object) this.__mainmodule_chenviartodascompras);
      this.__mainmodule_cbocompra = new CEnhancedCombo(this);
      this.__mainmodule_cbocompra.name = "__mainmodule_cbocompra";
      this.__mainmodule_cbocompra.Left = 50;
      this.__mainmodule_cbocompra.Top = 56;
      this.__mainmodule_cbocompra.Width = 183;
      this.__mainmodule_cbocompra.Height = 22;
      this.__mainmodule_cbocompra.Text = "";
      this.__mainmodule_cbocompra.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cbocompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cbocompra.Enabled = true;
      this.__mainmodule_cbocompra.Visible = true;
      this.__mainmodule_cbocompra.Font = new Font(this.__mainmodule_cbocompra.Font.Name, 9f, this.__mainmodule_cbocompra.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_cbocompra);
      this.htControls.Add((object) "__mainmodule_cbocompra", (object) this.__mainmodule_cbocompra);
      this.__mainmodule_cbocompra.AddEvents();
      this.__mainmodule_ltcomreg = new CEnhancedLabel(this);
      this.__mainmodule_ltcomreg.name = "__mainmodule_ltcomreg";
      this.__mainmodule_ltcomreg.Left = 160;
      this.__mainmodule_ltcomreg.Top = 165;
      this.__mainmodule_ltcomreg.Width = 70;
      this.__mainmodule_ltcomreg.Height = 20;
      this.__mainmodule_ltcomreg.Text = "";
      this.__mainmodule_ltcomreg.BackColor = Color.FromArgb(-464446);
      this.__mainmodule_ltcomreg.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltcomreg.MyEnabled = true;
      this.__mainmodule_ltcomreg.Visible = true;
      this.__mainmodule_ltcomreg.Transparent = false;
      this.__mainmodule_ltcomreg.Font = new Font(this.__mainmodule_ltcomreg.Font.Name, 9f, this.__mainmodule_ltcomreg.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_ltcomreg);
      this.htControls.Add((object) "__mainmodule_ltcomreg", (object) this.__mainmodule_ltcomreg);
      this.__mainmodule_label34 = new CEnhancedLabel(this);
      this.__mainmodule_label34.name = "__mainmodule_label34";
      this.__mainmodule_label34.Left = 100;
      this.__mainmodule_label34.Top = 167;
      this.__mainmodule_label34.Width = 65;
      this.__mainmodule_label34.Height = 20;
      this.__mainmodule_label34.Text = "Registros:";
      this.__mainmodule_label34.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label34.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label34.MyEnabled = true;
      this.__mainmodule_label34.Visible = true;
      this.__mainmodule_label34.Transparent = false;
      this.__mainmodule_label34.Font = new Font(this.__mainmodule_label34.Font.Name, 9f, this.__mainmodule_label34.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_label34);
      this.htControls.Add((object) "__mainmodule_label34", (object) this.__mainmodule_label34);
      this.__mainmodule_label31 = new CEnhancedLabel(this);
      this.__mainmodule_label31.name = "__mainmodule_label31";
      this.__mainmodule_label31.Left = 1;
      this.__mainmodule_label31.Top = 167;
      this.__mainmodule_label31.Width = 40;
      this.__mainmodule_label31.Height = 20;
      this.__mainmodule_label31.Text = "Cant.:";
      this.__mainmodule_label31.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label31.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label31.MyEnabled = true;
      this.__mainmodule_label31.Visible = true;
      this.__mainmodule_label31.Transparent = false;
      this.__mainmodule_label31.Font = new Font(this.__mainmodule_label31.Font.Name, 9f, this.__mainmodule_label31.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_label31);
      this.htControls.Add((object) "__mainmodule_label31", (object) this.__mainmodule_label31);
      this.__mainmodule_ltcomcant = new CEnhancedLabel(this);
      this.__mainmodule_ltcomcant.name = "__mainmodule_ltcomcant";
      this.__mainmodule_ltcomcant.Left = 40;
      this.__mainmodule_ltcomcant.Top = 165;
      this.__mainmodule_ltcomcant.Width = 60;
      this.__mainmodule_ltcomcant.Height = 20;
      this.__mainmodule_ltcomcant.Text = "";
      this.__mainmodule_ltcomcant.BackColor = Color.FromArgb(-464446);
      this.__mainmodule_ltcomcant.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltcomcant.MyEnabled = true;
      this.__mainmodule_ltcomcant.Visible = true;
      this.__mainmodule_ltcomcant.Transparent = false;
      this.__mainmodule_ltcomcant.Font = new Font(this.__mainmodule_ltcomcant.Font.Name, 9f, this.__mainmodule_ltcomcant.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_ltcomcant);
      this.htControls.Add((object) "__mainmodule_ltcomcant", (object) this.__mainmodule_ltcomcant);
      this.__mainmodule_ltcomart = new CEnhancedLabel(this);
      this.__mainmodule_ltcomart.name = "__mainmodule_ltcomart";
      this.__mainmodule_ltcomart.Left = 50;
      this.__mainmodule_ltcomart.Top = 140;
      this.__mainmodule_ltcomart.Width = 180;
      this.__mainmodule_ltcomart.Height = 20;
      this.__mainmodule_ltcomart.Text = "";
      this.__mainmodule_ltcomart.BackColor = Color.FromArgb(-464446);
      this.__mainmodule_ltcomart.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltcomart.MyEnabled = true;
      this.__mainmodule_ltcomart.Visible = true;
      this.__mainmodule_ltcomart.Transparent = false;
      this.__mainmodule_ltcomart.Font = new Font(this.__mainmodule_ltcomart.Font.Name, 9f, this.__mainmodule_ltcomart.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_ltcomart);
      this.htControls.Add((object) "__mainmodule_ltcomart", (object) this.__mainmodule_ltcomart);
      this.__mainmodule_label29 = new CEnhancedLabel(this);
      this.__mainmodule_label29.name = "__mainmodule_label29";
      this.__mainmodule_label29.Left = 1;
      this.__mainmodule_label29.Top = 140;
      this.__mainmodule_label29.Width = 55;
      this.__mainmodule_label29.Height = 20;
      this.__mainmodule_label29.Text = "Articulo:";
      this.__mainmodule_label29.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label29.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label29.MyEnabled = true;
      this.__mainmodule_label29.Visible = true;
      this.__mainmodule_label29.Transparent = false;
      this.__mainmodule_label29.Font = new Font(this.__mainmodule_label29.Font.Name, 9f, this.__mainmodule_label29.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_label29);
      this.htControls.Add((object) "__mainmodule_label29", (object) this.__mainmodule_label29);
      this.__mainmodule_ltconcepto = new CEnhancedLabel(this);
      this.__mainmodule_ltconcepto.name = "__mainmodule_ltconcepto";
      this.__mainmodule_ltconcepto.Left = 10;
      this.__mainmodule_ltconcepto.Top = 200;
      this.__mainmodule_ltconcepto.Width = 180;
      this.__mainmodule_ltconcepto.Height = 20;
      this.__mainmodule_ltconcepto.Text = "Concepto:";
      this.__mainmodule_ltconcepto.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltconcepto.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltconcepto.MyEnabled = true;
      this.__mainmodule_ltconcepto.Visible = true;
      this.__mainmodule_ltconcepto.Transparent = false;
      this.__mainmodule_ltconcepto.Font = new Font(this.__mainmodule_ltconcepto.Font.Name, 9f, this.__mainmodule_ltconcepto.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_ltconcepto);
      this.htControls.Add((object) "__mainmodule_ltconcepto", (object) this.__mainmodule_ltconcepto);
      this.__mainmodule_ltfoliocompra = new CEnhancedLabel(this);
      this.__mainmodule_ltfoliocompra.name = "__mainmodule_ltfoliocompra";
      this.__mainmodule_ltfoliocompra.Left = 8;
      this.__mainmodule_ltfoliocompra.Top = 56;
      this.__mainmodule_ltfoliocompra.Width = 72;
      this.__mainmodule_ltfoliocompra.Height = 20;
      this.__mainmodule_ltfoliocompra.Text = "Folio:";
      this.__mainmodule_ltfoliocompra.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltfoliocompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltfoliocompra.MyEnabled = true;
      this.__mainmodule_ltfoliocompra.Visible = true;
      this.__mainmodule_ltfoliocompra.Transparent = false;
      this.__mainmodule_ltfoliocompra.Font = new Font(this.__mainmodule_ltfoliocompra.Font.Name, 9f, this.__mainmodule_ltfoliocompra.Font.Style);
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_ltfoliocompra);
      this.htControls.Add((object) "__mainmodule_ltfoliocompra", (object) this.__mainmodule_ltfoliocompra);
      this.__mainmodule_btnsalirgencompra = new CEnhancedButton(this);
      this.__mainmodule_btnsalirgencompra.name = "__mainmodule_btnsalirgencompra";
      this.__mainmodule_btnsalirgencompra.Left = 190;
      this.__mainmodule_btnsalirgencompra.Top = 18;
      this.__mainmodule_btnsalirgencompra.Width = 45;
      this.__mainmodule_btnsalirgencompra.Height = 25;
      this.__mainmodule_btnsalirgencompra.Text = "Salir";
      this.__mainmodule_btnsalirgencompra.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsalirgencompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsalirgencompra.Enabled = true;
      this.__mainmodule_btnsalirgencompra.Visible = true;
      this.__mainmodule_btnsalirgencompra.Font = new Font(this.__mainmodule_btnsalirgencompra.Font.Name, 9f, this.__mainmodule_btnsalirgencompra.Font.Style);
      this.__mainmodule_btnsalirgencompra.AddEvents();
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_btnsalirgencompra);
      this.htControls.Add((object) "__mainmodule_btnsalirgencompra", (object) this.__mainmodule_btnsalirgencompra);
      this.__mainmodule_btngencompra = new CEnhancedButton(this);
      this.__mainmodule_btngencompra.name = "__mainmodule_btngencompra";
      this.__mainmodule_btngencompra.Left = 2;
      this.__mainmodule_btngencompra.Top = 10;
      this.__mainmodule_btngencompra.Width = 170;
      this.__mainmodule_btngencompra.Height = 30;
      this.__mainmodule_btngencompra.Text = "Generar orden de compra";
      this.__mainmodule_btngencompra.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btngencompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btngencompra.Enabled = true;
      this.__mainmodule_btngencompra.Visible = true;
      this.__mainmodule_btngencompra.Font = new Font(this.__mainmodule_btngencompra.Font.Name, 9f, this.__mainmodule_btngencompra.Font.Style);
      this.__mainmodule_btngencompra.AddEvents();
      this.__mainmodule_gencompra.Controls.Add((Control) this.__mainmodule_btngencompra);
      this.htControls.Add((object) "__mainmodule_btngencompra", (object) this.__mainmodule_btngencompra);
      this.__mainmodule_genpedido = new CEnhancedForm(this);
      this.__mainmodule_genpedido.name = "__mainmodule_genpedido";
      this.__mainmodule_genpedido.Text = "Generar pedido";
      this.__mainmodule_genpedido.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_genpedido.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_genpedido.BackColor), 0, 0, this.__mainmodule_genpedido.Width, this.__mainmodule_genpedido.Height);
      this.__mainmodule_genpedido.AddEvents();
      this.htControls.Add((object) "__mainmodule_genpedido", (object) this.__mainmodule_genpedido);
      this.__mainmodule_chenviartodospedidos = new CEnhancedCheckBox(this);
      this.__mainmodule_chenviartodospedidos.name = "__mainmodule_chenviartodospedidos";
      this.__mainmodule_chenviartodospedidos.Left = 5;
      this.__mainmodule_chenviartodospedidos.Top = 95;
      this.__mainmodule_chenviartodospedidos.Width = 215;
      this.__mainmodule_chenviartodospedidos.Height = 25;
      this.__mainmodule_chenviartodospedidos.Text = "Enviar todos los documentos";
      this.__mainmodule_chenviartodospedidos.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_chenviartodospedidos.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chenviartodospedidos.Enabled = true;
      this.__mainmodule_chenviartodospedidos.Visible = true;
      this.__mainmodule_chenviartodospedidos.Checked = false;
      this.__mainmodule_chenviartodospedidos.Font = new Font(this.__mainmodule_chenviartodospedidos.Font.Name, 9f, this.__mainmodule_chenviartodospedidos.Font.Style);
      this.__mainmodule_chenviartodospedidos.AddEvents();
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_chenviartodospedidos);
      this.htControls.Add((object) "__mainmodule_chenviartodospedidos", (object) this.__mainmodule_chenviartodospedidos);
      this.__mainmodule_btnsalirpedido = new CEnhancedButton(this);
      this.__mainmodule_btnsalirpedido.name = "__mainmodule_btnsalirpedido";
      this.__mainmodule_btnsalirpedido.Left = 185;
      this.__mainmodule_btnsalirpedido.Top = 15;
      this.__mainmodule_btnsalirpedido.Width = 55;
      this.__mainmodule_btnsalirpedido.Height = 29;
      this.__mainmodule_btnsalirpedido.Text = "Salir";
      this.__mainmodule_btnsalirpedido.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsalirpedido.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsalirpedido.Enabled = true;
      this.__mainmodule_btnsalirpedido.Visible = true;
      this.__mainmodule_btnsalirpedido.Font = new Font(this.__mainmodule_btnsalirpedido.Font.Name, 9f, this.__mainmodule_btnsalirpedido.Font.Style);
      this.__mainmodule_btnsalirpedido.AddEvents();
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_btnsalirpedido);
      this.htControls.Add((object) "__mainmodule_btnsalirpedido", (object) this.__mainmodule_btnsalirpedido);
      this.__mainmodule_btngenpedido = new CEnhancedButton(this);
      this.__mainmodule_btngenpedido.name = "__mainmodule_btngenpedido";
      this.__mainmodule_btngenpedido.Left = 5;
      this.__mainmodule_btngenpedido.Top = 5;
      this.__mainmodule_btngenpedido.Width = 135;
      this.__mainmodule_btngenpedido.Height = 35;
      this.__mainmodule_btngenpedido.Text = "Generar pedido";
      this.__mainmodule_btngenpedido.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btngenpedido.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btngenpedido.Enabled = true;
      this.__mainmodule_btngenpedido.Visible = true;
      this.__mainmodule_btngenpedido.Font = new Font(this.__mainmodule_btngenpedido.Font.Name, 9f, this.__mainmodule_btngenpedido.Font.Style);
      this.__mainmodule_btngenpedido.AddEvents();
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_btngenpedido);
      this.htControls.Add((object) "__mainmodule_btngenpedido", (object) this.__mainmodule_btngenpedido);
      this.__mainmodule_cbopedido = new CEnhancedCombo(this);
      this.__mainmodule_cbopedido.name = "__mainmodule_cbopedido";
      this.__mainmodule_cbopedido.Left = 45;
      this.__mainmodule_cbopedido.Top = 60;
      this.__mainmodule_cbopedido.Width = 187;
      this.__mainmodule_cbopedido.Height = 25;
      this.__mainmodule_cbopedido.Text = "";
      this.__mainmodule_cbopedido.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cbopedido.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cbopedido.Enabled = true;
      this.__mainmodule_cbopedido.Visible = true;
      this.__mainmodule_cbopedido.Font = new Font(this.__mainmodule_cbopedido.Font.Name, 10f, this.__mainmodule_cbopedido.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_cbopedido);
      this.htControls.Add((object) "__mainmodule_cbopedido", (object) this.__mainmodule_cbopedido);
      this.__mainmodule_cbopedido.AddEvents();
      this.__mainmodule_ltpedreg = new CEnhancedLabel(this);
      this.__mainmodule_ltpedreg.name = "__mainmodule_ltpedreg";
      this.__mainmodule_ltpedreg.Left = 170;
      this.__mainmodule_ltpedreg.Top = 162;
      this.__mainmodule_ltpedreg.Width = 66;
      this.__mainmodule_ltpedreg.Height = 25;
      this.__mainmodule_ltpedreg.Text = "";
      this.__mainmodule_ltpedreg.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltpedreg.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltpedreg.MyEnabled = true;
      this.__mainmodule_ltpedreg.Visible = true;
      this.__mainmodule_ltpedreg.Transparent = false;
      this.__mainmodule_ltpedreg.Font = new Font(this.__mainmodule_ltpedreg.Font.Name, 9f, this.__mainmodule_ltpedreg.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_ltpedreg);
      this.htControls.Add((object) "__mainmodule_ltpedreg", (object) this.__mainmodule_ltpedreg);
      this.__mainmodule_label49 = new CEnhancedLabel(this);
      this.__mainmodule_label49.name = "__mainmodule_label49";
      this.__mainmodule_label49.Left = 125;
      this.__mainmodule_label49.Top = 165;
      this.__mainmodule_label49.Width = 40;
      this.__mainmodule_label49.Height = 20;
      this.__mainmodule_label49.Text = "Regs.";
      this.__mainmodule_label49.BackColor = Color.FromArgb(-7750929);
      this.__mainmodule_label49.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label49.MyEnabled = true;
      this.__mainmodule_label49.Visible = true;
      this.__mainmodule_label49.Transparent = false;
      this.__mainmodule_label49.Font = new Font(this.__mainmodule_label49.Font.Name, 9f, this.__mainmodule_label49.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_label49);
      this.htControls.Add((object) "__mainmodule_label49", (object) this.__mainmodule_label49);
      this.__mainmodule_ltpedcant = new CEnhancedLabel(this);
      this.__mainmodule_ltpedcant.name = "__mainmodule_ltpedcant";
      this.__mainmodule_ltpedcant.Left = 55;
      this.__mainmodule_ltpedcant.Top = 162;
      this.__mainmodule_ltpedcant.Width = 65;
      this.__mainmodule_ltpedcant.Height = 25;
      this.__mainmodule_ltpedcant.Text = "";
      this.__mainmodule_ltpedcant.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltpedcant.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltpedcant.MyEnabled = true;
      this.__mainmodule_ltpedcant.Visible = true;
      this.__mainmodule_ltpedcant.Transparent = false;
      this.__mainmodule_ltpedcant.Font = new Font(this.__mainmodule_ltpedcant.Font.Name, 9f, this.__mainmodule_ltpedcant.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_ltpedcant);
      this.htControls.Add((object) "__mainmodule_ltpedcant", (object) this.__mainmodule_ltpedcant);
      this.__mainmodule_label47 = new CEnhancedLabel(this);
      this.__mainmodule_label47.name = "__mainmodule_label47";
      this.__mainmodule_label47.Left = 1;
      this.__mainmodule_label47.Top = 165;
      this.__mainmodule_label47.Width = 50;
      this.__mainmodule_label47.Height = 20;
      this.__mainmodule_label47.Text = "Cant.";
      this.__mainmodule_label47.BackColor = Color.FromArgb(-7750929);
      this.__mainmodule_label47.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label47.MyEnabled = true;
      this.__mainmodule_label47.Visible = true;
      this.__mainmodule_label47.Transparent = false;
      this.__mainmodule_label47.Font = new Font(this.__mainmodule_label47.Font.Name, 9f, this.__mainmodule_label47.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_label47);
      this.htControls.Add((object) "__mainmodule_label47", (object) this.__mainmodule_label47);
      this.__mainmodule_ltpedart = new CEnhancedLabel(this);
      this.__mainmodule_ltpedart.name = "__mainmodule_ltpedart";
      this.__mainmodule_ltpedart.Left = 55;
      this.__mainmodule_ltpedart.Top = 131;
      this.__mainmodule_ltpedart.Width = 180;
      this.__mainmodule_ltpedart.Height = 29;
      this.__mainmodule_ltpedart.Text = "";
      this.__mainmodule_ltpedart.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltpedart.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltpedart.MyEnabled = true;
      this.__mainmodule_ltpedart.Visible = true;
      this.__mainmodule_ltpedart.Transparent = false;
      this.__mainmodule_ltpedart.Font = new Font(this.__mainmodule_ltpedart.Font.Name, 9f, this.__mainmodule_ltpedart.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_ltpedart);
      this.htControls.Add((object) "__mainmodule_ltpedart", (object) this.__mainmodule_ltpedart);
      this.__mainmodule_label46 = new CEnhancedLabel(this);
      this.__mainmodule_label46.name = "__mainmodule_label46";
      this.__mainmodule_label46.Left = 1;
      this.__mainmodule_label46.Top = 131;
      this.__mainmodule_label46.Width = 50;
      this.__mainmodule_label46.Height = 25;
      this.__mainmodule_label46.Text = "Articulo";
      this.__mainmodule_label46.BackColor = Color.FromArgb(-7750929);
      this.__mainmodule_label46.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label46.MyEnabled = true;
      this.__mainmodule_label46.Visible = true;
      this.__mainmodule_label46.Transparent = false;
      this.__mainmodule_label46.Font = new Font(this.__mainmodule_label46.Font.Name, 9f, this.__mainmodule_label46.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_label46);
      this.htControls.Add((object) "__mainmodule_label46", (object) this.__mainmodule_label46);
      this.__mainmodule_label45 = new CEnhancedLabel(this);
      this.__mainmodule_label45.name = "__mainmodule_label45";
      this.__mainmodule_label45.Left = 5;
      this.__mainmodule_label45.Top = 60;
      this.__mainmodule_label45.Width = 41;
      this.__mainmodule_label45.Height = 25;
      this.__mainmodule_label45.Text = "Folio";
      this.__mainmodule_label45.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label45.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label45.MyEnabled = true;
      this.__mainmodule_label45.Visible = true;
      this.__mainmodule_label45.Transparent = false;
      this.__mainmodule_label45.Font = new Font(this.__mainmodule_label45.Font.Name, 9f, this.__mainmodule_label45.Font.Style);
      this.__mainmodule_genpedido.Controls.Add((Control) this.__mainmodule_label45);
      this.htControls.Add((object) "__mainmodule_label45", (object) this.__mainmodule_label45);
      this.__mainmodule_frmcomprasutils = new CEnhancedForm(this);
      this.__mainmodule_frmcomprasutils.name = "__mainmodule_frmcomprasutils";
      this.__mainmodule_frmcomprasutils.Text = "Opciones compras";
      this.__mainmodule_frmcomprasutils.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmcomprasutils.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmcomprasutils.BackColor), 0, 0, this.__mainmodule_frmcomprasutils.Width, this.__mainmodule_frmcomprasutils.Height);
      this.__mainmodule_frmcomprasutils.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmcomprasutils", (object) this.__mainmodule_frmcomprasutils);
      this.__mainmodule_tblcompras = new CEnhancedTable(this, "__mainmodule_tblcompras");
      this.__mainmodule_tblcompras.name = "__mainmodule_tblcompras";
      this.__mainmodule_tblcompras.Left = 1;
      this.__mainmodule_tblcompras.Top = 35;
      this.__mainmodule_tblcompras.Width = 235;
      this.__mainmodule_tblcompras.Height = 152;
      this.__mainmodule_tblcompras.Text = "";
      this.__mainmodule_tblcompras.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tblcompras.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tblcompras.Enabled = true;
      this.__mainmodule_tblcompras.Visible = true;
      this.__mainmodule_tblcompras.Font = new Font(this.__mainmodule_tblcompras.Font.Name, 9f, this.__mainmodule_tblcompras.Font.Style);
      this.__mainmodule_tblcompras.AddEvents();
      this.__mainmodule_frmcomprasutils.Controls.Add((Control) this.__mainmodule_tblcompras);
      this.htControls.Add((object) "__mainmodule_tblcompras", (object) this.__mainmodule_tblcompras);
      this.__mainmodule_cboprovutils = new CEnhancedCombo(this);
      this.__mainmodule_cboprovutils.name = "__mainmodule_cboprovutils";
      this.__mainmodule_cboprovutils.Left = 45;
      this.__mainmodule_cboprovutils.Top = 10;
      this.__mainmodule_cboprovutils.Width = 165;
      this.__mainmodule_cboprovutils.Height = 22;
      this.__mainmodule_cboprovutils.Text = "";
      this.__mainmodule_cboprovutils.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboprovutils.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboprovutils.Enabled = true;
      this.__mainmodule_cboprovutils.Visible = true;
      this.__mainmodule_cboprovutils.Font = new Font(this.__mainmodule_cboprovutils.Font.Name, 9f, this.__mainmodule_cboprovutils.Font.Style);
      this.__mainmodule_frmcomprasutils.Controls.Add((Control) this.__mainmodule_cboprovutils);
      this.htControls.Add((object) "__mainmodule_cboprovutils", (object) this.__mainmodule_cboprovutils);
      this.__mainmodule_cboprovutils.AddEvents();
      this.__mainmodule_label37 = new CEnhancedLabel(this);
      this.__mainmodule_label37.name = "__mainmodule_label37";
      this.__mainmodule_label37.Left = 5;
      this.__mainmodule_label37.Top = 10;
      this.__mainmodule_label37.Width = 40;
      this.__mainmodule_label37.Height = 20;
      this.__mainmodule_label37.Text = "Folio:";
      this.__mainmodule_label37.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label37.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label37.MyEnabled = true;
      this.__mainmodule_label37.Visible = true;
      this.__mainmodule_label37.Transparent = false;
      this.__mainmodule_label37.Font = new Font(this.__mainmodule_label37.Font.Name, 9f, this.__mainmodule_label37.Font.Style);
      this.__mainmodule_frmcomprasutils.Controls.Add((Control) this.__mainmodule_label37);
      this.htControls.Add((object) "__mainmodule_label37", (object) this.__mainmodule_label37);
      this.__mainmodule_mnuarchivocompras = new CEnhancedMenu(this);
      this.__mainmodule_mnuarchivocompras.name = "__mainmodule_mnuarchivocompras";
      this.__mainmodule_mnuarchivocompras.Text = "Archivo";
      this.__mainmodule_mnuarchivocompras.Enabled = true;
      this.__mainmodule_mnuarchivocompras.Checked = false;
      this.__mainmodule_mnuarchivocompras.AddToObject("__mainmodule_frmcomprasutils");
      this.__mainmodule_mnuarchivocompras.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuarchivocompras", (object) this.__mainmodule_mnuarchivocompras);
      this.__mainmodule_mnucancelcompra = new CEnhancedMenu(this);
      this.__mainmodule_mnucancelcompra.name = "__mainmodule_mnucancelcompra";
      this.__mainmodule_mnucancelcompra.Text = "Cancelar compra";
      this.__mainmodule_mnucancelcompra.Enabled = true;
      this.__mainmodule_mnucancelcompra.Checked = false;
      this.__mainmodule_mnucancelcompra.AddToObject("__mainmodule_mnuarchivocompras");
      this.__mainmodule_mnucancelcompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucancelcompra", (object) this.__mainmodule_mnucancelcompra);
      this.__mainmodule_mnucancelarpartidacompra = new CEnhancedMenu(this);
      this.__mainmodule_mnucancelarpartidacompra.name = "__mainmodule_mnucancelarpartidacompra";
      this.__mainmodule_mnucancelarpartidacompra.Text = "Eliminar partida";
      this.__mainmodule_mnucancelarpartidacompra.Enabled = true;
      this.__mainmodule_mnucancelarpartidacompra.Checked = false;
      this.__mainmodule_mnucancelarpartidacompra.AddToObject("__mainmodule_mnuarchivocompras");
      this.__mainmodule_mnucancelarpartidacompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucancelarpartidacompra", (object) this.__mainmodule_mnucancelarpartidacompra);
      this.__mainmodule_mnusalirutilscompra = new CEnhancedMenu(this);
      this.__mainmodule_mnusalirutilscompra.name = "__mainmodule_mnusalirutilscompra";
      this.__mainmodule_mnusalirutilscompra.Text = "Salir";
      this.__mainmodule_mnusalirutilscompra.Enabled = true;
      this.__mainmodule_mnusalirutilscompra.Checked = false;
      this.__mainmodule_mnusalirutilscompra.AddToObject("__mainmodule_mnuarchivocompras");
      this.__mainmodule_mnusalirutilscompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusalirutilscompra", (object) this.__mainmodule_mnusalirutilscompra);
      this.__mainmodule_frmpedidosutils = new CEnhancedForm(this);
      this.__mainmodule_frmpedidosutils.name = "__mainmodule_frmpedidosutils";
      this.__mainmodule_frmpedidosutils.Text = "Pedidos";
      this.__mainmodule_frmpedidosutils.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmpedidosutils.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmpedidosutils.BackColor), 0, 0, this.__mainmodule_frmpedidosutils.Width, this.__mainmodule_frmpedidosutils.Height);
      this.__mainmodule_frmpedidosutils.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmpedidosutils", (object) this.__mainmodule_frmpedidosutils);
      this.__mainmodule_btnsalped = new CEnhancedButton(this);
      this.__mainmodule_btnsalped.name = "__mainmodule_btnsalped";
      this.__mainmodule_btnsalped.Left = 187;
      this.__mainmodule_btnsalped.Top = 4;
      this.__mainmodule_btnsalped.Width = 47;
      this.__mainmodule_btnsalped.Height = 32;
      this.__mainmodule_btnsalped.Text = "Salir";
      this.__mainmodule_btnsalped.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsalped.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsalped.Enabled = true;
      this.__mainmodule_btnsalped.Visible = true;
      this.__mainmodule_btnsalped.Font = new Font(this.__mainmodule_btnsalped.Font.Name, 9f, this.__mainmodule_btnsalped.Font.Style);
      this.__mainmodule_btnsalped.AddEvents();
      this.__mainmodule_frmpedidosutils.Controls.Add((Control) this.__mainmodule_btnsalped);
      this.htControls.Add((object) "__mainmodule_btnsalped", (object) this.__mainmodule_btnsalped);
      this.__mainmodule_tblpedidos = new CEnhancedTable(this, "__mainmodule_tblpedidos");
      this.__mainmodule_tblpedidos.name = "__mainmodule_tblpedidos";
      this.__mainmodule_tblpedidos.Left = 3;
      this.__mainmodule_tblpedidos.Top = 41;
      this.__mainmodule_tblpedidos.Width = 236;
      this.__mainmodule_tblpedidos.Height = 225;
      this.__mainmodule_tblpedidos.Text = "";
      this.__mainmodule_tblpedidos.propColor = Color.FromArgb(-657931);
      this.__mainmodule_tblpedidos.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tblpedidos.Enabled = true;
      this.__mainmodule_tblpedidos.Visible = true;
      this.__mainmodule_tblpedidos.Font = new Font(this.__mainmodule_tblpedidos.Font.Name, 9f, this.__mainmodule_tblpedidos.Font.Style);
      this.__mainmodule_tblpedidos.AddEvents();
      this.__mainmodule_frmpedidosutils.Controls.Add((Control) this.__mainmodule_tblpedidos);
      this.htControls.Add((object) "__mainmodule_tblpedidos", (object) this.__mainmodule_tblpedidos);
      this.__mainmodule_cboclieutils = new CEnhancedCombo(this);
      this.__mainmodule_cboclieutils.name = "__mainmodule_cboclieutils";
      this.__mainmodule_cboclieutils.Left = 35;
      this.__mainmodule_cboclieutils.Top = 9;
      this.__mainmodule_cboclieutils.Width = 132;
      this.__mainmodule_cboclieutils.Height = 22;
      this.__mainmodule_cboclieutils.Text = "";
      this.__mainmodule_cboclieutils.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboclieutils.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboclieutils.Enabled = true;
      this.__mainmodule_cboclieutils.Visible = true;
      this.__mainmodule_cboclieutils.Font = new Font(this.__mainmodule_cboclieutils.Font.Name, 9f, this.__mainmodule_cboclieutils.Font.Style);
      this.__mainmodule_frmpedidosutils.Controls.Add((Control) this.__mainmodule_cboclieutils);
      this.htControls.Add((object) "__mainmodule_cboclieutils", (object) this.__mainmodule_cboclieutils);
      this.__mainmodule_cboclieutils.AddEvents();
      this.__mainmodule_label56 = new CEnhancedLabel(this);
      this.__mainmodule_label56.name = "__mainmodule_label56";
      this.__mainmodule_label56.Left = 4;
      this.__mainmodule_label56.Top = 10;
      this.__mainmodule_label56.Width = 40;
      this.__mainmodule_label56.Height = 20;
      this.__mainmodule_label56.Text = "Folio";
      this.__mainmodule_label56.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label56.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label56.MyEnabled = true;
      this.__mainmodule_label56.Visible = true;
      this.__mainmodule_label56.Transparent = false;
      this.__mainmodule_label56.Font = new Font(this.__mainmodule_label56.Font.Name, 9f, this.__mainmodule_label56.Font.Style);
      this.__mainmodule_frmpedidosutils.Controls.Add((Control) this.__mainmodule_label56);
      this.htControls.Add((object) "__mainmodule_label56", (object) this.__mainmodule_label56);
      this.__mainmodule_mnuarchipedutils = new CEnhancedMenu(this);
      this.__mainmodule_mnuarchipedutils.name = "__mainmodule_mnuarchipedutils";
      this.__mainmodule_mnuarchipedutils.Text = "Archivo";
      this.__mainmodule_mnuarchipedutils.Enabled = true;
      this.__mainmodule_mnuarchipedutils.Checked = false;
      this.__mainmodule_mnuarchipedutils.AddToObject("__mainmodule_frmpedidosutils");
      this.__mainmodule_mnuarchipedutils.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuarchipedutils", (object) this.__mainmodule_mnuarchipedutils);
      this.__mainmodule_mnucanped = new CEnhancedMenu(this);
      this.__mainmodule_mnucanped.name = "__mainmodule_mnucanped";
      this.__mainmodule_mnucanped.Text = "Cancelar";
      this.__mainmodule_mnucanped.Enabled = true;
      this.__mainmodule_mnucanped.Checked = false;
      this.__mainmodule_mnucanped.AddToObject("__mainmodule_mnuarchipedutils");
      this.__mainmodule_mnucanped.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucanped", (object) this.__mainmodule_mnucanped);
      this.__mainmodule_mnueliped = new CEnhancedMenu(this);
      this.__mainmodule_mnueliped.name = "__mainmodule_mnueliped";
      this.__mainmodule_mnueliped.Text = "Eliminar";
      this.__mainmodule_mnueliped.Enabled = true;
      this.__mainmodule_mnueliped.Checked = false;
      this.__mainmodule_mnueliped.AddToObject("__mainmodule_mnuarchipedutils");
      this.__mainmodule_mnueliped.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnueliped", (object) this.__mainmodule_mnueliped);
      this.__mainmodule_mnusalp = new CEnhancedMenu(this);
      this.__mainmodule_mnusalp.name = "__mainmodule_mnusalp";
      this.__mainmodule_mnusalp.Text = "Salir";
      this.__mainmodule_mnusalp.Enabled = true;
      this.__mainmodule_mnusalp.Checked = false;
      this.__mainmodule_mnusalp.AddToObject("__mainmodule_mnuarchipedutils");
      this.__mainmodule_mnusalp.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusalp", (object) this.__mainmodule_mnusalp);
      this.__mainmodule_frmmenu = new CEnhancedForm(this);
      this.__mainmodule_frmmenu.name = "__mainmodule_frmmenu";
      this.__mainmodule_frmmenu.Text = "Menu";
      this.__mainmodule_frmmenu.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmmenu.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmmenu.BackColor), 0, 0, this.__mainmodule_frmmenu.Width, this.__mainmodule_frmmenu.Height);
      this.__mainmodule_frmmenu.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmmenu", (object) this.__mainmodule_frmmenu);
      this.__mainmodule_pnlpedidos = new CEnhancedPanel(this);
      this.__mainmodule_pnlpedidos.name = "__mainmodule_pnlpedidos";
      this.__mainmodule_pnlpedidos.Left = 205;
      this.__mainmodule_pnlpedidos.Top = 155;
      this.__mainmodule_pnlpedidos.Width = 240;
      this.__mainmodule_pnlpedidos.Height = 190;
      this.__mainmodule_pnlpedidos.BackColor = Color.FromArgb(-11035939);
      this.__mainmodule_pnlpedidos.Enabled = true;
      this.__mainmodule_pnlpedidos.Visible = false;
      this.__mainmodule_pnlpedidos.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_pnlpedidos);
      this.htControls.Add((object) "__mainmodule_pnlpedidos", (object) this.__mainmodule_pnlpedidos);
      this.__mainmodule_btncteped2 = new CEnhancedButton(this);
      this.__mainmodule_btncteped2.name = "__mainmodule_btncteped2";
      this.__mainmodule_btncteped2.Left = 135;
      this.__mainmodule_btncteped2.Top = 130;
      this.__mainmodule_btncteped2.Width = 80;
      this.__mainmodule_btncteped2.Height = 30;
      this.__mainmodule_btncteped2.Text = "Cancelar";
      this.__mainmodule_btncteped2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btncteped2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btncteped2.Enabled = true;
      this.__mainmodule_btncteped2.Visible = true;
      this.__mainmodule_btncteped2.Font = new Font(this.__mainmodule_btncteped2.Font.Name, 9f, this.__mainmodule_btncteped2.Font.Style);
      this.__mainmodule_btncteped2.AddEvents();
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_btncteped2);
      this.htControls.Add((object) "__mainmodule_btncteped2", (object) this.__mainmodule_btncteped2);
      this.__mainmodule_btncteped1 = new CEnhancedButton(this);
      this.__mainmodule_btncteped1.name = "__mainmodule_btncteped1";
      this.__mainmodule_btncteped1.Left = 30;
      this.__mainmodule_btncteped1.Top = 130;
      this.__mainmodule_btncteped1.Width = 80;
      this.__mainmodule_btncteped1.Height = 30;
      this.__mainmodule_btncteped1.Text = "Aceptar";
      this.__mainmodule_btncteped1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btncteped1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btncteped1.Enabled = true;
      this.__mainmodule_btncteped1.Visible = true;
      this.__mainmodule_btncteped1.Font = new Font(this.__mainmodule_btncteped1.Font.Name, 9f, this.__mainmodule_btncteped1.Font.Style);
      this.__mainmodule_btncteped1.AddEvents();
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_btncteped1);
      this.htControls.Add((object) "__mainmodule_btncteped1", (object) this.__mainmodule_btncteped1);
      this.__mainmodule_tpedcte = new CEnhancedTextBox(this);
      this.__mainmodule_tpedcte.name = "__mainmodule_tpedcte";
      this.__mainmodule_tpedcte.Left = 55;
      this.__mainmodule_tpedcte.Top = 5;
      this.__mainmodule_tpedcte.Width = 85;
      this.__mainmodule_tpedcte.Text = "";
      this.__mainmodule_tpedcte.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tpedcte.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tpedcte.Enabled = true;
      this.__mainmodule_tpedcte.Visible = true;
      this.__mainmodule_tpedcte.Height = 25;
      this.__mainmodule_tpedcte.Font = new Font(this.__mainmodule_tpedcte.Font.Name, 10f, this.__mainmodule_tpedcte.Font.Style);
      this.__mainmodule_tpedcte.multiline = false;
      this.__mainmodule_tpedcte.AddEvents();
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_tpedcte);
      this.htControls.Add((object) "__mainmodule_tpedcte", (object) this.__mainmodule_tpedcte);
      this.__mainmodule_btnokcte = new CEnhancedImageButton(this);
      this.__mainmodule_btnokcte.name = "__mainmodule_btnokcte";
      this.__mainmodule_btnokcte.Left = 145;
      this.__mainmodule_btnokcte.Top = 2;
      this.__mainmodule_btnokcte.Width = 40;
      this.__mainmodule_btnokcte.Height = 30;
      this.__mainmodule_btnokcte.Text = "";
      this.__mainmodule_btnokcte.BackColor = Color.FromArgb(-777);
      this.__mainmodule_btnokcte.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnokcte.imageMode = "cCenterImage";
      this.__mainmodule_btnokcte.Transparent = false;
      this.__mainmodule_btnokcte.Enabled = true;
      this.__mainmodule_btnokcte.Visible = true;
      this.__mainmodule_btnokcte.MyBitmap = this.Other.GetBitmapFromResource("b4p.ok.png");
      this.__mainmodule_btnokcte.Font = new Font(this.__mainmodule_btnokcte.Font.Name, 9f, this.__mainmodule_btnokcte.Font.Style);
      this.__mainmodule_btnokcte.AddEvents();
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_btnokcte);
      this.htControls.Add((object) "__mainmodule_btnokcte", (object) this.__mainmodule_btnokcte);
      this.__mainmodule_btnbuscarcte = new CEnhancedImageButton(this);
      this.__mainmodule_btnbuscarcte.name = "__mainmodule_btnbuscarcte";
      this.__mainmodule_btnbuscarcte.Left = 195;
      this.__mainmodule_btnbuscarcte.Top = 2;
      this.__mainmodule_btnbuscarcte.Width = 35;
      this.__mainmodule_btnbuscarcte.Height = 30;
      this.__mainmodule_btnbuscarcte.Text = "";
      this.__mainmodule_btnbuscarcte.BackColor = Color.FromArgb(-2830136);
      this.__mainmodule_btnbuscarcte.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnbuscarcte.imageMode = "cNormalImage";
      this.__mainmodule_btnbuscarcte.Transparent = false;
      this.__mainmodule_btnbuscarcte.Enabled = true;
      this.__mainmodule_btnbuscarcte.Visible = true;
      this.__mainmodule_btnbuscarcte.MyBitmap = this.Other.GetBitmapFromResource("b4p.lupa2.jpg");
      this.__mainmodule_btnbuscarcte.Font = new Font(this.__mainmodule_btnbuscarcte.Font.Name, 9f, this.__mainmodule_btnbuscarcte.Font.Style);
      this.__mainmodule_btnbuscarcte.AddEvents();
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_btnbuscarcte);
      this.htControls.Add((object) "__mainmodule_btnbuscarcte", (object) this.__mainmodule_btnbuscarcte);
      this.__mainmodule_ltnombrecte = new CEnhancedLabel(this);
      this.__mainmodule_ltnombrecte.name = "__mainmodule_ltnombrecte";
      this.__mainmodule_ltnombrecte.Left = 55;
      this.__mainmodule_ltnombrecte.Top = 35;
      this.__mainmodule_ltnombrecte.Width = 175;
      this.__mainmodule_ltnombrecte.Height = 55;
      this.__mainmodule_ltnombrecte.Text = "";
      this.__mainmodule_ltnombrecte.BackColor = Color.FromArgb(-1);
      this.__mainmodule_ltnombrecte.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltnombrecte.MyEnabled = true;
      this.__mainmodule_ltnombrecte.Visible = true;
      this.__mainmodule_ltnombrecte.Transparent = false;
      this.__mainmodule_ltnombrecte.Font = new Font(this.__mainmodule_ltnombrecte.Font.Name, 9f, this.__mainmodule_ltnombrecte.Font.Style);
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_ltnombrecte);
      this.htControls.Add((object) "__mainmodule_ltnombrecte", (object) this.__mainmodule_ltnombrecte);
      this.__mainmodule_label50 = new CEnhancedLabel(this);
      this.__mainmodule_label50.name = "__mainmodule_label50";
      this.__mainmodule_label50.Left = 1;
      this.__mainmodule_label50.Top = 37;
      this.__mainmodule_label50.Width = 55;
      this.__mainmodule_label50.Height = 20;
      this.__mainmodule_label50.Text = "Nombre:";
      this.__mainmodule_label50.BackColor = Color.FromArgb(-11035939);
      this.__mainmodule_label50.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label50.MyEnabled = true;
      this.__mainmodule_label50.Visible = true;
      this.__mainmodule_label50.Transparent = false;
      this.__mainmodule_label50.Font = new Font(this.__mainmodule_label50.Font.Name, 9f, this.__mainmodule_label50.Font.Style);
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_label50);
      this.htControls.Add((object) "__mainmodule_label50", (object) this.__mainmodule_label50);
      this.__mainmodule_label48 = new CEnhancedLabel(this);
      this.__mainmodule_label48.name = "__mainmodule_label48";
      this.__mainmodule_label48.Left = 1;
      this.__mainmodule_label48.Top = 10;
      this.__mainmodule_label48.Width = 55;
      this.__mainmodule_label48.Height = 20;
      this.__mainmodule_label48.Text = "Clave";
      this.__mainmodule_label48.BackColor = Color.FromArgb(-11035939);
      this.__mainmodule_label48.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label48.MyEnabled = true;
      this.__mainmodule_label48.Visible = true;
      this.__mainmodule_label48.Transparent = false;
      this.__mainmodule_label48.Font = new Font(this.__mainmodule_label48.Font.Name, 9f, this.__mainmodule_label48.Font.Style);
      this.__mainmodule_pnlpedidos.Controls.Add((Control) this.__mainmodule_label48);
      this.htControls.Add((object) "__mainmodule_label48", (object) this.__mainmodule_label48);
      this.__mainmodule_btnpedido = new CEnhancedButton(this);
      this.__mainmodule_btnpedido.name = "__mainmodule_btnpedido";
      this.__mainmodule_btnpedido.Left = 55;
      this.__mainmodule_btnpedido.Top = 39;
      this.__mainmodule_btnpedido.Width = 125;
      this.__mainmodule_btnpedido.Height = 35;
      this.__mainmodule_btnpedido.Text = "Pedidos";
      this.__mainmodule_btnpedido.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnpedido.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnpedido.Enabled = true;
      this.__mainmodule_btnpedido.Visible = true;
      this.__mainmodule_btnpedido.Font = new Font(this.__mainmodule_btnpedido.Font.Name, 9f, this.__mainmodule_btnpedido.Font.Style);
      this.__mainmodule_btnpedido.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_btnpedido);
      this.htControls.Add((object) "__mainmodule_btnpedido", (object) this.__mainmodule_btnpedido);
      this.__mainmodule_btntraspasos = new CEnhancedButton(this);
      this.__mainmodule_btntraspasos.name = "__mainmodule_btntraspasos";
      this.__mainmodule_btntraspasos.Left = 55;
      this.__mainmodule_btntraspasos.Top = 114;
      this.__mainmodule_btntraspasos.Width = 125;
      this.__mainmodule_btntraspasos.Height = 35;
      this.__mainmodule_btntraspasos.Text = "Transpasos";
      this.__mainmodule_btntraspasos.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntraspasos.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntraspasos.Enabled = true;
      this.__mainmodule_btntraspasos.Visible = true;
      this.__mainmodule_btntraspasos.Font = new Font(this.__mainmodule_btntraspasos.Font.Name, 9f, this.__mainmodule_btntraspasos.Font.Style);
      this.__mainmodule_btntraspasos.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_btntraspasos);
      this.htControls.Add((object) "__mainmodule_btntraspasos", (object) this.__mainmodule_btntraspasos);
      this.__mainmodule_btnmenusalir = new CEnhancedButton(this);
      this.__mainmodule_btnmenusalir.name = "__mainmodule_btnmenusalir";
      this.__mainmodule_btnmenusalir.Left = 55;
      this.__mainmodule_btnmenusalir.Top = 151;
      this.__mainmodule_btnmenusalir.Width = 125;
      this.__mainmodule_btnmenusalir.Height = 35;
      this.__mainmodule_btnmenusalir.Text = "Salir";
      this.__mainmodule_btnmenusalir.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnmenusalir.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnmenusalir.Enabled = true;
      this.__mainmodule_btnmenusalir.Visible = true;
      this.__mainmodule_btnmenusalir.Font = new Font(this.__mainmodule_btnmenusalir.Font.Name, 9f, this.__mainmodule_btnmenusalir.Font.Style);
      this.__mainmodule_btnmenusalir.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_btnmenusalir);
      this.htControls.Add((object) "__mainmodule_btnmenusalir", (object) this.__mainmodule_btnmenusalir);
      this.__mainmodule_btnmenucompras = new CEnhancedButton(this);
      this.__mainmodule_btnmenucompras.name = "__mainmodule_btnmenucompras";
      this.__mainmodule_btnmenucompras.Left = 55;
      this.__mainmodule_btnmenucompras.Top = 77;
      this.__mainmodule_btnmenucompras.Width = 125;
      this.__mainmodule_btnmenucompras.Height = 35;
      this.__mainmodule_btnmenucompras.Text = "Compras";
      this.__mainmodule_btnmenucompras.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnmenucompras.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnmenucompras.Enabled = true;
      this.__mainmodule_btnmenucompras.Visible = true;
      this.__mainmodule_btnmenucompras.Font = new Font(this.__mainmodule_btnmenucompras.Font.Name, 9f, this.__mainmodule_btnmenucompras.Font.Style);
      this.__mainmodule_btnmenucompras.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_btnmenucompras);
      this.htControls.Add((object) "__mainmodule_btnmenucompras", (object) this.__mainmodule_btnmenucompras);
      this.__mainmodule_btnmenuinvent = new CEnhancedButton(this);
      this.__mainmodule_btnmenuinvent.name = "__mainmodule_btnmenuinvent";
      this.__mainmodule_btnmenuinvent.Left = 55;
      this.__mainmodule_btnmenuinvent.Top = 2;
      this.__mainmodule_btnmenuinvent.Width = 125;
      this.__mainmodule_btnmenuinvent.Height = 35;
      this.__mainmodule_btnmenuinvent.Text = "Inventario";
      this.__mainmodule_btnmenuinvent.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnmenuinvent.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnmenuinvent.Enabled = true;
      this.__mainmodule_btnmenuinvent.Visible = true;
      this.__mainmodule_btnmenuinvent.Font = new Font(this.__mainmodule_btnmenuinvent.Font.Name, 9f, this.__mainmodule_btnmenuinvent.Font.Style);
      this.__mainmodule_btnmenuinvent.AddEvents();
      this.__mainmodule_frmmenu.Controls.Add((Control) this.__mainmodule_btnmenuinvent);
      this.htControls.Add((object) "__mainmodule_btnmenuinvent", (object) this.__mainmodule_btnmenuinvent);
      this.__mainmodule_invent = new CEnhancedForm(this);
      this.__mainmodule_invent.name = "__mainmodule_invent";
      this.__mainmodule_invent.Text = "Inventario";
      this.__mainmodule_invent.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_invent.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_invent.BackColor), 0, 0, this.__mainmodule_invent.Width, this.__mainmodule_invent.Height);
      this.__mainmodule_invent.AddEvents();
      this.htControls.Add((object) "__mainmodule_invent", (object) this.__mainmodule_invent);
      this.__mainmodule_pnlred = new CEnhancedPanel(this);
      this.__mainmodule_pnlred.name = "__mainmodule_pnlred";
      this.__mainmodule_pnlred.Left = 215;
      this.__mainmodule_pnlred.Top = 60;
      this.__mainmodule_pnlred.Width = 235;
      this.__mainmodule_pnlred.Height = 135;
      this.__mainmodule_pnlred.BackColor = Color.FromArgb(-65536);
      this.__mainmodule_pnlred.Enabled = true;
      this.__mainmodule_pnlred.Visible = false;
      this.__mainmodule_pnlred.AddEvents();
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_pnlred);
      this.htControls.Add((object) "__mainmodule_pnlred", (object) this.__mainmodule_pnlred);
      this.__mainmodule_lt2 = new CEnhancedLabel(this);
      this.__mainmodule_lt2.name = "__mainmodule_lt2";
      this.__mainmodule_lt2.Left = 50;
      this.__mainmodule_lt2.Top = 200;
      this.__mainmodule_lt2.Width = 55;
      this.__mainmodule_lt2.Height = 25;
      this.__mainmodule_lt2.Text = "";
      this.__mainmodule_lt2.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_lt2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lt2.MyEnabled = true;
      this.__mainmodule_lt2.Visible = false;
      this.__mainmodule_lt2.Transparent = false;
      this.__mainmodule_lt2.Font = new Font(this.__mainmodule_lt2.Font.Name, 9f, this.__mainmodule_lt2.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_lt2);
      this.htControls.Add((object) "__mainmodule_lt2", (object) this.__mainmodule_lt2);
      this.__mainmodule_lt4 = new CEnhancedLabel(this);
      this.__mainmodule_lt4.name = "__mainmodule_lt4";
      this.__mainmodule_lt4.Left = 50;
      this.__mainmodule_lt4.Top = 230;
      this.__mainmodule_lt4.Width = 180;
      this.__mainmodule_lt4.Height = 35;
      this.__mainmodule_lt4.Text = "";
      this.__mainmodule_lt4.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_lt4.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lt4.MyEnabled = true;
      this.__mainmodule_lt4.Visible = false;
      this.__mainmodule_lt4.Transparent = false;
      this.__mainmodule_lt4.Font = new Font(this.__mainmodule_lt4.Font.Name, 9f, this.__mainmodule_lt4.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_lt4);
      this.htControls.Add((object) "__mainmodule_lt4", (object) this.__mainmodule_lt4);
      this.__mainmodule_lt3 = new CEnhancedLabel(this);
      this.__mainmodule_lt3.name = "__mainmodule_lt3";
      this.__mainmodule_lt3.Left = 1;
      this.__mainmodule_lt3.Top = 230;
      this.__mainmodule_lt3.Width = 50;
      this.__mainmodule_lt3.Height = 25;
      this.__mainmodule_lt3.Text = "Nombre";
      this.__mainmodule_lt3.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_lt3.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lt3.MyEnabled = true;
      this.__mainmodule_lt3.Visible = false;
      this.__mainmodule_lt3.Transparent = false;
      this.__mainmodule_lt3.Font = new Font(this.__mainmodule_lt3.Font.Name, 9f, this.__mainmodule_lt3.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_lt3);
      this.htControls.Add((object) "__mainmodule_lt3", (object) this.__mainmodule_lt3);
      this.__mainmodule_lt1 = new CEnhancedLabel(this);
      this.__mainmodule_lt1.name = "__mainmodule_lt1";
      this.__mainmodule_lt1.Left = 1;
      this.__mainmodule_lt1.Top = 200;
      this.__mainmodule_lt1.Width = 50;
      this.__mainmodule_lt1.Height = 25;
      this.__mainmodule_lt1.Text = "Cliente";
      this.__mainmodule_lt1.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_lt1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lt1.MyEnabled = true;
      this.__mainmodule_lt1.Visible = false;
      this.__mainmodule_lt1.Transparent = false;
      this.__mainmodule_lt1.Font = new Font(this.__mainmodule_lt1.Font.Name, 9f, this.__mainmodule_lt1.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_lt1);
      this.htControls.Add((object) "__mainmodule_lt1", (object) this.__mainmodule_lt1);
      this.__mainmodule_tarticulo = new CEnhancedTextBox(this);
      this.__mainmodule_tarticulo.name = "__mainmodule_tarticulo";
      this.__mainmodule_tarticulo.Left = 4;
      this.__mainmodule_tarticulo.Top = 30;
      this.__mainmodule_tarticulo.Width = 175;
      this.__mainmodule_tarticulo.Text = "";
      this.__mainmodule_tarticulo.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tarticulo.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tarticulo.Enabled = true;
      this.__mainmodule_tarticulo.Visible = true;
      this.__mainmodule_tarticulo.Height = 25;
      this.__mainmodule_tarticulo.Font = new Font(this.__mainmodule_tarticulo.Font.Name, 10f, this.__mainmodule_tarticulo.Font.Style);
      this.__mainmodule_tarticulo.multiline = false;
      this.__mainmodule_tarticulo.AddEvents();
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_tarticulo);
      this.htControls.Add((object) "__mainmodule_tarticulo", (object) this.__mainmodule_tarticulo);
      this.__mainmodule_tuni = new CEnhancedTextBox(this);
      this.__mainmodule_tuni.name = "__mainmodule_tuni";
      this.__mainmodule_tuni.Left = 185;
      this.__mainmodule_tuni.Top = 25;
      this.__mainmodule_tuni.Width = 50;
      this.__mainmodule_tuni.Text = "";
      this.__mainmodule_tuni.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tuni.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tuni.Enabled = true;
      this.__mainmodule_tuni.Visible = true;
      this.__mainmodule_tuni.Height = 35;
      this.__mainmodule_tuni.Font = new Font(this.__mainmodule_tuni.Font.Name, 14f, this.__mainmodule_tuni.Font.Style);
      this.__mainmodule_tuni.multiline = false;
      this.__mainmodule_tuni.AddEvents();
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_tuni);
      this.htControls.Add((object) "__mainmodule_tuni", (object) this.__mainmodule_tuni);
      this.__mainmodule_cboareas = new CEnhancedCombo(this);
      this.__mainmodule_cboareas.name = "__mainmodule_cboareas";
      this.__mainmodule_cboareas.Left = 50;
      this.__mainmodule_cboareas.Top = 195;
      this.__mainmodule_cboareas.Width = 175;
      this.__mainmodule_cboareas.Height = 22;
      this.__mainmodule_cboareas.Text = "";
      this.__mainmodule_cboareas.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboareas.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboareas.Enabled = true;
      this.__mainmodule_cboareas.Visible = true;
      this.__mainmodule_cboareas.Font = new Font(this.__mainmodule_cboareas.Font.Name, 9f, this.__mainmodule_cboareas.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_cboareas);
      this.htControls.Add((object) "__mainmodule_cboareas", (object) this.__mainmodule_cboareas);
      this.__mainmodule_cboareas.AddEvents();
      this.__mainmodule_label30 = new CEnhancedLabel(this);
      this.__mainmodule_label30.name = "__mainmodule_label30";
      this.__mainmodule_label30.Left = 10;
      this.__mainmodule_label30.Top = 195;
      this.__mainmodule_label30.Width = 40;
      this.__mainmodule_label30.Height = 25;
      this.__mainmodule_label30.Text = "Area:";
      this.__mainmodule_label30.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_label30.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label30.MyEnabled = true;
      this.__mainmodule_label30.Visible = true;
      this.__mainmodule_label30.Transparent = false;
      this.__mainmodule_label30.Font = new Font(this.__mainmodule_label30.Font.Name, 9f, this.__mainmodule_label30.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_label30);
      this.htControls.Add((object) "__mainmodule_label30", (object) this.__mainmodule_label30);
      this.__mainmodule_ltartinv = new CEnhancedLabel(this);
      this.__mainmodule_ltartinv.name = "__mainmodule_ltartinv";
      this.__mainmodule_ltartinv.Left = 10;
      this.__mainmodule_ltartinv.Top = 0;
      this.__mainmodule_ltartinv.Width = 235;
      this.__mainmodule_ltartinv.Height = 110;
      this.__mainmodule_ltartinv.Text = "______";
      this.__mainmodule_ltartinv.BackColor = Color.FromArgb(-65536);
      this.__mainmodule_ltartinv.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltartinv.MyEnabled = true;
      this.__mainmodule_ltartinv.Visible = true;
      this.__mainmodule_ltartinv.Transparent = false;
      this.__mainmodule_ltartinv.Font = new Font(this.__mainmodule_ltartinv.Font.Name, 12f, this.__mainmodule_ltartinv.Font.Style);
      this.__mainmodule_pnlred.Controls.Add((Control) this.__mainmodule_ltartinv);
      this.htControls.Add((object) "__mainmodule_ltartinv", (object) this.__mainmodule_ltartinv);
      this.__mainmodule_btnred = new CEnhancedButton(this);
      this.__mainmodule_btnred.name = "__mainmodule_btnred";
      this.__mainmodule_btnred.Left = 55;
      this.__mainmodule_btnred.Top = 105;
      this.__mainmodule_btnred.Width = 120;
      this.__mainmodule_btnred.Height = 35;
      this.__mainmodule_btnred.Text = "Aceptar";
      this.__mainmodule_btnred.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnred.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnred.Enabled = true;
      this.__mainmodule_btnred.Visible = true;
      this.__mainmodule_btnred.Font = new Font(this.__mainmodule_btnred.Font.Name, 9f, this.__mainmodule_btnred.Font.Style);
      this.__mainmodule_btnred.AddEvents();
      this.__mainmodule_pnlred.Controls.Add((Control) this.__mainmodule_btnred);
      this.htControls.Add((object) "__mainmodule_btnred", (object) this.__mainmodule_btnred);
      this.__mainmodule_ltred = new CEnhancedLabel(this);
      this.__mainmodule_ltred.name = "__mainmodule_ltred";
      this.__mainmodule_ltred.Left = 50;
      this.__mainmodule_ltred.Top = 0;
      this.__mainmodule_ltred.Width = 195;
      this.__mainmodule_ltred.Height = 70;
      this.__mainmodule_ltred.Text = "         LA CLAVE DEL ARTICULO NO EXISTE";
      this.__mainmodule_ltred.BackColor = Color.FromArgb(-65536);
      this.__mainmodule_ltred.ForeColor = Color.FromArgb(-1);
      this.__mainmodule_ltred.MyEnabled = true;
      this.__mainmodule_ltred.Visible = true;
      this.__mainmodule_ltred.Transparent = false;
      this.__mainmodule_ltred.Font = new Font(this.__mainmodule_ltred.Font.Name, 14f, this.__mainmodule_ltred.Font.Style);
      this.__mainmodule_pnlred.Controls.Add((Control) this.__mainmodule_ltred);
      this.htControls.Add((object) "__mainmodule_ltred", (object) this.__mainmodule_ltred);
      this.__mainmodule_ltfc = new CEnhancedLabel(this);
      this.__mainmodule_ltfc.name = "__mainmodule_ltfc";
      this.__mainmodule_ltfc.Left = 55;
      this.__mainmodule_ltfc.Top = 2;
      this.__mainmodule_ltfc.Width = 140;
      this.__mainmodule_ltfc.Height = 20;
      this.__mainmodule_ltfc.Text = "";
      this.__mainmodule_ltfc.BackColor = Color.FromArgb(-8323200);
      this.__mainmodule_ltfc.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltfc.MyEnabled = true;
      this.__mainmodule_ltfc.Visible = false;
      this.__mainmodule_ltfc.Transparent = false;
      this.__mainmodule_ltfc.Font = new Font(this.__mainmodule_ltfc.Font.Name, 10f, this.__mainmodule_ltfc.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_ltfc);
      this.htControls.Add((object) "__mainmodule_ltfc", (object) this.__mainmodule_ltfc);
      this.__mainmodule_ltsae = new CEnhancedLabel(this);
      this.__mainmodule_ltsae.name = "__mainmodule_ltsae";
      this.__mainmodule_ltsae.Left = 45;
      this.__mainmodule_ltsae.Top = 110;
      this.__mainmodule_ltsae.Width = 150;
      this.__mainmodule_ltsae.Height = 20;
      this.__mainmodule_ltsae.Text = "Existencia acumulada";
      this.__mainmodule_ltsae.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltsae.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsae.MyEnabled = true;
      this.__mainmodule_ltsae.Visible = true;
      this.__mainmodule_ltsae.Transparent = false;
      this.__mainmodule_ltsae.Font = new Font(this.__mainmodule_ltsae.Font.Name, 10f, this.__mainmodule_ltsae.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_ltsae);
      this.htControls.Add((object) "__mainmodule_ltsae", (object) this.__mainmodule_ltsae);
      this.__mainmodule_ltinven = new CEnhancedLabel(this);
      this.__mainmodule_ltinven.name = "__mainmodule_ltinven";
      this.__mainmodule_ltinven.Left = 3;
      this.__mainmodule_ltinven.Top = 130;
      this.__mainmodule_ltinven.Width = 235;
      this.__mainmodule_ltinven.Height = 55;
      this.__mainmodule_ltinven.Text = "";
      this.__mainmodule_ltinven.BackColor = Color.FromArgb(-8323200);
      this.__mainmodule_ltinven.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltinven.MyEnabled = true;
      this.__mainmodule_ltinven.Visible = true;
      this.__mainmodule_ltinven.Transparent = false;
      this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_ltinven);
      this.htControls.Add((object) "__mainmodule_ltinven", (object) this.__mainmodule_ltinven);
      this.__mainmodule_cmdinv = new CEnhancedButton(this);
      this.__mainmodule_cmdinv.name = "__mainmodule_cmdinv";
      this.__mainmodule_cmdinv.Left = 200;
      this.__mainmodule_cmdinv.Top = 2;
      this.__mainmodule_cmdinv.Width = 35;
      this.__mainmodule_cmdinv.Height = 20;
      this.__mainmodule_cmdinv.Text = ".....";
      this.__mainmodule_cmdinv.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdinv.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdinv.Enabled = true;
      this.__mainmodule_cmdinv.Visible = true;
      this.__mainmodule_cmdinv.Font = new Font(this.__mainmodule_cmdinv.Font.Name, 9f, this.__mainmodule_cmdinv.Font.Style);
      this.__mainmodule_cmdinv.AddEvents();
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_cmdinv);
      this.htControls.Add((object) "__mainmodule_cmdinv", (object) this.__mainmodule_cmdinv);
      this.__mainmodule_ltinven2 = new CEnhancedLabel(this);
      this.__mainmodule_ltinven2.name = "__mainmodule_ltinven2";
      this.__mainmodule_ltinven2.Left = 3;
      this.__mainmodule_ltinven2.Top = 62;
      this.__mainmodule_ltinven2.Width = 235;
      this.__mainmodule_ltinven2.Height = 45;
      this.__mainmodule_ltinven2.Text = "";
      this.__mainmodule_ltinven2.BackColor = Color.FromArgb(-8323200);
      this.__mainmodule_ltinven2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltinven2.MyEnabled = true;
      this.__mainmodule_ltinven2.Visible = true;
      this.__mainmodule_ltinven2.Transparent = false;
      this.__mainmodule_ltinven2.Font = new Font(this.__mainmodule_ltinven2.Font.Name, 9f, this.__mainmodule_ltinven2.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_ltinven2);
      this.htControls.Add((object) "__mainmodule_ltinven2", (object) this.__mainmodule_ltinven2);
      this.__mainmodule_label25 = new CEnhancedLabel(this);
      this.__mainmodule_label25.name = "__mainmodule_label25";
      this.__mainmodule_label25.Left = 5;
      this.__mainmodule_label25.Top = 13;
      this.__mainmodule_label25.Width = 48;
      this.__mainmodule_label25.Height = 16;
      this.__mainmodule_label25.Text = "Articulo";
      this.__mainmodule_label25.BackColor = Color.FromArgb(-67346);
      this.__mainmodule_label25.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label25.MyEnabled = true;
      this.__mainmodule_label25.Visible = true;
      this.__mainmodule_label25.Transparent = false;
      this.__mainmodule_label25.Font = new Font(this.__mainmodule_label25.Font.Name, 9f, this.__mainmodule_label25.Font.Style);
      this.__mainmodule_invent.Controls.Add((Control) this.__mainmodule_label25);
      this.htControls.Add((object) "__mainmodule_label25", (object) this.__mainmodule_label25);
      this.__mainmodule_mnuarchivo = new CEnhancedMenu(this);
      this.__mainmodule_mnuarchivo.name = "__mainmodule_mnuarchivo";
      this.__mainmodule_mnuarchivo.Text = "Archivo";
      this.__mainmodule_mnuarchivo.Enabled = true;
      this.__mainmodule_mnuarchivo.Checked = false;
      this.__mainmodule_mnuarchivo.AddToObject("__mainmodule_invent");
      this.__mainmodule_mnuarchivo.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuarchivo", (object) this.__mainmodule_mnuarchivo);
      this.__mainmodule_menmov = new CEnhancedMenu(this);
      this.__mainmodule_menmov.name = "__mainmodule_menmov";
      this.__mainmodule_menmov.Text = "Movimientos";
      this.__mainmodule_menmov.Enabled = true;
      this.__mainmodule_menmov.Checked = false;
      this.__mainmodule_menmov.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_menmov.AddEvents();
      this.htControls.Add((object) "__mainmodule_menmov", (object) this.__mainmodule_menmov);
      this.__mainmodule_mensend = new CEnhancedMenu(this);
      this.__mainmodule_mensend.name = "__mainmodule_mensend";
      this.__mainmodule_mensend.Text = "Enviar inventario texto";
      this.__mainmodule_mensend.Enabled = true;
      this.__mainmodule_mensend.Checked = false;
      this.__mainmodule_mensend.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mensend.AddEvents();
      this.htControls.Add((object) "__mainmodule_mensend", (object) this.__mainmodule_mensend);
      this.__mainmodule_mnuenviarsae = new CEnhancedMenu(this);
      this.__mainmodule_mnuenviarsae.name = "__mainmodule_mnuenviarsae";
      this.__mainmodule_mnuenviarsae.Text = "Generar MINVE en SAE";
      this.__mainmodule_mnuenviarsae.Enabled = true;
      this.__mainmodule_mnuenviarsae.Checked = false;
      this.__mainmodule_mnuenviarsae.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuenviarsae.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuenviarsae", (object) this.__mainmodule_mnuenviarsae);
      this.__mainmodule_mnupedido = new CEnhancedMenu(this);
      this.__mainmodule_mnupedido.name = "__mainmodule_mnupedido";
      this.__mainmodule_mnupedido.Text = "Generar pedido";
      this.__mainmodule_mnupedido.Enabled = true;
      this.__mainmodule_mnupedido.Checked = false;
      this.__mainmodule_mnupedido.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnupedido.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnupedido", (object) this.__mainmodule_mnupedido);
      this.__mainmodule_mnuopcionesped = new CEnhancedMenu(this);
      this.__mainmodule_mnuopcionesped.name = "__mainmodule_mnuopcionesped";
      this.__mainmodule_mnuopcionesped.Text = "Opciones pedidos";
      this.__mainmodule_mnuopcionesped.Enabled = true;
      this.__mainmodule_mnuopcionesped.Checked = false;
      this.__mainmodule_mnuopcionesped.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuopcionesped.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuopcionesped", (object) this.__mainmodule_mnuopcionesped);
      this.__mainmodule_mnunewpedido = new CEnhancedMenu(this);
      this.__mainmodule_mnunewpedido.name = "__mainmodule_mnunewpedido";
      this.__mainmodule_mnunewpedido.Text = "Nuevo pedido";
      this.__mainmodule_mnunewpedido.Enabled = true;
      this.__mainmodule_mnunewpedido.Checked = false;
      this.__mainmodule_mnunewpedido.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnunewpedido.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnunewpedido", (object) this.__mainmodule_mnunewpedido);
      this.__mainmodule_mnucompra = new CEnhancedMenu(this);
      this.__mainmodule_mnucompra.name = "__mainmodule_mnucompra";
      this.__mainmodule_mnucompra.Text = "Generar orden de compra";
      this.__mainmodule_mnucompra.Enabled = true;
      this.__mainmodule_mnucompra.Checked = false;
      this.__mainmodule_mnucompra.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnucompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnucompra", (object) this.__mainmodule_mnucompra);
      this.__mainmodule_mnuutilscompras = new CEnhancedMenu(this);
      this.__mainmodule_mnuutilscompras.name = "__mainmodule_mnuutilscompras";
      this.__mainmodule_mnuutilscompras.Text = "Opciones compras";
      this.__mainmodule_mnuutilscompras.Enabled = true;
      this.__mainmodule_mnuutilscompras.Checked = false;
      this.__mainmodule_mnuutilscompras.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuutilscompras.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuutilscompras", (object) this.__mainmodule_mnuutilscompras);
      this.__mainmodule_mnunuevacompra = new CEnhancedMenu(this);
      this.__mainmodule_mnunuevacompra.name = "__mainmodule_mnunuevacompra";
      this.__mainmodule_mnunuevacompra.Text = "Nueva Orden Compra";
      this.__mainmodule_mnunuevacompra.Enabled = true;
      this.__mainmodule_mnunuevacompra.Checked = false;
      this.__mainmodule_mnunuevacompra.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnunuevacompra.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnunuevacompra", (object) this.__mainmodule_mnunuevacompra);
      this.__mainmodule_mnureenviar = new CEnhancedMenu(this);
      this.__mainmodule_mnureenviar.name = "__mainmodule_mnureenviar";
      this.__mainmodule_mnureenviar.Text = "Remarcar inventario para reenviarlo";
      this.__mainmodule_mnureenviar.Enabled = true;
      this.__mainmodule_mnureenviar.Checked = false;
      this.__mainmodule_mnureenviar.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnureenviar.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnureenviar", (object) this.__mainmodule_mnureenviar);
      this.__mainmodule_mnuexist = new CEnhancedMenu(this);
      this.__mainmodule_mnuexist.name = "__mainmodule_mnuexist";
      this.__mainmodule_mnuexist.Text = "Existencias SAE";
      this.__mainmodule_mnuexist.Enabled = true;
      this.__mainmodule_mnuexist.Checked = false;
      this.__mainmodule_mnuexist.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuexist.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuexist", (object) this.__mainmodule_mnuexist);
      this.__mainmodule_mnutotal = new CEnhancedMenu(this);
      this.__mainmodule_mnutotal.name = "__mainmodule_mnutotal";
      this.__mainmodule_mnutotal.Text = "Total articulos";
      this.__mainmodule_mnutotal.Enabled = true;
      this.__mainmodule_mnutotal.Checked = false;
      this.__mainmodule_mnutotal.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnutotal.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnutotal", (object) this.__mainmodule_mnutotal);
      this.__mainmodule_mnuexisxlinea = new CEnhancedMenu(this);
      this.__mainmodule_mnuexisxlinea.name = "__mainmodule_mnuexisxlinea";
      this.__mainmodule_mnuexisxlinea.Text = "Exist. X Linea";
      this.__mainmodule_mnuexisxlinea.Enabled = true;
      this.__mainmodule_mnuexisxlinea.Checked = false;
      this.__mainmodule_mnuexisxlinea.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuexisxlinea.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuexisxlinea", (object) this.__mainmodule_mnuexisxlinea);
      this.__mainmodule_mnuareas = new CEnhancedMenu(this);
      this.__mainmodule_mnuareas.name = "__mainmodule_mnuareas";
      this.__mainmodule_mnuareas.Text = "Exist x Area";
      this.__mainmodule_mnuareas.Enabled = true;
      this.__mainmodule_mnuareas.Checked = false;
      this.__mainmodule_mnuareas.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_mnuareas.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuareas", (object) this.__mainmodule_mnuareas);
      this.__mainmodule_menfin = new CEnhancedMenu(this);
      this.__mainmodule_menfin.name = "__mainmodule_menfin";
      this.__mainmodule_menfin.Text = "Salir";
      this.__mainmodule_menfin.Enabled = true;
      this.__mainmodule_menfin.Checked = false;
      this.__mainmodule_menfin.AddToObject("__mainmodule_mnuarchivo");
      this.__mainmodule_menfin.AddEvents();
      this.htControls.Add((object) "__mainmodule_menfin", (object) this.__mainmodule_menfin);
      this.__mainmodule_sqlserver = new CEnhancedForm(this);
      this.__mainmodule_sqlserver.name = "__mainmodule_sqlserver";
      this.__mainmodule_sqlserver.Text = "SQL SERVER";
      this.__mainmodule_sqlserver.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_sqlserver.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_sqlserver.BackColor), 0, 0, this.__mainmodule_sqlserver.Width, this.__mainmodule_sqlserver.Height);
      this.__mainmodule_sqlserver.AddEvents();
      this.htControls.Add((object) "__mainmodule_sqlserver", (object) this.__mainmodule_sqlserver);
      this.__mainmodule_chmatriz = new CEnhancedCheckBox(this);
      this.__mainmodule_chmatriz.name = "__mainmodule_chmatriz";
      this.__mainmodule_chmatriz.Left = 135;
      this.__mainmodule_chmatriz.Top = 5;
      this.__mainmodule_chmatriz.Width = 60;
      this.__mainmodule_chmatriz.Height = 20;
      this.__mainmodule_chmatriz.Text = "Matriz";
      this.__mainmodule_chmatriz.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_chmatriz.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chmatriz.Enabled = true;
      this.__mainmodule_chmatriz.Visible = true;
      this.__mainmodule_chmatriz.Checked = false;
      this.__mainmodule_chmatriz.Font = new Font(this.__mainmodule_chmatriz.Font.Name, 8f, this.__mainmodule_chmatriz.Font.Style);
      this.__mainmodule_chmatriz.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_chmatriz);
      this.htControls.Add((object) "__mainmodule_chmatriz", (object) this.__mainmodule_chmatriz);
      this.__mainmodule_chmult = new CEnhancedCheckBox(this);
      this.__mainmodule_chmult.name = "__mainmodule_chmult";
      this.__mainmodule_chmult.Left = 120;
      this.__mainmodule_chmult.Top = 168;
      this.__mainmodule_chmult.Width = 115;
      this.__mainmodule_chmult.Height = 20;
      this.__mainmodule_chmult.Text = "Multialmacen";
      this.__mainmodule_chmult.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_chmult.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chmult.Enabled = true;
      this.__mainmodule_chmult.Visible = true;
      this.__mainmodule_chmult.Checked = false;
      this.__mainmodule_chmult.Font = new Font(this.__mainmodule_chmult.Font.Name, 9f, this.__mainmodule_chmult.Font.Style);
      this.__mainmodule_chmult.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_chmult);
      this.htControls.Add((object) "__mainmodule_chmult", (object) this.__mainmodule_chmult);
      this.__mainmodule_tremoto = new CEnhancedTextBox(this);
      this.__mainmodule_tremoto.name = "__mainmodule_tremoto";
      this.__mainmodule_tremoto.Left = 50;
      this.__mainmodule_tremoto.Top = 73;
      this.__mainmodule_tremoto.Width = 185;
      this.__mainmodule_tremoto.Text = "";
      this.__mainmodule_tremoto.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tremoto.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tremoto.Enabled = true;
      this.__mainmodule_tremoto.Visible = true;
      this.__mainmodule_tremoto.Height = 22;
      this.__mainmodule_tremoto.Font = new Font(this.__mainmodule_tremoto.Font.Name, 9f, this.__mainmodule_tremoto.Font.Style);
      this.__mainmodule_tremoto.multiline = false;
      this.__mainmodule_tremoto.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tremoto);
      this.htControls.Add((object) "__mainmodule_tremoto", (object) this.__mainmodule_tremoto);
      this.__mainmodule_label9 = new CEnhancedLabel(this);
      this.__mainmodule_label9.name = "__mainmodule_label9";
      this.__mainmodule_label9.Left = 1;
      this.__mainmodule_label9.Top = 76;
      this.__mainmodule_label9.Width = 55;
      this.__mainmodule_label9.Height = 20;
      this.__mainmodule_label9.Text = "Remoto";
      this.__mainmodule_label9.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label9.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label9.MyEnabled = true;
      this.__mainmodule_label9.Visible = true;
      this.__mainmodule_label9.Transparent = false;
      this.__mainmodule_label9.Font = new Font(this.__mainmodule_label9.Font.Name, 9f, this.__mainmodule_label9.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label9);
      this.htControls.Add((object) "__mainmodule_label9", (object) this.__mainmodule_label9);
      this.__mainmodule_tcorreo2 = new CEnhancedTextBox(this);
      this.__mainmodule_tcorreo2.name = "__mainmodule_tcorreo2";
      this.__mainmodule_tcorreo2.Left = 146;
      this.__mainmodule_tcorreo2.Top = 195;
      this.__mainmodule_tcorreo2.Width = 92;
      this.__mainmodule_tcorreo2.Text = "";
      this.__mainmodule_tcorreo2.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tcorreo2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tcorreo2.Enabled = true;
      this.__mainmodule_tcorreo2.Visible = true;
      this.__mainmodule_tcorreo2.Height = 22;
      this.__mainmodule_tcorreo2.Font = new Font(this.__mainmodule_tcorreo2.Font.Name, 9f, this.__mainmodule_tcorreo2.Font.Style);
      this.__mainmodule_tcorreo2.multiline = false;
      this.__mainmodule_tcorreo2.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tcorreo2);
      this.htControls.Add((object) "__mainmodule_tcorreo2", (object) this.__mainmodule_tcorreo2);
      this.__mainmodule_tcontrol = new CEnhancedTextBox(this);
      this.__mainmodule_tcontrol.name = "__mainmodule_tcontrol";
      this.__mainmodule_tcontrol.Left = 50;
      this.__mainmodule_tcontrol.Top = 167;
      this.__mainmodule_tcontrol.Width = 60;
      this.__mainmodule_tcontrol.Text = "??????????";
      this.__mainmodule_tcontrol.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tcontrol.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tcontrol.Enabled = true;
      this.__mainmodule_tcontrol.Visible = true;
      this.__mainmodule_tcontrol.Height = 22;
      this.__mainmodule_tcontrol.Font = new Font(this.__mainmodule_tcontrol.Font.Name, 9f, this.__mainmodule_tcontrol.Font.Style);
      this.__mainmodule_tcontrol.multiline = false;
      this.__mainmodule_tcontrol.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tcontrol);
      this.htControls.Add((object) "__mainmodule_tcontrol", (object) this.__mainmodule_tcontrol);
      this.__mainmodule_tlinea = new CEnhancedTextBox(this);
      this.__mainmodule_tlinea.name = "__mainmodule_tlinea";
      this.__mainmodule_tlinea.Left = 50;
      this.__mainmodule_tlinea.Top = 142;
      this.__mainmodule_tlinea.Width = 61;
      this.__mainmodule_tlinea.Text = "?????";
      this.__mainmodule_tlinea.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tlinea.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tlinea.Enabled = true;
      this.__mainmodule_tlinea.Visible = true;
      this.__mainmodule_tlinea.Height = 22;
      this.__mainmodule_tlinea.Font = new Font(this.__mainmodule_tlinea.Font.Name, 9f, this.__mainmodule_tlinea.Font.Style);
      this.__mainmodule_tlinea.multiline = false;
      this.__mainmodule_tlinea.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tlinea);
      this.htControls.Add((object) "__mainmodule_tlinea", (object) this.__mainmodule_tlinea);
      this.__mainmodule_label4 = new CEnhancedLabel(this);
      this.__mainmodule_label4.name = "__mainmodule_label4";
      this.__mainmodule_label4.Left = 1;
      this.__mainmodule_label4.Top = 144;
      this.__mainmodule_label4.Width = 55;
      this.__mainmodule_label4.Height = 20;
      this.__mainmodule_label4.Text = "Linea:";
      this.__mainmodule_label4.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label4.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label4.MyEnabled = true;
      this.__mainmodule_label4.Visible = true;
      this.__mainmodule_label4.Transparent = false;
      this.__mainmodule_label4.Font = new Font(this.__mainmodule_label4.Font.Name, 9f, this.__mainmodule_label4.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label4);
      this.htControls.Add((object) "__mainmodule_label4", (object) this.__mainmodule_label4);
      this.__mainmodule_btnsql3 = new CEnhancedButton(this);
      this.__mainmodule_btnsql3.name = "__mainmodule_btnsql3";
      this.__mainmodule_btnsql3.Left = 90;
      this.__mainmodule_btnsql3.Top = 230;
      this.__mainmodule_btnsql3.Width = 65;
      this.__mainmodule_btnsql3.Height = 30;
      this.__mainmodule_btnsql3.Text = "Eliminar";
      this.__mainmodule_btnsql3.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsql3.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsql3.Enabled = true;
      this.__mainmodule_btnsql3.Visible = true;
      this.__mainmodule_btnsql3.Font = new Font(this.__mainmodule_btnsql3.Font.Name, 9f, this.__mainmodule_btnsql3.Font.Style);
      this.__mainmodule_btnsql3.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_btnsql3);
      this.htControls.Add((object) "__mainmodule_btnsql3", (object) this.__mainmodule_btnsql3);
      this.__mainmodule_cboempresa1 = new CEnhancedCombo(this);
      this.__mainmodule_cboempresa1.name = "__mainmodule_cboempresa1";
      this.__mainmodule_cboempresa1.Left = 55;
      this.__mainmodule_cboempresa1.Top = 2;
      this.__mainmodule_cboempresa1.Width = 60;
      this.__mainmodule_cboempresa1.Height = 22;
      this.__mainmodule_cboempresa1.Text = "";
      this.__mainmodule_cboempresa1.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboempresa1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboempresa1.Enabled = true;
      this.__mainmodule_cboempresa1.Visible = true;
      this.__mainmodule_cboempresa1.Font = new Font(this.__mainmodule_cboempresa1.Font.Name, 9f, this.__mainmodule_cboempresa1.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_cboempresa1);
      this.htControls.Add((object) "__mainmodule_cboempresa1", (object) this.__mainmodule_cboempresa1);
      this.__mainmodule_cboempresa1.AddEvents();
      this.__mainmodule_tcorreo = new CEnhancedTextBox(this);
      this.__mainmodule_tcorreo.name = "__mainmodule_tcorreo";
      this.__mainmodule_tcorreo.Left = 50;
      this.__mainmodule_tcorreo.Top = 195;
      this.__mainmodule_tcorreo.Width = 90;
      this.__mainmodule_tcorreo.Text = "";
      this.__mainmodule_tcorreo.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tcorreo.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tcorreo.Enabled = true;
      this.__mainmodule_tcorreo.Visible = true;
      this.__mainmodule_tcorreo.Height = 22;
      this.__mainmodule_tcorreo.Font = new Font(this.__mainmodule_tcorreo.Font.Name, 9f, this.__mainmodule_tcorreo.Font.Style);
      this.__mainmodule_tcorreo.multiline = false;
      this.__mainmodule_tcorreo.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tcorreo);
      this.htControls.Add((object) "__mainmodule_tcorreo", (object) this.__mainmodule_tcorreo);
      this.__mainmodule_label20 = new CEnhancedLabel(this);
      this.__mainmodule_label20.name = "__mainmodule_label20";
      this.__mainmodule_label20.Left = 1;
      this.__mainmodule_label20.Top = 195;
      this.__mainmodule_label20.Width = 51;
      this.__mainmodule_label20.Height = 20;
      this.__mainmodule_label20.Text = "Correo:";
      this.__mainmodule_label20.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label20.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label20.MyEnabled = true;
      this.__mainmodule_label20.Visible = true;
      this.__mainmodule_label20.Transparent = false;
      this.__mainmodule_label20.Font = new Font(this.__mainmodule_label20.Font.Name, 9f, this.__mainmodule_label20.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label20);
      this.htControls.Add((object) "__mainmodule_label20", (object) this.__mainmodule_label20);
      this.__mainmodule_label19 = new CEnhancedLabel(this);
      this.__mainmodule_label19.name = "__mainmodule_label19";
      this.__mainmodule_label19.Left = 1;
      this.__mainmodule_label19.Top = 173;
      this.__mainmodule_label19.Width = 55;
      this.__mainmodule_label19.Height = 20;
      this.__mainmodule_label19.Text = "Ctrl.Alm:";
      this.__mainmodule_label19.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label19.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label19.MyEnabled = true;
      this.__mainmodule_label19.Visible = true;
      this.__mainmodule_label19.Transparent = false;
      this.__mainmodule_label19.Font = new Font(this.__mainmodule_label19.Font.Name, 9f, this.__mainmodule_label19.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label19);
      this.htControls.Add((object) "__mainmodule_label19", (object) this.__mainmodule_label19);
      this.__mainmodule_cboalm = new CEnhancedCombo(this);
      this.__mainmodule_cboalm.name = "__mainmodule_cboalm";
      this.__mainmodule_cboalm.Left = 175;
      this.__mainmodule_cboalm.Top = 142;
      this.__mainmodule_cboalm.Width = 60;
      this.__mainmodule_cboalm.Height = 22;
      this.__mainmodule_cboalm.Text = "";
      this.__mainmodule_cboalm.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboalm.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboalm.Enabled = true;
      this.__mainmodule_cboalm.Visible = true;
      this.__mainmodule_cboalm.Font = new Font(this.__mainmodule_cboalm.Font.Name, 9f, this.__mainmodule_cboalm.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_cboalm);
      this.htControls.Add((object) "__mainmodule_cboalm", (object) this.__mainmodule_cboalm);
      this.__mainmodule_cboalm.AddEvents();
      this.__mainmodule_label18 = new CEnhancedLabel(this);
      this.__mainmodule_label18.name = "__mainmodule_label18";
      this.__mainmodule_label18.Left = 118;
      this.__mainmodule_label18.Top = 145;
      this.__mainmodule_label18.Width = 56;
      this.__mainmodule_label18.Height = 20;
      this.__mainmodule_label18.Text = "Almacen:";
      this.__mainmodule_label18.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label18.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label18.MyEnabled = true;
      this.__mainmodule_label18.Visible = true;
      this.__mainmodule_label18.Transparent = false;
      this.__mainmodule_label18.Font = new Font(this.__mainmodule_label18.Font.Name, 9f, this.__mainmodule_label18.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label18);
      this.htControls.Add((object) "__mainmodule_label18", (object) this.__mainmodule_label18);
      this.__mainmodule_btnsql2 = new CEnhancedButton(this);
      this.__mainmodule_btnsql2.name = "__mainmodule_btnsql2";
      this.__mainmodule_btnsql2.Left = 170;
      this.__mainmodule_btnsql2.Top = 230;
      this.__mainmodule_btnsql2.Width = 65;
      this.__mainmodule_btnsql2.Height = 30;
      this.__mainmodule_btnsql2.Text = "Cancelar";
      this.__mainmodule_btnsql2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsql2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsql2.Enabled = true;
      this.__mainmodule_btnsql2.Visible = true;
      this.__mainmodule_btnsql2.Font = new Font(this.__mainmodule_btnsql2.Font.Name, 9f, this.__mainmodule_btnsql2.Font.Style);
      this.__mainmodule_btnsql2.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_btnsql2);
      this.htControls.Add((object) "__mainmodule_btnsql2", (object) this.__mainmodule_btnsql2);
      this.__mainmodule_btnsql1 = new CEnhancedButton(this);
      this.__mainmodule_btnsql1.name = "__mainmodule_btnsql1";
      this.__mainmodule_btnsql1.Left = 10;
      this.__mainmodule_btnsql1.Top = 230;
      this.__mainmodule_btnsql1.Width = 65;
      this.__mainmodule_btnsql1.Height = 30;
      this.__mainmodule_btnsql1.Text = "Grabar";
      this.__mainmodule_btnsql1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsql1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsql1.Enabled = true;
      this.__mainmodule_btnsql1.Visible = true;
      this.__mainmodule_btnsql1.Font = new Font(this.__mainmodule_btnsql1.Font.Name, 9f, this.__mainmodule_btnsql1.Font.Style);
      this.__mainmodule_btnsql1.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_btnsql1);
      this.htControls.Add((object) "__mainmodule_btnsql1", (object) this.__mainmodule_btnsql1);
      this.__mainmodule_tpuerto = new CEnhancedTextBox(this);
      this.__mainmodule_tpuerto.name = "__mainmodule_tpuerto";
      this.__mainmodule_tpuerto.Left = 195;
      this.__mainmodule_tpuerto.Top = 96;
      this.__mainmodule_tpuerto.Width = 40;
      this.__mainmodule_tpuerto.Text = "";
      this.__mainmodule_tpuerto.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tpuerto.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tpuerto.Enabled = true;
      this.__mainmodule_tpuerto.Visible = true;
      this.__mainmodule_tpuerto.Height = 22;
      this.__mainmodule_tpuerto.Font = new Font(this.__mainmodule_tpuerto.Font.Name, 9f, this.__mainmodule_tpuerto.Font.Style);
      this.__mainmodule_tpuerto.multiline = false;
      this.__mainmodule_tpuerto.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tpuerto);
      this.htControls.Add((object) "__mainmodule_tpuerto", (object) this.__mainmodule_tpuerto);
      this.__mainmodule_tpasssql = new CEnhancedTextBox(this);
      this.__mainmodule_tpasssql.name = "__mainmodule_tpasssql";
      this.__mainmodule_tpasssql.Left = 175;
      this.__mainmodule_tpasssql.Top = 119;
      this.__mainmodule_tpasssql.Width = 60;
      this.__mainmodule_tpasssql.Text = "";
      this.__mainmodule_tpasssql.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tpasssql.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tpasssql.Enabled = true;
      this.__mainmodule_tpasssql.Visible = true;
      this.__mainmodule_tpasssql.Height = 22;
      this.__mainmodule_tpasssql.Font = new Font(this.__mainmodule_tpasssql.Font.Name, 9f, this.__mainmodule_tpasssql.Font.Style);
      this.__mainmodule_tpasssql.multiline = false;
      this.__mainmodule_tpasssql.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tpasssql);
      this.htControls.Add((object) "__mainmodule_tpasssql", (object) this.__mainmodule_tpasssql);
      this.__mainmodule_tuser = new CEnhancedTextBox(this);
      this.__mainmodule_tuser.name = "__mainmodule_tuser";
      this.__mainmodule_tuser.Left = 50;
      this.__mainmodule_tuser.Top = 119;
      this.__mainmodule_tuser.Width = 60;
      this.__mainmodule_tuser.Text = "";
      this.__mainmodule_tuser.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tuser.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tuser.Enabled = true;
      this.__mainmodule_tuser.Visible = true;
      this.__mainmodule_tuser.Height = 22;
      this.__mainmodule_tuser.Font = new Font(this.__mainmodule_tuser.Font.Name, 9f, this.__mainmodule_tuser.Font.Style);
      this.__mainmodule_tuser.multiline = false;
      this.__mainmodule_tuser.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tuser);
      this.htControls.Add((object) "__mainmodule_tuser", (object) this.__mainmodule_tuser);
      this.__mainmodule_tbase = new CEnhancedTextBox(this);
      this.__mainmodule_tbase.name = "__mainmodule_tbase";
      this.__mainmodule_tbase.Left = 50;
      this.__mainmodule_tbase.Top = 96;
      this.__mainmodule_tbase.Width = 95;
      this.__mainmodule_tbase.Text = "";
      this.__mainmodule_tbase.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tbase.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tbase.Enabled = true;
      this.__mainmodule_tbase.Visible = true;
      this.__mainmodule_tbase.Height = 22;
      this.__mainmodule_tbase.Font = new Font(this.__mainmodule_tbase.Font.Name, 9f, this.__mainmodule_tbase.Font.Style);
      this.__mainmodule_tbase.multiline = false;
      this.__mainmodule_tbase.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tbase);
      this.htControls.Add((object) "__mainmodule_tbase", (object) this.__mainmodule_tbase);
      this.__mainmodule_tserver = new CEnhancedTextBox(this);
      this.__mainmodule_tserver.name = "__mainmodule_tserver";
      this.__mainmodule_tserver.Left = 50;
      this.__mainmodule_tserver.Top = 50;
      this.__mainmodule_tserver.Width = 185;
      this.__mainmodule_tserver.Text = "";
      this.__mainmodule_tserver.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tserver.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tserver.Enabled = true;
      this.__mainmodule_tserver.Visible = true;
      this.__mainmodule_tserver.Height = 22;
      this.__mainmodule_tserver.Font = new Font(this.__mainmodule_tserver.Font.Name, 9f, this.__mainmodule_tserver.Font.Style);
      this.__mainmodule_tserver.multiline = false;
      this.__mainmodule_tserver.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tserver);
      this.htControls.Add((object) "__mainmodule_tserver", (object) this.__mainmodule_tserver);
      this.__mainmodule_tnombreemp = new CEnhancedTextBox(this);
      this.__mainmodule_tnombreemp.name = "__mainmodule_tnombreemp";
      this.__mainmodule_tnombreemp.Left = 50;
      this.__mainmodule_tnombreemp.Top = 27;
      this.__mainmodule_tnombreemp.Width = 185;
      this.__mainmodule_tnombreemp.Text = "";
      this.__mainmodule_tnombreemp.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tnombreemp.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tnombreemp.Enabled = true;
      this.__mainmodule_tnombreemp.Visible = true;
      this.__mainmodule_tnombreemp.Height = 22;
      this.__mainmodule_tnombreemp.Font = new Font(this.__mainmodule_tnombreemp.Font.Name, 9f, this.__mainmodule_tnombreemp.Font.Style);
      this.__mainmodule_tnombreemp.multiline = false;
      this.__mainmodule_tnombreemp.AddEvents();
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_tnombreemp);
      this.htControls.Add((object) "__mainmodule_tnombreemp", (object) this.__mainmodule_tnombreemp);
      this.__mainmodule_label16 = new CEnhancedLabel(this);
      this.__mainmodule_label16.name = "__mainmodule_label16";
      this.__mainmodule_label16.Left = 1;
      this.__mainmodule_label16.Top = 27;
      this.__mainmodule_label16.Width = 55;
      this.__mainmodule_label16.Height = 20;
      this.__mainmodule_label16.Text = "Nombre";
      this.__mainmodule_label16.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label16.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label16.MyEnabled = true;
      this.__mainmodule_label16.Visible = true;
      this.__mainmodule_label16.Transparent = false;
      this.__mainmodule_label16.Font = new Font(this.__mainmodule_label16.Font.Name, 9f, this.__mainmodule_label16.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label16);
      this.htControls.Add((object) "__mainmodule_label16", (object) this.__mainmodule_label16);
      this.__mainmodule_label13 = new CEnhancedLabel(this);
      this.__mainmodule_label13.name = "__mainmodule_label13";
      this.__mainmodule_label13.Left = 2;
      this.__mainmodule_label13.Top = 2;
      this.__mainmodule_label13.Width = 60;
      this.__mainmodule_label13.Height = 20;
      this.__mainmodule_label13.Text = "Empresa";
      this.__mainmodule_label13.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label13.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label13.MyEnabled = true;
      this.__mainmodule_label13.Visible = true;
      this.__mainmodule_label13.Transparent = false;
      this.__mainmodule_label13.Font = new Font(this.__mainmodule_label13.Font.Name, 9f, this.__mainmodule_label13.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label13);
      this.htControls.Add((object) "__mainmodule_label13", (object) this.__mainmodule_label13);
      this.__mainmodule_label8 = new CEnhancedLabel(this);
      this.__mainmodule_label8.name = "__mainmodule_label8";
      this.__mainmodule_label8.Left = 151;
      this.__mainmodule_label8.Top = 99;
      this.__mainmodule_label8.Width = 45;
      this.__mainmodule_label8.Height = 20;
      this.__mainmodule_label8.Text = "Puerto:";
      this.__mainmodule_label8.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label8.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label8.MyEnabled = true;
      this.__mainmodule_label8.Visible = true;
      this.__mainmodule_label8.Transparent = false;
      this.__mainmodule_label8.Font = new Font(this.__mainmodule_label8.Font.Name, 9f, this.__mainmodule_label8.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label8);
      this.htControls.Add((object) "__mainmodule_label8", (object) this.__mainmodule_label8);
      this.__mainmodule_label7 = new CEnhancedLabel(this);
      this.__mainmodule_label7.name = "__mainmodule_label7";
      this.__mainmodule_label7.Left = 116;
      this.__mainmodule_label7.Top = 122;
      this.__mainmodule_label7.Width = 60;
      this.__mainmodule_label7.Height = 20;
      this.__mainmodule_label7.Text = "Contrase.";
      this.__mainmodule_label7.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label7.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label7.MyEnabled = true;
      this.__mainmodule_label7.Visible = true;
      this.__mainmodule_label7.Transparent = false;
      this.__mainmodule_label7.Font = new Font(this.__mainmodule_label7.Font.Name, 9f, this.__mainmodule_label7.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label7);
      this.htControls.Add((object) "__mainmodule_label7", (object) this.__mainmodule_label7);
      this.__mainmodule_label6 = new CEnhancedLabel(this);
      this.__mainmodule_label6.name = "__mainmodule_label6";
      this.__mainmodule_label6.Left = 1;
      this.__mainmodule_label6.Top = 122;
      this.__mainmodule_label6.Width = 55;
      this.__mainmodule_label6.Height = 20;
      this.__mainmodule_label6.Text = "Usuario";
      this.__mainmodule_label6.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label6.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label6.MyEnabled = true;
      this.__mainmodule_label6.Visible = true;
      this.__mainmodule_label6.Transparent = false;
      this.__mainmodule_label6.Font = new Font(this.__mainmodule_label6.Font.Name, 9f, this.__mainmodule_label6.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label6);
      this.htControls.Add((object) "__mainmodule_label6", (object) this.__mainmodule_label6);
      this.__mainmodule_label5 = new CEnhancedLabel(this);
      this.__mainmodule_label5.name = "__mainmodule_label5";
      this.__mainmodule_label5.Left = 1;
      this.__mainmodule_label5.Top = 99;
      this.__mainmodule_label5.Width = 55;
      this.__mainmodule_label5.Height = 20;
      this.__mainmodule_label5.Text = "Base ";
      this.__mainmodule_label5.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label5.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label5.MyEnabled = true;
      this.__mainmodule_label5.Visible = true;
      this.__mainmodule_label5.Transparent = false;
      this.__mainmodule_label5.Font = new Font(this.__mainmodule_label5.Font.Name, 9f, this.__mainmodule_label5.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_label5);
      this.htControls.Add((object) "__mainmodule_label5", (object) this.__mainmodule_label5);
      this.__mainmodule_ltsql1 = new CEnhancedLabel(this);
      this.__mainmodule_ltsql1.name = "__mainmodule_ltsql1";
      this.__mainmodule_ltsql1.Left = 1;
      this.__mainmodule_ltsql1.Top = 51;
      this.__mainmodule_ltsql1.Width = 55;
      this.__mainmodule_ltsql1.Height = 20;
      this.__mainmodule_ltsql1.Text = "Servidor";
      this.__mainmodule_ltsql1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltsql1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsql1.MyEnabled = true;
      this.__mainmodule_ltsql1.Visible = true;
      this.__mainmodule_ltsql1.Transparent = false;
      this.__mainmodule_ltsql1.Font = new Font(this.__mainmodule_ltsql1.Font.Name, 9f, this.__mainmodule_ltsql1.Font.Style);
      this.__mainmodule_sqlserver.Controls.Add((Control) this.__mainmodule_ltsql1);
      this.htControls.Add((object) "__mainmodule_ltsql1", (object) this.__mainmodule_ltsql1);
      this.__mainmodule_mnusql1 = new CEnhancedMenu(this);
      this.__mainmodule_mnusql1.name = "__mainmodule_mnusql1";
      this.__mainmodule_mnusql1.Text = "Archivo";
      this.__mainmodule_mnusql1.Enabled = true;
      this.__mainmodule_mnusql1.Checked = false;
      this.__mainmodule_mnusql1.AddToObject("__mainmodule_sqlserver");
      this.__mainmodule_mnusql1.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusql1", (object) this.__mainmodule_mnusql1);
      this.__mainmodule_mnusql2 = new CEnhancedMenu(this);
      this.__mainmodule_mnusql2.name = "__mainmodule_mnusql2";
      this.__mainmodule_mnusql2.Text = "Grabar";
      this.__mainmodule_mnusql2.Enabled = true;
      this.__mainmodule_mnusql2.Checked = false;
      this.__mainmodule_mnusql2.AddToObject("__mainmodule_mnusql1");
      this.__mainmodule_mnusql2.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusql2", (object) this.__mainmodule_mnusql2);
      this.__mainmodule_mnusql3 = new CEnhancedMenu(this);
      this.__mainmodule_mnusql3.name = "__mainmodule_mnusql3";
      this.__mainmodule_mnusql3.Text = "Eliminar";
      this.__mainmodule_mnusql3.Enabled = true;
      this.__mainmodule_mnusql3.Checked = false;
      this.__mainmodule_mnusql3.AddToObject("__mainmodule_mnusql1");
      this.__mainmodule_mnusql3.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusql3", (object) this.__mainmodule_mnusql3);
      this.__mainmodule_mnusql4 = new CEnhancedMenu(this);
      this.__mainmodule_mnusql4.name = "__mainmodule_mnusql4";
      this.__mainmodule_mnusql4.Text = "Cancelar";
      this.__mainmodule_mnusql4.Enabled = true;
      this.__mainmodule_mnusql4.Checked = false;
      this.__mainmodule_mnusql4.AddToObject("__mainmodule_mnusql1");
      this.__mainmodule_mnusql4.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnusql4", (object) this.__mainmodule_mnusql4);
      this.__mainmodule_frmseries = new CEnhancedForm(this);
      this.__mainmodule_frmseries.name = "__mainmodule_frmseries";
      this.__mainmodule_frmseries.Text = "Series";
      this.__mainmodule_frmseries.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_frmseries.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_frmseries.BackColor), 0, 0, this.__mainmodule_frmseries.Width, this.__mainmodule_frmseries.Height);
      this.__mainmodule_frmseries.AddEvents();
      this.htControls.Add((object) "__mainmodule_frmseries", (object) this.__mainmodule_frmseries);
      this.__mainmodule_cboempresapred = new CEnhancedCombo(this);
      this.__mainmodule_cboempresapred.name = "__mainmodule_cboempresapred";
      this.__mainmodule_cboempresapred.Left = 150;
      this.__mainmodule_cboempresapred.Top = 160;
      this.__mainmodule_cboempresapred.Width = 80;
      this.__mainmodule_cboempresapred.Height = 22;
      this.__mainmodule_cboempresapred.Text = "";
      this.__mainmodule_cboempresapred.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboempresapred.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboempresapred.Enabled = true;
      this.__mainmodule_cboempresapred.Visible = true;
      this.__mainmodule_cboempresapred.Font = new Font(this.__mainmodule_cboempresapred.Font.Name, 9f, this.__mainmodule_cboempresapred.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_cboempresapred);
      this.htControls.Add((object) "__mainmodule_cboempresapred", (object) this.__mainmodule_cboempresapred);
      this.__mainmodule_cboempresapred.AddEvents();
      this.__mainmodule_label35 = new CEnhancedLabel(this);
      this.__mainmodule_label35.name = "__mainmodule_label35";
      this.__mainmodule_label35.Left = 5;
      this.__mainmodule_label35.Top = 160;
      this.__mainmodule_label35.Width = 150;
      this.__mainmodule_label35.Height = 25;
      this.__mainmodule_label35.Text = "Empresa predeterminada";
      this.__mainmodule_label35.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label35.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label35.MyEnabled = true;
      this.__mainmodule_label35.Visible = true;
      this.__mainmodule_label35.Transparent = false;
      this.__mainmodule_label35.Font = new Font(this.__mainmodule_label35.Font.Name, 9f, this.__mainmodule_label35.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label35);
      this.htControls.Add((object) "__mainmodule_label35", (object) this.__mainmodule_label35);
      this.__mainmodule_tserped = new CEnhancedTextBox(this);
      this.__mainmodule_tserped.name = "__mainmodule_tserped";
      this.__mainmodule_tserped.Left = 44;
      this.__mainmodule_tserped.Top = 117;
      this.__mainmodule_tserped.Width = 45;
      this.__mainmodule_tserped.Text = "";
      this.__mainmodule_tserped.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tserped.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tserped.Enabled = true;
      this.__mainmodule_tserped.Visible = true;
      this.__mainmodule_tserped.Height = 25;
      this.__mainmodule_tserped.Font = new Font(this.__mainmodule_tserped.Font.Name, 10f, this.__mainmodule_tserped.Font.Style);
      this.__mainmodule_tserped.multiline = false;
      this.__mainmodule_tserped.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_tserped);
      this.htControls.Add((object) "__mainmodule_tserped", (object) this.__mainmodule_tserped);
      this.__mainmodule_label55 = new CEnhancedLabel(this);
      this.__mainmodule_label55.name = "__mainmodule_label55";
      this.__mainmodule_label55.Left = 4;
      this.__mainmodule_label55.Top = 120;
      this.__mainmodule_label55.Width = 50;
      this.__mainmodule_label55.Height = 25;
      this.__mainmodule_label55.Text = "Serie:";
      this.__mainmodule_label55.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label55.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label55.MyEnabled = true;
      this.__mainmodule_label55.Visible = true;
      this.__mainmodule_label55.Transparent = false;
      this.__mainmodule_label55.Font = new Font(this.__mainmodule_label55.Font.Name, 9f, this.__mainmodule_label55.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label55);
      this.htControls.Add((object) "__mainmodule_label55", (object) this.__mainmodule_label55);
      this.__mainmodule_tfolped = new CEnhancedTextBox(this);
      this.__mainmodule_tfolped.name = "__mainmodule_tfolped";
      this.__mainmodule_tfolped.Left = 134;
      this.__mainmodule_tfolped.Top = 117;
      this.__mainmodule_tfolped.Width = 95;
      this.__mainmodule_tfolped.Text = "";
      this.__mainmodule_tfolped.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tfolped.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tfolped.Enabled = true;
      this.__mainmodule_tfolped.Visible = true;
      this.__mainmodule_tfolped.Height = 25;
      this.__mainmodule_tfolped.Font = new Font(this.__mainmodule_tfolped.Font.Name, 10f, this.__mainmodule_tfolped.Font.Style);
      this.__mainmodule_tfolped.multiline = false;
      this.__mainmodule_tfolped.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_tfolped);
      this.htControls.Add((object) "__mainmodule_tfolped", (object) this.__mainmodule_tfolped);
      this.__mainmodule_label54 = new CEnhancedLabel(this);
      this.__mainmodule_label54.name = "__mainmodule_label54";
      this.__mainmodule_label54.Left = 99;
      this.__mainmodule_label54.Top = 120;
      this.__mainmodule_label54.Width = 35;
      this.__mainmodule_label54.Height = 20;
      this.__mainmodule_label54.Text = "Folio:";
      this.__mainmodule_label54.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label54.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label54.MyEnabled = true;
      this.__mainmodule_label54.Visible = true;
      this.__mainmodule_label54.Transparent = false;
      this.__mainmodule_label54.Font = new Font(this.__mainmodule_label54.Font.Name, 9f, this.__mainmodule_label54.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label54);
      this.htControls.Add((object) "__mainmodule_label54", (object) this.__mainmodule_label54);
      this.__mainmodule_label53 = new CEnhancedLabel(this);
      this.__mainmodule_label53.name = "__mainmodule_label53";
      this.__mainmodule_label53.Left = 4;
      this.__mainmodule_label53.Top = 92;
      this.__mainmodule_label53.Width = 80;
      this.__mainmodule_label53.Height = 20;
      this.__mainmodule_label53.Text = "Pedidos";
      this.__mainmodule_label53.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label53.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label53.MyEnabled = true;
      this.__mainmodule_label53.Visible = true;
      this.__mainmodule_label53.Transparent = false;
      this.__mainmodule_label53.Font = new Font(this.__mainmodule_label53.Font.Name, 9f, this.__mainmodule_label53.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label53);
      this.htControls.Add((object) "__mainmodule_label53", (object) this.__mainmodule_label53);
      this.__mainmodule_label52 = new CEnhancedLabel(this);
      this.__mainmodule_label52.name = "__mainmodule_label52";
      this.__mainmodule_label52.Left = 4;
      this.__mainmodule_label52.Top = 42;
      this.__mainmodule_label52.Width = 80;
      this.__mainmodule_label52.Height = 20;
      this.__mainmodule_label52.Text = "Compras";
      this.__mainmodule_label52.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label52.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label52.MyEnabled = true;
      this.__mainmodule_label52.Visible = true;
      this.__mainmodule_label52.Transparent = false;
      this.__mainmodule_label52.Font = new Font(this.__mainmodule_label52.Font.Name, 9f, this.__mainmodule_label52.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label52);
      this.htControls.Add((object) "__mainmodule_label52", (object) this.__mainmodule_label52);
      this.__mainmodule_label17 = new CEnhancedLabel(this);
      this.__mainmodule_label17.name = "__mainmodule_label17";
      this.__mainmodule_label17.Left = 100;
      this.__mainmodule_label17.Top = 68;
      this.__mainmodule_label17.Width = 35;
      this.__mainmodule_label17.Height = 20;
      this.__mainmodule_label17.Text = "Folio:";
      this.__mainmodule_label17.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label17.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label17.MyEnabled = true;
      this.__mainmodule_label17.Visible = true;
      this.__mainmodule_label17.Transparent = false;
      this.__mainmodule_label17.Font = new Font(this.__mainmodule_label17.Font.Name, 9f, this.__mainmodule_label17.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label17);
      this.htControls.Add((object) "__mainmodule_label17", (object) this.__mainmodule_label17);
      this.__mainmodule_tfoliocompra = new CEnhancedTextBox(this);
      this.__mainmodule_tfoliocompra.name = "__mainmodule_tfoliocompra";
      this.__mainmodule_tfoliocompra.Left = 135;
      this.__mainmodule_tfoliocompra.Top = 65;
      this.__mainmodule_tfoliocompra.Width = 95;
      this.__mainmodule_tfoliocompra.Text = "";
      this.__mainmodule_tfoliocompra.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tfoliocompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tfoliocompra.Enabled = true;
      this.__mainmodule_tfoliocompra.Visible = true;
      this.__mainmodule_tfoliocompra.Height = 25;
      this.__mainmodule_tfoliocompra.Font = new Font(this.__mainmodule_tfoliocompra.Font.Name, 10f, this.__mainmodule_tfoliocompra.Font.Style);
      this.__mainmodule_tfoliocompra.multiline = false;
      this.__mainmodule_tfoliocompra.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_tfoliocompra);
      this.htControls.Add((object) "__mainmodule_tfoliocompra", (object) this.__mainmodule_tfoliocompra);
      this.__mainmodule_tseriecompra = new CEnhancedTextBox(this);
      this.__mainmodule_tseriecompra.name = "__mainmodule_tseriecompra";
      this.__mainmodule_tseriecompra.Left = 45;
      this.__mainmodule_tseriecompra.Top = 65;
      this.__mainmodule_tseriecompra.Width = 45;
      this.__mainmodule_tseriecompra.Text = "";
      this.__mainmodule_tseriecompra.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tseriecompra.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tseriecompra.Enabled = true;
      this.__mainmodule_tseriecompra.Visible = true;
      this.__mainmodule_tseriecompra.Height = 25;
      this.__mainmodule_tseriecompra.Font = new Font(this.__mainmodule_tseriecompra.Font.Name, 10f, this.__mainmodule_tseriecompra.Font.Style);
      this.__mainmodule_tseriecompra.multiline = false;
      this.__mainmodule_tseriecompra.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_tseriecompra);
      this.htControls.Add((object) "__mainmodule_tseriecompra", (object) this.__mainmodule_tseriecompra);
      this.__mainmodule_label15 = new CEnhancedLabel(this);
      this.__mainmodule_label15.name = "__mainmodule_label15";
      this.__mainmodule_label15.Left = 5;
      this.__mainmodule_label15.Top = 68;
      this.__mainmodule_label15.Width = 50;
      this.__mainmodule_label15.Height = 25;
      this.__mainmodule_label15.Text = "Serie:";
      this.__mainmodule_label15.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label15.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label15.MyEnabled = true;
      this.__mainmodule_label15.Visible = true;
      this.__mainmodule_label15.Transparent = false;
      this.__mainmodule_label15.Font = new Font(this.__mainmodule_label15.Font.Name, 9f, this.__mainmodule_label15.Font.Style);
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_label15);
      this.htControls.Add((object) "__mainmodule_label15", (object) this.__mainmodule_label15);
      this.__mainmodule_btnsalirseries = new CEnhancedButton(this);
      this.__mainmodule_btnsalirseries.name = "__mainmodule_btnsalirseries";
      this.__mainmodule_btnsalirseries.Left = 123;
      this.__mainmodule_btnsalirseries.Top = 7;
      this.__mainmodule_btnsalirseries.Width = 80;
      this.__mainmodule_btnsalirseries.Height = 30;
      this.__mainmodule_btnsalirseries.Text = "Salir";
      this.__mainmodule_btnsalirseries.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsalirseries.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsalirseries.Enabled = true;
      this.__mainmodule_btnsalirseries.Visible = true;
      this.__mainmodule_btnsalirseries.Font = new Font(this.__mainmodule_btnsalirseries.Font.Name, 9f, this.__mainmodule_btnsalirseries.Font.Style);
      this.__mainmodule_btnsalirseries.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_btnsalirseries);
      this.htControls.Add((object) "__mainmodule_btnsalirseries", (object) this.__mainmodule_btnsalirseries);
      this.__mainmodule_btnseries = new CEnhancedButton(this);
      this.__mainmodule_btnseries.name = "__mainmodule_btnseries";
      this.__mainmodule_btnseries.Left = 23;
      this.__mainmodule_btnseries.Top = 7;
      this.__mainmodule_btnseries.Width = 80;
      this.__mainmodule_btnseries.Height = 30;
      this.__mainmodule_btnseries.Text = "Aceptar";
      this.__mainmodule_btnseries.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnseries.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnseries.Enabled = true;
      this.__mainmodule_btnseries.Visible = true;
      this.__mainmodule_btnseries.Font = new Font(this.__mainmodule_btnseries.Font.Name, 9f, this.__mainmodule_btnseries.Font.Style);
      this.__mainmodule_btnseries.AddEvents();
      this.__mainmodule_frmseries.Controls.Add((Control) this.__mainmodule_btnseries);
      this.htControls.Add((object) "__mainmodule_btnseries", (object) this.__mainmodule_btnseries);
      this.__mainmodule_main = new CEnhancedForm(this);
      this.__mainmodule_main.name = "__mainmodule_main";
      this.__mainmodule_main.Text = "Invent  Mobile";
      this.__mainmodule_main.BackColor = Color.FromArgb(-12550016);
      this.__mainmodule_main.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_main.BackColor), 0, 0, this.__mainmodule_main.Width, this.__mainmodule_main.Height);
      this.__mainmodule_main.AddEvents();
      this.htControls.Add((object) "__mainmodule_main", (object) this.__mainmodule_main);
      this.__mainmodule_image1 = new CEnhancedImage(this);
      this.__mainmodule_image1.name = "__mainmodule_image1";
      this.__mainmodule_image1.Left = 65;
      this.__mainmodule_image1.Top = 130;
      this.__mainmodule_image1.Width = 175;
      this.__mainmodule_image1.Height = 105;
      this.__mainmodule_image1.BackColor = Color.FromArgb(-657956);
      this.__mainmodule_image1.Enabled = true;
      this.__mainmodule_image1.Visible = true;
      this.__mainmodule_image1.MyImageMode = "cCenterImage";
      this.__mainmodule_image1.MyBitmap = this.Other.GetBitmapFromResource("b4p.images (4).jpg");
      this.__mainmodule_image1.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_image1);
      this.htControls.Add((object) "__mainmodule_image1", (object) this.__mainmodule_image1);
      this.__mainmodule_label28 = new CEnhancedLabel(this);
      this.__mainmodule_label28.name = "__mainmodule_label28";
      this.__mainmodule_label28.Left = 0;
      this.__mainmodule_label28.Top = 190;
      this.__mainmodule_label28.Width = 80;
      this.__mainmodule_label28.Height = 20;
      this.__mainmodule_label28.Text = "V.3.14.015";
      this.__mainmodule_label28.BackColor = Color.FromArgb(-6699525);
      this.__mainmodule_label28.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label28.MyEnabled = true;
      this.__mainmodule_label28.Visible = true;
      this.__mainmodule_label28.Transparent = true;
      this.__mainmodule_label28.Font = new Font(this.__mainmodule_label28.Font.Name, 8f, this.__mainmodule_label28.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_label28);
      this.htControls.Add((object) "__mainmodule_label28", (object) this.__mainmodule_label28);
      this.__mainmodule_chimportar = new CEnhancedCheckBox(this);
      this.__mainmodule_chimportar.name = "__mainmodule_chimportar";
      this.__mainmodule_chimportar.Left = 170;
      this.__mainmodule_chimportar.Top = 75;
      this.__mainmodule_chimportar.Width = 75;
      this.__mainmodule_chimportar.Height = 22;
      this.__mainmodule_chimportar.Text = "Articulos";
      this.__mainmodule_chimportar.BackColor = Color.FromArgb(-12550016);
      this.__mainmodule_chimportar.ForeColor = Color.FromArgb(-1);
      this.__mainmodule_chimportar.Enabled = true;
      this.__mainmodule_chimportar.Visible = true;
      this.__mainmodule_chimportar.Checked = false;
      this.__mainmodule_chimportar.Font = new Font(this.__mainmodule_chimportar.Font.Name, 9f, this.__mainmodule_chimportar.Font.Style);
      this.__mainmodule_chimportar.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_chimportar);
      this.htControls.Add((object) "__mainmodule_chimportar", (object) this.__mainmodule_chimportar);
      this.__mainmodule_cboempresa = new CEnhancedCombo(this);
      this.__mainmodule_cboempresa.name = "__mainmodule_cboempresa";
      this.__mainmodule_cboempresa.Left = 75;
      this.__mainmodule_cboempresa.Top = 2;
      this.__mainmodule_cboempresa.Width = 60;
      this.__mainmodule_cboempresa.Height = 25;
      this.__mainmodule_cboempresa.Text = "";
      this.__mainmodule_cboempresa.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboempresa.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboempresa.Enabled = true;
      this.__mainmodule_cboempresa.Visible = true;
      this.__mainmodule_cboempresa.Font = new Font(this.__mainmodule_cboempresa.Font.Name, 10f, this.__mainmodule_cboempresa.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_cboempresa);
      this.htControls.Add((object) "__mainmodule_cboempresa", (object) this.__mainmodule_cboempresa);
      this.__mainmodule_cboempresa.AddEvents();
      this.__mainmodule_tusuario = new CEnhancedTextBox(this);
      this.__mainmodule_tusuario.name = "__mainmodule_tusuario";
      this.__mainmodule_tusuario.Left = 75;
      this.__mainmodule_tusuario.Top = 30;
      this.__mainmodule_tusuario.Width = 90;
      this.__mainmodule_tusuario.Text = "Administrador";
      this.__mainmodule_tusuario.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tusuario.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tusuario.Enabled = true;
      this.__mainmodule_tusuario.Visible = true;
      this.__mainmodule_tusuario.Height = 22;
      this.__mainmodule_tusuario.Font = new Font(this.__mainmodule_tusuario.Font.Name, 9f, this.__mainmodule_tusuario.Font.Style);
      this.__mainmodule_tusuario.multiline = false;
      this.__mainmodule_tusuario.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_tusuario);
      this.htControls.Add((object) "__mainmodule_tusuario", (object) this.__mainmodule_tusuario);
      this.__mainmodule_tpassword = new CEnhancedTextBox(this);
      this.__mainmodule_tpassword.name = "__mainmodule_tpassword";
      this.__mainmodule_tpassword.Left = 75;
      this.__mainmodule_tpassword.Top = 55;
      this.__mainmodule_tpassword.Width = 90;
      this.__mainmodule_tpassword.Text = "";
      this.__mainmodule_tpassword.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tpassword.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tpassword.Enabled = true;
      this.__mainmodule_tpassword.Visible = true;
      this.__mainmodule_tpassword.Height = 22;
      this.__mainmodule_tpassword.Font = new Font(this.__mainmodule_tpassword.Font.Name, 9f, this.__mainmodule_tpassword.Font.Style);
      this.__mainmodule_tpassword.multiline = false;
      this.__mainmodule_tpassword.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_tpassword);
      this.htControls.Add((object) "__mainmodule_tpassword", (object) this.__mainmodule_tpassword);
      this.__mainmodule_btnaceptar = new CEnhancedButton(this);
      this.__mainmodule_btnaceptar.name = "__mainmodule_btnaceptar";
      this.__mainmodule_btnaceptar.Left = 175;
      this.__mainmodule_btnaceptar.Top = 30;
      this.__mainmodule_btnaceptar.Width = 61;
      this.__mainmodule_btnaceptar.Height = 40;
      this.__mainmodule_btnaceptar.Text = "Aceptar";
      this.__mainmodule_btnaceptar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnaceptar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnaceptar.Enabled = true;
      this.__mainmodule_btnaceptar.Visible = true;
      this.__mainmodule_btnaceptar.Font = new Font(this.__mainmodule_btnaceptar.Font.Name, 9f, this.__mainmodule_btnaceptar.Font.Style);
      this.__mainmodule_btnaceptar.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_btnaceptar);
      this.htControls.Add((object) "__mainmodule_btnaceptar", (object) this.__mainmodule_btnaceptar);
      this.__mainmodule_btnmain8 = new CEnhancedButton(this);
      this.__mainmodule_btnmain8.name = "__mainmodule_btnmain8";
      this.__mainmodule_btnmain8.Left = 175;
      this.__mainmodule_btnmain8.Top = 1;
      this.__mainmodule_btnmain8.Width = 61;
      this.__mainmodule_btnmain8.Height = 25;
      this.__mainmodule_btnmain8.Text = "Salir";
      this.__mainmodule_btnmain8.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnmain8.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnmain8.Enabled = true;
      this.__mainmodule_btnmain8.Visible = true;
      this.__mainmodule_btnmain8.Font = new Font(this.__mainmodule_btnmain8.Font.Name, 9f, this.__mainmodule_btnmain8.Font.Style);
      this.__mainmodule_btnmain8.AddEvents();
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_btnmain8);
      this.htControls.Add((object) "__mainmodule_btnmain8", (object) this.__mainmodule_btnmain8);
      this.__mainmodule_ltsocial = new CEnhancedLabel(this);
      this.__mainmodule_ltsocial.name = "__mainmodule_ltsocial";
      this.__mainmodule_ltsocial.Left = 2;
      this.__mainmodule_ltsocial.Top = 80;
      this.__mainmodule_ltsocial.Width = 160;
      this.__mainmodule_ltsocial.Height = 18;
      this.__mainmodule_ltsocial.Text = "";
      this.__mainmodule_ltsocial.BackColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsocial.ForeColor = Color.FromArgb(-16711936);
      this.__mainmodule_ltsocial.MyEnabled = true;
      this.__mainmodule_ltsocial.Visible = true;
      this.__mainmodule_ltsocial.Transparent = false;
      this.__mainmodule_ltsocial.Font = new Font(this.__mainmodule_ltsocial.Font.Name, 9f, this.__mainmodule_ltsocial.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_ltsocial);
      this.htControls.Add((object) "__mainmodule_ltsocial", (object) this.__mainmodule_ltsocial);
      this.__mainmodule_ltart = new CEnhancedLabel(this);
      this.__mainmodule_ltart.name = "__mainmodule_ltart";
      this.__mainmodule_ltart.Left = 2;
      this.__mainmodule_ltart.Top = 99;
      this.__mainmodule_ltart.Width = 239;
      this.__mainmodule_ltart.Height = 30;
      this.__mainmodule_ltart.Text = "";
      this.__mainmodule_ltart.BackColor = Color.FromArgb((int) short.MinValue);
      this.__mainmodule_ltart.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltart.MyEnabled = true;
      this.__mainmodule_ltart.Visible = true;
      this.__mainmodule_ltart.Transparent = false;
      this.__mainmodule_ltart.Font = new Font(this.__mainmodule_ltart.Font.Name, 9f, this.__mainmodule_ltart.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_ltart);
      this.htControls.Add((object) "__mainmodule_ltart", (object) this.__mainmodule_ltart);
      this.__mainmodule_ltsync = new CEnhancedLabel(this);
      this.__mainmodule_ltsync.name = "__mainmodule_ltsync";
      this.__mainmodule_ltsync.Left = 2;
      this.__mainmodule_ltsync.Top = 235;
      this.__mainmodule_ltsync.Width = 237;
      this.__mainmodule_ltsync.Height = 29;
      this.__mainmodule_ltsync.Text = "";
      this.__mainmodule_ltsync.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltsync.ForeColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltsync.MyEnabled = true;
      this.__mainmodule_ltsync.Visible = true;
      this.__mainmodule_ltsync.Transparent = false;
      this.__mainmodule_ltsync.Font = new Font(this.__mainmodule_ltsync.Font.Name, 9f, this.__mainmodule_ltsync.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_ltsync);
      this.htControls.Add((object) "__mainmodule_ltsync", (object) this.__mainmodule_ltsync);
      this.__mainmodule_label23 = new CEnhancedLabel(this);
      this.__mainmodule_label23.name = "__mainmodule_label23";
      this.__mainmodule_label23.Left = 4;
      this.__mainmodule_label23.Top = 58;
      this.__mainmodule_label23.Width = 74;
      this.__mainmodule_label23.Height = 22;
      this.__mainmodule_label23.Text = "Contraseña:";
      this.__mainmodule_label23.BackColor = Color.FromArgb(-1);
      this.__mainmodule_label23.ForeColor = Color.FromArgb(-1);
      this.__mainmodule_label23.MyEnabled = true;
      this.__mainmodule_label23.Visible = true;
      this.__mainmodule_label23.Transparent = true;
      this.__mainmodule_label23.Font = new Font(this.__mainmodule_label23.Font.Name, 9f, this.__mainmodule_label23.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_label23);
      this.htControls.Add((object) "__mainmodule_label23", (object) this.__mainmodule_label23);
      this.__mainmodule_label22 = new CEnhancedLabel(this);
      this.__mainmodule_label22.name = "__mainmodule_label22";
      this.__mainmodule_label22.Left = 23;
      this.__mainmodule_label22.Top = 35;
      this.__mainmodule_label22.Width = 55;
      this.__mainmodule_label22.Height = 22;
      this.__mainmodule_label22.Text = "Usuario:";
      this.__mainmodule_label22.BackColor = Color.FromArgb(-1);
      this.__mainmodule_label22.ForeColor = Color.FromArgb(-1);
      this.__mainmodule_label22.MyEnabled = true;
      this.__mainmodule_label22.Visible = true;
      this.__mainmodule_label22.Transparent = true;
      this.__mainmodule_label22.Font = new Font(this.__mainmodule_label22.Font.Name, 9f, this.__mainmodule_label22.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_label22);
      this.htControls.Add((object) "__mainmodule_label22", (object) this.__mainmodule_label22);
      this.__mainmodule_label21 = new CEnhancedLabel(this);
      this.__mainmodule_label21.name = "__mainmodule_label21";
      this.__mainmodule_label21.Left = 15;
      this.__mainmodule_label21.Top = 5;
      this.__mainmodule_label21.Width = 57;
      this.__mainmodule_label21.Height = 22;
      this.__mainmodule_label21.Text = "Empresa:";
      this.__mainmodule_label21.BackColor = Color.FromArgb(-1);
      this.__mainmodule_label21.ForeColor = Color.FromArgb(-1);
      this.__mainmodule_label21.MyEnabled = true;
      this.__mainmodule_label21.Visible = true;
      this.__mainmodule_label21.Transparent = true;
      this.__mainmodule_label21.Font = new Font(this.__mainmodule_label21.Font.Name, 9f, this.__mainmodule_label21.Font.Style);
      this.__mainmodule_main.Controls.Add((Control) this.__mainmodule_label21);
      this.htControls.Add((object) "__mainmodule_label21", (object) this.__mainmodule_label21);
      this.__mainmodule_config = new CEnhancedForm(this);
      this.__mainmodule_config.name = "__mainmodule_config";
      this.__mainmodule_config.Text = "Configuracion";
      this.__mainmodule_config.BackColor = Color.FromArgb(-731233);
      this.__mainmodule_config.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_config.BackColor), 0, 0, this.__mainmodule_config.Width, this.__mainmodule_config.Height);
      this.__mainmodule_config.AddEvents();
      this.htControls.Add((object) "__mainmodule_config", (object) this.__mainmodule_config);
      this.__mainmodule_btncrearbase = new CEnhancedButton(this);
      this.__mainmodule_btncrearbase.name = "__mainmodule_btncrearbase";
      this.__mainmodule_btncrearbase.Left = 5;
      this.__mainmodule_btncrearbase.Top = 126;
      this.__mainmodule_btncrearbase.Width = 110;
      this.__mainmodule_btncrearbase.Height = 30;
      this.__mainmodule_btncrearbase.Text = "Crea BD";
      this.__mainmodule_btncrearbase.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btncrearbase.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btncrearbase.Enabled = true;
      this.__mainmodule_btncrearbase.Visible = true;
      this.__mainmodule_btncrearbase.Font = new Font(this.__mainmodule_btncrearbase.Font.Name, 9f, this.__mainmodule_btncrearbase.Font.Style);
      this.__mainmodule_btncrearbase.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btncrearbase);
      this.htControls.Add((object) "__mainmodule_btncrearbase", (object) this.__mainmodule_btncrearbase);
      this.__mainmodule_btnareas = new CEnhancedButton(this);
      this.__mainmodule_btnareas.name = "__mainmodule_btnareas";
      this.__mainmodule_btnareas.Left = 117;
      this.__mainmodule_btnareas.Top = 126;
      this.__mainmodule_btnareas.Width = 110;
      this.__mainmodule_btnareas.Height = 30;
      this.__mainmodule_btnareas.Text = "Areas";
      this.__mainmodule_btnareas.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnareas.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnareas.Enabled = true;
      this.__mainmodule_btnareas.Visible = true;
      this.__mainmodule_btnareas.Font = new Font(this.__mainmodule_btnareas.Font.Name, 9f, this.__mainmodule_btnareas.Font.Style);
      this.__mainmodule_btnareas.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btnareas);
      this.htControls.Add((object) "__mainmodule_btnareas", (object) this.__mainmodule_btnareas);
      this.__mainmodule_btncompactar = new CEnhancedButton(this);
      this.__mainmodule_btncompactar.name = "__mainmodule_btncompactar";
      this.__mainmodule_btncompactar.Left = 117;
      this.__mainmodule_btncompactar.Top = 95;
      this.__mainmodule_btncompactar.Width = 110;
      this.__mainmodule_btncompactar.Height = 30;
      this.__mainmodule_btncompactar.Text = "Compactar";
      this.__mainmodule_btncompactar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btncompactar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btncompactar.Enabled = true;
      this.__mainmodule_btncompactar.Visible = true;
      this.__mainmodule_btncompactar.Font = new Font(this.__mainmodule_btncompactar.Font.Name, 9f, this.__mainmodule_btncompactar.Font.Style);
      this.__mainmodule_btncompactar.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btncompactar);
      this.htControls.Add((object) "__mainmodule_btncompactar", (object) this.__mainmodule_btncompactar);
      this.__mainmodule_btntea = new CEnhancedButton(this);
      this.__mainmodule_btntea.name = "__mainmodule_btntea";
      this.__mainmodule_btntea.Left = 5;
      this.__mainmodule_btntea.Top = 95;
      this.__mainmodule_btntea.Width = 110;
      this.__mainmodule_btntea.Height = 30;
      this.__mainmodule_btntea.Text = "Coneccion TEA";
      this.__mainmodule_btntea.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btntea.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btntea.Enabled = true;
      this.__mainmodule_btntea.Visible = true;
      this.__mainmodule_btntea.Font = new Font(this.__mainmodule_btntea.Font.Name, 9f, this.__mainmodule_btntea.Font.Style);
      this.__mainmodule_btntea.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btntea);
      this.htControls.Add((object) "__mainmodule_btntea", (object) this.__mainmodule_btntea);
      this.__mainmodule_chcaja = new CEnhancedCheckBox(this);
      this.__mainmodule_chcaja.name = "__mainmodule_chcaja";
      this.__mainmodule_chcaja.Left = 2;
      this.__mainmodule_chcaja.Top = 161;
      this.__mainmodule_chcaja.Width = 85;
      this.__mainmodule_chcaja.Height = 25;
      this.__mainmodule_chcaja.Text = "Base Caja";
      this.__mainmodule_chcaja.BackColor = Color.FromArgb(-731233);
      this.__mainmodule_chcaja.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chcaja.Enabled = false;
      this.__mainmodule_chcaja.Visible = true;
      this.__mainmodule_chcaja.Checked = false;
      this.__mainmodule_chcaja.Font = new Font(this.__mainmodule_chcaja.Font.Name, 9f, this.__mainmodule_chcaja.Font.Style);
      this.__mainmodule_chcaja.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_chcaja);
      this.htControls.Add((object) "__mainmodule_chcaja", (object) this.__mainmodule_chcaja);
      this.__mainmodule_btnenviarinven = new CEnhancedButton(this);
      this.__mainmodule_btnenviarinven.name = "__mainmodule_btnenviarinven";
      this.__mainmodule_btnenviarinven.Left = 5;
      this.__mainmodule_btnenviarinven.Top = 64;
      this.__mainmodule_btnenviarinven.Width = 110;
      this.__mainmodule_btnenviarinven.Height = 30;
      this.__mainmodule_btnenviarinven.Text = "Enviar Inventario";
      this.__mainmodule_btnenviarinven.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnenviarinven.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnenviarinven.Enabled = true;
      this.__mainmodule_btnenviarinven.Visible = true;
      this.__mainmodule_btnenviarinven.Font = new Font(this.__mainmodule_btnenviarinven.Font.Name, 9f, this.__mainmodule_btnenviarinven.Font.Style);
      this.__mainmodule_btnenviarinven.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btnenviarinven);
      this.htControls.Add((object) "__mainmodule_btnenviarinven", (object) this.__mainmodule_btnenviarinven);
      this.__mainmodule_ltllenar = new CEnhancedLabel(this);
      this.__mainmodule_ltllenar.name = "__mainmodule_ltllenar";
      this.__mainmodule_ltllenar.Left = 10;
      this.__mainmodule_ltllenar.Top = 230;
      this.__mainmodule_ltllenar.Width = 219;
      this.__mainmodule_ltllenar.Height = 25;
      this.__mainmodule_ltllenar.Text = "";
      this.__mainmodule_ltllenar.BackColor = Color.FromArgb(-731233);
      this.__mainmodule_ltllenar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltllenar.MyEnabled = true;
      this.__mainmodule_ltllenar.Visible = true;
      this.__mainmodule_ltllenar.Transparent = false;
      this.__mainmodule_ltllenar.Font = new Font(this.__mainmodule_ltllenar.Font.Name, 9f, this.__mainmodule_ltllenar.Font.Style);
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_ltllenar);
      this.htControls.Add((object) "__mainmodule_ltllenar", (object) this.__mainmodule_ltllenar);
      this.__mainmodule_btnutils = new CEnhancedButton(this);
      this.__mainmodule_btnutils.name = "__mainmodule_btnutils";
      this.__mainmodule_btnutils.Left = 117;
      this.__mainmodule_btnutils.Top = 64;
      this.__mainmodule_btnutils.Width = 110;
      this.__mainmodule_btnutils.Height = 30;
      this.__mainmodule_btnutils.Text = "Series";
      this.__mainmodule_btnutils.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnutils.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnutils.Enabled = true;
      this.__mainmodule_btnutils.Visible = true;
      this.__mainmodule_btnutils.Font = new Font(this.__mainmodule_btnutils.Font.Name, 9f, this.__mainmodule_btnutils.Font.Style);
      this.__mainmodule_btnutils.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btnutils);
      this.htControls.Add((object) "__mainmodule_btnutils", (object) this.__mainmodule_btnutils);
      this.__mainmodule_btnuser = new CEnhancedButton(this);
      this.__mainmodule_btnuser.name = "__mainmodule_btnuser";
      this.__mainmodule_btnuser.Left = 5;
      this.__mainmodule_btnuser.Top = 33;
      this.__mainmodule_btnuser.Width = 110;
      this.__mainmodule_btnuser.Height = 30;
      this.__mainmodule_btnuser.Text = "Usuarios";
      this.__mainmodule_btnuser.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnuser.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnuser.Enabled = true;
      this.__mainmodule_btnuser.Visible = true;
      this.__mainmodule_btnuser.Font = new Font(this.__mainmodule_btnuser.Font.Name, 9f, this.__mainmodule_btnuser.Font.Style);
      this.__mainmodule_btnuser.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btnuser);
      this.htControls.Add((object) "__mainmodule_btnuser", (object) this.__mainmodule_btnuser);
      this.__mainmodule_btnsql = new CEnhancedButton(this);
      this.__mainmodule_btnsql.name = "__mainmodule_btnsql";
      this.__mainmodule_btnsql.Left = 5;
      this.__mainmodule_btnsql.Top = 2;
      this.__mainmodule_btnsql.Width = 110;
      this.__mainmodule_btnsql.Height = 30;
      this.__mainmodule_btnsql.Text = "Empresas";
      this.__mainmodule_btnsql.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnsql.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnsql.Enabled = true;
      this.__mainmodule_btnsql.Visible = true;
      this.__mainmodule_btnsql.Font = new Font(this.__mainmodule_btnsql.Font.Name, 9f, this.__mainmodule_btnsql.Font.Style);
      this.__mainmodule_btnsql.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_btnsql);
      this.htControls.Add((object) "__mainmodule_btnsql", (object) this.__mainmodule_btnsql);
      this.__mainmodule_cmdvaciarinvent = new CEnhancedButton(this);
      this.__mainmodule_cmdvaciarinvent.name = "__mainmodule_cmdvaciarinvent";
      this.__mainmodule_cmdvaciarinvent.Left = 117;
      this.__mainmodule_cmdvaciarinvent.Top = 33;
      this.__mainmodule_cmdvaciarinvent.Width = 110;
      this.__mainmodule_cmdvaciarinvent.Height = 30;
      this.__mainmodule_cmdvaciarinvent.Text = "Vaciar BASE";
      this.__mainmodule_cmdvaciarinvent.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdvaciarinvent.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdvaciarinvent.Enabled = true;
      this.__mainmodule_cmdvaciarinvent.Visible = true;
      this.__mainmodule_cmdvaciarinvent.Font = new Font(this.__mainmodule_cmdvaciarinvent.Font.Name, 9f, this.__mainmodule_cmdvaciarinvent.Font.Style);
      this.__mainmodule_cmdvaciarinvent.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_cmdvaciarinvent);
      this.htControls.Add((object) "__mainmodule_cmdvaciarinvent", (object) this.__mainmodule_cmdvaciarinvent);
      this.__mainmodule_cmdrutapcc = new CEnhancedButton(this);
      this.__mainmodule_cmdrutapcc.name = "__mainmodule_cmdrutapcc";
      this.__mainmodule_cmdrutapcc.Left = 117;
      this.__mainmodule_cmdrutapcc.Top = 2;
      this.__mainmodule_cmdrutapcc.Width = 110;
      this.__mainmodule_cmdrutapcc.Height = 30;
      this.__mainmodule_cmdrutapcc.Text = "Salir";
      this.__mainmodule_cmdrutapcc.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdrutapcc.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdrutapcc.Enabled = true;
      this.__mainmodule_cmdrutapcc.Visible = true;
      this.__mainmodule_cmdrutapcc.Font = new Font(this.__mainmodule_cmdrutapcc.Font.Name, 9f, this.__mainmodule_cmdrutapcc.Font.Style);
      this.__mainmodule_cmdrutapcc.AddEvents();
      this.__mainmodule_config.Controls.Add((Control) this.__mainmodule_cmdrutapcc);
      this.htControls.Add((object) "__mainmodule_cmdrutapcc", (object) this.__mainmodule_cmdrutapcc);
      this.__mainmodule_enviar = new CEnhancedForm(this);
      this.__mainmodule_enviar.name = "__mainmodule_enviar";
      this.__mainmodule_enviar.Text = "Enviar inventario";
      this.__mainmodule_enviar.BackColor = Color.FromArgb(-5778440);
      this.__mainmodule_enviar.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_enviar.BackColor), 0, 0, this.__mainmodule_enviar.Width, this.__mainmodule_enviar.Height);
      this.__mainmodule_enviar.AddEvents();
      this.htControls.Add((object) "__mainmodule_enviar", (object) this.__mainmodule_enviar);
      this.__mainmodule_label51 = new CEnhancedLabel(this);
      this.__mainmodule_label51.name = "__mainmodule_label51";
      this.__mainmodule_label51.Left = 0;
      this.__mainmodule_label51.Top = 165;
      this.__mainmodule_label51.Width = 125;
      this.__mainmodule_label51.Height = 20;
      this.__mainmodule_label51.Text = "SQL SERVER";
      this.__mainmodule_label51.BackColor = Color.FromArgb(-7484934);
      this.__mainmodule_label51.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label51.MyEnabled = true;
      this.__mainmodule_label51.Visible = true;
      this.__mainmodule_label51.Transparent = false;
      this.__mainmodule_label51.Font = new Font(this.__mainmodule_label51.Font.Name, 10f, this.__mainmodule_label51.Font.Style);
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_label51);
      this.htControls.Add((object) "__mainmodule_label51", (object) this.__mainmodule_label51);
      this.__mainmodule_trutapc = new CEnhancedTextBox(this);
      this.__mainmodule_trutapc.name = "__mainmodule_trutapc";
      this.__mainmodule_trutapc.Left = 4;
      this.__mainmodule_trutapc.Top = 74;
      this.__mainmodule_trutapc.Width = 230;
      this.__mainmodule_trutapc.Text = "\\\\servidor\\dacaspel";
      this.__mainmodule_trutapc.BackColor = Color.FromArgb(-1);
      this.__mainmodule_trutapc.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_trutapc.Enabled = true;
      this.__mainmodule_trutapc.Visible = false;
      this.__mainmodule_trutapc.Height = 22;
      this.__mainmodule_trutapc.Font = new Font(this.__mainmodule_trutapc.Font.Name, 9f, this.__mainmodule_trutapc.Font.Style);
      this.__mainmodule_trutapc.multiline = false;
      this.__mainmodule_trutapc.AddEvents();
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_trutapc);
      this.htControls.Add((object) "__mainmodule_trutapc", (object) this.__mainmodule_trutapc);
      this.__mainmodule_chenviarpc = new CEnhancedCheckBox(this);
      this.__mainmodule_chenviarpc.name = "__mainmodule_chenviarpc";
      this.__mainmodule_chenviarpc.Left = 105;
      this.__mainmodule_chenviarpc.Top = 165;
      this.__mainmodule_chenviarpc.Width = 135;
      this.__mainmodule_chenviarpc.Height = 25;
      this.__mainmodule_chenviarpc.Text = "Enviar a PC";
      this.__mainmodule_chenviarpc.BackColor = Color.FromArgb(-5778440);
      this.__mainmodule_chenviarpc.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_chenviarpc.Enabled = true;
      this.__mainmodule_chenviarpc.Visible = false;
      this.__mainmodule_chenviarpc.Checked = true;
      this.__mainmodule_chenviarpc.Font = new Font(this.__mainmodule_chenviarpc.Font.Name, 9f, this.__mainmodule_chenviarpc.Font.Style);
      this.__mainmodule_chenviarpc.AddEvents();
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_chenviarpc);
      this.htControls.Add((object) "__mainmodule_chenviarpc", (object) this.__mainmodule_chenviarpc);
      this.__mainmodule_timer1 = new CEnhancedTimer(this);
      this.__mainmodule_timer1.name = "__mainmodule_timer1";
      this.__mainmodule_timer1.Enabled = false;
      this.__mainmodule_timer1.Interval = 500;
      this.__mainmodule_timer1.AddEvents();
      this.htControls.Add((object) "__mainmodule_timer1", (object) this.__mainmodule_timer1);
      this.__mainmodule_ltnum = new CEnhancedLabel(this);
      this.__mainmodule_ltnum.name = "__mainmodule_ltnum";
      this.__mainmodule_ltnum.Left = 5;
      this.__mainmodule_ltnum.Top = 141;
      this.__mainmodule_ltnum.Width = 237;
      this.__mainmodule_ltnum.Height = 20;
      this.__mainmodule_ltnum.Text = "";
      this.__mainmodule_ltnum.BackColor = Color.FromArgb(-7484934);
      this.__mainmodule_ltnum.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltnum.MyEnabled = true;
      this.__mainmodule_ltnum.Visible = true;
      this.__mainmodule_ltnum.Transparent = false;
      this.__mainmodule_ltnum.Font = new Font(this.__mainmodule_ltnum.Font.Name, 10f, this.__mainmodule_ltnum.Font.Style);
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_ltnum);
      this.htControls.Add((object) "__mainmodule_ltnum", (object) this.__mainmodule_ltnum);
      this.__mainmodule_cboconex = new CEnhancedCombo(this);
      this.__mainmodule_cboconex.name = "__mainmodule_cboconex";
      this.__mainmodule_cboconex.Left = 40;
      this.__mainmodule_cboconex.Top = 46;
      this.__mainmodule_cboconex.Width = 165;
      this.__mainmodule_cboconex.Height = 22;
      this.__mainmodule_cboconex.Text = "";
      this.__mainmodule_cboconex.BackColor = Color.FromArgb(-1);
      this.__mainmodule_cboconex.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cboconex.Enabled = true;
      this.__mainmodule_cboconex.Visible = false;
      this.__mainmodule_cboconex.Font = new Font(this.__mainmodule_cboconex.Font.Name, 9f, this.__mainmodule_cboconex.Font.Style);
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_cboconex);
      this.htControls.Add((object) "__mainmodule_cboconex", (object) this.__mainmodule_cboconex);
      this.__mainmodule_cboconex.AddEvents();
      this.__mainmodule_ltsend2 = new CEnhancedLabel(this);
      this.__mainmodule_ltsend2.name = "__mainmodule_ltsend2";
      this.__mainmodule_ltsend2.Left = 5;
      this.__mainmodule_ltsend2.Top = 119;
      this.__mainmodule_ltsend2.Width = 229;
      this.__mainmodule_ltsend2.Height = 20;
      this.__mainmodule_ltsend2.Text = "";
      this.__mainmodule_ltsend2.BackColor = Color.FromArgb(-7484934);
      this.__mainmodule_ltsend2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsend2.MyEnabled = true;
      this.__mainmodule_ltsend2.Visible = true;
      this.__mainmodule_ltsend2.Transparent = false;
      this.__mainmodule_ltsend2.Font = new Font(this.__mainmodule_ltsend2.Font.Name, 8f, this.__mainmodule_ltsend2.Font.Style);
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_ltsend2);
      this.htControls.Add((object) "__mainmodule_ltsend2", (object) this.__mainmodule_ltsend2);
      this.__mainmodule_cmdsend2 = new CEnhancedButton(this);
      this.__mainmodule_cmdsend2.name = "__mainmodule_cmdsend2";
      this.__mainmodule_cmdsend2.Left = 92;
      this.__mainmodule_cmdsend2.Top = 4;
      this.__mainmodule_cmdsend2.Width = 70;
      this.__mainmodule_cmdsend2.Height = 30;
      this.__mainmodule_cmdsend2.Text = "Cancelar";
      this.__mainmodule_cmdsend2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdsend2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdsend2.Enabled = true;
      this.__mainmodule_cmdsend2.Visible = true;
      this.__mainmodule_cmdsend2.Font = new Font(this.__mainmodule_cmdsend2.Font.Name, 9f, this.__mainmodule_cmdsend2.Font.Style);
      this.__mainmodule_cmdsend2.AddEvents();
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_cmdsend2);
      this.htControls.Add((object) "__mainmodule_cmdsend2", (object) this.__mainmodule_cmdsend2);
      this.__mainmodule_cmdsend1 = new CEnhancedButton(this);
      this.__mainmodule_cmdsend1.name = "__mainmodule_cmdsend1";
      this.__mainmodule_cmdsend1.Left = 9;
      this.__mainmodule_cmdsend1.Top = 4;
      this.__mainmodule_cmdsend1.Width = 70;
      this.__mainmodule_cmdsend1.Height = 30;
      this.__mainmodule_cmdsend1.Text = "Enviar";
      this.__mainmodule_cmdsend1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_cmdsend1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_cmdsend1.Enabled = true;
      this.__mainmodule_cmdsend1.Visible = true;
      this.__mainmodule_cmdsend1.Font = new Font(this.__mainmodule_cmdsend1.Font.Name, 9f, this.__mainmodule_cmdsend1.Font.Style);
      this.__mainmodule_cmdsend1.AddEvents();
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_cmdsend1);
      this.htControls.Add((object) "__mainmodule_cmdsend1", (object) this.__mainmodule_cmdsend1);
      this.__mainmodule_ltsend1 = new CEnhancedLabel(this);
      this.__mainmodule_ltsend1.name = "__mainmodule_ltsend1";
      this.__mainmodule_ltsend1.Left = 5;
      this.__mainmodule_ltsend1.Top = 97;
      this.__mainmodule_ltsend1.Width = 229;
      this.__mainmodule_ltsend1.Height = 20;
      this.__mainmodule_ltsend1.Text = "";
      this.__mainmodule_ltsend1.BackColor = Color.FromArgb(-7484934);
      this.__mainmodule_ltsend1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltsend1.MyEnabled = true;
      this.__mainmodule_ltsend1.Visible = true;
      this.__mainmodule_ltsend1.Transparent = false;
      this.__mainmodule_ltsend1.Font = new Font(this.__mainmodule_ltsend1.Font.Name, 8f, this.__mainmodule_ltsend1.Font.Style);
      this.__mainmodule_enviar.Controls.Add((Control) this.__mainmodule_ltsend1);
      this.htControls.Add((object) "__mainmodule_ltsend1", (object) this.__mainmodule_ltsend1);
      this.__mainmodule_procminve = new CEnhancedForm(this);
      this.__mainmodule_procminve.name = "__mainmodule_procminve";
      this.__mainmodule_procminve.Text = "Generar MINVE en SAE";
      this.__mainmodule_procminve.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_procminve.graphics.FillRectangle((Brush) new SolidBrush(this.__mainmodule_procminve.BackColor), 0, 0, this.__mainmodule_procminve.Width, this.__mainmodule_procminve.Height);
      this.__mainmodule_procminve.AddEvents();
      this.htControls.Add((object) "__mainmodule_procminve", (object) this.__mainmodule_procminve);
      this.__mainmodule_ltpiezas = new CEnhancedLabel(this);
      this.__mainmodule_ltpiezas.name = "__mainmodule_ltpiezas";
      this.__mainmodule_ltpiezas.Left = 165;
      this.__mainmodule_ltpiezas.Top = 121;
      this.__mainmodule_ltpiezas.Width = 70;
      this.__mainmodule_ltpiezas.Height = 18;
      this.__mainmodule_ltpiezas.Text = "";
      this.__mainmodule_ltpiezas.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltpiezas.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltpiezas.MyEnabled = true;
      this.__mainmodule_ltpiezas.Visible = true;
      this.__mainmodule_ltpiezas.Transparent = false;
      this.__mainmodule_ltpiezas.Font = new Font(this.__mainmodule_ltpiezas.Font.Name, 9f, this.__mainmodule_ltpiezas.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltpiezas);
      this.htControls.Add((object) "__mainmodule_ltpiezas", (object) this.__mainmodule_ltpiezas);
      this.__mainmodule_label41 = new CEnhancedLabel(this);
      this.__mainmodule_label41.name = "__mainmodule_label41";
      this.__mainmodule_label41.Left = 130;
      this.__mainmodule_label41.Top = 123;
      this.__mainmodule_label41.Width = 40;
      this.__mainmodule_label41.Height = 20;
      this.__mainmodule_label41.Text = "Pzas.";
      this.__mainmodule_label41.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label41.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label41.MyEnabled = true;
      this.__mainmodule_label41.Visible = true;
      this.__mainmodule_label41.Transparent = false;
      this.__mainmodule_label41.Font = new Font(this.__mainmodule_label41.Font.Name, 9f, this.__mainmodule_label41.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label41);
      this.htControls.Add((object) "__mainmodule_label41", (object) this.__mainmodule_label41);
      this.__mainmodule_ltserver = new CEnhancedLabel(this);
      this.__mainmodule_ltserver.name = "__mainmodule_ltserver";
      this.__mainmodule_ltserver.Left = 3;
      this.__mainmodule_ltserver.Top = 224;
      this.__mainmodule_ltserver.Width = 231;
      this.__mainmodule_ltserver.Height = 41;
      this.__mainmodule_ltserver.Text = "";
      this.__mainmodule_ltserver.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltserver.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltserver.MyEnabled = true;
      this.__mainmodule_ltserver.Visible = true;
      this.__mainmodule_ltserver.Transparent = false;
      this.__mainmodule_ltserver.Font = new Font(this.__mainmodule_ltserver.Font.Name, 9f, this.__mainmodule_ltserver.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltserver);
      this.htControls.Add((object) "__mainmodule_ltserver", (object) this.__mainmodule_ltserver);
      this.__mainmodule_ltmreg = new CEnhancedLabel(this);
      this.__mainmodule_ltmreg.name = "__mainmodule_ltmreg";
      this.__mainmodule_ltmreg.Left = 60;
      this.__mainmodule_ltmreg.Top = 121;
      this.__mainmodule_ltmreg.Width = 70;
      this.__mainmodule_ltmreg.Height = 18;
      this.__mainmodule_ltmreg.Text = "";
      this.__mainmodule_ltmreg.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltmreg.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltmreg.MyEnabled = true;
      this.__mainmodule_ltmreg.Visible = true;
      this.__mainmodule_ltmreg.Transparent = false;
      this.__mainmodule_ltmreg.Font = new Font(this.__mainmodule_ltmreg.Font.Name, 9f, this.__mainmodule_ltmreg.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltmreg);
      this.htControls.Add((object) "__mainmodule_ltmreg", (object) this.__mainmodule_ltmreg);
      this.__mainmodule_ltmcant = new CEnhancedLabel(this);
      this.__mainmodule_ltmcant.name = "__mainmodule_ltmcant";
      this.__mainmodule_ltmcant.Left = 185;
      this.__mainmodule_ltmcant.Top = 102;
      this.__mainmodule_ltmcant.Width = 50;
      this.__mainmodule_ltmcant.Height = 18;
      this.__mainmodule_ltmcant.Text = "";
      this.__mainmodule_ltmcant.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltmcant.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltmcant.MyEnabled = true;
      this.__mainmodule_ltmcant.Visible = true;
      this.__mainmodule_ltmcant.Transparent = false;
      this.__mainmodule_ltmcant.Font = new Font(this.__mainmodule_ltmcant.Font.Name, 9f, this.__mainmodule_ltmcant.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltmcant);
      this.htControls.Add((object) "__mainmodule_ltmcant", (object) this.__mainmodule_ltmcant);
      this.__mainmodule_lttipo = new CEnhancedLabel(this);
      this.__mainmodule_lttipo.name = "__mainmodule_lttipo";
      this.__mainmodule_lttipo.Left = 4;
      this.__mainmodule_lttipo.Top = 54;
      this.__mainmodule_lttipo.Width = 85;
      this.__mainmodule_lttipo.Height = 15;
      this.__mainmodule_lttipo.Text = "ACUMULATIVO";
      this.__mainmodule_lttipo.BackColor = Color.FromArgb(-6762242);
      this.__mainmodule_lttipo.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lttipo.MyEnabled = true;
      this.__mainmodule_lttipo.Visible = true;
      this.__mainmodule_lttipo.Transparent = false;
      this.__mainmodule_lttipo.Font = new Font(this.__mainmodule_lttipo.Font.Name, 7f, this.__mainmodule_lttipo.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_lttipo);
      this.htControls.Add((object) "__mainmodule_lttipo", (object) this.__mainmodule_lttipo);
      this.__mainmodule_opminve3 = new CEnhancedRadioBtn(this);
      this.__mainmodule_opminve3.name = "__mainmodule_opminve3";
      this.__mainmodule_opminve3.Left = 57;
      this.__mainmodule_opminve3.Top = 142;
      this.__mainmodule_opminve3.Width = 165;
      this.__mainmodule_opminve3.Height = 20;
      this.__mainmodule_opminve3.Text = "Inventario acumulativo";
      this.__mainmodule_opminve3.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_opminve3.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_opminve3.Enabled = true;
      this.__mainmodule_opminve3.Visible = true;
      this.__mainmodule_opminve3.Checked = false;
      this.__mainmodule_opminve3.Font = new Font(this.__mainmodule_opminve3.Font.Name, 9f, this.__mainmodule_opminve3.Font.Style);
      this.__mainmodule_opminve3.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_opminve3);
      this.htControls.Add((object) "__mainmodule_opminve3", (object) this.__mainmodule_opminve3);
      this.__mainmodule_opminve2 = new CEnhancedRadioBtn(this);
      this.__mainmodule_opminve2.name = "__mainmodule_opminve2";
      this.__mainmodule_opminve2.Left = 57;
      this.__mainmodule_opminve2.Top = 182;
      this.__mainmodule_opminve2.Width = 165;
      this.__mainmodule_opminve2.Height = 20;
      this.__mainmodule_opminve2.Text = "Ajustar inventario";
      this.__mainmodule_opminve2.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_opminve2.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_opminve2.Enabled = true;
      this.__mainmodule_opminve2.Visible = true;
      this.__mainmodule_opminve2.Checked = true;
      this.__mainmodule_opminve2.Font = new Font(this.__mainmodule_opminve2.Font.Name, 9f, this.__mainmodule_opminve2.Font.Style);
      this.__mainmodule_opminve2.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_opminve2);
      this.htControls.Add((object) "__mainmodule_opminve2", (object) this.__mainmodule_opminve2);
      this.__mainmodule_opminve1 = new CEnhancedRadioBtn(this);
      this.__mainmodule_opminve1.name = "__mainmodule_opminve1";
      this.__mainmodule_opminve1.Left = 57;
      this.__mainmodule_opminve1.Top = 162;
      this.__mainmodule_opminve1.Width = 165;
      this.__mainmodule_opminve1.Height = 20;
      this.__mainmodule_opminve1.Text = "Actualizar inventario";
      this.__mainmodule_opminve1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_opminve1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_opminve1.Enabled = true;
      this.__mainmodule_opminve1.Visible = true;
      this.__mainmodule_opminve1.Checked = false;
      this.__mainmodule_opminve1.Font = new Font(this.__mainmodule_opminve1.Font.Name, 9f, this.__mainmodule_opminve1.Font.Style);
      this.__mainmodule_opminve1.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_opminve1);
      this.htControls.Add((object) "__mainmodule_opminve1", (object) this.__mainmodule_opminve1);
      this.__mainmodule_lalma = new CEnhancedLabel(this);
      this.__mainmodule_lalma.name = "__mainmodule_lalma";
      this.__mainmodule_lalma.Left = 190;
      this.__mainmodule_lalma.Top = 28;
      this.__mainmodule_lalma.Width = 45;
      this.__mainmodule_lalma.Height = 20;
      this.__mainmodule_lalma.Text = "";
      this.__mainmodule_lalma.BackColor = Color.FromArgb(-6762242);
      this.__mainmodule_lalma.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_lalma.MyEnabled = true;
      this.__mainmodule_lalma.Visible = true;
      this.__mainmodule_lalma.Transparent = false;
      this.__mainmodule_lalma.Font = new Font(this.__mainmodule_lalma.Font.Name, 10f, this.__mainmodule_lalma.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_lalma);
      this.htControls.Add((object) "__mainmodule_lalma", (object) this.__mainmodule_lalma);
      this.__mainmodule_label38 = new CEnhancedLabel(this);
      this.__mainmodule_label38.name = "__mainmodule_label38";
      this.__mainmodule_label38.Left = 164;
      this.__mainmodule_label38.Top = 28;
      this.__mainmodule_label38.Width = 35;
      this.__mainmodule_label38.Height = 20;
      this.__mainmodule_label38.Text = "Alm.";
      this.__mainmodule_label38.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label38.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label38.MyEnabled = true;
      this.__mainmodule_label38.Visible = true;
      this.__mainmodule_label38.Transparent = false;
      this.__mainmodule_label38.Font = new Font(this.__mainmodule_label38.Font.Name, 9f, this.__mainmodule_label38.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label38);
      this.htControls.Add((object) "__mainmodule_label38", (object) this.__mainmodule_label38);
      this.__mainmodule_label1 = new CEnhancedLabel(this);
      this.__mainmodule_label1.name = "__mainmodule_label1";
      this.__mainmodule_label1.Left = 155;
      this.__mainmodule_label1.Top = 52;
      this.__mainmodule_label1.Width = 45;
      this.__mainmodule_label1.Height = 20;
      this.__mainmodule_label1.Text = "C. sal.:";
      this.__mainmodule_label1.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label1.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label1.MyEnabled = true;
      this.__mainmodule_label1.Visible = true;
      this.__mainmodule_label1.Transparent = false;
      this.__mainmodule_label1.Font = new Font(this.__mainmodule_label1.Font.Name, 9f, this.__mainmodule_label1.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label1);
      this.htControls.Add((object) "__mainmodule_label1", (object) this.__mainmodule_label1);
      this.__mainmodule_tconsal = new CEnhancedTextBox(this);
      this.__mainmodule_tconsal.name = "__mainmodule_tconsal";
      this.__mainmodule_tconsal.Left = 201;
      this.__mainmodule_tconsal.Top = 51;
      this.__mainmodule_tconsal.Width = 30;
      this.__mainmodule_tconsal.Text = "55";
      this.__mainmodule_tconsal.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tconsal.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tconsal.Enabled = true;
      this.__mainmodule_tconsal.Visible = true;
      this.__mainmodule_tconsal.Height = 22;
      this.__mainmodule_tconsal.Font = new Font(this.__mainmodule_tconsal.Font.Name, 9f, this.__mainmodule_tconsal.Font.Style);
      this.__mainmodule_tconsal.multiline = false;
      this.__mainmodule_tconsal.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_tconsal);
      this.htControls.Add((object) "__mainmodule_tconsal", (object) this.__mainmodule_tconsal);
      this.__mainmodule_numano = new CEnhancedNumUpDown(this);
      this.__mainmodule_numano.name = "__mainmodule_numano";
      this.__mainmodule_numano.Left = 173;
      this.__mainmodule_numano.Top = 77;
      this.__mainmodule_numano.Width = 60;
      this.__mainmodule_numano.Maximum = 2030M;
      this.__mainmodule_numano.Value = 2015M;
      this.__mainmodule_numano.BackColor = Color.FromArgb(-1);
      this.__mainmodule_numano.Enabled = true;
      this.__mainmodule_numano.Visible = true;
      this.__mainmodule_numano.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_numano);
      this.htControls.Add((object) "__mainmodule_numano", (object) this.__mainmodule_numano);
      this.__mainmodule_nummes = new CEnhancedNumUpDown(this);
      this.__mainmodule_nummes.name = "__mainmodule_nummes";
      this.__mainmodule_nummes.Left = 124;
      this.__mainmodule_nummes.Top = 77;
      this.__mainmodule_nummes.Width = 47;
      this.__mainmodule_nummes.Maximum = 12M;
      this.__mainmodule_nummes.Value = 0M;
      this.__mainmodule_nummes.BackColor = Color.FromArgb(-1);
      this.__mainmodule_nummes.Enabled = true;
      this.__mainmodule_nummes.Visible = true;
      this.__mainmodule_nummes.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_nummes);
      this.htControls.Add((object) "__mainmodule_nummes", (object) this.__mainmodule_nummes);
      this.__mainmodule_numdia = new CEnhancedNumUpDown(this);
      this.__mainmodule_numdia.name = "__mainmodule_numdia";
      this.__mainmodule_numdia.Left = 76;
      this.__mainmodule_numdia.Top = 77;
      this.__mainmodule_numdia.Width = 47;
      this.__mainmodule_numdia.Maximum = 31M;
      this.__mainmodule_numdia.Value = 0M;
      this.__mainmodule_numdia.BackColor = Color.FromArgb(-1);
      this.__mainmodule_numdia.Enabled = true;
      this.__mainmodule_numdia.Visible = true;
      this.__mainmodule_numdia.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_numdia);
      this.htControls.Add((object) "__mainmodule_numdia", (object) this.__mainmodule_numdia);
      this.__mainmodule_label32 = new CEnhancedLabel(this);
      this.__mainmodule_label32.name = "__mainmodule_label32";
      this.__mainmodule_label32.Left = 2;
      this.__mainmodule_label32.Top = 121;
      this.__mainmodule_label32.Width = 60;
      this.__mainmodule_label32.Height = 20;
      this.__mainmodule_label32.Text = "Registros:";
      this.__mainmodule_label32.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label32.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label32.MyEnabled = true;
      this.__mainmodule_label32.Visible = true;
      this.__mainmodule_label32.Transparent = false;
      this.__mainmodule_label32.Font = new Font(this.__mainmodule_label32.Font.Name, 9f, this.__mainmodule_label32.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label32);
      this.htControls.Add((object) "__mainmodule_label32", (object) this.__mainmodule_label32);
      this.__mainmodule_label33 = new CEnhancedLabel(this);
      this.__mainmodule_label33.name = "__mainmodule_label33";
      this.__mainmodule_label33.Left = 150;
      this.__mainmodule_label33.Top = 103;
      this.__mainmodule_label33.Width = 40;
      this.__mainmodule_label33.Height = 20;
      this.__mainmodule_label33.Text = "Cant.:";
      this.__mainmodule_label33.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label33.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label33.MyEnabled = true;
      this.__mainmodule_label33.Visible = true;
      this.__mainmodule_label33.Transparent = false;
      this.__mainmodule_label33.Font = new Font(this.__mainmodule_label33.Font.Name, 9f, this.__mainmodule_label33.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label33);
      this.htControls.Add((object) "__mainmodule_label33", (object) this.__mainmodule_label33);
      this.__mainmodule_ltmart = new CEnhancedLabel(this);
      this.__mainmodule_ltmart.name = "__mainmodule_ltmart";
      this.__mainmodule_ltmart.Left = 1;
      this.__mainmodule_ltmart.Top = 102;
      this.__mainmodule_ltmart.Width = 150;
      this.__mainmodule_ltmart.Height = 18;
      this.__mainmodule_ltmart.Text = "";
      this.__mainmodule_ltmart.BackColor = Color.FromArgb((int) sbyte.MinValue);
      this.__mainmodule_ltmart.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltmart.MyEnabled = true;
      this.__mainmodule_ltmart.Visible = true;
      this.__mainmodule_ltmart.Transparent = false;
      this.__mainmodule_ltmart.Font = new Font(this.__mainmodule_ltmart.Font.Name, 9f, this.__mainmodule_ltmart.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltmart);
      this.htControls.Add((object) "__mainmodule_ltmart", (object) this.__mainmodule_ltmart);
      this.__mainmodule_trefminve = new CEnhancedTextBox(this);
      this.__mainmodule_trefminve.name = "__mainmodule_trefminve";
      this.__mainmodule_trefminve.Left = 35;
      this.__mainmodule_trefminve.Top = 28;
      this.__mainmodule_trefminve.Width = 125;
      this.__mainmodule_trefminve.Text = "";
      this.__mainmodule_trefminve.BackColor = Color.FromArgb(-1);
      this.__mainmodule_trefminve.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_trefminve.Enabled = true;
      this.__mainmodule_trefminve.Visible = true;
      this.__mainmodule_trefminve.Height = 22;
      this.__mainmodule_trefminve.Font = new Font(this.__mainmodule_trefminve.Font.Name, 9f, this.__mainmodule_trefminve.Font.Style);
      this.__mainmodule_trefminve.multiline = false;
      this.__mainmodule_trefminve.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_trefminve);
      this.htControls.Add((object) "__mainmodule_trefminve", (object) this.__mainmodule_trefminve);
      this.__mainmodule_label24 = new CEnhancedLabel(this);
      this.__mainmodule_label24.name = "__mainmodule_label24";
      this.__mainmodule_label24.Left = 1;
      this.__mainmodule_label24.Top = 77;
      this.__mainmodule_label24.Width = 85;
      this.__mainmodule_label24.Height = 20;
      this.__mainmodule_label24.Text = "fecha(d-m-a)";
      this.__mainmodule_label24.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label24.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label24.MyEnabled = true;
      this.__mainmodule_label24.Visible = true;
      this.__mainmodule_label24.Transparent = false;
      this.__mainmodule_label24.Font = new Font(this.__mainmodule_label24.Font.Name, 9f, this.__mainmodule_label24.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label24);
      this.htControls.Add((object) "__mainmodule_label24", (object) this.__mainmodule_label24);
      this.__mainmodule_tconm = new CEnhancedTextBox(this);
      this.__mainmodule_tconm.name = "__mainmodule_tconm";
      this.__mainmodule_tconm.Left = 123;
      this.__mainmodule_tconm.Top = 52;
      this.__mainmodule_tconm.Width = 30;
      this.__mainmodule_tconm.Text = "6";
      this.__mainmodule_tconm.BackColor = Color.FromArgb(-1);
      this.__mainmodule_tconm.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_tconm.Enabled = true;
      this.__mainmodule_tconm.Visible = true;
      this.__mainmodule_tconm.Height = 22;
      this.__mainmodule_tconm.Font = new Font(this.__mainmodule_tconm.Font.Name, 9f, this.__mainmodule_tconm.Font.Style);
      this.__mainmodule_tconm.multiline = false;
      this.__mainmodule_tconm.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_tconm);
      this.htControls.Add((object) "__mainmodule_tconm", (object) this.__mainmodule_tconm);
      this.__mainmodule_ltconm = new CEnhancedLabel(this);
      this.__mainmodule_ltconm.name = "__mainmodule_ltconm";
      this.__mainmodule_ltconm.Left = 76;
      this.__mainmodule_ltconm.Top = 54;
      this.__mainmodule_ltconm.Width = 45;
      this.__mainmodule_ltconm.Height = 20;
      this.__mainmodule_ltconm.Text = "C. ent.:";
      this.__mainmodule_ltconm.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_ltconm.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_ltconm.MyEnabled = true;
      this.__mainmodule_ltconm.Visible = true;
      this.__mainmodule_ltconm.Transparent = false;
      this.__mainmodule_ltconm.Font = new Font(this.__mainmodule_ltconm.Font.Name, 9f, this.__mainmodule_ltconm.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_ltconm);
      this.htControls.Add((object) "__mainmodule_ltconm", (object) this.__mainmodule_ltconm);
      this.__mainmodule_label11 = new CEnhancedLabel(this);
      this.__mainmodule_label11.name = "__mainmodule_label11";
      this.__mainmodule_label11.Left = 1;
      this.__mainmodule_label11.Top = 30;
      this.__mainmodule_label11.Width = 45;
      this.__mainmodule_label11.Height = 20;
      this.__mainmodule_label11.Text = "Refer.:";
      this.__mainmodule_label11.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_label11.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_label11.MyEnabled = true;
      this.__mainmodule_label11.Visible = true;
      this.__mainmodule_label11.Transparent = false;
      this.__mainmodule_label11.Font = new Font(this.__mainmodule_label11.Font.Name, 8f, this.__mainmodule_label11.Font.Style);
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_label11);
      this.htControls.Add((object) "__mainmodule_label11", (object) this.__mainmodule_label11);
      this.__mainmodule_btnexistminve = new CEnhancedButton(this);
      this.__mainmodule_btnexistminve.name = "__mainmodule_btnexistminve";
      this.__mainmodule_btnexistminve.Left = 190;
      this.__mainmodule_btnexistminve.Top = 2;
      this.__mainmodule_btnexistminve.Width = 50;
      this.__mainmodule_btnexistminve.Height = 25;
      this.__mainmodule_btnexistminve.Text = "Salir";
      this.__mainmodule_btnexistminve.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btnexistminve.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btnexistminve.Enabled = true;
      this.__mainmodule_btnexistminve.Visible = true;
      this.__mainmodule_btnexistminve.Font = new Font(this.__mainmodule_btnexistminve.Font.Name, 9f, this.__mainmodule_btnexistminve.Font.Style);
      this.__mainmodule_btnexistminve.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_btnexistminve);
      this.htControls.Add((object) "__mainmodule_btnexistminve", (object) this.__mainmodule_btnexistminve);
      this.__mainmodule_btngenerar = new CEnhancedButton(this);
      this.__mainmodule_btngenerar.name = "__mainmodule_btngenerar";
      this.__mainmodule_btngenerar.Left = 70;
      this.__mainmodule_btngenerar.Top = 2;
      this.__mainmodule_btngenerar.Width = 110;
      this.__mainmodule_btngenerar.Height = 25;
      this.__mainmodule_btngenerar.Text = "Generar MINVE";
      this.__mainmodule_btngenerar.BackColor = Color.FromArgb(-66313);
      this.__mainmodule_btngenerar.ForeColor = Color.FromArgb(-16777216);
      this.__mainmodule_btngenerar.Enabled = true;
      this.__mainmodule_btngenerar.Visible = true;
      this.__mainmodule_btngenerar.Font = new Font(this.__mainmodule_btngenerar.Font.Name, 9f, this.__mainmodule_btngenerar.Font.Style);
      this.__mainmodule_btngenerar.AddEvents();
      this.__mainmodule_procminve.Controls.Add((Control) this.__mainmodule_btngenerar);
      this.htControls.Add((object) "__mainmodule_btngenerar", (object) this.__mainmodule_btngenerar);
      this.__mainmodule_mnuminve = new CEnhancedMenu(this);
      this.__mainmodule_mnuminve.name = "__mainmodule_mnuminve";
      this.__mainmodule_mnuminve.Text = "Archivo";
      this.__mainmodule_mnuminve.Enabled = true;
      this.__mainmodule_mnuminve.Checked = false;
      this.__mainmodule_mnuminve.AddToObject("__mainmodule_procminve");
      this.__mainmodule_mnuminve.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuminve", (object) this.__mainmodule_mnuminve);
      this.__mainmodule_mnuminve1 = new CEnhancedMenu(this);
      this.__mainmodule_mnuminve1.name = "__mainmodule_mnuminve1";
      this.__mainmodule_mnuminve1.Text = "Remarcar para reenvio";
      this.__mainmodule_mnuminve1.Enabled = true;
      this.__mainmodule_mnuminve1.Checked = false;
      this.__mainmodule_mnuminve1.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuminve1.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuminve1", (object) this.__mainmodule_mnuminve1);
      this.__mainmodule_mnuacumulativo = new CEnhancedMenu(this);
      this.__mainmodule_mnuacumulativo.name = "__mainmodule_mnuacumulativo";
      this.__mainmodule_mnuacumulativo.Text = "Inventario acumulativo";
      this.__mainmodule_mnuacumulativo.Enabled = true;
      this.__mainmodule_mnuacumulativo.Checked = false;
      this.__mainmodule_mnuacumulativo.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuacumulativo.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuacumulativo", (object) this.__mainmodule_mnuacumulativo);
      this.__mainmodule_mnuactualizar = new CEnhancedMenu(this);
      this.__mainmodule_mnuactualizar.name = "__mainmodule_mnuactualizar";
      this.__mainmodule_mnuactualizar.Text = "Actualizar inventario";
      this.__mainmodule_mnuactualizar.Enabled = true;
      this.__mainmodule_mnuactualizar.Checked = false;
      this.__mainmodule_mnuactualizar.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuactualizar.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuactualizar", (object) this.__mainmodule_mnuactualizar);
      this.__mainmodule_mnuajustar = new CEnhancedMenu(this);
      this.__mainmodule_mnuajustar.name = "__mainmodule_mnuajustar";
      this.__mainmodule_mnuajustar.Text = "Ajustar inventario";
      this.__mainmodule_mnuajustar.Enabled = true;
      this.__mainmodule_mnuajustar.Checked = false;
      this.__mainmodule_mnuajustar.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuajustar.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuajustar", (object) this.__mainmodule_mnuajustar);
      this.__mainmodule_mnuenviarsql = new CEnhancedMenu(this);
      this.__mainmodule_mnuenviarsql.name = "__mainmodule_mnuenviarsql";
      this.__mainmodule_mnuenviarsql.Text = "Enviar inventario al Servidor";
      this.__mainmodule_mnuenviarsql.Enabled = true;
      this.__mainmodule_mnuenviarsql.Checked = false;
      this.__mainmodule_mnuenviarsql.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuenviarsql.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuenviarsql", (object) this.__mainmodule_mnuenviarsql);
      this.__mainmodule_mnutotalminve = new CEnhancedMenu(this);
      this.__mainmodule_mnutotalminve.name = "__mainmodule_mnutotalminve";
      this.__mainmodule_mnutotalminve.Text = "Total partidas";
      this.__mainmodule_mnutotalminve.Enabled = true;
      this.__mainmodule_mnutotalminve.Checked = false;
      this.__mainmodule_mnutotalminve.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnutotalminve.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnutotalminve", (object) this.__mainmodule_mnutotalminve);
      this.__mainmodule_mnuexxlinea = new CEnhancedMenu(this);
      this.__mainmodule_mnuexxlinea.name = "__mainmodule_mnuexxlinea";
      this.__mainmodule_mnuexxlinea.Text = "Exist X Linea";
      this.__mainmodule_mnuexxlinea.Enabled = true;
      this.__mainmodule_mnuexxlinea.Checked = false;
      this.__mainmodule_mnuexxlinea.AddToObject("__mainmodule_mnuminve");
      this.__mainmodule_mnuexxlinea.AddEvents();
      this.htControls.Add((object) "__mainmodule_mnuexxlinea", (object) this.__mainmodule_mnuexxlinea);
    }

    public delegate string del0();

    public delegate string del1(string a);

    public delegate string del2(string a, string b);

    public delegate string del3(string a, string b, string c);
  }
}
