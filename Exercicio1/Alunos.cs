namespace Exercicio1
{
    public class Aluno
    {
        private string matricula, nome;
        private double notaP1, notaP2, notaT;

        public Aluno(string Matricula, string Nome, double NotaP1, double NotaP2, double NotaT)
        {
            matricula = Matricula;
            nome = Nome;
            this.notaP1 = NotaP1;
            this.notaP2 = NotaP2;
            this.notaT = NotaT;
        }
        public void Media()
        {
            double media = (notaP1 + notaP2 + notaT) / 3;

            if (media > 5)
            {
                Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula}\nMédia: {media:00.00}\n_APROVADO!_");
            }
            else
            {
                Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula}\nMédia: {media:00.00}\nPrecisa de {5 - media:00.00} para ser aprovado no exame final.");
            }
        }
    }
}
