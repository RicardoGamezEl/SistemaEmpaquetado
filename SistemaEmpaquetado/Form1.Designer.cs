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
            lblBrazo = new Label();
            lblBanda = new Label();
            lblEstado = new Label();
            lblContador = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbBrazo = new ComboBox();
            cmbBanda = new ComboBox();
            btnActualizar = new Button();
            btnConectarBrazo = new Button();
            btnConectarBanda = new Button();
            btnIniciar = new Button();
            btnDetener = new Button();
            lstEventos = new ListBox();
            btnPruebaBrazo = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(190, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(425, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE EMPAQUETADO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrazo
            // 
            lblBrazo.AutoSize = true;
            lblBrazo.Location = new Point(26, 85);
            lblBrazo.Name = "lblBrazo";
            lblBrazo.Size = new Size(149, 20);
            lblBrazo.TabIndex = 1;
            lblBrazo.Text = "Brazo: Desconectado";
            lblBrazo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBanda
            // 
            lblBanda.AutoSize = true;
            lblBanda.Location = new Point(26, 127);
            lblBanda.Name = "lblBanda";
            lblBanda.Size = new Size(152, 20);
            lblBanda.TabIndex = 2;
            lblBanda.Text = "Banda: Desconectada";
            lblBanda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(190, 85);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(171, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado: Esperando Inicio";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(190, 127);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(137, 20);
            lblContador.TabIndex = 4;
            lblContador.Text = "Cajas Procesadas: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 85);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 5;
            label1.Text = "Puerto Brazo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 154);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Puerto Banda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBrazo
            // 
            cmbBrazo.FormattingEnabled = true;
            cmbBrazo.Location = new Point(446, 108);
            cmbBrazo.Name = "cmbBrazo";
            cmbBrazo.Size = new Size(151, 28);
            cmbBrazo.TabIndex = 7;
            // 
            // cmbBanda
            // 
            cmbBanda.FormattingEnabled = true;
            cmbBanda.Location = new Point(446, 189);
            cmbBanda.Name = "cmbBanda";
            cmbBanda.Size = new Size(151, 28);
            cmbBanda.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(117, 171);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(152, 29);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar Puertos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnConectarBrazo
            // 
            btnConectarBrazo.Location = new Point(609, 108);
            btnConectarBrazo.Name = "btnConectarBrazo";
            btnConectarBrazo.Size = new Size(152, 29);
            btnConectarBrazo.TabIndex = 10;
            btnConectarBrazo.Text = "Conectar Brazo";
            btnConectarBrazo.UseVisualStyleBackColor = true;
            btnConectarBrazo.Click += btnConectarBrazo_Click;
            // 
            // btnConectarBanda
            // 
            btnConectarBanda.Location = new Point(609, 188);
            btnConectarBanda.Name = "btnConectarBanda";
            btnConectarBanda.Size = new Size(152, 29);
            btnConectarBanda.TabIndex = 11;
            btnConectarBanda.Text = "Conectar Banda";
            btnConectarBanda.UseVisualStyleBackColor = true;
            btnConectarBanda.Click += btnConectarBanda_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(36, 228);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(152, 29);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar Sistema";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(199, 228);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(152, 29);
            btnDetener.TabIndex = 13;
            btnDetener.Text = "Detener Sistema";
            btnDetener.UseVisualStyleBackColor = true;
            // 
            // lstEventos
            // 
            lstEventos.Dock = DockStyle.Bottom;
            lstEventos.FormattingEnabled = true;
            lstEventos.Location = new Point(0, 266);
            lstEventos.Name = "lstEventos";
            lstEventos.Size = new Size(800, 184);
            lstEventos.TabIndex = 14;
            lstEventos.SelectedIndexChanged += lstEventos_SelectedIndexChanged;
            // 
            // btnPruebaBrazo
            // 
            btnPruebaBrazo.Location = new Point(609, 228);
            btnPruebaBrazo.Name = "btnPruebaBrazo";
            btnPruebaBrazo.Size = new Size(152, 29);
            btnPruebaBrazo.TabIndex = 15;
            btnPruebaBrazo.Text = "Probar Brazo";
            btnPruebaBrazo.UseVisualStyleBackColor = true;
            btnPruebaBrazo.Click += btnPruebaBrazo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPruebaBrazo);
            Controls.Add(lstEventos);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(btnConectarBanda);
            Controls.Add(btnConectarBrazo);
            Controls.Add(btnActualizar);
            Controls.Add(cmbBanda);
            Controls.Add(cmbBrazo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblContador);
            Controls.Add(lblEstado);
            Controls.Add(lblBanda);
            Controls.Add(lblBrazo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblBrazo;
        private Label lblBanda;
        private Label lblEstado;
        private Label lblContador;
        private Label label1;
        private Label label2;
        private ComboBox cmbBrazo;
        private ComboBox cmbBanda;
        private Button btnActualizar;
        private Button btnConectarBrazo;
        private Button btnConectarBanda;
        private Button btnIniciar;
        private Button btnDetener;
        private ListBox lstEventos;
        private Button btnPruebaBrazo;
    }
}
