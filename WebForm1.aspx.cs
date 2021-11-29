using System;

namespace CintaTrans
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void OnBtnCintaOffClick(object sender, EventArgs e)
        {
            rbCinta.Checked = false;
            Image1.ImageUrl = "~/Resource/brazo-sin-bulto.png";

            PublicarEstado();
        }
        protected void OnBtnCintaOnClick(object sender, EventArgs e)
        {
            rbCinta.Checked = true;
            Image1.ImageUrl = "~/Resource/brazo-bulto.png";

            PublicarEstado();
        }

        protected void OnBtnOffClick(object sender, EventArgs e)
        {
            rbEncendido.Checked = false;
            rbPrensa.Checked = false;
            rbCinta.Checked = false;
            rbPila.Checked = false;

            PublicarEstado();
        }

        protected void OnBtnOnClick(object sender, EventArgs e)
        {
            rbEncendido.Checked = true;
            Image1.ImageUrl = "~/Resource/brazo-sin-bulto.png";

            PublicarEstado();
        }

        protected void OnBtnPilaOffClick(object sender, EventArgs e)
        {
            rbPila.Checked = false;
            Image1.ImageUrl = "~/Resource/brazo-sin-bulto.png";
            var totalbultos = Convert.ToInt32(LabelTotalPila.Text);
            totalbultos += 1;
            LabelTotalPila.Text = totalbultos.ToString();

            PublicarEstado();
        }

        protected void OnBtnPilaOnClick(object sender, EventArgs e)
        {
            rbPila.Checked = true;
            Image1.ImageUrl = "~/Resource/brazo-bulto.png";
            PublicarEstado();
        }

        protected void OnBtnPrensaOffClick(object sender, EventArgs e)
        {
            rbPrensa.Checked = false;
            Image1.ImageUrl = "~/Resource/brazo-sin-bulto.png";

            PublicarEstado();
        }

        protected void OnBtnPrensaOnClick(object sender, EventArgs e)
        {
            rbPrensa.Checked = true;
            Image1.ImageUrl = "~/Resource/brazo-bulto.png";

            PublicarEstado();

        }

        private void PublicarEstado()
        {
            var oRobot = Robot.InstanciaUnica();

            oRobot.BEncendido = $"{Convert.ToInt16(rbEncendido.Checked)}";
            oRobot.BPrensa = $"{Convert.ToInt16(rbPrensa.Checked)}";
            oRobot.BCinta = $"{Convert.ToInt16(rbCinta.Checked)}";
            oRobot.BPila = $"{Convert.ToInt16(rbPila.Checked)}";
            oRobot.Apilados = $"{LabelTotalPila.Text}";
            Publicador.PublicarEstados(oRobot);
        }
    }
}