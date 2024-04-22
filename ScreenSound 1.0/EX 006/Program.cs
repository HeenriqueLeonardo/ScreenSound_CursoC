void LOGO () { Console.WriteLine(@"
███████╗░█████╗░░█████╗░███████╗████████╗██████╗░██╗░░░██╗░██████╗░██╗░░░██╗███████╗
██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║░░░██║██╔═══██╗██║░░░██║██╔════╝
█████╗░░███████║██║░░╚═╝█████╗░░░░░██║░░░██████╔╝██║░░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░██╔══██║██║░░██╗██╔══╝░░░░░██║░░░██╔══██╗██║░░░██║╚██████╔╝██║░░░██║██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝███████╗░░░██║░░░██║░░██║╚██████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░░░░╚═╝░░░░╚═════╝░╚══════╝"); }

Dictionary<string, List<string>> Login = new Dictionary<string, List<string>>();
void MenuPrincipal()
{
    Console.Clear();
    LOGO();
    Console.WriteLine("(1) Fazer Login\n(2) Cadastrar usuario\n(0) Fechar programa\n");
    int escolha = 0;
    int.TryParse(Console.ReadLine(), out escolha);

    switch(escolha)
    {
        case 0: Console.WriteLine("Até mais!");
            break;
        case 1: RealizarLogin(); break;
        case 2: CadastroDeUsuario(); break; 
    }
}
void CadastroDeUsuario()
{
    Console.Write("Crie seu Login\nUsuario: ");

    string Usuario = Console.ReadLine();
    if (Login.ContainsKey(Usuario))
    {
        Console.WriteLine("Este usuário já está cadastrado. Tente outro usuário.");
        Thread.Sleep(2000);
        MenuPrincipal();
    }
    
    else
    {
        Console.Write("Senha: ");
        string Senha = Console.ReadLine();

        Login.Add(Usuario, new List<string> { Senha });
        Console.WriteLine($"Usuario {Usuario} cadastrado com sucesso!");
        Thread.Sleep(2000);
        MenuPrincipal();
    }
}
void RealizarLogin()
{
    do
    {
        Console.WriteLine("Realize o Login \n (0) Volta ao Menu");
        Console.Write("Usuario: ");
        string Usuario = Console.ReadLine();
        Console.Write("Senha: ");
        string Senha = Console.ReadLine();

        if (Login.ContainsKey(Usuario))
        {
            List<string> senhas;
            Login.TryGetValue(Usuario, out senhas);
            if (senhas.Contains(Senha))
            {
                Console.WriteLine($"Olá {Usuario}, seja bem-vindo!");
                break;
            }
            else
            {
                Console.WriteLine("Senha incorreta Tente novamente");
            }
        }
        else if (Usuario == "0")
        {
            MenuPrincipal();
        }
        else
        {
            Console.WriteLine("Usuário incorreto \nTente novamente");
        }
    }while(true);
    Thread.Sleep(2000);
    MenuPrincipal();
    

}

MenuPrincipal();
