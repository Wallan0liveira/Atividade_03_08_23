using AtividadeAvaliativa.Formularios;

namespace AtividadeAvaliativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExercicio1_Click(object sender, EventArgs e)
        {
            Atividade1 from = new Atividade1();
            from.ShowDialog();
        }

        private void btExercicio2_Click(object sender, EventArgs e)
        {
            Atividade2 from = new Atividade2();
            from.ShowDialog();
        }

        private void btExercicio3_Click(object sender, EventArgs e)
        {
            Atividade3 from = new Atividade3();
            from.ShowDialog();
        }
    }
}