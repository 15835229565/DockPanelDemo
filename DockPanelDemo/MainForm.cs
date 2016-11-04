using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockPanelDemo
{
    public partial class MainForm : Form
    {
        private ToolFormA toolFormA;
        private ToolFormB toolFormB;
        private ToolFormC toolFormC;
        private WorkFormA workFormA;
        private WorkFormB workFormB;
        private WorkFormC workFormC;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VS2013BlueTheme theme = new VS2013BlueTheme();
            this.MainPanel.Theme = theme;
            this.toolFormA=new ToolFormA();
            this.toolFormB=new ToolFormB();
            this.toolFormC=new ToolFormC();
            this.workFormA=new WorkFormA();
            this.workFormB=new WorkFormB();
            this.workFormC=new WorkFormC();
            toolFormA.Show(this.MainPanel,DockState.DockLeft);
            toolFormB.Show(this.MainPanel, DockState.DockLeft);
            toolFormC.Show(this.MainPanel, DockState.DockLeft);
            workFormA.Show(this.MainPanel,DockState.Document);
            workFormB.Show(this.MainPanel, DockState.Document);
            workFormC.Show(this.MainPanel, DockState.Document);
            
        }
    }
}
