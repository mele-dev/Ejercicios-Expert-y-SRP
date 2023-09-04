using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment appointment = new Appointment("Steven Jhonson", "986782342", "22", "5555-555-555", DateTime.Now, "Wall Street", "Armand");

            Appointment appointment2 = new Appointment("Ralf Manson", "", "24", "5555-555-555", DateTime.Now, "Queen Street", "");

            /* mandamos los objetos Appointment que creamos a el metodo ValidateAppointment
             * para que este nos retorne la validacion de cada campo, haciendolo en una
             * clase aparte */
            string appointmentResult = AppointmentService.ValidateAppointment(appointment);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.ValidateAppointment(appointment2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
