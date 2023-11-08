
// A matriz nossosAnimais vai guardar essas variaveis
string animalEspecie = "";
string animalID = "";
string animalIdade = "";
string animalDescricaoFisica = "";
string animalPersonalidade = "";
string animalApelido = "";
string sugestaoDoacao = "";

//Variáveis que dão suporte a entrada de dados
int maximoPets = 10;
string? lerResultado;
string selecaoMenu = "";
decimal doacaoDecimal = 0.00m;


string[,] nossosAnimais = new string[maximoPets, 7];

for (int i = 0; i < maximoPets; i++)
{
    switch (i)
    {
        case 0:
            animalID = "c1";
            animalEspecie = "cachorro";
            animalIdade = "10";
            animalApelido = "Apolo";
            animalDescricaoFisica = "Médio / cinza / macho / Schnauzer / 8,2 kg";
            animalPersonalidade = "ranzinza e carente, ama atenção e ficar perto.";
            sugestaoDoacao = "158,30";
            break;



        case 1:
            animalID = "g2";
            animalEspecie = "gato";
            animalIdade = "5";
            animalApelido = "Askov";
            animalDescricaoFisica = "Grande / Branco / Macho / Olhos azuis / 7 kg";
            animalPersonalidade = "ansioso, estressado e odeia tudo que sai da rotina.";
            sugestaoDoacao = "49,99";
            break;


        case 2:
            animalID = "g3";
            animalEspecie = "gato";
            animalIdade = "7";
            animalApelido = "Mica";
            animalDescricaoFisica = "Pequena / Branca com manchas pretas / Fêmea / Olhos cor de mel / 4 kg";
            animalPersonalidade = "Extremamente carinhosa, brincalhona e ama caçar.";
            sugestaoDoacao = "65,25";
            break;

        case 3:
            animalID = "c4";
            animalEspecie = "cachorro";
            animalIdade = "2";
            animalApelido = "Maria Antonella";
            animalDescricaoFisica = "pequena / branca / femea / lulu";
            animalPersonalidade = "estressada e brava";
            sugestaoDoacao = "235,40";
            break;

        default:
            animalID = "";
            animalEspecie = "";
            animalIdade = "";
            animalApelido = "";
            animalDescricaoFisica = "";
            animalPersonalidade = "";
            sugestaoDoacao = "";
            break;
    }

    nossosAnimais[i, 0] = "ID #: " + animalID;
    nossosAnimais[i, 1] = "Espécie: " + animalEspecie;
    nossosAnimais[i, 2] = "Idade: " + animalIdade;
    nossosAnimais[i, 3] = "Apelido: " + animalApelido;
    nossosAnimais[i, 4] = "Descrição física: " + animalDescricaoFisica;
    nossosAnimais[i, 5] = "Personalidade: " + animalPersonalidade;

    if (!decimal.TryParse(sugestaoDoacao, out doacaoDecimal))
    {
        doacaoDecimal = 45.00m; 
        //Se a sugestão de doação não for um número, o valor vai ser R$ 45,00 por padrão.
    }

    nossosAnimais[i, 6] = $"Sugestão de doação: {doacaoDecimal:C2}";
}


