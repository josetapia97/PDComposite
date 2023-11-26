using CompositeEmployes;
using CompositeEmployes.Elements;

var developer = new Employe("Tapita");
var seniorDev = new Manager("Nicolas Schurman");
var gerente = new Manager("Antonio");
var otroEmpleado = new Employe("Juanito");

seniorDev.AddMember(developer);
gerente.AddMember(seniorDev);
gerente.AddMember(otroEmpleado);

gerente.Display();