using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class RibbonAppTest : KryptonForm
    {
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;

        private void InitializeComponent()
        {
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = null;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1155, 114);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // RibbonAppTest
            // 
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "RibbonAppTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public RibbonAppTest()
        {
            InitializeComponent();
        }
    }
}