void ExibirLogo()
{
    Console.WriteLine(@"        

░█████╗░██████╗░░█████╗░████████╗░█████╗░  ██████╗░███████╗████████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝╚══██╔══╝██╔════╝
███████║██║░░██║██║░░██║░░░██║░░░███████║  ██████╔╝█████╗░░░░░██║░░░╚█████╗░
██╔══██║██║░░██║██║░░██║░░░██║░░░██╔══██║  ██╔═══╝░██╔══╝░░░░░██║░░░░╚═══██╗
██║░░██║██████╔╝╚█████╔╝░░░██║░░░██║░░██║  ██║░░░░░███████╗░░░██║░░░██████╔╝
╚═╝░░╚═╝╚═════╝░░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░░░░╚══════╝░░░╚═╝░░░╚═════╝░        
");

    Console.WriteLine("Boas vindas ao seu sistema de adoção preferido!!");
}


//Opções do menu principal
do
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine();
    Console.WriteLine("============= MENU PRINCIPAL ================");
    Console.WriteLine();
    Console.WriteLine("[1] Exibir informações completas sobre os pets.");
    Console.WriteLine("[2] Exibir todos os cães que possuem uma característica específica.");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada (ou digite Sair para finalizar o programa)");
    lerResultado = Console.ReadLine();

    if (lerResultado != null)
    {
        selecaoMenu = lerResultado.ToLower();
    }

    switch (selecaoMenu)
    {
        case "1":
            //Exibe informações completas sobre os pets.
            Console.Clear();
            Console.WriteLine("============= INFORMAÇÕES COMPLETAS ================");
            for (int i = 0; i < maximoPets; i++)
            {
                if (nossosAnimais[i, 0] != "ID #: ")
                {
                    Console.WriteLine();

                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(nossosAnimais[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\n\rPressione Enter para continuar.");
            lerResultado = Console.ReadLine();
            break;

        case "2":
            //Exibe todos os cães com a característica específica digitada.
            Console.Clear();
            Console.WriteLine("============= PESQUISA DE CARACTERÍSTICA DE CÃES ================");
            string caracteristicasEspecificas = "";

            while (caracteristicasEspecificas == "")
            {
                Console.WriteLine($"\nInsira as características específicas que deseja procurar separadas por vírgulas.");
                lerResultado = Console.ReadLine();

                if (lerResultado != null)
                {
                    caracteristicasEspecificas = lerResultado.ToLower();
                    Console.WriteLine();
                }
            }

            //Split remove a vírgula e exibe as caracteristica em lista
            string[] pesquisaDeCaes = caracteristicasEspecificas.Split(",");

            //Apaga os espaços do início e do fim de cada característica digitada
            for (int i = 0; i < pesquisaDeCaes.Length; i++)
            {
                //Trim apaga os espaços
                pesquisaDeCaes[i] = pesquisaDeCaes[i].Trim();
            }
            
            //Sort classifica a matriz em ordem alfabética
            Array.Sort(pesquisaDeCaes);


            //Cria uma animação que "roda" enquanto a pesquisa é feita
            string[] iconesPesquisando = { " |", " /", "--", " \\", " *" };

            bool correspondeComAlgumCao = false;
            string descricaoDoCao = "";

            //Loop pela matriz nossoAnimais para pesquisar se algum cão corresponde a caracteristica especifica
            for (int i = 0; i < maximoPets; i++)
            {
                if (nossosAnimais[i, 1].Contains("cachorro"))
                {
                    //Pesquisa as descrições que combinam e mostra o resultado
                    descricaoDoCao = nossosAnimais[i, 4] + "\n" + nossosAnimais[i, 5];
                    bool correspondeComCaoAtual = false;

                    foreach (string item in pesquisaDeCaes)
                    {
                        if (item != null && item.Trim() != "")
                        {
                            for (int j = 2; j > -1; j--)
                            {
                                //Atualiza a mensagem de "pesquisando" para mostrar a contagem
                                foreach (string icone in iconesPesquisando)
                                {
                                    Console.Write($"\rPesquisando nosso cão {nossosAnimais[i, 3]} para {item.Trim()} {icone} {j}");
                                    Thread.Sleep(100);
                                }

                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            //Itera os termos de características enviados
                            if (descricaoDoCao.Contains(" " + item.Trim() + " "))
                            {
                                //Atualiza a mensagem para corresponder com o termo de pesquisa atual
                                Console.WriteLine($"\rNosso cão - {nossosAnimais[i, 3]} - corresponde com sua pesquisa de {item.Trim()}");

                                correspondeComCaoAtual = true;
                                correspondeComAlgumCao = true;
                            }
                        }
                    }

                    //Se o cão atual corresponde, exibe as informações do cão
                    if (correspondeComCaoAtual)
                    {
                        Console.WriteLine($"\r{nossosAnimais[i, 3]} ({nossosAnimais[i, 0]})\n{descricaoDoCao}\n");
                    }
                }
            }

            if (!correspondeComAlgumCao)
            {
                Console.WriteLine("Nenhum de nossos cães corresponde com: " + caracteristicasEspecificas);
            }

            Console.WriteLine("\n\rPressione Enter para continuar");
            lerResultado = Console.ReadLine();

            break;

        default:
            break;
    }

}
while (selecaoMenu != "sair");



