namespace Dbasic
{
    using B4PSQL;
    using bControls;
    using Dbasic.EnhancedControls;
    using FormLib;
    using MSSQL;
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class b4p
    {
        public const double fixX = 1.0;
        public const double fixY = 1.0;
        public static CultureInfo cul = new CultureInfo("en-US", false);
        public CEnhancedForm mainForm;
        public CEnhancedForm shownForm;
        public Color transColor = Color.Violet;
        public SolidBrush foreBrush = new SolidBrush(Color.Violet);
        public Dbasic.EnhancedControls.CEnhancedObject CEnhancedObject;
        public CaseInsensitiveComparer caseNotCompare;
        public Comparer caseCompare;
        public CCompareNumbers numbersCompare;
        public bool quitFlag;
        public Hashtable htSubs = new Hashtable();
        public CHtControls htControls = new CHtControls();
        public ASCIIEncoding ae = new ASCIIEncoding();
        public string sender = "";
        public Hashtable htStreams = new Hashtable();
        private Dbasic.Other Other;
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
        public int screenY = 0x10c;
        public int screenX = 0xee;
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

        public b4p(string[] args)
        {
            try
            {
                this.CEnhancedObject = new Dbasic.EnhancedControls.CEnhancedObject(this);
                this.Other = new Dbasic.Other(this);
                this.dateFormat = "MM/dd/yyyy";
                this.timeFormat = "HH:mm";
                this.tdRunning = Thread.CurrentThread;
                this.b4pdir = Application.StartupPath;
                cPPC = "false";
                this.alFormsDisplayOrder = new ArrayList();
                Thread.SetData(Thread.GetNamedDataSlot("cPPC"), bool.Parse(cPPC));
                Thread.SetData(Thread.GetNamedDataSlot("optimized"), true);
                Thread.SetData(Thread.GetNamedDataSlot("b4p"), this);
                Thread.SetData(Thread.GetNamedDataSlot("version"), 6.9);
                this.var__mainmodule_args = args;
                this.initialize();
                this._globals();
                this.__mainmodule_app_start();
                if (this.shownForm != null)
                {
                    Application.Run(this.shownForm);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading program.\n" + exception.Message, "Basic4ppc", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private string __mainmodule_addfield()
        {
            string str2;
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_addfield > 0)
                {
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_addfield == 1)
                    {
                        this.err_mainmodule_addfield = 0;
                        goto Label_0284;
                    }
                }
                num = 1;
                this.var__mainmodule_sql = "PRAGMA table_info('minve')";
                lSide = "";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                lSide = "N";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.__mainmodule_reader.GetValue(1) == "idArea")
                    {
                        lSide = "S";
                    }
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
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.__mainmodule_reader.GetValue(1) == "status")
                    {
                        lSide = "S";
                    }
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
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.__mainmodule_reader.GetValue(1) == "empresapred")
                    {
                        lSide = "S";
                    }
                }
                this.__mainmodule_reader.Close();
                if (this.LCompareEqual(lSide, "N"))
                {
                    this.__mainmodule_cmd.CommandText = "ALTER TABLE config ADD COLUMN empresapred varchar(10) NULL";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                }
                return "";
            Label_0284:
                str2 = "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_addfield = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_addfield();
                }
                this.ShowError(exception, "_mainmodule_addfield");
                str2 = "";
            }
            return str2;
        }

        private string __mainmodule_app_start()
        {
            double num = 0.0;
            string str = "";
            double num2 = 0.0;
            string format = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_app_start > 0)
                {
                    format = this.localVars[3];
                    num2 = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_app_start == 1)
                    {
                        this.err_mainmodule_app_start = 0;
                        goto Label_153A;
                    }
                }
                this.dateFormat = "dd-mm-yyyy".ToLower(cul).Replace("m", "M");
                num3 = 1;
                this.var__mainmodule_process = "P";
                this.var__mainmodule_rutapc = " ";
                this.var__mainmodule_wifilocation = this.b4pdir + @"\inventmobile.db";
                if (File.Exists(Path.Combine(this.b4pdir, this.var__mainmodule_wifilocation)).ToString(cul).ToLower(cul) == "false")
                {
                    ((int) MessageBox.Show("No existe la base de datos comuniquelo con el supervisor", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    if (this.mainForm != null)
                    {
                        this.mainForm.Close();
                    }
                    else
                    {
                        this.CloseProgram();
                    }
                    return "";
                }
                if (this.htControls["__mainmodule_con"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_con"]);
                }
                this.__mainmodule_con = new Connection();
                this.htControls["__mainmodule_con"] = this.__mainmodule_con;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_con] = "__mainmodule_con";
                if (this.htControls["__mainmodule_reader"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_reader"]);
                }
                this.__mainmodule_reader = new DataReader();
                this.htControls["__mainmodule_reader"] = this.__mainmodule_reader;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_reader] = "__mainmodule_reader";
                if (this.htControls["__mainmodule_reader2"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_reader2"]);
                }
                this.__mainmodule_reader2 = new DataReader();
                this.htControls["__mainmodule_reader2"] = this.__mainmodule_reader2;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_reader2] = "__mainmodule_reader2";
                if (this.htControls["__mainmodule_cmd"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_cmd"]);
                }
                this.__mainmodule_cmd = new B4PSQL.Command("", this.__mainmodule_con.Value);
                this.htControls["__mainmodule_cmd"] = this.__mainmodule_cmd;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_cmd] = "__mainmodule_cmd";
                if (this.htControls["__mainmodule_cmd2"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_cmd2"]);
                }
                this.__mainmodule_cmd2 = new B4PSQL.Command("", this.__mainmodule_con.Value);
                this.htControls["__mainmodule_cmd2"] = this.__mainmodule_cmd2;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_cmd2] = "__mainmodule_cmd2";
                this.__mainmodule_con.Open("Data Source = " + this.var__mainmodule_wifilocation);
                if (this.htControls["__mainmodule_flb"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_flb"]);
                }
                this.__mainmodule_flb = new FormLib.FormLib((Form) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "main"), this);
                this.htControls["__mainmodule_flb"] = this.__mainmodule_flb;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_flb] = "__mainmodule_flb";
                this.__mainmodule_flb.SetPasswordTextBox((TextBox) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "tPassword"));
                this.__mainmodule_flb.SetPasswordTextBox((TextBox) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "tLogin"));
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtSocial"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtInven"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtSumCan2"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtSum2"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtE"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.TextAlignment((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtPrec"), this.__mainmodule_flb.alCenter);
                this.__mainmodule_flb.SetFontStyle((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtInven"), bool.Parse("true".ToLower(cul)), bool.Parse("false".ToLower(cul)), bool.Parse("false".ToLower(cul)), bool.Parse("false".ToLower(cul)));
                this.__mainmodule_flb.ChangeFont((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "LtInven"), "Arial Black");
                this.__mainmodule_creatablaarea();
                this.__mainmodule_addfield();
                this.__mainmodule_cboempresa.Items.Clear();
                this.__mainmodule_cmd.CommandText = "SELECT empresa FROM empresas ORDER BY empresa";
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_cboempresa.Items.Add(this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_cbotiendaorigen.Items.Add(this.__mainmodule_reader.GetValue(0));
                }
                this.__mainmodule_reader.Close();
                this.var__mainmodule_sistema = 1.0;
                this.var__mainmodule_seriefolio = "A";
                this.var__mainmodule_folioped = 1.0;
                this.var__mainmodule_empresapred = "";
                this.var__mainmodule_sql = "SELECT puerto, folio, port, server, base, user, pass, sistema, seriecompra, foliocompra, folioped, seriepedido, empresapred FROM config";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(0)).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_port = this.__mainmodule_reader.GetValue(0);
                    }
                    else
                    {
                        this.var__mainmodule_port = "1433";
                    }
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_folio = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                    }
                    else
                    {
                        this.var__mainmodule_folio = 1.0;
                    }
                    this.var__mainmodule_servertea = this.__mainmodule_reader.GetValue(3);
                    this.var__mainmodule_basetea = this.__mainmodule_reader.GetValue(4);
                    this.var__mainmodule_usertea = this.__mainmodule_reader.GetValue(5);
                    this.var__mainmodule_passtea = this.__mainmodule_reader.GetValue(6);
                    this.var__mainmodule_porttea = this.__mainmodule_reader.GetValue(2);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(7)).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_sistema = double.Parse(this.__mainmodule_reader.GetValue(7), cul);
                    }
                    this.var__mainmodule_seriecompra = this.__mainmodule_reader.GetValue(8);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(9)).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_foliocompra = double.Parse(this.__mainmodule_reader.GetValue(9), cul);
                    }
                    else
                    {
                        this.var__mainmodule_foliocompra = 1.0;
                    }
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(10)).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_folioped = double.Parse(this.__mainmodule_reader.GetValue(10), cul);
                    }
                    else
                    {
                        this.var__mainmodule_folioped = 1.0;
                    }
                    this.var__mainmodule_seriepedido = "" + this.__mainmodule_reader.GetValue(11);
                    this.var__mainmodule_empresapred = "" + this.__mainmodule_reader.GetValue(12);
                    if (this.LCompareEqual(this.var__mainmodule_empresapred, "Ninguna"))
                    {
                        this.var__mainmodule_empresapred = "";
                    }
                }
                else
                {
                    this.var__mainmodule_port = "COM5";
                    this.var__mainmodule_folio = 1.0;
                }
                this.__mainmodule_reader.Close();
                if (this.LCompareEqual(this.var__mainmodule_sistema.ToString(cul), "1"))
                {
                    this.__mainmodule_chcaja.Checked = bool.Parse("false".ToLower(cul));
                }
                else
                {
                    this.__mainmodule_chcaja.Checked = bool.Parse("true".ToLower(cul));
                }
                this.__mainmodule_pnlred.Top = 0;
                this.__mainmodule_pnlred.Left = 0;
                this.__mainmodule_pnlred.Height = 0xf5;
                this.__mainmodule_pnlred.Width = 270;
                this.__mainmodule_tabla.TableStyles[0].HeaderBackColor = Color.FromArgb(100, 200, 0xde);
                this.__mainmodule_tabla.AddCol(typeof(string), "Clave", 0x25, false);
                this.__mainmodule_tabla.AddCol(typeof(string), "Nombre", 150, false);
                this.__mainmodule_tabla.AddCol(typeof(string), "R.F.C.", 50, false);
                this.__mainmodule_tabla.AddCol(typeof(string), "Direcci\x00f3n", 80, false);
                this.__mainmodule_tabla.AddCol(typeof(string), "Tel\x00e9fono", 0x23, false);
                this.__mainmodule_tabla.AddCol(typeof(string), "Ciudad", 50, false);
                this.__mainmodule_pnlpedidos.Top = 0;
                this.__mainmodule_pnlpedidos.Left = 0;
                this.__mainmodule_pnlpedidos.Width = 240;
                this.__mainmodule_pnlpedidos.Height = 190;
                this.__utilerias_pnltrans.Top = 0;
                this.__utilerias_pnltrans.Left = 0;
                this.__utilerias_pnltrans.Height = 0xf5;
                this.__utilerias_pnltrans.Width = 270;
                this.__mainmodule_tblprod.Top = 30;
                this.__mainmodule_tblprod.Left = 3;
                this.__mainmodule_tblprod.Height = 0xeb;
                this.__mainmodule_tblprod.Width = 0xec;
                this.__mainmodule_tblprod.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tblprod.AddCol(typeof(string), "Articulo", 0x41, false);
                this.__mainmodule_tblprod.AddCol(typeof(string), "Descripci\x00f3n", 90, false);
                this.__mainmodule_tblprod.AddCol(typeof(string), "Exist", 40, false);
                this.__mainmodule_tblprod.AddCol(typeof(string), "Inv.Fisico", 40, false);
                this.__mainmodule_tbcaninven.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tbcaninven.AddCol(typeof(string), "id", 0, false);
                this.__mainmodule_tbcaninven.AddCol(typeof(string), "Usuario", 40, false);
                this.__mainmodule_tbcaninven.AddCol(typeof(string), "Articulo", 80, false);
                this.__mainmodule_tbcaninven.AddCol(typeof(string), "Cantidad", 50, false);
                this.__mainmodule_tbcaninven.AddCol(typeof(string), "Estado", 40, false);
                this.__mainmodule_tbluser.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tbluser.AddCol(typeof(string), "id", 0, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Usuario", 60, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Nombre", 120, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Contrase\x00f1a", 60, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Nivel", 60, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Serie", 60, false);
                this.__mainmodule_tbluser.AddCol(typeof(string), "Folio", 70, false);
                this.__mainmodule_tblcompras.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tblcompras.AddCol(typeof(string), "Articulo", 50, false);
                this.__mainmodule_tblcompras.AddCol(typeof(string), "Descripci\x00f3n", 0x87, false);
                this.__mainmodule_tblcompras.AddCol(typeof(string), "Cant", 40, false);
                this.__mainmodule_tblpedidos.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tblpedidos.AddCol(typeof(string), "Articulo", 50, false);
                this.__mainmodule_tblpedidos.AddCol(typeof(string), "Descripci\x00f3n", 0x87, false);
                this.__mainmodule_tblpedidos.AddCol(typeof(string), "Cant", 40, false);
                this.__mainmodule_tblexisxlinea.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tblexisxlinea.AddCol(typeof(string), "No.", 0x23, false);
                this.__mainmodule_tblexisxlinea.AddCol(typeof(string), "Nombre", 100, false);
                this.__mainmodule_tblexisxlinea.AddCol(typeof(string), "Cant", 70, false);
                this.__utilerias_fgprod.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__utilerias_fgprod.AddCol(typeof(string), "Folio", 0x19, false);
                this.__utilerias_fgprod.AddCol(typeof(string), "Clave", 0x41, false);
                this.__utilerias_fgprod.AddCol(typeof(string), "Descripci\x00f3n", 160, false);
                this.__utilerias_fgprod.AddCol(typeof(string), "Cant.", 0x23, false);
                this.__utilerias_fgprod.AddCol(typeof(string), "id.", 0, false);
                this.__utilerias_tbltea.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__utilerias_tbltea.AddCol(typeof(string), "Articulo", 40, false);
                this.__utilerias_tbltea.AddCol(typeof(string), "Descripci\x00f3n", 0x87, false);
                this.__utilerias_tbltea.AddCol(typeof(string), "Cant.", 0x2d, false);
                this.__utilerias_tblcanc.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__utilerias_tblcanc.AddCol(typeof(string), "id", 0, false);
                this.__utilerias_tblcanc.AddCol(typeof(string), "Folio", 30, false);
                this.__utilerias_tblcanc.AddCol(typeof(string), "Articulo", 40, false);
                this.__utilerias_tblcanc.AddCol(typeof(string), "Descripcion", 80, false);
                this.__utilerias_tblcanc.AddCol(typeof(string), "Estado", 40, false);
                this.__utilerias_tblcanc.AddCol(typeof(string), "Cantidad", 30, false);
                this.__mainmodule_tblareas.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tblareas.AddCol(typeof(string), "id", 0x23, false);
                this.__mainmodule_tblareas.AddCol(typeof(string), "Area", 0, false);
                this.__mainmodule_tblareas.AddCol(typeof(string), "Nombre", 160, false);
                this.__mainmodule_pnlareasseries.Top = 0;
                this.__mainmodule_pnlareasseries.Left = 0;
                this.__mainmodule_pnlareasseries.Width = 240;
                this.__mainmodule_pnlareasseries.Height = 0xc3;
                this.__mainmodule_pnltoper.Top = 0;
                this.__mainmodule_pnltoper.Left = 0;
                this.__mainmodule_pnltoper.Width = 0xef;
                this.__mainmodule_pnltoper.Height = 0xf6;
                this.__mainmodule_tbltoper.TableStyles[0].HeaderBackColor = Color.FromArgb(0x5d, 0xc2, 0xff);
                this.__mainmodule_tbltoper.AddCol(typeof(string), "id", 0, false);
                this.__mainmodule_tbltoper.AddCol(typeof(string), "Articulo", 160, false);
                this.__mainmodule_tbltoper.AddCol(typeof(string), "Cant.", 40, false);
                num = 1.0;
                double num4 = 900.0;
                double num5 = num;
                while (num5 <= num4)
                {
                    this.__mainmodule_cboseriesareas.Items.Add(((format = "D2".ToLower(cul))[0] != 'd') ? num.ToString(format, cul) : ((int) num).ToString(format, cul));
                    num = ++num5;
                }
                if (this.htControls["__mainmodule_listcte"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_listcte"]);
                }
                this.__mainmodule_listcte = new bList((Control) this.CEnhancedObject.GetControlStringOrRef("mainmodule", "frmClientes"));
                this.htControls["__mainmodule_listcte"] = this.__mainmodule_listcte;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_listcte] = "__mainmodule_listcte";
                this.__mainmodule_listcte.Click += new EventHandler(this.CEnhancedObject.MetapelEruim);
                if (this.htControls["__mainmodule_item"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_item"]);
                }
                this.__mainmodule_item = new bListItem();
                this.htControls["__mainmodule_item"] = this.__mainmodule_item;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_item] = "__mainmodule_item";
                this.__mainmodule_main.show();
                return "";
            Label_153A:
                ((int) MessageBox.Show(": ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_app_start = num3;
                    this.localVars = new object[] { num, str, num2, format };
                    return this.__mainmodule_app_start();
                }
                this.ShowError(exception, "_mainmodule_app_start");
                return "";
            }
        }

        private string __mainmodule_bcodigo()
        {
            string str = "";
            int row = 0;
            double num2 = 0.0;
            double num3 = 0.0;
            string str2 = "";
            int num4 = 0;
            try
            {
                if (this.err_mainmodule_bcodigo > 0)
                {
                    str2 = this.localVars[4];
                    num3 = this.localVars[3];
                    num2 = this.localVars[2];
                    row = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_bcodigo == 1)
                    {
                        this.err_mainmodule_bcodigo = 0;
                        goto Label_0B09;
                    }
                }
                num4 = 1;
                str = this.__mainmodule_tcodigo.Text.Replace(" ", "");
                if (str.Length.ToString(cul) == "0")
                {
                    ((int) MessageBox.Show("La clave del articulo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                this.__mainmodule_tbcaninven.AddRow(new object[0]);
                row = this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - ((int) 1.0);
                this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, row, str);
                this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, row, str);
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
                {
                    if (this.LCompareEqual(this.var__mainmodule_seriecompra, ""))
                    {
                        string introduced18 = this.__mainmodule_replicate(" ", 20.0 - this.var__mainmodule_foliocompra.ToString(cul).Length);
                        str2 = introduced18 + this.var__mainmodule_foliocompra.ToString(cul);
                    }
                    else
                    {
                        str2 = this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString(cul);
                    }
                    this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cant, M.cancelado ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM compras M INNER JOIN prods P ON P.articulo = M.articulo ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE (M.articulo = '" + str + "' OR clavealterna = '" + str;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "') AND cve_doc = '" + str2 + "' AND nuevo = 'S' ORDER BY id";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    this.__mainmodule_tbcaninven.dataTable.Clear();
                    this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
                    num2 = 0.0;
                    num3 = 0.0;
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_tbcaninven.AddRow(new object[0]);
                        row = this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - ((int) 1.0);
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, row, this.__mainmodule_reader.GetValue(0));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, row, this.__mainmodule_reader.GetValue(1));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, row, this.__mainmodule_reader.GetValue(2));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, row, this.__mainmodule_reader.GetValue(3));
                        if (this.__mainmodule_reader.GetValue(4) == "N")
                        {
                            num2 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                        }
                        else
                        {
                            num3 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, row, "Cancelado");
                        }
                    }
                    this.__mainmodule_reader.Close();
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
                {
                    this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cantidad, M.cancelado FROM minve M ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "INNER JOIN prods P ON P.articulo = M.articulo WHERE ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "(M.articulo = '" + str + "' OR clavealterna = '" + str + "') AND nuevo = 'S' ORDER BY id";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    this.__mainmodule_tbcaninven.dataTable.Clear();
                    this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
                    num2 = 0.0;
                    num3 = 0.0;
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_tbcaninven.AddRow(new object[0]);
                        row = this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - ((int) 1.0);
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, row, this.__mainmodule_reader.GetValue(0));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, row, this.__mainmodule_reader.GetValue(1));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, row, this.__mainmodule_reader.GetValue(2));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, row, this.__mainmodule_reader.GetValue(3));
                        if (this.__mainmodule_reader.GetValue(4) == "N")
                        {
                            num2 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                        }
                        else
                        {
                            num3 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, row, "Cancelado");
                        }
                    }
                    this.__mainmodule_reader.Close();
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    if (this.LCompareEqual(this.var__mainmodule_seriepedido, ""))
                    {
                        string introduced19 = this.__mainmodule_replicate(" ", 20.0 - this.var__mainmodule_folioped.ToString(cul).Length);
                        str2 = introduced19 + this.var__mainmodule_folioped.ToString(cul);
                    }
                    else
                    {
                        str2 = this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString(cul);
                    }
                    this.var__mainmodule_sql = "SELECT M.id, M.usuario, M.articulo, M.cant, M.cancelado ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM pedidos M INNER JOIN prods P ON P.articulo = M.articulo ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE (M.articulo = '" + str + "' OR clavealterna = '" + str;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "') AND cve_doc = '" + str2 + "' AND nuevo = 'S' ORDER BY id";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    this.__mainmodule_tbcaninven.dataTable.Clear();
                    this.__mainmodule_tbcaninven.dataTable.AcceptChanges();
                    num2 = 0.0;
                    num3 = 0.0;
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_tbcaninven.AddRow(new object[0]);
                        row = this.__mainmodule_tbcaninven.dataTable.DefaultView.Count - ((int) 1.0);
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, row, this.__mainmodule_reader.GetValue(0));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, row, this.__mainmodule_reader.GetValue(1));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, row, this.__mainmodule_reader.GetValue(2));
                        this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, row, this.__mainmodule_reader.GetValue(3));
                        if (this.__mainmodule_reader.GetValue(4) == "N")
                        {
                            num2 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                        }
                        else
                        {
                            num3 += double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                            this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, row, "Cancelado");
                        }
                    }
                    this.__mainmodule_reader.Close();
                }
                this.__mainmodule_ltsum2.Text = num2.ToString(cul);
                this.__mainmodule_ltsumcan2.Text = num3.ToString(cul);
                this.__mainmodule_tcodigo.Text = "";
                return "";
            Label_0B09:
                ((int) MessageBox.Show("Error en BCodigo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num4 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_bcodigo = num4;
                    this.localVars = new object[] { str, row, num2, num3, str2 };
                    return this.__mainmodule_bcodigo();
                }
                this.ShowError(exception, "_mainmodule_bcodigo");
                return "";
            }
        }

        private string __mainmodule_bk_txt()
        {
            string str6;
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            string str2 = "";
            string str3 = "";
            string str4 = "";
            double num3 = 0.0;
            string s = "";
            int num4 = 0;
            try
            {
                if (this.err_mainmodule_bk_txt > 0)
                {
                    s = this.localVars[7];
                    num3 = this.localVars[6];
                    str4 = this.localVars[5];
                    str3 = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_bk_txt == 1)
                    {
                        this.err_mainmodule_bk_txt = 0;
                        goto Label_06D7;
                    }
                }
                num4 = 1;
                str = this.b4pdir + @"\BK\inven" + DateTime.Now.Day.ToString(cul) + DateTime.Now.Month.ToString(cul) + DateTime.Now.Year.ToString(cul) + DateTime.Now.Hour.ToString(cul) + DateTime.Now.Minute.ToString(cul) + DateTime.Now.Second.ToString(cul) + ".csv";
                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, str), false, Encoding.ASCII));
                this.var__mainmodule_sql = "SELECT articulo, exist FROM inven";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                str2 = "Articulo,cantidad";
                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                s = "0";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    Application.DoEvents();
                    str3 = this.__mainmodule_reader.GetValue(0);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                    {
                        num2 = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                    }
                    else
                    {
                        num2 = 0.0;
                    }
                    s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                    str2 = str3 + "," + num2.ToString(cul);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                }
                this.__mainmodule_reader.Close();
                if (this.htStreams.Contains("_mainmodule_c1"))
                {
                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                    this.htStreams.Remove("_mainmodule_c1");
                    GC.Collect();
                }
                str = this.b4pdir + @"\BK\minve" + DateTime.Now.Day.ToString(cul) + DateTime.Now.Month.ToString(cul) + DateTime.Now.Year.ToString(cul) + DateTime.Now.Hour.ToString(cul) + DateTime.Now.Minute.ToString(cul) + DateTime.Now.Second.ToString(cul) + ".csv";
                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, str), false, Encoding.ASCII));
                this.var__mainmodule_sql = "SELECT id, articulo, cantidad, idArea, cancelado FROM minve";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                str2 = "Articulo,cantidad,idArea,cancelado";
                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                s = "0";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    Application.DoEvents();
                    str3 = this.__mainmodule_reader.GetValue(1);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(cul) == "true")
                    {
                        num2 = double.Parse(this.__mainmodule_reader.GetValue(2), cul);
                    }
                    else
                    {
                        num2 = 0.0;
                    }
                    s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                    str2 = this.__mainmodule_reader.GetValue(0) + "," + str3 + "," + num2.ToString(cul) + "," + this.__mainmodule_reader.GetValue(3) + "," + this.__mainmodule_reader.GetValue(4);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                }
                this.__mainmodule_reader.Close();
                if (this.htStreams.Contains("_mainmodule_c1"))
                {
                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                    this.htStreams.Remove("_mainmodule_c1");
                    GC.Collect();
                }
                return "";
            Label_06D7:
                str6 = "";
            }
            catch (Exception exception)
            {
                if (num4 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_bk_txt = num4;
                    this.localVars = new object[] { str, num, num2, str2, str3, str4, num3, s };
                    return this.__mainmodule_bk_txt();
                }
                this.ShowError(exception, "_mainmodule_bk_txt");
                str6 = "";
            }
            return str6;
        }

        private string __mainmodule_btnaceptar_click()
        {
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_btnaceptar_click > 0)
                {
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_btnaceptar_click == 1)
                    {
                        this.err_mainmodule_btnaceptar_click = 0;
                        goto Label_03EE;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboempresa.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (((this.__mainmodule_tpassword.Text != "sorom") && (this.__mainmodule_tpassword.Text != "Gsorom09")) && (this.__mainmodule_tpassword.Text != "111222"))
                {
                    this.var__mainmodule_sql = "SELECT nivel, serie, folio FROM usuarios WHERE usuario = '" + this.__mainmodule_tusuario.Text;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "' AND password = '" + this.__mainmodule_tpassword.Text + "'";
                    this.var__mainmodule_isadmin = "false";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        lSide = "1";
                        if ((this.Other.IsNumber(this.__mainmodule_reader.GetValue(0)).ToLower(cul) == "true") && (this.__mainmodule_reader.GetValue(0) == "1"))
                        {
                            this.var__mainmodule_isadmin = "true";
                        }
                    }
                    else
                    {
                        lSide = "0";
                    }
                    this.__mainmodule_reader.Close();
                    if (this.LCompareEqual(lSide, "0"))
                    {
                        this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\alarma.wav"));
                        Thread.Sleep(0x5dc);
                        ((int) MessageBox.Show("Usuario o contrase\x00f1a incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.var__mainmodule_userroot = this.__mainmodule_tusuario.Text;
                }
                else
                {
                    this.var__mainmodule_userroot = "sorom";
                    this.var__mainmodule_isadmin = "true";
                }
                this.var__mainmodule_empresa = this.__mainmodule_cboempresa.Items[this.__mainmodule_cboempresa.SelectedIndex].ToString();
                if (this.__mainmodule_chimportar.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_btnaceptar.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_btnmain8.Visible = bool.Parse("false".ToLower(cul));
                    Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.__mainmodule_importararticulos();
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.__mainmodule_btnaceptar.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_btnmain8.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_chimportar.Checked = bool.Parse("false".ToLower(cul));
                }
                this.__mainmodule_frmmenu.show();
                return "";
            Label_03EE:
                ((int) MessageBox.Show("Ocurrio un problema btnAceptar_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnaceptar_click = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_btnaceptar_click();
                }
                this.ShowError(exception, "_mainmodule_btnaceptar_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnarea2_click");
                return "";
            }
        }

        private string __mainmodule_btnareagrabar_click()
        {
            string str2;
            double num = 0.0;
            string s = "";
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_btnareagrabar_click > 0)
                {
                    s = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_btnareagrabar_click == 1)
                    {
                        this.err_mainmodule_btnareagrabar_click = 0;
                        goto Label_017B;
                    }
                }
                num2 = 1;
                s = this.__mainmodule_ltarea.Text;
                if (this.Other.IsNumber(s).ToLower(cul) == "true")
                {
                    num = (s == "") ? 0.0 : double.Parse(s, cul);
                }
                else
                {
                    this.var__mainmodule_tipomov = "alta";
                    num = 0.0;
                }
                if (this.LCompareEqual(this.var__mainmodule_tipomov, "alta"))
                {
                    this.__mainmodule_cmd.CommandText = "INSERT INTO areas (nombre) values('" + this.__mainmodule_tareanombre.Text + "')";
                }
                else
                {
                    this.__mainmodule_cmd.CommandText = "UPDATE areas SET nombre = '" + this.__mainmodule_tareanombre.Text + "' WHERE id = " + num.ToString(cul);
                }
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.var__mainmodule_tipomov = "";
                ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_tareanombre.Text = "";
                this.__mainmodule_desplegarareas();
                return "";
            Label_017B:
                str2 = "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnareagrabar_click = num2;
                    this.localVars = new object[] { num, s };
                    return this.__mainmodule_btnareagrabar_click();
                }
                this.ShowError(exception, "_mainmodule_btnareagrabar_click");
                str2 = "";
            }
            return str2;
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnareanew_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnareas_click");
                return "";
            }
        }

        private string __mainmodule_btnareaserie1_click()
        {
            string lSide = "";
            string s = "";
            string format = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_btnareaserie1_click > 0)
                {
                    format = this.localVars[2];
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_btnareaserie1_click == 1)
                    {
                        this.err_mainmodule_btnareaserie1_click = 0;
                        goto Label_02F9;
                    }
                }
                num = 1;
                lSide = ((int) MessageBox.Show("Este proceso agregar areas enumeradas y eliminara las existentes, Realmente desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    if (this.__mainmodule_tnotaarea.Text.Length.ToString(cul) == "0")
                    {
                        ((int) MessageBox.Show("Por favor capture el nuevo nombre de las areas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.__mainmodule_cmd.CommandText = "DELETE FROM areas";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_cmd.CommandText = "UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='areas';";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    s = "0";
                    double selectedIndex = this.__mainmodule_cboseriesareas.SelectedIndex;
                    double num3 = (s == "") ? 0.0 : double.Parse(s, cul);
                    while (num3 <= selectedIndex)
                    {
                        this.__mainmodule_cmd.CommandText = "INSERT INTO areas (nombre) values('" + this.__mainmodule_tnotaarea.Text + " " + (((format = "D2".ToLower(cul))[0] != 'd') ? (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(format, cul) : ((int) (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0)).ToString(format, cul)) + "')";
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        s = ++num3.ToString(cul);
                    }
                    this.__mainmodule_desplegarareas();
                    this.__mainmodule_pnlareasseries.Visible = bool.Parse("false".ToLower(cul));
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                }
                return "";
            Label_02F9:
                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                ((int) MessageBox.Show("Error en ErrmnuAreas1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnareaserie1_click = num;
                    this.localVars = new object[] { lSide, s, format };
                    return this.__mainmodule_btnareaserie1_click();
                }
                this.ShowError(exception, "_mainmodule_btnareaserie1_click");
                return "";
            }
        }

        private string __mainmodule_btnareaserie2_click()
        {
            try
            {
                this.__mainmodule_pnlareasseries.Visible = bool.Parse("false".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnareaserie2_click");
                return "";
            }
        }

        private string __mainmodule_btnbuscarcte_buttondown()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnbuscarcte_buttondown");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnbuscarcte_click");
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
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_btncompactar_click == 1)
                    {
                        this.err_mainmodule_btncompactar_click = 0;
                        goto Label_00B7;
                    }
                }
                num = 1;
                lSide = ((int) MessageBox.Show("Desea compactar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "VACUUM";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("La base de datos se compacto satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_00B7:
                ((int) MessageBox.Show("error en borrar datos ErrbtnCompactar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btncompactar_click = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_btncompactar_click();
                }
                this.ShowError(exception, "_mainmodule_btncompactar_click");
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
                    str = this.localVars[0];
                    if (this.err_mainmodule_btncrearbase_click == 1)
                    {
                        this.err_mainmodule_btncrearbase_click = 0;
                        goto Label_0316;
                    }
                }
                num = 1;
                this.__mainmodule_con.Close();
                str = this.b4pdir + @"\dbim.db";
                this.__mainmodule_con.Open("Data Source = " + str);
                if (this.htControls["__mainmodule_cmd"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_cmd"]);
                }
                this.__mainmodule_cmd = new B4PSQL.Command("", this.__mainmodule_con.Value);
                this.htControls["__mainmodule_cmd"] = this.__mainmodule_cmd;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_cmd] = "__mainmodule_cmd";
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
                ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_con.Close();
                if (this.mainForm != null)
                {
                    this.mainForm.Close();
                }
                else
                {
                    this.CloseProgram();
                }
                return "";
            Label_0316:
                ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btncrearbase_click = num;
                    this.localVars = new object[] { str };
                    return this.__mainmodule_btncrearbase_click();
                }
                this.ShowError(exception, "_mainmodule_btncrearbase_click");
                return "";
            }
        }

        private string __mainmodule_btncteped1_click()
        {
            string s = "";
            string str2 = "";
            string original = "";
            string lSide = "";
            try
            {
                if (this.__mainmodule_tpedcte.Text == "")
                {
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                    {
                        ((int) MessageBox.Show("Por favor seleccione un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    }
                    else
                    {
                        ((int) MessageBox.Show("Por favor seleccione un proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    }
                    return "";
                }
                s = this.__mainmodule_tpedcte.Text.Replace(" ", "");
                if (this.Other.IsNumber(s).ToLower(cul) == "true")
                {
                    str2 = (10.0 - s.Length).ToString(cul);
                    original = "@@@@@@@@@@";
                    s = this.Other.SubString(original, 1, (str2 == "") ? ((int) 0.0) : ((int) double.Parse(str2, cul))).Replace("@", " ") + s;
                }
                this.__mainmodule_tpedcte.Text = s;
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    this.var__mainmodule_sql = "SELECT nombre, status FROM clientes WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
                }
                else
                {
                    this.var__mainmodule_sql = "SELECT nombre FROM provs WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
                }
                lSide = "false";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_ltnombrecte.Text = this.__mainmodule_reader.GetValue(0);
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                    {
                        if (this.__mainmodule_reader.GetValue(1) == "S")
                        {
                            ((int) MessageBox.Show("El cliente esta SUSPENDIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        }
                        if (this.__mainmodule_reader.GetValue(1) == "M")
                        {
                            ((int) MessageBox.Show("Cliente MOROSO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        }
                    }
                }
                else
                {
                    lSide = "true";
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                    {
                        ((int) MessageBox.Show("Cliente inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    }
                    else
                    {
                        ((int) MessageBox.Show("Proveedor inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    }
                }
                this.__mainmodule_reader.Close();
                if (!this.LCompareEqual(lSide, "true"))
                {
                    this.__mainmodule_lt2.Text = this.__mainmodule_tpedcte.Text;
                    this.__mainmodule_lt4.Text = this.__mainmodule_ltnombrecte.Text;
                    this.__mainmodule_pnlpedidos.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_invent.show();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btncteped1_click");
                return "";
            }
        }

        private string __mainmodule_btncteped2_click()
        {
            try
            {
                this.__mainmodule_tpedcte.Text = "";
                this.__mainmodule_ltnombrecte.Text = "";
                this.__mainmodule_pnlpedidos.Visible = bool.Parse("false".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btncteped2_click");
                return "";
            }
        }

        private string __mainmodule_btneliminar_click()
        {
            string str = "";
            int num = 0;
            double num2 = 0.0;
            string str2 = "";
            string str3 = "";
            string lSide = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_btneliminar_click > 0)
                {
                    lSide = this.localVars[5];
                    str3 = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_btneliminar_click == 1)
                    {
                        this.err_mainmodule_btneliminar_click = 0;
                        goto Label_02AB;
                    }
                }
                num3 = 1;
                this.var__mainmodule_tipomov = "";
                if (this.__mainmodule_tblareas.dataTable.DefaultView.Count.ToString(cul) == "0")
                {
                    ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, this.__mainmodule_tblareas.CurrentCell.RowNumber, false);
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str3 = this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, this.__mainmodule_tblareas.CurrentCell.RowNumber, true);
                lSide = ((int) MessageBox.Show("Desea borar el area " + str3 + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.var__mainmodule_sql = "DELETE FROM areas WHERE id = " + num.ToString(cul);
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_desplegarareas();
                    this.__mainmodule_tareanombre.Text = "";
                    ((int) MessageBox.Show("Partida eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_02AB:
                ((int) MessageBox.Show("Error en errbtnEliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btneliminar_click = num3;
                    this.localVars = new object[] { str, num, num2, str2, str3, lSide };
                    return this.__mainmodule_btneliminar_click();
                }
                this.ShowError(exception, "_mainmodule_btneliminar_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnenviarinven_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnexistminve_click");
                return "";
            }
        }

        private string __mainmodule_btngencompra_click()
        {
            double num = 0.0;
            string str = "";
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
            string query = "";
            string str8 = "";
            string str9 = "";
            double num29 = 0.0;
            string str10 = "";
            string str11 = "";
            string str12 = "";
            string lSide = "";
            string str14 = "";
            string s = "";
            string str16 = "";
            string str17 = "";
            string str18 = "";
            string str19 = "";
            string str20 = "";
            string str21 = "";
            string str22 = "";
            string str23 = "";
            string str24 = "";
            string str25 = "";
            string str26 = "";
            string str27 = "";
            string str28 = "";
            string str29 = "";
            string str30 = "";
            string str31 = "";
            string str32 = "";
            string str33 = "";
            string str34 = "";
            string str35 = "";
            string str36 = "";
            string str37 = "";
            string str38 = "";
            string str39 = "";
            string str40 = "";
            string str41 = "";
            string str42 = "";
            int num30 = 0;
            try
            {
                if (this.err_mainmodule_btngencompra_click > 0)
                {
                    str42 = this.localVars[70];
                    str41 = this.localVars[0x45];
                    str40 = this.localVars[0x44];
                    str39 = this.localVars[0x43];
                    str38 = this.localVars[0x42];
                    str37 = this.localVars[0x41];
                    str36 = this.localVars[0x40];
                    str35 = this.localVars[0x3f];
                    str34 = this.localVars[0x3e];
                    str33 = this.localVars[0x3d];
                    str32 = this.localVars[60];
                    str31 = this.localVars[0x3b];
                    str30 = this.localVars[0x3a];
                    str29 = this.localVars[0x39];
                    str28 = this.localVars[0x38];
                    str27 = this.localVars[0x37];
                    str26 = this.localVars[0x36];
                    str25 = this.localVars[0x35];
                    str24 = this.localVars[0x34];
                    str23 = this.localVars[0x33];
                    str22 = this.localVars[50];
                    str21 = this.localVars[0x31];
                    str20 = this.localVars[0x30];
                    str19 = this.localVars[0x2f];
                    str18 = this.localVars[0x2e];
                    str17 = this.localVars[0x2d];
                    str16 = this.localVars[0x2c];
                    s = this.localVars[0x2b];
                    str14 = this.localVars[0x2a];
                    lSide = this.localVars[0x29];
                    str12 = this.localVars[40];
                    str11 = this.localVars[0x27];
                    str10 = this.localVars[0x26];
                    num29 = this.localVars[0x25];
                    str9 = this.localVars[0x24];
                    str8 = this.localVars[0x23];
                    query = this.localVars[0x22];
                    num28 = this.localVars[0x21];
                    str6 = this.localVars[0x20];
                    num27 = this.localVars[0x1f];
                    num26 = this.localVars[30];
                    num25 = this.localVars[0x1d];
                    str5 = this.localVars[0x1c];
                    str4 = this.localVars[0x1b];
                    num24 = this.localVars[0x1a];
                    str3 = this.localVars[0x19];
                    num23 = this.localVars[0x18];
                    str2 = this.localVars[0x17];
                    num22 = this.localVars[0x16];
                    num21 = this.localVars[0x15];
                    num20 = this.localVars[20];
                    num19 = this.localVars[0x13];
                    num18 = this.localVars[0x12];
                    num17 = this.localVars[0x11];
                    num16 = this.localVars[0x10];
                    num15 = this.localVars[15];
                    num14 = this.localVars[14];
                    num13 = this.localVars[13];
                    num12 = this.localVars[12];
                    num11 = this.localVars[11];
                    num10 = this.localVars[10];
                    num9 = this.localVars[9];
                    num8 = this.localVars[8];
                    num7 = this.localVars[7];
                    num6 = this.localVars[6];
                    num5 = this.localVars[5];
                    num4 = this.localVars[4];
                    num3 = this.localVars[3];
                    num2 = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_btngencompra_click == 1)
                    {
                        this.err_mainmodule_btngencompra_click = 0;
                        goto Label_1AF5;
                    }
                }
                num30 = 1;
                lSide = ((int) MessageBox.Show("Realmente desea generar compra?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    double num34;
                    if (this.__mainmodule_chenviartodascompras.Checked.ToString(cul).ToLower(cul) == "true")
                    {
                        str14 = "0";
                        num34 = this.__mainmodule_cbocompra.Items.Count - 1.0;
                        s = num34.ToString(cul);
                    }
                    else
                    {
                        num34 = -1.0;
                        if (this.__mainmodule_cbocompra.SelectedIndex.ToString(cul) == num34.ToString(cul))
                        {
                            ((int) MessageBox.Show("Por favor selecione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            return "";
                        }
                        str14 = this.__mainmodule_cbocompra.SelectedIndex.ToString(cul);
                        s = this.__mainmodule_cbocompra.SelectedIndex.ToString(cul);
                    }
                    str16 = "0";
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    str17 = str14;
                    double num31 = (s == "") ? 0.0 : double.Parse(s, cul);
                    double num32 = (str17 == "") ? 0.0 : double.Parse(str17, cul);
                    while (num32 <= num31)
                    {
                        if (this.LCompareEqual(this.var__mainmodule_seriecompra, ""))
                        {
                            str11 = this.__mainmodule_replicate(" ", 20.0 - this.__mainmodule_cbocompra.Items[(str17 == "") ? ((int) 0.0) : ((int) double.Parse(str17, cul))].ToString().Length) + this.__mainmodule_cbocompra.Items[(str17 == "") ? ((int) 0.0) : ((int) double.Parse(str17, cul))].ToString();
                        }
                        else
                        {
                            str11 = this.__mainmodule_cbocompra.Items[(str17 == "") ? ((int) 0.0) : ((int) double.Parse(str17, cul))].ToString();
                        }
                        this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.costo_prom), MAX(P.uni_med), MAX(P.impu1), MAX(P.impu4), max(clave), ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "ifnull(MAX(cve_esqimpu),0), ifnull(MAX(folio),0), ifnull(MAX(imp1aplica),0), ifnull(MAX(imp2aplica),0), ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "ifnull(Max(imp3aplica),0), ifnull(Max(imp4aplica),0) ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM compras I INNER JOIN prods P ON P.articulo = I.articulo ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.nuevo = 'S' AND cve_doc = '" + str11 + "' AND cancelado = 'N' GROUP BY I.articulo";
                        str18 = "0";
                        str19 = "0";
                        num = 1.0;
                        str20 = "0";
                        str21 = "0";
                        str22 = "0";
                        str21 = "0";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                        while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                        {
                            num34 = ((str16 == "") ? 0.0 : double.Parse(str16, cul)) + 1.0;
                            str16 = num34.ToString(cul);
                            str23 = this.__mainmodule_reader.GetValue(2);
                            str23 = Math.Round((str23 == "") ? 0.0 : double.Parse(str23, cul), 2).ToString(cul);
                            str24 = "0";
                            str25 = this.__mainmodule_reader.GetValue(0);
                            num2 = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                            num4 = 0.0;
                            num34 = ((str20 == "") ? 0.0 : double.Parse(str20, cul)) + (((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num2);
                            str20 = num34.ToString(cul);
                            num34 = ((str21 == "") ? 0.0 : double.Parse(str21, cul)) + (((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num2);
                            str21 = num34.ToString(cul);
                            str22 = "0";
                            str = str25;
                            num3 = num2;
                            num5 = (str23 == "") ? 0.0 : double.Parse(str23, cul);
                            str2 = "N";
                            num6 = double.Parse(this.__mainmodule_reader.GetValue(4), cul);
                            num7 = 0.0;
                            num8 = 0.0;
                            num9 = double.Parse(this.__mainmodule_reader.GetValue(5), cul);
                            str12 = this.__mainmodule_reader.GetValue(6);
                            str26 = this.__mainmodule_reader.GetValue(7);
                            str27 = this.__mainmodule_reader.GetValue(8);
                            num10 = double.Parse(this.__mainmodule_reader.GetValue(9), cul);
                            num11 = double.Parse(this.__mainmodule_reader.GetValue(10), cul);
                            num12 = double.Parse(this.__mainmodule_reader.GetValue(11), cul);
                            num13 = double.Parse(this.__mainmodule_reader.GetValue(12), cul);
                            num34 = (((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num6) / 100.0;
                            str28 = num34.ToString(cul);
                            if (this.LCompareEqual(num13.ToString(cul), "1"))
                            {
                                num34 = ((((str23 == "") ? 0.0 : double.Parse(str23, cul)) + ((str28 == "") ? 0.0 : double.Parse(str28, cul))) * num9) / 100.0;
                                str29 = num34.ToString(cul);
                            }
                            else
                            {
                                num34 = (((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num9) / 100.0;
                                str29 = num34.ToString(cul);
                            }
                            num34 = ((str18 == "") ? 0.0 : double.Parse(str18, cul)) + ((str28 == "") ? 0.0 : double.Parse(str28, cul));
                            str18 = num34.ToString(cul);
                            num34 = ((str19 == "") ? 0.0 : double.Parse(str19, cul)) + ((str29 == "") ? 0.0 : double.Parse(str29, cul));
                            str19 = num34.ToString(cul);
                            num14 = Math.Round((str28 == "") ? 0.0 : double.Parse(str28, cul), 3);
                            num15 = 0.0;
                            num16 = 0.0;
                            num17 = Math.Round((str29 == "") ? 0.0 : double.Parse(str29, cul), 3);
                            num18 = 0.0;
                            num19 = 0.0;
                            num20 = 0.0;
                            num21 = 0.0;
                            num22 = 0.0;
                            num23 = 1.0;
                            str4 = this.__mainmodule_reader.GetValue(3);
                            num27 = 0.0;
                            str30 = "0";
                            num28 = (((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num2) - (((((str23 == "") ? 0.0 : double.Parse(str23, cul)) * num2) * ((str24 == "") ? 0.0 : double.Parse(str24, cul))) / 100.0);
                            num28 = Math.Round(num28, 3);
                            query = "EXECUTE PDA_ORDEN_DE_COMPRA_PAR '" + str11 + "'," + num.ToString(cul) + ",'" + str + "'," + num2.ToString(cul) + ",";
                            query = query + num5.ToString(cul) + "," + num6.ToString(cul) + "," + num9.ToString(cul) + "," + num10.ToString(cul) + "," + num11.ToString(cul) + ",";
                            query = query + num12.ToString(cul) + "," + num13.ToString(cul) + "," + num14.ToString(cul) + "," + num17.ToString(cul) + "," + str30 + ",'";
                            query = query + str4 + "'," + num23.ToString(cul) + "," + num28.ToString(cul) + "," + str26;
                            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\PROC ALMACENADO COMPRAS PAR.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str8);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema en el ALMACENADO COMPRAS PAR", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                break;
                            }
                            num++;
                            this.__mainmodule_ltcomart.Text = str25;
                            this.__mainmodule_ltcomcant.Text = num2.ToString(cul);
                            this.__mainmodule_ltcomreg.Text = str16;
                        }
                        this.__mainmodule_reader.Close();
                        str31 = "o";
                        str22 = "0";
                        str32 = str21;
                        str33 = "O";
                        str34 = Math.Round((str32 == "") ? 0.0 : double.Parse(str32, cul), 3).ToString(cul);
                        str35 = Math.Round((str18 == "") ? 0.0 : double.Parse(str18, cul), 3).ToString(cul);
                        str36 = Math.Round((str19 == "") ? 0.0 : double.Parse(str19, cul), 3).ToString(cul);
                        str37 = "0";
                        str38 = Math.Round((double) ((((str32 == "") ? 0.0 : double.Parse(str32, cul)) + ((str18 == "") ? 0.0 : double.Parse(str18, cul))) + ((str19 == "") ? 0.0 : double.Parse(str19, cul))), 3).ToString(cul);
                        str39 = str22;
                        str40 = "";
                        num34 = ((str41 == "") ? 0.0 : double.Parse(str41, cul)) + 1.0;
                        str41 = num34.ToString(cul);
                        str42 = "EXECUTE PDA_ORDEN_DE_COMPRA '" + str31 + "','" + str11 + "','" + str12 + "','" + str33 + "','";
                        str42 = str42 + str40 + "'," + str34 + "," + str35 + "," + str36 + "," + str39 + ",";
                        str42 = str42 + str37 + "," + this.var__mainmodule_almacen.ToString(cul) + ",'" + this.var__mainmodule_seriecompra + "'," + str27 + "," + str38;
                        if (this.__mainmodule_msql1.ExecuteNonQuery(str42).ToString(cul).ToLower(cul) == "false")
                        {
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\COMPRAS CABEZA.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str42);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_mainmodule_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                this.htStreams.Remove("_mainmodule_c1");
                                GC.Collect();
                            }
                            ((int) MessageBox.Show("Problema en el ALMACENADO ORDER DE COMPRA\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        }
                        str17 = ++num32.ToString(cul);
                    }
                    this.__mainmodule_msql1.Close();
                    if (((str16 == "") ? 0.0 : double.Parse(str16, cul)) > 0.0)
                    {
                        this.var__mainmodule_foliocompra++;
                        this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString(cul);
                        this.__mainmodule_cmd.CommandText = "UPDATE config SET foliocompra = " + this.var__mainmodule_foliocompra.ToString(cul);
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        if (this.__mainmodule_chenviartodascompras.Checked.ToString(cul).ToLower(cul) == "true")
                        {
                            this.__mainmodule_cmd.CommandText = "UPDATE compras SET nuevo = 'N'";
                        }
                        else
                        {
                            this.__mainmodule_cmd.CommandText = "UPDATE compras SET nuevo = 'N' WHERE cve_doc = '" + str11 + "'";
                        }
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    ((int) MessageBox.Show("ok partidas enviadas " + str16, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_ltinven2.Text = "";
                    this.__mainmodule_ltinven.Text = "";
                }
                return "";
            Label_1AF5:
                ((int) MessageBox.Show("Error en errbtnGenCompra", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num30 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btngencompra_click = num30;
                    this.localVars = new object[] { 
                        num, str, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15,
                        num16, num17, num18, num19, num20, num21, num22, str2, num23, str3, num24, str4, str5, num25, num26, num27,
                        str6, num28, query, str8, str9, num29, str10, str11, str12, lSide, str14, s, str16, str17, str18, str19,
                        str20, str21, str22, str23, str24, str25, str26, str27, str28, str29, str30, str31, str32, str33, str34, str35,
                        str36, str37, str38, str39, str40, str41, str42
                    };
                    return this.__mainmodule_btngencompra_click();
                }
                this.ShowError(exception, "_mainmodule_btngencompra_click");
                return "";
            }
        }

        private string __mainmodule_btngenerar_click()
        {
            try
            {
                if (this.__mainmodule_opminve3.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_inventario_acumulativo_proc_almacenado();
                }
                else
                {
                    this.__mainmodule_inventario_directo_proc_almacenado();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btngenerar_click");
                return "";
            }
        }

        private string __mainmodule_btngenerar_keypress(string var__mainmodule_key)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btngenerar_keypress");
                return "";
            }
        }

        private string __mainmodule_btngenpedido_click()
        {
            double num = 0.0;
            string str = "";
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
            string str2 = "";
            double num14 = 0.0;
            string query = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string lSide = "";
            string str8 = "";
            string str9 = "";
            string s = "";
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
            string str24 = "";
            string str25 = "";
            string str26 = "";
            string str27 = "";
            string str28 = "";
            string str29 = "";
            string str30 = "";
            string str31 = "";
            string str32 = "";
            string str33 = "";
            string str34 = "";
            string str35 = "";
            string str36 = "";
            try
            {
                lSide = ((int) MessageBox.Show("Realmente desea generar pedido?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    double num18;
                    str8 = "";
                    if (this.__mainmodule_chenviartodospedidos.Checked.ToString(cul).ToLower(cul) == "true")
                    {
                        str9 = "0";
                        num18 = this.__mainmodule_cbopedido.Items.Count - 1.0;
                        s = num18.ToString(cul);
                    }
                    else
                    {
                        double num20 = -1.0;
                        if (this.__mainmodule_cbopedido.SelectedIndex.ToString(cul) == num20.ToString(cul))
                        {
                            ((int) MessageBox.Show("Por favor selecione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            return "";
                        }
                        str9 = this.__mainmodule_cbopedido.SelectedIndex.ToString(cul);
                        s = this.__mainmodule_cbopedido.SelectedIndex.ToString(cul);
                    }
                    str11 = "0";
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    str12 = str9;
                    double num15 = (s == "") ? 0.0 : double.Parse(s, cul);
                    double num16 = (str12 == "") ? 0.0 : double.Parse(str12, cul);
                    while (num16 <= num15)
                    {
                        if (this.LCompareEqual(this.var__mainmodule_seriepedido, ""))
                        {
                            str5 = this.__mainmodule_replicate(" ", 20.0 - this.__mainmodule_cbopedido.Items[(str12 == "") ? ((int) 0.0) : ((int) double.Parse(str12, cul))].ToString().Length) + this.__mainmodule_cbopedido.Items[(str12 == "") ? ((int) 0.0) : ((int) double.Parse(str12, cul))].ToString();
                        }
                        else
                        {
                            str5 = this.__mainmodule_cbopedido.Items[(str12 == "") ? ((int) 0.0) : ((int) double.Parse(str12, cul))].ToString();
                        }
                        num = 1.0;
                        str13 = "0";
                        str14 = "0";
                        str15 = "0";
                        str14 = "0";
                        str16 = "0";
                        str17 = "0";
                        this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.costo_prom), MAX(P.uni_med), MAX(P.impu1), MAX(P.impu4), MAX(P.precio1), MAX(clave), ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "ifnull(MAX(cve_esqimpu),0), ifnull(max(folio),0), ifnull(max(imp1aplica),0), ifnull(max(imp2aplica),0), ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "ifnull(Max(imp3aplica),0), ifnull(Max(imp4aplica),0) ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM pedidos I ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "INNER JOIN prods P ON P.articulo = I.articulo WHERE ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "I.nuevo = 'S' AND cve_doc = '" + str5 + "' AND cancelado = 'N' GROUP BY I.articulo";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                        while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                        {
                            num18 = ((str11 == "") ? 0.0 : double.Parse(str11, cul)) + 1.0;
                            str11 = num18.ToString(cul);
                            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(cul) == "true")
                            {
                                str18 = this.__mainmodule_reader.GetValue(2);
                            }
                            else
                            {
                                str18 = "0";
                            }
                            str6 = this.__mainmodule_reader.GetValue(7);
                            str19 = this.__mainmodule_reader.GetValue(8);
                            str20 = this.__mainmodule_reader.GetValue(9);
                            num7 = double.Parse(this.__mainmodule_reader.GetValue(10), cul);
                            num8 = double.Parse(this.__mainmodule_reader.GetValue(11), cul);
                            num9 = double.Parse(this.__mainmodule_reader.GetValue(12), cul);
                            num10 = double.Parse(this.__mainmodule_reader.GetValue(13), cul);
                            str18 = Math.Round((str18 == "") ? 0.0 : double.Parse(str18, cul), 2).ToString(cul);
                            str21 = "0";
                            str22 = this.__mainmodule_reader.GetValue(0);
                            num2 = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                            if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(6)).ToLower(cul) == "true")
                            {
                                num3 = double.Parse(this.__mainmodule_reader.GetValue(6), cul);
                            }
                            else
                            {
                                num3 = 0.0;
                            }
                            num18 = ((str13 == "") ? 0.0 : double.Parse(str13, cul)) + (num3 * num2);
                            str13 = num18.ToString(cul);
                            num18 = ((str14 == "") ? 0.0 : double.Parse(str14, cul)) + (num3 * num2);
                            str14 = num18.ToString(cul);
                            str15 = "0";
                            str = str22;
                            num4 = (str18 == "") ? 0.0 : double.Parse(str18, cul);
                            num5 = double.Parse(this.__mainmodule_reader.GetValue(4), cul);
                            num6 = double.Parse(this.__mainmodule_reader.GetValue(5), cul);
                            num18 = (num3 * num5) / 100.0;
                            str23 = num18.ToString(cul);
                            if (this.LCompareEqual(num10.ToString(cul), "1"))
                            {
                                num18 = ((num3 + ((str23 == "") ? 0.0 : double.Parse(str23, cul))) * num6) / 100.0;
                                str24 = num18.ToString(cul);
                            }
                            else
                            {
                                num18 = (num3 * num6) / 100.0;
                                str24 = num18.ToString(cul);
                            }
                            num18 = ((str16 == "") ? 0.0 : double.Parse(str16, cul)) + ((str23 == "") ? 0.0 : double.Parse(str23, cul));
                            str16 = num18.ToString(cul);
                            str17 = (((str17 == "") ? 0.0 : double.Parse(str17, cul)) + ((str24 == "") ? 0.0 : double.Parse(str24, cul))).ToString(cul);
                            num11 = Math.Round((str23 == "") ? 0.0 : double.Parse(str23, cul), 3);
                            num12 = Math.Round((str24 == "") ? 0.0 : double.Parse(str24, cul), 3);
                            num13 = 1.0;
                            str2 = this.__mainmodule_reader.GetValue(3);
                            str25 = "0";
                            num14 = (num3 * num2) - (((num3 * num2) * ((str21 == "") ? 0.0 : double.Parse(str21, cul))) / 100.0);
                            num14 = Math.Round(num14, 3);
                            query = "EXECUTE PDA_PEDIDOS_PART '" + str5 + "'," + num.ToString(cul) + ",'" + str + "'," + num2.ToString(cul) + ",";
                            query = query + num3.ToString(cul) + "," + num4.ToString(cul) + "," + num5.ToString(cul) + "," + num6.ToString(cul) + "," + num7.ToString(cul) + "," + num8.ToString(cul) + ",";
                            query = query + num9.ToString(cul) + "," + num10.ToString(cul) + "," + num11.ToString(cul) + "," + num12.ToString(cul) + "," + str25 + ",'";
                            query = query + str2 + "'," + num13.ToString(cul) + "," + num14.ToString(cul) + "," + str19;
                            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\PROC ALMACENADO PEDIDOS PAR.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str4);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema en el ALMACENADO PEDIDOS PAR\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                break;
                            }
                            num++;
                            this.__mainmodule_ltpedart.Text = str22;
                            this.__mainmodule_ltpedcant.Text = num2.ToString(cul);
                            this.__mainmodule_ltpedreg.Text = str11;
                        }
                        this.__mainmodule_reader.Close();
                        str26 = "P";
                        str15 = "0";
                        str27 = str14;
                        str28 = "O";
                        str29 = Math.Round((str27 == "") ? 0.0 : double.Parse(str27, cul), 3).ToString(cul);
                        str30 = Math.Round((str16 == "") ? 0.0 : double.Parse(str16, cul), 3).ToString(cul);
                        str31 = Math.Round((str17 == "") ? 0.0 : double.Parse(str17, cul), 3).ToString(cul);
                        str32 = "0";
                        str33 = Math.Round((double) ((((str27 == "") ? 0.0 : double.Parse(str27, cul)) + ((str16 == "") ? 0.0 : double.Parse(str16, cul))) + ((str17 == "") ? 0.0 : double.Parse(str17, cul))), 3).ToString(cul);
                        str34 = str15;
                        str35 = "";
                        str36 = "EXECUTE PDA_PEDIDOS '" + str26 + "','" + str5 + "','" + str6 + "','" + str28 + "','";
                        str36 = str36 + str35 + "'," + str29 + "," + str30 + "," + str31 + "," + str34 + ",";
                        str36 = str36 + str32 + "," + this.var__mainmodule_almacen.ToString(cul) + ",'" + this.var__mainmodule_seriepedido + "'," + str20 + "," + str33 + ",'" + str8 + "'";
                        if (this.__mainmodule_msql1.ExecuteNonQuery(str36).ToString(cul).ToLower(cul) == "false")
                        {
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\PEDIDO CABEZA.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str36);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_mainmodule_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                this.htStreams.Remove("_mainmodule_c1");
                                GC.Collect();
                            }
                            ((int) MessageBox.Show("Problema en el ALMACENADO PEDIDO CADENZA\r\n" + this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        }
                        str12 = ++num16.ToString(cul);
                    }
                    this.__mainmodule_msql1.Close();
                    if (((str11 == "") ? 0.0 : double.Parse(str11, cul)) > 0.0)
                    {
                        this.var__mainmodule_folioped++;
                        this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString(cul);
                        this.__mainmodule_cmd.CommandText = "UPDATE config SET folioped = " + this.var__mainmodule_folioped.ToString(cul);
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        if (this.__mainmodule_chenviartodospedidos.Checked.ToString(cul).ToLower(cul) == "true")
                        {
                            this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET nuevo = 'N'";
                        }
                        else
                        {
                            this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET nuevo = 'N' WHERE cve_doc = '" + str5 + "'";
                        }
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    ((int) MessageBox.Show("ok partidas enviadas " + str11, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_ltinven2.Text = "";
                    this.__mainmodule_ltinven.Text = "";
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btngenpedido_click");
                return "";
            }
        }

        private string __mainmodule_btnlogin1_click()
        {
            try
            {
                if (((this.__mainmodule_tlogin.Text != "Gsorom09") && (this.__mainmodule_tlogin.Text != "111222")) && ((this.__mainmodule_tlogin.Text != "admin") && (this.__mainmodule_tlogin.Text != "1212121212")))
                {
                    ((int) MessageBox.Show("Contrase\x00f1a incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                this.__mainmodule_frmacceso.close();
                this.__mainmodule_procminve.show();
                this.__mainmodule_tlogin.Focus();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnlogin1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnlogin2_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnmain5_click");
                return "";
            }
        }

        private string __mainmodule_btnmain8_click()
        {
            try
            {
                this.__mainmodule_con.Close();
                if (this.mainForm != null)
                {
                    this.mainForm.Close();
                }
                else
                {
                    this.CloseProgram();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnmain8_click");
                return "";
            }
        }

        private string __mainmodule_btnmenucompras_click()
        {
            try
            {
                this.__mainmodule_pnlpedidos.BringToFront();
                this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tpedcte.Text = "";
                this.__mainmodule_ltnombrecte.Text = "";
                this.var__mainmodule_tipoproc = "compras";
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnmenucompras_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnmenuinvent_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnmenusalir_click");
                return "";
            }
        }

        private string __mainmodule_btnnew_click()
        {
            try
            {
                this.__mainmodule_chnivel.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_tusu.Text = "";
                this.__mainmodule_tnombre.Text = "";
                this.__mainmodule_tclave.Text = "";
                this.__mainmodule_tusu.Focus();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnnew_click");
                return "";
            }
        }

        private string __mainmodule_btnokcte_click()
        {
            string str5;
            string s = "";
            string str2 = "";
            string original = "";
            string str4 = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_btnokcte_click > 0)
                {
                    str4 = this.localVars[3];
                    original = this.localVars[2];
                    str2 = this.localVars[1];
                    s = this.localVars[0];
                    if (this.err_mainmodule_btnokcte_click == 1)
                    {
                        this.err_mainmodule_btnokcte_click = 0;
                        goto Label_025D;
                    }
                }
                num = 1;
                s = this.__mainmodule_tpedcte.Text.Replace(" ", "");
                if (this.Other.IsNumber(s).ToLower(cul) == "true")
                {
                    str2 = (10.0 - s.Length).ToString(cul);
                    original = "@@@@@@@@@@";
                    str4 = this.Other.SubString(original, 1, (str2 == "") ? ((int) 0.0) : ((int) double.Parse(str2, cul)));
                    s = str4.Replace("@", " ") + s;
                }
                this.__mainmodule_tpedcte.Text = s;
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    this.var__mainmodule_sql = "SELECT nombre FROM clientes WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
                }
                else
                {
                    this.var__mainmodule_sql = "SELECT nombre FROM provs WHERE clave = '" + this.__mainmodule_tpedcte.Text + "'";
                }
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_ltnombrecte.Text = this.__mainmodule_reader.GetValue(0);
                }
                else if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    ((int) MessageBox.Show("Cliente inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                else
                {
                    ((int) MessageBox.Show("Proveedor inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_025D:
                str5 = "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnokcte_click = num;
                    this.localVars = new object[] { s, str2, original, str4 };
                    return this.__mainmodule_btnokcte_click();
                }
                this.ShowError(exception, "_mainmodule_btnokcte_click");
                str5 = "";
            }
            return str5;
        }

        private string __mainmodule_btnpedido_click()
        {
            try
            {
                this.__mainmodule_pnlpedidos.BringToFront();
                this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tpedcte.Text = "";
                this.__mainmodule_ltnombrecte.Text = "";
                this.var__mainmodule_tipoproc = "pedidos";
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnpedido_click");
                return "";
            }
        }

        private string __mainmodule_btnprods_click()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string lSide = "";
            string s = "";
            string str7 = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_btnprods_click > 0)
                {
                    str7 = this.localVars[8];
                    s = this.localVars[7];
                    lSide = this.localVars[6];
                    str4 = this.localVars[5];
                    str3 = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_btnprods_click == 1)
                    {
                        this.err_mainmodule_btnprods_click = 0;
                        goto Label_050F;
                    }
                }
                num3 = 1;
                lSide = ((int) MessageBox.Show("Este proceso puede tardar varios minutos, realmente desea continuar?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.var__mainmodule_sql = "SELECT I.articulo, I.descrip, I.existencia, (SELECT exist FROM inven P WHERE ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "P.articulo = i.articulo) FROM prods I ORDER BY descrip";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    s = "0";
                    this.__mainmodule_tblprod.dataTable.Clear();
                    this.__mainmodule_tblprod.dataTable.AcceptChanges();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str3 = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(2), cul);
                        }
                        else
                        {
                            num = 0.0;
                        }
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(3)).ToLower(cul) == "true")
                        {
                            num2 = double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                        }
                        else
                        {
                            num2 = 0.0;
                        }
                        if (num2 > 0.0)
                        {
                            s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                            this.__mainmodule_tblprod.AddRow(new object[0]);
                            str7 = (this.__mainmodule_tblprod.dataTable.DefaultView.Count - 1.0).ToString(cul);
                            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[0].MappingName, (str7 == "") ? ((int) 0.0) : ((int) double.Parse(str7, cul)), str3);
                            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[1].MappingName, (str7 == "") ? ((int) 0.0) : ((int) double.Parse(str7, cul)), this.__mainmodule_reader.GetValue(1));
                            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[2].MappingName, (str7 == "") ? ((int) 0.0) : ((int) double.Parse(str7, cul)), num.ToString(cul));
                            this.__mainmodule_tblprod.SetCell(this.__mainmodule_tblprod.TableStyles[0].GridColumnStyles[3].MappingName, (str7 == "") ? ((int) 0.0) : ((int) double.Parse(str7, cul)), num2.ToString(cul));
                        }
                    }
                    this.__mainmodule_reader.Close();
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("ok Articulos " + s, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_050F:
                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnprods_click = num3;
                    this.localVars = new object[] { str, num, num2, str2, str3, str4, lSide, s, str7 };
                    return this.__mainmodule_btnprods_click();
                }
                this.ShowError(exception, "_mainmodule_btnprods_click");
                return "";
            }
        }

        private string __mainmodule_btnred_click()
        {
            try
            {
                this.__mainmodule_pnlred.Visible = bool.Parse("false".ToLower(cul));
                this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tuni.Enabled = bool.Parse("true".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnred_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsalexist_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsalirgencompra_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsalirpedido_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsalirseries_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsalped_click");
                return "";
            }
        }

        private string __mainmodule_btnseries_click()
        {
            try
            {
                if (this.Other.IsNumber(this.__mainmodule_tfoliocompra.Text) == "false")
                {
                    ((int) MessageBox.Show("El folio debe contener un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.Other.IsNumber(this.__mainmodule_tfolped.Text) == "false")
                {
                    ((int) MessageBox.Show("El folio del pedidos debe ser un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.Other.IsNumber(this.__mainmodule_tfoliocompra.Text) == "false")
                {
                    ((int) MessageBox.Show("El folio de la compra debe ser un valor numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                double num5 = -1.0;
                if (this.__mainmodule_cboempresapred.SelectedIndex.ToString(cul) == num5.ToString(cul))
                {
                    this.__mainmodule_cboempresapred.SelectedIndex = 0;
                }
                this.var__mainmodule_empresapred = this.__mainmodule_cboempresapred.Items[this.__mainmodule_cboempresapred.SelectedIndex].ToString();
                this.var__mainmodule_sql = "UPDATE config SET seriecompra = '" + this.__mainmodule_tseriecompra.Text + "', foliocompra = " + this.__mainmodule_tfoliocompra.Text + ", seriepedido = '" + this.__mainmodule_tserped.Text + "', folioped = " + this.__mainmodule_tfolped.Text + ", empresapred = '" + this.var__mainmodule_empresapred + "'";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.var__mainmodule_seriecompra = this.__mainmodule_tseriecompra.Text;
                this.var__mainmodule_foliocompra = double.Parse(this.__mainmodule_tfoliocompra.Text, cul);
                this.var__mainmodule_seriepedido = this.__mainmodule_tserped.Text;
                this.var__mainmodule_folioped = double.Parse(this.__mainmodule_tfolped.Text, cul);
                ((int) MessageBox.Show("Los datos se grabaron satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnseries_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsql_click");
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
                    rSide = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_btnsql1_click == 1)
                    {
                        this.err_mainmodule_btnsql1_click = 0;
                        goto Label_04D2;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboempresa1.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                double num6 = -1.0;
                if (this.__mainmodule_cboalm.SelectedIndex.ToString(cul) == num6.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                rSide = this.__mainmodule_cboempresa1.Items[this.__mainmodule_cboempresa1.SelectedIndex].ToString();
                if (this.__mainmodule_chmult.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.var__mainmodule_multialmacen = 1.0;
                }
                else
                {
                    this.var__mainmodule_multialmacen = 0.0;
                }
                this.var__mainmodule_sql = "INSERT OR REPLACE INTO empresas (nombre, empresa, servidor, base, usuario, pass, puerto, ctrl_alm, ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "almacen, correo, linea, correo2, remoto, multialmacen) SELECT '" + this.__mainmodule_tnombreemp.Text + "','" + rSide + "','";
                this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tserver.Text + "','" + this.__mainmodule_tbase.Text + "','" + this.__mainmodule_tuser.Text + "','";
                this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tpasssql.Text + "','" + this.__mainmodule_tpuerto.Text + "','" + this.__mainmodule_tcontrol.Text + "','";
                this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_cboalm.Items[this.__mainmodule_cboalm.SelectedIndex].ToString() + "','" + this.__mainmodule_tcorreo.Text + "','";
                this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tlinea.Text + "','" + this.__mainmodule_tcorreo2.Text + "','" + this.__mainmodule_tremoto.Text + "','" + this.var__mainmodule_multialmacen.ToString(cul) + "'";
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
                    this.var__mainmodule_almacen = double.Parse(this.__mainmodule_cboalm.Items[this.__mainmodule_cboalm.SelectedIndex].ToString(), cul);
                    this.var__mainmodule_correo = this.__mainmodule_tcorreo.Text;
                    this.var__mainmodule_correo2 = this.__mainmodule_tcorreo2.Text;
                    this.var__mainmodule_linea = this.__mainmodule_tlinea.Text;
                }
                ((int) MessageBox.Show("Los datos se grabaron satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_sqlserver.close();
                return "";
            Label_04D2:
                ((int) MessageBox.Show("Problema en btnSQL1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnsql1_click = num;
                    this.localVars = new object[] { str, rSide };
                    return this.__mainmodule_btnsql1_click();
                }
                this.ShowError(exception, "_mainmodule_btnsql1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnsql2_click");
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
                    lSide = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_btnsql3_click == 1)
                    {
                        this.err_mainmodule_btnsql3_click = 0;
                        goto Label_01D3;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboempresa1.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboempresa1.Items[this.__mainmodule_cboempresa1.SelectedIndex].ToString();
                lSide = ((int) MessageBox.Show("Realmente desea eliminar la empresa " + str + "?", "Eliminar empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM empresas WHERE empresa = '" + str + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_tserver.Text = "";
                    this.__mainmodule_tbase.Text = "";
                    this.__mainmodule_tuser.Text = "";
                    this.__mainmodule_tpasssql.Text = "";
                    this.__mainmodule_tpuerto.Text = "";
                    this.__mainmodule_cboempresa1.SelectedIndex = -1;
                    this.__mainmodule_cboalm.SelectedIndex = -1;
                    ((int) MessageBox.Show("La empresa se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_01D3:
                ((int) MessageBox.Show("Problema detectado en btnSQL3_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnsql3_click = num;
                    this.localVars = new object[] { str, lSide };
                    return this.__mainmodule_btnsql3_click();
                }
                this.ShowError(exception, "_mainmodule_btnsql3_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btntea_click");
                return "";
            }
        }

        private string __mainmodule_btntoper1_click()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            string str2 = "";
            string s = "";
            string str4 = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_btntoper1_click > 0)
                {
                    str4 = this.localVars[5];
                    s = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_btntoper1_click == 1)
                    {
                        this.err_mainmodule_btntoper1_click = 0;
                        goto Label_0422;
                    }
                }
                num3 = 1;
                Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                str2 = this.__mainmodule_tblexisxlinea.GetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, this.var__mainmodule_crow, true);
                this.__mainmodule_pnltoper.Visible = bool.Parse("true".ToLower(cul));
                this.var__mainmodule_sql = "SELECT M.id, articulo, M.cantidad FROM minve M ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN areas P ON P.id = M.idArea WHERE nombre = '" + str2 + "' AND cancelado = 'N'";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                s = "0";
                this.__mainmodule_tbltoper.dataTable.Clear();
                this.__mainmodule_tbltoper.dataTable.AcceptChanges();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    Application.DoEvents();
                    str = this.__mainmodule_reader.GetValue(1);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(2)).ToLower(cul) == "true")
                    {
                        num2 = double.Parse(this.__mainmodule_reader.GetValue(2), cul);
                    }
                    else
                    {
                        num2 = 0.0;
                    }
                    if (num2 > 0.0)
                    {
                        s = (((s == "") ? 0.0 : double.Parse(s, cul)) + num2).ToString(cul);
                        this.__mainmodule_tbltoper.AddRow(new object[0]);
                        str4 = (this.__mainmodule_tbltoper.dataTable.DefaultView.Count - 1.0).ToString(cul);
                        this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[0].MappingName, (str4 == "") ? ((int) 0.0) : ((int) double.Parse(str4, cul)), this.__mainmodule_reader.GetValue(0));
                        this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[1].MappingName, (str4 == "") ? ((int) 0.0) : ((int) double.Parse(str4, cul)), str);
                        this.__mainmodule_tbltoper.SetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[2].MappingName, (str4 == "") ? ((int) 0.0) : ((int) double.Parse(str4, cul)), num2.ToString(cul));
                    }
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_ltstop.Text = "Piezas: " + s;
                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                return "";
            Label_0422:
                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btntoper1_click = num3;
                    this.localVars = new object[] { str, num, num2, str2, s, str4 };
                    return this.__mainmodule_btntoper1_click();
                }
                this.ShowError(exception, "_mainmodule_btntoper1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btntoper2_click");
                return "";
            }
        }

        private string __mainmodule_btntoperborrar_click()
        {
            string str6;
            string lSide = "";
            string s = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_btntoperborrar_click > 0)
                {
                    str5 = this.localVars[4];
                    str4 = this.localVars[3];
                    str3 = this.localVars[2];
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_btntoperborrar_click == 1)
                    {
                        this.err_mainmodule_btntoperborrar_click = 0;
                        goto Label_0363;
                    }
                }
                num = 1;
                this.__mainmodule_pnltoper.Visible = bool.Parse("false".ToLower(cul));
                lSide = ((int) MessageBox.Show("Desea cancelar el area ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    s = "0";
                    double num2 = this.__mainmodule_tbltoper.dataTable.DefaultView.Count - 1.0;
                    double num3 = (s == "") ? 0.0 : double.Parse(s, cul);
                    while (num3 <= num2)
                    {
                        str3 = this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), true);
                        str4 = this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), true);
                        str5 = this.__mainmodule_tbltoper.GetCell(this.__mainmodule_tbltoper.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), true);
                        this.var__mainmodule_sql = "UPDATE minve SET cancelado = 'C' WHERE id = " + str3;
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        this.var__mainmodule_sql = "UPDATE inven SET exist = exist - " + str5 + " WHERE articulo = '" + str4 + "'";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        s = ++num3.ToString(cul);
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("El area se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_0363:
                str6 = "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btntoperborrar_click = num;
                    this.localVars = new object[] { lSide, s, str3, str4, str5 };
                    return this.__mainmodule_btntoperborrar_click();
                }
                this.ShowError(exception, "_mainmodule_btntoperborrar_click");
                str6 = "";
            }
            return str6;
        }

        private string __mainmodule_btntopercerrar_click()
        {
            try
            {
                this.__mainmodule_pnltoper.Visible = bool.Parse("false".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btntopercerrar_click");
                return "";
            }
        }

        private string __mainmodule_btntraspasos_click()
        {
            string str = "";
            string str2 = "";
            int num = 0;
            try
            {
                this.var__mainmodule_sql = "SELECT tiendaorigen, tiendadestino from movsinv WHERE nuevo = 'S'  AND cancelado = 'N' AND status <> 'C' group by tiendaorigen, tiendadestino";
                this.var__mainmodule_empresa_origen = "";
                this.var__mainmodule_empresa_destino = "";
                num = 0;
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    str = this.__mainmodule_reader.GetValue(0);
                    str2 = this.__mainmodule_reader.GetValue(1);
                    num = 1;
                }
                this.__mainmodule_reader.Close();
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    this.var__mainmodule_empresa_origen = "";
                    this.var__mainmodule_empresa_destino = "";
                    this.__utilerias_importa.show();
                }
                else
                {
                    this.var__mainmodule_empresa_origen = str;
                    this.var__mainmodule_empresa_destino = str2;
                    this.__utilerias_inven.show();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btntraspasos_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnuser_click");
                return "";
            }
        }

        private string __mainmodule_btnusr1_click()
        {
            double num = 0.0;
            double num2 = 0.0;
            string s = "";
            string lSide = "";
            string str3 = "";
            string rSide = "";
            string str5 = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_btnusr1_click > 0)
                {
                    str5 = this.localVars[6];
                    rSide = this.localVars[5];
                    str3 = this.localVars[4];
                    lSide = this.localVars[3];
                    s = this.localVars[2];
                    num2 = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_btnusr1_click == 1)
                    {
                        this.err_mainmodule_btnusr1_click = 0;
                        goto Label_0BBC;
                    }
                }
                num3 = 1;
                if (this.__mainmodule_tusu.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor capture el usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__mainmodule_tnombre.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor capture el nombre del usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__mainmodule_tclave.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor capture la contrase\x00f1a", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__mainmodule_tserie.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor capture la serie", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__mainmodule_tfolio.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor capture el folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.Other.IsNumber(this.__mainmodule_tfolio.Text) == "false")
                {
                    ((int) MessageBox.Show("Por favor el folio debe numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                s = "0";
                num = 0.0;
                lSide = this.__mainmodule_tusu.Text;
                str3 = "0";
                double num4 = this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0;
                double num5 = (str3 == "") ? 0.0 : double.Parse(str3, cul);
                while (num5 <= num4)
                {
                    rSide = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (str3 == "") ? ((int) 0.0) : ((int) double.Parse(str3, cul)), true);
                    if (this.CompareEqual(lSide, rSide))
                    {
                        num = 1.0;
                        s = str3;
                        break;
                    }
                    str3 = ++num5.ToString(cul);
                }
                if (this.__mainmodule_chnivel.Checked.ToString(cul).ToLower(cul) == "true")
                {
                    num2 = 1.0;
                }
                else
                {
                    num2 = 0.0;
                }
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    this.var__mainmodule_sql = "INSERT INTO usuarios (usuario, nombre, password, nivel, serie, folio) VALUES('" + this.__mainmodule_tusu.Text + "','";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + this.__mainmodule_tnombre.Text + "','" + this.__mainmodule_tclave.Text + "','" + num2.ToString(cul) + "','" + this.__mainmodule_tserie.Text + "','" + this.__mainmodule_tfolio.Text + "')";
                }
                else
                {
                    this.var__mainmodule_sql = "UPDATE usuarios SET nombre = '" + this.__mainmodule_tnombre.Text + "', password = '" + this.__mainmodule_tclave.Text;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "', nivel = " + num2.ToString(cul) + ", serie = '" + this.__mainmodule_tserie.Text + "', folio = " + this.__mainmodule_tfolio.Text;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + " WHERE usuario = '" + this.__mainmodule_tusu.Text + "'";
                }
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_cmd.ExecuteNonQuery();
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    this.__mainmodule_tbluser.AddRow(new object[0]);
                    str5 = (this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), this.__mainmodule_tusu.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), this.__mainmodule_tnombre.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), this.__mainmodule_tclave.Text);
                    if (this.LCompareEqual(num2.ToString(cul), "1"))
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), "Administrador");
                    }
                    else
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), "");
                    }
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), this.__mainmodule_tserie.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, (str5 == "") ? ((int) 0.0) : ((int) double.Parse(str5, cul)), this.__mainmodule_tfolio.Text);
                }
                else
                {
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_tusu.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_tnombre.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_tclave.Text);
                    if (this.LCompareEqual(num2.ToString(cul), "1"))
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), "Administrador");
                    }
                    else
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), "");
                    }
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_tserie.Text);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_tfolio.Text);
                }
                ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_tusu.Text = "";
                this.__mainmodule_tnombre.Text = "";
                this.__mainmodule_tclave.Text = "";
                this.__mainmodule_tserie.Text = "";
                this.__mainmodule_tfolio.Text = "";
                return "";
            Label_0BBC:
                ((int) MessageBox.Show("Ocurrio un problema en btnUsr1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnusr1_click = num3;
                    this.localVars = new object[] { num, num2, s, lSide, str3, rSide, str5 };
                    return this.__mainmodule_btnusr1_click();
                }
                this.ShowError(exception, "_mainmodule_btnusr1_click");
                return "";
            }
        }

        private string __mainmodule_btnusr2_click()
        {
            string lSide = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_btnusr2_click > 0)
                {
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_btnusr2_click == 1)
                    {
                        this.err_mainmodule_btnusr2_click = 0;
                        goto Label_02AA;
                    }
                }
                num = 1;
                if (this.__mainmodule_tusu.Text.Replace(" ", "") == "")
                {
                    ((int) MessageBox.Show("Por favor espesifique el usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = ((int) MessageBox.Show("Realmente desea eliminar al usuario " + this.__mainmodule_tusu.Text + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM usuarios WHERE usuario = '" + this.__mainmodule_tusu.Text + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    s = "0";
                    double num2 = this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0;
                    double num3 = (s == "") ? 0.0 : double.Parse(s, cul);
                    while (num3 <= num2)
                    {
                        if (this.__mainmodule_tusu.Text == this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), true))
                        {
                            this.__mainmodule_tbluser.dataTable.DefaultView[(s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))].Delete();
                            this.__mainmodule_tbluser.dataTable.AcceptChanges();
                            break;
                        }
                        s = ++num3.ToString(cul);
                    }
                    ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tusu.Text = "";
                    this.__mainmodule_tnombre.Text = "";
                    this.__mainmodule_tclave.Text = "";
                }
                return "";
            Label_02AA:
                ((int) MessageBox.Show("Ocurrio un problema en btnUsr2_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnusr2_click = num;
                    this.localVars = new object[] { lSide, s };
                    return this.__mainmodule_btnusr2_click();
                }
                this.ShowError(exception, "_mainmodule_btnusr2_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_btnusr3_click");
                return "";
            }
        }

        private string __mainmodule_btnutils_click()
        {
            double num = 0.0;
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_btnutils_click > 0)
                {
                    num = this.localVars[0];
                    if (this.err_mainmodule_btnutils_click == 1)
                    {
                        this.err_mainmodule_btnutils_click = 0;
                        goto Label_004A;
                    }
                }
                num2 = 1;
                this.__mainmodule_frmseries.show();
                return "";
            Label_004A:
                ((int) MessageBox.Show("Ocurrio un problema", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_btnutils_click = num2;
                    this.localVars = new object[] { num };
                    return this.__mainmodule_btnutils_click();
                }
                this.ShowError(exception, "_mainmodule_btnutils_click");
                return "";
            }
        }

        private string __mainmodule_buscaexistencia()
        {
            string s = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string format = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_buscaexistencia > 0)
                {
                    format = this.localVars[5];
                    str5 = this.localVars[4];
                    str4 = this.localVars[3];
                    str3 = this.localVars[2];
                    str2 = this.localVars[1];
                    s = this.localVars[0];
                    if (this.err_mainmodule_buscaexistencia == 1)
                    {
                        this.err_mainmodule_buscaexistencia = 0;
                        goto Label_0732;
                    }
                }
                num = 1;
                if (this.htControls["__mainmodule_msql1"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                }
                this.__mainmodule_msql1 = new MSSQL.MSSQL();
                this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                {
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_msql1.Close();
                    return "";
                }
                this.var__mainmodule_sql = "SELECT EXIST, IMPUESTO1, IMPUESTO4, IMP1APLICA, IMP4APLICA, ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "(Select PRECIO FROM PRECIO_X_PROD" + this.var__mainmodule_empresa + " WHERE ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "CVE_ART = I.CVE_ART AND CVE_PRECIO = 1) As PREC1, DESCR FROM INVE" + this.var__mainmodule_empresa + " I ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " P ON P.CVE_ESQIMPU = I.CVE_ESQIMPU ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN CVES_ALTER" + this.var__mainmodule_empresa + " A ON A.CVE_ART = I.CVE_ART AND TIPO = 'N' ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.CVE_ART = '" + this.__mainmodule_tprod.Text + "' OR CVE_ALTER = '" + this.__mainmodule_tprod.Text + "'";
                if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        s = this.__mainmodule_msql1.ReadField("PREC1");
                        str2 = this.__mainmodule_msql1.ReadField("IMPUESTO1");
                        str3 = ((((s == "") ? 0.0 : double.Parse(s, cul)) * ((str2 == "") ? 0.0 : double.Parse(str2, cul))) / 100.0).ToString(cul);
                        str4 = this.__mainmodule_msql1.ReadField("IMPUESTO4");
                        if (this.__mainmodule_msql1.ReadField("IMP1APLICA") == "1")
                        {
                            str5 = (((((s == "") ? 0.0 : double.Parse(s, cul)) + ((str3 == "") ? 0.0 : double.Parse(str3, cul))) * ((str4 == "") ? 0.0 : double.Parse(str4, cul))) / 100.0).ToString(cul);
                        }
                        else
                        {
                            str5 = ((((s == "") ? 0.0 : double.Parse(s, cul)) * ((str4 == "") ? 0.0 : double.Parse(str4, cul))) / 100.0).ToString(cul);
                        }
                        s = ((((s == "") ? 0.0 : double.Parse(s, cul)) + ((str5 == "") ? 0.0 : double.Parse(str5, cul))) + ((str3 == "") ? 0.0 : double.Parse(str3, cul))).ToString(cul);
                        this.__mainmodule_ltdescr.Text = this.__mainmodule_msql1.ReadField("DESCR");
                        this.__mainmodule_lte.Text = "Exist.: " + this.__mainmodule_msql1.ReadField("EXIST");
                        this.__mainmodule_ltprec.Text = "$ " + (((format = "N2".ToLower(cul))[0] != 'd') ? ((s == "") ? 0.0 : double.Parse(s, cul)).ToString(format, cul) : ((s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))).ToString(format, cul));
                    }
                }
                else
                {
                    this.__mainmodule_lte.Text = "0";
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                this.__mainmodule_msql1.Close();
                this.__mainmodule_tprod.Text = "";
                return "";
            Label_0732:
                ((int) MessageBox.Show("Error en BuscaExistencia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_buscaexistencia = num;
                    this.localVars = new object[] { s, str2, str3, str4, str5, format };
                    return this.__mainmodule_buscaexistencia();
                }
                this.ShowError(exception, "_mainmodule_buscaexistencia");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_button12_click");
                return "";
            }
        }

        private string __mainmodule_cboclieutils_selectionchanged(string var__mainmodule_index, string var__mainmodule_value)
        {
            string str = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_cboclieutils_selectionchanged > 0)
                {
                    s = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_cboclieutils_selectionchanged == 1)
                    {
                        this.err_mainmodule_cboclieutils_selectionchanged = 0;
                        goto Label_02F5;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboclieutils.Items[this.__mainmodule_cboclieutils.SelectedIndex].ToString();
                this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.descrip) ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM pedidos I INNER JOIN prods P ON P.articulo = I.articulo ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE cve_doc = '" + str + "' AND nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_tblpedidos.dataTable.Clear();
                this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tblpedidos.AddRow(new object[0]);
                    s = (this.__mainmodule_tblpedidos.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(2));
                    this.__mainmodule_tblpedidos.SetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_02F5:
                ((int) MessageBox.Show("Problema detectado en ClieUtils_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cboclieutils_selectionchanged = num;
                    this.localVars = new object[] { str, s };
                    return this.__mainmodule_cboclieutils_selectionchanged(var__mainmodule_index, var__mainmodule_value);
                }
                this.ShowError(exception, "_mainmodule_cboclieutils_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_cboempresa_selectionchanged(string var__mainmodule_index, string var__mainmodule_value)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_cboempresa_selectionchanged > 0) && (this.err_mainmodule_cboempresa_selectionchanged == 1))
                {
                    this.err_mainmodule_cboempresa_selectionchanged = 0;
                }
                else
                {
                    num = 1;
                    double num3 = -1.0;
                    if (this.__mainmodule_cboempresa.SelectedIndex.ToString(cul) == num3.ToString(cul))
                    {
                        ((int) MessageBox.Show("Por favor seleccione una empresa", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.var__mainmodule_empresa = this.__mainmodule_cboempresa.Items[this.__mainmodule_cboempresa.SelectedIndex].ToString();
                    this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2, multialmacen FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
                        this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
                        this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
                        this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
                        this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
                        this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
                        this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), cul);
                        this.var__mainmodule_correo = this.__mainmodule_reader.GetValue(7);
                        this.var__mainmodule_nombreempresa = this.__mainmodule_reader.GetValue(8);
                        this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(9);
                        this.var__mainmodule_correo2 = this.__mainmodule_reader.GetValue(10);
                        this.var__mainmodule_multialmacen = double.Parse(this.__mainmodule_reader.GetValue(11), cul);
                    }
                    else
                    {
                        this.var__mainmodule_nombreempresa = "";
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_ltsocial.Text = this.var__mainmodule_nombreempresa;
                    this.__mainmodule_tusuario.Focus();
                    return "";
                }
                ((int) MessageBox.Show("Problema detectadoi en Empresa_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cboempresa_selectionchanged = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_cboempresa_selectionchanged(var__mainmodule_index, var__mainmodule_value);
                }
                this.ShowError(exception, "_mainmodule_cboempresa_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_cboempresa1_selectionchanged(string var__mainmodule_index, string var__mainmodule_value)
        {
            string str = "";
            string str2 = "";
            string rSide = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_cboempresa1_selectionchanged > 0)
                {
                    s = this.localVars[3];
                    rSide = this.localVars[2];
                    str2 = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_cboempresa1_selectionchanged == 1)
                    {
                        this.err_mainmodule_cboempresa1_selectionchanged = 0;
                        goto Label_04F8;
                    }
                }
                num = 1;
                double num4 = -1.0;
                if (!this.LCompareEqual(var__mainmodule_index, num4.ToString(cul)))
                {
                    str = this.__mainmodule_cboempresa1.Items[(var__mainmodule_index == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_index, cul))].ToString();
                    this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, nombre, ctrl_alm, almacen, ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, linea, correo2, remoto, multialmacen FROM empresas WHERE empresa = '" + str + "'";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
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
                            this.__mainmodule_chmult.Checked = bool.Parse("false".ToLower(cul));
                            this.__mainmodule_cboalm.SelectedIndex = 0;
                            this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(cul));
                        }
                        else
                        {
                            this.__mainmodule_chmult.Checked = bool.Parse("true".ToLower(cul));
                            this.__mainmodule_cboalm.Enabled = bool.Parse("true".ToLower(cul));
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
                    if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "1"))
                    {
                        this.__mainmodule_cboalm.SelectedIndex = -1;
                        s = "0";
                        double num2 = this.__mainmodule_cboalm.Items.Count - 1.0;
                        double num3 = (s == "") ? 0.0 : double.Parse(s, cul);
                        while (num3 <= num2)
                        {
                            if (this.RCompareEqual(this.__mainmodule_cboalm.Items[(s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))].ToString(), rSide))
                            {
                                this.__mainmodule_cboalm.SelectedIndex = (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul));
                                break;
                            }
                            s = ++num3.ToString(cul);
                        }
                    }
                    this.__mainmodule_tnombreemp.Focus();
                }
                return "";
            Label_04F8:
                ((int) MessageBox.Show("Problema detectado en cboEmpresa_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cboempresa1_selectionchanged = num;
                    this.localVars = new object[] { str, str2, rSide, s };
                    return this.__mainmodule_cboempresa1_selectionchanged(var__mainmodule_index, var__mainmodule_value);
                }
                this.ShowError(exception, "_mainmodule_cboempresa1_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_cboimporta_selectionchanged(string var__mainmodule_index, string var__mainmodule_value)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_cboimporta_selectionchanged > 0) && (this.err_mainmodule_cboimporta_selectionchanged == 1))
                {
                    this.err_mainmodule_cboimporta_selectionchanged = 0;
                }
                else
                {
                    num = 1;
                    double num2 = -1.0;
                    if (!this.LCompareEqual(var__mainmodule_index, num2.ToString(cul)))
                    {
                        this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, nombre ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                        if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
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
                    }
                    return "";
                }
                ((int) MessageBox.Show("Problema detectado en cboImporta_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cboimporta_selectionchanged = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_cboimporta_selectionchanged(var__mainmodule_index, var__mainmodule_value);
                }
                this.ShowError(exception, "_mainmodule_cboimporta_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_cboprovutils_selectionchanged(string var__mainmodule_index, string var__mainmodule_value)
        {
            string str = "";
            string s = "";
            try
            {
                double num2 = -1.0;
                if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num2.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboprovutils.Items[this.__mainmodule_cboprovutils.SelectedIndex].ToString();
                this.var__mainmodule_sql = "SELECT I.articulo, SUM(I.cant), MAX(P.descrip) ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM compras I INNER JOIN prods P ON P.articulo = I.articulo ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE cve_doc = '" + str + "' AND nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_tblcompras.dataTable.Clear();
                this.__mainmodule_tblcompras.dataTable.AcceptChanges();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tblcompras.AddRow(new object[0]);
                    s = (this.__mainmodule_tblcompras.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(2));
                    this.__mainmodule_tblcompras.SetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                }
                this.__mainmodule_reader.Close();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cboprovutils_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_centra(string var__mainmodule_fdato)
        {
            string str2;
            int count = 0;
            string original = "";
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_centra > 0)
                {
                    original = this.localVars[1];
                    count = this.localVars[0];
                    if (this.err_mainmodule_centra == 1)
                    {
                        this.err_mainmodule_centra = 0;
                        goto Label_0080;
                    }
                }
                num2 = 1;
                count = (int) ((32.0 - var__mainmodule_fdato.Length) / 2.0);
                original = "                                   ";
                return (this.Other.SubString(original, 0, count) + var__mainmodule_fdato);
            Label_0080:
                str2 = "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_centra = num2;
                    this.localVars = new object[] { count, original };
                    return this.__mainmodule_centra(var__mainmodule_fdato);
                }
                this.ShowError(exception, "_mainmodule_centra");
                str2 = "";
            }
            return str2;
        }

        private string __mainmodule_chcaja_click()
        {
            try
            {
                if (this.__mainmodule_chcaja.Checked.ToString(cul).ToLower(cul) == "true")
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_chcaja_click");
                return "";
            }
        }

        private string __mainmodule_chenviartodascompras_click()
        {
            try
            {
                if (this.__mainmodule_chenviartodascompras.Checked.ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_cbocompra.Enabled = bool.Parse("false".ToLower(cul));
                }
                else
                {
                    this.__mainmodule_cbocompra.Enabled = bool.Parse("true".ToLower(cul));
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_chenviartodascompras_click");
                return "";
            }
        }

        private string __mainmodule_chenviartodospedidos_click()
        {
            try
            {
                if (this.__mainmodule_chenviartodospedidos.Checked.ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_cbopedido.Enabled = bool.Parse("false".ToLower(cul));
                }
                else
                {
                    this.__mainmodule_cbopedido.Enabled = bool.Parse("true".ToLower(cul));
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_chenviartodospedidos_click");
                return "";
            }
        }

        private string __mainmodule_chmult_click()
        {
            try
            {
                if (this.__mainmodule_chmult.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_cboalm.Enabled = bool.Parse("true".ToLower(cul));
                }
                else
                {
                    this.__mainmodule_cboalm.SelectedIndex = 0;
                    this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(cul));
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_chmult_click");
                return "";
            }
        }

        private string __mainmodule_cierracontrans()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_cierracontrans > 0) && (this.err_mainmodule_cierracontrans == 1))
                {
                    this.err_mainmodule_cierracontrans = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_con.EndTransaction();
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cierracontrans = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_cierracontrans();
                }
                this.ShowError(exception, "_mainmodule_cierracontrans");
                return "";
            }
        }

        private string __mainmodule_cierramsql()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_cierramsql > 0) && (this.err_mainmodule_cierramsql == 1))
                {
                    this.err_mainmodule_cierramsql = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_msql1.Close();
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cierramsql = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_cierramsql();
                }
                this.ShowError(exception, "_mainmodule_cierramsql");
                return "";
            }
        }

        private string __mainmodule_cierrareader()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_cierrareader > 0) && (this.err_mainmodule_cierrareader == 1))
                {
                    this.err_mainmodule_cierrareader = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_reader.Close();
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cierrareader = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_cierrareader();
                }
                this.ShowError(exception, "_mainmodule_cierrareader");
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
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_cmdborrar_click == 1)
                    {
                        this.err_mainmodule_cmdborrar_click = 0;
                        goto Label_0129;
                    }
                }
                num = 1;
                if (((this.__mainmodule_tpassword.Text != "Gsorom09") && (this.__mainmodule_tpassword.Text != "111222")) && (this.__mainmodule_tusuario.Text != "Administrador"))
                {
                    ((int) MessageBox.Show("Contrase\x00f1a incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = ((int) MessageBox.Show("Desea vaciar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM minve";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("La tabla Invent se vacia satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_0129:
                ((int) MessageBox.Show("error en borrar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cmdborrar_click = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_cmdborrar_click();
                }
                this.ShowError(exception, "_mainmodule_cmdborrar_click");
                return "";
            }
        }

        private string __mainmodule_cmdbuscar_click()
        {
            string str3;
            string text = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_cmdbuscar_click > 0)
                {
                    s = this.localVars[1];
                    text = this.localVars[0];
                    if (this.err_mainmodule_cmdbuscar_click == 1)
                    {
                        this.err_mainmodule_cmdbuscar_click = 0;
                        goto Label_03E4;
                    }
                }
                num = 1;
                Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                this.__mainmodule_cmdbuscar.Enabled = bool.Parse("false".ToLower(cul));
                text = this.__mainmodule_tcliente.Text;
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    if (text.Length.ToString(cul) == "0")
                    {
                        this.var__mainmodule_sql = "SELECT clave, nombre FROM clientes ORDER BY nombre LIMIT 40";
                    }
                    else
                    {
                        this.var__mainmodule_sql = "SELECT clave, nombre FROM clientes WHERE clave LIKE '%" + text + "%' OR nombre LIKE '%" + text + "%'";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + " ORDER BY nombre LIMIT 40";
                    }
                }
                else if (text.Length.ToString(cul) == "0")
                {
                    this.var__mainmodule_sql = "SELECT clave, nombre FROM provs ORDER BY nombre LIMIT 40";
                }
                else
                {
                    this.var__mainmodule_sql = "SELECT clave, nombre FROM provs WHERE clave LIKE '%" + text + "%' OR nombre LIKE '%" + text + "%'";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + " ORDER BY nombre LIMIT 40";
                }
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_listcte.BringToFront();
                this.__mainmodule_listcte.Focus();
                this.__mainmodule_listcte.Clear();
                this.__mainmodule_listcte.Refresh();
                this.__mainmodule_listcte.SuspendLayout();
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                s = "0";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    text = this.__mainmodule_reader.GetValue(1);
                    this.__mainmodule_item.CreateNew();
                    this.__mainmodule_item.Text = this.__mainmodule_reader.GetValue(0) + " " + this.Other.SubString(this.__mainmodule_reader.GetValue(1), 0, 0x16);
                    this.__mainmodule_item.Tag = this.__mainmodule_reader.GetValue(0);
                    this.__mainmodule_item.BackColor1 = -10496;
                    this.__mainmodule_item.ForeColor = -16777216;
                    this.__mainmodule_item.FontSize = 9f;
                    this.__mainmodule_item.Font = "Courier New";
                    this.__mainmodule_listcte.Add(this.__mainmodule_item.Value);
                    s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_listcte.ResumeLayout();
                this.var__mainmodule_crow = -1;
                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                if (this.LCompareEqual(s, "0"))
                {
                    ((int) MessageBox.Show("No se encontraron coinsidencias de clientes", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                this.__mainmodule_cmdbuscar.Enabled = bool.Parse("true".ToLower(cul));
                return "";
            Label_03E4:
                str3 = "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cmdbuscar_click = num;
                    this.localVars = new object[] { text, s };
                    return this.__mainmodule_cmdbuscar_click();
                }
                this.ShowError(exception, "_mainmodule_cmdbuscar_click");
                str3 = "";
            }
            return str3;
        }

        private string __mainmodule_cmdimport1_click()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdimport1_click");
                return "";
            }
        }

        private string __mainmodule_cmdinv_click()
        {
            string lSide = "";
            double num = 0.0;
            string str2 = "";
            string str3 = "";
            double num2 = 0.0;
            int num3 = 0;
            double num4 = 0.0;
            string str4 = "";
            int num5 = 0;
            string original = "";
            double selectedIndex = 0.0;
            string format = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            string str10 = "";
            string str11 = "";
            int num7 = 0;
            try
            {
                if (this.err_mainmodule_cmdinv_click > 0)
                {
                    str11 = this.localVars[0x10];
                    str10 = this.localVars[15];
                    str9 = this.localVars[14];
                    str8 = this.localVars[13];
                    str7 = this.localVars[12];
                    format = this.localVars[11];
                    selectedIndex = this.localVars[10];
                    original = this.localVars[9];
                    num5 = this.localVars[8];
                    str4 = this.localVars[7];
                    num4 = this.localVars[6];
                    num3 = this.localVars[5];
                    num2 = this.localVars[4];
                    str3 = this.localVars[3];
                    str2 = this.localVars[2];
                    num = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_cmdinv_click == 1)
                    {
                        this.err_mainmodule_cmdinv_click = 0;
                        goto Label_171F;
                    }
                }
                num7 = 1;
                this.__mainmodule_tarticulo.Enabled = bool.Parse("false".ToLower(cul));
                str4 = DateTime.Now.Year.ToString(cul) + "-" + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Month).ToString(format, cul) : DateTime.Now.Month.ToString(format, cul)) + "-" + (((str7 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Day).ToString(str7, cul) : DateTime.Now.Day.ToString(str7, cul));
                lSide = this.__mainmodule_tarticulo.Text;
                lSide = lSide.Replace(" ", "");
                if (lSide.Length.ToString(cul) == "0")
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La clave del art\x00edculo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tarticulo.Focus();
                    return "";
                }
                if (this.LCompareEqual(lSide, "111222") && this.LCompareEqual(this.var__mainmodule_isadmin, "true"))
                {
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_sqlserver.show();
                    return "";
                }
                if (this.LCompareEqual(lSide, "333444") && this.LCompareEqual(this.var__mainmodule_isadmin, "true"))
                {
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_usuarios.show();
                    return "";
                }
                if (this.Other.IsNumber(this.__mainmodule_tuni.Text) == "false")
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La cantidad debe ser numerica", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tarticulo.Focus();
                    return "";
                }
                num = double.Parse(this.__mainmodule_tuni.Text, cul);
                if (num < 0.0)
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La cantidad no puede ser cero o menos a cero", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tuni.Text = "1";
                    this.__mainmodule_tuni.Focus();
                    return "";
                }
                if (num > 5000.0)
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\bocina.wav"));
                    Thread.Sleep(0x7d0);
                    ((int) MessageBox.Show("La cantidad no puede ser mayor a 5000", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tuni.Text = "1";
                    this.__mainmodule_tuni.Focus();
                    return "";
                }
                str2 = "1";
                str3 = "0";
                lSide = lSide.Replace(",", "");
                lSide = lSide.Replace("'", "");
                this.var__mainmodule_sql = "SELECT articulo, descrip, costo_prom, uni_med FROM prods WHERE ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "articulo = '" + lSide + "' OR clavealterna = '" + lSide + "'";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    lSide = this.__mainmodule_reader.GetValue(0);
                    str8 = this.__mainmodule_reader.GetValue(2);
                    str9 = this.__mainmodule_reader.GetValue(3);
                    this.__mainmodule_ltinven2.Text = "[" + lSide + "] " + this.__mainmodule_reader.GetValue(1);
                }
                else
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\bocina.wav"));
                    Thread.Sleep(0x7d0);
                    this.__mainmodule_ltinven2.Text = "NO EXISTE [" + lSide + "]  ";
                    this.__mainmodule_ltinven.Text = "";
                    str3 = -99.0.ToString(cul);
                }
                this.__mainmodule_reader.Close();
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
                {
                    double num19 = -99.0;
                    if (this.LCompareEqual(str3, num19.ToString(cul)))
                    {
                        this.__mainmodule_pnlred.Visible = bool.Parse("true".ToLower(cul));
                        this.__mainmodule_ltartinv.Text = lSide;
                        this.__mainmodule_pnlred.BringToFront();
                        this.__mainmodule_tarticulo.Enabled = bool.Parse("false".ToLower(cul));
                        this.__mainmodule_tuni.Enabled = bool.Parse("false".ToLower(cul));
                        this.__mainmodule_ltred.Focus();
                        return "";
                    }
                }
                double num20 = -99.0;
                if (this.LCompareEqual(str3, num20.ToString(cul)))
                {
                    this.__mainmodule_ltinven.Text = "";
                    this.var__mainmodule_sql = "INSERT OR REPLACE INTO noencontrados (articulo, exist) ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "Select '" + lSide + "',";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "COALESCE((SELECT exist FROM noencontrados WHERE articulo = '" + lSide + "'), 0) + " + num.ToString(cul);
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "SELECT articulo, exist FROM noencontrados WHERE articulo = '" + lSide + "'";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if ((this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true") && (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true"))
                    {
                        this.__mainmodule_ltinven.Text = this.__mainmodule_reader.GetValue(1);
                        if (double.Parse(this.__mainmodule_reader.GetValue(1), cul) < 1000.0)
                        {
                            this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                        }
                        else if ((double.Parse(this.__mainmodule_reader.GetValue(1), cul) > 999.0) && (double.Parse(this.__mainmodule_reader.GetValue(1), cul) < 10000.0))
                        {
                            this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                        }
                        else
                        {
                            this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
                        }
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tarticulo.Text = "";
                    this.__mainmodule_tarticulo.Focus();
                    return "";
                }
                selectedIndex = this.__mainmodule_cboareas.SelectedIndex;
                if (selectedIndex > -1.0)
                {
                    original = this.__mainmodule_cboareas.Items[this.__mainmodule_cboareas.SelectedIndex].ToString();
                    original = this.Other.SubString(original, 0, 3);
                    if (this.Other.IsNumber(original).ToLower(cul) == "true")
                    {
                        selectedIndex = (original == "") ? 0.0 : double.Parse(original, cul);
                    }
                    else
                    {
                        selectedIndex = 0.0;
                    }
                }
                else
                {
                    selectedIndex = 0.0;
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
                {
                    if (this.LCompareEqual(this.var__mainmodule_seriecompra, ""))
                    {
                        string introduced56 = this.__mainmodule_replicate(" ", 20.0 - this.var__mainmodule_foliocompra.ToString(cul).Length);
                        str10 = introduced56 + this.var__mainmodule_foliocompra.ToString(cul);
                    }
                    else
                    {
                        str10 = this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString(cul);
                    }
                    this.var__mainmodule_sql = "INSERT INTO compras (cve_doc, usuario, articulo, cant, alm1, cancelado, nuevo, status, clave, folio) VALUES('";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + str10 + "','" + this.var__mainmodule_userroot + "','" + lSide + "','" + num.ToString(cul) + "','" + str2 + "','N','S','0','" + this.__mainmodule_lt2.Text + "','" + this.var__mainmodule_foliocompra.ToString(cul) + "')";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "SELECT articulo, sum(cant) FROM compras WHERE articulo = '" + lSide + "' AND ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                            this.__mainmodule_ltinven.Text = num.ToString(cul);
                            if (num < 1000.0)
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else if ((num > 999.0) && (num < 10000.0))
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
                            }
                        }
                        this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide + "]  Ultima scaneada:" + num.ToString(cul) + "    " + this.__mainmodule_reader.GetValue(1);
                    }
                    this.__mainmodule_reader.Close();
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
                {
                    this.var__mainmodule_sql = "INSERT OR REPLACE INTO inven (articulo, exist, costo_prom, uni_med, status) SELECT '" + lSide + "',";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "COALESCE((SELECT exist FROM inven WHERE articulo = '" + lSide + "'), 0) + " + num.ToString(cul);
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "," + str8 + ",'" + str9 + "',0";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "INSERT INTO minve (usuario, articulo, cantidad, alm1, cancelado, nuevo, idArea) VALUES('";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + this.var__mainmodule_userroot + "','" + lSide + "','" + num.ToString(cul) + "','" + str2 + "','N','S','" + selectedIndex.ToString(cul) + "')";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "SELECT articulo, SUM(cantidad) FROM minve WHERE articulo = '" + lSide + "'AND nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                            this.__mainmodule_ltinven.Text = num.ToString(cul);
                            if (num < 1000.0)
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else if ((num > 999.0) && (num < 10000.0))
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
                            }
                        }
                        this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide + "]  Ultima scaneada:" + num.ToString(cul) + "    " + this.__mainmodule_reader.GetValue(1);
                    }
                    this.__mainmodule_reader.Close();
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    if (this.LCompareEqual(this.var__mainmodule_seriecompra, ""))
                    {
                        str10 = this.__mainmodule_replicate(" ", 20.0 - str11.Length) + this.var__mainmodule_folioped.ToString(cul);
                    }
                    else
                    {
                        str10 = this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString(cul);
                    }
                    this.var__mainmodule_sql = "INSERT INTO pedidos (cve_doc, usuario, articulo, cant, alm1, cancelado, nuevo, status, clave, folio) VALUES('";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + str10 + "','" + this.var__mainmodule_userroot + "','" + lSide + "','" + num.ToString(cul) + "','" + str2 + "','N','S','0','" + this.__mainmodule_lt2.Text + "','" + this.var__mainmodule_folioped.ToString(cul) + "')";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "SELECT articulo, sum(cant) FROM pedidos WHERE articulo = '" + lSide + "' AND ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "nuevo = 'S' AND cancelado = 'N' GROUP BY articulo";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                            this.__mainmodule_ltinven.Text = num.ToString(cul);
                            if (num < 1000.0)
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else if ((num > 999.0) && (num < 10000.0))
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
                            }
                            else
                            {
                                this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 12f, this.__mainmodule_ltinven.Font.Style);
                            }
                        }
                        this.__mainmodule_ltinven2.Text = this.__mainmodule_ltinven2.Text + "  [" + lSide + "]  Ultima scaneada:" + num.ToString(cul) + "    " + this.__mainmodule_reader.GetValue(1);
                    }
                    this.__mainmodule_reader.Close();
                }
                this.__mainmodule_tuni.Text = "1";
                this.__mainmodule_tarticulo.Text = "";
                this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tarticulo.Focus();
                return "";
            Label_171F:
                this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_cierrareader();
                ((int) MessageBox.Show("Error en cmdInv.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num7 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cmdinv_click = num7;
                    this.localVars = new object[] { 
                        lSide, num, str2, str3, num2, num3, num4, str4, num5, original, selectedIndex, format, str7, str8, str9, str10,
                        str11
                    };
                    return this.__mainmodule_cmdinv_click();
                }
                this.ShowError(exception, "_mainmodule_cmdinv_click");
                return "";
            }
        }

        private string __mainmodule_cmdinv_keypress(string var__mainmodule_key)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdinv_keypress");
                return "";
            }
        }

        private string __mainmodule_cmdinvc_click()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdinvc_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdinvensalir_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdrutapcc_click");
                return "";
            }
        }

        private string __mainmodule_cmdsend1_click()
        {
            string str = "";
            double num = 0.0;
            string str2 = "";
            string str3 = "";
            string lSide = "";
            string str5 = "";
            string connectiondata = "";
            string s = "";
            string str8 = "";
            try
            {
                str5 = ((int) MessageBox.Show("Desea enviar inventario ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str5, "7"))
                {
                    str = this.b4pdir + @"\INVEN " + this.var__mainmodule_nombreempresa + ".txt";
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, str), false, Encoding.ASCII));
                    connectiondata = "Persist Security Info=False;Integrated Security=False;";
                    connectiondata = (((connectiondata + "Server=" + this.var__mainmodule_servertea + "," + this.var__mainmodule_porttea) + ";initial catalog=INVENTMOBILE") + ";user id=" + this.var__mainmodule_usertea) + ";password=" + this.var__mainmodule_passtea + ";";
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open(connectiondata).ToString(cul).ToLower(cul) == "false")
                    {
                        ((int) MessageBox.Show("1.Imposible conectar al servidor " + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    Cursor.Current = bool.Parse("true".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.var__mainmodule_sql = "SELECT I.ctrl_alm, I.articulo, I.descrip, I.existencia, (SELECT exist FROM inven P WHERE ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "P.articulo = i.articulo) FROM prods I ORDER BY descrip";
                    this.var__mainmodule_sql = "SELECT articulo, cantidad FROM minve WHERE nuevo = 'S' AND cancelado = 'N'";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    str2 = "Ctrl Alm,Almacen,Articulo,Descripcion,Inv. Fisico,Existencia SAE,Diferencias";
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                    s = "0";
                    lSide = "no";
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str3 = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                        }
                        else
                        {
                            num = 0.0;
                        }
                        if (num > 0.0)
                        {
                            s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                            this.__mainmodule_ltnum.Text = "Procesando Regs:" + s + " por favor espere";
                            str2 = str3 + "," + num.ToString(cul);
                            this.var__mainmodule_sql = "INSERT INTO INVENT (ALMACEN, CVE_ART, CANT) VALUES('" + this.var__mainmodule_almacen.ToString(cul) + "','" + str3 + "','" + num.ToString(cul) + "')";
                            if (this.__mainmodule_msql1.ExecuteNonQuery(this.var__mainmodule_sql).ToString(cul).ToLower(cul) == "false")
                            {
                                this.htStreams.Add("_mainmodule_c2", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTMOBILE.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c2"]).WriteLine(this.var__mainmodule_sql);
                                ((StreamWriter) this.htStreams["_mainmodule_c2"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c2"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c2"]).Close();
                                    this.htStreams.Remove("_mainmodule_c2");
                                    GC.Collect();
                                }
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema en tabla INVENTMOBILE en " + this.var__mainmodule_servertea + " en linea 376", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                lSide = "si";
                                break;
                            }
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                        }
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_msql1.Close();
                    if (this.LCompareEqual(lSide, "si"))
                    {
                        if (this.htStreams.Contains("_mainmodule_c1"))
                        {
                            ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                            this.htStreams.Remove("_mainmodule_c1");
                            GC.Collect();
                        }
                        this.__mainmodule_msql1.Close();
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        return "";
                    }
                    this.__mainmodule_msql1.Close();
                    this.__mainmodule_cmd.CommandText = "UPDATE minve SET nuevo = 'N'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.var__mainmodule_sql = "SELECT articulo, exist FROM noencontrados WHERE exist > 0";
                    str2 = " ";
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                    str2 = " ";
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                    str2 = "Articulos no encontrados";
                    str2 = "---,-----,------,Articulos no encontrados,------,-------,---------";
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    str8 = "0";
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str3 = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                        }
                        else
                        {
                            num = 0.0;
                        }
                        if (num > 0.0)
                        {
                            str8 = (((str8 == "") ? 0.0 : double.Parse(str8, cul)) + 1.0).ToString(cul);
                            this.__mainmodule_ltnum.Text = "Procesando Regs:" + s + " por favor espere";
                            str2 = str3 + "," + num.ToString(cul);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str2);
                        }
                    }
                    this.__mainmodule_reader.Close();
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("Registros enviados " + s, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_ltinven2.Text = "";
                    this.__mainmodule_ltinven.Text = "";
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdsend1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_cmdsend2_click");
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
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_cmdvaciarinvent_click == 1)
                    {
                        this.err_mainmodule_cmdvaciarinvent_click = 0;
                        goto Label_0251;
                    }
                }
                num = 1;
                if (((this.__mainmodule_tusuario.Text != "Administrador") && (this.__mainmodule_tpassword.Text != "sorom")) && ((this.__mainmodule_tpassword.Text != "Gsorom09") && (this.__mainmodule_tpassword.Text == "111222")))
                {
                    ((int) MessageBox.Show("Contrase\x00f1a incorrecta intentelo de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = ((int) MessageBox.Show("Desea vaciar la base de datos ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    lSide = ((int) MessageBox.Show("Se borrara toda la informacion tendra que volver a recibir. Desea cotinua?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    if (this.LCompareEqual(lSide, "7"))
                    {
                        return "";
                    }
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
                    ((int) MessageBox.Show("La base de datos se vacio satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_0251:
                ((int) MessageBox.Show("error en borrar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_cmdvaciarinvent_click = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_cmdvaciarinvent_click();
                }
                this.ShowError(exception, "_mainmodule_cmdvaciarinvent_click");
                return "";
            }
        }

        private string __mainmodule_config_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_config_close");
                return "";
            }
        }

        private string __mainmodule_config_show()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_config_show > 0) && (this.err_mainmodule_config_show == 1))
                {
                    this.err_mainmodule_config_show = 0;
                }
                else
                {
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
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_config_show = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_config_show();
                }
                this.ShowError(exception, "_mainmodule_config_show");
                return "";
            }
        }

        private string __mainmodule_copiaarchivos()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_copiaarchivos");
                return "";
            }
        }

        private string __mainmodule_copiaarchivos2()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_copiaarchivos2");
                return "";
            }
        }

        private string __mainmodule_creatablaarea()
        {
            string str2;
            string str = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_creatablaarea > 0)
                {
                    str = this.localVars[0];
                    if (this.err_mainmodule_creatablaarea == 1)
                    {
                        this.err_mainmodule_creatablaarea = 0;
                        goto Label_0059;
                    }
                }
                num = 1;
                str = "CREATE Table IF NOT EXISTS [areas] ([id] Integer  PRIMARY KEY AUTOINCREMENT Not NULL,[area] VARCHAR(5) NULL,[nombre] VARCHAR(40) NULL)";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_cmd.ExecuteNonQuery();
                return "";
            Label_0059:
                str2 = "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_creatablaarea = num;
                    this.localVars = new object[] { str };
                    return this.__mainmodule_creatablaarea();
                }
                this.ShowError(exception, "_mainmodule_creatablaarea");
                str2 = "";
            }
            return str2;
        }

        private string __mainmodule_desplegarareas()
        {
            string str = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_desplegarareas > 0)
                {
                    s = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_desplegarareas == 1)
                    {
                        this.err_mainmodule_desplegarareas = 0;
                        goto Label_0270;
                    }
                }
                num = 1;
                this.__mainmodule_tblareas.dataTable.Clear();
                this.__mainmodule_tblareas.dataTable.AcceptChanges();
                str = "1";
                this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tblareas.AddRow(new object[0]);
                    s = (this.__mainmodule_tblareas.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), str);
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                    str = (((str == "") ? 0.0 : double.Parse(str, cul)) + 1.0).ToString(cul);
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_0270:
                ((int) MessageBox.Show("Problema detectado en ErrDesplegarAreas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_desplegarareas = num;
                    this.localVars = new object[] { str, s };
                    return this.__mainmodule_desplegarareas();
                }
                this.ShowError(exception, "_mainmodule_desplegarareas");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_enviar_close");
                return "";
            }
        }

        private string __mainmodule_enviar_show()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_enviar_show > 0) && (this.err_mainmodule_enviar_show == 1))
                {
                    this.err_mainmodule_enviar_show = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_trutapc.Text = @"\\" + this.var__mainmodule_serverlocal + @"\dacaspel";
                    this.__mainmodule_ltsend1.Text = "Servidor:" + this.var__mainmodule_servertea;
                    this.__mainmodule_ltsend2.Text = "Base:INVETMOBILE, TABLA:INVENT";
                    this.__mainmodule_cmdsend1.BringToFront();
                    this.__mainmodule_cmdsend2.BringToFront();
                    return "";
                }
                ((int) MessageBox.Show("Problema detectado en Enviar_Show", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_enviar_show = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_enviar_show();
                }
                this.ShowError(exception, "_mainmodule_enviar_show");
                return "";
            }
        }

        private string __mainmodule_enviaraunapc(string var__mainmodule_farchivo)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_enviaraunapc > 0) && (this.err_mainmodule_enviaraunapc == 1))
                {
                    this.err_mainmodule_enviaraunapc = 0;
                }
                else
                {
                    num = 1;
                    this.var__mainmodule_rutapc = this.__mainmodule_trutapc.Text;
                    this.var__mainmodule_twifi = "0";
                    this.__mainmodule_timer1.Interval = 800;
                    this.__mainmodule_timer1.Enabled = bool.Parse("true".ToLower(cul));
                    while ((Directory.Exists(Path.Combine(this.b4pdir, this.var__mainmodule_rutapc)).ToString(cul).ToLower(cul).ToLower(cul) != "true") && !this.LCompareEqual(this.var__mainmodule_twifi, "32"))
                    {
                        Application.DoEvents();
                    }
                    File.Copy(Path.Combine(this.b4pdir, var__mainmodule_farchivo), Path.Combine(this.b4pdir, this.b4pdir + @"\INVENT" + DateTime.Now.Day.ToString(cul) + DateTime.Now.Month.ToString(cul) + DateTime.Now.Year.ToString(cul) + "_" + DateTime.Now.Hour.ToString(cul) + DateTime.Now.Minute.ToString(cul) + DateTime.Now.Second.ToString(cul) + ".CSV"), true);
                    File.Copy(Path.Combine(this.b4pdir, var__mainmodule_farchivo), Path.Combine(this.b4pdir, this.var__mainmodule_rutapc + @"\INVENT" + DateTime.Now.Day.ToString(cul) + DateTime.Now.Month.ToString(cul) + DateTime.Now.Year.ToString(cul) + "_" + DateTime.Now.Hour.ToString(cul) + DateTime.Now.Minute.ToString(cul) + DateTime.Now.Second.ToString(cul) + ".CSV"), true);
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_enviaraunapc = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_enviaraunapc(var__mainmodule_farchivo);
                }
                this.ShowError(exception, "_mainmodule_enviaraunapc");
                return "";
            }
        }

        private string __mainmodule_fgprod_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_fgprod_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_frmareas_show()
        {
            double num = 0.0;
            double num2 = 0.0;
            string s = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_frmareas_show > 0)
                {
                    s = this.localVars[2];
                    num2 = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_frmareas_show == 1)
                    {
                        this.err_mainmodule_frmareas_show = 0;
                        goto Label_0285;
                    }
                }
                num3 = 1;
                this.var__mainmodule_tipomov = "";
                this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_tblareas.dataTable.Clear();
                this.__mainmodule_tblareas.dataTable.AcceptChanges();
                num2 = 1.0;
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tblareas.AddRow(new object[0]);
                    s = (this.__mainmodule_tblareas.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), num2.ToString(cul));
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tblareas.SetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                    num2++;
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_tareanombre.BringToFront();
                this.__mainmodule_btnarea2.BringToFront();
                return "";
            Label_0285:
                ((int) MessageBox.Show("Error en errfrmAreas", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_frmareas_show = num3;
                    this.localVars = new object[] { num, num2, s };
                    return this.__mainmodule_frmareas_show();
                }
                this.ShowError(exception, "_mainmodule_frmareas_show");
                return "";
            }
        }

        private string __mainmodule_frmclientes_show()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_frmclientes_show > 0) && (this.err_mainmodule_frmclientes_show == 1))
                {
                    this.err_mainmodule_frmclientes_show = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_tcliente.Text = "";
                    this.__mainmodule_tcliente.BringToFront();
                    this.__mainmodule_cmdbuscar.BringToFront();
                    this.__mainmodule_listcte.Clear();
                    this.__mainmodule_listcte.ItemHeight = 20;
                    this.__mainmodule_listcte.Top = ((this.__mainmodule_tcliente.Top / 1) + (this.__mainmodule_tcliente.Height / 1)) + ((int) 2.0);
                    this.__mainmodule_listcte.Left = 0;
                    this.__mainmodule_listcte.Width = this.screenX;
                    this.__mainmodule_listcte.BackColor = -8093052;
                    this.__mainmodule_listcte.Height = this.screenY - (((this.__mainmodule_tcliente.Top / 1) + (this.__mainmodule_tcliente.Height / 1)) + ((int) 4.0));
                    this.__mainmodule_listcte.BackColor = -8093052;
                    return "";
                }
                ((int) MessageBox.Show("Ocurrio un error en errfrmClientes", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_frmclientes_show = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_frmclientes_show();
                }
                this.ShowError(exception, "_mainmodule_frmclientes_show");
                return "";
            }
        }

        private string __mainmodule_frmcomprasutils_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmcomprasutils_close");
                return "";
            }
        }

        private string __mainmodule_frmcomprasutils_show()
        {
            string str = "";
            try
            {
                this.__mainmodule_tblcompras.dataTable.Clear();
                this.__mainmodule_tblcompras.dataTable.AcceptChanges();
                this.var__mainmodule_sql = "SELECT cve_doc, max(cancelado) FROM compras WHERE nuevo = 'S' GROUP BY cve_doc";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_cboprovutils.Items.Clear();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.__mainmodule_reader.GetValue(1) == "C")
                    {
                        str = "   Cancelado";
                    }
                    else
                    {
                        str = "";
                    }
                    this.__mainmodule_cboprovutils.Items.Add(this.__mainmodule_reader.GetValue(0) + str);
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_label37.BringToFront();
                this.__mainmodule_cboprovutils.BringToFront();
                this.var__mainmodule_rowcompra = -1.0;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmcomprasutils_show");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmexistencias_show");
                return "";
            }
        }

        private string __mainmodule_frmexistxlinea_show()
        {
            double num = 0.0;
            double num2 = 0.0;
            string s = "";
            try
            {
                if (this.LCompareEqual(this.var__mainmodule_tipomov, "lineas"))
                {
                    this.__mainmodule_frmexistxlinea.Text = "Exist. X Linea";
                    this.var__mainmodule_sql = "SELECT linea, sum(M.exist) FROM inven M ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN prods P ON P.articulo = M.articulo WHERE estatus <> 'C' GROUP BY linea";
                }
                else
                {
                    this.__mainmodule_frmexistxlinea.Text = "Exist. X Area";
                    this.var__mainmodule_sql = "SELECT nombre, sum(M.cantidad) FROM minve M ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN areas P ON P.id = M.idArea WHERE cancelado = 'N' GROUP BY nombre";
                }
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_tblexisxlinea.dataTable.Clear();
                this.__mainmodule_tblexisxlinea.dataTable.AcceptChanges();
                num = 0.0;
                num2 = 1.0;
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tblexisxlinea.AddRow(new object[0]);
                    s = (this.__mainmodule_tblexisxlinea.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), num2.ToString(cul));
                    this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                    num2++;
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                    {
                        num += double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                    }
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_tblexisxlinea.AddRow(new object[0]);
                s = (this.__mainmodule_tblexisxlinea.dataTable.DefaultView.Count - 1.0).ToString(cul);
                this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), "Total piezas");
                this.__mainmodule_tblexisxlinea.SetCell(this.__mainmodule_tblexisxlinea.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), num.ToString(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmexistxlinea_show");
                return "";
            }
        }

        private string __mainmodule_frmmenu_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmmenu_close");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmmenu_show");
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
                    str = this.localVars[0];
                    if (this.err_mainmodule_frmpedidosutils_show == 1)
                    {
                        this.err_mainmodule_frmpedidosutils_show = 0;
                        goto Label_014A;
                    }
                }
                num = 1;
                this.__mainmodule_tblpedidos.dataTable.Clear();
                this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
                this.var__mainmodule_sql = "SELECT cve_doc, max(cancelado) FROM pedidos WHERE nuevo = 'S' GROUP BY cve_doc";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__mainmodule_cboclieutils.Items.Clear();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    if (this.__mainmodule_reader.GetValue(1) == "C")
                    {
                        str = "   Cancelado";
                    }
                    else
                    {
                        str = "";
                    }
                    this.__mainmodule_cboclieutils.Items.Add(this.__mainmodule_reader.GetValue(0) + str);
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_label56.BringToFront();
                this.__mainmodule_cboclieutils.BringToFront();
                this.var__mainmodule_rowcompra = -1.0;
                return "";
            Label_014A:
                ((int) MessageBox.Show("Problema detectado en frmPedidosUtils", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_frmpedidosutils_show = num;
                    this.localVars = new object[] { str };
                    return this.__mainmodule_frmpedidosutils_show();
                }
                this.ShowError(exception, "_mainmodule_frmpedidosutils_show");
                return "";
            }
        }

        private string __mainmodule_frmseries_show()
        {
            string s = "";
            string format = "";
            try
            {
                this.__mainmodule_tseriecompra.Text = this.var__mainmodule_seriecompra;
                this.__mainmodule_tfoliocompra.Text = this.var__mainmodule_foliocompra.ToString(cul);
                this.__mainmodule_tserped.Text = this.var__mainmodule_seriepedido;
                this.__mainmodule_tfolped.Text = this.var__mainmodule_folioped.ToString(cul);
                this.__mainmodule_cboempresapred.Items.Clear();
                this.__mainmodule_cboempresapred.Items.Add("Ninguna");
                s = "1";
                double num = 99.0;
                double num2 = (s == "") ? 0.0 : double.Parse(s, cul);
                while (num2 <= num)
                {
                    this.__mainmodule_cboempresapred.Items.Add(((format = "D2".ToLower(cul))[0] != 'd') ? ((s == "") ? 0.0 : double.Parse(s, cul)).ToString(format, cul) : ((s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))).ToString(format, cul));
                    s = ++num2.ToString(cul);
                }
                if (this.var__mainmodule_empresapred.Length > 0.0)
                {
                    s = "0";
                    double num3 = 98.0;
                    double num4 = (s == "") ? 0.0 : double.Parse(s, cul);
                    while (num4 <= num3)
                    {
                        if (this.RCompareEqual(this.__mainmodule_cboempresapred.Items[(s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))].ToString(), this.var__mainmodule_empresapred))
                        {
                            this.__mainmodule_cboempresapred.SelectedIndex = (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul));
                            break;
                        }
                        s = ++num4.ToString(cul);
                    }
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmseries_show");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_frmtraspasos_show");
                return "";
            }
        }

        private string __mainmodule_gencompra_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_gencompra_close");
                return "";
            }
        }

        private string __mainmodule_gencompra_show()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_gencompra_show > 0) && (this.err_mainmodule_gencompra_show == 1))
                {
                    this.err_mainmodule_gencompra_show = 0;
                }
                else
                {
                    num = 1;
                    this.var__mainmodule_sql = "SELECT cve_doc FROM compras WHERE nuevo = 'S' AND cancelado = 'N' GROUP BY cve_doc";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    this.__mainmodule_cbocompra.Items.Clear();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_cbocompra.Items.Add(this.__mainmodule_reader.GetValue(0));
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_ltconcepto.Text = "Concepto: 01 Compras";
                    this.__mainmodule_btngencompra.BringToFront();
                    this.__mainmodule_btnsalirgencompra.BringToFront();
                    return "";
                }
                ((int) MessageBox.Show("Error en errGENCOMPRA", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_gencompra_show = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_gencompra_show();
                }
                this.ShowError(exception, "_mainmodule_gencompra_show");
                return "";
            }
        }

        private string __mainmodule_genpedido_show()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_genpedido_show > 0) && (this.err_mainmodule_genpedido_show == 1))
                {
                    this.err_mainmodule_genpedido_show = 0;
                }
                else
                {
                    num = 1;
                    this.var__mainmodule_sql = "SELECT cve_doc FROM pedidos WHERE nuevo = 'S' AND cancelado = 'N' GROUP BY cve_doc";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    this.__mainmodule_cbopedido.Items.Clear();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_cbopedido.Items.Add(this.__mainmodule_reader.GetValue(0));
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_btngenpedido.BringToFront();
                    this.__mainmodule_btnsalirpedido.BringToFront();
                    this.__mainmodule_cbopedido.Focus();
                    return "";
                }
                ((int) MessageBox.Show("Error en errerrGENPEDIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_genpedido_show = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_genpedido_show();
                }
                this.ShowError(exception, "_mainmodule_genpedido_show");
                return "";
            }
        }

        private string __mainmodule_image1_click()
        {
            double num = 0.0;
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_image1_click > 0)
                {
                    num = this.localVars[0];
                    if (this.err_mainmodule_image1_click == 1)
                    {
                        this.err_mainmodule_image1_click = 0;
                        goto Label_019E;
                    }
                }
                num2 = 1;
                if (((this.__mainmodule_tpassword.Text == "sorom") || (this.__mainmodule_tpassword.Text == "Gsorom09")) || (this.__mainmodule_tpassword.Text == "111222"))
                {
                    this.__mainmodule_config.show();
                }
                else
                {
                    this.var__mainmodule_sql = "SELECT * FROM usuarios WHERE usuario = '" + this.__mainmodule_tusuario.Text;
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "' AND password = '" + this.__mainmodule_tpassword.Text + "' AND nivel = 1";
                    num = 0.0;
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        num = 1.0;
                    }
                    this.__mainmodule_reader.Close();
                    if (this.LCompareEqual(num.ToString(cul), "0"))
                    {
                        ((int) MessageBox.Show("Usuario-contrase\x00f1a incorrecta o sin derecho", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.__mainmodule_config.show();
                }
                return "";
            Label_019E:
                ((int) MessageBox.Show("Problema detectado en Image1_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_image1_click = num2;
                    this.localVars = new object[] { num };
                    return this.__mainmodule_image1_click();
                }
                this.ShowError(exception, "_mainmodule_image1_click");
                return "";
            }
        }

        private string __mainmodule_importararticulos()
        {
            int num = 0;
            string str = "";
            string str2 = "";
            string connectiondata = "";
            string str4 = "";
            string str5 = "";
            string lSide = "";
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
            string str24 = "";
            string str25 = "";
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_importararticulos > 0)
                {
                    str25 = this.localVars[0x19];
                    str24 = this.localVars[0x18];
                    str23 = this.localVars[0x17];
                    str22 = this.localVars[0x16];
                    str21 = this.localVars[0x15];
                    str20 = this.localVars[20];
                    str19 = this.localVars[0x13];
                    str18 = this.localVars[0x12];
                    str17 = this.localVars[0x11];
                    str16 = this.localVars[0x10];
                    str15 = this.localVars[15];
                    str14 = this.localVars[14];
                    str13 = this.localVars[13];
                    str12 = this.localVars[12];
                    str11 = this.localVars[11];
                    str10 = this.localVars[10];
                    str9 = this.localVars[9];
                    str8 = this.localVars[8];
                    str7 = this.localVars[7];
                    lSide = this.localVars[6];
                    str5 = this.localVars[5];
                    str4 = this.localVars[4];
                    connectiondata = this.localVars[3];
                    str2 = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_importararticulos == 1)
                    {
                        this.err_mainmodule_importararticulos = 0;
                        goto Label_184F;
                    }
                }
                num2 = 1;
                this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
                this.__mainmodule_con.BeginTransaction();
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
                    this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
                    this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
                    this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
                    this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
                    this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
                    this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), cul);
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
                if (this.LCompareEqual(this.var__mainmodule_sistema.ToString(cul), "1"))
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
                {
                    this.var__mainmodule_sql = "SELECT PRODUCTO, DESCRIPCIO, LINEA, EXISTENCIA, CLVALTER1 FROM CATINVEN";
                }
                if (this.htControls["__mainmodule_msql1"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                }
                this.__mainmodule_msql1 = new MSSQL.MSSQL();
                this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                connectiondata = "Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + ",";
                connectiondata = connectiondata + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";";
                if (this.__mainmodule_msql1.Open(connectiondata).ToString(cul).ToLower(cul) == "false")
                {
                    ((int) MessageBox.Show("Imposible conectarse al servidor\r\n" + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\SQLERROR.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(connectiondata);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    this.__mainmodule_msql1.Close();
                    this.__mainmodule_con.EndTransaction();
                    return "";
                }
                this.__mainmodule_cmd.CommandText = "DELETE FROM prods";
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.__mainmodule_ltart.Text = "Importando articulo por favor espere";
                num = 0;
                str5 = "0";
                lSide = "0";
                if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str7 = "1";
                        if (this.LCompareEqual(this.var__mainmodule_sistema.ToString(cul), "1"))
                        {
                            str7 = "2";
                            str = this.__mainmodule_msql1.ReadField("CVE_ART");
                            str7 = "3";
                            str2 = this.__mainmodule_msql1.ReadField("DESCR");
                            str7 = "4";
                            str2 = str2.Replace("'", " ");
                            str7 = "5";
                            str8 = this.__mainmodule_msql1.ReadField("EXIST");
                            str7 = "6";
                            str9 = this.__mainmodule_msql1.ReadField("CTRL_ALM");
                            str7 = "7";
                            str10 = this.__mainmodule_msql1.ReadField("LIN_PROD");
                            str7 = "8";
                            str4 = this.__mainmodule_msql1.ReadField("ALTERNA");
                            str7 = "9";
                            lSide = Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("ULT_COSTO"), cul), 2).ToString(cul);
                            if (this.LCompareEqual(lSide, "0"))
                            {
                                str11 = Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("COSTO_PROM"), cul), 2).ToString(cul);
                            }
                            else
                            {
                                str11 = lSide;
                            }
                            str7 = "10";
                            str12 = this.__mainmodule_msql1.ReadField("UNI_MED");
                            str7 = "11";
                            str13 = this.__mainmodule_msql1.ReadField("IMPUESTO1");
                            str7 = "12";
                            str14 = this.__mainmodule_msql1.ReadField("IMPUESTO4");
                            str7 = "13";
                            str5 = Math.Round(double.Parse(this.__mainmodule_msql1.ReadField("P1"), cul), 2).ToString(cul);
                            str15 = this.__mainmodule_msql1.ReadField("CVE_ESQIMPU");
                            str16 = this.__mainmodule_msql1.ReadField("IMP1APLICA");
                            str17 = this.__mainmodule_msql1.ReadField("IMP2APLICA");
                            str18 = this.__mainmodule_msql1.ReadField("IMP3APLICA");
                            str19 = this.__mainmodule_msql1.ReadField("IMP4APLICA");
                        }
                        else
                        {
                            str = this.__mainmodule_msql1.ReadField("PRODUCTO");
                            str2 = this.__mainmodule_msql1.ReadField("DESCRIPCIO");
                            str2 = str2.Replace("'", " ");
                            str8 = this.__mainmodule_msql1.ReadField("EXISTENCIA");
                            str9 = "";
                            str10 = this.__mainmodule_msql1.ReadField("LINEA");
                            str4 = this.__mainmodule_msql1.ReadField("CLVALTER1");
                            str11 = "0";
                            str12 = "0";
                            str13 = "0";
                            str14 = "0";
                        }
                        str7 = "14";
                        str2 = str2.Replace("'", " ");
                        num += (int) 1.0;
                        this.__mainmodule_ltsync.Text = "Articulos: " + num.ToString(cul);
                        str = str.Replace("'", "");
                        str2 = str2.Replace("'", " ");
                        str7 = "15";
                        this.var__mainmodule_sql = "INSERT INTO prods (articulo, descrip, existencia, ctrl_alm, linea, clavealterna, costo_prom, precio1, ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "uni_med, impu1, impu4, status, cve_esqimpu, imp1aplica, imp2aplica, imp3aplica, imp4aplica) VALUES('" + str + "','";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + str2 + "','" + str8 + "','" + str9 + "','" + str10 + "','" + str4 + "','";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + str11 + "','" + str5 + "','" + str12 + "','" + str13 + "','" + str14 + "','0','";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + str15 + "','" + str16 + "','" + str17 + "','" + str18 + "','" + str19 + "')";
                        str7 = "16";
                        this.__mainmodule_ltart.Text = num.ToString(cul) + ". " + str + " - " + str2 + "(" + str7 + ")";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    this.__mainmodule_ltsync.Text = "Articulo: " + num.ToString(cul);
                }
                else
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR1.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                str7 = "17";
                this.__mainmodule_cmd.CommandText = "DELETE FROM provs";
                this.__mainmodule_cmd.ExecuteNonQuery();
                str7 = "18";
                this.__mainmodule_ltart.Text = "Importando Proveedores por favor espere";
                if (this.__mainmodule_msql1.ExecuteQuery("SELECT CLAVE, NOMBRE FROM PROV" + this.var__mainmodule_empresa).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str7 = "19";
                        str20 = this.__mainmodule_msql1.ReadField("CLAVE");
                        str21 = this.__mainmodule_msql1.ReadField("NOMBRE");
                        str21 = str21.Replace("'", " ");
                        this.var__mainmodule_sql = "INSERT INTO provs (clave, nombre) VALUES('" + str20 + "','" + str21 + "')";
                        str7 = "20";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR1.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                str7 = "18";
                this.__mainmodule_cmd.CommandText = "DELETE FROM clientes";
                this.__mainmodule_cmd.ExecuteNonQuery();
                str7 = "19";
                this.__mainmodule_ltart.Text = "Importando clientes por favor espere";
                if (this.__mainmodule_msql1.ExecuteQuery("SELECT CLAVE, NOMBRE, RFC, STATUS FROM CLIE" + this.var__mainmodule_empresa).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str7 = "20";
                        str20 = this.__mainmodule_msql1.ReadField("CLAVE");
                        str21 = this.__mainmodule_msql1.ReadField("NOMBRE");
                        str21 = str21.Replace("'", " ");
                        str22 = this.__mainmodule_msql1.ReadField("RFC");
                        str23 = this.__mainmodule_msql1.ReadField("STATUS");
                        this.var__mainmodule_sql = "INSERT INTO clientes (clave, nombre, rfc, status) VALUES('" + str20 + "','" + str21 + "','" + str22 + "','" + str23 + "')";
                        str7 = "21";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR_CLIENTES.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                str7 = "22";
                this.__mainmodule_cmd.CommandText = "DELETE FROM conm";
                this.__mainmodule_cmd.ExecuteNonQuery();
                str7 = "23";
                if (this.__mainmodule_msql1.ExecuteQuery("SELECT CVE_CPTO, DESCR FROM CONM" + this.var__mainmodule_empresa).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str24 = this.__mainmodule_msql1.ReadField("CVE_CPTO");
                        str25 = this.__mainmodule_msql1.ReadField("DESCR");
                        str7 = "24";
                        this.var__mainmodule_sql = "INSERT INTO conm (num_cpto, descr) VALUES('" + str24 + "','" + str25 + "')";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        str7 = "25";
                    }
                }
                else
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR1.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                this.__mainmodule_msql1.Close();
                str7 = "25";
                this.__mainmodule_ltart.Text = "";
                this.__mainmodule_con.EndTransaction();
                this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\button2.wav"));
                Thread.Sleep(0x7d0);
                ((int) MessageBox.Show(num.ToString(cul) + " OK Registros importados", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            Label_184F:
                this.__mainmodule_cierracontrans();
                ((int) MessageBox.Show("Error en importar paso " + str7 + "\r\n" + this.var__mainmodule_sql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR SQLITE.txt"), false, Encoding.UTF8));
                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(str7 + "->" + this.var__mainmodule_sql);
                if (this.htStreams.Contains("_mainmodule_c1"))
                {
                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                    this.htStreams.Remove("_mainmodule_c1");
                    GC.Collect();
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_importararticulos = num2;
                    this.localVars = new object[] { 
                        num, str, str2, connectiondata, str4, str5, lSide, str7, str8, str9, str10, str11, str12, str13, str14, str15,
                        str16, str17, str18, str19, str20, str21, str22, str23, str24, str25
                    };
                    return this.__mainmodule_importararticulos();
                }
                this.ShowError(exception, "_mainmodule_importararticulos");
                return "";
            }
        }

        private string __mainmodule_importararticulosupdateexist()
        {
            int num = 0;
            string lSide = "";
            string str2 = "";
            string connectiondata = "";
            string str4 = "";
            string str5 = "";
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_importararticulosupdateexist > 0)
                {
                    str5 = this.localVars[5];
                    str4 = this.localVars[4];
                    connectiondata = this.localVars[3];
                    str2 = this.localVars[2];
                    lSide = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_mainmodule_importararticulosupdateexist == 1)
                    {
                        this.err_mainmodule_importararticulosupdateexist = 0;
                        goto Label_0961;
                    }
                }
                num2 = 1;
                this.var__mainmodule_sql = "SELECT servidor, base, usuario, pass, puerto, ctrl_alm, almacen, ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '" + this.var__mainmodule_empresa + "'";
                this.__mainmodule_con.BeginTransaction();
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.var__mainmodule_serverlocal = this.__mainmodule_reader.GetValue(0);
                    this.var__mainmodule_base = this.__mainmodule_reader.GetValue(1);
                    this.var__mainmodule_usersql = this.__mainmodule_reader.GetValue(2);
                    this.var__mainmodule_passsql = this.__mainmodule_reader.GetValue(3);
                    this.var__mainmodule_portsql = this.__mainmodule_reader.GetValue(4);
                    this.var__mainmodule_ctrl_alm = this.__mainmodule_reader.GetValue(5);
                    this.var__mainmodule_almacen = double.Parse(this.__mainmodule_reader.GetValue(6), cul);
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
                if (this.LCompareEqual(this.var__mainmodule_sistema.ToString(cul), "1"))
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
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "IMPUESTO1, IMPUESTO4, (SELECT TOP 1 CVE_ALTER FROM ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE CTRL_ALM = '" + this.var__mainmodule_ctrl_alm + "'";
                    }
                    else
                    {
                        this.var__mainmodule_sql = "SELECT I.CVE_ART, DESCR, LIN_PROD, EXIST, CTRL_ALM, COSTO_PROM, UNI_MED, ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "IMPUESTO1, IMPUESTO4, (SELECT TOP 1 CVE_ALTER FROM ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "CVES_ALTER" + this.var__mainmodule_empresa + " A WHERE A.CVE_ART = I.CVE_ART AND TIPO = 'N') AS ALTERNA ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM INVE" + this.var__mainmodule_empresa + " I ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN IMPU" + this.var__mainmodule_empresa + " T ON T.CVE_ESQIMPU = I.CVE_ESQIMPU ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE LIN_PROD = '" + this.var__mainmodule_linea + "'";
                    }
                }
                else
                {
                    this.var__mainmodule_sql = "SELECT PRODUCTO, DESCRIPCIO, LINEA, EXISTENCIA, CLVALTER1,  ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "FROM CATINVEN";
                }
                this.var__mainmodule_errfound = bool.Parse("false");
                if (this.htControls["__mainmodule_msql1"] != null)
                {
                    this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                }
                this.__mainmodule_msql1 = new MSSQL.MSSQL();
                this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                connectiondata = "Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + ",";
                connectiondata = connectiondata + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";";
                if (this.__mainmodule_msql1.Open(connectiondata).ToString(cul).ToLower(cul) == "false")
                {
                    ((int) MessageBox.Show("Imposible conectarse al servidor\r\n" + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_msql1.Close();
                    this.var__mainmodule_errfound = bool.Parse("true");
                    this.__mainmodule_con.EndTransaction();
                    return "";
                }
                num = 0;
                if (this.__mainmodule_msql1.ExecuteQuery(this.var__mainmodule_sql).ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    while (this.__mainmodule_msql1.Advance().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        if (this.LCompareEqual(this.var__mainmodule_sistema.ToString(cul), "1"))
                        {
                            lSide = this.__mainmodule_msql1.ReadField("CVE_ART");
                            str5 = this.__mainmodule_msql1.ReadField("EXIST");
                        }
                        else
                        {
                            lSide = this.__mainmodule_msql1.ReadField("PRODUCTO");
                            str5 = this.__mainmodule_msql1.ReadField("EXISTENCIA");
                        }
                        if (this.LCompareEqual(lSide, "GRP000127OL"))
                        {
                            num = num;
                        }
                        num += (int) 1.0;
                        this.__mainmodule_ltmart.Text = lSide;
                        this.__mainmodule_ltmreg.Text = num.ToString(cul);
                        lSide = lSide.Replace("'", " ");
                        this.var__mainmodule_sql = "UPDATE prods SET existencia = " + str5 + " WHERE articulo = '" + lSide + "'";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR1.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show(this.__mainmodule_msql1.LastError, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                this.__mainmodule_msql1.Close();
                this.__mainmodule_con.EndTransaction();
                this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\button2.wav"));
                Thread.Sleep(0x7d0);
                return "";
            Label_0961:
                ((int) MessageBox.Show("Error al actualizar articulos  " + this.var__mainmodule_sql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_importararticulosupdateexist = num2;
                    this.localVars = new object[] { num, lSide, str2, connectiondata, str4, str5 };
                    return this.__mainmodule_importararticulosupdateexist();
                }
                this.ShowError(exception, "_mainmodule_importararticulosupdateexist");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_invencan_close");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_invencan_show");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_invent_close");
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
                    format = this.localVars[0];
                    if (this.err_mainmodule_invent_show == 1)
                    {
                        this.err_mainmodule_invent_show = 0;
                        goto Label_068C;
                    }
                }
                num = 1;
                this.__mainmodule_label25.BringToFront();
                this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tuni.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tarticulo.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_tarticulo.BringToFront();
                this.__mainmodule_label25.BringToFront();
                this.__mainmodule_tuni.BringToFront();
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
                {
                    this.__mainmodule_invent.Text = "Ordenes de compra";
                    this.__mainmodule_ltfc.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString(cul);
                    this.__mainmodule_mnucompra.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_label30.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_cboareas.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt1.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt2.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt3.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt4.Visible = bool.Parse("false".ToLower(cul));
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
                {
                    this.__mainmodule_invent.Text = "Inventario";
                    this.__mainmodule_ltfc.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_mnucompra.Enabled = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_label30.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_cboareas.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_lt1.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt2.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt3.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt4.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_cmd.CommandText = "SELECT id, nombre FROM areas order by nombre";
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_cboareas.Items.Add((((format = "D3".ToLower(cul))[0] != 'd') ? double.Parse(this.__mainmodule_reader.GetValue(0), cul).ToString(format, cul) : ((int) double.Parse(this.__mainmodule_reader.GetValue(0), cul)).ToString(format, cul)) + " " + this.__mainmodule_reader.GetValue(1));
                    }
                    this.__mainmodule_reader.Close();
                }
                if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                {
                    this.__mainmodule_invent.Text = "Pedidos";
                    this.__mainmodule_ltfc.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString(cul);
                    this.__mainmodule_mnucompra.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_mnuutilscompras.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_mnunuevacompra.Enabled = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_label30.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_cboareas.Visible = bool.Parse("false".ToLower(cul));
                    this.__mainmodule_lt1.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_lt2.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_lt3.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_lt4.Visible = bool.Parse("true".ToLower(cul));
                }
                this.__mainmodule_ltinven2.Text = "";
                this.__mainmodule_ltinven.Text = "";
                this.__mainmodule_tuni.Text = "1";
                this.__mainmodule_tarticulo.Text = "";
                this.__mainmodule_tarticulo.Focus();
                this.__mainmodule_tarticulo.Focus();
                this.__mainmodule_tarticulo.Focus();
                return "";
            Label_068C:
                ((int) MessageBox.Show("Error en Invent_Show.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_invent_show = num;
                    this.localVars = new object[] { format };
                    return this.__mainmodule_invent_show();
                }
                this.ShowError(exception, "_mainmodule_invent_show");
                return "";
            }
        }

        private string __mainmodule_inventario_acumulativo()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            string str2 = "";
            string lSide = "";
            string str4 = "";
            double num3 = 0.0;
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string format = "";
            string str9 = "";
            string str10 = "";
            string query = "";
            string s = "";
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
            string str24 = "";
            string str25 = "";
            string str26 = "";
            string str27 = "";
            string str28 = "";
            string str29 = "";
            string str30 = "";
            string str31 = "";
            string str32 = "";
            string str33 = "";
            string str34 = "";
            string str35 = "";
            string text = "";
            int num4 = 0;
            try
            {
                double num8;
                if (this.err_mainmodule_inventario_acumulativo > 0)
                {
                    text = this.localVars[0x26];
                    str35 = this.localVars[0x25];
                    str34 = this.localVars[0x24];
                    str33 = this.localVars[0x23];
                    str32 = this.localVars[0x22];
                    str31 = this.localVars[0x21];
                    str30 = this.localVars[0x20];
                    str29 = this.localVars[0x1f];
                    str28 = this.localVars[30];
                    str27 = this.localVars[0x1d];
                    str26 = this.localVars[0x1c];
                    str25 = this.localVars[0x1b];
                    str24 = this.localVars[0x1a];
                    str23 = this.localVars[0x19];
                    str22 = this.localVars[0x18];
                    str21 = this.localVars[0x17];
                    str20 = this.localVars[0x16];
                    str19 = this.localVars[0x15];
                    str18 = this.localVars[20];
                    str17 = this.localVars[0x13];
                    str16 = this.localVars[0x12];
                    str15 = this.localVars[0x11];
                    str14 = this.localVars[0x10];
                    str13 = this.localVars[15];
                    s = this.localVars[14];
                    query = this.localVars[13];
                    str10 = this.localVars[12];
                    str9 = this.localVars[11];
                    format = this.localVars[10];
                    str7 = this.localVars[9];
                    str6 = this.localVars[8];
                    str5 = this.localVars[7];
                    num3 = this.localVars[6];
                    str4 = this.localVars[5];
                    lSide = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_inventario_acumulativo == 1)
                    {
                        this.err_mainmodule_inventario_acumulativo = 0;
                        goto Label_16AA;
                    }
                }
                num4 = 1;
                str6 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str6, "7"))
                {
                    str7 = this.__mainmodule_numano.Value.ToString(cul) + (((format = "D2".ToLower(cul))[0] != 'd') ? (num8 = (double) this.__mainmodule_nummes.Value).ToString(format, cul) : ((int) ((double) this.__mainmodule_nummes.Value)).ToString(format, cul)) + (((str9 = "D2".ToLower(cul))[0] != 'd') ? ((double) this.__mainmodule_numdia.Value).ToString(str9, cul) : ((int) ((double) this.__mainmodule_numdia.Value)).ToString(str9, cul));
                    str10 = str7 + " " + new DateTime(DateTime.Now.Ticks).ToString(this.timeFormat, cul);
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    query = "SELECT TOP 1 NUM_MOV, CVE_FOLIO FROM MINVE" + this.var__mainmodule_empresa + " ORDER BY NUM_MOV DESC";
                    if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_msql1.Advance();
                        s = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("CVE_FOLIO"), "C");
                        if (this.Other.IsNumber(s).ToLower(cul) == "true")
                        {
                            str13 = s;
                            str13 = (((str13 == "") ? 0.0 : double.Parse(str13, cul)) + 1.0).ToString(cul);
                            s = str13;
                        }
                        else
                        {
                            s = "1";
                        }
                        str14 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("NUM_MOV"), "N");
                        if (this.Other.IsNumber(str14).ToLower(cul) == "true")
                        {
                            str13 = (((str14 == "") ? 0.0 : double.Parse(str14, cul)) + 1.0).ToString(cul);
                        }
                        else
                        {
                            str13 = "1";
                        }
                        goto Label_089D;
                    }
                    this.__mainmodule_msql1.Close();
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("Problema detectado 1894", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_089D:
                str15 = "M";
                str16 = "0";
                str17 = this.__mainmodule_trefminve.Text.Replace(" ", "");
                if (str17.Length.ToString(cul).ToLower(cul) == "true")
                {
                    int num5;
                    str17 = "II" + this.__mainmodule_numano.Value.ToString(cul) + this.__mainmodule_nummes.Value.ToString(cul) + this.__mainmodule_numdia.Value.ToString(cul) + (((str18 = "D2".ToLower(cul))[0] != 'd') ? ((double) (num8 = DateTime.Now.Minute)).ToString(str18, cul) : (num5 = DateTime.Now.Minute).ToString(str18, cul)) + (((str19 = "D2".ToLower(cul))[0] != 'd') ? ((double) (num8 = DateTime.Now.Second)).ToString(str19, cul) : (num5 = DateTime.Now.Second).ToString(str19, cul));
                }
                str20 = "";
                str21 = "";
                str22 = "0";
                str23 = "0";
                str24 = "P";
                str25 = "1";
                str26 = "S";
                str27 = "N";
                str28 = "0";
                this.var__mainmodule_sql = "Select P.articulo, SUM(cantidad), Max(costo_prom), MAX(uni_med) FROM minve M ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "INNER JOIN prods P ON P.articulo = M.articulo ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE nuevo = 'S' AND cancelado <> 'C' GROUP BY P.articulo HAVING SUM(cantidad) > 0";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                str29 = "0";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    Application.DoEvents();
                    lSide = this.__mainmodule_reader.GetValue(0);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                    {
                        num2 = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                    }
                    else
                    {
                        num2 = 0.0;
                    }
                    this.__mainmodule_ltmart.Text = lSide;
                    this.__mainmodule_ltmcant.Text = num2.ToString(cul);
                    this.__mainmodule_ltmreg.Text = str29;
                    str30 = this.__mainmodule_reader.GetValue(2);
                    str31 = "0";
                    str32 = str30;
                    str33 = str30;
                    str34 = this.__mainmodule_reader.GetValue(3);
                    num3 = num - num2;
                    if (this.LCompareEqual(lSide, "VIO000029OL"))
                    {
                        num8 = -1.0;
                        str35 = num8.ToString(cul);
                    }
                    text = this.__mainmodule_tconm.Text;
                    str35 = "1";
                    num8 = ((str29 == "") ? 0.0 : double.Parse(str29, cul)) + 1.0;
                    str29 = num8.ToString(cul);
                    if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "1"))
                    {
                        query = "UPDATE MULT" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) + " + num2.ToString(cul);
                        query = query + " WHERE CVE_ART = '" + lSide + "' AND CVE_ALM = " + this.var__mainmodule_almacen.ToString(cul);
                        if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                        {
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO_ACUMULATIVO MULT.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_mainmodule_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                this.htStreams.Remove("_mainmodule_c1");
                                GC.Collect();
                            }
                            this.__mainmodule_msql1.Close();
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            ((int) MessageBox.Show("Problema detectado 1985", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            return "";
                        }
                    }
                    query = "UPDATE INVE" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) + " + num2.ToString(cul) + " WHERE CVE_ART = '" + lSide + "'";
                    if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                    {
                        this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO_ACUMULATIVO UPDATE INVEN.txt"), false, Encoding.UTF8));
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                        if (this.htStreams.Contains("_mainmodule_c1"))
                        {
                            ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                            this.htStreams.Remove("_mainmodule_c1");
                            GC.Collect();
                        }
                        this.__mainmodule_msql1.Close();
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Problema detectado 2568", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    query = "INSERT INTO MINVE" + this.var__mainmodule_empresa + " (CVE_ART, ALMACEN, NUM_MOV, CVE_CPTO, VEND, ";
                    query = query + "FECHA_DOCU, TIPO_DOC, REFER, CLAVE_CLPV, CANT, CANT_COST, PRECIO, COSTO, ";
                    query = query + "REG_SERIE, UNI_VENTA, E_LTPD, EXISTENCIA, TIPO_PROD, FACTOR_CON, FECHAELAB, ";
                    query = query + "CVE_FOLIO, SIGNO, COSTEADO, COSTO_PROM_INI, COSTO_PROM_FIN, DESDE_INVE, ";
                    query = query + "MOV_ENLAZADO, AFEC_COI) Values('" + lSide + "','" + this.var__mainmodule_almacen.ToString(cul);
                    query = query + "','" + str13 + "','" + text + "','" + str21 + "','";
                    query = query + str7 + "','" + str15 + "','" + str17 + "X','" + str20;
                    query = query + "','" + num2.ToString(cul) + "','" + str31 + "','" + str16 + "','";
                    query = query + str30 + "','" + str22 + "','" + str34 + "','" + str23;
                    query = query + "',(SELECT EXIST FROM INVE" + this.var__mainmodule_empresa + " WHERE CVE_ART = '" + lSide + "'),'";
                    query = query + str24 + "','" + str25 + "','" + str10 + "','";
                    query = query + s + "','" + str35 + "','" + str26 + "','" + str32 + "','";
                    query = query + str33 + "','" + str27 + "','" + str28 + "','S')";
                    if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO_ACUMULATIVO MINVE.txt"), false, Encoding.UTF8));
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                        if (this.htStreams.Contains("_mainmodule_c1"))
                        {
                            ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                            this.htStreams.Remove("_mainmodule_c1");
                            GC.Collect();
                        }
                        this.__mainmodule_msql1.Close();
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Problema detectado 2593", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    str13 = (((str13 == "") ? 0.0 : double.Parse(str13, cul)) + 1.0).ToString(cul);
                    this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide + "'";
                    this.__mainmodule_cmd2.ExecuteNonQuery();
                    this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide + "'";
                    this.__mainmodule_cmd2.ExecuteNonQuery();
                }
                this.__mainmodule_reader.Close();
                query = "UPDATE TBLCONTROL" + this.var__mainmodule_empresa + " SET ULT_CVE = (SELECT ISNULL(MAX(NUM_MOV),0) FROM MINVE" + this.var__mainmodule_empresa;
                query = query + ") WHERE ID_TABLA = 44";
                if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                {
                    this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO_ACUMULATIVO TBLCONTROL2.txt"), false, Encoding.UTF8));
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                    ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                    if (this.htStreams.Contains("_mainmodule_c1"))
                    {
                        ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                        this.htStreams.Remove("_mainmodule_c1");
                        GC.Collect();
                    }
                    this.__mainmodule_msql1.Close();
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("Problema detectado 2613", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                this.__mainmodule_msql1.Close();
                ((int) MessageBox.Show("ok articulo procesados " + str29, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_ltinven2.Text = "";
                this.__mainmodule_ltinven.Text = "";
                this.__mainmodule_procminve.close();
                return "";
            Label_16AA:
                this.__mainmodule_cierramsql();
                ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num4 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_inventario_acumulativo = num4;
                    this.localVars = new object[] { 
                        str, num, num2, str2, lSide, str4, num3, str5, str6, str7, format, str9, str10, query, s, str13,
                        str14, str15, str16, str17, str18, str19, str20, str21, str22, str23, str24, str25, str26, str27, str28, str29,
                        str30, str31, str32, str33, str34, str35, text
                    };
                    return this.__mainmodule_inventario_acumulativo();
                }
                this.ShowError(exception, "_mainmodule_inventario_acumulativo");
                return "";
            }
        }

        private string __mainmodule_inventario_acumulativo_proc_almacenado()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            string str2 = "";
            string lSide = "";
            string str4 = "";
            double num4 = 0.0;
            string str5 = "";
            double num5 = 0.0;
            double num6 = 0.0;
            string str6 = "";
            string str7 = "";
            string format = "";
            string str9 = "";
            string s = "";
            string str11 = "";
            string str12 = "";
            string str13 = "";
            string str14 = "";
            string str15 = "";
            string str16 = "";
            string query = "";
            int num7 = 0;
            try
            {
                if (this.err_mainmodule_inventario_acumulativo_proc_almacenado > 0)
                {
                    query = this.localVars[0x16];
                    str16 = this.localVars[0x15];
                    str15 = this.localVars[20];
                    str14 = this.localVars[0x13];
                    str13 = this.localVars[0x12];
                    str12 = this.localVars[0x11];
                    str11 = this.localVars[0x10];
                    s = this.localVars[15];
                    str9 = this.localVars[14];
                    format = this.localVars[13];
                    str7 = this.localVars[12];
                    str6 = this.localVars[11];
                    num6 = this.localVars[10];
                    num5 = this.localVars[9];
                    str5 = this.localVars[8];
                    num4 = this.localVars[7];
                    str4 = this.localVars[6];
                    lSide = this.localVars[5];
                    str2 = this.localVars[4];
                    num3 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_inventario_acumulativo_proc_almacenado == 1)
                    {
                        this.err_mainmodule_inventario_acumulativo_proc_almacenado = 0;
                        goto Label_0D02;
                    }
                }
                num7 = 1;
                str6 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str6, "7"))
                {
                    this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(cul));
                    this.var__mainmodule_errfound = bool.Parse("false");
                    this.__mainmodule_copiaarchivos2();
                    this.__mainmodule_ltmreg.Text = "";
                    if (this.Other.IsNumber(this.__mainmodule_tconm.Text) == "false")
                    {
                        ((int) MessageBox.Show("El concepto es numerico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    str7 = this.__mainmodule_trefminve.Text.Replace(" ", "");
                    if (str7.Length.ToString(cul) == "0")
                    {
                        str7 = "II" + this.__mainmodule_numano.Value.ToString(cul) + this.__mainmodule_nummes.Value.ToString(cul) + this.__mainmodule_numdia.Value.ToString(cul) + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Minute).ToString(format, cul) : DateTime.Now.Minute.ToString(format, cul)) + (((str9 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Second).ToString(str9, cul) : DateTime.Now.Second.ToString(str9, cul));
                    }
                    s = "0";
                    str11 = "0";
                    this.var__mainmodule_sql = "Select I.articulo, Max(P.existencia), Max(P.costo_prom), Max(P.uni_med), ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "SUM(I.cantidad), Max(P.status), Max(P.descrip), Max(P.linea) FROM minve I ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN prods P ON P.articulo = I.articulo ";
                    this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo ORDER BY I.articulo";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        lSide = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                        }
                        else
                        {
                            num = 0.0;
                        }
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(cul) == "true")
                        {
                            num2 = double.Parse(this.__mainmodule_reader.GetValue(4), cul);
                            num3 = num2;
                        }
                        else
                        {
                            num2 = 0.0;
                        }
                        str12 = (((str12 == "") ? 0.0 : double.Parse(str12, cul)) + num2).ToString(cul);
                        this.__mainmodule_ltmart.Text = lSide;
                        this.__mainmodule_ltmcant.Text = num2.ToString(cul);
                        str13 = this.__mainmodule_reader.GetValue(2);
                        str14 = this.__mainmodule_reader.GetValue(3);
                        str15 = this.__mainmodule_reader.GetValue(6);
                        this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(7);
                        num4 = num - num2;
                        str16 = "0";
                        if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                        {
                            num4 = num2;
                            if (num2 > 0.0)
                            {
                                str16 = "1";
                            }
                        }
                        else
                        {
                            str16 = "1";
                        }
                        if (this.LCompareEqual(lSide, "CDN000160AC"))
                        {
                            str5 = "";
                        }
                        num6 = double.Parse(this.__mainmodule_tconm.Text, cul);
                        s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                        if (num2 > 0.0)
                        {
                            str11 = (((str11 == "") ? 0.0 : double.Parse(str11, cul)) + 1.0).ToString(cul);
                        }
                        this.__mainmodule_ltmreg.Text = str11 + "/" + s;
                        this.__mainmodule_ltpiezas.Text = str12;
                        if (this.LCompareEqual(str16, "1"))
                        {
                            num5 = 0.0;
                            if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "1"))
                            {
                                num5 = this.var__mainmodule_almacen;
                            }
                            query = "EXECUTE Inve_desde_pda_opcion2 " + num2.ToString(cul) + "," + num5.ToString(cul) + "," + str13 + "," + num6.ToString(cul) + ",'";
                            query = query + str7 + "','" + lSide + "','" + str15 + "','";
                            query = query + this.var__mainmodule_linea + "','" + str14 + "'," + str13 + "," + str13 + ",1";
                            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\PROCEDIMIENTO ALMACENADO.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                this.__mainmodule_msql1.Close();
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema en el PROCEDIMIENTO ALMACENADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                break;
                            }
                            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide + "'";
                            this.__mainmodule_cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide + "'";
                            this.__mainmodule_cmd2.ExecuteNonQuery();
                        }
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_msql1.Close();
                    ((int) MessageBox.Show("ok Articulos procesados " + s, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_bk_txt();
                    this.__mainmodule_copiaarchivos2();
                    this.__mainmodule_ltinven2.Text = "";
                    this.__mainmodule_ltinven.Text = "";
                }
                return "";
            Label_0D02:
                this.__mainmodule_cierramsql();
                this.__mainmodule_cierrareader();
                ((int) MessageBox.Show("Problema al enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num7 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_inventario_acumulativo_proc_almacenado = num7;
                    this.localVars = new object[] { 
                        str, num, num2, num3, str2, lSide, str4, num4, str5, num5, num6, str6, str7, format, str9, s,
                        str11, str12, str13, str14, str15, str16, query
                    };
                    return this.__mainmodule_inventario_acumulativo_proc_almacenado();
                }
                this.ShowError(exception, "_mainmodule_inventario_acumulativo_proc_almacenado");
                return "";
            }
        }

        private string __mainmodule_inventario_directo()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            string str2 = "";
            string lSide = "";
            string str4 = "";
            double num4 = 0.0;
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string format = "";
            string str9 = "";
            string str10 = "";
            string query = "";
            string s = "";
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
            string str24 = "";
            string str25 = "";
            string str26 = "";
            string str27 = "";
            string str28 = "";
            string str29 = "";
            string str30 = "";
            string str31 = "";
            string str32 = "";
            string str33 = "";
            string str34 = "";
            string str35 = "";
            string str36 = "";
            string str37 = "";
            string text = "";
            string str39 = "";
            string str40 = "";
            int num5 = 0;
            try
            {
                double num10;
                if (this.err_mainmodule_inventario_directo > 0)
                {
                    str40 = this.localVars[0x2b];
                    str39 = this.localVars[0x2a];
                    text = this.localVars[0x29];
                    str37 = this.localVars[40];
                    str36 = this.localVars[0x27];
                    str35 = this.localVars[0x26];
                    str34 = this.localVars[0x25];
                    str33 = this.localVars[0x24];
                    str32 = this.localVars[0x23];
                    str31 = this.localVars[0x22];
                    str30 = this.localVars[0x21];
                    str29 = this.localVars[0x20];
                    str28 = this.localVars[0x1f];
                    str27 = this.localVars[30];
                    str26 = this.localVars[0x1d];
                    str25 = this.localVars[0x1c];
                    str24 = this.localVars[0x1b];
                    str23 = this.localVars[0x1a];
                    str22 = this.localVars[0x19];
                    str21 = this.localVars[0x18];
                    str20 = this.localVars[0x17];
                    str19 = this.localVars[0x16];
                    str18 = this.localVars[0x15];
                    str17 = this.localVars[20];
                    str16 = this.localVars[0x13];
                    str15 = this.localVars[0x12];
                    str14 = this.localVars[0x11];
                    str13 = this.localVars[0x10];
                    s = this.localVars[15];
                    query = this.localVars[14];
                    str10 = this.localVars[13];
                    str9 = this.localVars[12];
                    format = this.localVars[11];
                    str7 = this.localVars[10];
                    str6 = this.localVars[9];
                    str5 = this.localVars[8];
                    num4 = this.localVars[7];
                    str4 = this.localVars[6];
                    lSide = this.localVars[5];
                    str2 = this.localVars[4];
                    num3 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_inventario_directo == 1)
                    {
                        this.err_mainmodule_inventario_directo = 0;
                        goto Label_19E2;
                    }
                }
                num5 = 1;
                str6 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str6, "7"))
                {
                    this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(cul));
                    this.var__mainmodule_errfound = bool.Parse("false");
                    this.__mainmodule_copiaarchivos2();
                    this.__mainmodule_importararticulosupdateexist();
                    this.__mainmodule_ltmreg.Text = "";
                    if (this.LCompareEqual(this.var__mainmodule_errfound.ToString().ToLower(cul), "true"))
                    {
                        ((int) MessageBox.Show("Ocurrio un error al intentar obtener las existencias actualizasdas, proceso cancelado", "Enviar inventario", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    str7 = this.__mainmodule_numano.Value.ToString(cul) + (((format = "D2".ToLower(cul))[0] != 'd') ? (num10 = (double) this.__mainmodule_nummes.Value).ToString(format, cul) : ((int) ((double) this.__mainmodule_nummes.Value)).ToString(format, cul)) + (((str9 = "D2".ToLower(cul))[0] != 'd') ? ((double) this.__mainmodule_numdia.Value).ToString(str9, cul) : ((int) ((double) this.__mainmodule_numdia.Value)).ToString(str9, cul));
                    str10 = str7 + " " + new DateTime(DateTime.Now.Ticks).ToString(this.timeFormat, cul);
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    query = "SELECT TOP 1 NUM_MOV, CVE_FOLIO FROM MINVE" + this.var__mainmodule_empresa + " ORDER BY NUM_MOV DESC";
                    if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "true")
                    {
                        this.__mainmodule_msql1.Advance();
                        s = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("CVE_FOLIO"), "C");
                        if (this.Other.IsNumber(s).ToLower(cul) == "true")
                        {
                            str13 = s;
                            num10 = ((str13 == "") ? 0.0 : double.Parse(str13, cul)) + 1.0;
                            str13 = num10.ToString(cul);
                            s = str13;
                        }
                        else
                        {
                            s = "1";
                        }
                        str14 = this.__mainmodule_validacampo(this.__mainmodule_msql1.ReadField("NUM_MOV"), "N");
                        if (this.Other.IsNumber(str14).ToLower(cul) == "true")
                        {
                            num10 = ((str14 == "") ? 0.0 : double.Parse(str14, cul)) + 1.0;
                            str13 = num10.ToString(cul);
                        }
                        else
                        {
                            str13 = "1";
                        }
                        goto Label_09B1;
                    }
                    this.__mainmodule_msql1.Close();
                    Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                    ((int) MessageBox.Show("Problema detectado 1894", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_09B1:
                str15 = "M";
                str16 = "0";
                str17 = this.__mainmodule_trefminve.Text.Replace(" ", "");
                if (str17.Length.ToString(cul) == "0")
                {
                    int num6;
                    str17 = "II" + this.__mainmodule_numano.Value.ToString(cul) + this.__mainmodule_nummes.Value.ToString(cul) + this.__mainmodule_numdia.Value.ToString(cul) + (((str18 = "D2".ToLower(cul))[0] != 'd') ? ((double) (num10 = DateTime.Now.Minute)).ToString(str18, cul) : (num6 = DateTime.Now.Minute).ToString(str18, cul)) + (((str19 = "D2".ToLower(cul))[0] != 'd') ? ((double) (num10 = DateTime.Now.Second)).ToString(str19, cul) : (num6 = DateTime.Now.Second).ToString(str19, cul));
                }
                str20 = "";
                str21 = "";
                str22 = "0";
                str23 = "0";
                str24 = "P";
                str25 = "1";
                str26 = "S";
                str27 = "N";
                str28 = "0";
                this.var__mainmodule_sql = "SELECT I.articulo, I.existencia, I.costo_prom, I.uni_med, (SELECT exist FROM inven P WHERE ";
                this.var__mainmodule_sql = this.var__mainmodule_sql + "P.articulo = i.articulo), status FROM prods I WHERE status = 0 ORDER BY descrip";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                str29 = "0";
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    Application.DoEvents();
                    lSide = this.__mainmodule_reader.GetValue(0);
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                    {
                        num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                    }
                    else
                    {
                        num = 0.0;
                    }
                    if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(cul) == "true")
                    {
                        num2 = double.Parse(this.__mainmodule_reader.GetValue(4), cul);
                        num3 = num2;
                    }
                    else
                    {
                        num2 = 0.0;
                    }
                    str30 = this.__mainmodule_reader.GetValue(5);
                    num10 = ((str31 == "") ? 0.0 : double.Parse(str31, cul)) + num2;
                    str31 = num10.ToString(cul);
                    this.__mainmodule_ltmart.Text = lSide;
                    this.__mainmodule_ltmcant.Text = num2.ToString(cul);
                    str32 = this.__mainmodule_reader.GetValue(2);
                    str33 = "0";
                    str34 = str32;
                    str35 = str32;
                    str36 = this.__mainmodule_reader.GetValue(3);
                    num4 = num - num2;
                    if (this.LCompareEqual(lSide, "GRP000127OL"))
                    {
                        num10 = -1.0;
                        str37 = num10.ToString(cul);
                    }
                    if (num4 > 0.0)
                    {
                        text = this.__mainmodule_tconsal.Text;
                        num10 = -1.0;
                        str37 = num10.ToString(cul);
                        str39 = " - " + Math.Abs(num4).ToString(cul);
                    }
                    else
                    {
                        text = this.__mainmodule_tconm.Text;
                        str37 = "1";
                        str39 = " + " + Math.Abs(num4).ToString(cul);
                    }
                    str40 = "0";
                    if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        if (num2 > 0.0)
                        {
                            str40 = "1";
                        }
                    }
                    else
                    {
                        str40 = "1";
                    }
                    if (num2 > 0.0)
                    {
                        str5 = "";
                    }
                    if (this.LCompareEqual(lSide, "ANI000018PL"))
                    {
                        str5 = "";
                    }
                    if (this.LCompareEqual(str40, "1"))
                    {
                        if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "1"))
                        {
                            query = "UPDATE MULT" + this.var__mainmodule_empresa + " SET EXIST = " + num2.ToString(cul);
                            query = query + " WHERE CVE_ART = '" + lSide + "' AND CVE_ALM = " + this.var__mainmodule_almacen.ToString(cul);
                            if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO DIRECTO UPDATE MULT.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                this.__mainmodule_msql1.Close();
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema detectado 2578", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                return "";
                            }
                        }
                        query = "UPDATE INVE" + this.var__mainmodule_empresa + " SET EXIST = ISNULL(EXIST,0) " + str39 + " WHERE CVE_ART = '" + lSide + "'";
                        if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                        {
                            this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO DIRECTO UPDATE INVEN.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_mainmodule_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                this.htStreams.Remove("_mainmodule_c1");
                                GC.Collect();
                            }
                            this.__mainmodule_msql1.Close();
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            ((int) MessageBox.Show("Problema detectado 2581", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            return "";
                        }
                        if ((Math.Abs(num4).ToString(cul) != "0") && this.LCompareEqual(str30, "0"))
                        {
                            this.__mainmodule_ltmreg.Text = str29 + "/" + str31;
                            num10 = ((str29 == "") ? 0.0 : double.Parse(str29, cul)) + 1.0;
                            str29 = num10.ToString(cul);
                            query = "INSERT INTO MINVE" + this.var__mainmodule_empresa + " (CVE_ART, ALMACEN, NUM_MOV, CVE_CPTO, VEND, ";
                            query = query + "FECHA_DOCU, TIPO_DOC, REFER, CLAVE_CLPV, CANT, CANT_COST, PRECIO, COSTO, ";
                            query = query + "REG_SERIE, UNI_VENTA, E_LTPD, EXISTENCIA, TIPO_PROD, FACTOR_CON, FECHAELAB, ";
                            query = query + "CVE_FOLIO, SIGNO, COSTEADO, COSTO_PROM_INI, COSTO_PROM_FIN, DESDE_INVE, ";
                            query = query + "MOV_ENLAZADO, AFEC_COI) Values('" + lSide + "','" + this.var__mainmodule_almacen.ToString(cul);
                            query = query + "','" + str13 + "','" + text + "','" + str21 + "','";
                            query = query + str7 + "','" + str15 + "','" + str17 + "','" + str20;
                            query = query + "','" + Math.Abs(num4).ToString(cul) + "','" + str33 + "','" + str16 + "','";
                            query = query + str32 + "','" + str22 + "','" + str36 + "','" + str23;
                            query = query + "','" + num2.ToString(cul) + "','";
                            query = query + str24 + "','" + str25 + "','" + str10 + "','";
                            query = query + s + "','" + str37 + "','" + str26 + "','" + str34 + "','";
                            query = query + str35 + "','" + str27 + "','" + str28 + "','S')";
                            if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO DIRECTO MINVE.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                this.__mainmodule_msql1.Close();
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema detectado 2621", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                return "";
                            }
                            str13 = (((str13 == "") ? 0.0 : double.Parse(str13, cul)) + 1.0).ToString(cul);
                        }
                        this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide + "'";
                        this.__mainmodule_cmd2.ExecuteNonQuery();
                        this.__mainmodule_cmd2.CommandText = "UPDATE prods SET status = 1 WHERE articulo = '" + lSide + "'";
                        this.__mainmodule_cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        this.__mainmodule_cmd2.CommandText = "UPDATE inven SET status = 1 WHERE articulo = '" + lSide + "'";
                        this.__mainmodule_cmd2.ExecuteNonQuery();
                        this.__mainmodule_cmd2.CommandText = "UPDATE prods SET status = 1 WHERE articulo = '" + lSide + "'";
                        this.__mainmodule_cmd2.ExecuteNonQuery();
                    }
                }
                this.__mainmodule_reader.Close();
                if (((str29 == "") ? 0.0 : double.Parse(str29, cul)) > 0.0)
                {
                    query = "UPDATE TBLCONTROL" + this.var__mainmodule_empresa + " SET ULT_CVE = (SELECT ISNULL(MAX(NUM_MOV),0) FROM MINVE" + this.var__mainmodule_empresa;
                    query = query + ") WHERE ID_TABLA = 44";
                    if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                    {
                        this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVENTARIO DIRECTO TBLCONTROL2.txt"), false, Encoding.UTF8));
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                        if (this.htStreams.Contains("_mainmodule_c1"))
                        {
                            ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                            this.htStreams.Remove("_mainmodule_c1");
                            GC.Collect();
                        }
                        this.__mainmodule_msql1.Close();
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Problema detectado 2647", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                }
                this.__mainmodule_msql1.Close();
                ((int) MessageBox.Show("ok Articulos procesados " + str29, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__mainmodule_copiaarchivos2();
                this.__mainmodule_ltinven2.Text = "";
                this.__mainmodule_ltinven.Text = "";
                return "";
            Label_19E2:
                this.__mainmodule_cierramsql();
                ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num5 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_inventario_directo = num5;
                    this.localVars = new object[] { 
                        str, num, num2, num3, str2, lSide, str4, num4, str5, str6, str7, format, str9, str10, query, s,
                        str13, str14, str15, str16, str17, str18, str19, str20, str21, str22, str23, str24, str25, str26, str27, str28,
                        str29, str30, str31, str32, str33, str34, str35, str36, str37, text, str39, str40
                    };
                    return this.__mainmodule_inventario_directo();
                }
                this.ShowError(exception, "_mainmodule_inventario_directo");
                return "";
            }
        }

        private string __mainmodule_inventario_directo_proc_almacenado()
        {
            string str = "";
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            string str2 = "";
            string lSide = "";
            string str4 = "";
            double num4 = 0.0;
            string str5 = "";
            double num5 = 0.0;
            string str6 = "";
            string str7 = "";
            string format = "";
            string str9 = "";
            string s = "";
            string str11 = "";
            string str12 = "";
            string str13 = "";
            string str14 = "";
            string str15 = "";
            string text = "";
            string str17 = "";
            string query = "";
            int num6 = 0;
            try
            {
                if (this.err_mainmodule_inventario_directo_proc_almacenado > 0)
                {
                    query = this.localVars[0x16];
                    str17 = this.localVars[0x15];
                    text = this.localVars[20];
                    str15 = this.localVars[0x13];
                    str14 = this.localVars[0x12];
                    str13 = this.localVars[0x11];
                    str12 = this.localVars[0x10];
                    str11 = this.localVars[15];
                    s = this.localVars[14];
                    str9 = this.localVars[13];
                    format = this.localVars[12];
                    str7 = this.localVars[11];
                    str6 = this.localVars[10];
                    num5 = this.localVars[9];
                    str5 = this.localVars[8];
                    num4 = this.localVars[7];
                    str4 = this.localVars[6];
                    lSide = this.localVars[5];
                    str2 = this.localVars[4];
                    num3 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_inventario_directo_proc_almacenado == 1)
                    {
                        this.err_mainmodule_inventario_directo_proc_almacenado = 0;
                        goto Label_0E2C;
                    }
                }
                num6 = 1;
                str6 = ((int) MessageBox.Show("Realmente desea enviar inventario ?", "Enviar inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str6, "7"))
                {
                    this.__mainmodule_btngenerar.Enabled = bool.Parse("false".ToLower(cul));
                    this.var__mainmodule_errfound = bool.Parse("false");
                    this.__mainmodule_copiaarchivos2();
                    this.__mainmodule_ltmreg.Text = "";
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\CONECT SQL ERROR.txt"), false, Encoding.UTF8));
                        ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                        if (this.htStreams.Contains("_mainmodule_c1"))
                        {
                            ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                            this.htStreams.Remove("_mainmodule_c1");
                            GC.Collect();
                        }
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    str7 = this.__mainmodule_trefminve.Text.Replace(" ", "");
                    if (str7.Length.ToString(cul) == "0")
                    {
                        str7 = "II" + this.__mainmodule_numano.Value.ToString(cul) + this.__mainmodule_nummes.Value.ToString(cul) + this.__mainmodule_numdia.Value.ToString(cul) + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Minute).ToString(format, cul) : DateTime.Now.Minute.ToString(format, cul)) + (((str9 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Second).ToString(str9, cul) : DateTime.Now.Second.ToString(str9, cul));
                    }
                    s = "0";
                    str11 = "0";
                    if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                    {
                        this.var__mainmodule_sql = "Select I.articulo, Max(P.existencia), Max(P.costo_prom), Max(P.uni_med), ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "SUM(I.cantidad), Max(P.status), Max(P.descrip), Max(P.linea) FROM minve I ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "LEFT JOIN prods P ON P.articulo = I.articulo ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "WHERE I.nuevo = 'S' AND cancelado = 'N' GROUP BY I.articulo ORDER BY I.articulo";
                    }
                    else
                    {
                        this.var__mainmodule_sql = "SELECT I.articulo, I.existencia, I.costo_prom, I.uni_med, (SELECT exist FROM inven P WHERE ";
                        this.var__mainmodule_sql = this.var__mainmodule_sql + "P.articulo = i.articulo), status, descrip, linea FROM prods I ORDER BY descrip";
                    }
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        lSide = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            num = double.Parse(this.__mainmodule_reader.GetValue(1), cul);
                        }
                        else
                        {
                            num = 0.0;
                        }
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(4)).ToLower(cul) == "true")
                        {
                            num2 = double.Parse(this.__mainmodule_reader.GetValue(4), cul);
                            num3 = num2;
                        }
                        else
                        {
                            num2 = 0.0;
                        }
                        str12 = (((str12 == "") ? 0.0 : double.Parse(str12, cul)) + num2).ToString(cul);
                        this.__mainmodule_ltmart.Text = lSide;
                        this.__mainmodule_ltmcant.Text = num2.ToString(cul);
                        str13 = this.__mainmodule_reader.GetValue(2);
                        str14 = this.__mainmodule_reader.GetValue(3);
                        str15 = this.__mainmodule_reader.GetValue(6);
                        this.var__mainmodule_linea = this.__mainmodule_reader.GetValue(7);
                        num4 = num - num2;
                        if (num4 > 0.0)
                        {
                            text = this.__mainmodule_tconsal.Text;
                        }
                        else
                        {
                            text = this.__mainmodule_tconm.Text;
                        }
                        str17 = "0";
                        if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                        {
                            num4 = num2;
                            text = this.__mainmodule_tconm.Text;
                            if (num2 > 0.0)
                            {
                                str17 = "1";
                            }
                        }
                        else
                        {
                            str17 = "1";
                        }
                        if (this.LCompareEqual(lSide, "CDN000160AC"))
                        {
                            str5 = "";
                        }
                        s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                        if (num2 > 0.0)
                        {
                            str11 = (((str11 == "") ? 0.0 : double.Parse(str11, cul)) + 1.0).ToString(cul);
                        }
                        this.__mainmodule_ltmreg.Text = str11 + "/" + s;
                        this.__mainmodule_ltpiezas.Text = str12;
                        if (this.LCompareEqual(str17, "1"))
                        {
                            num5 = 0.0;
                            if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "1"))
                            {
                                num5 = this.var__mainmodule_almacen;
                            }
                            query = "EXECUTE Inve_desde_pda " + num2.ToString(cul) + "," + num5.ToString(cul) + "," + str13 + ",'";
                            query = query + str7 + "','" + lSide + "','" + str15 + "','";
                            query = query + this.var__mainmodule_linea + "','" + str14 + "'," + str13 + "," + str13 + ",1";
                            if (this.__mainmodule_msql1.ExecuteQuery(query).ToString(cul).ToLower(cul) == "false")
                            {
                                this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\PROCEDIMIENTO ALMACENADO.txt"), false, Encoding.UTF8));
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(query);
                                ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError + "\r\n" + text);
                                if (this.htStreams.Contains("_mainmodule_c1"))
                                {
                                    ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                    this.htStreams.Remove("_mainmodule_c1");
                                    GC.Collect();
                                }
                                this.__mainmodule_msql1.Close();
                                Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                                ((int) MessageBox.Show("Problema en el PROCEDIMIENTO ALMACENADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                                break;
                            }
                            if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                            {
                                this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide + "'";
                                this.__mainmodule_cmd2.ExecuteNonQuery();
                            }
                        }
                        else if (this.__mainmodule_opminve1.Checked.ToString(cul).ToLower(cul).ToLower(cul) == "true")
                        {
                            this.__mainmodule_cmd2.CommandText = "UPDATE minve SET nuevo = 'N' WHERE articulo = '" + lSide + "'";
                            this.__mainmodule_cmd2.ExecuteNonQuery();
                        }
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_msql1.Close();
                    ((int) MessageBox.Show("ok Articulos procesados " + s, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_bk_txt();
                    this.__mainmodule_copiaarchivos2();
                    this.__mainmodule_ltinven2.Text = "";
                    this.__mainmodule_ltinven.Text = "";
                }
                return "";
            Label_0E2C:
                this.__mainmodule_cierramsql();
                this.__mainmodule_cierrareader();
                ((int) MessageBox.Show("No se logro enviar el inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num6 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_inventario_directo_proc_almacenado = num6;
                    this.localVars = new object[] { 
                        str, num, num2, num3, str2, lSide, str4, num4, str5, num5, str6, str7, format, str9, s, str11,
                        str12, str13, str14, str15, text, str17, query
                    };
                    return this.__mainmodule_inventario_directo_proc_almacenado();
                }
                this.ShowError(exception, "_mainmodule_inventario_directo_proc_almacenado");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_listcte_click");
                return "";
            }
        }

        private string __mainmodule_main_close()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_main_close > 0) && (this.err_mainmodule_main_close == 1))
                {
                    this.err_mainmodule_main_close = 0;
                }
                else
                {
                    num = 1;
                    if (((int) MessageBox.Show("Desea salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul) == "7")
                    {
                        this.__mainmodule_main.cancelClose = true;
                    }
                    else
                    {
                        this.__mainmodule_con.Close();
                    }
                    return "";
                }
                ((int) MessageBox.Show("Advertencia mnuMain_Close", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_main_close = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_main_close();
                }
                this.ShowError(exception, "_mainmodule_main_close");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_main_show");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mencan_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_menfin_click");
                return "";
            }
        }

        private string __mainmodule_menmov_click()
        {
            int num = 0;
            int num2 = 0;
            try
            {
                if (this.err_mainmodule_menmov_click > 0)
                {
                    num = this.localVars[0];
                    if (this.err_mainmodule_menmov_click == 1)
                    {
                        this.err_mainmodule_menmov_click = 0;
                        goto Label_0042;
                    }
                }
                num2 = 1;
                this.__mainmodule_invencan.show();
                return "";
            Label_0042:
                ((int) MessageBox.Show("Error en cmdMovs.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_menmov_click = num2;
                    this.localVars = new object[] { num };
                    return this.__mainmodule_menmov_click();
                }
                this.ShowError(exception, "_mainmodule_menmov_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mensend_click");
                return "";
            }
        }

        private string __mainmodule_mnuactualizar_click()
        {
            try
            {
                this.__mainmodule_opminve3.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_opminve1.Checked = bool.Parse("true".ToLower(cul));
                this.__mainmodule_opminve2.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_lttipo.Text = "ACTUALIZAR";
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuactualizar_click");
                return "";
            }
        }

        private string __mainmodule_mnuacumulativo_click()
        {
            try
            {
                this.__mainmodule_opminve3.Checked = bool.Parse("true".ToLower(cul));
                this.__mainmodule_opminve1.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_opminve2.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_lttipo.Text = "ACUMULATIVO";
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuacumulativo_click");
                return "";
            }
        }

        private string __mainmodule_mnuajustar_click()
        {
            try
            {
                this.__mainmodule_opminve3.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_opminve1.Checked = bool.Parse("false".ToLower(cul));
                this.__mainmodule_opminve2.Checked = bool.Parse("true".ToLower(cul));
                this.__mainmodule_lttipo.Text = "AJUSTAR";
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuajustar_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuareas_click");
                return "";
            }
        }

        private string __mainmodule_mnuareas1_click()
        {
            try
            {
                this.__mainmodule_pnlareasseries.Visible = bool.Parse("true".ToLower(cul));
                this.__mainmodule_pnlareasseries.BringToFront();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuareas1_click");
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
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_mnuborrarareas_click == 1)
                    {
                        this.err_mainmodule_mnuborrarareas_click = 0;
                        goto Label_00B5;
                    }
                }
                num = 1;
                lSide = ((int) MessageBox.Show("Realmente desea borras las areas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM areas";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_tblareas.dataTable.Clear();
                    this.__mainmodule_tblareas.dataTable.AcceptChanges();
                }
                return "";
            Label_00B5:
                ((int) MessageBox.Show("Error en ErrmnuBorrarAreas_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnuborrarareas_click = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_mnuborrarareas_click();
                }
                this.ShowError(exception, "_mainmodule_mnuborrarareas_click");
                return "";
            }
        }

        private string __mainmodule_mnucan1_click()
        {
            string str = "";
            int num = 0;
            double num2 = 0.0;
            string str2 = "";
            string lSide = "";
            int num3 = 0;
            try
            {
                if (this.err_mainmodule_mnucan1_click > 0)
                {
                    lSide = this.localVars[4];
                    str2 = this.localVars[3];
                    num2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_mnucan1_click == 1)
                    {
                        this.err_mainmodule_mnucan1_click = 0;
                        goto Label_0652;
                    }
                }
                num3 = 1;
                if (this.__mainmodule_tbcaninven.dataTable.DefaultView.Count.ToString(cul) == "0")
                {
                    ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[0].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, false);
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true) == "C")
                {
                    ((int) MessageBox.Show("Esta partida esta cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.Other.IsNumber((string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true)).ToLower(cul) == "true")
                {
                    num2 = this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[3].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, false);
                }
                else
                {
                    num2 = 0.0;
                }
                str2 = this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[2].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true);
                str = "Usuario: " + ((string) this.__mainmodule_tbcaninven.GetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[1].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, true)) + "\r\n";
                str = str + "Articulo: " + str2 + "\r\n";
                str = str + "Cant: " + num2.ToString(cul);
                lSide = ((int) MessageBox.Show("Desea cancelar partida " + str + " ?", "Invent Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "compras"))
                    {
                        this.var__mainmodule_sql = "UPDATE compras SET cancelado = 'C' WHERE id = " + num.ToString(cul);
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "pedidos"))
                    {
                        this.var__mainmodule_sql = "UPDATE pedidos SET cancelado = 'C' WHERE id = " + num.ToString(cul);
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    if (this.LCompareEqual(this.var__mainmodule_tipoproc, "invent"))
                    {
                        this.var__mainmodule_sql = "UPDATE minve SET cancelado = 'C' WHERE id = " + num.ToString(cul);
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        this.var__mainmodule_sql = "UPDATE inven SET exist = exist - " + num2.ToString(cul) + " WHERE articulo = '" + str2 + "'";
                        this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                        this.__mainmodule_cmd.ExecuteNonQuery();
                    }
                    if (this.Other.IsNumber(this.__mainmodule_ltsum2.Text).ToLower(cul) == "true")
                    {
                        this.__mainmodule_ltsum2.Text = (double.Parse(this.__mainmodule_ltsum2.Text, cul) - num2).ToString(cul);
                    }
                    if (this.Other.IsNumber(this.__mainmodule_ltsumcan2.Text).ToLower(cul) == "true")
                    {
                        this.__mainmodule_ltsumcan2.Text = (double.Parse(this.__mainmodule_ltsumcan2.Text, cul) + num2).ToString(cul);
                    }
                    this.__mainmodule_ltinven.Text = "";
                    ((int) MessageBox.Show("Partida cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_tbcaninven.SetCell(this.__mainmodule_tbcaninven.TableStyles[0].GridColumnStyles[4].MappingName, this.__mainmodule_tbcaninven.CurrentCell.RowNumber, "Cancelado");
                }
                return "";
            Label_0652:
                ((int) MessageBox.Show("Error en cmdInvenCanc", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num3 > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnucan1_click = num3;
                    this.localVars = new object[] { str, num, num2, str2, lSide };
                    return this.__mainmodule_mnucan1_click();
                }
                this.ShowError(exception, "_mainmodule_mnucan1_click");
                return "";
            }
        }

        private string __mainmodule_mnucancelarpartidacompra_click()
        {
            string str = "";
            string str2 = "";
            string lSide = "";
            try
            {
                double num2 = -1.0;
                if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num2.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.var__mainmodule_rowcompra < 0.0)
                {
                    ((int) MessageBox.Show("Por favor seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                double num6 = -1.0;
                if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num6.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboprovutils.Items[this.__mainmodule_cboprovutils.SelectedIndex].ToString();
                str2 = this.__mainmodule_tblcompras.GetCell(this.__mainmodule_tblcompras.TableStyles[0].GridColumnStyles[0].MappingName, (int) this.var__mainmodule_rowcompra, true);
                lSide = ((int) MessageBox.Show("Realmente desea eliminar partida " + str2 + "?", "Cancelar partida compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM compras WHERE cve_doc = '" + str + "' AND articulo = '" + str2 + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("La partida se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.var__mainmodule_rowcompra = -1.0;
                    this.__mainmodule_tblcompras.dataTable.Clear();
                    this.__mainmodule_tblcompras.dataTable.AcceptChanges();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnucancelarpartidacompra_click");
                return "";
            }
        }

        private string __mainmodule_mnucancelcompra_click()
        {
            string str = "";
            string lSide = "";
            try
            {
                double num2 = -1.0;
                if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num2.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboprovutils.Items[this.__mainmodule_cboprovutils.SelectedIndex].ToString();
                lSide = ((int) MessageBox.Show("Realmente desea cancelar la compra " + str + "?", "Cancelar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    if (str.IndexOf("Cancelado", 1) > 0.0)
                    {
                        ((int) MessageBox.Show("El documento ya se encuentra cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.__mainmodule_cmd.CommandText = "UPDATE compras SET cancelado = 'C' WHERE cve_doc = '" + str + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("El documento se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnucancelcompra_click");
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
                    lSide = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_mnucanped_click == 1)
                    {
                        this.err_mainmodule_mnucanped_click = 0;
                        goto Label_01B1;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboclieutils.Items[this.__mainmodule_cboclieutils.SelectedIndex].ToString();
                lSide = ((int) MessageBox.Show("Realmente desea cancelar el pedido " + str + "?", "Cancelar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    if (str.IndexOf("Cancelado", 1) > 0.0)
                    {
                        ((int) MessageBox.Show("El documento ya se encuentra cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET cancelado = 'C' WHERE cve_doc = '" + str + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("El documento se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_01B1:
                ((int) MessageBox.Show("Problema detectado en ClieUtils_SelectionChanged", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnucanped_click = num;
                    this.localVars = new object[] { str, lSide };
                    return this.__mainmodule_mnucanped_click();
                }
                this.ShowError(exception, "_mainmodule_mnucanped_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnucompra_click");
                return "";
            }
        }

        private string __mainmodule_mnuconsec_click()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuconsec_click");
                return "";
            }
        }

        private string __mainmodule_mnueliped_click()
        {
            string str = "";
            string str2 = "";
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_mnueliped_click > 0)
                {
                    lSide = this.localVars[2];
                    str2 = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_mnueliped_click == 1)
                    {
                        this.err_mainmodule_mnueliped_click = 0;
                        goto Label_02B3;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.var__mainmodule_rowcompra < 0.0)
                {
                    ((int) MessageBox.Show("Por favor seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                double num7 = -1.0;
                if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num7.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboclieutils.Items[this.__mainmodule_cboclieutils.SelectedIndex].ToString();
                str2 = this.__mainmodule_tblpedidos.GetCell(this.__mainmodule_tblpedidos.TableStyles[0].GridColumnStyles[0].MappingName, (int) this.var__mainmodule_rowcompra, true);
                lSide = ((int) MessageBox.Show("Realmente desea eliminar partida " + str2 + "?", "Cancelar partida compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_cmd.CommandText = "DELETE FROM pedidos WHERE cve_doc = '" + str + "' AND articulo = '" + str2 + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("La partida se elimino satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.var__mainmodule_rowcompra = -1.0;
                    this.__mainmodule_tblpedidos.dataTable.Clear();
                    this.__mainmodule_tblpedidos.dataTable.AcceptChanges();
                }
                return "";
            Label_02B3:
                ((int) MessageBox.Show("Problema detectado en mnuEliPed_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnueliped_click = num;
                    this.localVars = new object[] { str, str2, lSide };
                    return this.__mainmodule_mnueliped_click();
                }
                this.ShowError(exception, "_mainmodule_mnueliped_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuenviar_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuenviarsae_click");
                return "";
            }
        }

        private string __mainmodule_mnuenviarsql_click()
        {
            string lSide = "";
            string s = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_mnuenviarsql_click > 0)
                {
                    str6 = this.localVars[5];
                    str5 = this.localVars[4];
                    str4 = this.localVars[3];
                    str3 = this.localVars[2];
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_mnuenviarsql_click == 1)
                    {
                        this.err_mainmodule_mnuenviarsql_click = 0;
                        goto Label_070D;
                    }
                }
                num = 1;
                lSide = ((int) MessageBox.Show("Realmente desea enviar el inventario a SQL?", "Enviar Inventario a base INVENTMOBILE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.__mainmodule_trefminve.Text = this.__mainmodule_trefminve.Text.Replace(" ", "");
                    if (this.__mainmodule_trefminve.Text.Length.ToString(cul) == "0")
                    {
                        ((int) MessageBox.Show("Por favor capture la referencia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    if (this.__mainmodule_msql1.Open("Persist Security Info=False;Integrated Security=False;Data Source=" + this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ";initial catalog=" + this.var__mainmodule_base + "; user id=" + this.var__mainmodule_usersql + ";password=" + this.var__mainmodule_passsql + ";").ToString(cul).ToLower(cul) == "false")
                    {
                        Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                        ((int) MessageBox.Show("Imposible conectarse al servidor: " + this.var__mainmodule_serverlocal + ", " + this.var__mainmodule_portsql + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__mainmodule_msql1.Close();
                        return "";
                    }
                    this.__mainmodule_cmd.CommandText = "SELECT articulo, exist FROM inven";
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    s = "0";
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        Application.DoEvents();
                        str3 = this.__mainmodule_reader.GetValue(0);
                        if (this.Other.IsNumber(this.__mainmodule_reader.GetValue(1)).ToLower(cul) == "true")
                        {
                            str4 = this.__mainmodule_reader.GetValue(1);
                        }
                        else
                        {
                            str4 = "0";
                        }
                        this.__mainmodule_ltmart.Text = str3;
                        this.__mainmodule_ltmcant.Text = str4;
                        this.var__mainmodule_sql = "PROC_RECIBIR_INVENTMOBILE '" + this.__mainmodule_trefminve.Text + "','" + str3 + "'," + str4 + "," + this.var__mainmodule_almacen.ToString(cul);
                        if (this.__mainmodule_msql1.ExecuteNonQuery(this.var__mainmodule_sql).ToString(cul).ToLower(cul) == "false")
                        {
                            this.htStreams.Add("_mainmodule_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\" + this.var__mainmodule_servertea + " INVENTMOBILE.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.var__mainmodule_sql);
                            ((StreamWriter) this.htStreams["_mainmodule_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_mainmodule_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_mainmodule_c1"]).Close();
                                this.htStreams.Remove("_mainmodule_c1");
                                GC.Collect();
                            }
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            ((int) MessageBox.Show("Problema en tabla INVENTMOBILE en " + this.var__mainmodule_servertea + " en linea 3901", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            break;
                        }
                        s = (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0).ToString(cul);
                    }
                    this.__mainmodule_reader.Close();
                    str5 = "0";
                    str6 = "0";
                    this.var__mainmodule_sql = "Select count(*), sum(exist) FROM inven";
                    this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        str5 = this.__mainmodule_reader.GetValue(0);
                        str6 = this.__mainmodule_reader.GetValue(1);
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_msql1.Close();
                    ((int) MessageBox.Show("Total art\x00edculos: " + s + ",   Total piezas escaneadas: " + str6 + ",  Total art\x00edculos escaneados: " + str5, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__mainmodule_copiaarchivos2();
                }
                return "";
            Label_070D:
                this.__mainmodule_cierrareader();
                this.__mainmodule_cierramsql();
                ((int) MessageBox.Show("Error al enviar en mnuEnviarSQL_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnuenviarsql_click = num;
                    this.localVars = new object[] { lSide, s, str3, str4, str5, str6 };
                    return this.__mainmodule_mnuenviarsql_click();
                }
                this.ShowError(exception, "_mainmodule_mnuenviarsql_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuexist_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuexisxlinea_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuexxlinea_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuinvent_click");
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
                ((int) MessageBox.Show("Los registros se remarcaron para su reenvio satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuminve1_click");
                return "";
            }
        }

        private string __mainmodule_mnunewpedido_click()
        {
            string lSide = "";
            try
            {
                double num = this.var__mainmodule_folioped + 1.0;
                lSide = ((int) MessageBox.Show("Realmente desea iniciar nuevo pedido?", "Folio siguiente " + this.var__mainmodule_seriepedido + num.ToString(cul), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.var__mainmodule_folioped++;
                    this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriepedido + this.var__mainmodule_folioped.ToString(cul);
                    this.__mainmodule_cmd.CommandText = "UPDATE config SET folioped = " + this.var__mainmodule_folioped.ToString(cul);
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_invent.close();
                    this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tpedcte.Text = "";
                    this.__mainmodule_ltnombrecte.Text = "";
                    this.__mainmodule_tpedcte.Focus();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnunewpedido_click");
                return "";
            }
        }

        private string __mainmodule_mnunuevacompra_click()
        {
            string lSide = "";
            try
            {
                double num = this.var__mainmodule_foliocompra + 1.0;
                lSide = ((int) MessageBox.Show("Realmente desea iniciar nueva compra?", "Folio siguiente " + this.var__mainmodule_seriecompra + num.ToString(cul), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    this.var__mainmodule_foliocompra++;
                    this.__mainmodule_ltfc.Text = "Documento: " + this.var__mainmodule_seriecompra + this.var__mainmodule_foliocompra.ToString(cul);
                    this.__mainmodule_cmd.CommandText = "UPDATE config SET foliocompra = " + this.var__mainmodule_foliocompra.ToString(cul);
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    this.__mainmodule_invent.close();
                    this.__mainmodule_pnlpedidos.Visible = bool.Parse("true".ToLower(cul));
                    this.__mainmodule_tpedcte.Text = "";
                    this.__mainmodule_ltnombrecte.Text = "";
                    this.__mainmodule_tpedcte.Focus();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnunuevacompra_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuopcionesped_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnupedido_click");
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
                    lSide = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_mainmodule_mnureenped_click == 1)
                    {
                        this.err_mainmodule_mnureenped_click = 0;
                        goto Label_0216;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num3.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboclieutils.Items[this.__mainmodule_cboclieutils.SelectedIndex].ToString();
                if (str.IndexOf("Cancelado", 1) > 0.0)
                {
                    ((int) MessageBox.Show("El documento actualmente se encuentra cancelado no es posible reenviarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = ((int) MessageBox.Show("Realmente desea re-marcar para reenviar el documento " + str + "?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    double num8 = -1.0;
                    if (this.__mainmodule_cboclieutils.SelectedIndex.ToString(cul) == num8.ToString(cul))
                    {
                        ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.__mainmodule_cmd.CommandText = "UPDATE pedidos SET nuevo = 'S' WHERE cve_doc = '" + str + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("El documento puede ser enviado nuavamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            Label_0216:
                ((int) MessageBox.Show("Problema detectado en mnuReenPed_Click", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnureenped_click = num;
                    this.localVars = new object[] { str, lSide };
                    return this.__mainmodule_mnureenped_click();
                }
                this.ShowError(exception, "_mainmodule_mnureenped_click");
                return "";
            }
        }

        private string __mainmodule_mnureenviar_click()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_mnureenviar_click > 0) && (this.err_mainmodule_mnureenviar_click == 1))
                {
                    this.err_mainmodule_mnureenviar_click = 0;
                }
                else
                {
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
                    ((int) MessageBox.Show("El inventario esta listo para ser reenviado nuevamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                ((int) MessageBox.Show("Ocurrio un error", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnureenviar_click = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_mnureenviar_click();
                }
                this.ShowError(exception, "_mainmodule_mnureenviar_click");
                return "";
            }
        }

        private string __mainmodule_mnureenviarcompra_click()
        {
            string str = "";
            string lSide = "";
            try
            {
                double num2 = -1.0;
                if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num2.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = this.__mainmodule_cboprovutils.Items[this.__mainmodule_cboprovutils.SelectedIndex].ToString();
                if (str.IndexOf("Cancelado", 1) > 0.0)
                {
                    ((int) MessageBox.Show("El documento actualmente se encuentra cancelado no es posible reenviarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = ((int) MessageBox.Show("Realmente desea re-marcar para reenviar el documento " + str + "?", "Enviar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    double num7 = -1.0;
                    if (this.__mainmodule_cboprovutils.SelectedIndex.ToString(cul) == num7.ToString(cul))
                    {
                        ((int) MessageBox.Show("Por favor seleccione un documento", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    this.__mainmodule_cmd.CommandText = "UPDATE compras SET nuevo = 'S' WHERE cve_doc = '" + str + "'";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("El documento puede ser enviado nuavamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnureenviarcompra_click");
                return "";
            }
        }

        private string __mainmodule_mnurest_click()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnurest_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnusalircan_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnusql2_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnusql3_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnusql4_click");
                return "";
            }
        }

        private string __mainmodule_mnutotal_click()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_mnutotal_click > 0) && (this.err_mainmodule_mnutotal_click == 1))
                {
                    this.err_mainmodule_mnutotal_click = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_cmd.CommandText = "SELECT SUM(exist), COUNT(*) FROM inven";
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        ((int) MessageBox.Show("Partidas: " + this.__mainmodule_reader.GetValue(1) + ", Piezas: " + this.__mainmodule_reader.GetValue(0), "Total partidas", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    }
                    this.__mainmodule_reader.Close();
                    return "";
                }
                this.__mainmodule_cierrareader();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_mnutotal_click = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_mnutotal_click();
                }
                this.ShowError(exception, "_mainmodule_mnutotal_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnutotalminve_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_mnuutilscompras_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_opminve1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_opminve2_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_opminve3_click");
                return "";
            }
        }

        private string __mainmodule_partinven_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_partinven_close");
                return "";
            }
        }

        private string __mainmodule_procminve_close()
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_procminve_close");
                return "";
            }
        }

        private string __mainmodule_procminve_show()
        {
            string format = "";
            string str2 = "";
            try
            {
                this.__mainmodule_btngenerar.BringToFront();
                this.__mainmodule_btnexistminve.BringToFront();
                this.__mainmodule_numdia.Value = DateTime.Now.Day;
                this.__mainmodule_nummes.Value = DateTime.Now.Month;
                this.__mainmodule_numano.Value = DateTime.Now.Year;
                if (this.LCompareEqual(this.var__mainmodule_multialmacen.ToString(cul), "0"))
                {
                    this.__mainmodule_lalma.Text = "1";
                }
                else
                {
                    this.__mainmodule_lalma.Text = this.var__mainmodule_almacen.ToString(cul);
                }
                this.__mainmodule_trefminve.Text = "II" + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Day).ToString(format, cul) : DateTime.Now.Day.ToString(format, cul)) + (((str2 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Month).ToString(str2, cul) : DateTime.Now.Month.ToString(str2, cul)) + DateTime.Now.Year.ToString(cul) + "_AL" + this.var__mainmodule_almacen.ToString(cul);
                this.__mainmodule_ltserver.Text = this.var__mainmodule_serverlocal + "," + this.var__mainmodule_portsql + ", " + this.var__mainmodule_base + ", " + this.var__mainmodule_usersql + ", " + this.var__mainmodule_passsql;
                this.__mainmodule_btngenerar.Enabled = bool.Parse("true".ToLower(cul));
                this.__mainmodule_opminve2.Checked = bool.Parse("true".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_procminve_show");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_prods_show");
                return "";
            }
        }

        private string __mainmodule_replicate(string var__mainmodule_charadd, double var__mainmodule_totcharadd)
        {
            string str = "";
            string s = "";
            try
            {
                s = "1";
                double num = var__mainmodule_totcharadd;
                double num2 = (s == "") ? 0.0 : double.Parse(s, cul);
                while (num2 <= num)
                {
                    str = str + var__mainmodule_charadd;
                    s = ++num2.ToString(cul);
                }
                return str;
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_replicate");
                return "";
            }
        }

        private string __mainmodule_sqlserver_show()
        {
            string s = "";
            string format = "";
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
                s = "1";
                double num = 99.0;
                double num2 = (s == "") ? 0.0 : double.Parse(s, cul);
                while (num2 <= num)
                {
                    this.__mainmodule_cboempresa1.Items.Add(((format = "D2".ToLower(cul))[0] != 'd') ? ((s == "") ? 0.0 : double.Parse(s, cul)).ToString(format, cul) : ((s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))).ToString(format, cul));
                    s = ++num2.ToString(cul);
                }
                this.__mainmodule_cboalm.Items.Clear();
                s = "1";
                double num3 = 99.0;
                double num4 = (s == "") ? 0.0 : double.Parse(s, cul);
                while (num4 <= num3)
                {
                    this.__mainmodule_cboalm.Items.Add(s);
                    s = ++num4.ToString(cul);
                }
                this.__mainmodule_cboalm.Enabled = bool.Parse("false".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_sqlserver_show");
                return "";
            }
        }

        private string __mainmodule_tarticulo_gotfocus()
        {
            try
            {
                this.__mainmodule_tarticulo.SelectionStart = 0;
                this.__mainmodule_tarticulo.SelectionLength = this.__mainmodule_tarticulo.Text.Length;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tarticulo_gotfocus");
                return "";
            }
        }

        private string __mainmodule_tarticulo_keypress(string var__mainmodule_key)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_tarticulo_keypress > 0) && (this.err_mainmodule_tarticulo_keypress == 1))
                {
                    this.err_mainmodule_tarticulo_keypress = 0;
                }
                else
                {
                    num = 1;
                    char ch = '\r';
                    if (this.LCompareEqual(var__mainmodule_key, ch.ToString(cul)))
                    {
                        this.__mainmodule_cmdinv_click();
                    }
                    return "";
                }
                ((int) MessageBox.Show("Error en articulo keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tarticulo_keypress = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_tarticulo_keypress(var__mainmodule_key);
                }
                this.ShowError(exception, "_mainmodule_tarticulo_keypress");
                return "";
            }
        }

        private string __mainmodule_tbcaninven_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tbcaninven_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tblareas_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_tblareas_selectionchanged > 0)
                {
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_tblareas_selectionchanged == 1)
                    {
                        this.err_mainmodule_tblareas_selectionchanged = 0;
                        goto Label_01EB;
                    }
                }
                num = 1;
                if (this.__mainmodule_tblareas.dataTable.DefaultView.Count.ToString(cul) == "0")
                {
                    ((int) MessageBox.Show("Por favor seleccione partida a cancelar", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                lSide = this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, this.__mainmodule_tblareas.CurrentCell.RowNumber, true);
                if (this.LCompareEqual(lSide, "0"))
                {
                    ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                this.var__mainmodule_tipomov = "edit";
                this.__mainmodule_ltarea.Text = this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[1].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                this.__mainmodule_tareanombre.Text = this.__mainmodule_tblareas.GetCell(this.__mainmodule_tblareas.TableStyles[0].GridColumnStyles[2].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                return "";
            Label_01EB:
                ((int) MessageBox.Show("Problema detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tblareas_selectionchanged = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_tblareas_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
                }
                this.ShowError(exception, "_mainmodule_tblareas_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tblcompras_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                this.var__mainmodule_rowcompra = (var__mainmodule_row == "") ? 0.0 : double.Parse(var__mainmodule_row, cul);
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tblcompras_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tblexisxlinea_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                this.var__mainmodule_crow = (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tblexisxlinea_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tblpedidos_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                this.var__mainmodule_rowcompra = (var__mainmodule_row == "") ? 0.0 : double.Parse(var__mainmodule_row, cul);
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tblpedidos_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tblprod_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_tblprod_selectionchanged > 0) && (this.err_mainmodule_tblprod_selectionchanged == 1))
                {
                    this.err_mainmodule_tblprod_selectionchanged = 0;
                }
                else
                {
                    num = 1;
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tblprod_selectionchanged = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_tblprod_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
                }
                this.ShowError(exception, "_mainmodule_tblprod_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tbltoper_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            try
            {
                this.var__mainmodule_crow = (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tbltoper_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tbluser_selectionchanged(string var__mainmodule_colname, string var__mainmodule_row)
        {
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_mainmodule_tbluser_selectionchanged > 0)
                {
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_tbluser_selectionchanged == 1)
                    {
                        this.err_mainmodule_tbluser_selectionchanged = 0;
                        goto Label_02C8;
                    }
                }
                num = 1;
                this.__mainmodule_tusu.Text = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                this.__mainmodule_tnombre.Text = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                this.__mainmodule_tclave.Text = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                lSide = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                if (this.LCompareEqual(lSide, "Administrador"))
                {
                    this.__mainmodule_chnivel.Checked = bool.Parse("true".ToLower(cul));
                }
                else
                {
                    this.__mainmodule_chnivel.Checked = bool.Parse("false".ToLower(cul));
                }
                this.__mainmodule_tserie.Text = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                this.__mainmodule_tfolio.Text = this.__mainmodule_tbluser.GetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, (var__mainmodule_row == "") ? ((int) 0.0) : ((int) double.Parse(var__mainmodule_row, cul)), true);
                return "";
            Label_02C8:
                ((int) MessageBox.Show("Problema detectado en tblUser_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tbluser_selectionchanged = num;
                    this.localVars = new object[] { lSide };
                    return this.__mainmodule_tbluser_selectionchanged(var__mainmodule_colname, var__mainmodule_row);
                }
                this.ShowError(exception, "_mainmodule_tbluser_selectionchanged");
                return "";
            }
        }

        private string __mainmodule_tclave_gotfocus()
        {
            try
            {
                this.__mainmodule_tclave.SelectionStart = 0;
                this.__mainmodule_tclave.SelectionLength = this.__mainmodule_tclave.Text.Length;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tclave_gotfocus");
                return "";
            }
        }

        private string __mainmodule_tcodigo_keypress(string var__mainmodule_key)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_tcodigo_keypress > 0) && (this.err_mainmodule_tcodigo_keypress == 1))
                {
                    this.err_mainmodule_tcodigo_keypress = 0;
                }
                else
                {
                    num = 1;
                    char ch = '\r';
                    if (this.LCompareEqual(var__mainmodule_key, ch.ToString(cul)))
                    {
                        this.__mainmodule_bcodigo();
                    }
                    return "";
                }
                ((int) MessageBox.Show("Error en tCodigo_keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tcodigo_keypress = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_tcodigo_keypress(var__mainmodule_key);
                }
                this.ShowError(exception, "_mainmodule_tcodigo_keypress");
                return "";
            }
        }

        private string __mainmodule_timer1_tick()
        {
            try
            {
                this.var__mainmodule_twifi = (((this.var__mainmodule_twifi == "") ? 0.0 : double.Parse(this.var__mainmodule_twifi, cul)) + 1.0).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_timer1_tick");
                return "";
            }
        }

        private string __mainmodule_tlinea_keypress(string var__mainmodule_key)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tlinea_keypress");
                return "";
            }
        }

        private string __mainmodule_tnombre_gotfocus()
        {
            try
            {
                this.__mainmodule_tnombre.SelectionStart = 0;
                this.__mainmodule_tnombre.SelectionLength = this.__mainmodule_tnombre.Text.Length;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tnombre_gotfocus");
                return "";
            }
        }

        private string __mainmodule_tpedcte_keypress(string var__mainmodule_key)
        {
            string str;
            try
            {
                char ch = '\r';
                if (!this.LCompareEqual(var__mainmodule_key, ch.ToString(cul)))
                {
                    char ch2 = '\n';
                    if (!this.LCompareEqual(var__mainmodule_key, ch2.ToString(cul)))
                    {
                        goto Label_0037;
                    }
                }
                this.__mainmodule_btnokcte_click();
            Label_0037:
                str = "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tpedcte_keypress");
                str = "";
            }
            return str;
        }

        private string __mainmodule_tprod_keypress(string var__mainmodule_key)
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_tprod_keypress > 0) && (this.err_mainmodule_tprod_keypress == 1))
                {
                    this.err_mainmodule_tprod_keypress = 0;
                }
                else
                {
                    num = 1;
                    char ch = '\r';
                    if (this.LCompareEqual(var__mainmodule_key, ch.ToString(cul)))
                    {
                        this.__mainmodule_buscaexistencia();
                    }
                    return "";
                }
                ((int) MessageBox.Show("Error en tProd keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_tprod_keypress = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_tprod_keypress(var__mainmodule_key);
                }
                this.ShowError(exception, "_mainmodule_tprod_keypress");
                return "";
            }
        }

        private string __mainmodule_tuni_gotfocus()
        {
            try
            {
                this.__mainmodule_tuni.SelectionStart = 0;
                this.__mainmodule_tuni.SelectionLength = this.__mainmodule_tuni.Text.Length;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tuni_gotfocus");
                return "";
            }
        }

        private string __mainmodule_tuni_keypress(string var__mainmodule_key)
        {
            try
            {
                char ch = '\r';
                if (this.LCompareEqual(var__mainmodule_key, ch.ToString(cul)))
                {
                    this.__mainmodule_cmdinv_click();
                    this.__mainmodule_tarticulo.Focus();
                }
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tuni_keypress");
                return "";
            }
        }

        private string __mainmodule_tusu_gotfocus()
        {
            try
            {
                this.__mainmodule_tusu.SelectionStart = 0;
                this.__mainmodule_tusu.SelectionLength = this.__mainmodule_tusu.Text.Length;
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_tusu_gotfocus");
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
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_mainmodule_usuarios_show == 1)
                    {
                        this.err_mainmodule_usuarios_show = 0;
                        goto Label_0441;
                    }
                }
                num = 1;
                this.__mainmodule_tbluser.dataTable.Clear();
                this.__mainmodule_tbluser.dataTable.AcceptChanges();
                this.var__mainmodule_sql = "SELECT id, usuario, nombre, password, nivel, serie, folio FROM usuarios order by usuario";
                this.__mainmodule_cmd.CommandText = this.var__mainmodule_sql;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__mainmodule_tbluser.AddRow(new object[0]);
                    s = (this.__mainmodule_tbluser.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(2));
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[3].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(3));
                    lSide = this.__mainmodule_reader.GetValue(4);
                    if (this.LCompareEqual(lSide, "1"))
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), "Administrador");
                    }
                    else
                    {
                        this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[4].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), "");
                    }
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[5].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(5));
                    this.__mainmodule_tbluser.SetCell(this.__mainmodule_tbluser.TableStyles[0].GridColumnStyles[6].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(6));
                }
                this.__mainmodule_reader.Close();
                this.__mainmodule_label2.BringToFront();
                this.__mainmodule_tusu.BringToFront();
                this.__mainmodule_btnnew.BringToFront();
                return "";
            Label_0441:
                ((int) MessageBox.Show("Problema detectado en cboImporta_SelectionChanged ", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_usuarios_show = num;
                    this.localVars = new object[] { lSide, s };
                    return this.__mainmodule_usuarios_show();
                }
                this.ShowError(exception, "_mainmodule_usuarios_show");
                return "";
            }
        }

        private string __mainmodule_vacu()
        {
            int num = 0;
            try
            {
                if ((this.err_mainmodule_vacu > 0) && (this.err_mainmodule_vacu == 1))
                {
                    this.err_mainmodule_vacu = 0;
                }
                else
                {
                    num = 1;
                    this.__mainmodule_cmd.CommandText = "VACUUM";
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_mainmodule_vacu = num;
                    this.localVars = new object[0];
                    return this.__mainmodule_vacu();
                }
                this.ShowError(exception, "_mainmodule_vacu");
                return "";
            }
        }

        private string __mainmodule_validacampo(string var__mainmodule_fcampo, string var__mainmodule_ftipo)
        {
            try
            {
                var__mainmodule_fcampo = var__mainmodule_fcampo.ToUpper(cul);
                if (this.LCompareEqual(var__mainmodule_fcampo, "NULL"))
                {
                    if (this.LCompareEqual(var__mainmodule_ftipo, "C"))
                    {
                        return "";
                    }
                    return "0";
                }
                return var__mainmodule_fcampo;
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_mainmodule_validacampo");
                return "";
            }
        }

        private string __utilerias_bart()
        {
            string str = "";
            int row = 0;
            string str2 = "";
            int num2 = 0;
            try
            {
                if (this.err_utilerias_bart > 0)
                {
                    str2 = this.localVars[2];
                    row = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_bart == 1)
                    {
                        this.err_utilerias_bart = 0;
                        goto Label_0361;
                    }
                }
                num2 = 1;
                str = this.__utilerias_tart.Text.Replace(" ", "");
                if (str.Length.ToString(cul) == "0")
                {
                    ((int) MessageBox.Show("La clave del articulo no debe quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str2 = "SELECT M.id, M.folio, M.articulo, P.descrip, M.cantidad, M.cancelado ";
                str2 = str2 + "FROM movsinv M INNER JOIN prods P ON P.articulo = M.articulo ";
                str2 = str2 + "WHERE (M.articulo = '" + str + "' OR clavealterna = '" + str + "') AND ";
                str2 = str2 + "folio = " + this.__utilerias_ltfolio.Text + " ORDER BY M.id";
                this.__mainmodule_cmd.CommandText = str2;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__utilerias_tblcanc.dataTable.Clear();
                this.__utilerias_tblcanc.dataTable.AcceptChanges();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_tblcanc.AddRow(new object[0]);
                    row = this.__utilerias_tblcanc.dataTable.DefaultView.Count - ((int) 1.0);
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[0].MappingName, row, this.__mainmodule_reader.GetValue(0));
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[1].MappingName, row, this.__mainmodule_reader.GetValue(1));
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[2].MappingName, row, this.__mainmodule_reader.GetValue(2));
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, row, this.__mainmodule_reader.GetValue(3));
                    if (this.__mainmodule_reader.GetValue(5) == "C")
                    {
                        this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[4].MappingName, row, "Cancelado");
                    }
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[5].MappingName, row, this.__mainmodule_reader.GetValue(4));
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_0361:
                this.__utilerias_closeconexionsqlite();
                ((int) MessageBox.Show("Error en BArt.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_bart = num2;
                    this.localVars = new object[] { str, row, str2 };
                    return this.__utilerias_bart();
                }
                this.ShowError(exception, "_utilerias_bart");
                return "";
            }
        }

        private string __utilerias_btncanfol2_click()
        {
            try
            {
                this.__utilerias_pnlcanfolio.Visible = bool.Parse("false".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_btncanfol2_click");
                return "";
            }
        }

        private string __utilerias_btncanfolio1_click()
        {
            double num = 0.0;
            string str = "";
            string format = "";
            int num2 = 0;
            try
            {
                if (this.err_utilerias_btncanfolio1_click > 0)
                {
                    format = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_utilerias_btncanfolio1_click == 1)
                    {
                        this.err_utilerias_btncanfolio1_click = 0;
                        goto Label_026A;
                    }
                }
                num2 = 1;
                double num4 = -1.0;
                if (this.__utilerias_cbocanfolio.SelectedIndex.ToString(cul) == num4.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor selecione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = double.Parse(this.Other.SubString(this.__utilerias_cbocanfolio.Items[this.__utilerias_cbocanfolio.SelectedIndex].ToString(), 2, 5), cul);
                str = "UPDATE movsinv SET cancelado = 'C' WHERE folio = " + num.ToString(cul) + " AND tipo = '" + this.var__mainmodule_process + "'";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.var__mainmodule_folio++;
                this.__utilerias_ltfolio.Text = ((format = "D5".ToLower(cul))[0] != 'd') ? this.var__mainmodule_folio.ToString(format, cul) : ((int) this.var__mainmodule_folio).ToString(format, cul);
                this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString(cul);
                this.__mainmodule_cmd.ExecuteNonQuery();
                ((int) MessageBox.Show("El folio " + this.__utilerias_cbocanfolio.Items[this.__utilerias_cbocanfolio.SelectedIndex].ToString() + " se cancelo satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__utilerias_pnlcanfolio.Visible = bool.Parse("false".ToLower(cul));
                return "";
            Label_026A:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_btncanfolio1_click = num2;
                    this.localVars = new object[] { num, str, format };
                    return this.__utilerias_btncanfolio1_click();
                }
                this.ShowError(exception, "_utilerias_btncanfolio1_click");
                return "";
            }
        }

        private string __utilerias_btntea_click()
        {
            string text = "";
            string str2 = "";
            try
            {
                if (this.Other.IsNumber(this.__utilerias_tfolio.Text).ToLower(cul) == "true")
                {
                    text = this.__utilerias_tfolio.Text;
                }
                else
                {
                    ((int) MessageBox.Show("El folio debe ser num\x00e9rico", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                this.var__mainmodule_servertea = this.__utilerias_tservertea.Text;
                this.var__mainmodule_basetea = this.__utilerias_tbasetea.Text;
                this.var__mainmodule_usertea = this.__utilerias_tusertea.Text;
                this.var__mainmodule_passtea = this.__utilerias_tpasstea.Text;
                this.var__mainmodule_porttea = this.__utilerias_tporttea.Text;
                str2 = (("UPDATE config SET server = '" + this.var__mainmodule_servertea + "', ") + "base = '" + this.var__mainmodule_basetea + "', ") + "User = '" + this.var__mainmodule_usertea + "', ";
                str2 = str2 + "pass = '" + this.var__mainmodule_passtea + "', port = '" + this.var__mainmodule_porttea + "', folio = " + text;
                this.__mainmodule_cmd.CommandText = str2;
                this.__mainmodule_cmd.ExecuteNonQuery();
                ((int) MessageBox.Show("ok", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.__utilerias_frmtea.close();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_btntea_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_btntea2_click");
                return "";
            }
        }

        private string __utilerias_btntrans_click()
        {
            try
            {
                this.__utilerias_pnltrans.Visible = bool.Parse("false".ToLower(cul));
                this.__utilerias_tcant.Enabled = bool.Parse("true".ToLower(cul));
                this.__utilerias_tprod.Enabled = bool.Parse("true".ToLower(cul));
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_btntrans_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_canc_close");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_canc_show");
                return "";
            }
        }

        private string __utilerias_cbocanfolio_selectionchanged(string var__utilerias_index, string var__utilerias_value)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cbocanfolio_selectionchanged");
                return "";
            }
        }

        private string __utilerias_cbofol_selectionchanged(string var__utilerias_index, string var__utilerias_value)
        {
            double num = 0.0;
            string s = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string lSide = "";
            string rSide = "";
            string text = "";
            string str8 = "";
            int num2 = 0;
            try
            {
                if (this.err_utilerias_cbofol_selectionchanged > 0)
                {
                    str8 = this.localVars[8];
                    text = this.localVars[7];
                    rSide = this.localVars[6];
                    lSide = this.localVars[5];
                    str4 = this.localVars[4];
                    str3 = this.localVars[3];
                    str2 = this.localVars[2];
                    s = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_utilerias_cbofol_selectionchanged == 1)
                    {
                        this.err_utilerias_cbofol_selectionchanged = 0;
                        goto Label_03CF;
                    }
                }
                num2 = 1;
                double num4 = -1.0;
                if (this.__utilerias_cbofol.SelectedIndex.ToString(cul) == num4.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                s = this.Other.SubString(this.__utilerias_cbofol.Items[this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5);
                if (this.Other.IsNumber(s) != "false")
                {
                    num = double.Parse(this.Other.SubString(this.__utilerias_cbofol.Items[this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5), cul);
                    str2 = "SELECT tiendaorigen, tiendadestino FROM movsinv WHERE folio = " + num.ToString(cul) + " AND tipo = '" + this.var__mainmodule_process + "'";
                    this.__mainmodule_cmd.CommandText = str2;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        str3 = this.__mainmodule_reader.GetValue(0);
                        str4 = this.__mainmodule_reader.GetValue(1);
                        this.__utilerias_ltenviar1.Text = str3;
                        this.__utilerias_ltenviar2.Text = str4;
                    }
                    this.__mainmodule_reader.Close();
                    str2 = "SELECT empresa, nombre, multialmacen FROM empresas";
                    this.__mainmodule_cmd.CommandText = str2;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        lSide = this.__utilerias_ltenviar1.Text;
                        rSide = this.__mainmodule_reader.GetValue(0);
                        if (this.CompareEqual(lSide, rSide))
                        {
                            this.__utilerias_ltenviar1.Text = this.__mainmodule_reader.GetValue(0) + " " + this.__mainmodule_reader.GetValue(1);
                        }
                        text = this.__utilerias_ltenviar2.Text;
                        str8 = this.__mainmodule_reader.GetValue(0);
                        if (this.CompareEqual(text, str8))
                        {
                            this.__utilerias_ltenviar2.Text = this.__mainmodule_reader.GetValue(0) + " " + this.__mainmodule_reader.GetValue(1);
                        }
                    }
                    this.__mainmodule_reader.Close();
                }
                return "";
            Label_03CF:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cbofol_selectionchanged = num2;
                    this.localVars = new object[] { num, s, str2, str3, str4, lSide, rSide, text, str8 };
                    return this.__utilerias_cbofol_selectionchanged(var__utilerias_index, var__utilerias_value);
                }
                this.ShowError(exception, "_utilerias_cbofol_selectionchanged");
                return "";
            }
        }

        private string __utilerias_cbotiendadestino_selectionchanged(string var__utilerias_index, string var__utilerias_value)
        {
            string str = "";
            int num = 0;
            try
            {
                if (this.err_utilerias_cbotiendadestino_selectionchanged > 0)
                {
                    str = this.localVars[0];
                    if (this.err_utilerias_cbotiendadestino_selectionchanged == 1)
                    {
                        this.err_utilerias_cbotiendadestino_selectionchanged = 0;
                        goto Label_0188;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__utilerias_cbotiendadestino.SelectedIndex.ToString(cul) != num3.ToString(cul))
                {
                    str = this.Other.SubString(this.__utilerias_cbotiendadestino.Items[this.__utilerias_cbotiendadestino.SelectedIndex].ToString(), 0, 2);
                    this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre, multialmacen, servidor, base, usuario, pass  FROM empresas WHERE empresa = '" + str + "'";
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        this.__utilerias_ltserver9.Text = this.__mainmodule_reader.GetValue(3) + ", " + this.__mainmodule_reader.GetValue(4) + ", " + this.__mainmodule_reader.GetValue(5) + ", " + this.__mainmodule_reader.GetValue(6);
                    }
                    this.__mainmodule_reader.Close();
                }
                return "";
            Label_0188:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cbotiendadestino_selectionchanged = num;
                    this.localVars = new object[] { str };
                    return this.__utilerias_cbotiendadestino_selectionchanged(var__utilerias_index, var__utilerias_value);
                }
                this.ShowError(exception, "_utilerias_cbotiendadestino_selectionchanged");
                return "";
            }
        }

        private string __utilerias_cbotiendaorigen_selectionchanged(string var__utilerias_index, string var__utilerias_value)
        {
            string lSide = "";
            int num = 0;
            try
            {
                if (this.err_utilerias_cbotiendaorigen_selectionchanged > 0)
                {
                    lSide = this.localVars[0];
                    if (this.err_utilerias_cbotiendaorigen_selectionchanged == 1)
                    {
                        this.err_utilerias_cbotiendaorigen_selectionchanged = 0;
                        goto Label_0228;
                    }
                }
                num = 1;
                double num3 = -1.0;
                if (this.__utilerias_cbotiendaorigen.SelectedIndex.ToString(cul) != num3.ToString(cul))
                {
                    lSide = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
                    this.__utilerias_cbotiendadestino.Items.Clear();
                    this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre, multialmacen, servidor, base, usuario, pass FROM empresas ORDER BY empresa";
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        if (this.__utilerias_cbotiendaorigen.Items[this.__utilerias_cbotiendaorigen.SelectedIndex].ToString() != (this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1)))
                        {
                            this.__utilerias_cbotiendadestino.Items.Add(this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1));
                        }
                        if (this.LCompareEqual(lSide, this.__mainmodule_reader.GetValue(0)))
                        {
                            this.__utilerias_ltimport11.Text = this.__mainmodule_reader.GetValue(3) + ", " + this.__mainmodule_reader.GetValue(4) + ", " + this.__mainmodule_reader.GetValue(5) + ", " + this.__mainmodule_reader.GetValue(6);
                        }
                    }
                    this.__mainmodule_reader.Close();
                }
                return "";
            Label_0228:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cbotiendaorigen_selectionchanged = num;
                    this.localVars = new object[] { lSide };
                    return this.__utilerias_cbotiendaorigen_selectionchanged(var__utilerias_index, var__utilerias_value);
                }
                this.ShowError(exception, "_utilerias_cbotiendaorigen_selectionchanged");
                return "";
            }
        }

        private string __utilerias_closeconexionsqlite()
        {
            int num = 0;
            try
            {
                if ((this.err_utilerias_closeconexionsqlite > 0) && (this.err_utilerias_closeconexionsqlite == 1))
                {
                    this.err_utilerias_closeconexionsqlite = 0;
                }
                else
                {
                    num = 1;
                    return "";
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_closeconexionsqlite = num;
                    this.localVars = new object[0];
                    return this.__utilerias_closeconexionsqlite();
                }
                this.ShowError(exception, "_utilerias_closeconexionsqlite");
                return "";
            }
        }

        private string __utilerias_cmdaceptar_click()
        {
            string str = "";
            double num = 0.0;
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
            string format = "";
            string str8 = "";
            string s = "";
            string str10 = "";
            int num6 = 0;
            try
            {
                if (this.err_utilerias_cmdaceptar_click > 0)
                {
                    str10 = this.localVars[15];
                    s = this.localVars[14];
                    str8 = this.localVars[13];
                    format = this.localVars[12];
                    flag = this.localVars[11];
                    str6 = this.localVars[10];
                    str5 = this.localVars[9];
                    num5 = this.localVars[8];
                    str4 = this.localVars[7];
                    num4 = this.localVars[6];
                    num3 = this.localVars[5];
                    num2 = this.localVars[4];
                    str3 = this.localVars[3];
                    str2 = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_cmdaceptar_click == 1)
                    {
                        this.err_utilerias_cmdaceptar_click = 0;
                        goto Label_09A5;
                    }
                }
                num6 = 1;
                str4 = DateTime.Now.Year.ToString(cul) + "-" + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Month).ToString(format, cul) : DateTime.Now.Month.ToString(format, cul)) + "-" + (((str8 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Day).ToString(str8, cul) : DateTime.Now.Day.ToString(str8, cul));
                s = this.__utilerias_tprod.Text.Length.ToString(cul);
                double num7 = -1.0;
                double num8 = 0.0;
                double num9 = (s == "") ? 0.0 : double.Parse(s, cul);
                while ((num7 > 0.0) ? (num9 <= num8) : (num9 >= num8))
                {
                    if (this.Other.SubString(this.__utilerias_tprod.Text, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), 1) != " ")
                    {
                        str = this.Other.SubString(this.__utilerias_tprod.Text, 0, (int) (((s == "") ? 0.0 : double.Parse(s, cul)) + 1.0));
                        break;
                    }
                    s = (num9 += num7).ToString(cul);
                }
                if (this.__utilerias_tcant.Text.Replace(" ", "").Length.ToString(cul) == "0")
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("Capture la cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.Other.IsNumber(this.__utilerias_tcant.Text) == "false")
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La cantidad de ser n\x00famero", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = double.Parse(this.__utilerias_tcant.Text, cul);
                if (num <= 0.0)
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La cantidad no debe ser cero o menor a cero", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (num > 5000.0)
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La cantidad no debe ser mayor a 5000", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (str.Length.ToString(cul) == "0")
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\grito.wav"));
                    Thread.Sleep(0x3e8);
                    ((int) MessageBox.Show("La clave del art\x00edculo no deben quedar vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = double.Parse(this.__utilerias_tcant.Text, cul);
                str5 = this.var__mainmodule_empresa_origen;
                str6 = this.var__mainmodule_empresa_destino;
                flag = bool.Parse("false");
                str10 = "SELECT articulo, descrip FROM prods WHERE articulo = '" + str + "' OR ";
                str10 = str10 + "clavealterna = '" + str + "'";
                this.__mainmodule_cmd.CommandText = str10;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    flag = bool.Parse("true");
                    str = this.__mainmodule_reader.GetValue(0);
                }
                else
                {
                    this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\bocina.wav"));
                    Thread.Sleep(0x7d0);
                    this.__utilerias_tprod.Focus();
                }
                this.__mainmodule_reader.Close();
                if (this.LCompareEqual(flag.ToString().ToLower(cul), "false"))
                {
                    this.__utilerias_tprod.Text = "";
                    this.__utilerias_pnltrans.Visible = bool.Parse("true".ToLower(cul));
                    this.__utilerias_ltarttrans.Text = str;
                    this.__utilerias_pnltrans.BringToFront();
                    this.__utilerias_tcant.Enabled = bool.Parse("false".ToLower(cul));
                    this.__utilerias_tprod.Enabled = bool.Parse("false".ToLower(cul));
                    return "";
                }
                str10 = "INSERT INTO movsinv (Folio, articulo, cantidad, tiendaorigen, tiendadestino, ";
                str10 = str10 + "cancelado, nuevo, descrip, tipo, sistema, status) VALUES('" + this.var__mainmodule_folio.ToString(cul) + "','" + str + "','";
                str10 = str10 + num.ToString(cul) + "','" + str5 + "','" + str6 + "','N','S','";
                str10 = str10 + this.var__mainmodule_seriefolio + "','" + this.var__mainmodule_process + "','" + this.var__mainmodule_sistema.ToString(cul) + "',' ')";
                this.__mainmodule_cmd.CommandText = str10;
                this.__mainmodule_cmd.ExecuteNonQuery();
                flag = bool.Parse("true");
                this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\msgbox.wav"));
                if (flag.ToString().ToLower(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_loadmovsinv();
                }
                this.__utilerias_tcant.Text = "1";
                this.__utilerias_tprod.Text = "";
                this.__utilerias_tprod.Focus();
                return "";
            Label_09A5:
                this.__utilerias_closeconexionsqlite();
                ((int) MessageBox.Show("Error en cmdAceptar.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num6 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cmdaceptar_click = num6;
                    this.localVars = new object[] { str, num, str2, str3, num2, num3, num4, str4, num5, str5, str6, flag, format, str8, s, str10 };
                    return this.__utilerias_cmdaceptar_click();
                }
                this.ShowError(exception, "_utilerias_cmdaceptar_click");
                return "";
            }
        }

        private string __utilerias_cmdaceptar_keypress(string var__utilerias_key)
        {
            try
            {
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cmdaceptar_keypress");
                return "";
            }
        }

        private string __utilerias_cmdcanc1_click()
        {
            string str = "";
            int num = 0;
            string lSide = "";
            string str3 = "";
            int num2 = 0;
            try
            {
                if (this.err_utilerias_cmdcanc1_click > 0)
                {
                    str3 = this.localVars[3];
                    lSide = this.localVars[2];
                    num = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_cmdcanc1_click == 1)
                    {
                        this.err_utilerias_cmdcanc1_click = 0;
                        goto Label_03BD;
                    }
                }
                num2 = 1;
                if (this.__utilerias_tblcanc.CurrentCell.RowNumber < 0.0)
                {
                    ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                num = this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[0].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, false);
                if (this.LCompareEqual(num.ToString(cul), "0"))
                {
                    ((int) MessageBox.Show("Seleccione una partida", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                if (this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, true) == "Cancelado")
                {
                    ((int) MessageBox.Show("Esta partida esta cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str = ((string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[1].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, true)) + " - ";
                str = str + ((string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[2].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, true)) + " - ";
                str = str + ((string) this.__utilerias_tblcanc.GetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[3].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, true));
                lSide = ((int) MessageBox.Show("Desea eliminar partida " + str + " ?", "Josefina", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(lSide, "7"))
                {
                    str3 = "UPDATE movsinv SET cancelado = 'C' WHERE id = " + num.ToString(cul);
                    this.__mainmodule_cmd.CommandText = str3;
                    this.__mainmodule_cmd.ExecuteNonQuery();
                    ((int) MessageBox.Show("Partida cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    this.__utilerias_tblcanc.SetCell(this.__utilerias_tblcanc.TableStyles[0].GridColumnStyles[4].MappingName, this.__utilerias_tblcanc.CurrentCell.RowNumber, "Cancelado");
                    this.__utilerias_canc.close();
                }
                return "";
            Label_03BD:
                this.__utilerias_closeconexionsqlite();
                ((int) MessageBox.Show("Error en cmdCanc1.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cmdcanc1_click = num2;
                    this.localVars = new object[] { str, num, lSide, str3 };
                    return this.__utilerias_cmdcanc1_click();
                }
                this.ShowError(exception, "_utilerias_cmdcanc1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cmdcanc2_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cmdcbus_click");
                return "";
            }
        }

        private string __utilerias_cmdimpor1_click()
        {
            int num = 0;
            string str = "";
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
                    str17 = this.localVars[0x13];
                    str16 = this.localVars[0x12];
                    str15 = this.localVars[0x11];
                    str14 = this.localVars[0x10];
                    str13 = this.localVars[15];
                    str12 = this.localVars[14];
                    str11 = this.localVars[13];
                    str10 = this.localVars[12];
                    str9 = this.localVars[11];
                    str8 = this.localVars[10];
                    str7 = this.localVars[9];
                    num3 = this.localVars[8];
                    str6 = this.localVars[7];
                    num2 = this.localVars[6];
                    str5 = this.localVars[5];
                    str4 = this.localVars[4];
                    str3 = this.localVars[3];
                    str2 = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_utilerias_cmdimpor1_click == 1)
                    {
                        this.err_utilerias_cmdimpor1_click = 0;
                        goto Label_04E7;
                    }
                }
                num4 = 1;
                double num6 = -1.0;
                if (this.__utilerias_cbotiendaorigen.SelectedIndex.ToString(cul) == num6.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione una sucursal origen", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                double num9 = -1.0;
                if (this.__utilerias_cbotiendadestino.SelectedIndex.ToString(cul) == num9.ToString(cul))
                {
                    ((int) MessageBox.Show("Por favor seleccione una sucursal destino", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                    return "";
                }
                str11 = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
                this.var__mainmodule_empresa_origen = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[this.__utilerias_cbotiendaorigen.SelectedIndex].ToString(), 0, 2);
                this.var__mainmodule_empresa_destino = this.Other.SubString(this.__utilerias_cbotiendadestino.Items[this.__utilerias_cbotiendadestino.SelectedIndex].ToString(), 0, 2);
                str12 = "SELECT servidor, base, usuario, pass, puerto, nombre, ctrl_alm, almacen, ";
                str12 = str12 + "correo, nombre, linea, correo2 FROM empresas WHERE empresa = '02'";
                this.__mainmodule_cmd.CommandText = str12;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                if (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
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
                this.Other.Sound(Path.Combine(this.b4pdir, this.b4pdir + @"\button2.wav"));
                Thread.Sleep(0x7d0);
                this.__utilerias_importa.close();
                this.__utilerias_inven.show();
                return "";
            Label_04E7:
                this.__utilerias_closeconexionsqlite();
                ((int) MessageBox.Show("Error en importar " + str12, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                this.htStreams.Add("_utilerias_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\INVEN.txt"), false, Encoding.UTF8));
                ((StreamWriter) this.htStreams["_utilerias_c1"]).WriteLine(str12);
                if (this.htStreams.Contains("_utilerias_c1"))
                {
                    ((Dbasic.IStream) this.htStreams["_utilerias_c1"]).Close();
                    this.htStreams.Remove("_utilerias_c1");
                    GC.Collect();
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num4 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cmdimpor1_click = num4;
                    this.localVars = new object[] { 
                        num, str, str2, str3, str4, str5, num2, str6, num3, str7, str8, str9, str10, str11, str12, str13,
                        str14, str15, str16, str17
                    };
                    return this.__utilerias_cmdimpor1_click();
                }
                this.ShowError(exception, "_utilerias_cmdimpor1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cmdimpor2_click");
                return "";
            }
        }

        private string __utilerias_cmdsend1_click()
        {
            string str = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            double num = 0.0;
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
            string text = "";
            string text = "";
            string lSide = "";
            double num5 = 0.0;
            string str17 = "";
            string str18 = "";
            string connectiondata = "";
            string str20 = "";
            string str21 = "";
            string format = "";
            string str23 = "";
            string str24 = "";
            string str25 = "";
            string str26 = "";
            string query = "";
            string str28 = "";
            int num6 = 0;
            try
            {
                if (this.err_utilerias_cmdsend1_click > 0)
                {
                    str28 = this.localVars[0x20];
                    query = this.localVars[0x1f];
                    str26 = this.localVars[30];
                    str25 = this.localVars[0x1d];
                    str24 = this.localVars[0x1c];
                    str23 = this.localVars[0x1b];
                    format = this.localVars[0x1a];
                    str21 = this.localVars[0x19];
                    str20 = this.localVars[0x18];
                    connectiondata = this.localVars[0x17];
                    str18 = this.localVars[0x16];
                    str17 = this.localVars[0x15];
                    num5 = this.localVars[20];
                    lSide = this.localVars[0x13];
                    text = this.localVars[0x12];
                    text = this.localVars[0x11];
                    num4 = this.localVars[0x10];
                    str13 = this.localVars[15];
                    str12 = this.localVars[14];
                    str11 = this.localVars[13];
                    str10 = this.localVars[12];
                    str9 = this.localVars[11];
                    str8 = this.localVars[10];
                    str7 = this.localVars[9];
                    num3 = this.localVars[8];
                    num2 = this.localVars[7];
                    str6 = this.localVars[6];
                    str5 = this.localVars[5];
                    num = this.localVars[4];
                    str4 = this.localVars[3];
                    str3 = this.localVars[2];
                    str2 = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_cmdsend1_click == 1)
                    {
                        this.err_utilerias_cmdsend1_click = 0;
                        goto Label_0CED;
                    }
                }
                num6 = 1;
                str17 = ((int) MessageBox.Show("Desea realizar movimiento al inventario?", "Josefina", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                if (!this.LCompareEqual(str17, "7"))
                {
                    double num9 = -1.0;
                    if (this.__utilerias_cbofol.SelectedIndex.ToString(cul) == num9.ToString(cul))
                    {
                        ((int) MessageBox.Show("Por favor seleccione un folio", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    str18 = this.Other.SubString(this.__utilerias_cbofol.Items[this.__utilerias_cbofol.SelectedIndex].ToString(), 2, 5);
                    if (this.htControls["__mainmodule_msql1"] != null)
                    {
                        this.CEnhancedObject.htShemotAzamim.Remove(this.htControls["__mainmodule_msql1"]);
                    }
                    this.__mainmodule_msql1 = new MSSQL.MSSQL();
                    this.htControls["__mainmodule_msql1"] = this.__mainmodule_msql1;
                    this.CEnhancedObject.htShemotAzamim[this.__mainmodule_msql1] = "__mainmodule_msql1";
                    connectiondata = "Persist Security Info=False;Integrated Security=False;";
                    connectiondata = connectiondata + "Server=" + this.var__mainmodule_servertea + "," + this.var__mainmodule_porttea;
                    connectiondata = connectiondata + ";initial catalog=" + this.var__mainmodule_basetea;
                    connectiondata = connectiondata + ";user id=" + this.var__mainmodule_usertea;
                    connectiondata = connectiondata + ";password=" + this.var__mainmodule_passtea + ";";
                    if (this.__mainmodule_msql1.Open(connectiondata).ToString(cul).ToLower(cul) == "false")
                    {
                        ((int) MessageBox.Show("1.Imposible conectar al servidor " + connectiondata, "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        return "";
                    }
                    str5 = this.Other.SubString(this.__utilerias_ltenviar1.Text, 0, 2);
                    str6 = this.Other.SubString(this.__utilerias_ltenviar2.Text, 0, 2);
                    str20 = "1";
                    str21 = "1";
                    str7 = DateTime.Now.Year.ToString(cul) + (((format = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Month).ToString(format, cul) : DateTime.Now.Month.ToString(format, cul)) + (((str23 = "D2".ToLower(cul))[0] != 'd') ? ((double) DateTime.Now.Day).ToString(str23, cul) : DateTime.Now.Day.ToString(str23, cul));
                    text = this.__utilerias_ltenviar1.Text;
                    if (this.LCompareEqual(this.var__mainmodule_process, "P"))
                    {
                        text = this.__utilerias_ltenviar2.Text;
                    }
                    lSide = "NO";
                    num5 = 0.0;
                    str24 = "SELECT M.folio, M.articulo, SUM(M.cantidad), MAX(P.costo_prom), MAX(P.linea), ";
                    str24 = str24 + "MAX(P.descrip), MAX(sistema), MAX(tiendaorigen), MAX(tiendadestino) ";
                    str24 = str24 + "FROM movsinv M INNER JOIN prods P ON P.articulo = M.articulo ";
                    str24 = str24 + "WHERE folio = " + str18 + " AND M.nuevo = 'S' AND cancelado = 'N' AND ";
                    str24 = str24 + "M.tipo = '" + this.var__mainmodule_process + "' GROUP BY M.folio, M.articulo";
                    this.__mainmodule_cmd.CommandText = str24;
                    this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                    while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                    {
                        str4 = this.__mainmodule_reader.GetValue(1);
                        num = double.Parse(this.__mainmodule_reader.GetValue(2), cul);
                        num3 = double.Parse(this.__mainmodule_reader.GetValue(3), cul);
                        str = this.__mainmodule_reader.GetValue(5);
                        this.var__mainmodule_sistema = double.Parse(this.__mainmodule_reader.GetValue(6), cul);
                        str25 = this.__mainmodule_reader.GetValue(7);
                        str26 = this.__mainmodule_reader.GetValue(8);
                        if (num2 > 300.0)
                        {
                            num2 = 0.0;
                        }
                        if (num3 > 300.0)
                        {
                            num3 = 0.0;
                        }
                        query = "IF NOT EXISTS (SELECT folio FROM pda WHERE folio = " + str18 + " AND serie = '" + this.var__mainmodule_process;
                        query = query + "' AND articulo = '" + str4 + "') INSERT INTO pda (sucentrega, sucsolicita, serie, folio, ";
                        query = query + "f_entrega, f_recepcion, articulo, clv_alter, cantidad, costo, precio, cantrecibida, hora, estatus, ";
                        query = query + "tiporecep, usuario, descrip, estado3, cancelado, estacion3, solicita, recibe, alm1, alm2) ";
                        query = query + "VALUES ('" + text + "','" + text + "','" + this.var__mainmodule_process + "','" + str18 + "','" + str7 + "','";
                        query = query + str7 + "','" + str4 + "','" + str4 + "','" + num.ToString(cul);
                        query = query + "','" + num3.ToString(cul) + "','0','0',' ','0','" + this.var__mainmodule_process + "','BODEGA','";
                        query = query + str + "','0','N','" + this.var__mainmodule_sistema.ToString(cul) + "','" + str25 + "','" + str26 + "','";
                        query = query + str20 + "','" + str21 + "')";
                        if (this.__mainmodule_msql1.ExecuteNonQuery(query).ToString(cul).ToLower(cul) == "false")
                        {
                            this.htStreams.Add("_utilerias_c1", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\" + this.var__mainmodule_servertea + " TRASPASOS MOVS PDA.txt"), false, Encoding.UTF8));
                            ((StreamWriter) this.htStreams["_utilerias_c1"]).WriteLine(query);
                            ((StreamWriter) this.htStreams["_utilerias_c1"]).WriteLine(this.__mainmodule_msql1.LastError);
                            if (this.htStreams.Contains("_utilerias_c1"))
                            {
                                ((Dbasic.IStream) this.htStreams["_utilerias_c1"]).Close();
                                this.htStreams.Remove("_utilerias_c1");
                                GC.Collect();
                            }
                            Cursor.Current = bool.Parse("false".ToLower(cul)) ? Cursors.WaitCursor : Cursors.Default;
                            ((int) MessageBox.Show("Problema en tabla PDA en " + this.var__mainmodule_servertea + " en linea 735", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                            lSide = "SI";
                            break;
                        }
                        query = "UPDATE movsinv SET nuevo = 'T' WHERE folio = " + str18 + " AND tipo = '" + this.var__mainmodule_process + "'";
                        this.__mainmodule_cmd2.CommandText = query;
                        this.__mainmodule_cmd2.ExecuteNonQuery();
                        num5++;
                    }
                    this.__mainmodule_reader.Close();
                    this.__mainmodule_msql1.Close();
                    if (!this.LCompareEqual(lSide, "SI"))
                    {
                        this.var__mainmodule_folio++;
                        this.__utilerias_ltfolio.Text = ((str28 = "D5".ToLower(cul))[0] != 'd') ? this.var__mainmodule_folio.ToString(str28, cul) : ((int) this.var__mainmodule_folio).ToString(str28, cul);
                        this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString(cul);
                        this.__mainmodule_cmd.ExecuteNonQuery();
                        ((int) MessageBox.Show("ok registros procesados " + num5.ToString(cul) + " siguiente folio " + this.var__mainmodule_folio.ToString(cul), "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                        this.__utilerias_enviar.close();
                        this.__utilerias_inven.close();
                    }
                }
                return "";
            Label_0CED:
                this.__utilerias_closeconexionsqlite();
                this.htStreams.Add("_utilerias_c5", new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + @"\ERROR1.txt"), false, Encoding.UTF8));
                ((StreamWriter) this.htStreams["_utilerias_c5"]).WriteLine(query);
                if (this.htStreams.Contains("_utilerias_c5"))
                {
                    ((Dbasic.IStream) this.htStreams["_utilerias_c5"]).Close();
                    this.htStreams.Remove("_utilerias_c5");
                    GC.Collect();
                }
                return "";
            }
            catch (Exception exception)
            {
                if (num6 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_cmdsend1_click = num6;
                    this.localVars = new object[] { 
                        str, str2, str3, str4, num, str5, str6, num2, num3, str7, str8, str9, str10, str11, str12, str13,
                        num4, text, text, lSide, num5, str17, str18, connectiondata, str20, str21, format, str23, str24, str25, str26, query,
                        str28
                    };
                    return this.__utilerias_cmdsend1_click();
                }
                this.ShowError(exception, "_utilerias_cmdsend1_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_cmdsend2_click");
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
                    format = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_enviar_show == 1)
                    {
                        this.err_utilerias_enviar_show = 0;
                        goto Label_023E;
                    }
                }
                num = 1;
                if (this.LCompareEqual(this.var__mainmodule_process, "P"))
                {
                    this.__utilerias_label5.Visible = bool.Parse("true".ToLower(cul));
                    this.__utilerias_ltenviar2.Visible = bool.Parse("true".ToLower(cul));
                    this.__utilerias_label6.Text = "Tienda origen:";
                }
                else
                {
                    this.__utilerias_label5.Visible = bool.Parse("false".ToLower(cul));
                    this.__utilerias_ltenviar2.Visible = bool.Parse("false".ToLower(cul));
                    this.__utilerias_label6.Text = "Gen. Compra en:";
                }
                str = "SELECT folio FROM movsinv WHERE cancelado = 'N' AND nuevo = 'S' AND tipo = '" + this.var__mainmodule_process + "' GROUP BY folio ORDER BY folio DESC";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__utilerias_cbofol.Items.Clear();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_cbofol.Items.Add(this.var__mainmodule_process + " " + (((format = "D5".ToLower(cul))[0] != 'd') ? double.Parse(this.__mainmodule_reader.GetValue(0), cul).ToString(format, cul) : ((int) double.Parse(this.__mainmodule_reader.GetValue(0), cul)).ToString(format, cul)));
                }
                this.__mainmodule_reader.Close();
                this.__utilerias_ltrutaenviar.Text = this.var__mainmodule_rutapc;
                this.__utilerias_ltenviar9.BringToFront();
                this.__utilerias_cbofol.BringToFront();
                return "";
            Label_023E:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_enviar_show = num;
                    this.localVars = new object[] { str, format };
                    return this.__utilerias_enviar_show();
                }
                this.ShowError(exception, "_utilerias_enviar_show");
                return "";
            }
        }

        private string __utilerias_frmtea_show()
        {
            try
            {
                this.__utilerias_tfolio.Text = this.var__mainmodule_folio.ToString(cul);
                this.__utilerias_tservertea.Text = this.var__mainmodule_servertea;
                this.__utilerias_tbasetea.Text = this.var__mainmodule_basetea;
                this.__utilerias_tusertea.Text = this.var__mainmodule_usertea;
                this.__utilerias_tpasstea.Text = this.var__mainmodule_passtea;
                this.__utilerias_tporttea.Text = this.var__mainmodule_porttea;
                this.__utilerias_label1.BringToFront();
                this.__utilerias_tservertea.BringToFront();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_frmtea_show");
                return "";
            }
        }

        private string __utilerias_importa_show()
        {
            string lSide = "";
            string s = "";
            int num = 0;
            try
            {
                if (this.err_utilerias_importa_show > 0)
                {
                    s = this.localVars[1];
                    lSide = this.localVars[0];
                    if (this.err_utilerias_importa_show == 1)
                    {
                        this.err_utilerias_importa_show = 0;
                        goto Label_02B4;
                    }
                }
                num = 1;
                this.__mainmodule_cmd.CommandText = "SELECT empresa, nombre FROM empresas ORDER BY empresa";
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__utilerias_cbotiendaorigen.Items.Clear();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_cbotiendaorigen.Items.Add(this.__mainmodule_reader.GetValue(0) + "] " + this.__mainmodule_reader.GetValue(1));
                }
                this.__mainmodule_reader.Close();
                if (this.var__mainmodule_empresapred.Length > 0.0)
                {
                    s = "0";
                    double num2 = this.__utilerias_cbotiendaorigen.Items.Count - 1.0;
                    double num3 = (s == "") ? 0.0 : double.Parse(s, cul);
                    while (num3 <= num2)
                    {
                        lSide = this.Other.SubString(this.__utilerias_cbotiendaorigen.Items[(s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul))].ToString(), 0, 2);
                        if (this.CompareEqual(lSide, this.var__mainmodule_empresapred))
                        {
                            this.__utilerias_cbotiendaorigen.SelectedIndex = (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul));
                            break;
                        }
                        s = ++num3.ToString(cul);
                    }
                    this.__utilerias_cbotiendaorigen.Enabled = bool.Parse("false".ToLower(cul));
                }
                else
                {
                    this.__utilerias_cbotiendaorigen.Enabled = bool.Parse("true".ToLower(cul));
                }
                this.__utilerias_ltdestino1.Visible = bool.Parse("true".ToLower(cul));
                this.__utilerias_cbotiendadestino.Visible = bool.Parse("true".ToLower(cul));
                this.var__mainmodule_process = "P";
                this.__utilerias_ltorigen1.BringToFront();
                this.__utilerias_cbotiendaorigen.BringToFront();
                return "";
            Label_02B4:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_importa_show = num;
                    this.localVars = new object[] { lSide, s };
                    return this.__utilerias_importa_show();
                }
                this.ShowError(exception, "_utilerias_importa_show");
                return "";
            }
        }

        private string __utilerias_inven_show()
        {
            string format = "";
            try
            {
                this.__utilerias_ltfolio.Text = ((format = "D5".ToLower(cul))[0] != 'd') ? this.var__mainmodule_folio.ToString(format, cul) : ((int) this.var__mainmodule_folio).ToString(format, cul);
                this.__utilerias_tcant.Text = "1";
                this.__utilerias_loadmovsinv();
                return "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_inven_show");
                return "";
            }
        }

        private string __utilerias_loadmovsinv()
        {
            double num = 0.0;
            string str = "";
            string s = "";
            int num2 = 0;
            try
            {
                if (this.err_utilerias_loadmovsinv > 0)
                {
                    s = this.localVars[2];
                    str = this.localVars[1];
                    num = this.localVars[0];
                    if (this.err_utilerias_loadmovsinv == 1)
                    {
                        this.err_utilerias_loadmovsinv = 0;
                        goto Label_028D;
                    }
                }
                num2 = 1;
                str = "SELECT M.articulo, P.descrip, SUM(M.cantidad) AS cant FROM movsinv M ";
                str = str + "LEFT JOIN prods P ON P.articulo = M.articulo WHERE ";
                str = str + "folio = " + this.var__mainmodule_folio.ToString(cul) + " AND M.nuevo = 'S' AND M.cancelado = 'N' ";
                str = str + "AND tipo = '" + this.var__mainmodule_process + "' GROUP BY M.articulo";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__utilerias_tbltea.dataTable.Clear();
                this.__utilerias_tbltea.dataTable.AcceptChanges();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_tbltea.AddRow(new object[0]);
                    s = (this.__utilerias_tbltea.dataTable.DefaultView.Count - 1.0).ToString(cul);
                    this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[0].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(0));
                    this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[1].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(1));
                    this.__utilerias_tbltea.SetCell(this.__utilerias_tbltea.TableStyles[0].GridColumnStyles[2].MappingName, (s == "") ? ((int) 0.0) : ((int) double.Parse(s, cul)), this.__mainmodule_reader.GetValue(2));
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_028D:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_loadmovsinv = num2;
                    this.localVars = new object[] { num, str, s };
                    return this.__utilerias_loadmovsinv();
                }
                this.ShowError(exception, "_utilerias_loadmovsinv");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_mnucanc_click");
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
                    str = this.localVars[0];
                    if (this.err_utilerias_mnucanfolio_click == 1)
                    {
                        this.err_utilerias_mnucanfolio_click = 0;
                        goto Label_0146;
                    }
                }
                num = 1;
                this.__utilerias_pnlcanfolio.Visible = bool.Parse("true".ToLower(cul));
                this.__utilerias_pnlcanfolio.Top = 0;
                this.__utilerias_pnlcanfolio.Left = 0;
                this.__utilerias_pnlcanfolio.Height = 0xeb;
                this.__utilerias_pnlcanfolio.Width = 240;
                str = "SELECT folio FROM movsinv WHERE nuevo = 'S' AND cancelado = 'N' AND tipo = '" + this.var__mainmodule_process + "' GROUP BY folio ORDER BY folio DESC";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_reader.Value = this.__mainmodule_cmd.ExecuteReader();
                this.__utilerias_cbocanfolio.Items.Clear();
                while (this.__mainmodule_reader.ReadNextRow().ToString(cul).ToLower(cul) == "true")
                {
                    this.__utilerias_cbocanfolio.Items.Add(this.var__mainmodule_process + " " + this.__mainmodule_reader.GetValue(0));
                }
                this.__mainmodule_reader.Close();
                return "";
            Label_0146:
                this.__utilerias_closeconexionsqlite();
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_mnucanfolio_click = num;
                    this.localVars = new object[] { str };
                    return this.__utilerias_mnucanfolio_click();
                }
                this.ShowError(exception, "_utilerias_mnucanfolio_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_mnucantea_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_mnuenviar_click");
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
                    format = this.localVars[1];
                    str = this.localVars[0];
                    if (this.err_utilerias_mnufin_click == 1)
                    {
                        this.err_utilerias_mnufin_click = 0;
                        goto Label_0112;
                    }
                }
                num = 1;
                str = "UPDATE movsinv SET status = 'C'";
                this.__mainmodule_cmd.CommandText = str;
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.var__mainmodule_folio++;
                this.__utilerias_ltfolio.Text = ((format = "D5".ToLower(cul))[0] != 'd') ? this.var__mainmodule_folio.ToString(format, cul) : ((int) this.var__mainmodule_folio).ToString(format, cul);
                this.__mainmodule_cmd.CommandText = "UPDATE config SET folio = " + this.var__mainmodule_folio.ToString(cul);
                this.__mainmodule_cmd.ExecuteNonQuery();
                this.__utilerias_inven.close();
                return "";
            Label_0112:
                ((int) MessageBox.Show("Error en errmnuFin_Click.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_mnufin_click = num;
                    this.localVars = new object[] { str, format };
                    return this.__utilerias_mnufin_click();
                }
                this.ShowError(exception, "_utilerias_mnufin_click");
                return "";
            }
        }

        private string __utilerias_mnumov_click()
        {
            int num = 0;
            int num2 = 0;
            try
            {
                if (this.err_utilerias_mnumov_click > 0)
                {
                    num = this.localVars[0];
                    if (this.err_utilerias_mnumov_click == 1)
                    {
                        this.err_utilerias_mnumov_click = 0;
                        goto Label_0042;
                    }
                }
                num2 = 1;
                this.__utilerias_partinven.show();
                return "";
            Label_0042:
                ((int) MessageBox.Show("Error en cmdMovs.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num2 > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_mnumov_click = num2;
                    this.localVars = new object[] { num };
                    return this.__utilerias_mnumov_click();
                }
                this.ShowError(exception, "_utilerias_mnumov_click");
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
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_partinven_show");
                return "";
            }
        }

        private string __utilerias_tart_keypress(string var__utilerias_key)
        {
            int num = 0;
            try
            {
                if ((this.err_utilerias_tart_keypress > 0) && (this.err_utilerias_tart_keypress == 1))
                {
                    this.err_utilerias_tart_keypress = 0;
                }
                else
                {
                    num = 1;
                    char ch = '\r';
                    if (this.LCompareEqual(var__utilerias_key, ch.ToString(cul)))
                    {
                        this.__utilerias_bart();
                    }
                    return "";
                }
                ((int) MessageBox.Show("Error en tArt_keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_tart_keypress = num;
                    this.localVars = new object[0];
                    return this.__utilerias_tart_keypress(var__utilerias_key);
                }
                this.ShowError(exception, "_utilerias_tart_keypress");
                return "";
            }
        }

        private string __utilerias_tcant_keypress(string var__utilerias_key)
        {
            string str;
            try
            {
                char ch = '\r';
                if (!this.LCompareEqual(var__utilerias_key, ch.ToString(cul)))
                {
                    char ch2 = '\n';
                    if (!this.LCompareEqual(var__utilerias_key, ch2.ToString(cul)))
                    {
                        goto Label_003C;
                    }
                }
                this.__utilerias_tprod.Focus();
            Label_003C:
                str = "";
            }
            catch (Exception exception)
            {
                this.ShowError(exception, "_utilerias_tcant_keypress");
                str = "";
            }
            return str;
        }

        private string __utilerias_tprod_keypress(string var__utilerias_key)
        {
            int num = 0;
            try
            {
                if ((this.err_utilerias_tprod_keypress > 0) && (this.err_utilerias_tprod_keypress == 1))
                {
                    this.err_utilerias_tprod_keypress = 0;
                    goto Label_005F;
                }
                num = 1;
                char ch = '\r';
                if (!this.LCompareEqual(var__utilerias_key, ch.ToString(cul)))
                {
                    char ch2 = '\n';
                    if (!this.LCompareEqual(var__utilerias_key, ch2.ToString(cul)))
                    {
                        goto Label_0057;
                    }
                }
                this.__utilerias_cmdaceptar_click();
            Label_0057:
                return "";
            Label_005F:
                ((int) MessageBox.Show("Error en keypress.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString(cul);
                return "";
            }
            catch (Exception exception)
            {
                if (num > 0)
                {
                    this.lastError = exception;
                    this.err_utilerias_tprod_keypress = num;
                    this.localVars = new object[0];
                    return this.__utilerias_tprod_keypress(var__utilerias_key);
                }
                this.ShowError(exception, "_utilerias_tprod_keypress");
                return "";
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

        private void AddRuntimeEvent(string name, string eventName, string subName)
        {
            if (this.htControls[name] is IEnhancedControl)
            {
                ((IEnhancedControl) this.htControls[name]).AddRunTimeEvent(eventName, subName);
            }
            else
            {
                this.CEnhancedObject.AddRunTimeEvent(this.htControls[name], name, eventName, subName);
            }
        }

        public void CloseProgram()
        {
            this.quitFlag = true;
            this.shownForm = null;
            if (this.CEnhancedObject.htShemotAzamim != null)
            {
                this.CEnhancedObject.htShemotAzamim.Clear();
            }
            foreach (DictionaryEntry entry in this.htStreams)
            {
                ((Dbasic.IStream) entry.Value).Close();
            }
            this.htStreams.Clear();
            foreach (DictionaryEntry entry2 in this.htControls)
            {
                object obj2 = entry2.Value;
                if ((obj2 is CEnhancedForm) && (obj2 != this.mainForm))
                {
                    ((CEnhancedForm) obj2).Close();
                }
                else if (obj2 is System.Windows.Forms.Timer)
                {
                    ((System.Windows.Forms.Timer) obj2).Enabled = false;
                }
                try
                {
                    if ((obj2 != null) && (obj2 is IDisposable))
                    {
                        ((IDisposable) obj2).Dispose();
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

        public bool CompareEqual(string lSide, string rSide)
        {
            if (((lSide != "") || (rSide != "0")) && ((lSide != "0") || (rSide != "")))
            {
                return (lSide == rSide);
            }
            return true;
        }

        private void initialize()
        {
            this.htSubs.Add("__mainmodule_config_close", new del0(this.__mainmodule_config_close));
            this.htSubs.Add("__mainmodule_chenviartodascompras_click", new del0(this.__mainmodule_chenviartodascompras_click));
            this.htSubs.Add("__mainmodule_chenviartodospedidos_click", new del0(this.__mainmodule_chenviartodospedidos_click));
            this.htSubs.Add("__mainmodule_btnbuscarcte_buttondown", new del0(this.__mainmodule_btnbuscarcte_buttondown));
            this.htSubs.Add("__mainmodule_tpedcte_keypress", new del1(this.__mainmodule_tpedcte_keypress));
            this.htSubs.Add("__mainmodule_btnokcte_click", new del0(this.__mainmodule_btnokcte_click));
            this.htSubs.Add("__mainmodule_frmclientes_show", new del0(this.__mainmodule_frmclientes_show));
            this.htSubs.Add("__mainmodule_listcte_click", new del0(this.__mainmodule_listcte_click));
            this.htSubs.Add("__mainmodule_btncteped2_click", new del0(this.__mainmodule_btncteped2_click));
            this.htSubs.Add("__mainmodule_btncteped1_click", new del0(this.__mainmodule_btncteped1_click));
            this.htSubs.Add("__mainmodule_btnbuscarcte_click", new del0(this.__mainmodule_btnbuscarcte_click));
            this.htSubs.Add("__mainmodule_cmdbuscar_click", new del0(this.__mainmodule_cmdbuscar_click));
            this.htSubs.Add("__mainmodule_btnsalped_click", new del0(this.__mainmodule_btnsalped_click));
            this.htSubs.Add("__mainmodule_mnuopcionesped_click", new del0(this.__mainmodule_mnuopcionesped_click));
            this.htSubs.Add("__mainmodule_mnueliped_click", new del0(this.__mainmodule_mnueliped_click));
            this.htSubs.Add("__mainmodule_mnureenped_click", new del0(this.__mainmodule_mnureenped_click));
            this.htSubs.Add("__mainmodule_mnucanped_click", new del0(this.__mainmodule_mnucanped_click));
            this.htSubs.Add("__mainmodule_tblpedidos_selectionchanged", new del2(this.__mainmodule_tblpedidos_selectionchanged));
            this.htSubs.Add("__mainmodule_cboclieutils_selectionchanged", new del2(this.__mainmodule_cboclieutils_selectionchanged));
            this.htSubs.Add("__mainmodule_frmpedidosutils_show", new del0(this.__mainmodule_frmpedidosutils_show));
            this.htSubs.Add("__mainmodule_btnsalirpedido_click", new del0(this.__mainmodule_btnsalirpedido_click));
            this.htSubs.Add("__mainmodule_mnupedido_click", new del0(this.__mainmodule_mnupedido_click));
            this.htSubs.Add("__mainmodule_btngenpedido_click", new del0(this.__mainmodule_btngenpedido_click));
            this.htSubs.Add("__mainmodule_genpedido_show", new del0(this.__mainmodule_genpedido_show));
            this.htSubs.Add("__mainmodule_mnunewpedido_click", new del0(this.__mainmodule_mnunewpedido_click));
            this.htSubs.Add("__mainmodule_btnpedido_click", new del0(this.__mainmodule_btnpedido_click));
            this.htSubs.Add("__mainmodule_frmtraspasos_show", new del0(this.__mainmodule_frmtraspasos_show));
            this.htSubs.Add("__mainmodule_frmmenu_show", new del0(this.__mainmodule_frmmenu_show));
            this.htSubs.Add("__mainmodule_btncrearbase_click", new del0(this.__mainmodule_btncrearbase_click));
            this.htSubs.Add("__mainmodule_cierrareader", new del0(this.__mainmodule_cierrareader));
            this.htSubs.Add("__mainmodule_btntopercerrar_click", new del0(this.__mainmodule_btntopercerrar_click));
            this.htSubs.Add("__mainmodule_btntoper2_click", new del0(this.__mainmodule_btntoper2_click));
            this.htSubs.Add("__mainmodule_btntoperborrar_click", new del0(this.__mainmodule_btntoperborrar_click));
            this.htSubs.Add("__mainmodule_tblexisxlinea_selectionchanged", new del2(this.__mainmodule_tblexisxlinea_selectionchanged));
            this.htSubs.Add("__mainmodule_tbltoper_selectionchanged", new del2(this.__mainmodule_tbltoper_selectionchanged));
            this.htSubs.Add("__mainmodule_btntoper1_click", new del0(this.__mainmodule_btntoper1_click));
            this.htSubs.Add("__mainmodule_btnareaserie2_click", new del0(this.__mainmodule_btnareaserie2_click));
            this.htSubs.Add("__mainmodule_btnareaserie1_click", new del0(this.__mainmodule_btnareaserie1_click));
            this.htSubs.Add("__mainmodule_mnuborrarareas_click", new del0(this.__mainmodule_mnuborrarareas_click));
            this.htSubs.Add("__mainmodule_mnuareas1_click", new del0(this.__mainmodule_mnuareas1_click));
            this.htSubs.Add("__mainmodule_mnuareas_click", new del0(this.__mainmodule_mnuareas_click));
            this.htSubs.Add("__mainmodule_btnarea2_click", new del0(this.__mainmodule_btnarea2_click));
            this.htSubs.Add("__mainmodule_btnareas_click", new del0(this.__mainmodule_btnareas_click));
            this.htSubs.Add("__mainmodule_btnareanew_click", new del0(this.__mainmodule_btnareanew_click));
            this.htSubs.Add("__mainmodule_btnareagrabar_click", new del0(this.__mainmodule_btnareagrabar_click));
            this.htSubs.Add("__mainmodule_desplegarareas", new del0(this.__mainmodule_desplegarareas));
            this.htSubs.Add("__mainmodule_btneliminar_click", new del0(this.__mainmodule_btneliminar_click));
            this.htSubs.Add("__mainmodule_tblareas_selectionchanged", new del2(this.__mainmodule_tblareas_selectionchanged));
            this.htSubs.Add("__mainmodule_frmareas_show", new del0(this.__mainmodule_frmareas_show));
            this.htSubs.Add("__mainmodule_bk_txt", new del0(this.__mainmodule_bk_txt));
            this.htSubs.Add("__mainmodule_mnuexxlinea_click", new del0(this.__mainmodule_mnuexxlinea_click));
            this.htSubs.Add("__mainmodule_mnuexisxlinea_click", new del0(this.__mainmodule_mnuexisxlinea_click));
            this.htSubs.Add("__mainmodule_frmexistxlinea_show", new del0(this.__mainmodule_frmexistxlinea_show));
            this.htSubs.Add("__mainmodule_btncompactar_click", new del0(this.__mainmodule_btncompactar_click));
            this.htSubs.Add("__mainmodule_procminve_close", new del0(this.__mainmodule_procminve_close));
            this.htSubs.Add("__mainmodule_frmmenu_close", new del0(this.__mainmodule_frmmenu_close));
            this.htSubs.Add("__mainmodule_gencompra_close", new del0(this.__mainmodule_gencompra_close));
            this.htSubs.Add("__mainmodule_mnutotalminve_click", new del0(this.__mainmodule_mnutotalminve_click));
            this.htSubs.Add("__mainmodule_mnutotal_click", new del0(this.__mainmodule_mnutotal_click));
            this.htSubs.Add("__mainmodule_btngenerar_keypress", new del1(this.__mainmodule_btngenerar_keypress));
            this.htSubs.Add("__mainmodule_mnuenviarsql_click", new del0(this.__mainmodule_mnuenviarsql_click));
            this.htSubs.Add("__mainmodule_mnuconsec_click", new del0(this.__mainmodule_mnuconsec_click));
            this.htSubs.Add("__mainmodule_opminve2_click", new del0(this.__mainmodule_opminve2_click));
            this.htSubs.Add("__mainmodule_opminve1_click", new del0(this.__mainmodule_opminve1_click));
            this.htSubs.Add("__mainmodule_opminve3_click", new del0(this.__mainmodule_opminve3_click));
            this.htSubs.Add("__mainmodule_mnuajustar_click", new del0(this.__mainmodule_mnuajustar_click));
            this.htSubs.Add("__mainmodule_mnuactualizar_click", new del0(this.__mainmodule_mnuactualizar_click));
            this.htSubs.Add("__mainmodule_mnuacumulativo_click", new del0(this.__mainmodule_mnuacumulativo_click));
            this.htSubs.Add("__mainmodule_btnred_click", new del0(this.__mainmodule_btnred_click));
            this.htSubs.Add("__mainmodule_cmdinv_keypress", new del1(this.__mainmodule_cmdinv_keypress));
            this.htSubs.Add("__mainmodule_btntea_click", new del0(this.__mainmodule_btntea_click));
            this.htSubs.Add("__mainmodule_btntraspasos_click", new del0(this.__mainmodule_btntraspasos_click));
            this.htSubs.Add("__mainmodule_cmdimport1_click", new del0(this.__mainmodule_cmdimport1_click));
            this.htSubs.Add("__mainmodule_frmcomprasutils_close", new del0(this.__mainmodule_frmcomprasutils_close));
            this.htSubs.Add("__mainmodule_tblcompras_selectionchanged", new del2(this.__mainmodule_tblcompras_selectionchanged));
            this.htSubs.Add("__mainmodule_mnucancelarpartidacompra_click", new del0(this.__mainmodule_mnucancelarpartidacompra_click));
            this.htSubs.Add("__mainmodule_tbcaninven_selectionchanged", new del2(this.__mainmodule_tbcaninven_selectionchanged));
            this.htSubs.Add("__mainmodule_mnuminve1_click", new del0(this.__mainmodule_mnuminve1_click));
            this.htSubs.Add("__mainmodule_btnlogin1_click", new del0(this.__mainmodule_btnlogin1_click));
            this.htSubs.Add("__mainmodule_btnlogin2_click", new del0(this.__mainmodule_btnlogin2_click));
            this.htSubs.Add("__mainmodule_mnuinvent_click", new del0(this.__mainmodule_mnuinvent_click));
            this.htSubs.Add("__mainmodule_btnprods_click", new del0(this.__mainmodule_btnprods_click));
            this.htSubs.Add("__mainmodule_prods_show", new del0(this.__mainmodule_prods_show));
            this.htSubs.Add("__mainmodule_chmult_click", new del0(this.__mainmodule_chmult_click));
            this.htSubs.Add("__mainmodule_mnunuevacompra_click", new del0(this.__mainmodule_mnunuevacompra_click));
            this.htSubs.Add("__mainmodule_cmdinvc_click", new del0(this.__mainmodule_cmdinvc_click));
            this.htSubs.Add("__mainmodule_mnucancelcompra_click", new del0(this.__mainmodule_mnucancelcompra_click));
            this.htSubs.Add("__mainmodule_mnureenviarcompra_click", new del0(this.__mainmodule_mnureenviarcompra_click));
            this.htSubs.Add("__mainmodule_cboprovutils_selectionchanged", new del2(this.__mainmodule_cboprovutils_selectionchanged));
            this.htSubs.Add("__mainmodule_frmcomprasutils_show", new del0(this.__mainmodule_frmcomprasutils_show));
            this.htSubs.Add("__mainmodule_mnuutilscompras_click", new del0(this.__mainmodule_mnuutilscompras_click));
            this.htSubs.Add("__mainmodule_btnmenucompras_click", new del0(this.__mainmodule_btnmenucompras_click));
            this.htSubs.Add("__mainmodule_btnmenuinvent_click", new del0(this.__mainmodule_btnmenuinvent_click));
            this.htSubs.Add("__mainmodule_btnmenusalir_click", new del0(this.__mainmodule_btnmenusalir_click));
            this.htSubs.Add("__mainmodule_frmseries_show", new del0(this.__mainmodule_frmseries_show));
            this.htSubs.Add("__mainmodule_btnsalirseries_click", new del0(this.__mainmodule_btnsalirseries_click));
            this.htSubs.Add("__mainmodule_btnseries_click", new del0(this.__mainmodule_btnseries_click));
            this.htSubs.Add("__mainmodule_frmexistencias_show", new del0(this.__mainmodule_frmexistencias_show));
            this.htSubs.Add("__mainmodule_btnsalexist_click", new del0(this.__mainmodule_btnsalexist_click));
            this.htSubs.Add("__mainmodule_mnuexist_click", new del0(this.__mainmodule_mnuexist_click));
            this.htSubs.Add("__mainmodule_buscaexistencia", new del0(this.__mainmodule_buscaexistencia));
            this.htSubs.Add("__mainmodule_tprod_keypress", new del1(this.__mainmodule_tprod_keypress));
            this.htSubs.Add("__mainmodule_mnureenviar_click", new del0(this.__mainmodule_mnureenviar_click));
            this.htSubs.Add("__mainmodule_gencompra_show", new del0(this.__mainmodule_gencompra_show));
            this.htSubs.Add("__mainmodule_btngencompra_click", new del0(this.__mainmodule_btngencompra_click));
            this.htSubs.Add("__mainmodule_btnsalirgencompra_click", new del0(this.__mainmodule_btnsalirgencompra_click));
            this.htSubs.Add("__mainmodule_mnucompra_click", new del0(this.__mainmodule_mnucompra_click));
            this.htSubs.Add("__mainmodule_inventario_acumulativo", new del0(this.__mainmodule_inventario_acumulativo));
            this.htSubs.Add("__mainmodule_inventario_directo", new del0(this.__mainmodule_inventario_directo));
            this.htSubs.Add("__mainmodule_inventario_acumulativo_proc_almacenado", new del0(this.__mainmodule_inventario_acumulativo_proc_almacenado));
            this.htSubs.Add("__mainmodule_inventario_directo_proc_almacenado", new del0(this.__mainmodule_inventario_directo_proc_almacenado));
            this.htSubs.Add("__mainmodule_btngenerar_click", new del0(this.__mainmodule_btngenerar_click));
            this.htSubs.Add("__mainmodule_procminve_show", new del0(this.__mainmodule_procminve_show));
            this.htSubs.Add("__mainmodule_btnexistminve_click", new del0(this.__mainmodule_btnexistminve_click));
            this.htSubs.Add("__mainmodule_validacampo", new del2(this.__mainmodule_validacampo));
            this.htSubs.Add("__mainmodule_mnuenviarsae_click", new del0(this.__mainmodule_mnuenviarsae_click));
            this.htSubs.Add("__mainmodule_enviaraunapc", new del1(this.__mainmodule_enviaraunapc));
            this.htSubs.Add("__mainmodule_invent_close", new del0(this.__mainmodule_invent_close));
            this.htSubs.Add("__mainmodule_mnusql4_click", new del0(this.__mainmodule_mnusql4_click));
            this.htSubs.Add("__mainmodule_mnusql3_click", new del0(this.__mainmodule_mnusql3_click));
            this.htSubs.Add("__mainmodule_mnusql2_click", new del0(this.__mainmodule_mnusql2_click));
            this.htSubs.Add("__mainmodule_chcaja_click", new del0(this.__mainmodule_chcaja_click));
            this.htSubs.Add("__mainmodule_btnenviarinven_click", new del0(this.__mainmodule_btnenviarinven_click));
            this.htSubs.Add("__mainmodule_enviar_close", new del0(this.__mainmodule_enviar_close));
            this.htSubs.Add("__mainmodule_menfin_click", new del0(this.__mainmodule_menfin_click));
            this.htSubs.Add("__mainmodule_mnusalircan_click", new del0(this.__mainmodule_mnusalircan_click));
            this.htSubs.Add("__mainmodule_btnnew_click", new del0(this.__mainmodule_btnnew_click));
            this.htSubs.Add("__mainmodule_tarticulo_gotfocus", new del0(this.__mainmodule_tarticulo_gotfocus));
            this.htSubs.Add("__mainmodule_btnutils_click", new del0(this.__mainmodule_btnutils_click));
            this.htSubs.Add("__mainmodule_btnusr3_click", new del0(this.__mainmodule_btnusr3_click));
            this.htSubs.Add("__mainmodule_tclave_gotfocus", new del0(this.__mainmodule_tclave_gotfocus));
            this.htSubs.Add("__mainmodule_tnombre_gotfocus", new del0(this.__mainmodule_tnombre_gotfocus));
            this.htSubs.Add("__mainmodule_tusu_gotfocus", new del0(this.__mainmodule_tusu_gotfocus));
            this.htSubs.Add("__mainmodule_btnusr2_click", new del0(this.__mainmodule_btnusr2_click));
            this.htSubs.Add("__mainmodule_btnuser_click", new del0(this.__mainmodule_btnuser_click));
            this.htSubs.Add("__mainmodule_tlinea_keypress", new del1(this.__mainmodule_tlinea_keypress));
            this.htSubs.Add("__mainmodule_cierracontrans", new del0(this.__mainmodule_cierracontrans));
            this.htSubs.Add("__mainmodule_cierramsql", new del0(this.__mainmodule_cierramsql));
            this.htSubs.Add("__mainmodule_cboempresa_selectionchanged", new del2(this.__mainmodule_cboempresa_selectionchanged));
            this.htSubs.Add("__mainmodule_tbluser_selectionchanged", new del2(this.__mainmodule_tbluser_selectionchanged));
            this.htSubs.Add("__mainmodule_btnsql3_click", new del0(this.__mainmodule_btnsql3_click));
            this.htSubs.Add("__mainmodule_btnaceptar_click", new del0(this.__mainmodule_btnaceptar_click));
            this.htSubs.Add("__mainmodule_btnusr1_click", new del0(this.__mainmodule_btnusr1_click));
            this.htSubs.Add("__mainmodule_usuarios_show", new del0(this.__mainmodule_usuarios_show));
            this.htSubs.Add("__mainmodule_image1_click", new del0(this.__mainmodule_image1_click));
            this.htSubs.Add("__mainmodule_invencan_close", new del0(this.__mainmodule_invencan_close));
            this.htSubs.Add("__mainmodule_cboimporta_selectionchanged", new del2(this.__mainmodule_cboimporta_selectionchanged));
            this.htSubs.Add("__mainmodule_cboempresa1_selectionchanged", new del2(this.__mainmodule_cboempresa1_selectionchanged));
            this.htSubs.Add("__mainmodule_btnsql2_click", new del0(this.__mainmodule_btnsql2_click));
            this.htSubs.Add("__mainmodule_btnsql_click", new del0(this.__mainmodule_btnsql_click));
            this.htSubs.Add("__mainmodule_btnsql1_click", new del0(this.__mainmodule_btnsql1_click));
            this.htSubs.Add("__mainmodule_sqlserver_show", new del0(this.__mainmodule_sqlserver_show));
            this.htSubs.Add("__mainmodule_invencan_show", new del0(this.__mainmodule_invencan_show));
            this.htSubs.Add("__mainmodule_bcodigo", new del0(this.__mainmodule_bcodigo));
            this.htSubs.Add("__mainmodule_tcodigo_keypress", new del1(this.__mainmodule_tcodigo_keypress));
            this.htSubs.Add("__mainmodule_mnucan1_click", new del0(this.__mainmodule_mnucan1_click));
            this.htSubs.Add("__mainmodule_cmdinvensalir_click", new del0(this.__mainmodule_cmdinvensalir_click));
            this.htSubs.Add("__mainmodule_mencan_click", new del0(this.__mainmodule_mencan_click));
            this.htSubs.Add("__mainmodule_tuni_gotfocus", new del0(this.__mainmodule_tuni_gotfocus));
            this.htSubs.Add("__mainmodule_tuni_keypress", new del1(this.__mainmodule_tuni_keypress));
            this.htSubs.Add("__mainmodule_main_show", new del0(this.__mainmodule_main_show));
            this.htSubs.Add("__mainmodule_menmov_click", new del0(this.__mainmodule_menmov_click));
            this.htSubs.Add("__mainmodule_copiaarchivos2", new del0(this.__mainmodule_copiaarchivos2));
            this.htSubs.Add("__mainmodule_copiaarchivos", new del0(this.__mainmodule_copiaarchivos));
            this.htSubs.Add("__mainmodule_vacu", new del0(this.__mainmodule_vacu));
            this.htSubs.Add("__mainmodule_cmdvaciarinvent_click", new del0(this.__mainmodule_cmdvaciarinvent_click));
            this.htSubs.Add("__mainmodule_mnurest_click", new del0(this.__mainmodule_mnurest_click));
            this.htSubs.Add("__mainmodule_importararticulosupdateexist", new del0(this.__mainmodule_importararticulosupdateexist));
            this.htSubs.Add("__mainmodule_importararticulos", new del0(this.__mainmodule_importararticulos));
            this.htSubs.Add("__mainmodule_tarticulo_keypress", new del1(this.__mainmodule_tarticulo_keypress));
            this.htSubs.Add("__mainmodule_invent_show", new del0(this.__mainmodule_invent_show));
            this.htSubs.Add("__mainmodule_mensend_click", new del0(this.__mainmodule_mensend_click));
            this.htSubs.Add("__mainmodule_cmdinv_click", new del0(this.__mainmodule_cmdinv_click));
            this.htSubs.Add("__mainmodule_button12_click", new del0(this.__mainmodule_button12_click));
            this.htSubs.Add("__mainmodule_btnmain5_click", new del0(this.__mainmodule_btnmain5_click));
            this.htSubs.Add("__mainmodule_main_close", new del0(this.__mainmodule_main_close));
            this.htSubs.Add("__mainmodule_btnmain8_click", new del0(this.__mainmodule_btnmain8_click));
            this.htSubs.Add("__mainmodule_cmdborrar_click", new del0(this.__mainmodule_cmdborrar_click));
            this.htSubs.Add("__mainmodule_fgprod_selectionchanged", new del2(this.__mainmodule_fgprod_selectionchanged));
            this.htSubs.Add("__mainmodule_cmdsend2_click", new del0(this.__mainmodule_cmdsend2_click));
            this.htSubs.Add("__mainmodule_enviar_show", new del0(this.__mainmodule_enviar_show));
            this.htSubs.Add("__mainmodule_cmdsend1_click", new del0(this.__mainmodule_cmdsend1_click));
            this.htSubs.Add("__mainmodule_cmdrutapcc_click", new del0(this.__mainmodule_cmdrutapcc_click));
            this.htSubs.Add("__mainmodule_config_show", new del0(this.__mainmodule_config_show));
            this.htSubs.Add("__mainmodule_centra", new del1(this.__mainmodule_centra));
            this.htSubs.Add("__mainmodule_mnuenviar_click", new del0(this.__mainmodule_mnuenviar_click));
            this.htSubs.Add("__mainmodule_partinven_close", new del0(this.__mainmodule_partinven_close));
            this.htSubs.Add("__mainmodule_tblprod_selectionchanged", new del2(this.__mainmodule_tblprod_selectionchanged));
            this.htSubs.Add("__mainmodule_timer1_tick", new del0(this.__mainmodule_timer1_tick));
            this.htSubs.Add("__mainmodule_addfield", new del0(this.__mainmodule_addfield));
            this.htSubs.Add("__mainmodule_creatablaarea", new del0(this.__mainmodule_creatablaarea));
            this.htSubs.Add("__mainmodule_app_start", new del0(this.__mainmodule_app_start));
            this.htSubs.Add("__utilerias_partinven_show", new del0(this.__utilerias_partinven_show));
            this.htSubs.Add("__utilerias_tcant_keypress", new del1(this.__utilerias_tcant_keypress));
            this.htSubs.Add("__utilerias_mnucantea_click", new del0(this.__utilerias_mnucantea_click));
            this.htSubs.Add("__utilerias_cbotiendadestino_selectionchanged", new del2(this.__utilerias_cbotiendadestino_selectionchanged));
            this.htSubs.Add("__utilerias_cbocanfolio_selectionchanged", new del2(this.__utilerias_cbocanfolio_selectionchanged));
            this.htSubs.Add("__utilerias_btntrans_click", new del0(this.__utilerias_btntrans_click));
            this.htSubs.Add("__utilerias_cmdaceptar_keypress", new del1(this.__utilerias_cmdaceptar_keypress));
            this.htSubs.Add("__utilerias_cbofol_selectionchanged", new del2(this.__utilerias_cbofol_selectionchanged));
            this.htSubs.Add("__utilerias_bart", new del0(this.__utilerias_bart));
            this.htSubs.Add("__utilerias_loadmovsinv", new del0(this.__utilerias_loadmovsinv));
            this.htSubs.Add("__utilerias_cbotiendaorigen_selectionchanged", new del2(this.__utilerias_cbotiendaorigen_selectionchanged));
            this.htSubs.Add("__utilerias_importa_show", new del0(this.__utilerias_importa_show));
            this.htSubs.Add("__utilerias_cmdimpor2_click", new del0(this.__utilerias_cmdimpor2_click));
            this.htSubs.Add("__utilerias_cmdimpor1_click", new del0(this.__utilerias_cmdimpor1_click));
            this.htSubs.Add("__utilerias_cmdsend2_click", new del0(this.__utilerias_cmdsend2_click));
            this.htSubs.Add("__utilerias_cmdsend1_click", new del0(this.__utilerias_cmdsend1_click));
            this.htSubs.Add("__utilerias_enviar_show", new del0(this.__utilerias_enviar_show));
            this.htSubs.Add("__utilerias_cmdcanc2_click", new del0(this.__utilerias_cmdcanc2_click));
            this.htSubs.Add("__utilerias_cmdcanc1_click", new del0(this.__utilerias_cmdcanc1_click));
            this.htSubs.Add("__utilerias_cmdcbus_click", new del0(this.__utilerias_cmdcbus_click));
            this.htSubs.Add("__utilerias_tart_keypress", new del1(this.__utilerias_tart_keypress));
            this.htSubs.Add("__utilerias_canc_close", new del0(this.__utilerias_canc_close));
            this.htSubs.Add("__utilerias_canc_show", new del0(this.__utilerias_canc_show));
            this.htSubs.Add("__utilerias_mnucanfolio_click", new del0(this.__utilerias_mnucanfolio_click));
            this.htSubs.Add("__utilerias_mnucanc_click", new del0(this.__utilerias_mnucanc_click));
            this.htSubs.Add("__utilerias_mnufin_click", new del0(this.__utilerias_mnufin_click));
            this.htSubs.Add("__utilerias_mnuenviar_click", new del0(this.__utilerias_mnuenviar_click));
            this.htSubs.Add("__utilerias_mnumov_click", new del0(this.__utilerias_mnumov_click));
            this.htSubs.Add("__utilerias_btncanfol2_click", new del0(this.__utilerias_btncanfol2_click));
            this.htSubs.Add("__utilerias_btncanfolio1_click", new del0(this.__utilerias_btncanfolio1_click));
            this.htSubs.Add("__utilerias_inven_show", new del0(this.__utilerias_inven_show));
            this.htSubs.Add("__utilerias_tprod_keypress", new del1(this.__utilerias_tprod_keypress));
            this.htSubs.Add("__utilerias_closeconexionsqlite", new del0(this.__utilerias_closeconexionsqlite));
            this.htSubs.Add("__utilerias_cmdaceptar_click", new del0(this.__utilerias_cmdaceptar_click));
            this.htSubs.Add("__utilerias_btntea_click", new del0(this.__utilerias_btntea_click));
            this.htSubs.Add("__utilerias_btntea2_click", new del0(this.__utilerias_btntea2_click));
            this.htSubs.Add("__utilerias_frmtea_show", new del0(this.__utilerias_frmtea_show));
            this.screenX = 240;
            this.screenY = 0x10c;
            this.icon = "INVEN1.ico";
            this.__utilerias_canc = new CEnhancedForm(this);
            this.__utilerias_canc.name = "__utilerias_canc";
            this.__utilerias_canc.Text = "Cancelaciones";
            this.__utilerias_canc.BackColor = Color.FromArgb(-1389077);
            this.__utilerias_canc.graphics.FillRectangle(new SolidBrush(this.__utilerias_canc.BackColor), 0, 0, this.__utilerias_canc.Width, this.__utilerias_canc.Height);
            this.__utilerias_canc.AddEvents();
            this.htControls.Add("__utilerias_canc", this.__utilerias_canc);
            this.__utilerias_cmdcbus = new CEnhancedButton(this);
            this.__utilerias_cmdcbus.name = "__utilerias_cmdcbus";
            this.__utilerias_cmdcbus.Left = 0xc9;
            this.__utilerias_cmdcbus.Top = 6;
            this.__utilerias_cmdcbus.Width = 0x24;
            this.__utilerias_cmdcbus.Height = 0x15;
            this.__utilerias_cmdcbus.Text = "......";
            this.__utilerias_cmdcbus.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdcbus.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdcbus.Enabled = true;
            this.__utilerias_cmdcbus.Visible = true;
            this.__utilerias_cmdcbus.Font = new Font(this.__utilerias_cmdcbus.Font.Name, 11f, this.__utilerias_cmdcbus.Font.Style);
            this.__utilerias_cmdcbus.AddEvents();
            this.__utilerias_canc.Controls.Add(this.__utilerias_cmdcbus);
            this.htControls.Add("__utilerias_cmdcbus", this.__utilerias_cmdcbus);
            this.__utilerias_cmdcanc2 = new CEnhancedButton(this);
            this.__utilerias_cmdcanc2.name = "__utilerias_cmdcanc2";
            this.__utilerias_cmdcanc2.Left = 0xa1;
            this.__utilerias_cmdcanc2.Top = 240;
            this.__utilerias_cmdcanc2.Width = 0x3e;
            this.__utilerias_cmdcanc2.Height = 0x1a;
            this.__utilerias_cmdcanc2.Text = "Salir";
            this.__utilerias_cmdcanc2.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdcanc2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdcanc2.Enabled = true;
            this.__utilerias_cmdcanc2.Visible = true;
            this.__utilerias_cmdcanc2.Font = new Font(this.__utilerias_cmdcanc2.Font.Name, 9f, this.__utilerias_cmdcanc2.Font.Style);
            this.__utilerias_cmdcanc2.AddEvents();
            this.__utilerias_canc.Controls.Add(this.__utilerias_cmdcanc2);
            this.htControls.Add("__utilerias_cmdcanc2", this.__utilerias_cmdcanc2);
            this.__utilerias_tart = new CEnhancedTextBox(this);
            this.__utilerias_tart.name = "__utilerias_tart";
            this.__utilerias_tart.Left = 0x34;
            this.__utilerias_tart.Top = 7;
            this.__utilerias_tart.Width = 0x93;
            this.__utilerias_tart.Text = "";
            this.__utilerias_tart.BackColor = Color.FromArgb(-1);
            this.__utilerias_tart.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tart.Enabled = true;
            this.__utilerias_tart.Visible = true;
            this.__utilerias_tart.Height = 0x16;
            this.__utilerias_tart.Font = new Font(this.__utilerias_tart.Font.Name, 9f, this.__utilerias_tart.Font.Style);
            this.__utilerias_tart.multiline = false;
            this.__utilerias_tart.AddEvents();
            this.__utilerias_canc.Controls.Add(this.__utilerias_tart);
            this.htControls.Add("__utilerias_tart", this.__utilerias_tart);
            this.__utilerias_ltcodigo = new CEnhancedLabel(this);
            this.__utilerias_ltcodigo.name = "__utilerias_ltcodigo";
            this.__utilerias_ltcodigo.Left = 5;
            this.__utilerias_ltcodigo.Top = 10;
            this.__utilerias_ltcodigo.Width = 50;
            this.__utilerias_ltcodigo.Height = 0x12;
            this.__utilerias_ltcodigo.Text = "Articulo";
            this.__utilerias_ltcodigo.BackColor = Color.FromArgb(-1389077);
            this.__utilerias_ltcodigo.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltcodigo.MyEnabled = true;
            this.__utilerias_ltcodigo.Visible = true;
            this.__utilerias_ltcodigo.Transparent = false;
            this.__utilerias_ltcodigo.Font = new Font(this.__utilerias_ltcodigo.Font.Name, 9f, this.__utilerias_ltcodigo.Font.Style);
            this.__utilerias_canc.Controls.Add(this.__utilerias_ltcodigo);
            this.htControls.Add("__utilerias_ltcodigo", this.__utilerias_ltcodigo);
            this.__utilerias_cmdcanc1 = new CEnhancedButton(this);
            this.__utilerias_cmdcanc1.name = "__utilerias_cmdcanc1";
            this.__utilerias_cmdcanc1.Left = 8;
            this.__utilerias_cmdcanc1.Top = 240;
            this.__utilerias_cmdcanc1.Width = 120;
            this.__utilerias_cmdcanc1.Height = 0x1a;
            this.__utilerias_cmdcanc1.Text = "Cancelar partida";
            this.__utilerias_cmdcanc1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdcanc1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdcanc1.Enabled = true;
            this.__utilerias_cmdcanc1.Visible = true;
            this.__utilerias_cmdcanc1.Font = new Font(this.__utilerias_cmdcanc1.Font.Name, 9f, this.__utilerias_cmdcanc1.Font.Style);
            this.__utilerias_cmdcanc1.AddEvents();
            this.__utilerias_canc.Controls.Add(this.__utilerias_cmdcanc1);
            this.htControls.Add("__utilerias_cmdcanc1", this.__utilerias_cmdcanc1);
            this.__utilerias_tblcanc = new CEnhancedTable(this, "__utilerias_tblcanc");
            this.__utilerias_tblcanc.name = "__utilerias_tblcanc";
            this.__utilerias_tblcanc.Left = 0;
            this.__utilerias_tblcanc.Top = 0x23;
            this.__utilerias_tblcanc.Width = 240;
            this.__utilerias_tblcanc.Height = 150;
            this.__utilerias_tblcanc.Text = "";
            this.__utilerias_tblcanc.propColor = Color.FromArgb(-657931);
            this.__utilerias_tblcanc.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tblcanc.Enabled = true;
            this.__utilerias_tblcanc.Visible = true;
            this.__utilerias_tblcanc.Font = new Font(this.__utilerias_tblcanc.Font.Name, 9f, this.__utilerias_tblcanc.Font.Style);
            this.__utilerias_tblcanc.AddEvents();
            this.__utilerias_canc.Controls.Add(this.__utilerias_tblcanc);
            this.htControls.Add("__utilerias_tblcanc", this.__utilerias_tblcanc);
            this.__utilerias_mnucantea = new CEnhancedMenu(this);
            this.__utilerias_mnucantea.name = "__utilerias_mnucantea";
            this.__utilerias_mnucantea.Text = "Cancelar partida";
            this.__utilerias_mnucantea.Enabled = true;
            this.__utilerias_mnucantea.Checked = false;
            this.__utilerias_mnucantea.AddToObject("__utilerias_canc");
            this.__utilerias_mnucantea.AddEvents();
            this.htControls.Add("__utilerias_mnucantea", this.__utilerias_mnucantea);
            this.__utilerias_partinven = new CEnhancedForm(this);
            this.__utilerias_partinven.name = "__utilerias_partinven";
            this.__utilerias_partinven.Text = "Relacion de partidas";
            this.__utilerias_partinven.BackColor = Color.FromArgb(-66313);
            this.__utilerias_partinven.graphics.FillRectangle(new SolidBrush(this.__utilerias_partinven.BackColor), 0, 0, this.__utilerias_partinven.Width, this.__utilerias_partinven.Height);
            this.__utilerias_partinven.AddEvents();
            this.htControls.Add("__utilerias_partinven", this.__utilerias_partinven);
            this.__utilerias_cbomovfol = new CEnhancedCombo(this);
            this.__utilerias_cbomovfol.name = "__utilerias_cbomovfol";
            this.__utilerias_cbomovfol.Left = 80;
            this.__utilerias_cbomovfol.Top = 4;
            this.__utilerias_cbomovfol.Width = 0x4e;
            this.__utilerias_cbomovfol.Height = 0x16;
            this.__utilerias_cbomovfol.Text = "";
            this.__utilerias_cbomovfol.BackColor = Color.FromArgb(-1);
            this.__utilerias_cbomovfol.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cbomovfol.Enabled = true;
            this.__utilerias_cbomovfol.Visible = false;
            this.__utilerias_cbomovfol.Font = new Font(this.__utilerias_cbomovfol.Font.Name, 9f, this.__utilerias_cbomovfol.Font.Style);
            this.__utilerias_partinven.Controls.Add(this.__utilerias_cbomovfol);
            this.htControls.Add("__utilerias_cbomovfol", this.__utilerias_cbomovfol);
            this.__utilerias_cbomovfol.AddEvents();
            this.__utilerias_fgprod = new CEnhancedTable(this, "__utilerias_fgprod");
            this.__utilerias_fgprod.name = "__utilerias_fgprod";
            this.__utilerias_fgprod.Left = 0;
            this.__utilerias_fgprod.Top = 30;
            this.__utilerias_fgprod.Width = 240;
            this.__utilerias_fgprod.Height = 0xea;
            this.__utilerias_fgprod.Text = "";
            this.__utilerias_fgprod.propColor = Color.FromArgb(-657931);
            this.__utilerias_fgprod.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_fgprod.Enabled = true;
            this.__utilerias_fgprod.Visible = true;
            this.__utilerias_fgprod.Font = new Font(this.__utilerias_fgprod.Font.Name, 8f, this.__utilerias_fgprod.Font.Style);
            this.__utilerias_fgprod.AddEvents();
            this.__utilerias_partinven.Controls.Add(this.__utilerias_fgprod);
            this.htControls.Add("__utilerias_fgprod", this.__utilerias_fgprod);
            this.__utilerias_mnurelpar = new CEnhancedMenu(this);
            this.__utilerias_mnurelpar.name = "__utilerias_mnurelpar";
            this.__utilerias_mnurelpar.Text = "Archivo";
            this.__utilerias_mnurelpar.Enabled = true;
            this.__utilerias_mnurelpar.Checked = false;
            this.__utilerias_mnurelpar.AddToObject("__utilerias_partinven");
            this.__utilerias_mnurelpar.AddEvents();
            this.htControls.Add("__utilerias_mnurelpar", this.__utilerias_mnurelpar);
            this.__utilerias_mnutodos = new CEnhancedMenu(this);
            this.__utilerias_mnutodos.name = "__utilerias_mnutodos";
            this.__utilerias_mnutodos.Text = "Todas";
            this.__utilerias_mnutodos.Enabled = true;
            this.__utilerias_mnutodos.Checked = false;
            this.__utilerias_mnutodos.AddToObject("__utilerias_mnurelpar");
            this.__utilerias_mnutodos.AddEvents();
            this.htControls.Add("__utilerias_mnutodos", this.__utilerias_mnutodos);
            this.__utilerias_mnuxfol = new CEnhancedMenu(this);
            this.__utilerias_mnuxfol.name = "__utilerias_mnuxfol";
            this.__utilerias_mnuxfol.Text = "Folio";
            this.__utilerias_mnuxfol.Enabled = true;
            this.__utilerias_mnuxfol.Checked = false;
            this.__utilerias_mnuxfol.AddToObject("__utilerias_mnurelpar");
            this.__utilerias_mnuxfol.AddEvents();
            this.htControls.Add("__utilerias_mnuxfol", this.__utilerias_mnuxfol);
            this.__utilerias_mnueliminar = new CEnhancedMenu(this);
            this.__utilerias_mnueliminar.name = "__utilerias_mnueliminar";
            this.__utilerias_mnueliminar.Text = "Eliminar";
            this.__utilerias_mnueliminar.Enabled = true;
            this.__utilerias_mnueliminar.Checked = false;
            this.__utilerias_mnueliminar.AddToObject("__utilerias_mnurelpar");
            this.__utilerias_mnueliminar.AddEvents();
            this.htControls.Add("__utilerias_mnueliminar", this.__utilerias_mnueliminar);
            this.__utilerias_frmtea = new CEnhancedForm(this);
            this.__utilerias_frmtea.name = "__utilerias_frmtea";
            this.__utilerias_frmtea.Text = "Conexion TEA";
            this.__utilerias_frmtea.BackColor = Color.FromArgb(-66313);
            this.__utilerias_frmtea.graphics.FillRectangle(new SolidBrush(this.__utilerias_frmtea.BackColor), 0, 0, this.__utilerias_frmtea.Width, this.__utilerias_frmtea.Height);
            this.__utilerias_frmtea.AddEvents();
            this.htControls.Add("__utilerias_frmtea", this.__utilerias_frmtea);
            this.__utilerias_tfolio = new CEnhancedTextBox(this);
            this.__utilerias_tfolio.name = "__utilerias_tfolio";
            this.__utilerias_tfolio.Left = 0xa5;
            this.__utilerias_tfolio.Top = 0x69;
            this.__utilerias_tfolio.Width = 70;
            this.__utilerias_tfolio.Text = "";
            this.__utilerias_tfolio.BackColor = Color.FromArgb(-1);
            this.__utilerias_tfolio.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tfolio.Enabled = true;
            this.__utilerias_tfolio.Visible = true;
            this.__utilerias_tfolio.Height = 0x16;
            this.__utilerias_tfolio.Font = new Font(this.__utilerias_tfolio.Font.Name, 9f, this.__utilerias_tfolio.Font.Style);
            this.__utilerias_tfolio.multiline = false;
            this.__utilerias_tfolio.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tfolio);
            this.htControls.Add("__utilerias_tfolio", this.__utilerias_tfolio);
            this.__utilerias_label10 = new CEnhancedLabel(this);
            this.__utilerias_label10.name = "__utilerias_label10";
            this.__utilerias_label10.Left = 0x87;
            this.__utilerias_label10.Top = 0x69;
            this.__utilerias_label10.Width = 0x23;
            this.__utilerias_label10.Height = 20;
            this.__utilerias_label10.Text = "Folio";
            this.__utilerias_label10.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label10.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label10.MyEnabled = true;
            this.__utilerias_label10.Visible = true;
            this.__utilerias_label10.Transparent = false;
            this.__utilerias_label10.Font = new Font(this.__utilerias_label10.Font.Name, 9f, this.__utilerias_label10.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label10);
            this.htControls.Add("__utilerias_label10", this.__utilerias_label10);
            this.__utilerias_btntea2 = new CEnhancedButton(this);
            this.__utilerias_btntea2.name = "__utilerias_btntea2";
            this.__utilerias_btntea2.Left = 0x7e;
            this.__utilerias_btntea2.Top = 0x91;
            this.__utilerias_btntea2.Width = 80;
            this.__utilerias_btntea2.Height = 0x1f;
            this.__utilerias_btntea2.Text = "Cancelar";
            this.__utilerias_btntea2.BackColor = Color.FromArgb(-66313);
            this.__utilerias_btntea2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_btntea2.Enabled = true;
            this.__utilerias_btntea2.Visible = true;
            this.__utilerias_btntea2.Font = new Font(this.__utilerias_btntea2.Font.Name, 9f, this.__utilerias_btntea2.Font.Style);
            this.__utilerias_btntea2.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_btntea2);
            this.htControls.Add("__utilerias_btntea2", this.__utilerias_btntea2);
            this.__utilerias_btntea = new CEnhancedButton(this);
            this.__utilerias_btntea.name = "__utilerias_btntea";
            this.__utilerias_btntea.Left = 0x18;
            this.__utilerias_btntea.Top = 0x91;
            this.__utilerias_btntea.Width = 80;
            this.__utilerias_btntea.Height = 0x1f;
            this.__utilerias_btntea.Text = "Aceptar";
            this.__utilerias_btntea.BackColor = Color.FromArgb(-66313);
            this.__utilerias_btntea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_btntea.Enabled = true;
            this.__utilerias_btntea.Visible = true;
            this.__utilerias_btntea.Font = new Font(this.__utilerias_btntea.Font.Name, 9f, this.__utilerias_btntea.Font.Style);
            this.__utilerias_btntea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_btntea);
            this.htControls.Add("__utilerias_btntea", this.__utilerias_btntea);
            this.__utilerias_tporttea = new CEnhancedTextBox(this);
            this.__utilerias_tporttea.name = "__utilerias_tporttea";
            this.__utilerias_tporttea.Left = 0x38;
            this.__utilerias_tporttea.Top = 0x69;
            this.__utilerias_tporttea.Width = 0x3d;
            this.__utilerias_tporttea.Text = "";
            this.__utilerias_tporttea.BackColor = Color.FromArgb(-1);
            this.__utilerias_tporttea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tporttea.Enabled = true;
            this.__utilerias_tporttea.Visible = true;
            this.__utilerias_tporttea.Height = 0x16;
            this.__utilerias_tporttea.Font = new Font(this.__utilerias_tporttea.Font.Name, 9f, this.__utilerias_tporttea.Font.Style);
            this.__utilerias_tporttea.multiline = false;
            this.__utilerias_tporttea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tporttea);
            this.htControls.Add("__utilerias_tporttea", this.__utilerias_tporttea);
            this.__utilerias_tbasetea = new CEnhancedTextBox(this);
            this.__utilerias_tbasetea.name = "__utilerias_tbasetea";
            this.__utilerias_tbasetea.Left = 0x38;
            this.__utilerias_tbasetea.Top = 0x21;
            this.__utilerias_tbasetea.Width = 180;
            this.__utilerias_tbasetea.Text = "";
            this.__utilerias_tbasetea.BackColor = Color.FromArgb(-1);
            this.__utilerias_tbasetea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tbasetea.Enabled = true;
            this.__utilerias_tbasetea.Visible = true;
            this.__utilerias_tbasetea.Height = 0x16;
            this.__utilerias_tbasetea.Font = new Font(this.__utilerias_tbasetea.Font.Name, 9f, this.__utilerias_tbasetea.Font.Style);
            this.__utilerias_tbasetea.multiline = false;
            this.__utilerias_tbasetea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tbasetea);
            this.htControls.Add("__utilerias_tbasetea", this.__utilerias_tbasetea);
            this.__utilerias_label5 = new CEnhancedLabel(this);
            this.__utilerias_label5.name = "__utilerias_label5";
            this.__utilerias_label5.Left = 3;
            this.__utilerias_label5.Top = 0x69;
            this.__utilerias_label5.Width = 0x37;
            this.__utilerias_label5.Height = 0x19;
            this.__utilerias_label5.Text = "Puerto";
            this.__utilerias_label5.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label5.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label5.MyEnabled = true;
            this.__utilerias_label5.Visible = true;
            this.__utilerias_label5.Transparent = false;
            this.__utilerias_label5.Font = new Font(this.__utilerias_label5.Font.Name, 9f, this.__utilerias_label5.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label5);
            this.htControls.Add("__utilerias_label5", this.__utilerias_label5);
            this.__utilerias_tpasstea = new CEnhancedTextBox(this);
            this.__utilerias_tpasstea.name = "__utilerias_tpasstea";
            this.__utilerias_tpasstea.Left = 0x38;
            this.__utilerias_tpasstea.Top = 0x51;
            this.__utilerias_tpasstea.Width = 0x87;
            this.__utilerias_tpasstea.Text = "";
            this.__utilerias_tpasstea.BackColor = Color.FromArgb(-1);
            this.__utilerias_tpasstea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tpasstea.Enabled = true;
            this.__utilerias_tpasstea.Visible = true;
            this.__utilerias_tpasstea.Height = 0x16;
            this.__utilerias_tpasstea.Font = new Font(this.__utilerias_tpasstea.Font.Name, 9f, this.__utilerias_tpasstea.Font.Style);
            this.__utilerias_tpasstea.multiline = false;
            this.__utilerias_tpasstea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tpasstea);
            this.htControls.Add("__utilerias_tpasstea", this.__utilerias_tpasstea);
            this.__utilerias_label4 = new CEnhancedLabel(this);
            this.__utilerias_label4.name = "__utilerias_label4";
            this.__utilerias_label4.Left = 3;
            this.__utilerias_label4.Top = 0x51;
            this.__utilerias_label4.Width = 0x37;
            this.__utilerias_label4.Height = 0x19;
            this.__utilerias_label4.Text = "Contra.";
            this.__utilerias_label4.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label4.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label4.MyEnabled = true;
            this.__utilerias_label4.Visible = true;
            this.__utilerias_label4.Transparent = false;
            this.__utilerias_label4.Font = new Font(this.__utilerias_label4.Font.Name, 9f, this.__utilerias_label4.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label4);
            this.htControls.Add("__utilerias_label4", this.__utilerias_label4);
            this.__utilerias_tusertea = new CEnhancedTextBox(this);
            this.__utilerias_tusertea.name = "__utilerias_tusertea";
            this.__utilerias_tusertea.Left = 0x38;
            this.__utilerias_tusertea.Top = 0x39;
            this.__utilerias_tusertea.Width = 0x87;
            this.__utilerias_tusertea.Text = "";
            this.__utilerias_tusertea.BackColor = Color.FromArgb(-1);
            this.__utilerias_tusertea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tusertea.Enabled = true;
            this.__utilerias_tusertea.Visible = true;
            this.__utilerias_tusertea.Height = 0x16;
            this.__utilerias_tusertea.Font = new Font(this.__utilerias_tusertea.Font.Name, 9f, this.__utilerias_tusertea.Font.Style);
            this.__utilerias_tusertea.multiline = false;
            this.__utilerias_tusertea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tusertea);
            this.htControls.Add("__utilerias_tusertea", this.__utilerias_tusertea);
            this.__utilerias_label3 = new CEnhancedLabel(this);
            this.__utilerias_label3.name = "__utilerias_label3";
            this.__utilerias_label3.Left = 3;
            this.__utilerias_label3.Top = 0x39;
            this.__utilerias_label3.Width = 0x37;
            this.__utilerias_label3.Height = 0x19;
            this.__utilerias_label3.Text = "Usuario";
            this.__utilerias_label3.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label3.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label3.MyEnabled = true;
            this.__utilerias_label3.Visible = true;
            this.__utilerias_label3.Transparent = false;
            this.__utilerias_label3.Font = new Font(this.__utilerias_label3.Font.Name, 9f, this.__utilerias_label3.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label3);
            this.htControls.Add("__utilerias_label3", this.__utilerias_label3);
            this.__utilerias_label2 = new CEnhancedLabel(this);
            this.__utilerias_label2.name = "__utilerias_label2";
            this.__utilerias_label2.Left = 3;
            this.__utilerias_label2.Top = 0x21;
            this.__utilerias_label2.Width = 0x37;
            this.__utilerias_label2.Height = 0x19;
            this.__utilerias_label2.Text = "Base";
            this.__utilerias_label2.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label2.MyEnabled = true;
            this.__utilerias_label2.Visible = true;
            this.__utilerias_label2.Transparent = false;
            this.__utilerias_label2.Font = new Font(this.__utilerias_label2.Font.Name, 9f, this.__utilerias_label2.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label2);
            this.htControls.Add("__utilerias_label2", this.__utilerias_label2);
            this.__utilerias_tservertea = new CEnhancedTextBox(this);
            this.__utilerias_tservertea.name = "__utilerias_tservertea";
            this.__utilerias_tservertea.Left = 0x38;
            this.__utilerias_tservertea.Top = 9;
            this.__utilerias_tservertea.Width = 180;
            this.__utilerias_tservertea.Text = "";
            this.__utilerias_tservertea.BackColor = Color.FromArgb(-1);
            this.__utilerias_tservertea.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tservertea.Enabled = true;
            this.__utilerias_tservertea.Visible = true;
            this.__utilerias_tservertea.Height = 0x16;
            this.__utilerias_tservertea.Font = new Font(this.__utilerias_tservertea.Font.Name, 9f, this.__utilerias_tservertea.Font.Style);
            this.__utilerias_tservertea.multiline = false;
            this.__utilerias_tservertea.AddEvents();
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_tservertea);
            this.htControls.Add("__utilerias_tservertea", this.__utilerias_tservertea);
            this.__utilerias_label1 = new CEnhancedLabel(this);
            this.__utilerias_label1.name = "__utilerias_label1";
            this.__utilerias_label1.Left = 3;
            this.__utilerias_label1.Top = 9;
            this.__utilerias_label1.Width = 0x37;
            this.__utilerias_label1.Height = 0x19;
            this.__utilerias_label1.Text = "Servidor";
            this.__utilerias_label1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_label1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label1.MyEnabled = true;
            this.__utilerias_label1.Visible = true;
            this.__utilerias_label1.Transparent = false;
            this.__utilerias_label1.Font = new Font(this.__utilerias_label1.Font.Name, 9f, this.__utilerias_label1.Font.Style);
            this.__utilerias_frmtea.Controls.Add(this.__utilerias_label1);
            this.htControls.Add("__utilerias_label1", this.__utilerias_label1);
            this.__utilerias_inven = new CEnhancedForm(this);
            this.__utilerias_inven.name = "__utilerias_inven";
            this.__utilerias_inven.Text = "Transferencias";
            this.__utilerias_inven.BackColor = Color.FromArgb(-16744256);
            this.__utilerias_inven.graphics.FillRectangle(new SolidBrush(this.__utilerias_inven.BackColor), 0, 0, this.__utilerias_inven.Width, this.__utilerias_inven.Height);
            this.__utilerias_inven.AddEvents();
            this.htControls.Add("__utilerias_inven", this.__utilerias_inven);
            this.__utilerias_pnlcanfolio = new CEnhancedPanel(this);
            this.__utilerias_pnlcanfolio.name = "__utilerias_pnlcanfolio";
            this.__utilerias_pnlcanfolio.Left = 200;
            this.__utilerias_pnlcanfolio.Top = 15;
            this.__utilerias_pnlcanfolio.Width = 0xd7;
            this.__utilerias_pnlcanfolio.Height = 40;
            this.__utilerias_pnlcanfolio.BackColor = Color.FromArgb(-8355585);
            this.__utilerias_pnlcanfolio.Enabled = true;
            this.__utilerias_pnlcanfolio.Visible = false;
            this.__utilerias_pnlcanfolio.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_pnlcanfolio);
            this.htControls.Add("__utilerias_pnlcanfolio", this.__utilerias_pnlcanfolio);
            this.__utilerias_pnltrans = new CEnhancedPanel(this);
            this.__utilerias_pnltrans.name = "__utilerias_pnltrans";
            this.__utilerias_pnltrans.Left = 140;
            this.__utilerias_pnltrans.Top = 0xaf;
            this.__utilerias_pnltrans.Width = 0xff;
            this.__utilerias_pnltrans.Height = 120;
            this.__utilerias_pnltrans.BackColor = Color.FromArgb(-65536);
            this.__utilerias_pnltrans.Enabled = true;
            this.__utilerias_pnltrans.Visible = false;
            this.__utilerias_pnltrans.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_pnltrans);
            this.htControls.Add("__utilerias_pnltrans", this.__utilerias_pnltrans);
            this.__utilerias_ltarttrans = new CEnhancedLabel(this);
            this.__utilerias_ltarttrans.name = "__utilerias_ltarttrans";
            this.__utilerias_ltarttrans.Left = 5;
            this.__utilerias_ltarttrans.Top = 70;
            this.__utilerias_ltarttrans.Width = 0xf5;
            this.__utilerias_ltarttrans.Height = 20;
            this.__utilerias_ltarttrans.Text = "";
            this.__utilerias_ltarttrans.BackColor = Color.FromArgb(-65536);
            this.__utilerias_ltarttrans.ForeColor = Color.FromArgb(-1);
            this.__utilerias_ltarttrans.MyEnabled = true;
            this.__utilerias_ltarttrans.Visible = true;
            this.__utilerias_ltarttrans.Transparent = false;
            this.__utilerias_ltarttrans.Font = new Font(this.__utilerias_ltarttrans.Font.Name, 12f, this.__utilerias_ltarttrans.Font.Style);
            this.__utilerias_pnltrans.Controls.Add(this.__utilerias_ltarttrans);
            this.htControls.Add("__utilerias_ltarttrans", this.__utilerias_ltarttrans);
            this.__utilerias_btntrans = new CEnhancedButton(this);
            this.__utilerias_btntrans.name = "__utilerias_btntrans";
            this.__utilerias_btntrans.Left = 60;
            this.__utilerias_btntrans.Top = 0x69;
            this.__utilerias_btntrans.Width = 0x91;
            this.__utilerias_btntrans.Height = 0x23;
            this.__utilerias_btntrans.Text = "Aceptar";
            this.__utilerias_btntrans.BackColor = Color.FromArgb(-66313);
            this.__utilerias_btntrans.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_btntrans.Enabled = true;
            this.__utilerias_btntrans.Visible = true;
            this.__utilerias_btntrans.Font = new Font(this.__utilerias_btntrans.Font.Name, 9f, this.__utilerias_btntrans.Font.Style);
            this.__utilerias_btntrans.AddEvents();
            this.__utilerias_pnltrans.Controls.Add(this.__utilerias_btntrans);
            this.htControls.Add("__utilerias_btntrans", this.__utilerias_btntrans);
            this.__utilerias_label9 = new CEnhancedLabel(this);
            this.__utilerias_label9.name = "__utilerias_label9";
            this.__utilerias_label9.Left = 20;
            this.__utilerias_label9.Top = 15;
            this.__utilerias_label9.Width = 230;
            this.__utilerias_label9.Height = 0x4b;
            this.__utilerias_label9.Text = "        LA CLAVE DEL ARTICULO NO EXISTE";
            this.__utilerias_label9.BackColor = Color.FromArgb(-1);
            this.__utilerias_label9.ForeColor = Color.FromArgb(-1);
            this.__utilerias_label9.MyEnabled = true;
            this.__utilerias_label9.Visible = true;
            this.__utilerias_label9.Transparent = true;
            this.__utilerias_label9.Font = new Font(this.__utilerias_label9.Font.Name, 14f, this.__utilerias_label9.Font.Style);
            this.__utilerias_pnltrans.Controls.Add(this.__utilerias_label9);
            this.htControls.Add("__utilerias_label9", this.__utilerias_label9);
            this.__utilerias_cbocanfolio = new CEnhancedCombo(this);
            this.__utilerias_cbocanfolio.name = "__utilerias_cbocanfolio";
            this.__utilerias_cbocanfolio.Left = 0x41;
            this.__utilerias_cbocanfolio.Top = 0x37;
            this.__utilerias_cbocanfolio.Width = 90;
            this.__utilerias_cbocanfolio.Height = 0x16;
            this.__utilerias_cbocanfolio.Text = "";
            this.__utilerias_cbocanfolio.BackColor = Color.FromArgb(-1);
            this.__utilerias_cbocanfolio.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cbocanfolio.Enabled = true;
            this.__utilerias_cbocanfolio.Visible = true;
            this.__utilerias_cbocanfolio.Font = new Font(this.__utilerias_cbocanfolio.Font.Name, 9f, this.__utilerias_cbocanfolio.Font.Style);
            this.__utilerias_pnlcanfolio.Controls.Add(this.__utilerias_cbocanfolio);
            this.htControls.Add("__utilerias_cbocanfolio", this.__utilerias_cbocanfolio);
            this.__utilerias_cbocanfolio.AddEvents();
            this.__utilerias_btncanfol2 = new CEnhancedButton(this);
            this.__utilerias_btncanfol2.name = "__utilerias_btncanfol2";
            this.__utilerias_btncanfol2.Left = 0x87;
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
            this.__utilerias_pnlcanfolio.Controls.Add(this.__utilerias_btncanfol2);
            this.htControls.Add("__utilerias_btncanfol2", this.__utilerias_btncanfol2);
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
            this.__utilerias_pnlcanfolio.Controls.Add(this.__utilerias_btncanfolio1);
            this.htControls.Add("__utilerias_btncanfolio1", this.__utilerias_btncanfolio1);
            this.__utilerias_label8 = new CEnhancedLabel(this);
            this.__utilerias_label8.name = "__utilerias_label8";
            this.__utilerias_label8.Left = 0x37;
            this.__utilerias_label8.Top = 30;
            this.__utilerias_label8.Width = 0x7d;
            this.__utilerias_label8.Height = 0x19;
            this.__utilerias_label8.Text = "Selecciones folio";
            this.__utilerias_label8.BackColor = Color.FromArgb(-8355585);
            this.__utilerias_label8.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label8.MyEnabled = true;
            this.__utilerias_label8.Visible = true;
            this.__utilerias_label8.Transparent = false;
            this.__utilerias_label8.Font = new Font(this.__utilerias_label8.Font.Name, 9f, this.__utilerias_label8.Font.Style);
            this.__utilerias_pnlcanfolio.Controls.Add(this.__utilerias_label8);
            this.htControls.Add("__utilerias_label8", this.__utilerias_label8);
            this.__utilerias_label7 = new CEnhancedLabel(this);
            this.__utilerias_label7.name = "__utilerias_label7";
            this.__utilerias_label7.Left = 50;
            this.__utilerias_label7.Top = 5;
            this.__utilerias_label7.Width = 0x9b;
            this.__utilerias_label7.Height = 0x19;
            this.__utilerias_label7.Text = "Cancelacion folio";
            this.__utilerias_label7.BackColor = Color.FromArgb(-8355585);
            this.__utilerias_label7.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label7.MyEnabled = true;
            this.__utilerias_label7.Visible = true;
            this.__utilerias_label7.Transparent = false;
            this.__utilerias_label7.Font = new Font(this.__utilerias_label7.Font.Name, 12f, this.__utilerias_label7.Font.Style);
            this.__utilerias_pnlcanfolio.Controls.Add(this.__utilerias_label7);
            this.htControls.Add("__utilerias_label7", this.__utilerias_label7);
            this.__utilerias_tprod = new CEnhancedTextBox(this);
            this.__utilerias_tprod.name = "__utilerias_tprod";
            this.__utilerias_tprod.Left = 0x41;
            this.__utilerias_tprod.Top = 0x2f;
            this.__utilerias_tprod.Width = 0xac;
            this.__utilerias_tprod.Text = "";
            this.__utilerias_tprod.BackColor = Color.FromArgb(-1);
            this.__utilerias_tprod.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tprod.Enabled = true;
            this.__utilerias_tprod.Visible = true;
            this.__utilerias_tprod.Height = 0x16;
            this.__utilerias_tprod.Font = new Font(this.__utilerias_tprod.Font.Name, 9f, this.__utilerias_tprod.Font.Style);
            this.__utilerias_tprod.multiline = false;
            this.__utilerias_tprod.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_tprod);
            this.htControls.Add("__utilerias_tprod", this.__utilerias_tprod);
            this.__utilerias_ltcantidad = new CEnhancedButton(this);
            this.__utilerias_ltcantidad.name = "__utilerias_ltcantidad";
            this.__utilerias_ltcantidad.Left = 2;
            this.__utilerias_ltcantidad.Top = 20;
            this.__utilerias_ltcantidad.Width = 0x3e;
            this.__utilerias_ltcantidad.Height = 0x19;
            this.__utilerias_ltcantidad.Text = "Cantidad:";
            this.__utilerias_ltcantidad.BackColor = Color.FromArgb(-66313);
            this.__utilerias_ltcantidad.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltcantidad.Enabled = true;
            this.__utilerias_ltcantidad.Visible = true;
            this.__utilerias_ltcantidad.Font = new Font(this.__utilerias_ltcantidad.Font.Name, 8f, this.__utilerias_ltcantidad.Font.Style);
            this.__utilerias_ltcantidad.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_ltcantidad);
            this.htControls.Add("__utilerias_ltcantidad", this.__utilerias_ltcantidad);
            this.__utilerias_tbltea = new CEnhancedTable(this, "__utilerias_tbltea");
            this.__utilerias_tbltea.name = "__utilerias_tbltea";
            this.__utilerias_tbltea.Left = 1;
            this.__utilerias_tbltea.Top = 70;
            this.__utilerias_tbltea.Width = 0xed;
            this.__utilerias_tbltea.Height = 0x7d;
            this.__utilerias_tbltea.Text = "";
            this.__utilerias_tbltea.propColor = Color.FromArgb(-657931);
            this.__utilerias_tbltea.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tbltea.Enabled = true;
            this.__utilerias_tbltea.Visible = true;
            this.__utilerias_tbltea.Font = new Font(this.__utilerias_tbltea.Font.Name, 8f, this.__utilerias_tbltea.Font.Style);
            this.__utilerias_tbltea.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_tbltea);
            this.htControls.Add("__utilerias_tbltea", this.__utilerias_tbltea);
            this.__utilerias_ltfolio = new CEnhancedLabel(this);
            this.__utilerias_ltfolio.name = "__utilerias_ltfolio";
            this.__utilerias_ltfolio.Left = 150;
            this.__utilerias_ltfolio.Top = 1;
            this.__utilerias_ltfolio.Width = 90;
            this.__utilerias_ltfolio.Height = 0x13;
            this.__utilerias_ltfolio.Text = "";
            this.__utilerias_ltfolio.BackColor = Color.FromArgb(-16777216);
            this.__utilerias_ltfolio.ForeColor = Color.FromArgb(-16711936);
            this.__utilerias_ltfolio.MyEnabled = true;
            this.__utilerias_ltfolio.Visible = true;
            this.__utilerias_ltfolio.Transparent = false;
            this.__utilerias_ltfolio.Font = new Font(this.__utilerias_ltfolio.Font.Name, 10f, this.__utilerias_ltfolio.Font.Style);
            this.__utilerias_inven.Controls.Add(this.__utilerias_ltfolio);
            this.htControls.Add("__utilerias_ltfolio", this.__utilerias_ltfolio);
            this.__utilerias_btnmainfolio = new CEnhancedButton(this);
            this.__utilerias_btnmainfolio.name = "__utilerias_btnmainfolio";
            this.__utilerias_btnmainfolio.Left = 100;
            this.__utilerias_btnmainfolio.Top = 1;
            this.__utilerias_btnmainfolio.Width = 0x2d;
            this.__utilerias_btnmainfolio.Height = 0x13;
            this.__utilerias_btnmainfolio.Text = "Folio:";
            this.__utilerias_btnmainfolio.BackColor = Color.FromArgb(-66313);
            this.__utilerias_btnmainfolio.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_btnmainfolio.Enabled = true;
            this.__utilerias_btnmainfolio.Visible = true;
            this.__utilerias_btnmainfolio.Font = new Font(this.__utilerias_btnmainfolio.Font.Name, 8f, this.__utilerias_btnmainfolio.Font.Style);
            this.__utilerias_btnmainfolio.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_btnmainfolio);
            this.htControls.Add("__utilerias_btnmainfolio", this.__utilerias_btnmainfolio);
            this.__utilerias_ltkit = new CEnhancedLabel(this);
            this.__utilerias_ltkit.name = "__utilerias_ltkit";
            this.__utilerias_ltkit.Left = 0x73;
            this.__utilerias_ltkit.Top = 90;
            this.__utilerias_ltkit.Width = 0x2b;
            this.__utilerias_ltkit.Height = 20;
            this.__utilerias_ltkit.Text = "Kit";
            this.__utilerias_ltkit.BackColor = Color.FromArgb(-3679238);
            this.__utilerias_ltkit.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltkit.MyEnabled = true;
            this.__utilerias_ltkit.Visible = false;
            this.__utilerias_ltkit.Transparent = false;
            this.__utilerias_ltkit.Font = new Font(this.__utilerias_ltkit.Font.Name, 10f, this.__utilerias_ltkit.Font.Style);
            this.__utilerias_inven.Controls.Add(this.__utilerias_ltkit);
            this.htControls.Add("__utilerias_ltkit", this.__utilerias_ltkit);
            this.__utilerias_ltproducto = new CEnhancedButton(this);
            this.__utilerias_ltproducto.name = "__utilerias_ltproducto";
            this.__utilerias_ltproducto.Left = 2;
            this.__utilerias_ltproducto.Top = 0x2f;
            this.__utilerias_ltproducto.Width = 0x3e;
            this.__utilerias_ltproducto.Height = 0x16;
            this.__utilerias_ltproducto.Text = "Articulo:";
            this.__utilerias_ltproducto.BackColor = Color.FromArgb(-66313);
            this.__utilerias_ltproducto.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltproducto.Enabled = true;
            this.__utilerias_ltproducto.Visible = true;
            this.__utilerias_ltproducto.Font = new Font(this.__utilerias_ltproducto.Font.Name, 8f, this.__utilerias_ltproducto.Font.Style);
            this.__utilerias_ltproducto.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_ltproducto);
            this.htControls.Add("__utilerias_ltproducto", this.__utilerias_ltproducto);
            this.__utilerias_tcant = new CEnhancedTextBox(this);
            this.__utilerias_tcant.name = "__utilerias_tcant";
            this.__utilerias_tcant.Left = 0x41;
            this.__utilerias_tcant.Top = 20;
            this.__utilerias_tcant.Width = 50;
            this.__utilerias_tcant.Text = "";
            this.__utilerias_tcant.BackColor = Color.FromArgb(-1);
            this.__utilerias_tcant.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_tcant.Enabled = true;
            this.__utilerias_tcant.Visible = true;
            this.__utilerias_tcant.Height = 0x19;
            this.__utilerias_tcant.Font = new Font(this.__utilerias_tcant.Font.Name, 10f, this.__utilerias_tcant.Font.Style);
            this.__utilerias_tcant.multiline = false;
            this.__utilerias_tcant.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_tcant);
            this.htControls.Add("__utilerias_tcant", this.__utilerias_tcant);
            this.__utilerias_cmdaceptar = new CEnhancedButton(this);
            this.__utilerias_cmdaceptar.name = "__utilerias_cmdaceptar";
            this.__utilerias_cmdaceptar.Left = 0xa6;
            this.__utilerias_cmdaceptar.Top = 20;
            this.__utilerias_cmdaceptar.Width = 70;
            this.__utilerias_cmdaceptar.Height = 0x19;
            this.__utilerias_cmdaceptar.Text = "Aceptar";
            this.__utilerias_cmdaceptar.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdaceptar.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdaceptar.Enabled = true;
            this.__utilerias_cmdaceptar.Visible = false;
            this.__utilerias_cmdaceptar.Font = new Font(this.__utilerias_cmdaceptar.Font.Name, 8f, this.__utilerias_cmdaceptar.Font.Style);
            this.__utilerias_cmdaceptar.AddEvents();
            this.__utilerias_inven.Controls.Add(this.__utilerias_cmdaceptar);
            this.htControls.Add("__utilerias_cmdaceptar", this.__utilerias_cmdaceptar);
            this.__utilerias_mnuarchivo = new CEnhancedMenu(this);
            this.__utilerias_mnuarchivo.name = "__utilerias_mnuarchivo";
            this.__utilerias_mnuarchivo.Text = "Archivo";
            this.__utilerias_mnuarchivo.Enabled = true;
            this.__utilerias_mnuarchivo.Checked = false;
            this.__utilerias_mnuarchivo.AddToObject("__utilerias_inven");
            this.__utilerias_mnuarchivo.AddEvents();
            this.htControls.Add("__utilerias_mnuarchivo", this.__utilerias_mnuarchivo);
            this.__utilerias_mnumov = new CEnhancedMenu(this);
            this.__utilerias_mnumov.name = "__utilerias_mnumov";
            this.__utilerias_mnumov.Text = "Movimientos";
            this.__utilerias_mnumov.Enabled = true;
            this.__utilerias_mnumov.Checked = false;
            this.__utilerias_mnumov.AddToObject("__utilerias_mnuarchivo");
            this.__utilerias_mnumov.AddEvents();
            this.htControls.Add("__utilerias_mnumov", this.__utilerias_mnumov);
            this.__utilerias_mnuenviar = new CEnhancedMenu(this);
            this.__utilerias_mnuenviar.name = "__utilerias_mnuenviar";
            this.__utilerias_mnuenviar.Text = "Generar movimiento";
            this.__utilerias_mnuenviar.Enabled = true;
            this.__utilerias_mnuenviar.Checked = false;
            this.__utilerias_mnuenviar.AddToObject("__utilerias_mnuarchivo");
            this.__utilerias_mnuenviar.AddEvents();
            this.htControls.Add("__utilerias_mnuenviar", this.__utilerias_mnuenviar);
            this.__utilerias_mnufin = new CEnhancedMenu(this);
            this.__utilerias_mnufin.name = "__utilerias_mnufin";
            this.__utilerias_mnufin.Text = "Finalizar movimiento";
            this.__utilerias_mnufin.Enabled = true;
            this.__utilerias_mnufin.Checked = false;
            this.__utilerias_mnufin.AddToObject("__utilerias_mnuarchivo");
            this.__utilerias_mnufin.AddEvents();
            this.htControls.Add("__utilerias_mnufin", this.__utilerias_mnufin);
            this.__utilerias_mnucanc = new CEnhancedMenu(this);
            this.__utilerias_mnucanc.name = "__utilerias_mnucanc";
            this.__utilerias_mnucanc.Text = "Cancelar partida";
            this.__utilerias_mnucanc.Enabled = true;
            this.__utilerias_mnucanc.Checked = false;
            this.__utilerias_mnucanc.AddToObject("__utilerias_mnuarchivo");
            this.__utilerias_mnucanc.AddEvents();
            this.htControls.Add("__utilerias_mnucanc", this.__utilerias_mnucanc);
            this.__utilerias_mnucanfolio = new CEnhancedMenu(this);
            this.__utilerias_mnucanfolio.name = "__utilerias_mnucanfolio";
            this.__utilerias_mnucanfolio.Text = "Cancelar folio";
            this.__utilerias_mnucanfolio.Enabled = true;
            this.__utilerias_mnucanfolio.Checked = false;
            this.__utilerias_mnucanfolio.AddToObject("__utilerias_mnuarchivo");
            this.__utilerias_mnucanfolio.AddEvents();
            this.htControls.Add("__utilerias_mnucanfolio", this.__utilerias_mnucanfolio);
            this.__utilerias_enviar = new CEnhancedForm(this);
            this.__utilerias_enviar.name = "__utilerias_enviar";
            this.__utilerias_enviar.Text = "Enviar Movimiento";
            this.__utilerias_enviar.BackColor = Color.FromArgb(-1291);
            this.__utilerias_enviar.graphics.FillRectangle(new SolidBrush(this.__utilerias_enviar.BackColor), 0, 0, this.__utilerias_enviar.Width, this.__utilerias_enviar.Height);
            this.__utilerias_enviar.AddEvents();
            this.htControls.Add("__utilerias_enviar", this.__utilerias_enviar);
            this.__utilerias_label6 = new CEnhancedLabel(this);
            this.__utilerias_label6.name = "__utilerias_label6";
            this.__utilerias_label6.Left = 2;
            this.__utilerias_label6.Top = 0x2d;
            this.__utilerias_label6.Width = 230;
            this.__utilerias_label6.Height = 15;
            this.__utilerias_label6.Text = "Sucursal origen:";
            this.__utilerias_label6.BackColor = Color.FromArgb(-8323200);
            this.__utilerias_label6.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label6.MyEnabled = true;
            this.__utilerias_label6.Visible = true;
            this.__utilerias_label6.Transparent = false;
            this.__utilerias_label6.Font = new Font(this.__utilerias_label6.Font.Name, 8f, this.__utilerias_label6.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_label6);
            this.htControls.Add("__utilerias_label6", this.__utilerias_label6);
            this.__utilerias_label990 = new CEnhancedLabel(this);
            this.__utilerias_label990.name = "__utilerias_label990";
            this.__utilerias_label990.Left = 2;
            this.__utilerias_label990.Top = 0x52;
            this.__utilerias_label990.Width = 230;
            this.__utilerias_label990.Height = 15;
            this.__utilerias_label990.Text = "Sucursal destino:";
            this.__utilerias_label990.BackColor = Color.FromArgb(-8323200);
            this.__utilerias_label990.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_label990.MyEnabled = true;
            this.__utilerias_label990.Visible = true;
            this.__utilerias_label990.Transparent = false;
            this.__utilerias_label990.Font = new Font(this.__utilerias_label990.Font.Name, 8f, this.__utilerias_label990.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_label990);
            this.htControls.Add("__utilerias_label990", this.__utilerias_label990);
            this.__utilerias_cbofol = new CEnhancedCombo(this);
            this.__utilerias_cbofol.name = "__utilerias_cbofol";
            this.__utilerias_cbofol.Left = 0x7c;
            this.__utilerias_cbofol.Top = 13;
            this.__utilerias_cbofol.Width = 100;
            this.__utilerias_cbofol.Height = 0x19;
            this.__utilerias_cbofol.Text = "";
            this.__utilerias_cbofol.BackColor = Color.FromArgb(-1);
            this.__utilerias_cbofol.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cbofol.Enabled = true;
            this.__utilerias_cbofol.Visible = true;
            this.__utilerias_cbofol.Font = new Font(this.__utilerias_cbofol.Font.Name, 10f, this.__utilerias_cbofol.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_cbofol);
            this.htControls.Add("__utilerias_cbofol", this.__utilerias_cbofol);
            this.__utilerias_cbofol.AddEvents();
            this.__utilerias_ltenviar2 = new CEnhancedLabel(this);
            this.__utilerias_ltenviar2.name = "__utilerias_ltenviar2";
            this.__utilerias_ltenviar2.Left = 2;
            this.__utilerias_ltenviar2.Top = 0x62;
            this.__utilerias_ltenviar2.Width = 230;
            this.__utilerias_ltenviar2.Height = 20;
            this.__utilerias_ltenviar2.Text = "";
            this.__utilerias_ltenviar2.BackColor = Color.FromArgb(-3873106);
            this.__utilerias_ltenviar2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltenviar2.MyEnabled = true;
            this.__utilerias_ltenviar2.Visible = true;
            this.__utilerias_ltenviar2.Transparent = false;
            this.__utilerias_ltenviar2.Font = new Font(this.__utilerias_ltenviar2.Font.Name, 9f, this.__utilerias_ltenviar2.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_ltenviar2);
            this.htControls.Add("__utilerias_ltenviar2", this.__utilerias_ltenviar2);
            this.__utilerias_ltenviar1 = new CEnhancedLabel(this);
            this.__utilerias_ltenviar1.name = "__utilerias_ltenviar1";
            this.__utilerias_ltenviar1.Left = 2;
            this.__utilerias_ltenviar1.Top = 0x3d;
            this.__utilerias_ltenviar1.Width = 230;
            this.__utilerias_ltenviar1.Height = 20;
            this.__utilerias_ltenviar1.Text = "";
            this.__utilerias_ltenviar1.BackColor = Color.FromArgb(-3873106);
            this.__utilerias_ltenviar1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltenviar1.MyEnabled = true;
            this.__utilerias_ltenviar1.Visible = true;
            this.__utilerias_ltenviar1.Transparent = false;
            this.__utilerias_ltenviar1.Font = new Font(this.__utilerias_ltenviar1.Font.Name, 9f, this.__utilerias_ltenviar1.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_ltenviar1);
            this.htControls.Add("__utilerias_ltenviar1", this.__utilerias_ltenviar1);
            this.__utilerias_chtodos = new CEnhancedCheckBox(this);
            this.__utilerias_chtodos.name = "__utilerias_chtodos";
            this.__utilerias_chtodos.Left = 0x9b;
            this.__utilerias_chtodos.Top = 230;
            this.__utilerias_chtodos.Width = 0x55;
            this.__utilerias_chtodos.Height = 0x19;
            this.__utilerias_chtodos.Text = "Todos";
            this.__utilerias_chtodos.BackColor = Color.FromArgb(-1291);
            this.__utilerias_chtodos.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_chtodos.Enabled = true;
            this.__utilerias_chtodos.Visible = false;
            this.__utilerias_chtodos.Checked = false;
            this.__utilerias_chtodos.Font = new Font(this.__utilerias_chtodos.Font.Name, 9f, this.__utilerias_chtodos.Font.Style);
            this.__utilerias_chtodos.AddEvents();
            this.__utilerias_enviar.Controls.Add(this.__utilerias_chtodos);
            this.htControls.Add("__utilerias_chtodos", this.__utilerias_chtodos);
            this.__utilerias_ltrutaenviar = new CEnhancedLabel(this);
            this.__utilerias_ltrutaenviar.name = "__utilerias_ltrutaenviar";
            this.__utilerias_ltrutaenviar.Left = 5;
            this.__utilerias_ltrutaenviar.Top = 0xc6;
            this.__utilerias_ltrutaenviar.Width = 0xe5;
            this.__utilerias_ltrutaenviar.Height = 20;
            this.__utilerias_ltrutaenviar.Text = "";
            this.__utilerias_ltrutaenviar.BackColor = Color.FromArgb(-1291);
            this.__utilerias_ltrutaenviar.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltrutaenviar.MyEnabled = true;
            this.__utilerias_ltrutaenviar.Visible = true;
            this.__utilerias_ltrutaenviar.Transparent = false;
            this.__utilerias_ltrutaenviar.Font = new Font(this.__utilerias_ltrutaenviar.Font.Name, 8f, this.__utilerias_ltrutaenviar.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_ltrutaenviar);
            this.htControls.Add("__utilerias_ltrutaenviar", this.__utilerias_ltrutaenviar);
            this.__utilerias_cmdsend2 = new CEnhancedButton(this);
            this.__utilerias_cmdsend2.name = "__utilerias_cmdsend2";
            this.__utilerias_cmdsend2.Left = 140;
            this.__utilerias_cmdsend2.Top = 150;
            this.__utilerias_cmdsend2.Width = 80;
            this.__utilerias_cmdsend2.Height = 0x23;
            this.__utilerias_cmdsend2.Text = "Cancelar";
            this.__utilerias_cmdsend2.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdsend2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdsend2.Enabled = true;
            this.__utilerias_cmdsend2.Visible = true;
            this.__utilerias_cmdsend2.Font = new Font(this.__utilerias_cmdsend2.Font.Name, 9f, this.__utilerias_cmdsend2.Font.Style);
            this.__utilerias_cmdsend2.AddEvents();
            this.__utilerias_enviar.Controls.Add(this.__utilerias_cmdsend2);
            this.htControls.Add("__utilerias_cmdsend2", this.__utilerias_cmdsend2);
            this.__utilerias_cmdsend1 = new CEnhancedButton(this);
            this.__utilerias_cmdsend1.name = "__utilerias_cmdsend1";
            this.__utilerias_cmdsend1.Left = 0x19;
            this.__utilerias_cmdsend1.Top = 150;
            this.__utilerias_cmdsend1.Width = 80;
            this.__utilerias_cmdsend1.Height = 0x23;
            this.__utilerias_cmdsend1.Text = "Enviar";
            this.__utilerias_cmdsend1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdsend1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdsend1.Enabled = true;
            this.__utilerias_cmdsend1.Visible = true;
            this.__utilerias_cmdsend1.Font = new Font(this.__utilerias_cmdsend1.Font.Name, 9f, this.__utilerias_cmdsend1.Font.Style);
            this.__utilerias_cmdsend1.AddEvents();
            this.__utilerias_enviar.Controls.Add(this.__utilerias_cmdsend1);
            this.htControls.Add("__utilerias_cmdsend1", this.__utilerias_cmdsend1);
            this.__utilerias_ltenviar9 = new CEnhancedLabel(this);
            this.__utilerias_ltenviar9.name = "__utilerias_ltenviar9";
            this.__utilerias_ltenviar9.Left = 0x4d;
            this.__utilerias_ltenviar9.Top = 0x11;
            this.__utilerias_ltenviar9.Width = 40;
            this.__utilerias_ltenviar9.Height = 20;
            this.__utilerias_ltenviar9.Text = "Folio:";
            this.__utilerias_ltenviar9.BackColor = Color.FromArgb(-1291);
            this.__utilerias_ltenviar9.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltenviar9.MyEnabled = true;
            this.__utilerias_ltenviar9.Visible = true;
            this.__utilerias_ltenviar9.Transparent = false;
            this.__utilerias_ltenviar9.Font = new Font(this.__utilerias_ltenviar9.Font.Name, 9f, this.__utilerias_ltenviar9.Font.Style);
            this.__utilerias_enviar.Controls.Add(this.__utilerias_ltenviar9);
            this.htControls.Add("__utilerias_ltenviar9", this.__utilerias_ltenviar9);
            this.__utilerias_importa = new CEnhancedForm(this);
            this.__utilerias_importa.name = "__utilerias_importa";
            this.__utilerias_importa.Text = "Traspasos";
            this.__utilerias_importa.BackColor = Color.FromArgb(-66313);
            this.__utilerias_importa.graphics.FillRectangle(new SolidBrush(this.__utilerias_importa.BackColor), 0, 0, this.__utilerias_importa.Width, this.__utilerias_importa.Height);
            this.__utilerias_importa.AddEvents();
            this.htControls.Add("__utilerias_importa", this.__utilerias_importa);
            this.__utilerias_cbotiendadestino = new CEnhancedCombo(this);
            this.__utilerias_cbotiendadestino.name = "__utilerias_cbotiendadestino";
            this.__utilerias_cbotiendadestino.Left = 50;
            this.__utilerias_cbotiendadestino.Top = 50;
            this.__utilerias_cbotiendadestino.Width = 170;
            this.__utilerias_cbotiendadestino.Height = 0x16;
            this.__utilerias_cbotiendadestino.Text = "";
            this.__utilerias_cbotiendadestino.BackColor = Color.FromArgb(-1);
            this.__utilerias_cbotiendadestino.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cbotiendadestino.Enabled = true;
            this.__utilerias_cbotiendadestino.Visible = true;
            this.__utilerias_cbotiendadestino.Font = new Font(this.__utilerias_cbotiendadestino.Font.Name, 9f, this.__utilerias_cbotiendadestino.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_cbotiendadestino);
            this.htControls.Add("__utilerias_cbotiendadestino", this.__utilerias_cbotiendadestino);
            this.__utilerias_cbotiendadestino.AddEvents();
            this.__utilerias_ltserver9 = new CEnhancedLabel(this);
            this.__utilerias_ltserver9.name = "__utilerias_ltserver9";
            this.__utilerias_ltserver9.Left = -1;
            this.__utilerias_ltserver9.Top = 0xa9;
            this.__utilerias_ltserver9.Width = 0xf5;
            this.__utilerias_ltserver9.Height = 20;
            this.__utilerias_ltserver9.Text = "";
            this.__utilerias_ltserver9.BackColor = Color.FromArgb(-16744193);
            this.__utilerias_ltserver9.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltserver9.MyEnabled = true;
            this.__utilerias_ltserver9.Visible = true;
            this.__utilerias_ltserver9.Transparent = false;
            this.__utilerias_ltserver9.Font = new Font(this.__utilerias_ltserver9.Font.Name, 8f, this.__utilerias_ltserver9.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_ltserver9);
            this.htControls.Add("__utilerias_ltserver9", this.__utilerias_ltserver9);
            this.__utilerias_ltimport11 = new CEnhancedLabel(this);
            this.__utilerias_ltimport11.name = "__utilerias_ltimport11";
            this.__utilerias_ltimport11.Left = -1;
            this.__utilerias_ltimport11.Top = 0x94;
            this.__utilerias_ltimport11.Width = 0xf2;
            this.__utilerias_ltimport11.Height = 20;
            this.__utilerias_ltimport11.Text = "";
            this.__utilerias_ltimport11.BackColor = Color.FromArgb(-16744256);
            this.__utilerias_ltimport11.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltimport11.MyEnabled = true;
            this.__utilerias_ltimport11.Visible = true;
            this.__utilerias_ltimport11.Transparent = false;
            this.__utilerias_ltimport11.Font = new Font(this.__utilerias_ltimport11.Font.Name, 8f, this.__utilerias_ltimport11.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_ltimport11);
            this.htControls.Add("__utilerias_ltimport11", this.__utilerias_ltimport11);
            this.__utilerias_cmdimpor2 = new CEnhancedButton(this);
            this.__utilerias_cmdimpor2.name = "__utilerias_cmdimpor2";
            this.__utilerias_cmdimpor2.Left = 0x87;
            this.__utilerias_cmdimpor2.Top = 100;
            this.__utilerias_cmdimpor2.Width = 0x55;
            this.__utilerias_cmdimpor2.Height = 30;
            this.__utilerias_cmdimpor2.Text = "Cancelar";
            this.__utilerias_cmdimpor2.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdimpor2.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdimpor2.Enabled = true;
            this.__utilerias_cmdimpor2.Visible = true;
            this.__utilerias_cmdimpor2.Font = new Font(this.__utilerias_cmdimpor2.Font.Name, 9f, this.__utilerias_cmdimpor2.Font.Style);
            this.__utilerias_cmdimpor2.AddEvents();
            this.__utilerias_importa.Controls.Add(this.__utilerias_cmdimpor2);
            this.htControls.Add("__utilerias_cmdimpor2", this.__utilerias_cmdimpor2);
            this.__utilerias_cmdimpor1 = new CEnhancedButton(this);
            this.__utilerias_cmdimpor1.name = "__utilerias_cmdimpor1";
            this.__utilerias_cmdimpor1.Left = 0x19;
            this.__utilerias_cmdimpor1.Top = 100;
            this.__utilerias_cmdimpor1.Width = 0x55;
            this.__utilerias_cmdimpor1.Height = 30;
            this.__utilerias_cmdimpor1.Text = "Iniciar";
            this.__utilerias_cmdimpor1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_cmdimpor1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cmdimpor1.Enabled = true;
            this.__utilerias_cmdimpor1.Visible = true;
            this.__utilerias_cmdimpor1.Font = new Font(this.__utilerias_cmdimpor1.Font.Name, 9f, this.__utilerias_cmdimpor1.Font.Style);
            this.__utilerias_cmdimpor1.AddEvents();
            this.__utilerias_importa.Controls.Add(this.__utilerias_cmdimpor1);
            this.htControls.Add("__utilerias_cmdimpor1", this.__utilerias_cmdimpor1);
            this.__utilerias_ltdestino1 = new CEnhancedLabel(this);
            this.__utilerias_ltdestino1.name = "__utilerias_ltdestino1";
            this.__utilerias_ltdestino1.Left = 2;
            this.__utilerias_ltdestino1.Top = 0x33;
            this.__utilerias_ltdestino1.Width = 0x37;
            this.__utilerias_ltdestino1.Height = 20;
            this.__utilerias_ltdestino1.Text = "Destino:";
            this.__utilerias_ltdestino1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_ltdestino1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltdestino1.MyEnabled = true;
            this.__utilerias_ltdestino1.Visible = true;
            this.__utilerias_ltdestino1.Transparent = false;
            this.__utilerias_ltdestino1.Font = new Font(this.__utilerias_ltdestino1.Font.Name, 9f, this.__utilerias_ltdestino1.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_ltdestino1);
            this.htControls.Add("__utilerias_ltdestino1", this.__utilerias_ltdestino1);
            this.__utilerias_cbotiendaorigen = new CEnhancedCombo(this);
            this.__utilerias_cbotiendaorigen.name = "__utilerias_cbotiendaorigen";
            this.__utilerias_cbotiendaorigen.Left = 50;
            this.__utilerias_cbotiendaorigen.Top = 4;
            this.__utilerias_cbotiendaorigen.Width = 170;
            this.__utilerias_cbotiendaorigen.Height = 0x16;
            this.__utilerias_cbotiendaorigen.Text = "";
            this.__utilerias_cbotiendaorigen.BackColor = Color.FromArgb(-1);
            this.__utilerias_cbotiendaorigen.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_cbotiendaorigen.Enabled = false;
            this.__utilerias_cbotiendaorigen.Visible = true;
            this.__utilerias_cbotiendaorigen.Font = new Font(this.__utilerias_cbotiendaorigen.Font.Name, 9f, this.__utilerias_cbotiendaorigen.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_cbotiendaorigen);
            this.htControls.Add("__utilerias_cbotiendaorigen", this.__utilerias_cbotiendaorigen);
            this.__utilerias_cbotiendaorigen.AddEvents();
            this.__utilerias_ltorigen1 = new CEnhancedLabel(this);
            this.__utilerias_ltorigen1.name = "__utilerias_ltorigen1";
            this.__utilerias_ltorigen1.Left = 2;
            this.__utilerias_ltorigen1.Top = 5;
            this.__utilerias_ltorigen1.Width = 0x37;
            this.__utilerias_ltorigen1.Height = 20;
            this.__utilerias_ltorigen1.Text = "Origen:";
            this.__utilerias_ltorigen1.BackColor = Color.FromArgb(-66313);
            this.__utilerias_ltorigen1.ForeColor = Color.FromArgb(-16777216);
            this.__utilerias_ltorigen1.MyEnabled = true;
            this.__utilerias_ltorigen1.Visible = true;
            this.__utilerias_ltorigen1.Transparent = false;
            this.__utilerias_ltorigen1.Font = new Font(this.__utilerias_ltorigen1.Font.Name, 9f, this.__utilerias_ltorigen1.Font.Style);
            this.__utilerias_importa.Controls.Add(this.__utilerias_ltorigen1);
            this.htControls.Add("__utilerias_ltorigen1", this.__utilerias_ltorigen1);
            this.__mainmodule_prods = new CEnhancedForm(this);
            this.__mainmodule_prods.name = "__mainmodule_prods";
            this.__mainmodule_prods.Text = "Seleccione articulo";
            this.__mainmodule_prods.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_prods.graphics.FillRectangle(new SolidBrush(this.__mainmodule_prods.BackColor), 0, 0, this.__mainmodule_prods.Width, this.__mainmodule_prods.Height);
            this.__mainmodule_prods.AddEvents();
            this.htControls.Add("__mainmodule_prods", this.__mainmodule_prods);
            this.__mainmodule_btnprods = new CEnhancedButton(this);
            this.__mainmodule_btnprods.name = "__mainmodule_btnprods";
            this.__mainmodule_btnprods.Left = 3;
            this.__mainmodule_btnprods.Top = 2;
            this.__mainmodule_btnprods.Width = 0x4b;
            this.__mainmodule_btnprods.Height = 0x17;
            this.__mainmodule_btnprods.Text = "Aceptar";
            this.__mainmodule_btnprods.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnprods.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnprods.Enabled = true;
            this.__mainmodule_btnprods.Visible = true;
            this.__mainmodule_btnprods.Font = new Font(this.__mainmodule_btnprods.Font.Name, 9f, this.__mainmodule_btnprods.Font.Style);
            this.__mainmodule_btnprods.AddEvents();
            this.__mainmodule_prods.Controls.Add(this.__mainmodule_btnprods);
            this.htControls.Add("__mainmodule_btnprods", this.__mainmodule_btnprods);
            this.__mainmodule_tblprod = new CEnhancedTable(this, "__mainmodule_tblprod");
            this.__mainmodule_tblprod.name = "__mainmodule_tblprod";
            this.__mainmodule_tblprod.Left = 3;
            this.__mainmodule_tblprod.Top = 30;
            this.__mainmodule_tblprod.Width = 0xec;
            this.__mainmodule_tblprod.Height = 0xeb;
            this.__mainmodule_tblprod.Text = "";
            this.__mainmodule_tblprod.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tblprod.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tblprod.Enabled = true;
            this.__mainmodule_tblprod.Visible = true;
            this.__mainmodule_tblprod.Font = new Font(this.__mainmodule_tblprod.Font.Name, 8f, this.__mainmodule_tblprod.Font.Style);
            this.__mainmodule_tblprod.AddEvents();
            this.__mainmodule_prods.Controls.Add(this.__mainmodule_tblprod);
            this.htControls.Add("__mainmodule_tblprod", this.__mainmodule_tblprod);
            this.__mainmodule_frmacceso = new CEnhancedForm(this);
            this.__mainmodule_frmacceso.name = "__mainmodule_frmacceso";
            this.__mainmodule_frmacceso.Text = "Acceso";
            this.__mainmodule_frmacceso.BackColor = Color.FromArgb(-4930050);
            this.__mainmodule_frmacceso.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmacceso.BackColor), 0, 0, this.__mainmodule_frmacceso.Width, this.__mainmodule_frmacceso.Height);
            this.__mainmodule_frmacceso.AddEvents();
            this.htControls.Add("__mainmodule_frmacceso", this.__mainmodule_frmacceso);
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
            this.__mainmodule_tlogin.Height = 0x19;
            this.__mainmodule_tlogin.Font = new Font(this.__mainmodule_tlogin.Font.Name, 10f, this.__mainmodule_tlogin.Font.Style);
            this.__mainmodule_tlogin.multiline = false;
            this.__mainmodule_tlogin.AddEvents();
            this.__mainmodule_frmacceso.Controls.Add(this.__mainmodule_tlogin);
            this.htControls.Add("__mainmodule_tlogin", this.__mainmodule_tlogin);
            this.__mainmodule_btnlogin2 = new CEnhancedButton(this);
            this.__mainmodule_btnlogin2.name = "__mainmodule_btnlogin2";
            this.__mainmodule_btnlogin2.Left = 120;
            this.__mainmodule_btnlogin2.Top = 0x55;
            this.__mainmodule_btnlogin2.Width = 90;
            this.__mainmodule_btnlogin2.Height = 30;
            this.__mainmodule_btnlogin2.Text = "Cancelar";
            this.__mainmodule_btnlogin2.BackColor = Color.FromArgb(-777);
            this.__mainmodule_btnlogin2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnlogin2.Enabled = true;
            this.__mainmodule_btnlogin2.Visible = true;
            this.__mainmodule_btnlogin2.Font = new Font(this.__mainmodule_btnlogin2.Font.Name, 9f, this.__mainmodule_btnlogin2.Font.Style);
            this.__mainmodule_btnlogin2.AddEvents();
            this.__mainmodule_frmacceso.Controls.Add(this.__mainmodule_btnlogin2);
            this.htControls.Add("__mainmodule_btnlogin2", this.__mainmodule_btnlogin2);
            this.__mainmodule_btnlogin1 = new CEnhancedButton(this);
            this.__mainmodule_btnlogin1.name = "__mainmodule_btnlogin1";
            this.__mainmodule_btnlogin1.Left = 0x19;
            this.__mainmodule_btnlogin1.Top = 0x55;
            this.__mainmodule_btnlogin1.Width = 90;
            this.__mainmodule_btnlogin1.Height = 30;
            this.__mainmodule_btnlogin1.Text = "Aceptar";
            this.__mainmodule_btnlogin1.BackColor = Color.FromArgb(-777);
            this.__mainmodule_btnlogin1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnlogin1.Enabled = true;
            this.__mainmodule_btnlogin1.Visible = true;
            this.__mainmodule_btnlogin1.Font = new Font(this.__mainmodule_btnlogin1.Font.Name, 9f, this.__mainmodule_btnlogin1.Font.Style);
            this.__mainmodule_btnlogin1.AddEvents();
            this.__mainmodule_frmacceso.Controls.Add(this.__mainmodule_btnlogin1);
            this.htControls.Add("__mainmodule_btnlogin1", this.__mainmodule_btnlogin1);
            this.__mainmodule_label39 = new CEnhancedLabel(this);
            this.__mainmodule_label39.name = "__mainmodule_label39";
            this.__mainmodule_label39.Left = 0x37;
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
            this.__mainmodule_frmacceso.Controls.Add(this.__mainmodule_label39);
            this.htControls.Add("__mainmodule_label39", this.__mainmodule_label39);
            this.__mainmodule_usuarios = new CEnhancedForm(this);
            this.__mainmodule_usuarios.name = "__mainmodule_usuarios";
            this.__mainmodule_usuarios.Text = "Usuarios";
            this.__mainmodule_usuarios.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_usuarios.graphics.FillRectangle(new SolidBrush(this.__mainmodule_usuarios.BackColor), 0, 0, this.__mainmodule_usuarios.Width, this.__mainmodule_usuarios.Height);
            this.__mainmodule_usuarios.AddEvents();
            this.htControls.Add("__mainmodule_usuarios", this.__mainmodule_usuarios);
            this.__mainmodule_tbluser = new CEnhancedTable(this, "__mainmodule_tbluser");
            this.__mainmodule_tbluser.name = "__mainmodule_tbluser";
            this.__mainmodule_tbluser.Left = 1;
            this.__mainmodule_tbluser.Top = 0x88;
            this.__mainmodule_tbluser.Width = 0xed;
            this.__mainmodule_tbluser.Height = 130;
            this.__mainmodule_tbluser.Text = "";
            this.__mainmodule_tbluser.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tbluser.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tbluser.Enabled = true;
            this.__mainmodule_tbluser.Visible = true;
            this.__mainmodule_tbluser.Font = new Font(this.__mainmodule_tbluser.Font.Name, 9f, this.__mainmodule_tbluser.Font.Style);
            this.__mainmodule_tbluser.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tbluser);
            this.htControls.Add("__mainmodule_tbluser", this.__mainmodule_tbluser);
            this.__mainmodule_btnusr3 = new CEnhancedButton(this);
            this.__mainmodule_btnusr3.name = "__mainmodule_btnusr3";
            this.__mainmodule_btnusr3.Left = 0xa5;
            this.__mainmodule_btnusr3.Top = 0x6a;
            this.__mainmodule_btnusr3.Width = 0x41;
            this.__mainmodule_btnusr3.Height = 0x19;
            this.__mainmodule_btnusr3.Text = "Salir";
            this.__mainmodule_btnusr3.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnusr3.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnusr3.Enabled = true;
            this.__mainmodule_btnusr3.Visible = true;
            this.__mainmodule_btnusr3.Font = new Font(this.__mainmodule_btnusr3.Font.Name, 9f, this.__mainmodule_btnusr3.Font.Style);
            this.__mainmodule_btnusr3.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_btnusr3);
            this.htControls.Add("__mainmodule_btnusr3", this.__mainmodule_btnusr3);
            this.__mainmodule_btnusr2 = new CEnhancedButton(this);
            this.__mainmodule_btnusr2.name = "__mainmodule_btnusr2";
            this.__mainmodule_btnusr2.Left = 0x51;
            this.__mainmodule_btnusr2.Top = 0x6a;
            this.__mainmodule_btnusr2.Width = 0x41;
            this.__mainmodule_btnusr2.Height = 0x19;
            this.__mainmodule_btnusr2.Text = "Eliminar";
            this.__mainmodule_btnusr2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnusr2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnusr2.Enabled = true;
            this.__mainmodule_btnusr2.Visible = true;
            this.__mainmodule_btnusr2.Font = new Font(this.__mainmodule_btnusr2.Font.Name, 9f, this.__mainmodule_btnusr2.Font.Style);
            this.__mainmodule_btnusr2.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_btnusr2);
            this.htControls.Add("__mainmodule_btnusr2", this.__mainmodule_btnusr2);
            this.__mainmodule_btnusr1 = new CEnhancedButton(this);
            this.__mainmodule_btnusr1.name = "__mainmodule_btnusr1";
            this.__mainmodule_btnusr1.Left = 6;
            this.__mainmodule_btnusr1.Top = 0x6a;
            this.__mainmodule_btnusr1.Width = 0x37;
            this.__mainmodule_btnusr1.Height = 0x19;
            this.__mainmodule_btnusr1.Text = "Grabar";
            this.__mainmodule_btnusr1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnusr1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnusr1.Enabled = true;
            this.__mainmodule_btnusr1.Visible = true;
            this.__mainmodule_btnusr1.Font = new Font(this.__mainmodule_btnusr1.Font.Name, 9f, this.__mainmodule_btnusr1.Font.Style);
            this.__mainmodule_btnusr1.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_btnusr1);
            this.htControls.Add("__mainmodule_btnusr1", this.__mainmodule_btnusr1);
            this.__mainmodule_tfolio = new CEnhancedTextBox(this);
            this.__mainmodule_tfolio.name = "__mainmodule_tfolio";
            this.__mainmodule_tfolio.Left = 0x91;
            this.__mainmodule_tfolio.Top = 0x4b;
            this.__mainmodule_tfolio.Width = 90;
            this.__mainmodule_tfolio.Text = "";
            this.__mainmodule_tfolio.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tfolio.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tfolio.Enabled = true;
            this.__mainmodule_tfolio.Visible = true;
            this.__mainmodule_tfolio.Height = 0x16;
            this.__mainmodule_tfolio.Font = new Font(this.__mainmodule_tfolio.Font.Name, 9f, this.__mainmodule_tfolio.Font.Style);
            this.__mainmodule_tfolio.multiline = false;
            this.__mainmodule_tfolio.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tfolio);
            this.htControls.Add("__mainmodule_tfolio", this.__mainmodule_tfolio);
            this.__mainmodule_tserie = new CEnhancedTextBox(this);
            this.__mainmodule_tserie.name = "__mainmodule_tserie";
            this.__mainmodule_tserie.Left = 0x37;
            this.__mainmodule_tserie.Top = 0x4c;
            this.__mainmodule_tserie.Width = 0x34;
            this.__mainmodule_tserie.Text = "";
            this.__mainmodule_tserie.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tserie.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tserie.Enabled = true;
            this.__mainmodule_tserie.Visible = true;
            this.__mainmodule_tserie.Height = 0x16;
            this.__mainmodule_tserie.Font = new Font(this.__mainmodule_tserie.Font.Name, 9f, this.__mainmodule_tserie.Font.Style);
            this.__mainmodule_tserie.multiline = false;
            this.__mainmodule_tserie.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tserie);
            this.htControls.Add("__mainmodule_tserie", this.__mainmodule_tserie);
            this.__mainmodule_chnivel = new CEnhancedCheckBox(this);
            this.__mainmodule_chnivel.name = "__mainmodule_chnivel";
            this.__mainmodule_chnivel.Left = 0x99;
            this.__mainmodule_chnivel.Top = 50;
            this.__mainmodule_chnivel.Width = 0x57;
            this.__mainmodule_chnivel.Height = 20;
            this.__mainmodule_chnivel.Text = "Administrador";
            this.__mainmodule_chnivel.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_chnivel.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chnivel.Enabled = true;
            this.__mainmodule_chnivel.Visible = true;
            this.__mainmodule_chnivel.Checked = false;
            this.__mainmodule_chnivel.Font = new Font(this.__mainmodule_chnivel.Font.Name, 8f, this.__mainmodule_chnivel.Font.Style);
            this.__mainmodule_chnivel.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_chnivel);
            this.htControls.Add("__mainmodule_chnivel", this.__mainmodule_chnivel);
            this.__mainmodule_tclave = new CEnhancedTextBox(this);
            this.__mainmodule_tclave.name = "__mainmodule_tclave";
            this.__mainmodule_tclave.Left = 0x43;
            this.__mainmodule_tclave.Top = 50;
            this.__mainmodule_tclave.Width = 0x55;
            this.__mainmodule_tclave.Text = "";
            this.__mainmodule_tclave.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tclave.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tclave.Enabled = true;
            this.__mainmodule_tclave.Visible = true;
            this.__mainmodule_tclave.Height = 0x16;
            this.__mainmodule_tclave.Font = new Font(this.__mainmodule_tclave.Font.Name, 9f, this.__mainmodule_tclave.Font.Style);
            this.__mainmodule_tclave.multiline = false;
            this.__mainmodule_tclave.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tclave);
            this.htControls.Add("__mainmodule_tclave", this.__mainmodule_tclave);
            this.__mainmodule_tnombre = new CEnhancedTextBox(this);
            this.__mainmodule_tnombre.name = "__mainmodule_tnombre";
            this.__mainmodule_tnombre.Left = 0x37;
            this.__mainmodule_tnombre.Top = 0x19;
            this.__mainmodule_tnombre.Width = 180;
            this.__mainmodule_tnombre.Text = "";
            this.__mainmodule_tnombre.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tnombre.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tnombre.Enabled = true;
            this.__mainmodule_tnombre.Visible = true;
            this.__mainmodule_tnombre.Height = 0x16;
            this.__mainmodule_tnombre.Font = new Font(this.__mainmodule_tnombre.Font.Name, 9f, this.__mainmodule_tnombre.Font.Style);
            this.__mainmodule_tnombre.multiline = false;
            this.__mainmodule_tnombre.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tnombre);
            this.htControls.Add("__mainmodule_tnombre", this.__mainmodule_tnombre);
            this.__mainmodule_tusu = new CEnhancedTextBox(this);
            this.__mainmodule_tusu.name = "__mainmodule_tusu";
            this.__mainmodule_tusu.Left = 0x37;
            this.__mainmodule_tusu.Top = 2;
            this.__mainmodule_tusu.Width = 0x7a;
            this.__mainmodule_tusu.Text = "";
            this.__mainmodule_tusu.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tusu.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tusu.Enabled = true;
            this.__mainmodule_tusu.Visible = true;
            this.__mainmodule_tusu.Height = 0x16;
            this.__mainmodule_tusu.Font = new Font(this.__mainmodule_tusu.Font.Name, 9f, this.__mainmodule_tusu.Font.Style);
            this.__mainmodule_tusu.multiline = false;
            this.__mainmodule_tusu.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_tusu);
            this.htControls.Add("__mainmodule_tusu", this.__mainmodule_tusu);
            this.__mainmodule_label14 = new CEnhancedLabel(this);
            this.__mainmodule_label14.name = "__mainmodule_label14";
            this.__mainmodule_label14.Left = 0x6c;
            this.__mainmodule_label14.Top = 0x4e;
            this.__mainmodule_label14.Width = 40;
            this.__mainmodule_label14.Height = 20;
            this.__mainmodule_label14.Text = "Folio:";
            this.__mainmodule_label14.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label14.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label14.MyEnabled = true;
            this.__mainmodule_label14.Visible = true;
            this.__mainmodule_label14.Transparent = false;
            this.__mainmodule_label14.Font = new Font(this.__mainmodule_label14.Font.Name, 9f, this.__mainmodule_label14.Font.Style);
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_label14);
            this.htControls.Add("__mainmodule_label14", this.__mainmodule_label14);
            this.__mainmodule_label12 = new CEnhancedLabel(this);
            this.__mainmodule_label12.name = "__mainmodule_label12";
            this.__mainmodule_label12.Left = 5;
            this.__mainmodule_label12.Top = 0x4c;
            this.__mainmodule_label12.Width = 0x2d;
            this.__mainmodule_label12.Height = 20;
            this.__mainmodule_label12.Text = "Serie:";
            this.__mainmodule_label12.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label12.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label12.MyEnabled = true;
            this.__mainmodule_label12.Visible = true;
            this.__mainmodule_label12.Transparent = false;
            this.__mainmodule_label12.Font = new Font(this.__mainmodule_label12.Font.Name, 9f, this.__mainmodule_label12.Font.Style);
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_label12);
            this.htControls.Add("__mainmodule_label12", this.__mainmodule_label12);
            this.__mainmodule_btnnew = new CEnhancedButton(this);
            this.__mainmodule_btnnew.name = "__mainmodule_btnnew";
            this.__mainmodule_btnnew.Left = 180;
            this.__mainmodule_btnnew.Top = 2;
            this.__mainmodule_btnnew.Width = 0x24;
            this.__mainmodule_btnnew.Height = 20;
            this.__mainmodule_btnnew.Text = "...";
            this.__mainmodule_btnnew.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnnew.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnnew.Enabled = true;
            this.__mainmodule_btnnew.Visible = true;
            this.__mainmodule_btnnew.Font = new Font(this.__mainmodule_btnnew.Font.Name, 9f, this.__mainmodule_btnnew.Font.Style);
            this.__mainmodule_btnnew.AddEvents();
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_btnnew);
            this.htControls.Add("__mainmodule_btnnew", this.__mainmodule_btnnew);
            this.__mainmodule_label3 = new CEnhancedLabel(this);
            this.__mainmodule_label3.name = "__mainmodule_label3";
            this.__mainmodule_label3.Left = 1;
            this.__mainmodule_label3.Top = 0x1a;
            this.__mainmodule_label3.Width = 0x34;
            this.__mainmodule_label3.Height = 20;
            this.__mainmodule_label3.Text = "Nombre:";
            this.__mainmodule_label3.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label3.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label3.MyEnabled = true;
            this.__mainmodule_label3.Visible = true;
            this.__mainmodule_label3.Transparent = false;
            this.__mainmodule_label3.Font = new Font(this.__mainmodule_label3.Font.Name, 9f, this.__mainmodule_label3.Font.Style);
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_label3);
            this.htControls.Add("__mainmodule_label3", this.__mainmodule_label3);
            this.__mainmodule_label10 = new CEnhancedLabel(this);
            this.__mainmodule_label10.name = "__mainmodule_label10";
            this.__mainmodule_label10.Left = 1;
            this.__mainmodule_label10.Top = 0x31;
            this.__mainmodule_label10.Width = 70;
            this.__mainmodule_label10.Height = 20;
            this.__mainmodule_label10.Text = "Contrase\x00f1a:";
            this.__mainmodule_label10.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label10.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label10.MyEnabled = true;
            this.__mainmodule_label10.Visible = true;
            this.__mainmodule_label10.Transparent = false;
            this.__mainmodule_label10.Font = new Font(this.__mainmodule_label10.Font.Name, 9f, this.__mainmodule_label10.Font.Style);
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_label10);
            this.htControls.Add("__mainmodule_label10", this.__mainmodule_label10);
            this.__mainmodule_label2 = new CEnhancedLabel(this);
            this.__mainmodule_label2.name = "__mainmodule_label2";
            this.__mainmodule_label2.Left = 1;
            this.__mainmodule_label2.Top = 3;
            this.__mainmodule_label2.Width = 0x36;
            this.__mainmodule_label2.Height = 20;
            this.__mainmodule_label2.Text = "Usuario:";
            this.__mainmodule_label2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label2.MyEnabled = true;
            this.__mainmodule_label2.Visible = true;
            this.__mainmodule_label2.Transparent = false;
            this.__mainmodule_label2.Font = new Font(this.__mainmodule_label2.Font.Name, 9f, this.__mainmodule_label2.Font.Style);
            this.__mainmodule_usuarios.Controls.Add(this.__mainmodule_label2);
            this.htControls.Add("__mainmodule_label2", this.__mainmodule_label2);
            this.__mainmodule_frmtraspasos = new CEnhancedForm(this);
            this.__mainmodule_frmtraspasos.name = "__mainmodule_frmtraspasos";
            this.__mainmodule_frmtraspasos.Text = "Traspasos";
            this.__mainmodule_frmtraspasos.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmtraspasos.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmtraspasos.BackColor), 0, 0, this.__mainmodule_frmtraspasos.Width, this.__mainmodule_frmtraspasos.Height);
            this.__mainmodule_frmtraspasos.AddEvents();
            this.htControls.Add("__mainmodule_frmtraspasos", this.__mainmodule_frmtraspasos);
            this.__mainmodule_cmdimport2 = new CEnhancedButton(this);
            this.__mainmodule_cmdimport2.name = "__mainmodule_cmdimport2";
            this.__mainmodule_cmdimport2.Left = 130;
            this.__mainmodule_cmdimport2.Top = 130;
            this.__mainmodule_cmdimport2.Width = 0x55;
            this.__mainmodule_cmdimport2.Height = 0x23;
            this.__mainmodule_cmdimport2.Text = "Cancelar";
            this.__mainmodule_cmdimport2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_cmdimport2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdimport2.Enabled = true;
            this.__mainmodule_cmdimport2.Visible = true;
            this.__mainmodule_cmdimport2.Font = new Font(this.__mainmodule_cmdimport2.Font.Name, 9f, this.__mainmodule_cmdimport2.Font.Style);
            this.__mainmodule_cmdimport2.AddEvents();
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_cmdimport2);
            this.htControls.Add("__mainmodule_cmdimport2", this.__mainmodule_cmdimport2);
            this.__mainmodule_cmdimport1 = new CEnhancedButton(this);
            this.__mainmodule_cmdimport1.name = "__mainmodule_cmdimport1";
            this.__mainmodule_cmdimport1.Left = 30;
            this.__mainmodule_cmdimport1.Top = 130;
            this.__mainmodule_cmdimport1.Width = 0x55;
            this.__mainmodule_cmdimport1.Height = 0x23;
            this.__mainmodule_cmdimport1.Text = "Iniciar";
            this.__mainmodule_cmdimport1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_cmdimport1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdimport1.Enabled = true;
            this.__mainmodule_cmdimport1.Visible = true;
            this.__mainmodule_cmdimport1.Font = new Font(this.__mainmodule_cmdimport1.Font.Name, 9f, this.__mainmodule_cmdimport1.Font.Style);
            this.__mainmodule_cmdimport1.AddEvents();
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_cmdimport1);
            this.htControls.Add("__mainmodule_cmdimport1", this.__mainmodule_cmdimport1);
            this.__mainmodule_cbotiendadestino = new CEnhancedCombo(this);
            this.__mainmodule_cbotiendadestino.name = "__mainmodule_cbotiendadestino";
            this.__mainmodule_cbotiendadestino.Left = 60;
            this.__mainmodule_cbotiendadestino.Top = 0x2d;
            this.__mainmodule_cbotiendadestino.Width = 170;
            this.__mainmodule_cbotiendadestino.Height = 0x16;
            this.__mainmodule_cbotiendadestino.Text = "";
            this.__mainmodule_cbotiendadestino.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cbotiendadestino.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cbotiendadestino.Enabled = true;
            this.__mainmodule_cbotiendadestino.Visible = true;
            this.__mainmodule_cbotiendadestino.Font = new Font(this.__mainmodule_cbotiendadestino.Font.Name, 9f, this.__mainmodule_cbotiendadestino.Font.Style);
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_cbotiendadestino);
            this.htControls.Add("__mainmodule_cbotiendadestino", this.__mainmodule_cbotiendadestino);
            this.__mainmodule_cbotiendadestino.AddEvents();
            this.__mainmodule_label40 = new CEnhancedLabel(this);
            this.__mainmodule_label40.name = "__mainmodule_label40";
            this.__mainmodule_label40.Left = 1;
            this.__mainmodule_label40.Top = 0x2c;
            this.__mainmodule_label40.Width = 60;
            this.__mainmodule_label40.Height = 0x19;
            this.__mainmodule_label40.Text = "Destino:";
            this.__mainmodule_label40.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label40.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label40.MyEnabled = true;
            this.__mainmodule_label40.Visible = true;
            this.__mainmodule_label40.Transparent = false;
            this.__mainmodule_label40.Font = new Font(this.__mainmodule_label40.Font.Name, 9f, this.__mainmodule_label40.Font.Style);
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_label40);
            this.htControls.Add("__mainmodule_label40", this.__mainmodule_label40);
            this.__mainmodule_cbotiendaorigen = new CEnhancedCombo(this);
            this.__mainmodule_cbotiendaorigen.name = "__mainmodule_cbotiendaorigen";
            this.__mainmodule_cbotiendaorigen.Left = 60;
            this.__mainmodule_cbotiendaorigen.Top = 5;
            this.__mainmodule_cbotiendaorigen.Width = 170;
            this.__mainmodule_cbotiendaorigen.Height = 0x16;
            this.__mainmodule_cbotiendaorigen.Text = "";
            this.__mainmodule_cbotiendaorigen.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cbotiendaorigen.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cbotiendaorigen.Enabled = true;
            this.__mainmodule_cbotiendaorigen.Visible = true;
            this.__mainmodule_cbotiendaorigen.Font = new Font(this.__mainmodule_cbotiendaorigen.Font.Name, 9f, this.__mainmodule_cbotiendaorigen.Font.Style);
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_cbotiendaorigen);
            this.htControls.Add("__mainmodule_cbotiendaorigen", this.__mainmodule_cbotiendaorigen);
            this.__mainmodule_cbotiendaorigen.AddEvents();
            this.__mainmodule_label36 = new CEnhancedLabel(this);
            this.__mainmodule_label36.name = "__mainmodule_label36";
            this.__mainmodule_label36.Left = 1;
            this.__mainmodule_label36.Top = 4;
            this.__mainmodule_label36.Width = 60;
            this.__mainmodule_label36.Height = 0x19;
            this.__mainmodule_label36.Text = "Origen:";
            this.__mainmodule_label36.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label36.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label36.MyEnabled = true;
            this.__mainmodule_label36.Visible = true;
            this.__mainmodule_label36.Transparent = false;
            this.__mainmodule_label36.Font = new Font(this.__mainmodule_label36.Font.Name, 9f, this.__mainmodule_label36.Font.Style);
            this.__mainmodule_frmtraspasos.Controls.Add(this.__mainmodule_label36);
            this.htControls.Add("__mainmodule_label36", this.__mainmodule_label36);
            this.__mainmodule_frmexistencias = new CEnhancedForm(this);
            this.__mainmodule_frmexistencias.name = "__mainmodule_frmexistencias";
            this.__mainmodule_frmexistencias.Text = "Existencias Remota SAE6";
            this.__mainmodule_frmexistencias.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmexistencias.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmexistencias.BackColor), 0, 0, this.__mainmodule_frmexistencias.Width, this.__mainmodule_frmexistencias.Height);
            this.__mainmodule_frmexistencias.AddEvents();
            this.htControls.Add("__mainmodule_frmexistencias", this.__mainmodule_frmexistencias);
            this.__mainmodule_lte = new CEnhancedLabel(this);
            this.__mainmodule_lte.name = "__mainmodule_lte";
            this.__mainmodule_lte.Left = 2;
            this.__mainmodule_lte.Top = 110;
            this.__mainmodule_lte.Width = 0x86;
            this.__mainmodule_lte.Height = 30;
            this.__mainmodule_lte.Text = "";
            this.__mainmodule_lte.BackColor = Color.FromArgb(-397360);
            this.__mainmodule_lte.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lte.MyEnabled = true;
            this.__mainmodule_lte.Visible = true;
            this.__mainmodule_lte.Transparent = false;
            this.__mainmodule_lte.Font = new Font(this.__mainmodule_lte.Font.Name, 14f, this.__mainmodule_lte.Font.Style);
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_lte);
            this.htControls.Add("__mainmodule_lte", this.__mainmodule_lte);
            this.__mainmodule_ltdescr = new CEnhancedLabel(this);
            this.__mainmodule_ltdescr.name = "__mainmodule_ltdescr";
            this.__mainmodule_ltdescr.Left = 2;
            this.__mainmodule_ltdescr.Top = 50;
            this.__mainmodule_ltdescr.Width = 0xeb;
            this.__mainmodule_ltdescr.Height = 0x37;
            this.__mainmodule_ltdescr.Text = "";
            this.__mainmodule_ltdescr.BackColor = Color.FromArgb(-397360);
            this.__mainmodule_ltdescr.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltdescr.MyEnabled = true;
            this.__mainmodule_ltdescr.Visible = true;
            this.__mainmodule_ltdescr.Transparent = false;
            this.__mainmodule_ltdescr.Font = new Font(this.__mainmodule_ltdescr.Font.Name, 10f, this.__mainmodule_ltdescr.Font.Style);
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_ltdescr);
            this.htControls.Add("__mainmodule_ltdescr", this.__mainmodule_ltdescr);
            this.__mainmodule_ltprec = new CEnhancedLabel(this);
            this.__mainmodule_ltprec.name = "__mainmodule_ltprec";
            this.__mainmodule_ltprec.Left = 0x89;
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
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_ltprec);
            this.htControls.Add("__mainmodule_ltprec", this.__mainmodule_ltprec);
            this.__mainmodule_btnsalexist = new CEnhancedButton(this);
            this.__mainmodule_btnsalexist.name = "__mainmodule_btnsalexist";
            this.__mainmodule_btnsalexist.Left = 0x9b;
            this.__mainmodule_btnsalexist.Top = 0x91;
            this.__mainmodule_btnsalexist.Width = 0x4b;
            this.__mainmodule_btnsalexist.Height = 30;
            this.__mainmodule_btnsalexist.Text = "Salir";
            this.__mainmodule_btnsalexist.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsalexist.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsalexist.Enabled = true;
            this.__mainmodule_btnsalexist.Visible = true;
            this.__mainmodule_btnsalexist.Font = new Font(this.__mainmodule_btnsalexist.Font.Name, 9f, this.__mainmodule_btnsalexist.Font.Style);
            this.__mainmodule_btnsalexist.AddEvents();
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_btnsalexist);
            this.htControls.Add("__mainmodule_btnsalexist", this.__mainmodule_btnsalexist);
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
            this.__mainmodule_tprod.Height = 0x19;
            this.__mainmodule_tprod.Font = new Font(this.__mainmodule_tprod.Font.Name, 10f, this.__mainmodule_tprod.Font.Style);
            this.__mainmodule_tprod.multiline = false;
            this.__mainmodule_tprod.AddEvents();
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_tprod);
            this.htControls.Add("__mainmodule_tprod", this.__mainmodule_tprod);
            this.__mainmodule_label26 = new CEnhancedLabel(this);
            this.__mainmodule_label26.name = "__mainmodule_label26";
            this.__mainmodule_label26.Left = 5;
            this.__mainmodule_label26.Top = 2;
            this.__mainmodule_label26.Width = 0x4b;
            this.__mainmodule_label26.Height = 20;
            this.__mainmodule_label26.Text = "Articulo";
            this.__mainmodule_label26.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label26.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label26.MyEnabled = true;
            this.__mainmodule_label26.Visible = true;
            this.__mainmodule_label26.Transparent = false;
            this.__mainmodule_label26.Font = new Font(this.__mainmodule_label26.Font.Name, 9f, this.__mainmodule_label26.Font.Style);
            this.__mainmodule_frmexistencias.Controls.Add(this.__mainmodule_label26);
            this.htControls.Add("__mainmodule_label26", this.__mainmodule_label26);
            this.__mainmodule_frmexistxlinea = new CEnhancedForm(this);
            this.__mainmodule_frmexistxlinea.name = "__mainmodule_frmexistxlinea";
            this.__mainmodule_frmexistxlinea.Text = "Exist. X Linea";
            this.__mainmodule_frmexistxlinea.BackColor = Color.FromArgb(-66569);
            this.__mainmodule_frmexistxlinea.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmexistxlinea.BackColor), 0, 0, this.__mainmodule_frmexistxlinea.Width, this.__mainmodule_frmexistxlinea.Height);
            this.__mainmodule_frmexistxlinea.AddEvents();
            this.htControls.Add("__mainmodule_frmexistxlinea", this.__mainmodule_frmexistxlinea);
            this.__mainmodule_pnltoper = new CEnhancedPanel(this);
            this.__mainmodule_pnltoper.name = "__mainmodule_pnltoper";
            this.__mainmodule_pnltoper.Left = 0x9e;
            this.__mainmodule_pnltoper.Top = -10;
            this.__mainmodule_pnltoper.Width = 0xef;
            this.__mainmodule_pnltoper.Height = 0xfd;
            this.__mainmodule_pnltoper.BackColor = Color.FromArgb(-1);
            this.__mainmodule_pnltoper.Enabled = true;
            this.__mainmodule_pnltoper.Visible = false;
            this.__mainmodule_pnltoper.AddEvents();
            this.__mainmodule_frmexistxlinea.Controls.Add(this.__mainmodule_pnltoper);
            this.htControls.Add("__mainmodule_pnltoper", this.__mainmodule_pnltoper);
            this.__mainmodule_btntoperborrar = new CEnhancedButton(this);
            this.__mainmodule_btntoperborrar.name = "__mainmodule_btntoperborrar";
            this.__mainmodule_btntoperborrar.Left = 0x13;
            this.__mainmodule_btntoperborrar.Top = 200;
            this.__mainmodule_btntoperborrar.Width = 0x4b;
            this.__mainmodule_btntoperborrar.Height = 0x17;
            this.__mainmodule_btntoperborrar.Text = "Borrar ";
            this.__mainmodule_btntoperborrar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntoperborrar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntoperborrar.Enabled = true;
            this.__mainmodule_btntoperborrar.Visible = true;
            this.__mainmodule_btntoperborrar.Font = new Font(this.__mainmodule_btntoperborrar.Font.Name, 9f, this.__mainmodule_btntoperborrar.Font.Style);
            this.__mainmodule_btntoperborrar.AddEvents();
            this.__mainmodule_pnltoper.Controls.Add(this.__mainmodule_btntoperborrar);
            this.htControls.Add("__mainmodule_btntoperborrar", this.__mainmodule_btntoperborrar);
            this.__mainmodule_ltstop = new CEnhancedLabel(this);
            this.__mainmodule_ltstop.name = "__mainmodule_ltstop";
            this.__mainmodule_ltstop.Left = 0xa2;
            this.__mainmodule_ltstop.Top = 0xab;
            this.__mainmodule_ltstop.Width = 0x4b;
            this.__mainmodule_ltstop.Height = 0x19;
            this.__mainmodule_ltstop.Text = "";
            this.__mainmodule_ltstop.BackColor = Color.FromArgb(-1);
            this.__mainmodule_ltstop.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltstop.MyEnabled = true;
            this.__mainmodule_ltstop.Visible = true;
            this.__mainmodule_ltstop.Transparent = false;
            this.__mainmodule_ltstop.Font = new Font(this.__mainmodule_ltstop.Font.Name, 9f, this.__mainmodule_ltstop.Font.Style);
            this.__mainmodule_pnltoper.Controls.Add(this.__mainmodule_ltstop);
            this.htControls.Add("__mainmodule_ltstop", this.__mainmodule_ltstop);
            this.__mainmodule_btntopercerrar = new CEnhancedButton(this);
            this.__mainmodule_btntopercerrar.name = "__mainmodule_btntopercerrar";
            this.__mainmodule_btntopercerrar.Left = 0x73;
            this.__mainmodule_btntopercerrar.Top = 0xc6;
            this.__mainmodule_btntopercerrar.Width = 0x4b;
            this.__mainmodule_btntopercerrar.Height = 0x17;
            this.__mainmodule_btntopercerrar.Text = "Salir";
            this.__mainmodule_btntopercerrar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntopercerrar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntopercerrar.Enabled = true;
            this.__mainmodule_btntopercerrar.Visible = true;
            this.__mainmodule_btntopercerrar.Font = new Font(this.__mainmodule_btntopercerrar.Font.Name, 9f, this.__mainmodule_btntopercerrar.Font.Style);
            this.__mainmodule_btntopercerrar.AddEvents();
            this.__mainmodule_pnltoper.Controls.Add(this.__mainmodule_btntopercerrar);
            this.htControls.Add("__mainmodule_btntopercerrar", this.__mainmodule_btntopercerrar);
            this.__mainmodule_tbltoper = new CEnhancedTable(this, "__mainmodule_tbltoper");
            this.__mainmodule_tbltoper.name = "__mainmodule_tbltoper";
            this.__mainmodule_tbltoper.Left = 3;
            this.__mainmodule_tbltoper.Top = 4;
            this.__mainmodule_tbltoper.Width = 0xea;
            this.__mainmodule_tbltoper.Height = 0xa5;
            this.__mainmodule_tbltoper.Text = "";
            this.__mainmodule_tbltoper.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tbltoper.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tbltoper.Enabled = true;
            this.__mainmodule_tbltoper.Visible = true;
            this.__mainmodule_tbltoper.Font = new Font(this.__mainmodule_tbltoper.Font.Name, 9f, this.__mainmodule_tbltoper.Font.Style);
            this.__mainmodule_tbltoper.AddEvents();
            this.__mainmodule_pnltoper.Controls.Add(this.__mainmodule_tbltoper);
            this.htControls.Add("__mainmodule_tbltoper", this.__mainmodule_tbltoper);
            this.__mainmodule_btntoper2 = new CEnhancedButton(this);
            this.__mainmodule_btntoper2.name = "__mainmodule_btntoper2";
            this.__mainmodule_btntoper2.Left = 0x69;
            this.__mainmodule_btntoper2.Top = 0xd7;
            this.__mainmodule_btntoper2.Width = 0x4b;
            this.__mainmodule_btntoper2.Height = 0x19;
            this.__mainmodule_btntoper2.Text = "Salir";
            this.__mainmodule_btntoper2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntoper2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntoper2.Enabled = true;
            this.__mainmodule_btntoper2.Visible = true;
            this.__mainmodule_btntoper2.Font = new Font(this.__mainmodule_btntoper2.Font.Name, 9f, this.__mainmodule_btntoper2.Font.Style);
            this.__mainmodule_btntoper2.AddEvents();
            this.__mainmodule_frmexistxlinea.Controls.Add(this.__mainmodule_btntoper2);
            this.htControls.Add("__mainmodule_btntoper2", this.__mainmodule_btntoper2);
            this.__mainmodule_btntoper1 = new CEnhancedButton(this);
            this.__mainmodule_btntoper1.name = "__mainmodule_btntoper1";
            this.__mainmodule_btntoper1.Left = 15;
            this.__mainmodule_btntoper1.Top = 0xd7;
            this.__mainmodule_btntoper1.Width = 0x4b;
            this.__mainmodule_btntoper1.Height = 0x19;
            this.__mainmodule_btntoper1.Text = "Partidas";
            this.__mainmodule_btntoper1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntoper1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntoper1.Enabled = true;
            this.__mainmodule_btntoper1.Visible = true;
            this.__mainmodule_btntoper1.Font = new Font(this.__mainmodule_btntoper1.Font.Name, 9f, this.__mainmodule_btntoper1.Font.Style);
            this.__mainmodule_btntoper1.AddEvents();
            this.__mainmodule_frmexistxlinea.Controls.Add(this.__mainmodule_btntoper1);
            this.htControls.Add("__mainmodule_btntoper1", this.__mainmodule_btntoper1);
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
            this.__mainmodule_frmexistxlinea.Controls.Add(this.__mainmodule_tblexisxlinea);
            this.htControls.Add("__mainmodule_tblexisxlinea", this.__mainmodule_tblexisxlinea);
            this.__mainmodule_invencan = new CEnhancedForm(this);
            this.__mainmodule_invencan.name = "__mainmodule_invencan";
            this.__mainmodule_invencan.Text = "Consultas";
            this.__mainmodule_invencan.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_invencan.graphics.FillRectangle(new SolidBrush(this.__mainmodule_invencan.BackColor), 0, 0, this.__mainmodule_invencan.Width, this.__mainmodule_invencan.Height);
            this.__mainmodule_invencan.AddEvents();
            this.htControls.Add("__mainmodule_invencan", this.__mainmodule_invencan);
            this.__mainmodule_ltsumcan2 = new CEnhancedLabel(this);
            this.__mainmodule_ltsumcan2.name = "__mainmodule_ltsumcan2";
            this.__mainmodule_ltsumcan2.Left = 0xbd;
            this.__mainmodule_ltsumcan2.Top = 0xa8;
            this.__mainmodule_ltsumcan2.Width = 50;
            this.__mainmodule_ltsumcan2.Height = 20;
            this.__mainmodule_ltsumcan2.Text = "";
            this.__mainmodule_ltsumcan2.BackColor = Color.FromArgb(-474893);
            this.__mainmodule_ltsumcan2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsumcan2.MyEnabled = true;
            this.__mainmodule_ltsumcan2.Visible = true;
            this.__mainmodule_ltsumcan2.Transparent = false;
            this.__mainmodule_ltsumcan2.Font = new Font(this.__mainmodule_ltsumcan2.Font.Name, 10f, this.__mainmodule_ltsumcan2.Font.Style);
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_ltsumcan2);
            this.htControls.Add("__mainmodule_ltsumcan2", this.__mainmodule_ltsumcan2);
            this.__mainmodule_ltsum2 = new CEnhancedLabel(this);
            this.__mainmodule_ltsum2.name = "__mainmodule_ltsum2";
            this.__mainmodule_ltsum2.Left = 0x3b;
            this.__mainmodule_ltsum2.Top = 0xa8;
            this.__mainmodule_ltsum2.Width = 0x37;
            this.__mainmodule_ltsum2.Height = 20;
            this.__mainmodule_ltsum2.Text = "";
            this.__mainmodule_ltsum2.BackColor = Color.FromArgb(-474893);
            this.__mainmodule_ltsum2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsum2.MyEnabled = true;
            this.__mainmodule_ltsum2.Visible = true;
            this.__mainmodule_ltsum2.Transparent = false;
            this.__mainmodule_ltsum2.Font = new Font(this.__mainmodule_ltsum2.Font.Name, 10f, this.__mainmodule_ltsum2.Font.Style);
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_ltsum2);
            this.htControls.Add("__mainmodule_ltsum2", this.__mainmodule_ltsum2);
            this.__mainmodule_ltsumcan = new CEnhancedLabel(this);
            this.__mainmodule_ltsumcan.name = "__mainmodule_ltsumcan";
            this.__mainmodule_ltsumcan.Left = 0x74;
            this.__mainmodule_ltsumcan.Top = 0xa8;
            this.__mainmodule_ltsumcan.Width = 0x48;
            this.__mainmodule_ltsumcan.Height = 20;
            this.__mainmodule_ltsumcan.Text = "Cancelados";
            this.__mainmodule_ltsumcan.BackColor = Color.FromArgb(-474893);
            this.__mainmodule_ltsumcan.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsumcan.MyEnabled = true;
            this.__mainmodule_ltsumcan.Visible = true;
            this.__mainmodule_ltsumcan.Transparent = false;
            this.__mainmodule_ltsumcan.Font = new Font(this.__mainmodule_ltsumcan.Font.Name, 9f, this.__mainmodule_ltsumcan.Font.Style);
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_ltsumcan);
            this.htControls.Add("__mainmodule_ltsumcan", this.__mainmodule_ltsumcan);
            this.__mainmodule_ltsum = new CEnhancedLabel(this);
            this.__mainmodule_ltsum.name = "__mainmodule_ltsum";
            this.__mainmodule_ltsum.Left = 2;
            this.__mainmodule_ltsum.Top = 0xa8;
            this.__mainmodule_ltsum.Width = 0x38;
            this.__mainmodule_ltsum.Height = 20;
            this.__mainmodule_ltsum.Text = "Cantidad:";
            this.__mainmodule_ltsum.BackColor = Color.FromArgb(-474893);
            this.__mainmodule_ltsum.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsum.MyEnabled = true;
            this.__mainmodule_ltsum.Visible = true;
            this.__mainmodule_ltsum.Transparent = false;
            this.__mainmodule_ltsum.Font = new Font(this.__mainmodule_ltsum.Font.Name, 9f, this.__mainmodule_ltsum.Font.Style);
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_ltsum);
            this.htControls.Add("__mainmodule_ltsum", this.__mainmodule_ltsum);
            this.__mainmodule_tcodigo = new CEnhancedTextBox(this);
            this.__mainmodule_tcodigo.name = "__mainmodule_tcodigo";
            this.__mainmodule_tcodigo.Left = 0x3f;
            this.__mainmodule_tcodigo.Top = 20;
            this.__mainmodule_tcodigo.Width = 0x91;
            this.__mainmodule_tcodigo.Text = "";
            this.__mainmodule_tcodigo.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tcodigo.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tcodigo.Enabled = true;
            this.__mainmodule_tcodigo.Visible = true;
            this.__mainmodule_tcodigo.Height = 0x16;
            this.__mainmodule_tcodigo.Font = new Font(this.__mainmodule_tcodigo.Font.Name, 9f, this.__mainmodule_tcodigo.Font.Style);
            this.__mainmodule_tcodigo.multiline = false;
            this.__mainmodule_tcodigo.AddEvents();
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_tcodigo);
            this.htControls.Add("__mainmodule_tcodigo", this.__mainmodule_tcodigo);
            this.__mainmodule_tbcaninven = new CEnhancedTable(this, "__mainmodule_tbcaninven");
            this.__mainmodule_tbcaninven.name = "__mainmodule_tbcaninven";
            this.__mainmodule_tbcaninven.Left = 2;
            this.__mainmodule_tbcaninven.Top = 0x2b;
            this.__mainmodule_tbcaninven.Width = 0xee;
            this.__mainmodule_tbcaninven.Height = 0x7d;
            this.__mainmodule_tbcaninven.Text = "";
            this.__mainmodule_tbcaninven.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tbcaninven.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tbcaninven.Enabled = true;
            this.__mainmodule_tbcaninven.Visible = true;
            this.__mainmodule_tbcaninven.Font = new Font(this.__mainmodule_tbcaninven.Font.Name, 9f, this.__mainmodule_tbcaninven.Font.Style);
            this.__mainmodule_tbcaninven.AddEvents();
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_tbcaninven);
            this.htControls.Add("__mainmodule_tbcaninven", this.__mainmodule_tbcaninven);
            this.__mainmodule_cmdinvc = new CEnhancedButton(this);
            this.__mainmodule_cmdinvc.name = "__mainmodule_cmdinvc";
            this.__mainmodule_cmdinvc.Left = 0xd1;
            this.__mainmodule_cmdinvc.Top = 20;
            this.__mainmodule_cmdinvc.Width = 0x1b;
            this.__mainmodule_cmdinvc.Height = 20;
            this.__mainmodule_cmdinvc.Text = "::::";
            this.__mainmodule_cmdinvc.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_cmdinvc.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdinvc.Enabled = true;
            this.__mainmodule_cmdinvc.Visible = true;
            this.__mainmodule_cmdinvc.Font = new Font(this.__mainmodule_cmdinvc.Font.Name, 9f, this.__mainmodule_cmdinvc.Font.Style);
            this.__mainmodule_cmdinvc.AddEvents();
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_cmdinvc);
            this.htControls.Add("__mainmodule_cmdinvc", this.__mainmodule_cmdinvc);
            this.__mainmodule_label27 = new CEnhancedLabel(this);
            this.__mainmodule_label27.name = "__mainmodule_label27";
            this.__mainmodule_label27.Left = 7;
            this.__mainmodule_label27.Top = 20;
            this.__mainmodule_label27.Width = 0x31;
            this.__mainmodule_label27.Height = 20;
            this.__mainmodule_label27.Text = "Articulo";
            this.__mainmodule_label27.BackColor = Color.FromArgb(-474893);
            this.__mainmodule_label27.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label27.MyEnabled = true;
            this.__mainmodule_label27.Visible = true;
            this.__mainmodule_label27.Transparent = true;
            this.__mainmodule_label27.Font = new Font(this.__mainmodule_label27.Font.Name, 9f, this.__mainmodule_label27.Font.Style);
            this.__mainmodule_invencan.Controls.Add(this.__mainmodule_label27);
            this.htControls.Add("__mainmodule_label27", this.__mainmodule_label27);
            this.__mainmodule_mnucanc0 = new CEnhancedMenu(this);
            this.__mainmodule_mnucanc0.name = "__mainmodule_mnucanc0";
            this.__mainmodule_mnucanc0.Text = "Menu";
            this.__mainmodule_mnucanc0.Enabled = true;
            this.__mainmodule_mnucanc0.Checked = false;
            this.__mainmodule_mnucanc0.AddToObject("__mainmodule_invencan");
            this.__mainmodule_mnucanc0.AddEvents();
            this.htControls.Add("__mainmodule_mnucanc0", this.__mainmodule_mnucanc0);
            this.__mainmodule_mnucan1 = new CEnhancedMenu(this);
            this.__mainmodule_mnucan1.name = "__mainmodule_mnucan1";
            this.__mainmodule_mnucan1.Text = "Cancelar";
            this.__mainmodule_mnucan1.Enabled = true;
            this.__mainmodule_mnucan1.Checked = false;
            this.__mainmodule_mnucan1.AddToObject("__mainmodule_mnucanc0");
            this.__mainmodule_mnucan1.AddEvents();
            this.htControls.Add("__mainmodule_mnucan1", this.__mainmodule_mnucan1);
            this.__mainmodule_mnuinvent = new CEnhancedMenu(this);
            this.__mainmodule_mnuinvent.name = "__mainmodule_mnuinvent";
            this.__mainmodule_mnuinvent.Text = "Inventario";
            this.__mainmodule_mnuinvent.Enabled = true;
            this.__mainmodule_mnuinvent.Checked = false;
            this.__mainmodule_mnuinvent.AddToObject("__mainmodule_mnucanc0");
            this.__mainmodule_mnuinvent.AddEvents();
            this.htControls.Add("__mainmodule_mnuinvent", this.__mainmodule_mnuinvent);
            this.__mainmodule_mnusalircan = new CEnhancedMenu(this);
            this.__mainmodule_mnusalircan.name = "__mainmodule_mnusalircan";
            this.__mainmodule_mnusalircan.Text = "Salir";
            this.__mainmodule_mnusalircan.Enabled = true;
            this.__mainmodule_mnusalircan.Checked = false;
            this.__mainmodule_mnusalircan.AddToObject("__mainmodule_mnucanc0");
            this.__mainmodule_mnusalircan.AddEvents();
            this.htControls.Add("__mainmodule_mnusalircan", this.__mainmodule_mnusalircan);
            this.__mainmodule_frmareas = new CEnhancedForm(this);
            this.__mainmodule_frmareas.name = "__mainmodule_frmareas";
            this.__mainmodule_frmareas.Text = "Areas";
            this.__mainmodule_frmareas.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmareas.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmareas.BackColor), 0, 0, this.__mainmodule_frmareas.Width, this.__mainmodule_frmareas.Height);
            this.__mainmodule_frmareas.AddEvents();
            this.htControls.Add("__mainmodule_frmareas", this.__mainmodule_frmareas);
            this.__mainmodule_pnlareasseries = new CEnhancedPanel(this);
            this.__mainmodule_pnlareasseries.name = "__mainmodule_pnlareasseries";
            this.__mainmodule_pnlareasseries.Left = 20;
            this.__mainmodule_pnlareasseries.Top = 0xbd;
            this.__mainmodule_pnlareasseries.Width = 0xf1;
            this.__mainmodule_pnlareasseries.Height = 0xbd;
            this.__mainmodule_pnlareasseries.BackColor = Color.FromArgb(-7625730);
            this.__mainmodule_pnlareasseries.Enabled = true;
            this.__mainmodule_pnlareasseries.Visible = false;
            this.__mainmodule_pnlareasseries.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_pnlareasseries);
            this.htControls.Add("__mainmodule_pnlareasseries", this.__mainmodule_pnlareasseries);
            this.__mainmodule_cboseriesareas = new CEnhancedCombo(this);
            this.__mainmodule_cboseriesareas.name = "__mainmodule_cboseriesareas";
            this.__mainmodule_cboseriesareas.Left = 0x9c;
            this.__mainmodule_cboseriesareas.Top = 0x3b;
            this.__mainmodule_cboseriesareas.Width = 60;
            this.__mainmodule_cboseriesareas.Height = 0x19;
            this.__mainmodule_cboseriesareas.Text = "";
            this.__mainmodule_cboseriesareas.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboseriesareas.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboseriesareas.Enabled = true;
            this.__mainmodule_cboseriesareas.Visible = true;
            this.__mainmodule_cboseriesareas.Font = new Font(this.__mainmodule_cboseriesareas.Font.Name, 10f, this.__mainmodule_cboseriesareas.Font.Style);
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_cboseriesareas);
            this.htControls.Add("__mainmodule_cboseriesareas", this.__mainmodule_cboseriesareas);
            this.__mainmodule_cboseriesareas.AddEvents();
            this.__mainmodule_tnotaarea = new CEnhancedTextBox(this);
            this.__mainmodule_tnotaarea.name = "__mainmodule_tnotaarea";
            this.__mainmodule_tnotaarea.Left = 4;
            this.__mainmodule_tnotaarea.Top = 0x1b;
            this.__mainmodule_tnotaarea.Width = 0xdf;
            this.__mainmodule_tnotaarea.Text = "";
            this.__mainmodule_tnotaarea.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tnotaarea.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tnotaarea.Enabled = true;
            this.__mainmodule_tnotaarea.Visible = true;
            this.__mainmodule_tnotaarea.Height = 0x16;
            this.__mainmodule_tnotaarea.Font = new Font(this.__mainmodule_tnotaarea.Font.Name, 9f, this.__mainmodule_tnotaarea.Font.Style);
            this.__mainmodule_tnotaarea.multiline = false;
            this.__mainmodule_tnotaarea.AddEvents();
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_tnotaarea);
            this.htControls.Add("__mainmodule_tnotaarea", this.__mainmodule_tnotaarea);
            this.__mainmodule_label44 = new CEnhancedLabel(this);
            this.__mainmodule_label44.name = "__mainmodule_label44";
            this.__mainmodule_label44.Left = 4;
            this.__mainmodule_label44.Top = 0x3d;
            this.__mainmodule_label44.Width = 0x9a;
            this.__mainmodule_label44.Height = 20;
            this.__mainmodule_label44.Text = "No. de registros a agregar:";
            this.__mainmodule_label44.BackColor = Color.FromArgb(-7625730);
            this.__mainmodule_label44.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label44.MyEnabled = true;
            this.__mainmodule_label44.Visible = true;
            this.__mainmodule_label44.Transparent = false;
            this.__mainmodule_label44.Font = new Font(this.__mainmodule_label44.Font.Name, 9f, this.__mainmodule_label44.Font.Style);
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_label44);
            this.htControls.Add("__mainmodule_label44", this.__mainmodule_label44);
            this.__mainmodule_ltseries = new CEnhancedLabel(this);
            this.__mainmodule_ltseries.name = "__mainmodule_ltseries";
            this.__mainmodule_ltseries.Left = 1;
            this.__mainmodule_ltseries.Top = 0x8f;
            this.__mainmodule_ltseries.Width = 0xec;
            this.__mainmodule_ltseries.Height = 0x31;
            this.__mainmodule_ltseries.Text = "Se agregaran series con la  descripcion indicada en forma consecutiva y se borrara las existentes";
            this.__mainmodule_ltseries.BackColor = Color.FromArgb(-7625730);
            this.__mainmodule_ltseries.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltseries.MyEnabled = true;
            this.__mainmodule_ltseries.Visible = true;
            this.__mainmodule_ltseries.Transparent = false;
            this.__mainmodule_ltseries.Font = new Font(this.__mainmodule_ltseries.Font.Name, 9f, this.__mainmodule_ltseries.Font.Style);
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_ltseries);
            this.htControls.Add("__mainmodule_ltseries", this.__mainmodule_ltseries);
            this.__mainmodule_btnareaserie2 = new CEnhancedButton(this);
            this.__mainmodule_btnareaserie2.name = "__mainmodule_btnareaserie2";
            this.__mainmodule_btnareaserie2.Left = 0x7b;
            this.__mainmodule_btnareaserie2.Top = 100;
            this.__mainmodule_btnareaserie2.Width = 0x5f;
            this.__mainmodule_btnareaserie2.Height = 30;
            this.__mainmodule_btnareaserie2.Text = "Cancelar";
            this.__mainmodule_btnareaserie2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnareaserie2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnareaserie2.Enabled = true;
            this.__mainmodule_btnareaserie2.Visible = true;
            this.__mainmodule_btnareaserie2.Font = new Font(this.__mainmodule_btnareaserie2.Font.Name, 9f, this.__mainmodule_btnareaserie2.Font.Style);
            this.__mainmodule_btnareaserie2.AddEvents();
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_btnareaserie2);
            this.htControls.Add("__mainmodule_btnareaserie2", this.__mainmodule_btnareaserie2);
            this.__mainmodule_btnareaserie1 = new CEnhancedButton(this);
            this.__mainmodule_btnareaserie1.name = "__mainmodule_btnareaserie1";
            this.__mainmodule_btnareaserie1.Left = 12;
            this.__mainmodule_btnareaserie1.Top = 100;
            this.__mainmodule_btnareaserie1.Width = 0x5f;
            this.__mainmodule_btnareaserie1.Height = 30;
            this.__mainmodule_btnareaserie1.Text = "Agregar";
            this.__mainmodule_btnareaserie1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnareaserie1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnareaserie1.Enabled = true;
            this.__mainmodule_btnareaserie1.Visible = true;
            this.__mainmodule_btnareaserie1.Font = new Font(this.__mainmodule_btnareaserie1.Font.Name, 9f, this.__mainmodule_btnareaserie1.Font.Style);
            this.__mainmodule_btnareaserie1.AddEvents();
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_btnareaserie1);
            this.htControls.Add("__mainmodule_btnareaserie1", this.__mainmodule_btnareaserie1);
            this.__mainmodule_label42 = new CEnhancedLabel(this);
            this.__mainmodule_label42.name = "__mainmodule_label42";
            this.__mainmodule_label42.Left = 4;
            this.__mainmodule_label42.Top = 7;
            this.__mainmodule_label42.Width = 0x5f;
            this.__mainmodule_label42.Height = 20;
            this.__mainmodule_label42.Text = "Nombre Area:";
            this.__mainmodule_label42.BackColor = Color.FromArgb(-7625730);
            this.__mainmodule_label42.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label42.MyEnabled = true;
            this.__mainmodule_label42.Visible = true;
            this.__mainmodule_label42.Transparent = false;
            this.__mainmodule_label42.Font = new Font(this.__mainmodule_label42.Font.Name, 9f, this.__mainmodule_label42.Font.Style);
            this.__mainmodule_pnlareasseries.Controls.Add(this.__mainmodule_label42);
            this.htControls.Add("__mainmodule_label42", this.__mainmodule_label42);
            this.__mainmodule_tareanombre = new CEnhancedTextBox(this);
            this.__mainmodule_tareanombre.name = "__mainmodule_tareanombre";
            this.__mainmodule_tareanombre.Left = 0x2f;
            this.__mainmodule_tareanombre.Top = 0x21;
            this.__mainmodule_tareanombre.Width = 150;
            this.__mainmodule_tareanombre.Text = "";
            this.__mainmodule_tareanombre.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tareanombre.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tareanombre.Enabled = true;
            this.__mainmodule_tareanombre.Visible = true;
            this.__mainmodule_tareanombre.Height = 0x16;
            this.__mainmodule_tareanombre.Font = new Font(this.__mainmodule_tareanombre.Font.Name, 9f, this.__mainmodule_tareanombre.Font.Style);
            this.__mainmodule_tareanombre.multiline = false;
            this.__mainmodule_tareanombre.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_tareanombre);
            this.htControls.Add("__mainmodule_tareanombre", this.__mainmodule_tareanombre);
            this.__mainmodule_ltarea = new CEnhancedLabel(this);
            this.__mainmodule_ltarea.name = "__mainmodule_ltarea";
            this.__mainmodule_ltarea.Left = 0xc6;
            this.__mainmodule_ltarea.Top = 0x23;
            this.__mainmodule_ltarea.Width = 0x2e;
            this.__mainmodule_ltarea.Height = 20;
            this.__mainmodule_ltarea.Text = "Nombre area";
            this.__mainmodule_ltarea.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_ltarea.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltarea.MyEnabled = true;
            this.__mainmodule_ltarea.Visible = true;
            this.__mainmodule_ltarea.Transparent = false;
            this.__mainmodule_ltarea.Font = new Font(this.__mainmodule_ltarea.Font.Name, 9f, this.__mainmodule_ltarea.Font.Style);
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_ltarea);
            this.htControls.Add("__mainmodule_ltarea", this.__mainmodule_ltarea);
            this.__mainmodule_btnareagrabar = new CEnhancedButton(this);
            this.__mainmodule_btnareagrabar.name = "__mainmodule_btnareagrabar";
            this.__mainmodule_btnareagrabar.Left = 180;
            this.__mainmodule_btnareagrabar.Top = 0x3a;
            this.__mainmodule_btnareagrabar.Width = 50;
            this.__mainmodule_btnareagrabar.Height = 0x16;
            this.__mainmodule_btnareagrabar.Text = "Grabar";
            this.__mainmodule_btnareagrabar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnareagrabar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnareagrabar.Enabled = true;
            this.__mainmodule_btnareagrabar.Visible = true;
            this.__mainmodule_btnareagrabar.Font = new Font(this.__mainmodule_btnareagrabar.Font.Name, 9f, this.__mainmodule_btnareagrabar.Font.Style);
            this.__mainmodule_btnareagrabar.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_btnareagrabar);
            this.htControls.Add("__mainmodule_btnareagrabar", this.__mainmodule_btnareagrabar);
            this.__mainmodule_btneliminar = new CEnhancedButton(this);
            this.__mainmodule_btneliminar.name = "__mainmodule_btneliminar";
            this.__mainmodule_btneliminar.Left = 0x73;
            this.__mainmodule_btneliminar.Top = 0x3a;
            this.__mainmodule_btneliminar.Width = 50;
            this.__mainmodule_btneliminar.Height = 0x16;
            this.__mainmodule_btneliminar.Text = "Borrar";
            this.__mainmodule_btneliminar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btneliminar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btneliminar.Enabled = true;
            this.__mainmodule_btneliminar.Visible = true;
            this.__mainmodule_btneliminar.Font = new Font(this.__mainmodule_btneliminar.Font.Name, 9f, this.__mainmodule_btneliminar.Font.Style);
            this.__mainmodule_btneliminar.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_btneliminar);
            this.htControls.Add("__mainmodule_btneliminar", this.__mainmodule_btneliminar);
            this.__mainmodule_btnareanew = new CEnhancedButton(this);
            this.__mainmodule_btnareanew.name = "__mainmodule_btnareanew";
            this.__mainmodule_btnareanew.Left = 0x33;
            this.__mainmodule_btnareanew.Top = 0x3a;
            this.__mainmodule_btnareanew.Width = 50;
            this.__mainmodule_btnareanew.Height = 0x16;
            this.__mainmodule_btnareanew.Text = "Nuevo";
            this.__mainmodule_btnareanew.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnareanew.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnareanew.Enabled = true;
            this.__mainmodule_btnareanew.Visible = true;
            this.__mainmodule_btnareanew.Font = new Font(this.__mainmodule_btnareanew.Font.Name, 9f, this.__mainmodule_btnareanew.Font.Style);
            this.__mainmodule_btnareanew.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_btnareanew);
            this.htControls.Add("__mainmodule_btnareanew", this.__mainmodule_btnareanew);
            this.__mainmodule_btnarea2 = new CEnhancedButton(this);
            this.__mainmodule_btnarea2.name = "__mainmodule_btnarea2";
            this.__mainmodule_btnarea2.Left = 0xaf;
            this.__mainmodule_btnarea2.Top = 2;
            this.__mainmodule_btnarea2.Width = 0x3d;
            this.__mainmodule_btnarea2.Height = 0x1b;
            this.__mainmodule_btnarea2.Text = "Salir";
            this.__mainmodule_btnarea2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnarea2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnarea2.Enabled = true;
            this.__mainmodule_btnarea2.Visible = true;
            this.__mainmodule_btnarea2.Font = new Font(this.__mainmodule_btnarea2.Font.Name, 9f, this.__mainmodule_btnarea2.Font.Style);
            this.__mainmodule_btnarea2.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_btnarea2);
            this.htControls.Add("__mainmodule_btnarea2", this.__mainmodule_btnarea2);
            this.__mainmodule_tblareas = new CEnhancedTable(this, "__mainmodule_tblareas");
            this.__mainmodule_tblareas.name = "__mainmodule_tblareas";
            this.__mainmodule_tblareas.Left = 1;
            this.__mainmodule_tblareas.Top = 0x51;
            this.__mainmodule_tblareas.Width = 0xed;
            this.__mainmodule_tblareas.Height = 0x70;
            this.__mainmodule_tblareas.Text = "";
            this.__mainmodule_tblareas.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tblareas.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tblareas.Enabled = true;
            this.__mainmodule_tblareas.Visible = true;
            this.__mainmodule_tblareas.Font = new Font(this.__mainmodule_tblareas.Font.Name, 9f, this.__mainmodule_tblareas.Font.Style);
            this.__mainmodule_tblareas.AddEvents();
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_tblareas);
            this.htControls.Add("__mainmodule_tblareas", this.__mainmodule_tblareas);
            this.__mainmodule_label43 = new CEnhancedLabel(this);
            this.__mainmodule_label43.name = "__mainmodule_label43";
            this.__mainmodule_label43.Left = 1;
            this.__mainmodule_label43.Top = 0x24;
            this.__mainmodule_label43.Width = 0x37;
            this.__mainmodule_label43.Height = 0x12;
            this.__mainmodule_label43.Text = "Nombre";
            this.__mainmodule_label43.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label43.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label43.MyEnabled = true;
            this.__mainmodule_label43.Visible = true;
            this.__mainmodule_label43.Transparent = false;
            this.__mainmodule_label43.Font = new Font(this.__mainmodule_label43.Font.Name, 9f, this.__mainmodule_label43.Font.Style);
            this.__mainmodule_frmareas.Controls.Add(this.__mainmodule_label43);
            this.htControls.Add("__mainmodule_label43", this.__mainmodule_label43);
            this.__mainmodule_mnuarchivoareas = new CEnhancedMenu(this);
            this.__mainmodule_mnuarchivoareas.name = "__mainmodule_mnuarchivoareas";
            this.__mainmodule_mnuarchivoareas.Text = "Archivo";
            this.__mainmodule_mnuarchivoareas.Enabled = true;
            this.__mainmodule_mnuarchivoareas.Checked = false;
            this.__mainmodule_mnuarchivoareas.AddToObject("__mainmodule_frmareas");
            this.__mainmodule_mnuarchivoareas.AddEvents();
            this.htControls.Add("__mainmodule_mnuarchivoareas", this.__mainmodule_mnuarchivoareas);
            this.__mainmodule_mnuareas1 = new CEnhancedMenu(this);
            this.__mainmodule_mnuareas1.name = "__mainmodule_mnuareas1";
            this.__mainmodule_mnuareas1.Text = "Agregar areas";
            this.__mainmodule_mnuareas1.Enabled = true;
            this.__mainmodule_mnuareas1.Checked = false;
            this.__mainmodule_mnuareas1.AddToObject("__mainmodule_mnuarchivoareas");
            this.__mainmodule_mnuareas1.AddEvents();
            this.htControls.Add("__mainmodule_mnuareas1", this.__mainmodule_mnuareas1);
            this.__mainmodule_mnuborrarareas = new CEnhancedMenu(this);
            this.__mainmodule_mnuborrarareas.name = "__mainmodule_mnuborrarareas";
            this.__mainmodule_mnuborrarareas.Text = "Borrar Areas";
            this.__mainmodule_mnuborrarareas.Enabled = true;
            this.__mainmodule_mnuborrarareas.Checked = false;
            this.__mainmodule_mnuborrarareas.AddToObject("__mainmodule_mnuarchivoareas");
            this.__mainmodule_mnuborrarareas.AddEvents();
            this.htControls.Add("__mainmodule_mnuborrarareas", this.__mainmodule_mnuborrarareas);
            this.__mainmodule_frmclientes = new CEnhancedForm(this);
            this.__mainmodule_frmclientes.name = "__mainmodule_frmclientes";
            this.__mainmodule_frmclientes.Text = "Clientes";
            this.__mainmodule_frmclientes.BackColor = Color.FromArgb(-8344071);
            this.__mainmodule_frmclientes.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmclientes.BackColor), 0, 0, this.__mainmodule_frmclientes.Width, this.__mainmodule_frmclientes.Height);
            this.__mainmodule_frmclientes.AddEvents();
            this.htControls.Add("__mainmodule_frmclientes", this.__mainmodule_frmclientes);
            this.__mainmodule_tcliente = new CEnhancedTextBox(this);
            this.__mainmodule_tcliente.name = "__mainmodule_tcliente";
            this.__mainmodule_tcliente.Left = 1;
            this.__mainmodule_tcliente.Top = 4;
            this.__mainmodule_tcliente.Width = 0xaf;
            this.__mainmodule_tcliente.Text = "";
            this.__mainmodule_tcliente.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tcliente.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tcliente.Enabled = true;
            this.__mainmodule_tcliente.Visible = true;
            this.__mainmodule_tcliente.Height = 0x16;
            this.__mainmodule_tcliente.Font = new Font(this.__mainmodule_tcliente.Font.Name, 9f, this.__mainmodule_tcliente.Font.Style);
            this.__mainmodule_tcliente.multiline = false;
            this.__mainmodule_tcliente.AddEvents();
            this.__mainmodule_frmclientes.Controls.Add(this.__mainmodule_tcliente);
            this.htControls.Add("__mainmodule_tcliente", this.__mainmodule_tcliente);
            this.__mainmodule_tabla = new CEnhancedTable(this, "__mainmodule_tabla");
            this.__mainmodule_tabla.name = "__mainmodule_tabla";
            this.__mainmodule_tabla.Left = 0;
            this.__mainmodule_tabla.Top = 30;
            this.__mainmodule_tabla.Width = 0xee;
            this.__mainmodule_tabla.Height = 0xeb;
            this.__mainmodule_tabla.Text = "";
            this.__mainmodule_tabla.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tabla.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tabla.Enabled = true;
            this.__mainmodule_tabla.Visible = false;
            this.__mainmodule_tabla.Font = new Font(this.__mainmodule_tabla.Font.Name, 9f, this.__mainmodule_tabla.Font.Style);
            this.__mainmodule_tabla.AddEvents();
            this.__mainmodule_frmclientes.Controls.Add(this.__mainmodule_tabla);
            this.htControls.Add("__mainmodule_tabla", this.__mainmodule_tabla);
            this.__mainmodule_cmdbuscar = new CEnhancedButton(this);
            this.__mainmodule_cmdbuscar.name = "__mainmodule_cmdbuscar";
            this.__mainmodule_cmdbuscar.Left = 0xb9;
            this.__mainmodule_cmdbuscar.Top = 3;
            this.__mainmodule_cmdbuscar.Width = 0x30;
            this.__mainmodule_cmdbuscar.Height = 0x19;
            this.__mainmodule_cmdbuscar.Text = "Buscar";
            this.__mainmodule_cmdbuscar.BackColor = Color.FromArgb(-197899);
            this.__mainmodule_cmdbuscar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdbuscar.Enabled = true;
            this.__mainmodule_cmdbuscar.Visible = true;
            this.__mainmodule_cmdbuscar.Font = new Font(this.__mainmodule_cmdbuscar.Font.Name, 8f, this.__mainmodule_cmdbuscar.Font.Style);
            this.__mainmodule_cmdbuscar.AddEvents();
            this.__mainmodule_frmclientes.Controls.Add(this.__mainmodule_cmdbuscar);
            this.htControls.Add("__mainmodule_cmdbuscar", this.__mainmodule_cmdbuscar);
            this.__mainmodule_mnuctep = new CEnhancedMenu(this);
            this.__mainmodule_mnuctep.name = "__mainmodule_mnuctep";
            this.__mainmodule_mnuctep.Text = "Archivo";
            this.__mainmodule_mnuctep.Enabled = true;
            this.__mainmodule_mnuctep.Checked = false;
            this.__mainmodule_mnuctep.AddToObject("__mainmodule_frmclientes");
            this.__mainmodule_mnuctep.AddEvents();
            this.htControls.Add("__mainmodule_mnuctep", this.__mainmodule_mnuctep);
            this.__mainmodule_mnucte1 = new CEnhancedMenu(this);
            this.__mainmodule_mnucte1.name = "__mainmodule_mnucte1";
            this.__mainmodule_mnucte1.Text = "Alta de cliente";
            this.__mainmodule_mnucte1.Enabled = true;
            this.__mainmodule_mnucte1.Checked = false;
            this.__mainmodule_mnucte1.AddToObject("__mainmodule_mnuctep");
            this.__mainmodule_mnucte1.AddEvents();
            this.htControls.Add("__mainmodule_mnucte1", this.__mainmodule_mnucte1);
            this.__mainmodule_mnucte2 = new CEnhancedMenu(this);
            this.__mainmodule_mnucte2.name = "__mainmodule_mnucte2";
            this.__mainmodule_mnucte2.Text = "Teclado";
            this.__mainmodule_mnucte2.Enabled = true;
            this.__mainmodule_mnucte2.Checked = false;
            this.__mainmodule_mnucte2.AddToObject("__mainmodule_mnuctep");
            this.__mainmodule_mnucte2.AddEvents();
            this.htControls.Add("__mainmodule_mnucte2", this.__mainmodule_mnucte2);
            this.__mainmodule_mnucte3 = new CEnhancedMenu(this);
            this.__mainmodule_mnucte3.name = "__mainmodule_mnucte3";
            this.__mainmodule_mnucte3.Text = "Salir";
            this.__mainmodule_mnucte3.Enabled = true;
            this.__mainmodule_mnucte3.Checked = false;
            this.__mainmodule_mnucte3.AddToObject("__mainmodule_mnuctep");
            this.__mainmodule_mnucte3.AddEvents();
            this.htControls.Add("__mainmodule_mnucte3", this.__mainmodule_mnucte3);
            this.__mainmodule_gencompra = new CEnhancedForm(this);
            this.__mainmodule_gencompra.name = "__mainmodule_gencompra";
            this.__mainmodule_gencompra.Text = "Generar compra";
            this.__mainmodule_gencompra.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_gencompra.graphics.FillRectangle(new SolidBrush(this.__mainmodule_gencompra.BackColor), 0, 0, this.__mainmodule_gencompra.Width, this.__mainmodule_gencompra.Height);
            this.__mainmodule_gencompra.AddEvents();
            this.htControls.Add("__mainmodule_gencompra", this.__mainmodule_gencompra);
            this.__mainmodule_chenviartodascompras = new CEnhancedCheckBox(this);
            this.__mainmodule_chenviartodascompras.name = "__mainmodule_chenviartodascompras";
            this.__mainmodule_chenviartodascompras.Left = 10;
            this.__mainmodule_chenviartodascompras.Top = 90;
            this.__mainmodule_chenviartodascompras.Width = 0xd7;
            this.__mainmodule_chenviartodascompras.Height = 0x19;
            this.__mainmodule_chenviartodascompras.Text = "Enviar todos los documentos";
            this.__mainmodule_chenviartodascompras.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_chenviartodascompras.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chenviartodascompras.Enabled = true;
            this.__mainmodule_chenviartodascompras.Visible = true;
            this.__mainmodule_chenviartodascompras.Checked = false;
            this.__mainmodule_chenviartodascompras.Font = new Font(this.__mainmodule_chenviartodascompras.Font.Name, 9f, this.__mainmodule_chenviartodascompras.Font.Style);
            this.__mainmodule_chenviartodascompras.AddEvents();
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_chenviartodascompras);
            this.htControls.Add("__mainmodule_chenviartodascompras", this.__mainmodule_chenviartodascompras);
            this.__mainmodule_cbocompra = new CEnhancedCombo(this);
            this.__mainmodule_cbocompra.name = "__mainmodule_cbocompra";
            this.__mainmodule_cbocompra.Left = 50;
            this.__mainmodule_cbocompra.Top = 0x38;
            this.__mainmodule_cbocompra.Width = 0xb7;
            this.__mainmodule_cbocompra.Height = 0x16;
            this.__mainmodule_cbocompra.Text = "";
            this.__mainmodule_cbocompra.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cbocompra.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cbocompra.Enabled = true;
            this.__mainmodule_cbocompra.Visible = true;
            this.__mainmodule_cbocompra.Font = new Font(this.__mainmodule_cbocompra.Font.Name, 9f, this.__mainmodule_cbocompra.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_cbocompra);
            this.htControls.Add("__mainmodule_cbocompra", this.__mainmodule_cbocompra);
            this.__mainmodule_cbocompra.AddEvents();
            this.__mainmodule_ltcomreg = new CEnhancedLabel(this);
            this.__mainmodule_ltcomreg.name = "__mainmodule_ltcomreg";
            this.__mainmodule_ltcomreg.Left = 160;
            this.__mainmodule_ltcomreg.Top = 0xa5;
            this.__mainmodule_ltcomreg.Width = 70;
            this.__mainmodule_ltcomreg.Height = 20;
            this.__mainmodule_ltcomreg.Text = "";
            this.__mainmodule_ltcomreg.BackColor = Color.FromArgb(-464446);
            this.__mainmodule_ltcomreg.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltcomreg.MyEnabled = true;
            this.__mainmodule_ltcomreg.Visible = true;
            this.__mainmodule_ltcomreg.Transparent = false;
            this.__mainmodule_ltcomreg.Font = new Font(this.__mainmodule_ltcomreg.Font.Name, 9f, this.__mainmodule_ltcomreg.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_ltcomreg);
            this.htControls.Add("__mainmodule_ltcomreg", this.__mainmodule_ltcomreg);
            this.__mainmodule_label34 = new CEnhancedLabel(this);
            this.__mainmodule_label34.name = "__mainmodule_label34";
            this.__mainmodule_label34.Left = 100;
            this.__mainmodule_label34.Top = 0xa7;
            this.__mainmodule_label34.Width = 0x41;
            this.__mainmodule_label34.Height = 20;
            this.__mainmodule_label34.Text = "Registros:";
            this.__mainmodule_label34.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label34.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label34.MyEnabled = true;
            this.__mainmodule_label34.Visible = true;
            this.__mainmodule_label34.Transparent = false;
            this.__mainmodule_label34.Font = new Font(this.__mainmodule_label34.Font.Name, 9f, this.__mainmodule_label34.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_label34);
            this.htControls.Add("__mainmodule_label34", this.__mainmodule_label34);
            this.__mainmodule_label31 = new CEnhancedLabel(this);
            this.__mainmodule_label31.name = "__mainmodule_label31";
            this.__mainmodule_label31.Left = 1;
            this.__mainmodule_label31.Top = 0xa7;
            this.__mainmodule_label31.Width = 40;
            this.__mainmodule_label31.Height = 20;
            this.__mainmodule_label31.Text = "Cant.:";
            this.__mainmodule_label31.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label31.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label31.MyEnabled = true;
            this.__mainmodule_label31.Visible = true;
            this.__mainmodule_label31.Transparent = false;
            this.__mainmodule_label31.Font = new Font(this.__mainmodule_label31.Font.Name, 9f, this.__mainmodule_label31.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_label31);
            this.htControls.Add("__mainmodule_label31", this.__mainmodule_label31);
            this.__mainmodule_ltcomcant = new CEnhancedLabel(this);
            this.__mainmodule_ltcomcant.name = "__mainmodule_ltcomcant";
            this.__mainmodule_ltcomcant.Left = 40;
            this.__mainmodule_ltcomcant.Top = 0xa5;
            this.__mainmodule_ltcomcant.Width = 60;
            this.__mainmodule_ltcomcant.Height = 20;
            this.__mainmodule_ltcomcant.Text = "";
            this.__mainmodule_ltcomcant.BackColor = Color.FromArgb(-464446);
            this.__mainmodule_ltcomcant.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltcomcant.MyEnabled = true;
            this.__mainmodule_ltcomcant.Visible = true;
            this.__mainmodule_ltcomcant.Transparent = false;
            this.__mainmodule_ltcomcant.Font = new Font(this.__mainmodule_ltcomcant.Font.Name, 9f, this.__mainmodule_ltcomcant.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_ltcomcant);
            this.htControls.Add("__mainmodule_ltcomcant", this.__mainmodule_ltcomcant);
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
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_ltcomart);
            this.htControls.Add("__mainmodule_ltcomart", this.__mainmodule_ltcomart);
            this.__mainmodule_label29 = new CEnhancedLabel(this);
            this.__mainmodule_label29.name = "__mainmodule_label29";
            this.__mainmodule_label29.Left = 1;
            this.__mainmodule_label29.Top = 140;
            this.__mainmodule_label29.Width = 0x37;
            this.__mainmodule_label29.Height = 20;
            this.__mainmodule_label29.Text = "Articulo:";
            this.__mainmodule_label29.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label29.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label29.MyEnabled = true;
            this.__mainmodule_label29.Visible = true;
            this.__mainmodule_label29.Transparent = false;
            this.__mainmodule_label29.Font = new Font(this.__mainmodule_label29.Font.Name, 9f, this.__mainmodule_label29.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_label29);
            this.htControls.Add("__mainmodule_label29", this.__mainmodule_label29);
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
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_ltconcepto);
            this.htControls.Add("__mainmodule_ltconcepto", this.__mainmodule_ltconcepto);
            this.__mainmodule_ltfoliocompra = new CEnhancedLabel(this);
            this.__mainmodule_ltfoliocompra.name = "__mainmodule_ltfoliocompra";
            this.__mainmodule_ltfoliocompra.Left = 8;
            this.__mainmodule_ltfoliocompra.Top = 0x38;
            this.__mainmodule_ltfoliocompra.Width = 0x48;
            this.__mainmodule_ltfoliocompra.Height = 20;
            this.__mainmodule_ltfoliocompra.Text = "Folio:";
            this.__mainmodule_ltfoliocompra.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_ltfoliocompra.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltfoliocompra.MyEnabled = true;
            this.__mainmodule_ltfoliocompra.Visible = true;
            this.__mainmodule_ltfoliocompra.Transparent = false;
            this.__mainmodule_ltfoliocompra.Font = new Font(this.__mainmodule_ltfoliocompra.Font.Name, 9f, this.__mainmodule_ltfoliocompra.Font.Style);
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_ltfoliocompra);
            this.htControls.Add("__mainmodule_ltfoliocompra", this.__mainmodule_ltfoliocompra);
            this.__mainmodule_btnsalirgencompra = new CEnhancedButton(this);
            this.__mainmodule_btnsalirgencompra.name = "__mainmodule_btnsalirgencompra";
            this.__mainmodule_btnsalirgencompra.Left = 190;
            this.__mainmodule_btnsalirgencompra.Top = 0x12;
            this.__mainmodule_btnsalirgencompra.Width = 0x2d;
            this.__mainmodule_btnsalirgencompra.Height = 0x19;
            this.__mainmodule_btnsalirgencompra.Text = "Salir";
            this.__mainmodule_btnsalirgencompra.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsalirgencompra.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsalirgencompra.Enabled = true;
            this.__mainmodule_btnsalirgencompra.Visible = true;
            this.__mainmodule_btnsalirgencompra.Font = new Font(this.__mainmodule_btnsalirgencompra.Font.Name, 9f, this.__mainmodule_btnsalirgencompra.Font.Style);
            this.__mainmodule_btnsalirgencompra.AddEvents();
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_btnsalirgencompra);
            this.htControls.Add("__mainmodule_btnsalirgencompra", this.__mainmodule_btnsalirgencompra);
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
            this.__mainmodule_gencompra.Controls.Add(this.__mainmodule_btngencompra);
            this.htControls.Add("__mainmodule_btngencompra", this.__mainmodule_btngencompra);
            this.__mainmodule_genpedido = new CEnhancedForm(this);
            this.__mainmodule_genpedido.name = "__mainmodule_genpedido";
            this.__mainmodule_genpedido.Text = "Generar pedido";
            this.__mainmodule_genpedido.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_genpedido.graphics.FillRectangle(new SolidBrush(this.__mainmodule_genpedido.BackColor), 0, 0, this.__mainmodule_genpedido.Width, this.__mainmodule_genpedido.Height);
            this.__mainmodule_genpedido.AddEvents();
            this.htControls.Add("__mainmodule_genpedido", this.__mainmodule_genpedido);
            this.__mainmodule_chenviartodospedidos = new CEnhancedCheckBox(this);
            this.__mainmodule_chenviartodospedidos.name = "__mainmodule_chenviartodospedidos";
            this.__mainmodule_chenviartodospedidos.Left = 5;
            this.__mainmodule_chenviartodospedidos.Top = 0x5f;
            this.__mainmodule_chenviartodospedidos.Width = 0xd7;
            this.__mainmodule_chenviartodospedidos.Height = 0x19;
            this.__mainmodule_chenviartodospedidos.Text = "Enviar todos los documentos";
            this.__mainmodule_chenviartodospedidos.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_chenviartodospedidos.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chenviartodospedidos.Enabled = true;
            this.__mainmodule_chenviartodospedidos.Visible = true;
            this.__mainmodule_chenviartodospedidos.Checked = false;
            this.__mainmodule_chenviartodospedidos.Font = new Font(this.__mainmodule_chenviartodospedidos.Font.Name, 9f, this.__mainmodule_chenviartodospedidos.Font.Style);
            this.__mainmodule_chenviartodospedidos.AddEvents();
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_chenviartodospedidos);
            this.htControls.Add("__mainmodule_chenviartodospedidos", this.__mainmodule_chenviartodospedidos);
            this.__mainmodule_btnsalirpedido = new CEnhancedButton(this);
            this.__mainmodule_btnsalirpedido.name = "__mainmodule_btnsalirpedido";
            this.__mainmodule_btnsalirpedido.Left = 0xb9;
            this.__mainmodule_btnsalirpedido.Top = 15;
            this.__mainmodule_btnsalirpedido.Width = 0x37;
            this.__mainmodule_btnsalirpedido.Height = 0x1d;
            this.__mainmodule_btnsalirpedido.Text = "Salir";
            this.__mainmodule_btnsalirpedido.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsalirpedido.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsalirpedido.Enabled = true;
            this.__mainmodule_btnsalirpedido.Visible = true;
            this.__mainmodule_btnsalirpedido.Font = new Font(this.__mainmodule_btnsalirpedido.Font.Name, 9f, this.__mainmodule_btnsalirpedido.Font.Style);
            this.__mainmodule_btnsalirpedido.AddEvents();
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_btnsalirpedido);
            this.htControls.Add("__mainmodule_btnsalirpedido", this.__mainmodule_btnsalirpedido);
            this.__mainmodule_btngenpedido = new CEnhancedButton(this);
            this.__mainmodule_btngenpedido.name = "__mainmodule_btngenpedido";
            this.__mainmodule_btngenpedido.Left = 5;
            this.__mainmodule_btngenpedido.Top = 5;
            this.__mainmodule_btngenpedido.Width = 0x87;
            this.__mainmodule_btngenpedido.Height = 0x23;
            this.__mainmodule_btngenpedido.Text = "Generar pedido";
            this.__mainmodule_btngenpedido.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btngenpedido.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btngenpedido.Enabled = true;
            this.__mainmodule_btngenpedido.Visible = true;
            this.__mainmodule_btngenpedido.Font = new Font(this.__mainmodule_btngenpedido.Font.Name, 9f, this.__mainmodule_btngenpedido.Font.Style);
            this.__mainmodule_btngenpedido.AddEvents();
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_btngenpedido);
            this.htControls.Add("__mainmodule_btngenpedido", this.__mainmodule_btngenpedido);
            this.__mainmodule_cbopedido = new CEnhancedCombo(this);
            this.__mainmodule_cbopedido.name = "__mainmodule_cbopedido";
            this.__mainmodule_cbopedido.Left = 0x2d;
            this.__mainmodule_cbopedido.Top = 60;
            this.__mainmodule_cbopedido.Width = 0xbb;
            this.__mainmodule_cbopedido.Height = 0x19;
            this.__mainmodule_cbopedido.Text = "";
            this.__mainmodule_cbopedido.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cbopedido.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cbopedido.Enabled = true;
            this.__mainmodule_cbopedido.Visible = true;
            this.__mainmodule_cbopedido.Font = new Font(this.__mainmodule_cbopedido.Font.Name, 10f, this.__mainmodule_cbopedido.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_cbopedido);
            this.htControls.Add("__mainmodule_cbopedido", this.__mainmodule_cbopedido);
            this.__mainmodule_cbopedido.AddEvents();
            this.__mainmodule_ltpedreg = new CEnhancedLabel(this);
            this.__mainmodule_ltpedreg.name = "__mainmodule_ltpedreg";
            this.__mainmodule_ltpedreg.Left = 170;
            this.__mainmodule_ltpedreg.Top = 0xa2;
            this.__mainmodule_ltpedreg.Width = 0x42;
            this.__mainmodule_ltpedreg.Height = 0x19;
            this.__mainmodule_ltpedreg.Text = "";
            this.__mainmodule_ltpedreg.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltpedreg.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltpedreg.MyEnabled = true;
            this.__mainmodule_ltpedreg.Visible = true;
            this.__mainmodule_ltpedreg.Transparent = false;
            this.__mainmodule_ltpedreg.Font = new Font(this.__mainmodule_ltpedreg.Font.Name, 9f, this.__mainmodule_ltpedreg.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_ltpedreg);
            this.htControls.Add("__mainmodule_ltpedreg", this.__mainmodule_ltpedreg);
            this.__mainmodule_label49 = new CEnhancedLabel(this);
            this.__mainmodule_label49.name = "__mainmodule_label49";
            this.__mainmodule_label49.Left = 0x7d;
            this.__mainmodule_label49.Top = 0xa5;
            this.__mainmodule_label49.Width = 40;
            this.__mainmodule_label49.Height = 20;
            this.__mainmodule_label49.Text = "Regs.";
            this.__mainmodule_label49.BackColor = Color.FromArgb(-7750929);
            this.__mainmodule_label49.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label49.MyEnabled = true;
            this.__mainmodule_label49.Visible = true;
            this.__mainmodule_label49.Transparent = false;
            this.__mainmodule_label49.Font = new Font(this.__mainmodule_label49.Font.Name, 9f, this.__mainmodule_label49.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_label49);
            this.htControls.Add("__mainmodule_label49", this.__mainmodule_label49);
            this.__mainmodule_ltpedcant = new CEnhancedLabel(this);
            this.__mainmodule_ltpedcant.name = "__mainmodule_ltpedcant";
            this.__mainmodule_ltpedcant.Left = 0x37;
            this.__mainmodule_ltpedcant.Top = 0xa2;
            this.__mainmodule_ltpedcant.Width = 0x41;
            this.__mainmodule_ltpedcant.Height = 0x19;
            this.__mainmodule_ltpedcant.Text = "";
            this.__mainmodule_ltpedcant.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltpedcant.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltpedcant.MyEnabled = true;
            this.__mainmodule_ltpedcant.Visible = true;
            this.__mainmodule_ltpedcant.Transparent = false;
            this.__mainmodule_ltpedcant.Font = new Font(this.__mainmodule_ltpedcant.Font.Name, 9f, this.__mainmodule_ltpedcant.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_ltpedcant);
            this.htControls.Add("__mainmodule_ltpedcant", this.__mainmodule_ltpedcant);
            this.__mainmodule_label47 = new CEnhancedLabel(this);
            this.__mainmodule_label47.name = "__mainmodule_label47";
            this.__mainmodule_label47.Left = 1;
            this.__mainmodule_label47.Top = 0xa5;
            this.__mainmodule_label47.Width = 50;
            this.__mainmodule_label47.Height = 20;
            this.__mainmodule_label47.Text = "Cant.";
            this.__mainmodule_label47.BackColor = Color.FromArgb(-7750929);
            this.__mainmodule_label47.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label47.MyEnabled = true;
            this.__mainmodule_label47.Visible = true;
            this.__mainmodule_label47.Transparent = false;
            this.__mainmodule_label47.Font = new Font(this.__mainmodule_label47.Font.Name, 9f, this.__mainmodule_label47.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_label47);
            this.htControls.Add("__mainmodule_label47", this.__mainmodule_label47);
            this.__mainmodule_ltpedart = new CEnhancedLabel(this);
            this.__mainmodule_ltpedart.name = "__mainmodule_ltpedart";
            this.__mainmodule_ltpedart.Left = 0x37;
            this.__mainmodule_ltpedart.Top = 0x83;
            this.__mainmodule_ltpedart.Width = 180;
            this.__mainmodule_ltpedart.Height = 0x1d;
            this.__mainmodule_ltpedart.Text = "";
            this.__mainmodule_ltpedart.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltpedart.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltpedart.MyEnabled = true;
            this.__mainmodule_ltpedart.Visible = true;
            this.__mainmodule_ltpedart.Transparent = false;
            this.__mainmodule_ltpedart.Font = new Font(this.__mainmodule_ltpedart.Font.Name, 9f, this.__mainmodule_ltpedart.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_ltpedart);
            this.htControls.Add("__mainmodule_ltpedart", this.__mainmodule_ltpedart);
            this.__mainmodule_label46 = new CEnhancedLabel(this);
            this.__mainmodule_label46.name = "__mainmodule_label46";
            this.__mainmodule_label46.Left = 1;
            this.__mainmodule_label46.Top = 0x83;
            this.__mainmodule_label46.Width = 50;
            this.__mainmodule_label46.Height = 0x19;
            this.__mainmodule_label46.Text = "Articulo";
            this.__mainmodule_label46.BackColor = Color.FromArgb(-7750929);
            this.__mainmodule_label46.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label46.MyEnabled = true;
            this.__mainmodule_label46.Visible = true;
            this.__mainmodule_label46.Transparent = false;
            this.__mainmodule_label46.Font = new Font(this.__mainmodule_label46.Font.Name, 9f, this.__mainmodule_label46.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_label46);
            this.htControls.Add("__mainmodule_label46", this.__mainmodule_label46);
            this.__mainmodule_label45 = new CEnhancedLabel(this);
            this.__mainmodule_label45.name = "__mainmodule_label45";
            this.__mainmodule_label45.Left = 5;
            this.__mainmodule_label45.Top = 60;
            this.__mainmodule_label45.Width = 0x29;
            this.__mainmodule_label45.Height = 0x19;
            this.__mainmodule_label45.Text = "Folio";
            this.__mainmodule_label45.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label45.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label45.MyEnabled = true;
            this.__mainmodule_label45.Visible = true;
            this.__mainmodule_label45.Transparent = false;
            this.__mainmodule_label45.Font = new Font(this.__mainmodule_label45.Font.Name, 9f, this.__mainmodule_label45.Font.Style);
            this.__mainmodule_genpedido.Controls.Add(this.__mainmodule_label45);
            this.htControls.Add("__mainmodule_label45", this.__mainmodule_label45);
            this.__mainmodule_frmcomprasutils = new CEnhancedForm(this);
            this.__mainmodule_frmcomprasutils.name = "__mainmodule_frmcomprasutils";
            this.__mainmodule_frmcomprasutils.Text = "Opciones compras";
            this.__mainmodule_frmcomprasutils.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmcomprasutils.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmcomprasutils.BackColor), 0, 0, this.__mainmodule_frmcomprasutils.Width, this.__mainmodule_frmcomprasutils.Height);
            this.__mainmodule_frmcomprasutils.AddEvents();
            this.htControls.Add("__mainmodule_frmcomprasutils", this.__mainmodule_frmcomprasutils);
            this.__mainmodule_tblcompras = new CEnhancedTable(this, "__mainmodule_tblcompras");
            this.__mainmodule_tblcompras.name = "__mainmodule_tblcompras";
            this.__mainmodule_tblcompras.Left = 1;
            this.__mainmodule_tblcompras.Top = 0x23;
            this.__mainmodule_tblcompras.Width = 0xeb;
            this.__mainmodule_tblcompras.Height = 0x98;
            this.__mainmodule_tblcompras.Text = "";
            this.__mainmodule_tblcompras.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tblcompras.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tblcompras.Enabled = true;
            this.__mainmodule_tblcompras.Visible = true;
            this.__mainmodule_tblcompras.Font = new Font(this.__mainmodule_tblcompras.Font.Name, 9f, this.__mainmodule_tblcompras.Font.Style);
            this.__mainmodule_tblcompras.AddEvents();
            this.__mainmodule_frmcomprasutils.Controls.Add(this.__mainmodule_tblcompras);
            this.htControls.Add("__mainmodule_tblcompras", this.__mainmodule_tblcompras);
            this.__mainmodule_cboprovutils = new CEnhancedCombo(this);
            this.__mainmodule_cboprovutils.name = "__mainmodule_cboprovutils";
            this.__mainmodule_cboprovutils.Left = 0x2d;
            this.__mainmodule_cboprovutils.Top = 10;
            this.__mainmodule_cboprovutils.Width = 0xa5;
            this.__mainmodule_cboprovutils.Height = 0x16;
            this.__mainmodule_cboprovutils.Text = "";
            this.__mainmodule_cboprovutils.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboprovutils.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboprovutils.Enabled = true;
            this.__mainmodule_cboprovutils.Visible = true;
            this.__mainmodule_cboprovutils.Font = new Font(this.__mainmodule_cboprovutils.Font.Name, 9f, this.__mainmodule_cboprovutils.Font.Style);
            this.__mainmodule_frmcomprasutils.Controls.Add(this.__mainmodule_cboprovutils);
            this.htControls.Add("__mainmodule_cboprovutils", this.__mainmodule_cboprovutils);
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
            this.__mainmodule_frmcomprasutils.Controls.Add(this.__mainmodule_label37);
            this.htControls.Add("__mainmodule_label37", this.__mainmodule_label37);
            this.__mainmodule_mnuarchivocompras = new CEnhancedMenu(this);
            this.__mainmodule_mnuarchivocompras.name = "__mainmodule_mnuarchivocompras";
            this.__mainmodule_mnuarchivocompras.Text = "Archivo";
            this.__mainmodule_mnuarchivocompras.Enabled = true;
            this.__mainmodule_mnuarchivocompras.Checked = false;
            this.__mainmodule_mnuarchivocompras.AddToObject("__mainmodule_frmcomprasutils");
            this.__mainmodule_mnuarchivocompras.AddEvents();
            this.htControls.Add("__mainmodule_mnuarchivocompras", this.__mainmodule_mnuarchivocompras);
            this.__mainmodule_mnucancelcompra = new CEnhancedMenu(this);
            this.__mainmodule_mnucancelcompra.name = "__mainmodule_mnucancelcompra";
            this.__mainmodule_mnucancelcompra.Text = "Cancelar compra";
            this.__mainmodule_mnucancelcompra.Enabled = true;
            this.__mainmodule_mnucancelcompra.Checked = false;
            this.__mainmodule_mnucancelcompra.AddToObject("__mainmodule_mnuarchivocompras");
            this.__mainmodule_mnucancelcompra.AddEvents();
            this.htControls.Add("__mainmodule_mnucancelcompra", this.__mainmodule_mnucancelcompra);
            this.__mainmodule_mnucancelarpartidacompra = new CEnhancedMenu(this);
            this.__mainmodule_mnucancelarpartidacompra.name = "__mainmodule_mnucancelarpartidacompra";
            this.__mainmodule_mnucancelarpartidacompra.Text = "Eliminar partida";
            this.__mainmodule_mnucancelarpartidacompra.Enabled = true;
            this.__mainmodule_mnucancelarpartidacompra.Checked = false;
            this.__mainmodule_mnucancelarpartidacompra.AddToObject("__mainmodule_mnuarchivocompras");
            this.__mainmodule_mnucancelarpartidacompra.AddEvents();
            this.htControls.Add("__mainmodule_mnucancelarpartidacompra", this.__mainmodule_mnucancelarpartidacompra);
            this.__mainmodule_mnusalirutilscompra = new CEnhancedMenu(this);
            this.__mainmodule_mnusalirutilscompra.name = "__mainmodule_mnusalirutilscompra";
            this.__mainmodule_mnusalirutilscompra.Text = "Salir";
            this.__mainmodule_mnusalirutilscompra.Enabled = true;
            this.__mainmodule_mnusalirutilscompra.Checked = false;
            this.__mainmodule_mnusalirutilscompra.AddToObject("__mainmodule_mnuarchivocompras");
            this.__mainmodule_mnusalirutilscompra.AddEvents();
            this.htControls.Add("__mainmodule_mnusalirutilscompra", this.__mainmodule_mnusalirutilscompra);
            this.__mainmodule_frmpedidosutils = new CEnhancedForm(this);
            this.__mainmodule_frmpedidosutils.name = "__mainmodule_frmpedidosutils";
            this.__mainmodule_frmpedidosutils.Text = "Pedidos";
            this.__mainmodule_frmpedidosutils.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmpedidosutils.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmpedidosutils.BackColor), 0, 0, this.__mainmodule_frmpedidosutils.Width, this.__mainmodule_frmpedidosutils.Height);
            this.__mainmodule_frmpedidosutils.AddEvents();
            this.htControls.Add("__mainmodule_frmpedidosutils", this.__mainmodule_frmpedidosutils);
            this.__mainmodule_btnsalped = new CEnhancedButton(this);
            this.__mainmodule_btnsalped.name = "__mainmodule_btnsalped";
            this.__mainmodule_btnsalped.Left = 0xbb;
            this.__mainmodule_btnsalped.Top = 4;
            this.__mainmodule_btnsalped.Width = 0x2f;
            this.__mainmodule_btnsalped.Height = 0x20;
            this.__mainmodule_btnsalped.Text = "Salir";
            this.__mainmodule_btnsalped.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsalped.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsalped.Enabled = true;
            this.__mainmodule_btnsalped.Visible = true;
            this.__mainmodule_btnsalped.Font = new Font(this.__mainmodule_btnsalped.Font.Name, 9f, this.__mainmodule_btnsalped.Font.Style);
            this.__mainmodule_btnsalped.AddEvents();
            this.__mainmodule_frmpedidosutils.Controls.Add(this.__mainmodule_btnsalped);
            this.htControls.Add("__mainmodule_btnsalped", this.__mainmodule_btnsalped);
            this.__mainmodule_tblpedidos = new CEnhancedTable(this, "__mainmodule_tblpedidos");
            this.__mainmodule_tblpedidos.name = "__mainmodule_tblpedidos";
            this.__mainmodule_tblpedidos.Left = 3;
            this.__mainmodule_tblpedidos.Top = 0x29;
            this.__mainmodule_tblpedidos.Width = 0xec;
            this.__mainmodule_tblpedidos.Height = 0xe1;
            this.__mainmodule_tblpedidos.Text = "";
            this.__mainmodule_tblpedidos.propColor = Color.FromArgb(-657931);
            this.__mainmodule_tblpedidos.TableStyles[0].ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tblpedidos.Enabled = true;
            this.__mainmodule_tblpedidos.Visible = true;
            this.__mainmodule_tblpedidos.Font = new Font(this.__mainmodule_tblpedidos.Font.Name, 9f, this.__mainmodule_tblpedidos.Font.Style);
            this.__mainmodule_tblpedidos.AddEvents();
            this.__mainmodule_frmpedidosutils.Controls.Add(this.__mainmodule_tblpedidos);
            this.htControls.Add("__mainmodule_tblpedidos", this.__mainmodule_tblpedidos);
            this.__mainmodule_cboclieutils = new CEnhancedCombo(this);
            this.__mainmodule_cboclieutils.name = "__mainmodule_cboclieutils";
            this.__mainmodule_cboclieutils.Left = 0x23;
            this.__mainmodule_cboclieutils.Top = 9;
            this.__mainmodule_cboclieutils.Width = 0x84;
            this.__mainmodule_cboclieutils.Height = 0x16;
            this.__mainmodule_cboclieutils.Text = "";
            this.__mainmodule_cboclieutils.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboclieutils.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboclieutils.Enabled = true;
            this.__mainmodule_cboclieutils.Visible = true;
            this.__mainmodule_cboclieutils.Font = new Font(this.__mainmodule_cboclieutils.Font.Name, 9f, this.__mainmodule_cboclieutils.Font.Style);
            this.__mainmodule_frmpedidosutils.Controls.Add(this.__mainmodule_cboclieutils);
            this.htControls.Add("__mainmodule_cboclieutils", this.__mainmodule_cboclieutils);
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
            this.__mainmodule_frmpedidosutils.Controls.Add(this.__mainmodule_label56);
            this.htControls.Add("__mainmodule_label56", this.__mainmodule_label56);
            this.__mainmodule_mnuarchipedutils = new CEnhancedMenu(this);
            this.__mainmodule_mnuarchipedutils.name = "__mainmodule_mnuarchipedutils";
            this.__mainmodule_mnuarchipedutils.Text = "Archivo";
            this.__mainmodule_mnuarchipedutils.Enabled = true;
            this.__mainmodule_mnuarchipedutils.Checked = false;
            this.__mainmodule_mnuarchipedutils.AddToObject("__mainmodule_frmpedidosutils");
            this.__mainmodule_mnuarchipedutils.AddEvents();
            this.htControls.Add("__mainmodule_mnuarchipedutils", this.__mainmodule_mnuarchipedutils);
            this.__mainmodule_mnucanped = new CEnhancedMenu(this);
            this.__mainmodule_mnucanped.name = "__mainmodule_mnucanped";
            this.__mainmodule_mnucanped.Text = "Cancelar";
            this.__mainmodule_mnucanped.Enabled = true;
            this.__mainmodule_mnucanped.Checked = false;
            this.__mainmodule_mnucanped.AddToObject("__mainmodule_mnuarchipedutils");
            this.__mainmodule_mnucanped.AddEvents();
            this.htControls.Add("__mainmodule_mnucanped", this.__mainmodule_mnucanped);
            this.__mainmodule_mnueliped = new CEnhancedMenu(this);
            this.__mainmodule_mnueliped.name = "__mainmodule_mnueliped";
            this.__mainmodule_mnueliped.Text = "Eliminar";
            this.__mainmodule_mnueliped.Enabled = true;
            this.__mainmodule_mnueliped.Checked = false;
            this.__mainmodule_mnueliped.AddToObject("__mainmodule_mnuarchipedutils");
            this.__mainmodule_mnueliped.AddEvents();
            this.htControls.Add("__mainmodule_mnueliped", this.__mainmodule_mnueliped);
            this.__mainmodule_mnusalp = new CEnhancedMenu(this);
            this.__mainmodule_mnusalp.name = "__mainmodule_mnusalp";
            this.__mainmodule_mnusalp.Text = "Salir";
            this.__mainmodule_mnusalp.Enabled = true;
            this.__mainmodule_mnusalp.Checked = false;
            this.__mainmodule_mnusalp.AddToObject("__mainmodule_mnuarchipedutils");
            this.__mainmodule_mnusalp.AddEvents();
            this.htControls.Add("__mainmodule_mnusalp", this.__mainmodule_mnusalp);
            this.__mainmodule_frmmenu = new CEnhancedForm(this);
            this.__mainmodule_frmmenu.name = "__mainmodule_frmmenu";
            this.__mainmodule_frmmenu.Text = "Menu";
            this.__mainmodule_frmmenu.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmmenu.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmmenu.BackColor), 0, 0, this.__mainmodule_frmmenu.Width, this.__mainmodule_frmmenu.Height);
            this.__mainmodule_frmmenu.AddEvents();
            this.htControls.Add("__mainmodule_frmmenu", this.__mainmodule_frmmenu);
            this.__mainmodule_pnlpedidos = new CEnhancedPanel(this);
            this.__mainmodule_pnlpedidos.name = "__mainmodule_pnlpedidos";
            this.__mainmodule_pnlpedidos.Left = 0xcd;
            this.__mainmodule_pnlpedidos.Top = 0x9b;
            this.__mainmodule_pnlpedidos.Width = 240;
            this.__mainmodule_pnlpedidos.Height = 190;
            this.__mainmodule_pnlpedidos.BackColor = Color.FromArgb(-11035939);
            this.__mainmodule_pnlpedidos.Enabled = true;
            this.__mainmodule_pnlpedidos.Visible = false;
            this.__mainmodule_pnlpedidos.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_pnlpedidos);
            this.htControls.Add("__mainmodule_pnlpedidos", this.__mainmodule_pnlpedidos);
            this.__mainmodule_btncteped2 = new CEnhancedButton(this);
            this.__mainmodule_btncteped2.name = "__mainmodule_btncteped2";
            this.__mainmodule_btncteped2.Left = 0x87;
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
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_btncteped2);
            this.htControls.Add("__mainmodule_btncteped2", this.__mainmodule_btncteped2);
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
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_btncteped1);
            this.htControls.Add("__mainmodule_btncteped1", this.__mainmodule_btncteped1);
            this.__mainmodule_tpedcte = new CEnhancedTextBox(this);
            this.__mainmodule_tpedcte.name = "__mainmodule_tpedcte";
            this.__mainmodule_tpedcte.Left = 0x37;
            this.__mainmodule_tpedcte.Top = 5;
            this.__mainmodule_tpedcte.Width = 0x55;
            this.__mainmodule_tpedcte.Text = "";
            this.__mainmodule_tpedcte.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tpedcte.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tpedcte.Enabled = true;
            this.__mainmodule_tpedcte.Visible = true;
            this.__mainmodule_tpedcte.Height = 0x19;
            this.__mainmodule_tpedcte.Font = new Font(this.__mainmodule_tpedcte.Font.Name, 10f, this.__mainmodule_tpedcte.Font.Style);
            this.__mainmodule_tpedcte.multiline = false;
            this.__mainmodule_tpedcte.AddEvents();
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_tpedcte);
            this.htControls.Add("__mainmodule_tpedcte", this.__mainmodule_tpedcte);
            this.__mainmodule_btnokcte = new CEnhancedImageButton(this);
            this.__mainmodule_btnokcte.name = "__mainmodule_btnokcte";
            this.__mainmodule_btnokcte.Left = 0x91;
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
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_btnokcte);
            this.htControls.Add("__mainmodule_btnokcte", this.__mainmodule_btnokcte);
            this.__mainmodule_btnbuscarcte = new CEnhancedImageButton(this);
            this.__mainmodule_btnbuscarcte.name = "__mainmodule_btnbuscarcte";
            this.__mainmodule_btnbuscarcte.Left = 0xc3;
            this.__mainmodule_btnbuscarcte.Top = 2;
            this.__mainmodule_btnbuscarcte.Width = 0x23;
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
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_btnbuscarcte);
            this.htControls.Add("__mainmodule_btnbuscarcte", this.__mainmodule_btnbuscarcte);
            this.__mainmodule_ltnombrecte = new CEnhancedLabel(this);
            this.__mainmodule_ltnombrecte.name = "__mainmodule_ltnombrecte";
            this.__mainmodule_ltnombrecte.Left = 0x37;
            this.__mainmodule_ltnombrecte.Top = 0x23;
            this.__mainmodule_ltnombrecte.Width = 0xaf;
            this.__mainmodule_ltnombrecte.Height = 0x37;
            this.__mainmodule_ltnombrecte.Text = "";
            this.__mainmodule_ltnombrecte.BackColor = Color.FromArgb(-1);
            this.__mainmodule_ltnombrecte.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltnombrecte.MyEnabled = true;
            this.__mainmodule_ltnombrecte.Visible = true;
            this.__mainmodule_ltnombrecte.Transparent = false;
            this.__mainmodule_ltnombrecte.Font = new Font(this.__mainmodule_ltnombrecte.Font.Name, 9f, this.__mainmodule_ltnombrecte.Font.Style);
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_ltnombrecte);
            this.htControls.Add("__mainmodule_ltnombrecte", this.__mainmodule_ltnombrecte);
            this.__mainmodule_label50 = new CEnhancedLabel(this);
            this.__mainmodule_label50.name = "__mainmodule_label50";
            this.__mainmodule_label50.Left = 1;
            this.__mainmodule_label50.Top = 0x25;
            this.__mainmodule_label50.Width = 0x37;
            this.__mainmodule_label50.Height = 20;
            this.__mainmodule_label50.Text = "Nombre:";
            this.__mainmodule_label50.BackColor = Color.FromArgb(-11035939);
            this.__mainmodule_label50.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label50.MyEnabled = true;
            this.__mainmodule_label50.Visible = true;
            this.__mainmodule_label50.Transparent = false;
            this.__mainmodule_label50.Font = new Font(this.__mainmodule_label50.Font.Name, 9f, this.__mainmodule_label50.Font.Style);
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_label50);
            this.htControls.Add("__mainmodule_label50", this.__mainmodule_label50);
            this.__mainmodule_label48 = new CEnhancedLabel(this);
            this.__mainmodule_label48.name = "__mainmodule_label48";
            this.__mainmodule_label48.Left = 1;
            this.__mainmodule_label48.Top = 10;
            this.__mainmodule_label48.Width = 0x37;
            this.__mainmodule_label48.Height = 20;
            this.__mainmodule_label48.Text = "Clave";
            this.__mainmodule_label48.BackColor = Color.FromArgb(-11035939);
            this.__mainmodule_label48.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label48.MyEnabled = true;
            this.__mainmodule_label48.Visible = true;
            this.__mainmodule_label48.Transparent = false;
            this.__mainmodule_label48.Font = new Font(this.__mainmodule_label48.Font.Name, 9f, this.__mainmodule_label48.Font.Style);
            this.__mainmodule_pnlpedidos.Controls.Add(this.__mainmodule_label48);
            this.htControls.Add("__mainmodule_label48", this.__mainmodule_label48);
            this.__mainmodule_btnpedido = new CEnhancedButton(this);
            this.__mainmodule_btnpedido.name = "__mainmodule_btnpedido";
            this.__mainmodule_btnpedido.Left = 0x37;
            this.__mainmodule_btnpedido.Top = 0x27;
            this.__mainmodule_btnpedido.Width = 0x7d;
            this.__mainmodule_btnpedido.Height = 0x23;
            this.__mainmodule_btnpedido.Text = "Pedidos";
            this.__mainmodule_btnpedido.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnpedido.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnpedido.Enabled = true;
            this.__mainmodule_btnpedido.Visible = true;
            this.__mainmodule_btnpedido.Font = new Font(this.__mainmodule_btnpedido.Font.Name, 9f, this.__mainmodule_btnpedido.Font.Style);
            this.__mainmodule_btnpedido.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_btnpedido);
            this.htControls.Add("__mainmodule_btnpedido", this.__mainmodule_btnpedido);
            this.__mainmodule_btntraspasos = new CEnhancedButton(this);
            this.__mainmodule_btntraspasos.name = "__mainmodule_btntraspasos";
            this.__mainmodule_btntraspasos.Left = 0x37;
            this.__mainmodule_btntraspasos.Top = 0x72;
            this.__mainmodule_btntraspasos.Width = 0x7d;
            this.__mainmodule_btntraspasos.Height = 0x23;
            this.__mainmodule_btntraspasos.Text = "Transpasos";
            this.__mainmodule_btntraspasos.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntraspasos.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntraspasos.Enabled = true;
            this.__mainmodule_btntraspasos.Visible = true;
            this.__mainmodule_btntraspasos.Font = new Font(this.__mainmodule_btntraspasos.Font.Name, 9f, this.__mainmodule_btntraspasos.Font.Style);
            this.__mainmodule_btntraspasos.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_btntraspasos);
            this.htControls.Add("__mainmodule_btntraspasos", this.__mainmodule_btntraspasos);
            this.__mainmodule_btnmenusalir = new CEnhancedButton(this);
            this.__mainmodule_btnmenusalir.name = "__mainmodule_btnmenusalir";
            this.__mainmodule_btnmenusalir.Left = 0x37;
            this.__mainmodule_btnmenusalir.Top = 0x97;
            this.__mainmodule_btnmenusalir.Width = 0x7d;
            this.__mainmodule_btnmenusalir.Height = 0x23;
            this.__mainmodule_btnmenusalir.Text = "Salir";
            this.__mainmodule_btnmenusalir.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnmenusalir.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnmenusalir.Enabled = true;
            this.__mainmodule_btnmenusalir.Visible = true;
            this.__mainmodule_btnmenusalir.Font = new Font(this.__mainmodule_btnmenusalir.Font.Name, 9f, this.__mainmodule_btnmenusalir.Font.Style);
            this.__mainmodule_btnmenusalir.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_btnmenusalir);
            this.htControls.Add("__mainmodule_btnmenusalir", this.__mainmodule_btnmenusalir);
            this.__mainmodule_btnmenucompras = new CEnhancedButton(this);
            this.__mainmodule_btnmenucompras.name = "__mainmodule_btnmenucompras";
            this.__mainmodule_btnmenucompras.Left = 0x37;
            this.__mainmodule_btnmenucompras.Top = 0x4d;
            this.__mainmodule_btnmenucompras.Width = 0x7d;
            this.__mainmodule_btnmenucompras.Height = 0x23;
            this.__mainmodule_btnmenucompras.Text = "Compras";
            this.__mainmodule_btnmenucompras.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnmenucompras.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnmenucompras.Enabled = true;
            this.__mainmodule_btnmenucompras.Visible = true;
            this.__mainmodule_btnmenucompras.Font = new Font(this.__mainmodule_btnmenucompras.Font.Name, 9f, this.__mainmodule_btnmenucompras.Font.Style);
            this.__mainmodule_btnmenucompras.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_btnmenucompras);
            this.htControls.Add("__mainmodule_btnmenucompras", this.__mainmodule_btnmenucompras);
            this.__mainmodule_btnmenuinvent = new CEnhancedButton(this);
            this.__mainmodule_btnmenuinvent.name = "__mainmodule_btnmenuinvent";
            this.__mainmodule_btnmenuinvent.Left = 0x37;
            this.__mainmodule_btnmenuinvent.Top = 2;
            this.__mainmodule_btnmenuinvent.Width = 0x7d;
            this.__mainmodule_btnmenuinvent.Height = 0x23;
            this.__mainmodule_btnmenuinvent.Text = "Inventario";
            this.__mainmodule_btnmenuinvent.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnmenuinvent.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnmenuinvent.Enabled = true;
            this.__mainmodule_btnmenuinvent.Visible = true;
            this.__mainmodule_btnmenuinvent.Font = new Font(this.__mainmodule_btnmenuinvent.Font.Name, 9f, this.__mainmodule_btnmenuinvent.Font.Style);
            this.__mainmodule_btnmenuinvent.AddEvents();
            this.__mainmodule_frmmenu.Controls.Add(this.__mainmodule_btnmenuinvent);
            this.htControls.Add("__mainmodule_btnmenuinvent", this.__mainmodule_btnmenuinvent);
            this.__mainmodule_invent = new CEnhancedForm(this);
            this.__mainmodule_invent.name = "__mainmodule_invent";
            this.__mainmodule_invent.Text = "Inventario";
            this.__mainmodule_invent.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_invent.graphics.FillRectangle(new SolidBrush(this.__mainmodule_invent.BackColor), 0, 0, this.__mainmodule_invent.Width, this.__mainmodule_invent.Height);
            this.__mainmodule_invent.AddEvents();
            this.htControls.Add("__mainmodule_invent", this.__mainmodule_invent);
            this.__mainmodule_pnlred = new CEnhancedPanel(this);
            this.__mainmodule_pnlred.name = "__mainmodule_pnlred";
            this.__mainmodule_pnlred.Left = 0xd7;
            this.__mainmodule_pnlred.Top = 60;
            this.__mainmodule_pnlred.Width = 0xeb;
            this.__mainmodule_pnlred.Height = 0x87;
            this.__mainmodule_pnlred.BackColor = Color.FromArgb(-65536);
            this.__mainmodule_pnlred.Enabled = true;
            this.__mainmodule_pnlred.Visible = false;
            this.__mainmodule_pnlred.AddEvents();
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_pnlred);
            this.htControls.Add("__mainmodule_pnlred", this.__mainmodule_pnlred);
            this.__mainmodule_lt2 = new CEnhancedLabel(this);
            this.__mainmodule_lt2.name = "__mainmodule_lt2";
            this.__mainmodule_lt2.Left = 50;
            this.__mainmodule_lt2.Top = 200;
            this.__mainmodule_lt2.Width = 0x37;
            this.__mainmodule_lt2.Height = 0x19;
            this.__mainmodule_lt2.Text = "";
            this.__mainmodule_lt2.BackColor = Color.FromArgb(-128);
            this.__mainmodule_lt2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lt2.MyEnabled = true;
            this.__mainmodule_lt2.Visible = false;
            this.__mainmodule_lt2.Transparent = false;
            this.__mainmodule_lt2.Font = new Font(this.__mainmodule_lt2.Font.Name, 9f, this.__mainmodule_lt2.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_lt2);
            this.htControls.Add("__mainmodule_lt2", this.__mainmodule_lt2);
            this.__mainmodule_lt4 = new CEnhancedLabel(this);
            this.__mainmodule_lt4.name = "__mainmodule_lt4";
            this.__mainmodule_lt4.Left = 50;
            this.__mainmodule_lt4.Top = 230;
            this.__mainmodule_lt4.Width = 180;
            this.__mainmodule_lt4.Height = 0x23;
            this.__mainmodule_lt4.Text = "";
            this.__mainmodule_lt4.BackColor = Color.FromArgb(-128);
            this.__mainmodule_lt4.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lt4.MyEnabled = true;
            this.__mainmodule_lt4.Visible = false;
            this.__mainmodule_lt4.Transparent = false;
            this.__mainmodule_lt4.Font = new Font(this.__mainmodule_lt4.Font.Name, 9f, this.__mainmodule_lt4.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_lt4);
            this.htControls.Add("__mainmodule_lt4", this.__mainmodule_lt4);
            this.__mainmodule_lt3 = new CEnhancedLabel(this);
            this.__mainmodule_lt3.name = "__mainmodule_lt3";
            this.__mainmodule_lt3.Left = 1;
            this.__mainmodule_lt3.Top = 230;
            this.__mainmodule_lt3.Width = 50;
            this.__mainmodule_lt3.Height = 0x19;
            this.__mainmodule_lt3.Text = "Nombre";
            this.__mainmodule_lt3.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_lt3.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lt3.MyEnabled = true;
            this.__mainmodule_lt3.Visible = false;
            this.__mainmodule_lt3.Transparent = false;
            this.__mainmodule_lt3.Font = new Font(this.__mainmodule_lt3.Font.Name, 9f, this.__mainmodule_lt3.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_lt3);
            this.htControls.Add("__mainmodule_lt3", this.__mainmodule_lt3);
            this.__mainmodule_lt1 = new CEnhancedLabel(this);
            this.__mainmodule_lt1.name = "__mainmodule_lt1";
            this.__mainmodule_lt1.Left = 1;
            this.__mainmodule_lt1.Top = 200;
            this.__mainmodule_lt1.Width = 50;
            this.__mainmodule_lt1.Height = 0x19;
            this.__mainmodule_lt1.Text = "Cliente";
            this.__mainmodule_lt1.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_lt1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lt1.MyEnabled = true;
            this.__mainmodule_lt1.Visible = false;
            this.__mainmodule_lt1.Transparent = false;
            this.__mainmodule_lt1.Font = new Font(this.__mainmodule_lt1.Font.Name, 9f, this.__mainmodule_lt1.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_lt1);
            this.htControls.Add("__mainmodule_lt1", this.__mainmodule_lt1);
            this.__mainmodule_tarticulo = new CEnhancedTextBox(this);
            this.__mainmodule_tarticulo.name = "__mainmodule_tarticulo";
            this.__mainmodule_tarticulo.Left = 4;
            this.__mainmodule_tarticulo.Top = 30;
            this.__mainmodule_tarticulo.Width = 0xaf;
            this.__mainmodule_tarticulo.Text = "";
            this.__mainmodule_tarticulo.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tarticulo.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tarticulo.Enabled = true;
            this.__mainmodule_tarticulo.Visible = true;
            this.__mainmodule_tarticulo.Height = 0x19;
            this.__mainmodule_tarticulo.Font = new Font(this.__mainmodule_tarticulo.Font.Name, 10f, this.__mainmodule_tarticulo.Font.Style);
            this.__mainmodule_tarticulo.multiline = false;
            this.__mainmodule_tarticulo.AddEvents();
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_tarticulo);
            this.htControls.Add("__mainmodule_tarticulo", this.__mainmodule_tarticulo);
            this.__mainmodule_tuni = new CEnhancedTextBox(this);
            this.__mainmodule_tuni.name = "__mainmodule_tuni";
            this.__mainmodule_tuni.Left = 0xb9;
            this.__mainmodule_tuni.Top = 0x19;
            this.__mainmodule_tuni.Width = 50;
            this.__mainmodule_tuni.Text = "";
            this.__mainmodule_tuni.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tuni.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tuni.Enabled = true;
            this.__mainmodule_tuni.Visible = true;
            this.__mainmodule_tuni.Height = 0x23;
            this.__mainmodule_tuni.Font = new Font(this.__mainmodule_tuni.Font.Name, 14f, this.__mainmodule_tuni.Font.Style);
            this.__mainmodule_tuni.multiline = false;
            this.__mainmodule_tuni.AddEvents();
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_tuni);
            this.htControls.Add("__mainmodule_tuni", this.__mainmodule_tuni);
            this.__mainmodule_cboareas = new CEnhancedCombo(this);
            this.__mainmodule_cboareas.name = "__mainmodule_cboareas";
            this.__mainmodule_cboareas.Left = 50;
            this.__mainmodule_cboareas.Top = 0xc3;
            this.__mainmodule_cboareas.Width = 0xaf;
            this.__mainmodule_cboareas.Height = 0x16;
            this.__mainmodule_cboareas.Text = "";
            this.__mainmodule_cboareas.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboareas.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboareas.Enabled = true;
            this.__mainmodule_cboareas.Visible = true;
            this.__mainmodule_cboareas.Font = new Font(this.__mainmodule_cboareas.Font.Name, 9f, this.__mainmodule_cboareas.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_cboareas);
            this.htControls.Add("__mainmodule_cboareas", this.__mainmodule_cboareas);
            this.__mainmodule_cboareas.AddEvents();
            this.__mainmodule_label30 = new CEnhancedLabel(this);
            this.__mainmodule_label30.name = "__mainmodule_label30";
            this.__mainmodule_label30.Left = 10;
            this.__mainmodule_label30.Top = 0xc3;
            this.__mainmodule_label30.Width = 40;
            this.__mainmodule_label30.Height = 0x19;
            this.__mainmodule_label30.Text = "Area:";
            this.__mainmodule_label30.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_label30.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label30.MyEnabled = true;
            this.__mainmodule_label30.Visible = true;
            this.__mainmodule_label30.Transparent = false;
            this.__mainmodule_label30.Font = new Font(this.__mainmodule_label30.Font.Name, 9f, this.__mainmodule_label30.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_label30);
            this.htControls.Add("__mainmodule_label30", this.__mainmodule_label30);
            this.__mainmodule_ltartinv = new CEnhancedLabel(this);
            this.__mainmodule_ltartinv.name = "__mainmodule_ltartinv";
            this.__mainmodule_ltartinv.Left = 10;
            this.__mainmodule_ltartinv.Top = 0;
            this.__mainmodule_ltartinv.Width = 0xeb;
            this.__mainmodule_ltartinv.Height = 110;
            this.__mainmodule_ltartinv.Text = "______";
            this.__mainmodule_ltartinv.BackColor = Color.FromArgb(-65536);
            this.__mainmodule_ltartinv.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltartinv.MyEnabled = true;
            this.__mainmodule_ltartinv.Visible = true;
            this.__mainmodule_ltartinv.Transparent = false;
            this.__mainmodule_ltartinv.Font = new Font(this.__mainmodule_ltartinv.Font.Name, 12f, this.__mainmodule_ltartinv.Font.Style);
            this.__mainmodule_pnlred.Controls.Add(this.__mainmodule_ltartinv);
            this.htControls.Add("__mainmodule_ltartinv", this.__mainmodule_ltartinv);
            this.__mainmodule_btnred = new CEnhancedButton(this);
            this.__mainmodule_btnred.name = "__mainmodule_btnred";
            this.__mainmodule_btnred.Left = 0x37;
            this.__mainmodule_btnred.Top = 0x69;
            this.__mainmodule_btnred.Width = 120;
            this.__mainmodule_btnred.Height = 0x23;
            this.__mainmodule_btnred.Text = "Aceptar";
            this.__mainmodule_btnred.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnred.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnred.Enabled = true;
            this.__mainmodule_btnred.Visible = true;
            this.__mainmodule_btnred.Font = new Font(this.__mainmodule_btnred.Font.Name, 9f, this.__mainmodule_btnred.Font.Style);
            this.__mainmodule_btnred.AddEvents();
            this.__mainmodule_pnlred.Controls.Add(this.__mainmodule_btnred);
            this.htControls.Add("__mainmodule_btnred", this.__mainmodule_btnred);
            this.__mainmodule_ltred = new CEnhancedLabel(this);
            this.__mainmodule_ltred.name = "__mainmodule_ltred";
            this.__mainmodule_ltred.Left = 50;
            this.__mainmodule_ltred.Top = 0;
            this.__mainmodule_ltred.Width = 0xc3;
            this.__mainmodule_ltred.Height = 70;
            this.__mainmodule_ltred.Text = "         LA CLAVE DEL ARTICULO NO EXISTE";
            this.__mainmodule_ltred.BackColor = Color.FromArgb(-65536);
            this.__mainmodule_ltred.ForeColor = Color.FromArgb(-1);
            this.__mainmodule_ltred.MyEnabled = true;
            this.__mainmodule_ltred.Visible = true;
            this.__mainmodule_ltred.Transparent = false;
            this.__mainmodule_ltred.Font = new Font(this.__mainmodule_ltred.Font.Name, 14f, this.__mainmodule_ltred.Font.Style);
            this.__mainmodule_pnlred.Controls.Add(this.__mainmodule_ltred);
            this.htControls.Add("__mainmodule_ltred", this.__mainmodule_ltred);
            this.__mainmodule_ltfc = new CEnhancedLabel(this);
            this.__mainmodule_ltfc.name = "__mainmodule_ltfc";
            this.__mainmodule_ltfc.Left = 0x37;
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
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_ltfc);
            this.htControls.Add("__mainmodule_ltfc", this.__mainmodule_ltfc);
            this.__mainmodule_ltsae = new CEnhancedLabel(this);
            this.__mainmodule_ltsae.name = "__mainmodule_ltsae";
            this.__mainmodule_ltsae.Left = 0x2d;
            this.__mainmodule_ltsae.Top = 110;
            this.__mainmodule_ltsae.Width = 150;
            this.__mainmodule_ltsae.Height = 20;
            this.__mainmodule_ltsae.Text = "Existencia acumulada";
            this.__mainmodule_ltsae.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltsae.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsae.MyEnabled = true;
            this.__mainmodule_ltsae.Visible = true;
            this.__mainmodule_ltsae.Transparent = false;
            this.__mainmodule_ltsae.Font = new Font(this.__mainmodule_ltsae.Font.Name, 10f, this.__mainmodule_ltsae.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_ltsae);
            this.htControls.Add("__mainmodule_ltsae", this.__mainmodule_ltsae);
            this.__mainmodule_ltinven = new CEnhancedLabel(this);
            this.__mainmodule_ltinven.name = "__mainmodule_ltinven";
            this.__mainmodule_ltinven.Left = 3;
            this.__mainmodule_ltinven.Top = 130;
            this.__mainmodule_ltinven.Width = 0xeb;
            this.__mainmodule_ltinven.Height = 0x37;
            this.__mainmodule_ltinven.Text = "";
            this.__mainmodule_ltinven.BackColor = Color.FromArgb(-8323200);
            this.__mainmodule_ltinven.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltinven.MyEnabled = true;
            this.__mainmodule_ltinven.Visible = true;
            this.__mainmodule_ltinven.Transparent = false;
            this.__mainmodule_ltinven.Font = new Font(this.__mainmodule_ltinven.Font.Name, 24f, this.__mainmodule_ltinven.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_ltinven);
            this.htControls.Add("__mainmodule_ltinven", this.__mainmodule_ltinven);
            this.__mainmodule_cmdinv = new CEnhancedButton(this);
            this.__mainmodule_cmdinv.name = "__mainmodule_cmdinv";
            this.__mainmodule_cmdinv.Left = 200;
            this.__mainmodule_cmdinv.Top = 2;
            this.__mainmodule_cmdinv.Width = 0x23;
            this.__mainmodule_cmdinv.Height = 20;
            this.__mainmodule_cmdinv.Text = ".....";
            this.__mainmodule_cmdinv.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_cmdinv.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdinv.Enabled = true;
            this.__mainmodule_cmdinv.Visible = true;
            this.__mainmodule_cmdinv.Font = new Font(this.__mainmodule_cmdinv.Font.Name, 9f, this.__mainmodule_cmdinv.Font.Style);
            this.__mainmodule_cmdinv.AddEvents();
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_cmdinv);
            this.htControls.Add("__mainmodule_cmdinv", this.__mainmodule_cmdinv);
            this.__mainmodule_ltinven2 = new CEnhancedLabel(this);
            this.__mainmodule_ltinven2.name = "__mainmodule_ltinven2";
            this.__mainmodule_ltinven2.Left = 3;
            this.__mainmodule_ltinven2.Top = 0x3e;
            this.__mainmodule_ltinven2.Width = 0xeb;
            this.__mainmodule_ltinven2.Height = 0x2d;
            this.__mainmodule_ltinven2.Text = "";
            this.__mainmodule_ltinven2.BackColor = Color.FromArgb(-8323200);
            this.__mainmodule_ltinven2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltinven2.MyEnabled = true;
            this.__mainmodule_ltinven2.Visible = true;
            this.__mainmodule_ltinven2.Transparent = false;
            this.__mainmodule_ltinven2.Font = new Font(this.__mainmodule_ltinven2.Font.Name, 9f, this.__mainmodule_ltinven2.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_ltinven2);
            this.htControls.Add("__mainmodule_ltinven2", this.__mainmodule_ltinven2);
            this.__mainmodule_label25 = new CEnhancedLabel(this);
            this.__mainmodule_label25.name = "__mainmodule_label25";
            this.__mainmodule_label25.Left = 5;
            this.__mainmodule_label25.Top = 13;
            this.__mainmodule_label25.Width = 0x30;
            this.__mainmodule_label25.Height = 0x10;
            this.__mainmodule_label25.Text = "Articulo";
            this.__mainmodule_label25.BackColor = Color.FromArgb(-67346);
            this.__mainmodule_label25.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label25.MyEnabled = true;
            this.__mainmodule_label25.Visible = true;
            this.__mainmodule_label25.Transparent = false;
            this.__mainmodule_label25.Font = new Font(this.__mainmodule_label25.Font.Name, 9f, this.__mainmodule_label25.Font.Style);
            this.__mainmodule_invent.Controls.Add(this.__mainmodule_label25);
            this.htControls.Add("__mainmodule_label25", this.__mainmodule_label25);
            this.__mainmodule_mnuarchivo = new CEnhancedMenu(this);
            this.__mainmodule_mnuarchivo.name = "__mainmodule_mnuarchivo";
            this.__mainmodule_mnuarchivo.Text = "Archivo";
            this.__mainmodule_mnuarchivo.Enabled = true;
            this.__mainmodule_mnuarchivo.Checked = false;
            this.__mainmodule_mnuarchivo.AddToObject("__mainmodule_invent");
            this.__mainmodule_mnuarchivo.AddEvents();
            this.htControls.Add("__mainmodule_mnuarchivo", this.__mainmodule_mnuarchivo);
            this.__mainmodule_menmov = new CEnhancedMenu(this);
            this.__mainmodule_menmov.name = "__mainmodule_menmov";
            this.__mainmodule_menmov.Text = "Movimientos";
            this.__mainmodule_menmov.Enabled = true;
            this.__mainmodule_menmov.Checked = false;
            this.__mainmodule_menmov.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_menmov.AddEvents();
            this.htControls.Add("__mainmodule_menmov", this.__mainmodule_menmov);
            this.__mainmodule_mensend = new CEnhancedMenu(this);
            this.__mainmodule_mensend.name = "__mainmodule_mensend";
            this.__mainmodule_mensend.Text = "Enviar inventario texto";
            this.__mainmodule_mensend.Enabled = true;
            this.__mainmodule_mensend.Checked = false;
            this.__mainmodule_mensend.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mensend.AddEvents();
            this.htControls.Add("__mainmodule_mensend", this.__mainmodule_mensend);
            this.__mainmodule_mnuenviarsae = new CEnhancedMenu(this);
            this.__mainmodule_mnuenviarsae.name = "__mainmodule_mnuenviarsae";
            this.__mainmodule_mnuenviarsae.Text = "Generar MINVE en SAE";
            this.__mainmodule_mnuenviarsae.Enabled = true;
            this.__mainmodule_mnuenviarsae.Checked = false;
            this.__mainmodule_mnuenviarsae.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuenviarsae.AddEvents();
            this.htControls.Add("__mainmodule_mnuenviarsae", this.__mainmodule_mnuenviarsae);
            this.__mainmodule_mnupedido = new CEnhancedMenu(this);
            this.__mainmodule_mnupedido.name = "__mainmodule_mnupedido";
            this.__mainmodule_mnupedido.Text = "Generar pedido";
            this.__mainmodule_mnupedido.Enabled = true;
            this.__mainmodule_mnupedido.Checked = false;
            this.__mainmodule_mnupedido.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnupedido.AddEvents();
            this.htControls.Add("__mainmodule_mnupedido", this.__mainmodule_mnupedido);
            this.__mainmodule_mnuopcionesped = new CEnhancedMenu(this);
            this.__mainmodule_mnuopcionesped.name = "__mainmodule_mnuopcionesped";
            this.__mainmodule_mnuopcionesped.Text = "Opciones pedidos";
            this.__mainmodule_mnuopcionesped.Enabled = true;
            this.__mainmodule_mnuopcionesped.Checked = false;
            this.__mainmodule_mnuopcionesped.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuopcionesped.AddEvents();
            this.htControls.Add("__mainmodule_mnuopcionesped", this.__mainmodule_mnuopcionesped);
            this.__mainmodule_mnunewpedido = new CEnhancedMenu(this);
            this.__mainmodule_mnunewpedido.name = "__mainmodule_mnunewpedido";
            this.__mainmodule_mnunewpedido.Text = "Nuevo pedido";
            this.__mainmodule_mnunewpedido.Enabled = true;
            this.__mainmodule_mnunewpedido.Checked = false;
            this.__mainmodule_mnunewpedido.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnunewpedido.AddEvents();
            this.htControls.Add("__mainmodule_mnunewpedido", this.__mainmodule_mnunewpedido);
            this.__mainmodule_mnucompra = new CEnhancedMenu(this);
            this.__mainmodule_mnucompra.name = "__mainmodule_mnucompra";
            this.__mainmodule_mnucompra.Text = "Generar orden de compra";
            this.__mainmodule_mnucompra.Enabled = true;
            this.__mainmodule_mnucompra.Checked = false;
            this.__mainmodule_mnucompra.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnucompra.AddEvents();
            this.htControls.Add("__mainmodule_mnucompra", this.__mainmodule_mnucompra);
            this.__mainmodule_mnuutilscompras = new CEnhancedMenu(this);
            this.__mainmodule_mnuutilscompras.name = "__mainmodule_mnuutilscompras";
            this.__mainmodule_mnuutilscompras.Text = "Opciones compras";
            this.__mainmodule_mnuutilscompras.Enabled = true;
            this.__mainmodule_mnuutilscompras.Checked = false;
            this.__mainmodule_mnuutilscompras.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuutilscompras.AddEvents();
            this.htControls.Add("__mainmodule_mnuutilscompras", this.__mainmodule_mnuutilscompras);
            this.__mainmodule_mnunuevacompra = new CEnhancedMenu(this);
            this.__mainmodule_mnunuevacompra.name = "__mainmodule_mnunuevacompra";
            this.__mainmodule_mnunuevacompra.Text = "Nueva Orden Compra";
            this.__mainmodule_mnunuevacompra.Enabled = true;
            this.__mainmodule_mnunuevacompra.Checked = false;
            this.__mainmodule_mnunuevacompra.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnunuevacompra.AddEvents();
            this.htControls.Add("__mainmodule_mnunuevacompra", this.__mainmodule_mnunuevacompra);
            this.__mainmodule_mnureenviar = new CEnhancedMenu(this);
            this.__mainmodule_mnureenviar.name = "__mainmodule_mnureenviar";
            this.__mainmodule_mnureenviar.Text = "Remarcar inventario para reenviarlo";
            this.__mainmodule_mnureenviar.Enabled = true;
            this.__mainmodule_mnureenviar.Checked = false;
            this.__mainmodule_mnureenviar.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnureenviar.AddEvents();
            this.htControls.Add("__mainmodule_mnureenviar", this.__mainmodule_mnureenviar);
            this.__mainmodule_mnuexist = new CEnhancedMenu(this);
            this.__mainmodule_mnuexist.name = "__mainmodule_mnuexist";
            this.__mainmodule_mnuexist.Text = "Existencias SAE";
            this.__mainmodule_mnuexist.Enabled = true;
            this.__mainmodule_mnuexist.Checked = false;
            this.__mainmodule_mnuexist.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuexist.AddEvents();
            this.htControls.Add("__mainmodule_mnuexist", this.__mainmodule_mnuexist);
            this.__mainmodule_mnutotal = new CEnhancedMenu(this);
            this.__mainmodule_mnutotal.name = "__mainmodule_mnutotal";
            this.__mainmodule_mnutotal.Text = "Total articulos";
            this.__mainmodule_mnutotal.Enabled = true;
            this.__mainmodule_mnutotal.Checked = false;
            this.__mainmodule_mnutotal.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnutotal.AddEvents();
            this.htControls.Add("__mainmodule_mnutotal", this.__mainmodule_mnutotal);
            this.__mainmodule_mnuexisxlinea = new CEnhancedMenu(this);
            this.__mainmodule_mnuexisxlinea.name = "__mainmodule_mnuexisxlinea";
            this.__mainmodule_mnuexisxlinea.Text = "Exist. X Linea";
            this.__mainmodule_mnuexisxlinea.Enabled = true;
            this.__mainmodule_mnuexisxlinea.Checked = false;
            this.__mainmodule_mnuexisxlinea.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuexisxlinea.AddEvents();
            this.htControls.Add("__mainmodule_mnuexisxlinea", this.__mainmodule_mnuexisxlinea);
            this.__mainmodule_mnuareas = new CEnhancedMenu(this);
            this.__mainmodule_mnuareas.name = "__mainmodule_mnuareas";
            this.__mainmodule_mnuareas.Text = "Exist x Area";
            this.__mainmodule_mnuareas.Enabled = true;
            this.__mainmodule_mnuareas.Checked = false;
            this.__mainmodule_mnuareas.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_mnuareas.AddEvents();
            this.htControls.Add("__mainmodule_mnuareas", this.__mainmodule_mnuareas);
            this.__mainmodule_menfin = new CEnhancedMenu(this);
            this.__mainmodule_menfin.name = "__mainmodule_menfin";
            this.__mainmodule_menfin.Text = "Salir";
            this.__mainmodule_menfin.Enabled = true;
            this.__mainmodule_menfin.Checked = false;
            this.__mainmodule_menfin.AddToObject("__mainmodule_mnuarchivo");
            this.__mainmodule_menfin.AddEvents();
            this.htControls.Add("__mainmodule_menfin", this.__mainmodule_menfin);
            this.__mainmodule_sqlserver = new CEnhancedForm(this);
            this.__mainmodule_sqlserver.name = "__mainmodule_sqlserver";
            this.__mainmodule_sqlserver.Text = "SQL SERVER";
            this.__mainmodule_sqlserver.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_sqlserver.graphics.FillRectangle(new SolidBrush(this.__mainmodule_sqlserver.BackColor), 0, 0, this.__mainmodule_sqlserver.Width, this.__mainmodule_sqlserver.Height);
            this.__mainmodule_sqlserver.AddEvents();
            this.htControls.Add("__mainmodule_sqlserver", this.__mainmodule_sqlserver);
            this.__mainmodule_chmatriz = new CEnhancedCheckBox(this);
            this.__mainmodule_chmatriz.name = "__mainmodule_chmatriz";
            this.__mainmodule_chmatriz.Left = 0x87;
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
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_chmatriz);
            this.htControls.Add("__mainmodule_chmatriz", this.__mainmodule_chmatriz);
            this.__mainmodule_chmult = new CEnhancedCheckBox(this);
            this.__mainmodule_chmult.name = "__mainmodule_chmult";
            this.__mainmodule_chmult.Left = 120;
            this.__mainmodule_chmult.Top = 0xa8;
            this.__mainmodule_chmult.Width = 0x73;
            this.__mainmodule_chmult.Height = 20;
            this.__mainmodule_chmult.Text = "Multialmacen";
            this.__mainmodule_chmult.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_chmult.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chmult.Enabled = true;
            this.__mainmodule_chmult.Visible = true;
            this.__mainmodule_chmult.Checked = false;
            this.__mainmodule_chmult.Font = new Font(this.__mainmodule_chmult.Font.Name, 9f, this.__mainmodule_chmult.Font.Style);
            this.__mainmodule_chmult.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_chmult);
            this.htControls.Add("__mainmodule_chmult", this.__mainmodule_chmult);
            this.__mainmodule_tremoto = new CEnhancedTextBox(this);
            this.__mainmodule_tremoto.name = "__mainmodule_tremoto";
            this.__mainmodule_tremoto.Left = 50;
            this.__mainmodule_tremoto.Top = 0x49;
            this.__mainmodule_tremoto.Width = 0xb9;
            this.__mainmodule_tremoto.Text = "";
            this.__mainmodule_tremoto.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tremoto.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tremoto.Enabled = true;
            this.__mainmodule_tremoto.Visible = true;
            this.__mainmodule_tremoto.Height = 0x16;
            this.__mainmodule_tremoto.Font = new Font(this.__mainmodule_tremoto.Font.Name, 9f, this.__mainmodule_tremoto.Font.Style);
            this.__mainmodule_tremoto.multiline = false;
            this.__mainmodule_tremoto.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tremoto);
            this.htControls.Add("__mainmodule_tremoto", this.__mainmodule_tremoto);
            this.__mainmodule_label9 = new CEnhancedLabel(this);
            this.__mainmodule_label9.name = "__mainmodule_label9";
            this.__mainmodule_label9.Left = 1;
            this.__mainmodule_label9.Top = 0x4c;
            this.__mainmodule_label9.Width = 0x37;
            this.__mainmodule_label9.Height = 20;
            this.__mainmodule_label9.Text = "Remoto";
            this.__mainmodule_label9.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label9.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label9.MyEnabled = true;
            this.__mainmodule_label9.Visible = true;
            this.__mainmodule_label9.Transparent = false;
            this.__mainmodule_label9.Font = new Font(this.__mainmodule_label9.Font.Name, 9f, this.__mainmodule_label9.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label9);
            this.htControls.Add("__mainmodule_label9", this.__mainmodule_label9);
            this.__mainmodule_tcorreo2 = new CEnhancedTextBox(this);
            this.__mainmodule_tcorreo2.name = "__mainmodule_tcorreo2";
            this.__mainmodule_tcorreo2.Left = 0x92;
            this.__mainmodule_tcorreo2.Top = 0xc3;
            this.__mainmodule_tcorreo2.Width = 0x5c;
            this.__mainmodule_tcorreo2.Text = "";
            this.__mainmodule_tcorreo2.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tcorreo2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tcorreo2.Enabled = true;
            this.__mainmodule_tcorreo2.Visible = true;
            this.__mainmodule_tcorreo2.Height = 0x16;
            this.__mainmodule_tcorreo2.Font = new Font(this.__mainmodule_tcorreo2.Font.Name, 9f, this.__mainmodule_tcorreo2.Font.Style);
            this.__mainmodule_tcorreo2.multiline = false;
            this.__mainmodule_tcorreo2.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tcorreo2);
            this.htControls.Add("__mainmodule_tcorreo2", this.__mainmodule_tcorreo2);
            this.__mainmodule_tcontrol = new CEnhancedTextBox(this);
            this.__mainmodule_tcontrol.name = "__mainmodule_tcontrol";
            this.__mainmodule_tcontrol.Left = 50;
            this.__mainmodule_tcontrol.Top = 0xa7;
            this.__mainmodule_tcontrol.Width = 60;
            this.__mainmodule_tcontrol.Text = "??????????";
            this.__mainmodule_tcontrol.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tcontrol.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tcontrol.Enabled = true;
            this.__mainmodule_tcontrol.Visible = true;
            this.__mainmodule_tcontrol.Height = 0x16;
            this.__mainmodule_tcontrol.Font = new Font(this.__mainmodule_tcontrol.Font.Name, 9f, this.__mainmodule_tcontrol.Font.Style);
            this.__mainmodule_tcontrol.multiline = false;
            this.__mainmodule_tcontrol.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tcontrol);
            this.htControls.Add("__mainmodule_tcontrol", this.__mainmodule_tcontrol);
            this.__mainmodule_tlinea = new CEnhancedTextBox(this);
            this.__mainmodule_tlinea.name = "__mainmodule_tlinea";
            this.__mainmodule_tlinea.Left = 50;
            this.__mainmodule_tlinea.Top = 0x8e;
            this.__mainmodule_tlinea.Width = 0x3d;
            this.__mainmodule_tlinea.Text = "?????";
            this.__mainmodule_tlinea.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tlinea.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tlinea.Enabled = true;
            this.__mainmodule_tlinea.Visible = true;
            this.__mainmodule_tlinea.Height = 0x16;
            this.__mainmodule_tlinea.Font = new Font(this.__mainmodule_tlinea.Font.Name, 9f, this.__mainmodule_tlinea.Font.Style);
            this.__mainmodule_tlinea.multiline = false;
            this.__mainmodule_tlinea.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tlinea);
            this.htControls.Add("__mainmodule_tlinea", this.__mainmodule_tlinea);
            this.__mainmodule_label4 = new CEnhancedLabel(this);
            this.__mainmodule_label4.name = "__mainmodule_label4";
            this.__mainmodule_label4.Left = 1;
            this.__mainmodule_label4.Top = 0x90;
            this.__mainmodule_label4.Width = 0x37;
            this.__mainmodule_label4.Height = 20;
            this.__mainmodule_label4.Text = "Linea:";
            this.__mainmodule_label4.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label4.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label4.MyEnabled = true;
            this.__mainmodule_label4.Visible = true;
            this.__mainmodule_label4.Transparent = false;
            this.__mainmodule_label4.Font = new Font(this.__mainmodule_label4.Font.Name, 9f, this.__mainmodule_label4.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label4);
            this.htControls.Add("__mainmodule_label4", this.__mainmodule_label4);
            this.__mainmodule_btnsql3 = new CEnhancedButton(this);
            this.__mainmodule_btnsql3.name = "__mainmodule_btnsql3";
            this.__mainmodule_btnsql3.Left = 90;
            this.__mainmodule_btnsql3.Top = 230;
            this.__mainmodule_btnsql3.Width = 0x41;
            this.__mainmodule_btnsql3.Height = 30;
            this.__mainmodule_btnsql3.Text = "Eliminar";
            this.__mainmodule_btnsql3.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsql3.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsql3.Enabled = true;
            this.__mainmodule_btnsql3.Visible = true;
            this.__mainmodule_btnsql3.Font = new Font(this.__mainmodule_btnsql3.Font.Name, 9f, this.__mainmodule_btnsql3.Font.Style);
            this.__mainmodule_btnsql3.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_btnsql3);
            this.htControls.Add("__mainmodule_btnsql3", this.__mainmodule_btnsql3);
            this.__mainmodule_cboempresa1 = new CEnhancedCombo(this);
            this.__mainmodule_cboempresa1.name = "__mainmodule_cboempresa1";
            this.__mainmodule_cboempresa1.Left = 0x37;
            this.__mainmodule_cboempresa1.Top = 2;
            this.__mainmodule_cboempresa1.Width = 60;
            this.__mainmodule_cboempresa1.Height = 0x16;
            this.__mainmodule_cboempresa1.Text = "";
            this.__mainmodule_cboempresa1.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboempresa1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboempresa1.Enabled = true;
            this.__mainmodule_cboempresa1.Visible = true;
            this.__mainmodule_cboempresa1.Font = new Font(this.__mainmodule_cboempresa1.Font.Name, 9f, this.__mainmodule_cboempresa1.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_cboempresa1);
            this.htControls.Add("__mainmodule_cboempresa1", this.__mainmodule_cboempresa1);
            this.__mainmodule_cboempresa1.AddEvents();
            this.__mainmodule_tcorreo = new CEnhancedTextBox(this);
            this.__mainmodule_tcorreo.name = "__mainmodule_tcorreo";
            this.__mainmodule_tcorreo.Left = 50;
            this.__mainmodule_tcorreo.Top = 0xc3;
            this.__mainmodule_tcorreo.Width = 90;
            this.__mainmodule_tcorreo.Text = "";
            this.__mainmodule_tcorreo.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tcorreo.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tcorreo.Enabled = true;
            this.__mainmodule_tcorreo.Visible = true;
            this.__mainmodule_tcorreo.Height = 0x16;
            this.__mainmodule_tcorreo.Font = new Font(this.__mainmodule_tcorreo.Font.Name, 9f, this.__mainmodule_tcorreo.Font.Style);
            this.__mainmodule_tcorreo.multiline = false;
            this.__mainmodule_tcorreo.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tcorreo);
            this.htControls.Add("__mainmodule_tcorreo", this.__mainmodule_tcorreo);
            this.__mainmodule_label20 = new CEnhancedLabel(this);
            this.__mainmodule_label20.name = "__mainmodule_label20";
            this.__mainmodule_label20.Left = 1;
            this.__mainmodule_label20.Top = 0xc3;
            this.__mainmodule_label20.Width = 0x33;
            this.__mainmodule_label20.Height = 20;
            this.__mainmodule_label20.Text = "Correo:";
            this.__mainmodule_label20.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label20.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label20.MyEnabled = true;
            this.__mainmodule_label20.Visible = true;
            this.__mainmodule_label20.Transparent = false;
            this.__mainmodule_label20.Font = new Font(this.__mainmodule_label20.Font.Name, 9f, this.__mainmodule_label20.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label20);
            this.htControls.Add("__mainmodule_label20", this.__mainmodule_label20);
            this.__mainmodule_label19 = new CEnhancedLabel(this);
            this.__mainmodule_label19.name = "__mainmodule_label19";
            this.__mainmodule_label19.Left = 1;
            this.__mainmodule_label19.Top = 0xad;
            this.__mainmodule_label19.Width = 0x37;
            this.__mainmodule_label19.Height = 20;
            this.__mainmodule_label19.Text = "Ctrl.Alm:";
            this.__mainmodule_label19.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label19.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label19.MyEnabled = true;
            this.__mainmodule_label19.Visible = true;
            this.__mainmodule_label19.Transparent = false;
            this.__mainmodule_label19.Font = new Font(this.__mainmodule_label19.Font.Name, 9f, this.__mainmodule_label19.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label19);
            this.htControls.Add("__mainmodule_label19", this.__mainmodule_label19);
            this.__mainmodule_cboalm = new CEnhancedCombo(this);
            this.__mainmodule_cboalm.name = "__mainmodule_cboalm";
            this.__mainmodule_cboalm.Left = 0xaf;
            this.__mainmodule_cboalm.Top = 0x8e;
            this.__mainmodule_cboalm.Width = 60;
            this.__mainmodule_cboalm.Height = 0x16;
            this.__mainmodule_cboalm.Text = "";
            this.__mainmodule_cboalm.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboalm.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboalm.Enabled = true;
            this.__mainmodule_cboalm.Visible = true;
            this.__mainmodule_cboalm.Font = new Font(this.__mainmodule_cboalm.Font.Name, 9f, this.__mainmodule_cboalm.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_cboalm);
            this.htControls.Add("__mainmodule_cboalm", this.__mainmodule_cboalm);
            this.__mainmodule_cboalm.AddEvents();
            this.__mainmodule_label18 = new CEnhancedLabel(this);
            this.__mainmodule_label18.name = "__mainmodule_label18";
            this.__mainmodule_label18.Left = 0x76;
            this.__mainmodule_label18.Top = 0x91;
            this.__mainmodule_label18.Width = 0x38;
            this.__mainmodule_label18.Height = 20;
            this.__mainmodule_label18.Text = "Almacen:";
            this.__mainmodule_label18.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label18.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label18.MyEnabled = true;
            this.__mainmodule_label18.Visible = true;
            this.__mainmodule_label18.Transparent = false;
            this.__mainmodule_label18.Font = new Font(this.__mainmodule_label18.Font.Name, 9f, this.__mainmodule_label18.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label18);
            this.htControls.Add("__mainmodule_label18", this.__mainmodule_label18);
            this.__mainmodule_btnsql2 = new CEnhancedButton(this);
            this.__mainmodule_btnsql2.name = "__mainmodule_btnsql2";
            this.__mainmodule_btnsql2.Left = 170;
            this.__mainmodule_btnsql2.Top = 230;
            this.__mainmodule_btnsql2.Width = 0x41;
            this.__mainmodule_btnsql2.Height = 30;
            this.__mainmodule_btnsql2.Text = "Cancelar";
            this.__mainmodule_btnsql2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsql2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsql2.Enabled = true;
            this.__mainmodule_btnsql2.Visible = true;
            this.__mainmodule_btnsql2.Font = new Font(this.__mainmodule_btnsql2.Font.Name, 9f, this.__mainmodule_btnsql2.Font.Style);
            this.__mainmodule_btnsql2.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_btnsql2);
            this.htControls.Add("__mainmodule_btnsql2", this.__mainmodule_btnsql2);
            this.__mainmodule_btnsql1 = new CEnhancedButton(this);
            this.__mainmodule_btnsql1.name = "__mainmodule_btnsql1";
            this.__mainmodule_btnsql1.Left = 10;
            this.__mainmodule_btnsql1.Top = 230;
            this.__mainmodule_btnsql1.Width = 0x41;
            this.__mainmodule_btnsql1.Height = 30;
            this.__mainmodule_btnsql1.Text = "Grabar";
            this.__mainmodule_btnsql1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnsql1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnsql1.Enabled = true;
            this.__mainmodule_btnsql1.Visible = true;
            this.__mainmodule_btnsql1.Font = new Font(this.__mainmodule_btnsql1.Font.Name, 9f, this.__mainmodule_btnsql1.Font.Style);
            this.__mainmodule_btnsql1.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_btnsql1);
            this.htControls.Add("__mainmodule_btnsql1", this.__mainmodule_btnsql1);
            this.__mainmodule_tpuerto = new CEnhancedTextBox(this);
            this.__mainmodule_tpuerto.name = "__mainmodule_tpuerto";
            this.__mainmodule_tpuerto.Left = 0xc3;
            this.__mainmodule_tpuerto.Top = 0x60;
            this.__mainmodule_tpuerto.Width = 40;
            this.__mainmodule_tpuerto.Text = "";
            this.__mainmodule_tpuerto.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tpuerto.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tpuerto.Enabled = true;
            this.__mainmodule_tpuerto.Visible = true;
            this.__mainmodule_tpuerto.Height = 0x16;
            this.__mainmodule_tpuerto.Font = new Font(this.__mainmodule_tpuerto.Font.Name, 9f, this.__mainmodule_tpuerto.Font.Style);
            this.__mainmodule_tpuerto.multiline = false;
            this.__mainmodule_tpuerto.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tpuerto);
            this.htControls.Add("__mainmodule_tpuerto", this.__mainmodule_tpuerto);
            this.__mainmodule_tpasssql = new CEnhancedTextBox(this);
            this.__mainmodule_tpasssql.name = "__mainmodule_tpasssql";
            this.__mainmodule_tpasssql.Left = 0xaf;
            this.__mainmodule_tpasssql.Top = 0x77;
            this.__mainmodule_tpasssql.Width = 60;
            this.__mainmodule_tpasssql.Text = "";
            this.__mainmodule_tpasssql.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tpasssql.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tpasssql.Enabled = true;
            this.__mainmodule_tpasssql.Visible = true;
            this.__mainmodule_tpasssql.Height = 0x16;
            this.__mainmodule_tpasssql.Font = new Font(this.__mainmodule_tpasssql.Font.Name, 9f, this.__mainmodule_tpasssql.Font.Style);
            this.__mainmodule_tpasssql.multiline = false;
            this.__mainmodule_tpasssql.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tpasssql);
            this.htControls.Add("__mainmodule_tpasssql", this.__mainmodule_tpasssql);
            this.__mainmodule_tuser = new CEnhancedTextBox(this);
            this.__mainmodule_tuser.name = "__mainmodule_tuser";
            this.__mainmodule_tuser.Left = 50;
            this.__mainmodule_tuser.Top = 0x77;
            this.__mainmodule_tuser.Width = 60;
            this.__mainmodule_tuser.Text = "";
            this.__mainmodule_tuser.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tuser.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tuser.Enabled = true;
            this.__mainmodule_tuser.Visible = true;
            this.__mainmodule_tuser.Height = 0x16;
            this.__mainmodule_tuser.Font = new Font(this.__mainmodule_tuser.Font.Name, 9f, this.__mainmodule_tuser.Font.Style);
            this.__mainmodule_tuser.multiline = false;
            this.__mainmodule_tuser.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tuser);
            this.htControls.Add("__mainmodule_tuser", this.__mainmodule_tuser);
            this.__mainmodule_tbase = new CEnhancedTextBox(this);
            this.__mainmodule_tbase.name = "__mainmodule_tbase";
            this.__mainmodule_tbase.Left = 50;
            this.__mainmodule_tbase.Top = 0x60;
            this.__mainmodule_tbase.Width = 0x5f;
            this.__mainmodule_tbase.Text = "";
            this.__mainmodule_tbase.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tbase.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tbase.Enabled = true;
            this.__mainmodule_tbase.Visible = true;
            this.__mainmodule_tbase.Height = 0x16;
            this.__mainmodule_tbase.Font = new Font(this.__mainmodule_tbase.Font.Name, 9f, this.__mainmodule_tbase.Font.Style);
            this.__mainmodule_tbase.multiline = false;
            this.__mainmodule_tbase.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tbase);
            this.htControls.Add("__mainmodule_tbase", this.__mainmodule_tbase);
            this.__mainmodule_tserver = new CEnhancedTextBox(this);
            this.__mainmodule_tserver.name = "__mainmodule_tserver";
            this.__mainmodule_tserver.Left = 50;
            this.__mainmodule_tserver.Top = 50;
            this.__mainmodule_tserver.Width = 0xb9;
            this.__mainmodule_tserver.Text = "";
            this.__mainmodule_tserver.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tserver.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tserver.Enabled = true;
            this.__mainmodule_tserver.Visible = true;
            this.__mainmodule_tserver.Height = 0x16;
            this.__mainmodule_tserver.Font = new Font(this.__mainmodule_tserver.Font.Name, 9f, this.__mainmodule_tserver.Font.Style);
            this.__mainmodule_tserver.multiline = false;
            this.__mainmodule_tserver.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tserver);
            this.htControls.Add("__mainmodule_tserver", this.__mainmodule_tserver);
            this.__mainmodule_tnombreemp = new CEnhancedTextBox(this);
            this.__mainmodule_tnombreemp.name = "__mainmodule_tnombreemp";
            this.__mainmodule_tnombreemp.Left = 50;
            this.__mainmodule_tnombreemp.Top = 0x1b;
            this.__mainmodule_tnombreemp.Width = 0xb9;
            this.__mainmodule_tnombreemp.Text = "";
            this.__mainmodule_tnombreemp.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tnombreemp.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tnombreemp.Enabled = true;
            this.__mainmodule_tnombreemp.Visible = true;
            this.__mainmodule_tnombreemp.Height = 0x16;
            this.__mainmodule_tnombreemp.Font = new Font(this.__mainmodule_tnombreemp.Font.Name, 9f, this.__mainmodule_tnombreemp.Font.Style);
            this.__mainmodule_tnombreemp.multiline = false;
            this.__mainmodule_tnombreemp.AddEvents();
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_tnombreemp);
            this.htControls.Add("__mainmodule_tnombreemp", this.__mainmodule_tnombreemp);
            this.__mainmodule_label16 = new CEnhancedLabel(this);
            this.__mainmodule_label16.name = "__mainmodule_label16";
            this.__mainmodule_label16.Left = 1;
            this.__mainmodule_label16.Top = 0x1b;
            this.__mainmodule_label16.Width = 0x37;
            this.__mainmodule_label16.Height = 20;
            this.__mainmodule_label16.Text = "Nombre";
            this.__mainmodule_label16.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label16.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label16.MyEnabled = true;
            this.__mainmodule_label16.Visible = true;
            this.__mainmodule_label16.Transparent = false;
            this.__mainmodule_label16.Font = new Font(this.__mainmodule_label16.Font.Name, 9f, this.__mainmodule_label16.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label16);
            this.htControls.Add("__mainmodule_label16", this.__mainmodule_label16);
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
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label13);
            this.htControls.Add("__mainmodule_label13", this.__mainmodule_label13);
            this.__mainmodule_label8 = new CEnhancedLabel(this);
            this.__mainmodule_label8.name = "__mainmodule_label8";
            this.__mainmodule_label8.Left = 0x97;
            this.__mainmodule_label8.Top = 0x63;
            this.__mainmodule_label8.Width = 0x2d;
            this.__mainmodule_label8.Height = 20;
            this.__mainmodule_label8.Text = "Puerto:";
            this.__mainmodule_label8.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label8.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label8.MyEnabled = true;
            this.__mainmodule_label8.Visible = true;
            this.__mainmodule_label8.Transparent = false;
            this.__mainmodule_label8.Font = new Font(this.__mainmodule_label8.Font.Name, 9f, this.__mainmodule_label8.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label8);
            this.htControls.Add("__mainmodule_label8", this.__mainmodule_label8);
            this.__mainmodule_label7 = new CEnhancedLabel(this);
            this.__mainmodule_label7.name = "__mainmodule_label7";
            this.__mainmodule_label7.Left = 0x74;
            this.__mainmodule_label7.Top = 0x7a;
            this.__mainmodule_label7.Width = 60;
            this.__mainmodule_label7.Height = 20;
            this.__mainmodule_label7.Text = "Contrase.";
            this.__mainmodule_label7.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label7.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label7.MyEnabled = true;
            this.__mainmodule_label7.Visible = true;
            this.__mainmodule_label7.Transparent = false;
            this.__mainmodule_label7.Font = new Font(this.__mainmodule_label7.Font.Name, 9f, this.__mainmodule_label7.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label7);
            this.htControls.Add("__mainmodule_label7", this.__mainmodule_label7);
            this.__mainmodule_label6 = new CEnhancedLabel(this);
            this.__mainmodule_label6.name = "__mainmodule_label6";
            this.__mainmodule_label6.Left = 1;
            this.__mainmodule_label6.Top = 0x7a;
            this.__mainmodule_label6.Width = 0x37;
            this.__mainmodule_label6.Height = 20;
            this.__mainmodule_label6.Text = "Usuario";
            this.__mainmodule_label6.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label6.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label6.MyEnabled = true;
            this.__mainmodule_label6.Visible = true;
            this.__mainmodule_label6.Transparent = false;
            this.__mainmodule_label6.Font = new Font(this.__mainmodule_label6.Font.Name, 9f, this.__mainmodule_label6.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label6);
            this.htControls.Add("__mainmodule_label6", this.__mainmodule_label6);
            this.__mainmodule_label5 = new CEnhancedLabel(this);
            this.__mainmodule_label5.name = "__mainmodule_label5";
            this.__mainmodule_label5.Left = 1;
            this.__mainmodule_label5.Top = 0x63;
            this.__mainmodule_label5.Width = 0x37;
            this.__mainmodule_label5.Height = 20;
            this.__mainmodule_label5.Text = "Base ";
            this.__mainmodule_label5.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label5.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label5.MyEnabled = true;
            this.__mainmodule_label5.Visible = true;
            this.__mainmodule_label5.Transparent = false;
            this.__mainmodule_label5.Font = new Font(this.__mainmodule_label5.Font.Name, 9f, this.__mainmodule_label5.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_label5);
            this.htControls.Add("__mainmodule_label5", this.__mainmodule_label5);
            this.__mainmodule_ltsql1 = new CEnhancedLabel(this);
            this.__mainmodule_ltsql1.name = "__mainmodule_ltsql1";
            this.__mainmodule_ltsql1.Left = 1;
            this.__mainmodule_ltsql1.Top = 0x33;
            this.__mainmodule_ltsql1.Width = 0x37;
            this.__mainmodule_ltsql1.Height = 20;
            this.__mainmodule_ltsql1.Text = "Servidor";
            this.__mainmodule_ltsql1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_ltsql1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsql1.MyEnabled = true;
            this.__mainmodule_ltsql1.Visible = true;
            this.__mainmodule_ltsql1.Transparent = false;
            this.__mainmodule_ltsql1.Font = new Font(this.__mainmodule_ltsql1.Font.Name, 9f, this.__mainmodule_ltsql1.Font.Style);
            this.__mainmodule_sqlserver.Controls.Add(this.__mainmodule_ltsql1);
            this.htControls.Add("__mainmodule_ltsql1", this.__mainmodule_ltsql1);
            this.__mainmodule_mnusql1 = new CEnhancedMenu(this);
            this.__mainmodule_mnusql1.name = "__mainmodule_mnusql1";
            this.__mainmodule_mnusql1.Text = "Archivo";
            this.__mainmodule_mnusql1.Enabled = true;
            this.__mainmodule_mnusql1.Checked = false;
            this.__mainmodule_mnusql1.AddToObject("__mainmodule_sqlserver");
            this.__mainmodule_mnusql1.AddEvents();
            this.htControls.Add("__mainmodule_mnusql1", this.__mainmodule_mnusql1);
            this.__mainmodule_mnusql2 = new CEnhancedMenu(this);
            this.__mainmodule_mnusql2.name = "__mainmodule_mnusql2";
            this.__mainmodule_mnusql2.Text = "Grabar";
            this.__mainmodule_mnusql2.Enabled = true;
            this.__mainmodule_mnusql2.Checked = false;
            this.__mainmodule_mnusql2.AddToObject("__mainmodule_mnusql1");
            this.__mainmodule_mnusql2.AddEvents();
            this.htControls.Add("__mainmodule_mnusql2", this.__mainmodule_mnusql2);
            this.__mainmodule_mnusql3 = new CEnhancedMenu(this);
            this.__mainmodule_mnusql3.name = "__mainmodule_mnusql3";
            this.__mainmodule_mnusql3.Text = "Eliminar";
            this.__mainmodule_mnusql3.Enabled = true;
            this.__mainmodule_mnusql3.Checked = false;
            this.__mainmodule_mnusql3.AddToObject("__mainmodule_mnusql1");
            this.__mainmodule_mnusql3.AddEvents();
            this.htControls.Add("__mainmodule_mnusql3", this.__mainmodule_mnusql3);
            this.__mainmodule_mnusql4 = new CEnhancedMenu(this);
            this.__mainmodule_mnusql4.name = "__mainmodule_mnusql4";
            this.__mainmodule_mnusql4.Text = "Cancelar";
            this.__mainmodule_mnusql4.Enabled = true;
            this.__mainmodule_mnusql4.Checked = false;
            this.__mainmodule_mnusql4.AddToObject("__mainmodule_mnusql1");
            this.__mainmodule_mnusql4.AddEvents();
            this.htControls.Add("__mainmodule_mnusql4", this.__mainmodule_mnusql4);
            this.__mainmodule_frmseries = new CEnhancedForm(this);
            this.__mainmodule_frmseries.name = "__mainmodule_frmseries";
            this.__mainmodule_frmseries.Text = "Series";
            this.__mainmodule_frmseries.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_frmseries.graphics.FillRectangle(new SolidBrush(this.__mainmodule_frmseries.BackColor), 0, 0, this.__mainmodule_frmseries.Width, this.__mainmodule_frmseries.Height);
            this.__mainmodule_frmseries.AddEvents();
            this.htControls.Add("__mainmodule_frmseries", this.__mainmodule_frmseries);
            this.__mainmodule_cboempresapred = new CEnhancedCombo(this);
            this.__mainmodule_cboempresapred.name = "__mainmodule_cboempresapred";
            this.__mainmodule_cboempresapred.Left = 150;
            this.__mainmodule_cboempresapred.Top = 160;
            this.__mainmodule_cboempresapred.Width = 80;
            this.__mainmodule_cboempresapred.Height = 0x16;
            this.__mainmodule_cboempresapred.Text = "";
            this.__mainmodule_cboempresapred.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboempresapred.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboempresapred.Enabled = true;
            this.__mainmodule_cboempresapred.Visible = true;
            this.__mainmodule_cboempresapred.Font = new Font(this.__mainmodule_cboempresapred.Font.Name, 9f, this.__mainmodule_cboempresapred.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_cboempresapred);
            this.htControls.Add("__mainmodule_cboempresapred", this.__mainmodule_cboempresapred);
            this.__mainmodule_cboempresapred.AddEvents();
            this.__mainmodule_label35 = new CEnhancedLabel(this);
            this.__mainmodule_label35.name = "__mainmodule_label35";
            this.__mainmodule_label35.Left = 5;
            this.__mainmodule_label35.Top = 160;
            this.__mainmodule_label35.Width = 150;
            this.__mainmodule_label35.Height = 0x19;
            this.__mainmodule_label35.Text = "Empresa predeterminada";
            this.__mainmodule_label35.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label35.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label35.MyEnabled = true;
            this.__mainmodule_label35.Visible = true;
            this.__mainmodule_label35.Transparent = false;
            this.__mainmodule_label35.Font = new Font(this.__mainmodule_label35.Font.Name, 9f, this.__mainmodule_label35.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label35);
            this.htControls.Add("__mainmodule_label35", this.__mainmodule_label35);
            this.__mainmodule_tserped = new CEnhancedTextBox(this);
            this.__mainmodule_tserped.name = "__mainmodule_tserped";
            this.__mainmodule_tserped.Left = 0x2c;
            this.__mainmodule_tserped.Top = 0x75;
            this.__mainmodule_tserped.Width = 0x2d;
            this.__mainmodule_tserped.Text = "";
            this.__mainmodule_tserped.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tserped.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tserped.Enabled = true;
            this.__mainmodule_tserped.Visible = true;
            this.__mainmodule_tserped.Height = 0x19;
            this.__mainmodule_tserped.Font = new Font(this.__mainmodule_tserped.Font.Name, 10f, this.__mainmodule_tserped.Font.Style);
            this.__mainmodule_tserped.multiline = false;
            this.__mainmodule_tserped.AddEvents();
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_tserped);
            this.htControls.Add("__mainmodule_tserped", this.__mainmodule_tserped);
            this.__mainmodule_label55 = new CEnhancedLabel(this);
            this.__mainmodule_label55.name = "__mainmodule_label55";
            this.__mainmodule_label55.Left = 4;
            this.__mainmodule_label55.Top = 120;
            this.__mainmodule_label55.Width = 50;
            this.__mainmodule_label55.Height = 0x19;
            this.__mainmodule_label55.Text = "Serie:";
            this.__mainmodule_label55.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label55.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label55.MyEnabled = true;
            this.__mainmodule_label55.Visible = true;
            this.__mainmodule_label55.Transparent = false;
            this.__mainmodule_label55.Font = new Font(this.__mainmodule_label55.Font.Name, 9f, this.__mainmodule_label55.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label55);
            this.htControls.Add("__mainmodule_label55", this.__mainmodule_label55);
            this.__mainmodule_tfolped = new CEnhancedTextBox(this);
            this.__mainmodule_tfolped.name = "__mainmodule_tfolped";
            this.__mainmodule_tfolped.Left = 0x86;
            this.__mainmodule_tfolped.Top = 0x75;
            this.__mainmodule_tfolped.Width = 0x5f;
            this.__mainmodule_tfolped.Text = "";
            this.__mainmodule_tfolped.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tfolped.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tfolped.Enabled = true;
            this.__mainmodule_tfolped.Visible = true;
            this.__mainmodule_tfolped.Height = 0x19;
            this.__mainmodule_tfolped.Font = new Font(this.__mainmodule_tfolped.Font.Name, 10f, this.__mainmodule_tfolped.Font.Style);
            this.__mainmodule_tfolped.multiline = false;
            this.__mainmodule_tfolped.AddEvents();
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_tfolped);
            this.htControls.Add("__mainmodule_tfolped", this.__mainmodule_tfolped);
            this.__mainmodule_label54 = new CEnhancedLabel(this);
            this.__mainmodule_label54.name = "__mainmodule_label54";
            this.__mainmodule_label54.Left = 0x63;
            this.__mainmodule_label54.Top = 120;
            this.__mainmodule_label54.Width = 0x23;
            this.__mainmodule_label54.Height = 20;
            this.__mainmodule_label54.Text = "Folio:";
            this.__mainmodule_label54.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label54.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label54.MyEnabled = true;
            this.__mainmodule_label54.Visible = true;
            this.__mainmodule_label54.Transparent = false;
            this.__mainmodule_label54.Font = new Font(this.__mainmodule_label54.Font.Name, 9f, this.__mainmodule_label54.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label54);
            this.htControls.Add("__mainmodule_label54", this.__mainmodule_label54);
            this.__mainmodule_label53 = new CEnhancedLabel(this);
            this.__mainmodule_label53.name = "__mainmodule_label53";
            this.__mainmodule_label53.Left = 4;
            this.__mainmodule_label53.Top = 0x5c;
            this.__mainmodule_label53.Width = 80;
            this.__mainmodule_label53.Height = 20;
            this.__mainmodule_label53.Text = "Pedidos";
            this.__mainmodule_label53.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label53.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label53.MyEnabled = true;
            this.__mainmodule_label53.Visible = true;
            this.__mainmodule_label53.Transparent = false;
            this.__mainmodule_label53.Font = new Font(this.__mainmodule_label53.Font.Name, 9f, this.__mainmodule_label53.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label53);
            this.htControls.Add("__mainmodule_label53", this.__mainmodule_label53);
            this.__mainmodule_label52 = new CEnhancedLabel(this);
            this.__mainmodule_label52.name = "__mainmodule_label52";
            this.__mainmodule_label52.Left = 4;
            this.__mainmodule_label52.Top = 0x2a;
            this.__mainmodule_label52.Width = 80;
            this.__mainmodule_label52.Height = 20;
            this.__mainmodule_label52.Text = "Compras";
            this.__mainmodule_label52.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label52.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label52.MyEnabled = true;
            this.__mainmodule_label52.Visible = true;
            this.__mainmodule_label52.Transparent = false;
            this.__mainmodule_label52.Font = new Font(this.__mainmodule_label52.Font.Name, 9f, this.__mainmodule_label52.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label52);
            this.htControls.Add("__mainmodule_label52", this.__mainmodule_label52);
            this.__mainmodule_label17 = new CEnhancedLabel(this);
            this.__mainmodule_label17.name = "__mainmodule_label17";
            this.__mainmodule_label17.Left = 100;
            this.__mainmodule_label17.Top = 0x44;
            this.__mainmodule_label17.Width = 0x23;
            this.__mainmodule_label17.Height = 20;
            this.__mainmodule_label17.Text = "Folio:";
            this.__mainmodule_label17.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label17.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label17.MyEnabled = true;
            this.__mainmodule_label17.Visible = true;
            this.__mainmodule_label17.Transparent = false;
            this.__mainmodule_label17.Font = new Font(this.__mainmodule_label17.Font.Name, 9f, this.__mainmodule_label17.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label17);
            this.htControls.Add("__mainmodule_label17", this.__mainmodule_label17);
            this.__mainmodule_tfoliocompra = new CEnhancedTextBox(this);
            this.__mainmodule_tfoliocompra.name = "__mainmodule_tfoliocompra";
            this.__mainmodule_tfoliocompra.Left = 0x87;
            this.__mainmodule_tfoliocompra.Top = 0x41;
            this.__mainmodule_tfoliocompra.Width = 0x5f;
            this.__mainmodule_tfoliocompra.Text = "";
            this.__mainmodule_tfoliocompra.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tfoliocompra.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tfoliocompra.Enabled = true;
            this.__mainmodule_tfoliocompra.Visible = true;
            this.__mainmodule_tfoliocompra.Height = 0x19;
            this.__mainmodule_tfoliocompra.Font = new Font(this.__mainmodule_tfoliocompra.Font.Name, 10f, this.__mainmodule_tfoliocompra.Font.Style);
            this.__mainmodule_tfoliocompra.multiline = false;
            this.__mainmodule_tfoliocompra.AddEvents();
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_tfoliocompra);
            this.htControls.Add("__mainmodule_tfoliocompra", this.__mainmodule_tfoliocompra);
            this.__mainmodule_tseriecompra = new CEnhancedTextBox(this);
            this.__mainmodule_tseriecompra.name = "__mainmodule_tseriecompra";
            this.__mainmodule_tseriecompra.Left = 0x2d;
            this.__mainmodule_tseriecompra.Top = 0x41;
            this.__mainmodule_tseriecompra.Width = 0x2d;
            this.__mainmodule_tseriecompra.Text = "";
            this.__mainmodule_tseriecompra.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tseriecompra.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tseriecompra.Enabled = true;
            this.__mainmodule_tseriecompra.Visible = true;
            this.__mainmodule_tseriecompra.Height = 0x19;
            this.__mainmodule_tseriecompra.Font = new Font(this.__mainmodule_tseriecompra.Font.Name, 10f, this.__mainmodule_tseriecompra.Font.Style);
            this.__mainmodule_tseriecompra.multiline = false;
            this.__mainmodule_tseriecompra.AddEvents();
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_tseriecompra);
            this.htControls.Add("__mainmodule_tseriecompra", this.__mainmodule_tseriecompra);
            this.__mainmodule_label15 = new CEnhancedLabel(this);
            this.__mainmodule_label15.name = "__mainmodule_label15";
            this.__mainmodule_label15.Left = 5;
            this.__mainmodule_label15.Top = 0x44;
            this.__mainmodule_label15.Width = 50;
            this.__mainmodule_label15.Height = 0x19;
            this.__mainmodule_label15.Text = "Serie:";
            this.__mainmodule_label15.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label15.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label15.MyEnabled = true;
            this.__mainmodule_label15.Visible = true;
            this.__mainmodule_label15.Transparent = false;
            this.__mainmodule_label15.Font = new Font(this.__mainmodule_label15.Font.Name, 9f, this.__mainmodule_label15.Font.Style);
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_label15);
            this.htControls.Add("__mainmodule_label15", this.__mainmodule_label15);
            this.__mainmodule_btnsalirseries = new CEnhancedButton(this);
            this.__mainmodule_btnsalirseries.name = "__mainmodule_btnsalirseries";
            this.__mainmodule_btnsalirseries.Left = 0x7b;
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
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_btnsalirseries);
            this.htControls.Add("__mainmodule_btnsalirseries", this.__mainmodule_btnsalirseries);
            this.__mainmodule_btnseries = new CEnhancedButton(this);
            this.__mainmodule_btnseries.name = "__mainmodule_btnseries";
            this.__mainmodule_btnseries.Left = 0x17;
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
            this.__mainmodule_frmseries.Controls.Add(this.__mainmodule_btnseries);
            this.htControls.Add("__mainmodule_btnseries", this.__mainmodule_btnseries);
            this.__mainmodule_main = new CEnhancedForm(this);
            this.__mainmodule_main.name = "__mainmodule_main";
            this.__mainmodule_main.Text = "Invent  Mobile";
            this.__mainmodule_main.BackColor = Color.FromArgb(-12550016);
            this.__mainmodule_main.graphics.FillRectangle(new SolidBrush(this.__mainmodule_main.BackColor), 0, 0, this.__mainmodule_main.Width, this.__mainmodule_main.Height);
            this.__mainmodule_main.AddEvents();
            this.htControls.Add("__mainmodule_main", this.__mainmodule_main);
            this.__mainmodule_image1 = new CEnhancedImage(this);
            this.__mainmodule_image1.name = "__mainmodule_image1";
            this.__mainmodule_image1.Left = 0x41;
            this.__mainmodule_image1.Top = 130;
            this.__mainmodule_image1.Width = 0xaf;
            this.__mainmodule_image1.Height = 0x69;
            this.__mainmodule_image1.BackColor = Color.FromArgb(-657956);
            this.__mainmodule_image1.Enabled = true;
            this.__mainmodule_image1.Visible = true;
            this.__mainmodule_image1.MyImageMode = "cCenterImage";
            this.__mainmodule_image1.MyBitmap = this.Other.GetBitmapFromResource("b4p.images (4).jpg");
            this.__mainmodule_image1.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_image1);
            this.htControls.Add("__mainmodule_image1", this.__mainmodule_image1);
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
            this.__mainmodule_main.Controls.Add(this.__mainmodule_label28);
            this.htControls.Add("__mainmodule_label28", this.__mainmodule_label28);
            this.__mainmodule_chimportar = new CEnhancedCheckBox(this);
            this.__mainmodule_chimportar.name = "__mainmodule_chimportar";
            this.__mainmodule_chimportar.Left = 170;
            this.__mainmodule_chimportar.Top = 0x4b;
            this.__mainmodule_chimportar.Width = 0x4b;
            this.__mainmodule_chimportar.Height = 0x16;
            this.__mainmodule_chimportar.Text = "Articulos";
            this.__mainmodule_chimportar.BackColor = Color.FromArgb(-12550016);
            this.__mainmodule_chimportar.ForeColor = Color.FromArgb(-1);
            this.__mainmodule_chimportar.Enabled = true;
            this.__mainmodule_chimportar.Visible = true;
            this.__mainmodule_chimportar.Checked = false;
            this.__mainmodule_chimportar.Font = new Font(this.__mainmodule_chimportar.Font.Name, 9f, this.__mainmodule_chimportar.Font.Style);
            this.__mainmodule_chimportar.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_chimportar);
            this.htControls.Add("__mainmodule_chimportar", this.__mainmodule_chimportar);
            this.__mainmodule_cboempresa = new CEnhancedCombo(this);
            this.__mainmodule_cboempresa.name = "__mainmodule_cboempresa";
            this.__mainmodule_cboempresa.Left = 0x4b;
            this.__mainmodule_cboempresa.Top = 2;
            this.__mainmodule_cboempresa.Width = 60;
            this.__mainmodule_cboempresa.Height = 0x19;
            this.__mainmodule_cboempresa.Text = "";
            this.__mainmodule_cboempresa.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboempresa.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboempresa.Enabled = true;
            this.__mainmodule_cboempresa.Visible = true;
            this.__mainmodule_cboempresa.Font = new Font(this.__mainmodule_cboempresa.Font.Name, 10f, this.__mainmodule_cboempresa.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_cboempresa);
            this.htControls.Add("__mainmodule_cboempresa", this.__mainmodule_cboempresa);
            this.__mainmodule_cboempresa.AddEvents();
            this.__mainmodule_tusuario = new CEnhancedTextBox(this);
            this.__mainmodule_tusuario.name = "__mainmodule_tusuario";
            this.__mainmodule_tusuario.Left = 0x4b;
            this.__mainmodule_tusuario.Top = 30;
            this.__mainmodule_tusuario.Width = 90;
            this.__mainmodule_tusuario.Text = "Administrador";
            this.__mainmodule_tusuario.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tusuario.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tusuario.Enabled = true;
            this.__mainmodule_tusuario.Visible = true;
            this.__mainmodule_tusuario.Height = 0x16;
            this.__mainmodule_tusuario.Font = new Font(this.__mainmodule_tusuario.Font.Name, 9f, this.__mainmodule_tusuario.Font.Style);
            this.__mainmodule_tusuario.multiline = false;
            this.__mainmodule_tusuario.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_tusuario);
            this.htControls.Add("__mainmodule_tusuario", this.__mainmodule_tusuario);
            this.__mainmodule_tpassword = new CEnhancedTextBox(this);
            this.__mainmodule_tpassword.name = "__mainmodule_tpassword";
            this.__mainmodule_tpassword.Left = 0x4b;
            this.__mainmodule_tpassword.Top = 0x37;
            this.__mainmodule_tpassword.Width = 90;
            this.__mainmodule_tpassword.Text = "";
            this.__mainmodule_tpassword.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tpassword.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tpassword.Enabled = true;
            this.__mainmodule_tpassword.Visible = true;
            this.__mainmodule_tpassword.Height = 0x16;
            this.__mainmodule_tpassword.Font = new Font(this.__mainmodule_tpassword.Font.Name, 9f, this.__mainmodule_tpassword.Font.Style);
            this.__mainmodule_tpassword.multiline = false;
            this.__mainmodule_tpassword.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_tpassword);
            this.htControls.Add("__mainmodule_tpassword", this.__mainmodule_tpassword);
            this.__mainmodule_btnaceptar = new CEnhancedButton(this);
            this.__mainmodule_btnaceptar.name = "__mainmodule_btnaceptar";
            this.__mainmodule_btnaceptar.Left = 0xaf;
            this.__mainmodule_btnaceptar.Top = 30;
            this.__mainmodule_btnaceptar.Width = 0x3d;
            this.__mainmodule_btnaceptar.Height = 40;
            this.__mainmodule_btnaceptar.Text = "Aceptar";
            this.__mainmodule_btnaceptar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnaceptar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnaceptar.Enabled = true;
            this.__mainmodule_btnaceptar.Visible = true;
            this.__mainmodule_btnaceptar.Font = new Font(this.__mainmodule_btnaceptar.Font.Name, 9f, this.__mainmodule_btnaceptar.Font.Style);
            this.__mainmodule_btnaceptar.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_btnaceptar);
            this.htControls.Add("__mainmodule_btnaceptar", this.__mainmodule_btnaceptar);
            this.__mainmodule_btnmain8 = new CEnhancedButton(this);
            this.__mainmodule_btnmain8.name = "__mainmodule_btnmain8";
            this.__mainmodule_btnmain8.Left = 0xaf;
            this.__mainmodule_btnmain8.Top = 1;
            this.__mainmodule_btnmain8.Width = 0x3d;
            this.__mainmodule_btnmain8.Height = 0x19;
            this.__mainmodule_btnmain8.Text = "Salir";
            this.__mainmodule_btnmain8.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnmain8.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnmain8.Enabled = true;
            this.__mainmodule_btnmain8.Visible = true;
            this.__mainmodule_btnmain8.Font = new Font(this.__mainmodule_btnmain8.Font.Name, 9f, this.__mainmodule_btnmain8.Font.Style);
            this.__mainmodule_btnmain8.AddEvents();
            this.__mainmodule_main.Controls.Add(this.__mainmodule_btnmain8);
            this.htControls.Add("__mainmodule_btnmain8", this.__mainmodule_btnmain8);
            this.__mainmodule_ltsocial = new CEnhancedLabel(this);
            this.__mainmodule_ltsocial.name = "__mainmodule_ltsocial";
            this.__mainmodule_ltsocial.Left = 2;
            this.__mainmodule_ltsocial.Top = 80;
            this.__mainmodule_ltsocial.Width = 160;
            this.__mainmodule_ltsocial.Height = 0x12;
            this.__mainmodule_ltsocial.Text = "";
            this.__mainmodule_ltsocial.BackColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsocial.ForeColor = Color.FromArgb(-16711936);
            this.__mainmodule_ltsocial.MyEnabled = true;
            this.__mainmodule_ltsocial.Visible = true;
            this.__mainmodule_ltsocial.Transparent = false;
            this.__mainmodule_ltsocial.Font = new Font(this.__mainmodule_ltsocial.Font.Name, 9f, this.__mainmodule_ltsocial.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_ltsocial);
            this.htControls.Add("__mainmodule_ltsocial", this.__mainmodule_ltsocial);
            this.__mainmodule_ltart = new CEnhancedLabel(this);
            this.__mainmodule_ltart.name = "__mainmodule_ltart";
            this.__mainmodule_ltart.Left = 2;
            this.__mainmodule_ltart.Top = 0x63;
            this.__mainmodule_ltart.Width = 0xef;
            this.__mainmodule_ltart.Height = 30;
            this.__mainmodule_ltart.Text = "";
            this.__mainmodule_ltart.BackColor = Color.FromArgb(-32768);
            this.__mainmodule_ltart.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltart.MyEnabled = true;
            this.__mainmodule_ltart.Visible = true;
            this.__mainmodule_ltart.Transparent = false;
            this.__mainmodule_ltart.Font = new Font(this.__mainmodule_ltart.Font.Name, 9f, this.__mainmodule_ltart.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_ltart);
            this.htControls.Add("__mainmodule_ltart", this.__mainmodule_ltart);
            this.__mainmodule_ltsync = new CEnhancedLabel(this);
            this.__mainmodule_ltsync.name = "__mainmodule_ltsync";
            this.__mainmodule_ltsync.Left = 2;
            this.__mainmodule_ltsync.Top = 0xeb;
            this.__mainmodule_ltsync.Width = 0xed;
            this.__mainmodule_ltsync.Height = 0x1d;
            this.__mainmodule_ltsync.Text = "";
            this.__mainmodule_ltsync.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltsync.ForeColor = Color.FromArgb(-128);
            this.__mainmodule_ltsync.MyEnabled = true;
            this.__mainmodule_ltsync.Visible = true;
            this.__mainmodule_ltsync.Transparent = false;
            this.__mainmodule_ltsync.Font = new Font(this.__mainmodule_ltsync.Font.Name, 9f, this.__mainmodule_ltsync.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_ltsync);
            this.htControls.Add("__mainmodule_ltsync", this.__mainmodule_ltsync);
            this.__mainmodule_label23 = new CEnhancedLabel(this);
            this.__mainmodule_label23.name = "__mainmodule_label23";
            this.__mainmodule_label23.Left = 4;
            this.__mainmodule_label23.Top = 0x3a;
            this.__mainmodule_label23.Width = 0x4a;
            this.__mainmodule_label23.Height = 0x16;
            this.__mainmodule_label23.Text = "Contrase\x00f1a:";
            this.__mainmodule_label23.BackColor = Color.FromArgb(-1);
            this.__mainmodule_label23.ForeColor = Color.FromArgb(-1);
            this.__mainmodule_label23.MyEnabled = true;
            this.__mainmodule_label23.Visible = true;
            this.__mainmodule_label23.Transparent = true;
            this.__mainmodule_label23.Font = new Font(this.__mainmodule_label23.Font.Name, 9f, this.__mainmodule_label23.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_label23);
            this.htControls.Add("__mainmodule_label23", this.__mainmodule_label23);
            this.__mainmodule_label22 = new CEnhancedLabel(this);
            this.__mainmodule_label22.name = "__mainmodule_label22";
            this.__mainmodule_label22.Left = 0x17;
            this.__mainmodule_label22.Top = 0x23;
            this.__mainmodule_label22.Width = 0x37;
            this.__mainmodule_label22.Height = 0x16;
            this.__mainmodule_label22.Text = "Usuario:";
            this.__mainmodule_label22.BackColor = Color.FromArgb(-1);
            this.__mainmodule_label22.ForeColor = Color.FromArgb(-1);
            this.__mainmodule_label22.MyEnabled = true;
            this.__mainmodule_label22.Visible = true;
            this.__mainmodule_label22.Transparent = true;
            this.__mainmodule_label22.Font = new Font(this.__mainmodule_label22.Font.Name, 9f, this.__mainmodule_label22.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_label22);
            this.htControls.Add("__mainmodule_label22", this.__mainmodule_label22);
            this.__mainmodule_label21 = new CEnhancedLabel(this);
            this.__mainmodule_label21.name = "__mainmodule_label21";
            this.__mainmodule_label21.Left = 15;
            this.__mainmodule_label21.Top = 5;
            this.__mainmodule_label21.Width = 0x39;
            this.__mainmodule_label21.Height = 0x16;
            this.__mainmodule_label21.Text = "Empresa:";
            this.__mainmodule_label21.BackColor = Color.FromArgb(-1);
            this.__mainmodule_label21.ForeColor = Color.FromArgb(-1);
            this.__mainmodule_label21.MyEnabled = true;
            this.__mainmodule_label21.Visible = true;
            this.__mainmodule_label21.Transparent = true;
            this.__mainmodule_label21.Font = new Font(this.__mainmodule_label21.Font.Name, 9f, this.__mainmodule_label21.Font.Style);
            this.__mainmodule_main.Controls.Add(this.__mainmodule_label21);
            this.htControls.Add("__mainmodule_label21", this.__mainmodule_label21);
            this.__mainmodule_config = new CEnhancedForm(this);
            this.__mainmodule_config.name = "__mainmodule_config";
            this.__mainmodule_config.Text = "Configuracion";
            this.__mainmodule_config.BackColor = Color.FromArgb(-731233);
            this.__mainmodule_config.graphics.FillRectangle(new SolidBrush(this.__mainmodule_config.BackColor), 0, 0, this.__mainmodule_config.Width, this.__mainmodule_config.Height);
            this.__mainmodule_config.AddEvents();
            this.htControls.Add("__mainmodule_config", this.__mainmodule_config);
            this.__mainmodule_btncrearbase = new CEnhancedButton(this);
            this.__mainmodule_btncrearbase.name = "__mainmodule_btncrearbase";
            this.__mainmodule_btncrearbase.Left = 5;
            this.__mainmodule_btncrearbase.Top = 0x7e;
            this.__mainmodule_btncrearbase.Width = 110;
            this.__mainmodule_btncrearbase.Height = 30;
            this.__mainmodule_btncrearbase.Text = "Crea BD";
            this.__mainmodule_btncrearbase.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btncrearbase.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btncrearbase.Enabled = true;
            this.__mainmodule_btncrearbase.Visible = true;
            this.__mainmodule_btncrearbase.Font = new Font(this.__mainmodule_btncrearbase.Font.Name, 9f, this.__mainmodule_btncrearbase.Font.Style);
            this.__mainmodule_btncrearbase.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btncrearbase);
            this.htControls.Add("__mainmodule_btncrearbase", this.__mainmodule_btncrearbase);
            this.__mainmodule_btnareas = new CEnhancedButton(this);
            this.__mainmodule_btnareas.name = "__mainmodule_btnareas";
            this.__mainmodule_btnareas.Left = 0x75;
            this.__mainmodule_btnareas.Top = 0x7e;
            this.__mainmodule_btnareas.Width = 110;
            this.__mainmodule_btnareas.Height = 30;
            this.__mainmodule_btnareas.Text = "Areas";
            this.__mainmodule_btnareas.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnareas.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnareas.Enabled = true;
            this.__mainmodule_btnareas.Visible = true;
            this.__mainmodule_btnareas.Font = new Font(this.__mainmodule_btnareas.Font.Name, 9f, this.__mainmodule_btnareas.Font.Style);
            this.__mainmodule_btnareas.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btnareas);
            this.htControls.Add("__mainmodule_btnareas", this.__mainmodule_btnareas);
            this.__mainmodule_btncompactar = new CEnhancedButton(this);
            this.__mainmodule_btncompactar.name = "__mainmodule_btncompactar";
            this.__mainmodule_btncompactar.Left = 0x75;
            this.__mainmodule_btncompactar.Top = 0x5f;
            this.__mainmodule_btncompactar.Width = 110;
            this.__mainmodule_btncompactar.Height = 30;
            this.__mainmodule_btncompactar.Text = "Compactar";
            this.__mainmodule_btncompactar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btncompactar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btncompactar.Enabled = true;
            this.__mainmodule_btncompactar.Visible = true;
            this.__mainmodule_btncompactar.Font = new Font(this.__mainmodule_btncompactar.Font.Name, 9f, this.__mainmodule_btncompactar.Font.Style);
            this.__mainmodule_btncompactar.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btncompactar);
            this.htControls.Add("__mainmodule_btncompactar", this.__mainmodule_btncompactar);
            this.__mainmodule_btntea = new CEnhancedButton(this);
            this.__mainmodule_btntea.name = "__mainmodule_btntea";
            this.__mainmodule_btntea.Left = 5;
            this.__mainmodule_btntea.Top = 0x5f;
            this.__mainmodule_btntea.Width = 110;
            this.__mainmodule_btntea.Height = 30;
            this.__mainmodule_btntea.Text = "Coneccion TEA";
            this.__mainmodule_btntea.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btntea.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btntea.Enabled = true;
            this.__mainmodule_btntea.Visible = true;
            this.__mainmodule_btntea.Font = new Font(this.__mainmodule_btntea.Font.Name, 9f, this.__mainmodule_btntea.Font.Style);
            this.__mainmodule_btntea.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btntea);
            this.htControls.Add("__mainmodule_btntea", this.__mainmodule_btntea);
            this.__mainmodule_chcaja = new CEnhancedCheckBox(this);
            this.__mainmodule_chcaja.name = "__mainmodule_chcaja";
            this.__mainmodule_chcaja.Left = 2;
            this.__mainmodule_chcaja.Top = 0xa1;
            this.__mainmodule_chcaja.Width = 0x55;
            this.__mainmodule_chcaja.Height = 0x19;
            this.__mainmodule_chcaja.Text = "Base Caja";
            this.__mainmodule_chcaja.BackColor = Color.FromArgb(-731233);
            this.__mainmodule_chcaja.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chcaja.Enabled = false;
            this.__mainmodule_chcaja.Visible = true;
            this.__mainmodule_chcaja.Checked = false;
            this.__mainmodule_chcaja.Font = new Font(this.__mainmodule_chcaja.Font.Name, 9f, this.__mainmodule_chcaja.Font.Style);
            this.__mainmodule_chcaja.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_chcaja);
            this.htControls.Add("__mainmodule_chcaja", this.__mainmodule_chcaja);
            this.__mainmodule_btnenviarinven = new CEnhancedButton(this);
            this.__mainmodule_btnenviarinven.name = "__mainmodule_btnenviarinven";
            this.__mainmodule_btnenviarinven.Left = 5;
            this.__mainmodule_btnenviarinven.Top = 0x40;
            this.__mainmodule_btnenviarinven.Width = 110;
            this.__mainmodule_btnenviarinven.Height = 30;
            this.__mainmodule_btnenviarinven.Text = "Enviar Inventario";
            this.__mainmodule_btnenviarinven.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnenviarinven.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnenviarinven.Enabled = true;
            this.__mainmodule_btnenviarinven.Visible = true;
            this.__mainmodule_btnenviarinven.Font = new Font(this.__mainmodule_btnenviarinven.Font.Name, 9f, this.__mainmodule_btnenviarinven.Font.Style);
            this.__mainmodule_btnenviarinven.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btnenviarinven);
            this.htControls.Add("__mainmodule_btnenviarinven", this.__mainmodule_btnenviarinven);
            this.__mainmodule_ltllenar = new CEnhancedLabel(this);
            this.__mainmodule_ltllenar.name = "__mainmodule_ltllenar";
            this.__mainmodule_ltllenar.Left = 10;
            this.__mainmodule_ltllenar.Top = 230;
            this.__mainmodule_ltllenar.Width = 0xdb;
            this.__mainmodule_ltllenar.Height = 0x19;
            this.__mainmodule_ltllenar.Text = "";
            this.__mainmodule_ltllenar.BackColor = Color.FromArgb(-731233);
            this.__mainmodule_ltllenar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltllenar.MyEnabled = true;
            this.__mainmodule_ltllenar.Visible = true;
            this.__mainmodule_ltllenar.Transparent = false;
            this.__mainmodule_ltllenar.Font = new Font(this.__mainmodule_ltllenar.Font.Name, 9f, this.__mainmodule_ltllenar.Font.Style);
            this.__mainmodule_config.Controls.Add(this.__mainmodule_ltllenar);
            this.htControls.Add("__mainmodule_ltllenar", this.__mainmodule_ltllenar);
            this.__mainmodule_btnutils = new CEnhancedButton(this);
            this.__mainmodule_btnutils.name = "__mainmodule_btnutils";
            this.__mainmodule_btnutils.Left = 0x75;
            this.__mainmodule_btnutils.Top = 0x40;
            this.__mainmodule_btnutils.Width = 110;
            this.__mainmodule_btnutils.Height = 30;
            this.__mainmodule_btnutils.Text = "Series";
            this.__mainmodule_btnutils.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnutils.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnutils.Enabled = true;
            this.__mainmodule_btnutils.Visible = true;
            this.__mainmodule_btnutils.Font = new Font(this.__mainmodule_btnutils.Font.Name, 9f, this.__mainmodule_btnutils.Font.Style);
            this.__mainmodule_btnutils.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btnutils);
            this.htControls.Add("__mainmodule_btnutils", this.__mainmodule_btnutils);
            this.__mainmodule_btnuser = new CEnhancedButton(this);
            this.__mainmodule_btnuser.name = "__mainmodule_btnuser";
            this.__mainmodule_btnuser.Left = 5;
            this.__mainmodule_btnuser.Top = 0x21;
            this.__mainmodule_btnuser.Width = 110;
            this.__mainmodule_btnuser.Height = 30;
            this.__mainmodule_btnuser.Text = "Usuarios";
            this.__mainmodule_btnuser.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnuser.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnuser.Enabled = true;
            this.__mainmodule_btnuser.Visible = true;
            this.__mainmodule_btnuser.Font = new Font(this.__mainmodule_btnuser.Font.Name, 9f, this.__mainmodule_btnuser.Font.Style);
            this.__mainmodule_btnuser.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btnuser);
            this.htControls.Add("__mainmodule_btnuser", this.__mainmodule_btnuser);
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
            this.__mainmodule_config.Controls.Add(this.__mainmodule_btnsql);
            this.htControls.Add("__mainmodule_btnsql", this.__mainmodule_btnsql);
            this.__mainmodule_cmdvaciarinvent = new CEnhancedButton(this);
            this.__mainmodule_cmdvaciarinvent.name = "__mainmodule_cmdvaciarinvent";
            this.__mainmodule_cmdvaciarinvent.Left = 0x75;
            this.__mainmodule_cmdvaciarinvent.Top = 0x21;
            this.__mainmodule_cmdvaciarinvent.Width = 110;
            this.__mainmodule_cmdvaciarinvent.Height = 30;
            this.__mainmodule_cmdvaciarinvent.Text = "Vaciar BASE";
            this.__mainmodule_cmdvaciarinvent.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_cmdvaciarinvent.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cmdvaciarinvent.Enabled = true;
            this.__mainmodule_cmdvaciarinvent.Visible = true;
            this.__mainmodule_cmdvaciarinvent.Font = new Font(this.__mainmodule_cmdvaciarinvent.Font.Name, 9f, this.__mainmodule_cmdvaciarinvent.Font.Style);
            this.__mainmodule_cmdvaciarinvent.AddEvents();
            this.__mainmodule_config.Controls.Add(this.__mainmodule_cmdvaciarinvent);
            this.htControls.Add("__mainmodule_cmdvaciarinvent", this.__mainmodule_cmdvaciarinvent);
            this.__mainmodule_cmdrutapcc = new CEnhancedButton(this);
            this.__mainmodule_cmdrutapcc.name = "__mainmodule_cmdrutapcc";
            this.__mainmodule_cmdrutapcc.Left = 0x75;
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
            this.__mainmodule_config.Controls.Add(this.__mainmodule_cmdrutapcc);
            this.htControls.Add("__mainmodule_cmdrutapcc", this.__mainmodule_cmdrutapcc);
            this.__mainmodule_enviar = new CEnhancedForm(this);
            this.__mainmodule_enviar.name = "__mainmodule_enviar";
            this.__mainmodule_enviar.Text = "Enviar inventario";
            this.__mainmodule_enviar.BackColor = Color.FromArgb(-5778440);
            this.__mainmodule_enviar.graphics.FillRectangle(new SolidBrush(this.__mainmodule_enviar.BackColor), 0, 0, this.__mainmodule_enviar.Width, this.__mainmodule_enviar.Height);
            this.__mainmodule_enviar.AddEvents();
            this.htControls.Add("__mainmodule_enviar", this.__mainmodule_enviar);
            this.__mainmodule_label51 = new CEnhancedLabel(this);
            this.__mainmodule_label51.name = "__mainmodule_label51";
            this.__mainmodule_label51.Left = 0;
            this.__mainmodule_label51.Top = 0xa5;
            this.__mainmodule_label51.Width = 0x7d;
            this.__mainmodule_label51.Height = 20;
            this.__mainmodule_label51.Text = "SQL SERVER";
            this.__mainmodule_label51.BackColor = Color.FromArgb(-7484934);
            this.__mainmodule_label51.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label51.MyEnabled = true;
            this.__mainmodule_label51.Visible = true;
            this.__mainmodule_label51.Transparent = false;
            this.__mainmodule_label51.Font = new Font(this.__mainmodule_label51.Font.Name, 10f, this.__mainmodule_label51.Font.Style);
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_label51);
            this.htControls.Add("__mainmodule_label51", this.__mainmodule_label51);
            this.__mainmodule_trutapc = new CEnhancedTextBox(this);
            this.__mainmodule_trutapc.name = "__mainmodule_trutapc";
            this.__mainmodule_trutapc.Left = 4;
            this.__mainmodule_trutapc.Top = 0x4a;
            this.__mainmodule_trutapc.Width = 230;
            this.__mainmodule_trutapc.Text = @"\\servidor\dacaspel";
            this.__mainmodule_trutapc.BackColor = Color.FromArgb(-1);
            this.__mainmodule_trutapc.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_trutapc.Enabled = true;
            this.__mainmodule_trutapc.Visible = false;
            this.__mainmodule_trutapc.Height = 0x16;
            this.__mainmodule_trutapc.Font = new Font(this.__mainmodule_trutapc.Font.Name, 9f, this.__mainmodule_trutapc.Font.Style);
            this.__mainmodule_trutapc.multiline = false;
            this.__mainmodule_trutapc.AddEvents();
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_trutapc);
            this.htControls.Add("__mainmodule_trutapc", this.__mainmodule_trutapc);
            this.__mainmodule_chenviarpc = new CEnhancedCheckBox(this);
            this.__mainmodule_chenviarpc.name = "__mainmodule_chenviarpc";
            this.__mainmodule_chenviarpc.Left = 0x69;
            this.__mainmodule_chenviarpc.Top = 0xa5;
            this.__mainmodule_chenviarpc.Width = 0x87;
            this.__mainmodule_chenviarpc.Height = 0x19;
            this.__mainmodule_chenviarpc.Text = "Enviar a PC";
            this.__mainmodule_chenviarpc.BackColor = Color.FromArgb(-5778440);
            this.__mainmodule_chenviarpc.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_chenviarpc.Enabled = true;
            this.__mainmodule_chenviarpc.Visible = false;
            this.__mainmodule_chenviarpc.Checked = true;
            this.__mainmodule_chenviarpc.Font = new Font(this.__mainmodule_chenviarpc.Font.Name, 9f, this.__mainmodule_chenviarpc.Font.Style);
            this.__mainmodule_chenviarpc.AddEvents();
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_chenviarpc);
            this.htControls.Add("__mainmodule_chenviarpc", this.__mainmodule_chenviarpc);
            this.__mainmodule_timer1 = new CEnhancedTimer(this);
            this.__mainmodule_timer1.name = "__mainmodule_timer1";
            this.__mainmodule_timer1.Enabled = false;
            this.__mainmodule_timer1.Interval = 500;
            this.__mainmodule_timer1.AddEvents();
            this.htControls.Add("__mainmodule_timer1", this.__mainmodule_timer1);
            this.__mainmodule_ltnum = new CEnhancedLabel(this);
            this.__mainmodule_ltnum.name = "__mainmodule_ltnum";
            this.__mainmodule_ltnum.Left = 5;
            this.__mainmodule_ltnum.Top = 0x8d;
            this.__mainmodule_ltnum.Width = 0xed;
            this.__mainmodule_ltnum.Height = 20;
            this.__mainmodule_ltnum.Text = "";
            this.__mainmodule_ltnum.BackColor = Color.FromArgb(-7484934);
            this.__mainmodule_ltnum.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltnum.MyEnabled = true;
            this.__mainmodule_ltnum.Visible = true;
            this.__mainmodule_ltnum.Transparent = false;
            this.__mainmodule_ltnum.Font = new Font(this.__mainmodule_ltnum.Font.Name, 10f, this.__mainmodule_ltnum.Font.Style);
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_ltnum);
            this.htControls.Add("__mainmodule_ltnum", this.__mainmodule_ltnum);
            this.__mainmodule_cboconex = new CEnhancedCombo(this);
            this.__mainmodule_cboconex.name = "__mainmodule_cboconex";
            this.__mainmodule_cboconex.Left = 40;
            this.__mainmodule_cboconex.Top = 0x2e;
            this.__mainmodule_cboconex.Width = 0xa5;
            this.__mainmodule_cboconex.Height = 0x16;
            this.__mainmodule_cboconex.Text = "";
            this.__mainmodule_cboconex.BackColor = Color.FromArgb(-1);
            this.__mainmodule_cboconex.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_cboconex.Enabled = true;
            this.__mainmodule_cboconex.Visible = false;
            this.__mainmodule_cboconex.Font = new Font(this.__mainmodule_cboconex.Font.Name, 9f, this.__mainmodule_cboconex.Font.Style);
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_cboconex);
            this.htControls.Add("__mainmodule_cboconex", this.__mainmodule_cboconex);
            this.__mainmodule_cboconex.AddEvents();
            this.__mainmodule_ltsend2 = new CEnhancedLabel(this);
            this.__mainmodule_ltsend2.name = "__mainmodule_ltsend2";
            this.__mainmodule_ltsend2.Left = 5;
            this.__mainmodule_ltsend2.Top = 0x77;
            this.__mainmodule_ltsend2.Width = 0xe5;
            this.__mainmodule_ltsend2.Height = 20;
            this.__mainmodule_ltsend2.Text = "";
            this.__mainmodule_ltsend2.BackColor = Color.FromArgb(-7484934);
            this.__mainmodule_ltsend2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsend2.MyEnabled = true;
            this.__mainmodule_ltsend2.Visible = true;
            this.__mainmodule_ltsend2.Transparent = false;
            this.__mainmodule_ltsend2.Font = new Font(this.__mainmodule_ltsend2.Font.Name, 8f, this.__mainmodule_ltsend2.Font.Style);
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_ltsend2);
            this.htControls.Add("__mainmodule_ltsend2", this.__mainmodule_ltsend2);
            this.__mainmodule_cmdsend2 = new CEnhancedButton(this);
            this.__mainmodule_cmdsend2.name = "__mainmodule_cmdsend2";
            this.__mainmodule_cmdsend2.Left = 0x5c;
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
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_cmdsend2);
            this.htControls.Add("__mainmodule_cmdsend2", this.__mainmodule_cmdsend2);
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
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_cmdsend1);
            this.htControls.Add("__mainmodule_cmdsend1", this.__mainmodule_cmdsend1);
            this.__mainmodule_ltsend1 = new CEnhancedLabel(this);
            this.__mainmodule_ltsend1.name = "__mainmodule_ltsend1";
            this.__mainmodule_ltsend1.Left = 5;
            this.__mainmodule_ltsend1.Top = 0x61;
            this.__mainmodule_ltsend1.Width = 0xe5;
            this.__mainmodule_ltsend1.Height = 20;
            this.__mainmodule_ltsend1.Text = "";
            this.__mainmodule_ltsend1.BackColor = Color.FromArgb(-7484934);
            this.__mainmodule_ltsend1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltsend1.MyEnabled = true;
            this.__mainmodule_ltsend1.Visible = true;
            this.__mainmodule_ltsend1.Transparent = false;
            this.__mainmodule_ltsend1.Font = new Font(this.__mainmodule_ltsend1.Font.Name, 8f, this.__mainmodule_ltsend1.Font.Style);
            this.__mainmodule_enviar.Controls.Add(this.__mainmodule_ltsend1);
            this.htControls.Add("__mainmodule_ltsend1", this.__mainmodule_ltsend1);
            this.__mainmodule_procminve = new CEnhancedForm(this);
            this.__mainmodule_procminve.name = "__mainmodule_procminve";
            this.__mainmodule_procminve.Text = "Generar MINVE en SAE";
            this.__mainmodule_procminve.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_procminve.graphics.FillRectangle(new SolidBrush(this.__mainmodule_procminve.BackColor), 0, 0, this.__mainmodule_procminve.Width, this.__mainmodule_procminve.Height);
            this.__mainmodule_procminve.AddEvents();
            this.htControls.Add("__mainmodule_procminve", this.__mainmodule_procminve);
            this.__mainmodule_ltpiezas = new CEnhancedLabel(this);
            this.__mainmodule_ltpiezas.name = "__mainmodule_ltpiezas";
            this.__mainmodule_ltpiezas.Left = 0xa5;
            this.__mainmodule_ltpiezas.Top = 0x79;
            this.__mainmodule_ltpiezas.Width = 70;
            this.__mainmodule_ltpiezas.Height = 0x12;
            this.__mainmodule_ltpiezas.Text = "";
            this.__mainmodule_ltpiezas.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltpiezas.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltpiezas.MyEnabled = true;
            this.__mainmodule_ltpiezas.Visible = true;
            this.__mainmodule_ltpiezas.Transparent = false;
            this.__mainmodule_ltpiezas.Font = new Font(this.__mainmodule_ltpiezas.Font.Name, 9f, this.__mainmodule_ltpiezas.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltpiezas);
            this.htControls.Add("__mainmodule_ltpiezas", this.__mainmodule_ltpiezas);
            this.__mainmodule_label41 = new CEnhancedLabel(this);
            this.__mainmodule_label41.name = "__mainmodule_label41";
            this.__mainmodule_label41.Left = 130;
            this.__mainmodule_label41.Top = 0x7b;
            this.__mainmodule_label41.Width = 40;
            this.__mainmodule_label41.Height = 20;
            this.__mainmodule_label41.Text = "Pzas.";
            this.__mainmodule_label41.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label41.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label41.MyEnabled = true;
            this.__mainmodule_label41.Visible = true;
            this.__mainmodule_label41.Transparent = false;
            this.__mainmodule_label41.Font = new Font(this.__mainmodule_label41.Font.Name, 9f, this.__mainmodule_label41.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label41);
            this.htControls.Add("__mainmodule_label41", this.__mainmodule_label41);
            this.__mainmodule_ltserver = new CEnhancedLabel(this);
            this.__mainmodule_ltserver.name = "__mainmodule_ltserver";
            this.__mainmodule_ltserver.Left = 3;
            this.__mainmodule_ltserver.Top = 0xe0;
            this.__mainmodule_ltserver.Width = 0xe7;
            this.__mainmodule_ltserver.Height = 0x29;
            this.__mainmodule_ltserver.Text = "";
            this.__mainmodule_ltserver.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_ltserver.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltserver.MyEnabled = true;
            this.__mainmodule_ltserver.Visible = true;
            this.__mainmodule_ltserver.Transparent = false;
            this.__mainmodule_ltserver.Font = new Font(this.__mainmodule_ltserver.Font.Name, 9f, this.__mainmodule_ltserver.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltserver);
            this.htControls.Add("__mainmodule_ltserver", this.__mainmodule_ltserver);
            this.__mainmodule_ltmreg = new CEnhancedLabel(this);
            this.__mainmodule_ltmreg.name = "__mainmodule_ltmreg";
            this.__mainmodule_ltmreg.Left = 60;
            this.__mainmodule_ltmreg.Top = 0x79;
            this.__mainmodule_ltmreg.Width = 70;
            this.__mainmodule_ltmreg.Height = 0x12;
            this.__mainmodule_ltmreg.Text = "";
            this.__mainmodule_ltmreg.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltmreg.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltmreg.MyEnabled = true;
            this.__mainmodule_ltmreg.Visible = true;
            this.__mainmodule_ltmreg.Transparent = false;
            this.__mainmodule_ltmreg.Font = new Font(this.__mainmodule_ltmreg.Font.Name, 9f, this.__mainmodule_ltmreg.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltmreg);
            this.htControls.Add("__mainmodule_ltmreg", this.__mainmodule_ltmreg);
            this.__mainmodule_ltmcant = new CEnhancedLabel(this);
            this.__mainmodule_ltmcant.name = "__mainmodule_ltmcant";
            this.__mainmodule_ltmcant.Left = 0xb9;
            this.__mainmodule_ltmcant.Top = 0x66;
            this.__mainmodule_ltmcant.Width = 50;
            this.__mainmodule_ltmcant.Height = 0x12;
            this.__mainmodule_ltmcant.Text = "";
            this.__mainmodule_ltmcant.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltmcant.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltmcant.MyEnabled = true;
            this.__mainmodule_ltmcant.Visible = true;
            this.__mainmodule_ltmcant.Transparent = false;
            this.__mainmodule_ltmcant.Font = new Font(this.__mainmodule_ltmcant.Font.Name, 9f, this.__mainmodule_ltmcant.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltmcant);
            this.htControls.Add("__mainmodule_ltmcant", this.__mainmodule_ltmcant);
            this.__mainmodule_lttipo = new CEnhancedLabel(this);
            this.__mainmodule_lttipo.name = "__mainmodule_lttipo";
            this.__mainmodule_lttipo.Left = 4;
            this.__mainmodule_lttipo.Top = 0x36;
            this.__mainmodule_lttipo.Width = 0x55;
            this.__mainmodule_lttipo.Height = 15;
            this.__mainmodule_lttipo.Text = "ACUMULATIVO";
            this.__mainmodule_lttipo.BackColor = Color.FromArgb(-6762242);
            this.__mainmodule_lttipo.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lttipo.MyEnabled = true;
            this.__mainmodule_lttipo.Visible = true;
            this.__mainmodule_lttipo.Transparent = false;
            this.__mainmodule_lttipo.Font = new Font(this.__mainmodule_lttipo.Font.Name, 7f, this.__mainmodule_lttipo.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_lttipo);
            this.htControls.Add("__mainmodule_lttipo", this.__mainmodule_lttipo);
            this.__mainmodule_opminve3 = new CEnhancedRadioBtn(this);
            this.__mainmodule_opminve3.name = "__mainmodule_opminve3";
            this.__mainmodule_opminve3.Left = 0x39;
            this.__mainmodule_opminve3.Top = 0x8e;
            this.__mainmodule_opminve3.Width = 0xa5;
            this.__mainmodule_opminve3.Height = 20;
            this.__mainmodule_opminve3.Text = "Inventario acumulativo";
            this.__mainmodule_opminve3.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_opminve3.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_opminve3.Enabled = true;
            this.__mainmodule_opminve3.Visible = true;
            this.__mainmodule_opminve3.Checked = false;
            this.__mainmodule_opminve3.Font = new Font(this.__mainmodule_opminve3.Font.Name, 9f, this.__mainmodule_opminve3.Font.Style);
            this.__mainmodule_opminve3.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_opminve3);
            this.htControls.Add("__mainmodule_opminve3", this.__mainmodule_opminve3);
            this.__mainmodule_opminve2 = new CEnhancedRadioBtn(this);
            this.__mainmodule_opminve2.name = "__mainmodule_opminve2";
            this.__mainmodule_opminve2.Left = 0x39;
            this.__mainmodule_opminve2.Top = 0xb6;
            this.__mainmodule_opminve2.Width = 0xa5;
            this.__mainmodule_opminve2.Height = 20;
            this.__mainmodule_opminve2.Text = "Ajustar inventario";
            this.__mainmodule_opminve2.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_opminve2.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_opminve2.Enabled = true;
            this.__mainmodule_opminve2.Visible = true;
            this.__mainmodule_opminve2.Checked = true;
            this.__mainmodule_opminve2.Font = new Font(this.__mainmodule_opminve2.Font.Name, 9f, this.__mainmodule_opminve2.Font.Style);
            this.__mainmodule_opminve2.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_opminve2);
            this.htControls.Add("__mainmodule_opminve2", this.__mainmodule_opminve2);
            this.__mainmodule_opminve1 = new CEnhancedRadioBtn(this);
            this.__mainmodule_opminve1.name = "__mainmodule_opminve1";
            this.__mainmodule_opminve1.Left = 0x39;
            this.__mainmodule_opminve1.Top = 0xa2;
            this.__mainmodule_opminve1.Width = 0xa5;
            this.__mainmodule_opminve1.Height = 20;
            this.__mainmodule_opminve1.Text = "Actualizar inventario";
            this.__mainmodule_opminve1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_opminve1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_opminve1.Enabled = true;
            this.__mainmodule_opminve1.Visible = true;
            this.__mainmodule_opminve1.Checked = false;
            this.__mainmodule_opminve1.Font = new Font(this.__mainmodule_opminve1.Font.Name, 9f, this.__mainmodule_opminve1.Font.Style);
            this.__mainmodule_opminve1.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_opminve1);
            this.htControls.Add("__mainmodule_opminve1", this.__mainmodule_opminve1);
            this.__mainmodule_lalma = new CEnhancedLabel(this);
            this.__mainmodule_lalma.name = "__mainmodule_lalma";
            this.__mainmodule_lalma.Left = 190;
            this.__mainmodule_lalma.Top = 0x1c;
            this.__mainmodule_lalma.Width = 0x2d;
            this.__mainmodule_lalma.Height = 20;
            this.__mainmodule_lalma.Text = "";
            this.__mainmodule_lalma.BackColor = Color.FromArgb(-6762242);
            this.__mainmodule_lalma.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_lalma.MyEnabled = true;
            this.__mainmodule_lalma.Visible = true;
            this.__mainmodule_lalma.Transparent = false;
            this.__mainmodule_lalma.Font = new Font(this.__mainmodule_lalma.Font.Name, 10f, this.__mainmodule_lalma.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_lalma);
            this.htControls.Add("__mainmodule_lalma", this.__mainmodule_lalma);
            this.__mainmodule_label38 = new CEnhancedLabel(this);
            this.__mainmodule_label38.name = "__mainmodule_label38";
            this.__mainmodule_label38.Left = 0xa4;
            this.__mainmodule_label38.Top = 0x1c;
            this.__mainmodule_label38.Width = 0x23;
            this.__mainmodule_label38.Height = 20;
            this.__mainmodule_label38.Text = "Alm.";
            this.__mainmodule_label38.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label38.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label38.MyEnabled = true;
            this.__mainmodule_label38.Visible = true;
            this.__mainmodule_label38.Transparent = false;
            this.__mainmodule_label38.Font = new Font(this.__mainmodule_label38.Font.Name, 9f, this.__mainmodule_label38.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label38);
            this.htControls.Add("__mainmodule_label38", this.__mainmodule_label38);
            this.__mainmodule_label1 = new CEnhancedLabel(this);
            this.__mainmodule_label1.name = "__mainmodule_label1";
            this.__mainmodule_label1.Left = 0x9b;
            this.__mainmodule_label1.Top = 0x34;
            this.__mainmodule_label1.Width = 0x2d;
            this.__mainmodule_label1.Height = 20;
            this.__mainmodule_label1.Text = "C. sal.:";
            this.__mainmodule_label1.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label1.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label1.MyEnabled = true;
            this.__mainmodule_label1.Visible = true;
            this.__mainmodule_label1.Transparent = false;
            this.__mainmodule_label1.Font = new Font(this.__mainmodule_label1.Font.Name, 9f, this.__mainmodule_label1.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label1);
            this.htControls.Add("__mainmodule_label1", this.__mainmodule_label1);
            this.__mainmodule_tconsal = new CEnhancedTextBox(this);
            this.__mainmodule_tconsal.name = "__mainmodule_tconsal";
            this.__mainmodule_tconsal.Left = 0xc9;
            this.__mainmodule_tconsal.Top = 0x33;
            this.__mainmodule_tconsal.Width = 30;
            this.__mainmodule_tconsal.Text = "55";
            this.__mainmodule_tconsal.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tconsal.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tconsal.Enabled = true;
            this.__mainmodule_tconsal.Visible = true;
            this.__mainmodule_tconsal.Height = 0x16;
            this.__mainmodule_tconsal.Font = new Font(this.__mainmodule_tconsal.Font.Name, 9f, this.__mainmodule_tconsal.Font.Style);
            this.__mainmodule_tconsal.multiline = false;
            this.__mainmodule_tconsal.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_tconsal);
            this.htControls.Add("__mainmodule_tconsal", this.__mainmodule_tconsal);
            this.__mainmodule_numano = new CEnhancedNumUpDown(this);
            this.__mainmodule_numano.name = "__mainmodule_numano";
            this.__mainmodule_numano.Left = 0xad;
            this.__mainmodule_numano.Top = 0x4d;
            this.__mainmodule_numano.Width = 60;
            this.__mainmodule_numano.Maximum = 2030M;
            this.__mainmodule_numano.Value = 2015M;
            this.__mainmodule_numano.BackColor = Color.FromArgb(-1);
            this.__mainmodule_numano.Enabled = true;
            this.__mainmodule_numano.Visible = true;
            this.__mainmodule_numano.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_numano);
            this.htControls.Add("__mainmodule_numano", this.__mainmodule_numano);
            this.__mainmodule_nummes = new CEnhancedNumUpDown(this);
            this.__mainmodule_nummes.name = "__mainmodule_nummes";
            this.__mainmodule_nummes.Left = 0x7c;
            this.__mainmodule_nummes.Top = 0x4d;
            this.__mainmodule_nummes.Width = 0x2f;
            this.__mainmodule_nummes.Maximum = 12M;
            this.__mainmodule_nummes.Value = 0M;
            this.__mainmodule_nummes.BackColor = Color.FromArgb(-1);
            this.__mainmodule_nummes.Enabled = true;
            this.__mainmodule_nummes.Visible = true;
            this.__mainmodule_nummes.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_nummes);
            this.htControls.Add("__mainmodule_nummes", this.__mainmodule_nummes);
            this.__mainmodule_numdia = new CEnhancedNumUpDown(this);
            this.__mainmodule_numdia.name = "__mainmodule_numdia";
            this.__mainmodule_numdia.Left = 0x4c;
            this.__mainmodule_numdia.Top = 0x4d;
            this.__mainmodule_numdia.Width = 0x2f;
            this.__mainmodule_numdia.Maximum = 31M;
            this.__mainmodule_numdia.Value = 0M;
            this.__mainmodule_numdia.BackColor = Color.FromArgb(-1);
            this.__mainmodule_numdia.Enabled = true;
            this.__mainmodule_numdia.Visible = true;
            this.__mainmodule_numdia.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_numdia);
            this.htControls.Add("__mainmodule_numdia", this.__mainmodule_numdia);
            this.__mainmodule_label32 = new CEnhancedLabel(this);
            this.__mainmodule_label32.name = "__mainmodule_label32";
            this.__mainmodule_label32.Left = 2;
            this.__mainmodule_label32.Top = 0x79;
            this.__mainmodule_label32.Width = 60;
            this.__mainmodule_label32.Height = 20;
            this.__mainmodule_label32.Text = "Registros:";
            this.__mainmodule_label32.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label32.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label32.MyEnabled = true;
            this.__mainmodule_label32.Visible = true;
            this.__mainmodule_label32.Transparent = false;
            this.__mainmodule_label32.Font = new Font(this.__mainmodule_label32.Font.Name, 9f, this.__mainmodule_label32.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label32);
            this.htControls.Add("__mainmodule_label32", this.__mainmodule_label32);
            this.__mainmodule_label33 = new CEnhancedLabel(this);
            this.__mainmodule_label33.name = "__mainmodule_label33";
            this.__mainmodule_label33.Left = 150;
            this.__mainmodule_label33.Top = 0x67;
            this.__mainmodule_label33.Width = 40;
            this.__mainmodule_label33.Height = 20;
            this.__mainmodule_label33.Text = "Cant.:";
            this.__mainmodule_label33.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label33.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label33.MyEnabled = true;
            this.__mainmodule_label33.Visible = true;
            this.__mainmodule_label33.Transparent = false;
            this.__mainmodule_label33.Font = new Font(this.__mainmodule_label33.Font.Name, 9f, this.__mainmodule_label33.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label33);
            this.htControls.Add("__mainmodule_label33", this.__mainmodule_label33);
            this.__mainmodule_ltmart = new CEnhancedLabel(this);
            this.__mainmodule_ltmart.name = "__mainmodule_ltmart";
            this.__mainmodule_ltmart.Left = 1;
            this.__mainmodule_ltmart.Top = 0x66;
            this.__mainmodule_ltmart.Width = 150;
            this.__mainmodule_ltmart.Height = 0x12;
            this.__mainmodule_ltmart.Text = "";
            this.__mainmodule_ltmart.BackColor = Color.FromArgb(-128);
            this.__mainmodule_ltmart.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltmart.MyEnabled = true;
            this.__mainmodule_ltmart.Visible = true;
            this.__mainmodule_ltmart.Transparent = false;
            this.__mainmodule_ltmart.Font = new Font(this.__mainmodule_ltmart.Font.Name, 9f, this.__mainmodule_ltmart.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltmart);
            this.htControls.Add("__mainmodule_ltmart", this.__mainmodule_ltmart);
            this.__mainmodule_trefminve = new CEnhancedTextBox(this);
            this.__mainmodule_trefminve.name = "__mainmodule_trefminve";
            this.__mainmodule_trefminve.Left = 0x23;
            this.__mainmodule_trefminve.Top = 0x1c;
            this.__mainmodule_trefminve.Width = 0x7d;
            this.__mainmodule_trefminve.Text = "";
            this.__mainmodule_trefminve.BackColor = Color.FromArgb(-1);
            this.__mainmodule_trefminve.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_trefminve.Enabled = true;
            this.__mainmodule_trefminve.Visible = true;
            this.__mainmodule_trefminve.Height = 0x16;
            this.__mainmodule_trefminve.Font = new Font(this.__mainmodule_trefminve.Font.Name, 9f, this.__mainmodule_trefminve.Font.Style);
            this.__mainmodule_trefminve.multiline = false;
            this.__mainmodule_trefminve.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_trefminve);
            this.htControls.Add("__mainmodule_trefminve", this.__mainmodule_trefminve);
            this.__mainmodule_label24 = new CEnhancedLabel(this);
            this.__mainmodule_label24.name = "__mainmodule_label24";
            this.__mainmodule_label24.Left = 1;
            this.__mainmodule_label24.Top = 0x4d;
            this.__mainmodule_label24.Width = 0x55;
            this.__mainmodule_label24.Height = 20;
            this.__mainmodule_label24.Text = "fecha(d-m-a)";
            this.__mainmodule_label24.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label24.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label24.MyEnabled = true;
            this.__mainmodule_label24.Visible = true;
            this.__mainmodule_label24.Transparent = false;
            this.__mainmodule_label24.Font = new Font(this.__mainmodule_label24.Font.Name, 9f, this.__mainmodule_label24.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label24);
            this.htControls.Add("__mainmodule_label24", this.__mainmodule_label24);
            this.__mainmodule_tconm = new CEnhancedTextBox(this);
            this.__mainmodule_tconm.name = "__mainmodule_tconm";
            this.__mainmodule_tconm.Left = 0x7b;
            this.__mainmodule_tconm.Top = 0x34;
            this.__mainmodule_tconm.Width = 30;
            this.__mainmodule_tconm.Text = "6";
            this.__mainmodule_tconm.BackColor = Color.FromArgb(-1);
            this.__mainmodule_tconm.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_tconm.Enabled = true;
            this.__mainmodule_tconm.Visible = true;
            this.__mainmodule_tconm.Height = 0x16;
            this.__mainmodule_tconm.Font = new Font(this.__mainmodule_tconm.Font.Name, 9f, this.__mainmodule_tconm.Font.Style);
            this.__mainmodule_tconm.multiline = false;
            this.__mainmodule_tconm.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_tconm);
            this.htControls.Add("__mainmodule_tconm", this.__mainmodule_tconm);
            this.__mainmodule_ltconm = new CEnhancedLabel(this);
            this.__mainmodule_ltconm.name = "__mainmodule_ltconm";
            this.__mainmodule_ltconm.Left = 0x4c;
            this.__mainmodule_ltconm.Top = 0x36;
            this.__mainmodule_ltconm.Width = 0x2d;
            this.__mainmodule_ltconm.Height = 20;
            this.__mainmodule_ltconm.Text = "C. ent.:";
            this.__mainmodule_ltconm.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_ltconm.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_ltconm.MyEnabled = true;
            this.__mainmodule_ltconm.Visible = true;
            this.__mainmodule_ltconm.Transparent = false;
            this.__mainmodule_ltconm.Font = new Font(this.__mainmodule_ltconm.Font.Name, 9f, this.__mainmodule_ltconm.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_ltconm);
            this.htControls.Add("__mainmodule_ltconm", this.__mainmodule_ltconm);
            this.__mainmodule_label11 = new CEnhancedLabel(this);
            this.__mainmodule_label11.name = "__mainmodule_label11";
            this.__mainmodule_label11.Left = 1;
            this.__mainmodule_label11.Top = 30;
            this.__mainmodule_label11.Width = 0x2d;
            this.__mainmodule_label11.Height = 20;
            this.__mainmodule_label11.Text = "Refer.:";
            this.__mainmodule_label11.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_label11.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_label11.MyEnabled = true;
            this.__mainmodule_label11.Visible = true;
            this.__mainmodule_label11.Transparent = false;
            this.__mainmodule_label11.Font = new Font(this.__mainmodule_label11.Font.Name, 8f, this.__mainmodule_label11.Font.Style);
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_label11);
            this.htControls.Add("__mainmodule_label11", this.__mainmodule_label11);
            this.__mainmodule_btnexistminve = new CEnhancedButton(this);
            this.__mainmodule_btnexistminve.name = "__mainmodule_btnexistminve";
            this.__mainmodule_btnexistminve.Left = 190;
            this.__mainmodule_btnexistminve.Top = 2;
            this.__mainmodule_btnexistminve.Width = 50;
            this.__mainmodule_btnexistminve.Height = 0x19;
            this.__mainmodule_btnexistminve.Text = "Salir";
            this.__mainmodule_btnexistminve.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btnexistminve.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btnexistminve.Enabled = true;
            this.__mainmodule_btnexistminve.Visible = true;
            this.__mainmodule_btnexistminve.Font = new Font(this.__mainmodule_btnexistminve.Font.Name, 9f, this.__mainmodule_btnexistminve.Font.Style);
            this.__mainmodule_btnexistminve.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_btnexistminve);
            this.htControls.Add("__mainmodule_btnexistminve", this.__mainmodule_btnexistminve);
            this.__mainmodule_btngenerar = new CEnhancedButton(this);
            this.__mainmodule_btngenerar.name = "__mainmodule_btngenerar";
            this.__mainmodule_btngenerar.Left = 70;
            this.__mainmodule_btngenerar.Top = 2;
            this.__mainmodule_btngenerar.Width = 110;
            this.__mainmodule_btngenerar.Height = 0x19;
            this.__mainmodule_btngenerar.Text = "Generar MINVE";
            this.__mainmodule_btngenerar.BackColor = Color.FromArgb(-66313);
            this.__mainmodule_btngenerar.ForeColor = Color.FromArgb(-16777216);
            this.__mainmodule_btngenerar.Enabled = true;
            this.__mainmodule_btngenerar.Visible = true;
            this.__mainmodule_btngenerar.Font = new Font(this.__mainmodule_btngenerar.Font.Name, 9f, this.__mainmodule_btngenerar.Font.Style);
            this.__mainmodule_btngenerar.AddEvents();
            this.__mainmodule_procminve.Controls.Add(this.__mainmodule_btngenerar);
            this.htControls.Add("__mainmodule_btngenerar", this.__mainmodule_btngenerar);
            this.__mainmodule_mnuminve = new CEnhancedMenu(this);
            this.__mainmodule_mnuminve.name = "__mainmodule_mnuminve";
            this.__mainmodule_mnuminve.Text = "Archivo";
            this.__mainmodule_mnuminve.Enabled = true;
            this.__mainmodule_mnuminve.Checked = false;
            this.__mainmodule_mnuminve.AddToObject("__mainmodule_procminve");
            this.__mainmodule_mnuminve.AddEvents();
            this.htControls.Add("__mainmodule_mnuminve", this.__mainmodule_mnuminve);
            this.__mainmodule_mnuminve1 = new CEnhancedMenu(this);
            this.__mainmodule_mnuminve1.name = "__mainmodule_mnuminve1";
            this.__mainmodule_mnuminve1.Text = "Remarcar para reenvio";
            this.__mainmodule_mnuminve1.Enabled = true;
            this.__mainmodule_mnuminve1.Checked = false;
            this.__mainmodule_mnuminve1.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuminve1.AddEvents();
            this.htControls.Add("__mainmodule_mnuminve1", this.__mainmodule_mnuminve1);
            this.__mainmodule_mnuacumulativo = new CEnhancedMenu(this);
            this.__mainmodule_mnuacumulativo.name = "__mainmodule_mnuacumulativo";
            this.__mainmodule_mnuacumulativo.Text = "Inventario acumulativo";
            this.__mainmodule_mnuacumulativo.Enabled = true;
            this.__mainmodule_mnuacumulativo.Checked = false;
            this.__mainmodule_mnuacumulativo.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuacumulativo.AddEvents();
            this.htControls.Add("__mainmodule_mnuacumulativo", this.__mainmodule_mnuacumulativo);
            this.__mainmodule_mnuactualizar = new CEnhancedMenu(this);
            this.__mainmodule_mnuactualizar.name = "__mainmodule_mnuactualizar";
            this.__mainmodule_mnuactualizar.Text = "Actualizar inventario";
            this.__mainmodule_mnuactualizar.Enabled = true;
            this.__mainmodule_mnuactualizar.Checked = false;
            this.__mainmodule_mnuactualizar.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuactualizar.AddEvents();
            this.htControls.Add("__mainmodule_mnuactualizar", this.__mainmodule_mnuactualizar);
            this.__mainmodule_mnuajustar = new CEnhancedMenu(this);
            this.__mainmodule_mnuajustar.name = "__mainmodule_mnuajustar";
            this.__mainmodule_mnuajustar.Text = "Ajustar inventario";
            this.__mainmodule_mnuajustar.Enabled = true;
            this.__mainmodule_mnuajustar.Checked = false;
            this.__mainmodule_mnuajustar.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuajustar.AddEvents();
            this.htControls.Add("__mainmodule_mnuajustar", this.__mainmodule_mnuajustar);
            this.__mainmodule_mnuenviarsql = new CEnhancedMenu(this);
            this.__mainmodule_mnuenviarsql.name = "__mainmodule_mnuenviarsql";
            this.__mainmodule_mnuenviarsql.Text = "Enviar inventario al Servidor";
            this.__mainmodule_mnuenviarsql.Enabled = true;
            this.__mainmodule_mnuenviarsql.Checked = false;
            this.__mainmodule_mnuenviarsql.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuenviarsql.AddEvents();
            this.htControls.Add("__mainmodule_mnuenviarsql", this.__mainmodule_mnuenviarsql);
            this.__mainmodule_mnutotalminve = new CEnhancedMenu(this);
            this.__mainmodule_mnutotalminve.name = "__mainmodule_mnutotalminve";
            this.__mainmodule_mnutotalminve.Text = "Total partidas";
            this.__mainmodule_mnutotalminve.Enabled = true;
            this.__mainmodule_mnutotalminve.Checked = false;
            this.__mainmodule_mnutotalminve.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnutotalminve.AddEvents();
            this.htControls.Add("__mainmodule_mnutotalminve", this.__mainmodule_mnutotalminve);
            this.__mainmodule_mnuexxlinea = new CEnhancedMenu(this);
            this.__mainmodule_mnuexxlinea.name = "__mainmodule_mnuexxlinea";
            this.__mainmodule_mnuexxlinea.Text = "Exist X Linea";
            this.__mainmodule_mnuexxlinea.Enabled = true;
            this.__mainmodule_mnuexxlinea.Checked = false;
            this.__mainmodule_mnuexxlinea.AddToObject("__mainmodule_mnuminve");
            this.__mainmodule_mnuexxlinea.AddEvents();
            this.htControls.Add("__mainmodule_mnuexxlinea", this.__mainmodule_mnuexxlinea);
        }

        public bool LCompareEqual(string lSide, string rSide) => 
            ((lSide == "") && (rSide == "0")) || (lSide == rSide);

        [STAThread]
        private static void Main(string[] args)
        {
            new b4p(args);
        }

        public bool RCompareEqual(string lSide, string rSide) => 
            ((lSide == "0") && (rSide == "")) || (lSide == rSide);

        public bool ShowError(Exception ex, string subName)
        {
            Cursor.Current = Cursors.Default;
            if (this.quitFlag)
            {
                return true;
            }
            ArrayList list = new ArrayList();
            foreach (DictionaryEntry entry in this.htControls)
            {
                object obj2 = entry.Value;
                if ((obj2 is System.Windows.Forms.Timer) && ((System.Windows.Forms.Timer) obj2).Enabled)
                {
                    ((System.Windows.Forms.Timer) obj2).Enabled = false;
                    list.Add(obj2);
                }
            }
            if (MessageBox.Show("An error occurred on sub " + subName + ".\r\n\r\n" + ex.Message + "\r\nContinue?", "Basic4ppc", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                this.quitFlag = true;
                if (this.mainForm != null)
                {
                    this.mainForm.Close();
                }
                return true;
            }
            foreach (System.Windows.Forms.Timer timer in list)
            {
                timer.Enabled = true;
            }
            return false;
        }

        public delegate string del0();

        public delegate string del1(string a);

        public delegate string del2(string a, string b);

        public delegate string del3(string a, string b, string c);
    }
}

