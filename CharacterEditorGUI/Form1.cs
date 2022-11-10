using Modelslib;

namespace CharacterEditorGUI
{
    public partial class Form1 : Form
    {
        private readonly Testdaten Testdaten; 

        public Form1()
        {
            InitializeComponent();
            Testdaten = TestdatenErzeuger.ErzeugeTestdaten();
            RefreshDataGridViews();
            RefreshCharacter();
        }

        private void RefreshDataGridViews()
        {
            dataGridView1.DataSource = Testdaten.Ruestungen;
            dataGridView2.DataSource = Testdaten.Waffen;
            dataGridView3.DataSource = Testdaten.Helme;
            dataGridView4.DataSource = Testdaten.Stiefel;

            dataGridView1.Refresh();
            dataGridView2.Refresh();
            dataGridView3.Refresh();
            dataGridView4.Refresh();

            dataGridView1.Update();
            dataGridView2.Update();
            dataGridView3.Update();
            dataGridView4.Update();
        }

        private void RefreshCharacter()
        {
            label1.Text = Testdaten.Character.Name;
            label2.Text = Testdaten.Character.Defense.ToString();
            label3.Text = Testdaten.Character.Attack.ToString();
            label4.Text = Testdaten.Character.Health.ToString();
        }

        private void SetGameObject(GameObject gameObject)
        {
            if (gameObject is Helm helm)
                Testdaten.Character.Helm = helm;
            else if (gameObject is Waffe waffe)
                Testdaten.Character.Waffe = waffe;
            else if (gameObject is Ruestung ruestung)
                Testdaten.Character.Ruestung = ruestung;
            else if (gameObject is Stiefel stiefel)
                Testdaten.Character.Stiefel = stiefel;

            RefreshCharacter();
        }
    }
}