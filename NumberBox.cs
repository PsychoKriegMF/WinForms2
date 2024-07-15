using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace WinForms2
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            //InitializeComponent();
        }
        public double Value
        { 
            get 
            {                
                return Convert.ToDouble(this.Text);
            } 
            set => this.Text = Convert.ToString(value);            
        }

        
    }
}
