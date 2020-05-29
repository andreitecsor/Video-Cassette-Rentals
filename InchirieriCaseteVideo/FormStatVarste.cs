using InchirieriCaseteVideo.DBContext;
using InchirieriCaseteVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriCaseteVideo
{
    public partial class FormStatVarste : Form
    {
        InchirieriDbContext context = new InchirieriDbContext();
        public int[] varste;
        public FormStatVarste()
        {
            InitializeComponent();
            int contor = context.Clienti.ToArray().Count() ;
            StatusLabel.Text = "Total clienți: " + contor;
            varste = new int[contor];
            int i = 0;
            foreach(Client client in context.Clienti ){
                varste[i] = ((DateTime.Today.Date - client.DataNastere.Date).Days) / 365;
                i++;
            }

            #region User control
            //Initializare user control-ul creat
            AgeStatsChartLibrary.AgeStatsChart ageStatsChart = new AgeStatsChartLibrary.AgeStatsChart(varste);
            ageStatsChart.Location = new System.Drawing.Point(12, 12);
            ageStatsChart.Name = "ageStatsChart";
            ageStatsChart.Size = new System.Drawing.Size(262, 331);
            ageStatsChart.TabIndex = 0;
            this.Controls.Add(ageStatsChart);
            #endregion
        }

    }
}
