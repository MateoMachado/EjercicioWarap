using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact owners = new Contact("Matias");
            Phonebook owner = new Phonebook(owners);
            
            // Crear la lista de contactos
            List<Contact> contactList = new List<Contact>();
            Contact contact1 = new Contact("Matia");
            Contact contact2 = new Contact("Mati");
            Contact contact3 = new Contact("Mat");

            // Agregar contactos a la lista
            contactList.Add(contact1);
            contactList.Add(contact2);
            contactList.Add(contact3);
            owner.persons = contactList;

            //Creo el mensaje
            Message m  = new Message(owners,contact1);
            m.Text = "Hola";

            // Enviar un WhatsApp a algunos contactos
            IMessageChannel message;
            message = new WhatsApp();
            message.Send(m);
            
            // Enviar un twitter a algunos contactos
            IMessageChannel message1;
            message1 = new Twitter();
            message1.Send(m);
        }
    }
}
