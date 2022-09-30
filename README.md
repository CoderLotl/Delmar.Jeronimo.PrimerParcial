# 2do D - Primer Parcial

# Delmar.Jeronimo.PrimerParcial
1st Exam - 2022


Title: "1st Exam, 2ºD, 2022 - Magical Turkish Airlines"
    
    

//------------------------------
    
About me:

My name is Jerónimo Delmar and (as you may probably know) I'm a 1st year Programming student at UTN-FRA.
Prior to this I never had any contact with programming, although I have a wide and general experience with mechanic and electronic devices.
This project posed a real challenge, as I can generally visualize mechanic blocks, but I had 0 knowledge about MVSC, Windows Forms, and interface controls
and how to deal with them. I resulted into a thrilling, intense, exhaustive, and fun experience.

NOTE: I still think passengers should have Health Points and faint (at least) during the trip. Traveling is tiring.
    
    
    
Diagrama de clases: Pegar una foto del diagrama de clases correspondiente a la lógica de negocio. Se debe construir con la herramienta de Visual Studio 
y deberá estar actualizado a la última versión entregada de la solución.


Subject 1: "Introduction to .NET & C#"
    
- Time and dates: the premise asks from us to show the current Date in the taskbar using the short format, so it's obviously shown there.
Beyond that, every flight has a departure date and an arrival date, calculated from a random year, day, month, hour, minute, and second, a random duration
in minutes, and from there summing the duration to the departure date you get the arrival date.
This is applied both in the creation of flights by the user, and the automatic hardcoding at the start of the program.
    
- StringBuilder: it's used together with the override to the ToString() method in order to turn objects into their mere string data and return it.
Using the (controversial) technique of appending a special character with each block of data and then splitting the whole string using that character
as parameter, I was able to transform the text returned back to its bits.
    
Subject 2: "Static classes and methods"
    
- Namespaces: the project is obviously separated in 2 namespaces: 'Library', that represents the classes and methods library, and 'UI', that represents
all the forms that implement the Library.
    
- Static Classes: inside the Library there are 2 static classes. One corresponds to Flights, and the other to Extra (that contains a bunch of extra
elements that don't fit anywhere else). The reasons is these classes don't represent objects, so they are not meant to be instanced and they are ran
at the very start of the program, to do only one task. - Extras can be and will be used later in the program, but it doesn't represent an object of
any kind.
    
    
    
    
    
    
    Justificación técnica: Indicar tema a tema (de los 

temas 01 al 09) dónde se fue aplicando en el código y por qué se decidió implementarlo de esa forma. Toda decisión tiene que estar argumentada 

con razones técnicas que giren alrededor de los pilares de la programación orientada a objetos y cuestiones de mantenibilidad, código limpio, 

flexibilidad al cambio, experiencia de usuario, accesibilidad, uso seguro, rendimiento y eficiencia.
        Suma identificar pros y contras, 

si los tienen en mente.
        El objetivo es que demuestren que saben lo que hacen y que tomaron decisiones con criterio y no mecanizadas.
    

    Si se utilizó alguna biblioteca externa también se deberá justificar la elección. 
    Propuesta de valor agregado: En esta sección se 

explicará y justificará la funcionalidad adicional propuesta para el punto de promoción.
