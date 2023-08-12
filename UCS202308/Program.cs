using UCS202308;

Pessoa p1 = new Pessoa();

p1.Nome = "Felipe";

p1.SobreNome = "Guerra";

Console.WriteLine($"Meu nome é {p1.Nome} e meu sobrenome é {p1.SobreNome}");

Cliente c1 = new Cliente();

c1.Nome = p1.Nome;
c1.SobreNome = p1.SobreNome;
c1.Idade = p1.Idade;
c1.Limite = 200;