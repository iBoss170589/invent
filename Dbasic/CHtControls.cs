namespace Dbasic
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    public class CHtControls : Hashtable
    {
        public static bool shouldScale;

        public override void Add(object key, object value)
        {
            base.Add(key, value);
            if (shouldScale)
            {
                object obj2 = value;
                if (obj2 is Control)
                {
                    Other.ScaleControls((Control) obj2);
                }
            }
        }
    }
}

