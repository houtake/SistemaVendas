using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.Utils
{
    public static class EstiloBotoes
    {
        // Percorre todos os componentes da tela e aplica o evento nos botões
        //bizarro funcoes se auto chamar tecnologia e assustador
        public static void Aplicar(Control container)
        {
            foreach (Control controle in container.Controls)
            {
                if (controle is Button btn)
                {
                    btn.Paint += Botao_Paint;
                }
                else if (controle.HasChildren)
                {
                    // Se o botão estiver dentro de um Panel ou GroupBox, busca lá dentro também
                    Aplicar(controle);
                }
            }
        }

        private static void Botao_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            if (!btn.Enabled)
            {
                using (SolidBrush fundo = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillRectangle(fundo, btn.ClientRectangle);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    Color.Red,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}