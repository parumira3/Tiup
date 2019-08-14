using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiup
{
    public partial class OrderForm_01 : Form
    {
        public delegate int delgOrderDecision(int i);

        int _Tot_Price = 0;
        public OrderForm_01()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_01_Click(object sender, EventArgs e)
        {
            if (rdoSvc_Beginner.Checked)

                tiupCourse(1);

            else if (rdoSvc_Intermediate.Checked)

                tiupCourse(2);

            else if (rdoSvc_Advanced.Checked)

                tiupCourse(3);
        }

        #region Function

        private int tiupCourse(int iCrs)
        {
            string strOrder = string.Empty;
            
            int Course_Price = 0;
            

            if (iCrs == 1)
            {
                Course_Price = 20000;
                strOrder =  string.Format("초급자 ({0}원)", Course_Price.ToString());
                
            }
            else if (iCrs == 2)
            {
                Course_Price = 25000;
                strOrder = string.Format("중급자 ({0}원)", Course_Price.ToString());
            }
            else if (iCrs == 3)
            {
                Course_Price = 30000;
                strOrder = string.Format("고급자 ({0}원)", Course_Price.ToString());
            }
            else
            {                
                strOrder = "코스선택 안함";
            }

            lstBxDisplay_01.Items.Add(strOrder);
            return _Tot_Price = +Course_Price;

        }

        #endregion

    }
}
