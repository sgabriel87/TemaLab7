/*Un autoturism detine un motor precum si un numar de
usi. De asemenea autovehiculul este caracterizat de marca,
model si an de fabricatie
• Motorul
 este caracterizat de
 Capacitate cilindrica
 Putere
 Tipul combustibilului
 Detine functii pentru
 Pornirea motorului
 la apelul acestei functii motorul va afisa in consola “brr”
 Oprire a motorului
 la apelul acestei functii motorul va afisa in consola “par poc
pac”
• Usa va detina doua metode
 Deschide
 La apelul acestei metode usa va afisa in consola “click”
 Inchide
 La apelul acestei metode usa va afisa in consola “clack”
• Autoturismul va avea urmatoarele metode/proprietati
 GetDescription
 Va returna descrierea complete a autovehicolului sub forma unui
sir de caractere
 “Marca, model, anDeFabricatie, capacitate cilindrica,
combustibil, putere motor, numar de usi
 Porneste masina
 Va afisa textul “masina porneste” , va inchide usile si va porni
motorul
 Opreste masina
 Va afisa textul “masina se opreste”, va opri motorul si va inchide
usile*/

using TemaLab7;


Car car = new("Audi", "R8", 2020, 5200, "Gas", 541, 2);
Console.WriteLine(car.GetDescription());

car.StartCar();
Console.WriteLine("\nCar travels...");
car.StopCar();

