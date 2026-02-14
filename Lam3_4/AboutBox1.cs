using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Lam3_4
{
    public partial class AboutBox1 : Form
    {
        private System.ComponentModel.IContainer? components = null;
        private TableLayoutPanel tableLayoutPanel = null!;
        private Label labelProductName = null!;
        private Label labelVersion = null!;
        private Label labelCopyright = null!;
        private Label labelCompanyName = null!;
        private TextBox textBoxDescription = null!;
        private Button okButton = null!;

        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("Про програму {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = "@РДЕУ, 2008";
            this.labelCompanyName.Text = "Ваше ім’я";
            this.textBoxDescription.Text = "Студентський проект";
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new TableLayoutPanel();
            this.labelProductName = new Label();
            this.labelVersion = new Label();
            this.labelCopyright = new Label();
            this.labelCompanyName = new Label();
            this.textBoxDescription = new TextBox();
            this.okButton = new Button();
            this.SuspendLayout();

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 0, 5);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.Location = new Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new Size(417, 265);
            this.tableLayoutPanel.TabIndex = 0;

            // labelProductName
            this.labelProductName.Dock = DockStyle.Fill;
            this.labelProductName.Margin = new Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new Size(408, 17);
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;

            // labelVersion
            this.labelVersion.Dock = DockStyle.Fill;
            this.labelVersion.Margin = new Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new Size(408, 17);
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;

            // labelCopyright
            this.labelCopyright.Dock = DockStyle.Fill;
            this.labelCopyright.Margin = new Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new Size(408, 17);
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;

            // labelCompanyName
            this.labelCompanyName.Dock = DockStyle.Fill;
            this.labelCompanyName.Margin = new Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(408, 17);
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;

            // textBoxDescription
            this.textBoxDescription.Dock = DockStyle.Fill;
            this.textBoxDescription.Margin = new Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = ScrollBars.Both;
            this.textBoxDescription.Size = new Size(408, 126);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";

            // okButton
            this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.okButton.DialogResult = DialogResult.OK;
            this.okButton.Location = new Point(339, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += (s, e) => this.Close();

            // AboutBox1
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0.0";
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
