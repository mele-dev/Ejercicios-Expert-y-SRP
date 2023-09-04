using System;
using System.Text;

namespace Library
{
    /* creamos una clase Appointment la cual solo se encarga de crearlo,
     * luego utilizamos el metodo ValidateAppointment de la clase
     * AppointmentService para validar e ingresar los datos */
    public class Appointment
    {
        public string PatientName { get; set; }
        public string PatientId { get; set; }
        public string PatientAge { get; set; }
        public string PatientPhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentPlace { get; set; }
        public string DoctorName { get; set; }

        public Appointment(String patientName, String patientId, String patientAge, String patientPhoneNumber,
                DateTime date, String appointmentPlace, String doctorName)
        {
            this.PatientName = patientName;
            this.PatientId = patientId;
            this.PatientAge = patientAge;
            this.PatientPhoneNumber = patientPhoneNumber;
            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
            this.DoctorName = doctorName;
        }
    }
}