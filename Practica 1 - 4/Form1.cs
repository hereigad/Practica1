using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1___4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            Button nuevo = new Button();
            SuspendLayout();
            nuevo.Location = new System.Drawing.Point(350, 73);
            nuevo.Name = "nuevo";
            nuevo.Size = new System.Drawing.Size(102, 53);
            nuevo.TabIndex = 2;
            nuevo.Text = "Nuevo";
            nuevo.UseVisualStyleBackColor = true;
            nuevo.Click += new System.EventHandler(this.nuevo_Click);
            this.Controls.Add(nuevo);
            ResumeLayout(false);
        }

        private void nuevo_Click(object sender, EventArgs e) {
            string message = "Hola";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }
    }
}
