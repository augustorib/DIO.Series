using DIO.Series.Classes;

 
 string opcaoUsuario = programOperations.ObterOpcaoUsuario();

    while (opcaoUsuario.ToUpper() != "X")
    {
        switch (opcaoUsuario)
        {
            case "1":
                programOperations.ListarSeries();
                break;
            case "2":
                programOperations.InserirSerie();
                break;
            case "3":
                programOperations.AtualizarSerie();
                break;
            case "4":
                programOperations.ExcluirSerie();
                break;
            case "5":
                programOperations.VisualizarSerie();
                break;
            case "C":
                Console.Clear();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        opcaoUsuario = programOperations.ObterOpcaoUsuario();
    }

    Console.WriteLine("Obrigado por utilizar nossos serviços.");
    Console.ReadLine();

 