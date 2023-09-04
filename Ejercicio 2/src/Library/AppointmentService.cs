using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string ValidateAppointment(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(appointment.PatientName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.PatientId))
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.PatientAge))
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient age' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.PatientPhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.AppointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(appointment.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
