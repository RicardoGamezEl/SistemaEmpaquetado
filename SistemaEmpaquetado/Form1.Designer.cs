namespace SistemaEmpaquetado
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
            lblTitulo = new Label();
            lblEstado = new Label();
            lblContador = new Label();
            lstEventos = new ListBox();
            btnPruebaBrazo = new Button();
            btnDetener = new Button();
            btnIniciar = new Button();
            btnActualizar = new Button();
            btnConectarBanda = new Button();
            btnConectarBrazo = new Button();
            cmbBanda = new ComboBox();
            cmbBrazo = new ComboBox();
            panelBanda = new Panel();
            panelBrazo = new Panel();
            lblBrazo = new Label();
            lblBanda = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DodgerBlue;
            lblTitulo.Location = new Point(300, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(561, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE EMPAQUETADO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEstado.ForeColor = Color.Transparent;
            lblEstado.Location = new Point(409, 166);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(361, 41);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado: Esperando Inicio";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Click += lblEstado_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblContador.ForeColor = Color.Transparent;
            lblContador.Location = new Point(409, 213);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(287, 41);
            lblContador.TabIndex = 4;
            lblContador.Text = "Cajas Procesadas: 0";
            lblContador.Click += lblContador_Click;
            // 
            // lstEventos
            // 
            lstEventos.BackColor = Color.Black;
            lstEventos.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEventos.ForeColor = Color.Lime;
            lstEventos.FormattingEnabled = true;
            lstEventos.Location = new Point(786, 177);
            lstEventos.Name = "lstEventos";
            lstEventos.Size = new Size(384, 464);
            lstEventos.TabIndex = 14;
            lstEventos.SelectedIndexChanged += lstEventos_SelectedIndexChanged;
            // 
            // btnPruebaBrazo
            // 
            btnPruebaBrazo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPruebaBrazo.AutoSize = true;
            btnPruebaBrazo.BackColor = Color.Transparent;
            btnPruebaBrazo.FlatAppearance.BorderColor = Color.Black;
            btnPruebaBrazo.FlatAppearance.BorderSize = 2;
            btnPruebaBrazo.FlatStyle = FlatStyle.Flat;
            btnPruebaBrazo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPruebaBrazo.Location = new Point(409, 503);
            btnPruebaBrazo.Name = "btnPruebaBrazo";
            btnPruebaBrazo.Size = new Size(349, 34);
            btnPruebaBrazo.TabIndex = 15;
            btnPruebaBrazo.Text = "Probar Brazo";
            btnPruebaBrazo.UseVisualStyleBackColor = false;
            btnPruebaBrazo.Click += btnPruebaBrazo_Click;
            // 
            // btnDetener
            // 
            btnDetener.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDetener.AutoSize = true;
            btnDetener.BackColor = Color.Transparent;
            btnDetener.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnDetener.FlatAppearance.BorderSize = 2;
            btnDetener.FlatStyle = FlatStyle.Flat;
            btnDetener.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDetener.Location = new Point(409, 463);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(349, 34);
            btnDetener.TabIndex = 13;
            btnDetener.Text = "Detener Sistema";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciar.AutoSize = true;
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnIniciar.FlatAppearance.BorderSize = 2;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciar.Location = new Point(409, 422);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(349, 35);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar Sistema";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 128, 255);
            btnActualizar.FlatAppearance.BorderColor = Color.Blue;
            btnActualizar.FlatAppearance.BorderSize = 2;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizar.Location = new Point(178, 503);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(157, 34);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar Puertos";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnConectarBanda
            // 
            btnConectarBanda.BackColor = Color.FromArgb(128, 128, 255);
            btnConectarBanda.FlatAppearance.BorderColor = Color.Blue;
            btnConectarBanda.FlatAppearance.BorderSize = 2;
            btnConectarBanda.FlatStyle = FlatStyle.Flat;
            btnConectarBanda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConectarBanda.Location = new Point(178, 463);
            btnConectarBanda.Name = "btnConectarBanda";
            btnConectarBanda.Size = new Size(157, 34);
            btnConectarBanda.TabIndex = 11;
            btnConectarBanda.Text = "Conectar Banda";
            btnConectarBanda.UseVisualStyleBackColor = false;
            btnConectarBanda.Click += btnConectarBanda_Click;
            // 
            // btnConectarBrazo
            // 
            btnConectarBrazo.BackColor = Color.FromArgb(128, 128, 255);
            btnConectarBrazo.FlatAppearance.BorderColor = Color.Blue;
            btnConectarBrazo.FlatAppearance.BorderSize = 2;
            btnConectarBrazo.FlatStyle = FlatStyle.Flat;
            btnConectarBrazo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConectarBrazo.Location = new Point(178, 422);
            btnConectarBrazo.Name = "btnConectarBrazo";
            btnConectarBrazo.Size = new Size(157, 35);
            btnConectarBrazo.TabIndex = 10;
            btnConectarBrazo.Text = "Conectar Brazo";
            btnConectarBrazo.UseVisualStyleBackColor = false;
            btnConectarBrazo.Click += btnConectarBrazo_Click;
            // 
            // cmbBanda
            // 
            cmbBanda.BackColor = Color.FromArgb(26, 32, 44);
            cmbBanda.FlatStyle = FlatStyle.Flat;
            cmbBanda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbBanda.ForeColor = Color.Transparent;
            cmbBanda.FormattingEnabled = true;
            cmbBanda.Location = new Point(30, 467);
            cmbBanda.Name = "cmbBanda";
            cmbBanda.Size = new Size(142, 28);
            cmbBanda.TabIndex = 8;
            // 
            // cmbBrazo
            // 
            cmbBrazo.BackColor = Color.FromArgb(26, 32, 44);
            cmbBrazo.FlatStyle = FlatStyle.Flat;
            cmbBrazo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbBrazo.ForeColor = Color.Transparent;
            cmbBrazo.FormattingEnabled = true;
            cmbBrazo.Location = new Point(30, 426);
            cmbBrazo.Name = "cmbBrazo";
            cmbBrazo.Size = new Size(142, 28);
            cmbBrazo.TabIndex = 7;
            // 
            // panelBanda
            // 
            panelBanda.BackColor = Color.Red;
            panelBanda.BorderStyle = BorderStyle.FixedSingle;
            panelBanda.Location = new Point(30, 223);
            panelBanda.Name = "panelBanda";
            panelBanda.Size = new Size(20, 20);
            panelBanda.TabIndex = 16;
            // 
            // panelBrazo
            // 
            panelBrazo.BackColor = Color.Red;
            panelBrazo.BorderStyle = BorderStyle.FixedSingle;
            panelBrazo.Font = new Font("Segoe UI", 9F);
            panelBrazo.Location = new Point(30, 178);
            panelBrazo.Name = "panelBrazo";
            panelBrazo.Size = new Size(20, 20);
            panelBrazo.TabIndex = 17;
            // 
            // lblBrazo
            // 
            lblBrazo.AutoSize = true;
            lblBrazo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrazo.Location = new Point(56, 166);
            lblBrazo.Name = "lblBrazo";
            lblBrazo.Size = new Size(309, 41);
            lblBrazo.TabIndex = 1;
            lblBrazo.Text = "Brazo: Desconectado";
            lblBrazo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBanda
            // 
            lblBanda.AutoSize = true;
            lblBanda.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBanda.Location = new Point(56, 213);
            lblBanda.Name = "lblBanda";
            lblBanda.Size = new Size(316, 41);
            lblBanda.TabIndex = 2;
            lblBanda.Text = "Banda: Desconectada";
            lblBanda.TextAlign = ContentAlignment.MiddleCenter;
            lblBanda.Click += lblBanda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 92, 106);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 10F);
            panel2.Location = new Point(30, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 51);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(253, 23);
            label1.TabIndex = 0;
            label1.Text = "CONFIGURACION Y CONEXION";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(74, 92, 106);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Segoe UI", 10F);
            panel3.Location = new Point(409, 365);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 51);
            panel3.TabIndex = 23;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(0, 18);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 0;
            label2.Text = "CONTROL DEL SISTEMA";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 92, 106);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(30, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 51);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(0, 16);
            label3.Name = "label3";
            label3.Size = new Size(173, 23);
            label3.TabIndex = 0;
            label3.Text = "ESTADO DEL EQUIPO";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(74, 92, 106);
            panel4.Controls.Add(label4);
            panel4.Font = new Font("Segoe UI", 10F);
            panel4.Location = new Point(409, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 51);
            panel4.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(230, 23);
            label4.TabIndex = 0;
            label4.Text = "METRICAS DE PRODUCCION";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(74, 92, 106);
            panel5.Controls.Add(label5);
            panel5.Font = new Font("Segoe UI", 10F);
            panel5.Location = new Point(786, 112);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 51);
            panel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(190, 23);
            label5.TabIndex = 0;
            label5.Text = "REGISTRO DE EVENTOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(1182, 653);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(lblContador);
            Controls.Add(lblEstado);
            Controls.Add(lblBanda);
            Controls.Add(panel3);
            Controls.Add(lblBrazo);
            Controls.Add(panelBrazo);
            Controls.Add(panel2);
            Controls.Add(panelBanda);
            Controls.Add(btnIniciar);
            Controls.Add(cmbBrazo);
            Controls.Add(cmbBanda);
            Controls.Add(btnDetener);
            Controls.Add(btnConectarBrazo);
            Controls.Add(btnConectarBanda);
            Controls.Add(btnPruebaBrazo);
            Controls.Add(btnActualizar);
            Controls.Add(lstEventos);
            Controls.Add(lblTitulo);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEstado;
        private Label lblContador;
        private ListBox lstEventos;
        private Button btnPruebaBrazo;
        private Button btnDetener;
        private Button btnIniciar;
        private Button btnActualizar;
        private Button btnConectarBanda;
        private Button btnConectarBrazo;
        private ComboBox cmbBanda;
        private ComboBox cmbBrazo;
        private Panel panelBanda;
        private Panel panelBrazo;
        private Label lblBrazo;
        private Label lblBanda;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
    }
}
