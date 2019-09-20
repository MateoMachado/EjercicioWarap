using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            owner dueño = new owner();

            // Crear la lista de contactos
            contact contacto1 = new contact("Francisco");
            contact contaco2 = new contact("Mateo");
            contact contaco3 = new contact("Matias");
            List<contact> contactos = new List<contact>();
            
            // Agregar contactos a la lista
            contactos.add(contacto2);
            contactos.add(contacto3);
            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
