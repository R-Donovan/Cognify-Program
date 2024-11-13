using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognify
{
    public class CognifyController
    {
        // Método para aplicar la rehabilitación con base en el tipo de crimen
        public string ApplyRehabilitation(string crimeType)
        {
            string message = string.Empty;

            switch (crimeType)
            {
                case "Violento":
                    message = "Experiencia de rehabilitación aplicada para un crimen violento: empatía y remordimiento experimentados.";
                    break;
                case "Financiero":
                    message = "Experiencia de rehabilitación aplicada para un crimen financiero: comprensión de consecuencias económicas.";
                    break;
                case "De Odio":
                    message = "Experiencia de rehabilitación aplicada para un crimen de odio: perspectiva transformada hacia la diversidad.";
                    break;
                default:
                    message = "Tipo de crimen no reconocido.";
                    break;
            }

            return message;
        }

        // Método para mostrar el impacto general del sistema
        public string ShowImpact()
        {
            return "Impacto general: reducción de costos, reintegración social efectiva y menor reincidencia.";
        }
    }
}
