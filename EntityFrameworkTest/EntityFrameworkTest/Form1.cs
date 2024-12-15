using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var u = new ConfigSettings()
            {
                Id = Guid.NewGuid(),
                ConfigModel = "TEST"
            };

            using (var cbContext=new ApplicationDbContext())
            {
                cbContext.ConfigSettings.Add(u);
                cbContext.SaveChanges();
            }
        }
    }
}
