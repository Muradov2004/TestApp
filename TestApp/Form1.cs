namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Question1()
        {
            Quest1A.BackColor = Color.Red;
            Quest1CheckBoxA.BackColor = Color.Red;
            Quest1B.BackColor = Color.Red;
            Quest1CheckBoxB.BackColor = Color.Red;
            Quest1C.BackColor = Color.Green;
            Quest1CheckBoxC.BackColor = Color.Green;
        }

        private void Question2()
        {
            Quest2A.BackColor = Color.Green;
            Quest2CheckBoxA.BackColor = Color.Green;
            Quest2B.BackColor = Color.Red;
            Quest2CheckBoxB.BackColor = Color.Red;
            Quest2C.BackColor = Color.Red;
            Quest2CheckBoxC.BackColor = Color.Red;
        }

        private void Question3()
        {
            Quest3A.BackColor = Color.Red;
            Quest3CheckBoxA.BackColor = Color.Red;
            Quest3B.BackColor = Color.Green;
            Quest3CheckBoxB.BackColor = Color.Green;
            Quest3C.BackColor = Color.Red;
            Quest3CheckBoxC.BackColor = Color.Red;
        }

        private void Quest1CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (Quest1CheckBoxA.Checked || Quest1CheckBoxB.Checked || Quest1CheckBoxC.Checked)
                Question1();
        }

        private void Quest2CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (Quest2CheckBoxA.Checked || Quest2CheckBoxB.Checked || Quest2CheckBoxC.Checked)
                Question2();
        }

        private void Quest3CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (Quest3CheckBoxA.Checked || Quest3CheckBoxB.Checked || Quest3CheckBoxC.Checked)
                Question3();
        }

    }
}