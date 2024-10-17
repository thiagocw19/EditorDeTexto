namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtbTexto = new RichTextBox();
            tosPrincipal = new ToolStrip();
            tsbNovoDocumento = new ToolStripButton();
            tsbAbrirDocumento = new ToolStripButton();
            tsbSalvarDocumento = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbInserir = new ToolStripButton();
            ofdAbrirDocumento = new OpenFileDialog();
            sfdSalvarDocumento = new SaveFileDialog();
            tosPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // rtbTexto
            // 
            rtbTexto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbTexto.Location = new Point(12, 42);
            rtbTexto.Name = "rtbTexto";
            rtbTexto.Size = new Size(776, 396);
            rtbTexto.TabIndex = 0;
            rtbTexto.Text = "";
            rtbTexto.SelectionChanged += rtbTexto_SelectionChanged;
            rtbTexto.TextChanged += rtbTexto_TextChanged;
            // 
            // tosPrincipal
            // 
            tosPrincipal.Items.AddRange(new ToolStripItem[] { tsbNovoDocumento, tsbAbrirDocumento, tsbSalvarDocumento, toolStripSeparator1, tsbInserir });
            tosPrincipal.Location = new Point(0, 0);
            tosPrincipal.Name = "tosPrincipal";
            tosPrincipal.Size = new Size(800, 39);
            tosPrincipal.TabIndex = 1;
            tosPrincipal.Text = "toolStrip1";
            // 
            // tsbNovoDocumento
            // 
            tsbNovoDocumento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNovoDocumento.Image = (Image)resources.GetObject("tsbNovoDocumento.Image");
            tsbNovoDocumento.ImageScaling = ToolStripItemImageScaling.None;
            tsbNovoDocumento.ImageTransparentColor = Color.Magenta;
            tsbNovoDocumento.Name = "tsbNovoDocumento";
            tsbNovoDocumento.Size = new Size(36, 36);
            tsbNovoDocumento.Text = "toolStripButton1";
            tsbNovoDocumento.TextImageRelation = TextImageRelation.TextAboveImage;
            tsbNovoDocumento.ToolTipText = "Novo Documento";
            tsbNovoDocumento.Click += tsbNovoDocumento_Click;
            // 
            // tsbAbrirDocumento
            // 
            tsbAbrirDocumento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAbrirDocumento.Image = (Image)resources.GetObject("tsbAbrirDocumento.Image");
            tsbAbrirDocumento.ImageScaling = ToolStripItemImageScaling.None;
            tsbAbrirDocumento.ImageTransparentColor = Color.Magenta;
            tsbAbrirDocumento.Name = "tsbAbrirDocumento";
            tsbAbrirDocumento.Size = new Size(36, 36);
            tsbAbrirDocumento.Text = "toolStripButton2";
            tsbAbrirDocumento.ToolTipText = "Abrir Documento";
            tsbAbrirDocumento.Click += tsbAbrirDocumento_Click;
            // 
            // tsbSalvarDocumento
            // 
            tsbSalvarDocumento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalvarDocumento.Enabled = false;
            tsbSalvarDocumento.Image = (Image)resources.GetObject("tsbSalvarDocumento.Image");
            tsbSalvarDocumento.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalvarDocumento.ImageTransparentColor = Color.Magenta;
            tsbSalvarDocumento.Name = "tsbSalvarDocumento";
            tsbSalvarDocumento.Size = new Size(36, 36);
            tsbSalvarDocumento.Text = "toolStripButton3";
            tsbSalvarDocumento.ToolTipText = "Salvar Documento";
            tsbSalvarDocumento.Click += tsbSalvarDocumento_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbInserir
            // 
            tsbInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbInserir.Enabled = false;
            tsbInserir.Image = (Image)resources.GetObject("tsbInserir.Image");
            tsbInserir.ImageScaling = ToolStripItemImageScaling.None;
            tsbInserir.ImageTransparentColor = Color.Magenta;
            tsbInserir.Name = "tsbInserir";
            tsbInserir.Size = new Size(36, 36);
            tsbInserir.Text = "toolStripButton1";
            tsbInserir.ToolTipText = "Inserir na Lista";
            tsbInserir.Click += tsbInserir_Click;
            // 
            // ofdAbrirDocumento
            // 
            ofdAbrirDocumento.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tosPrincipal);
            Controls.Add(rtbTexto);
            Name = "Form1";
            Text = "Form1";
            tosPrincipal.ResumeLayout(false);
            tosPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbTexto;
        private ToolStrip tosPrincipal;
        private ToolStripButton tsbNovoDocumento;
        private ToolStripButton tsbAbrirDocumento;
        private ToolStripButton tsbSalvarDocumento;
        private ToolStripSeparator toolStripSeparator1;
        private OpenFileDialog ofdAbrirDocumento;
        private SaveFileDialog sfdSalvarDocumento;
        private ToolStripButton tsbInserir;
    }
}
