using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lam3_4
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer? components = null;
        private MenuStrip menuStrip1 = null!;
        private ToolStripMenuItem fileToolStripMenuItem = null!;
        private ToolStripMenuItem objektToolStripMenuItem = null!;
        private ToolStripMenuItem exitToolStripMenuItem = null!;
        private ToolStripMenuItem helpToolStripMenuItem = null!;
        private ToolStripMenuItem aboutToolStripMenuItem = null!;
        
        private ToolStrip toolStrip1 = null!;
        private ToolStripButton toolStripButtonUndo = null!;
        private ToolStripButton toolStripButtonNew = null!;
        private ToolStripButton toolStripButtonEdit = null!;
        private ToolStripButton toolStripButtonSave = null!;
        private ToolStripButton toolStripButtonRemove = null!;
        
        private ContextMenuStrip contextMenuStrip1 = null!;
        private ToolStripMenuItem undo1ToolStripMenuItem = null!;
        
        private StatusStrip statusStrip1 = null!;
        private ToolStripStatusLabel toolStripStatusLabelTime = null!;
        private System.Windows.Forms.Timer timer1 = null!;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.objektToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            
            this.toolStrip1 = new ToolStrip();
            this.toolStripButtonUndo = new ToolStripButton();
            this.toolStripButtonNew = new ToolStripButton();
            this.toolStripButtonEdit = new ToolStripButton();
            this.toolStripButtonSave = new ToolStripButton();
            this.toolStripButtonRemove = new ToolStripButton();
            
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.undo1ToolStripMenuItem = new ToolStripMenuItem();
            
            this.statusStrip1 = new StatusStrip();
            this.toolStripStatusLabelTime = new ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.helpToolStripMenuItem
            });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.objektToolStripMenuItem,
                this.exitToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";

            // objektToolStripMenuItem
            this.objektToolStripMenuItem.Name = "objektToolStripMenuItem";
            this.objektToolStripMenuItem.Size = new Size(180, 22);
            this.objektToolStripMenuItem.Text = "Об’єкт";
            this.objektToolStripMenuItem.Click += new EventHandler(this.objektToolStripMenuItem_Click);

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new Size(180, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);

            // helpToolStripMenuItem
            this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.aboutToolStripMenuItem
            });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(65, 20);
            this.helpToolStripMenuItem.Text = "Довідка";

            // aboutToolStripMenuItem
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Про програму";
            this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);

            // toolStrip1
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
                this.toolStripButtonUndo,
                this.toolStripButtonNew,
                this.toolStripButtonEdit,
                this.toolStripButtonSave,
                this.toolStripButtonRemove
            });
            this.toolStrip1.Location = new Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";

            // toolStripButtonUndo
            this.toolStripButtonUndo.DisplayStyle = ToolStripItemDisplayStyle.Text; // Спрощено без іконок поки що
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new Size(40, 22);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.ToolTipText = "Відмінити останню дію";
            this.toolStripButtonUndo.Click += new EventHandler(this.toolStripButtonUndo_Click);

            // toolStripButtonNew
            this.toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.ToolTipText = "Створити новий об'єкт";

            // toolStripButtonEdit
            this.toolStripButtonEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Text = "Edit";
            this.toolStripButtonEdit.ToolTipText = "Редагувати";

            // toolStripButtonSave
            this.toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.ToolTipText = "Зберегти";

            // toolStripButtonRemove
            this.toolStripButtonRemove.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemove.Text = "Remove";
            this.toolStripButtonRemove.ToolTipText = "Видалити";
            this.toolStripButtonRemove.Click += (s, e) => Remove();

            // contextMenuStrip1
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
                this.undo1ToolStripMenuItem
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(104, 26);

            // undo1ToolStripMenuItem
            this.undo1ToolStripMenuItem.Name = "undo1ToolStripMenuItem";
            this.undo1ToolStripMenuItem.Size = new Size(103, 22);
            this.undo1ToolStripMenuItem.Text = "Undo";
            this.undo1ToolStripMenuItem.Click += new EventHandler(this.undo1ToolStripMenuItem_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
                this.toolStripStatusLabelTime
            });
            this.statusStrip1.Location = new Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";

            // toolStripStatusLabelTime
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new Size(0, 17);

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);

            // MainForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "MainForm";
            this.Text = "Лабораторна робота 3-4";
            this.Load += new EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void exitToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void objektToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Пункт меню Об'єкт");
        }

        private void aboutToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog(this);
        }

        private void toolStripButtonUndo_Click(object? sender, EventArgs e)
        {
            Undo();
        }

        private void undo1ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Undo();
        }

        private void Undo()
        {
            MessageBox.Show("Дія Undo виконана");
        }

        private void Remove()
        {
            DialogResult result = MessageBox.Show(
                "Видалити дані \n по співробітнику?",
                "Попередження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Видалення даних");
                    break;

                case DialogResult.No:
                    MessageBox.Show("Скасування видалення даних");
                    break;
            }
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

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
