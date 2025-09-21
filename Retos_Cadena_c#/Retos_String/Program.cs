// See https://aka.ms/new-console-template for more information

//Retos de cadena en C#
//ID: 11

//Insertando texto en una cadena
string Cuento = "";
try
{
    Cuento = File.ReadAllText(@"C:\Users\FLIA PEREZ\Desktop\U.T.P\4° SEMESTRE 2025\DES. SOFT. IV\cuento.txt");
    //Console.WriteLine(Cuento);

    Console.WriteLine("Retos de Cadenas en C# \n"); //Titulo principal

    //Crecion y conversión
    //1. string Concat(): Une el nombre Bitin con la palabra explorador
    string Conc_nombre_pal = string.Concat("Bitín" + " explorador");
    Console.WriteLine("Reto 1: " + Conc_nombre_pal);

    //2. Separa el cuento por "." y luego une con "|"
    String[] oraciones = Cuento.Split(".");
    string Separacion_cuento = string.Join("|", oraciones);
    Console.WriteLine("\nReto 2: " + Separacion_cuento);

    //3. Conteo de caracteres y palabras usando el formato string.format
    int carcter = Cuento.Length;
    int palabras = Cuento.Split(new char[] { ' ', '\n' },
        StringSplitOptions.RemoveEmptyEntries).Length;
    string Usoformat = string.Format($"El cuento tiene {carcter} caracteres y {palabras} palabras");
    Console.WriteLine("\nReto 3: " + Usoformat);

    //4. uso de interpolacion para mostrar el nombre del protagonista y busca {meta} 
    string nombre = "Bitín";
    string meta = "meta";
    string Interpolacion = $"\nReto 4: {nombre} {meta}";
    Console.WriteLine(Interpolacion);

    //5. convertir un numero a cadena y muestralo concatenado. 
    int longitud_cuento = Cuento.Length; //obtenemos la logitud del cuento
    string longitud_string = longitud_cuento.ToString();
    Console.WriteLine("\nReto 5: La longitud del cuento es " + longitud_string);

    //Busqueda y localizacion
    //6. Encuentra la localizacion de la primera palabra mundo
    int Localizacion_mundo = Cuento.IndexOf("mundo");
    Console.WriteLine("\nReto 6: la primera posición encontrada es: " + Localizacion_mundo);
    char caracterEnPosicion = Cuento[Localizacion_mundo];
    Console.WriteLine("El carácter en esa posición es: " + caracterEnPosicion);

    //7. Encuentra la ultima vez en que aparece la palabara ceros
    int posicion_ceros = Cuento.LastIndexOf("ceros");
    Console.WriteLine("\nReto 7: Ultima posicion de ceros: " + posicion_ceros);

    //8. Verifica si en el cuento aparece la palabara nube y envia un mesaje de confirmacion
    bool confirmacion = Cuento.Contains("Nube");
    Console.WriteLine("\nReto 8: Resultado: " + (confirmacion ? "El cuento si menciona Nube" : "El cuento No menciona Nube"));

    //9. Comprabacion del inicio del cuento, si inicia con Vasto Universo
    bool confirmacion2 = Cuento.StartsWith("En el vasto universo");
    Console.WriteLine("\nReto 9: Resultado: " + (confirmacion2 ? "Si incia asi" : "No incia asi."));

    //10. Comprabacion si el cuento termina con ceros y uno
    bool comprobacion3 = Cuento.Trim().EndsWith("ceros y unos.");
    Console.WriteLine("\nReto 10: Resultado: " + (comprobacion3 ? "Sí termina así" : "No termina así"));

    //Manipulacion de contenido 
    //11. Extrae la palabra ciudades luminosa del texto original 
    int ciudades = Cuento.IndexOf("ciudades luminosas");
    string Extraer_palabra = Cuento.Substring(ciudades, "ciudades luminosas".Length);
    Console.WriteLine("\nReto 11: Extraer --Ciudades Luminosas--: " + Extraer_palabra);

    //12. Elimina los primeros 15 caracteres del cuento
    string delete = Cuento.Remove(0, 15);
    Console.WriteLine("\nReto 12: Quitar los primeros caracteres: " + delete);

    //13. Sustituye todas la primeras palabras de Bitin po ProgramarX
    string Uso_replace = Cuento.Replace("Bitín", "ProgramarX");
    Console.WriteLine("\nReto 13: Cuentos despues del Remplazo:  \n" + Uso_replace);

    //14. Inserta importante despues de Firewall
    int Posicion_firewall = Cuento.IndexOf("firewall") + "firewall".Length;
    string Insertar_cuento = Cuento.Insert(Posicion_firewall, "(IMPORTANTE)");
    Console.WriteLine("\nReto 14: Cambio de Firewall mas IMPORTANTE\n" + Insertar_cuento);

    //15: Rellenar Bitin con * a la izquierda hasta 10 caracteres
    string rellenar = "Bitín".PadLeft(15, '*');
    Console.WriteLine("\nReto 15: Insertar * al lado de Bitin.\n" + rellenar);

    //16: Rellenar Nube  con - con 10 de estos. 
    int localizar_Nube = Cuento.IndexOf("Nube");
    string palabranube = Cuento.Substring(localizar_Nube, "Nube".Length);
    string rellenarderecha = palabranube.PadLeft(15, '-');
    Console.WriteLine("\nReto 15: Rellenar la palabra nube.\n" + rellenarderecha);

    //17: Toma un fragmento con con espacios extras y elimina los espacios
    string fraseTrim = "     " + oraciones[1] + "     ";
    Console.WriteLine("\nReto 17: " + fraseTrim.Trim());

    //18: Elimina los espacios iniciles de la frase de Mundo Binario
    string Uso_TrimStart = "   Mundo binario".TrimStart();
    Console.WriteLine("\nReto 18: Eliminar espacio solo al incio: " + Uso_TrimStart);

    //19: Elimina solo espacios finales de "Bitin Explorador"
    string Uso_TrimEnd = "Bitín explorador   ".TrimEnd();
    Console.WriteLine("\nReto 19: Eliminar datos finales: " + Uso_TrimEnd);

    //20: Divide el cuento en palabras individuales y muestra las primeras 10
    string[] palabrasSplit = Cuento.Split(' ', '\n');
    string Uso_split = string.Join(", ", palabrasSplit.Take(10));
    Console.WriteLine("\nReto 20. Mostrar las primeras 10 palabras individuales: " + Uso_split);

    //21: Comparación si Nube y nube son iguales
    bool es_Igual = "Nube".Equals("nube");
    Console.WriteLine("\nReto 21: " + (es_Igual ? "Son Iguales" : "Es Diferente"));

    //22: Comparacion de Bitin con Firewall e indica cual va de primero
    int comparacion = string.Compare("Bitin", "Firewall");
    Console.WriteLine("\nReto 22: La compracion es y va de primero: " + comparacion);

    //23: CompareTo(): Compara "Nube" y "Cielo"
    int Uso_CompareTo = "Nube".CompareTo("cielo");
    Console.WriteLine("\nReto 23: El resultado fue: " + Uso_CompareTo);

    //24. Declara una variable vacia e indica si lo es 
    string Variable_vacia = "";
    bool Es_vacia = string.IsNullOrWhiteSpace(Variable_vacia);
    Console.WriteLine("\nReto 24: La variable es: " + (Es_vacia ? "Cadena Vacia" : "Cadena No Vacia"));

    //25. Declara  una variable con solo espacios y verifica el resultado
    string Solo_Espacios = "      ";
    bool es_espacio = string.IsNullOrWhiteSpace(Solo_Espacios);
    Console.WriteLine("\nReto 25: La variable es: " + (es_espacio ? "Solo espacio" : "No lo es"));

    //26. Convierte todo el cuento en miniscula 
    Console.WriteLine("\nReto 26: Cuento en minisculas.\n" + Cuento.ToLower());

    //27. convierte todo el cuento en maysuculas
    Console.WriteLine("\nReto 27: Cuento en mayusculas.\n " + Cuento.ToUpper());

    //28. conviete la palabra NUBE en Minisculas
    Console.WriteLine("\nReto 28: la palabra NUBE en Minisculas: " + "NUBE".ToLowerInvariant());

    //29. Convierte bitin a mayusculas
    Console.WriteLine("\nReto 29: Bitin a mayusculas: " + "bitin".ToUpperInvariant());

}
catch (FileNotFoundException)
{
    Console.WriteLine("No se encontro el archivo especificado");
}
catch(UnauthorizedAccessException)
{
    Console.WriteLine("No se tiene permiso para acceder a leer el archivo"); 
}