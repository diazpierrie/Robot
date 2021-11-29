using System;
using RabbitMQ.Client;
using System.Text;

namespace CintaTrans
{
    public static class Publicador
    {
        private static IModel CrearCanal(IConnection conexion)
        {
            var canal = conexion.CreateModel();
            canal.QueueDeclare("Robot", false, false, false, null);
            //canal.ExchangeDeclare("Robot", "fanout");
            //canal.QueueBind("Robot", "Robot", "");

            return canal;
        }

        public static void PublicarEstados(Robot oRobot)

        {
            var industria = new ConnectionFactory() { HostName = "LocalHost" };

            using (var connection = industria.CreateConnection())
            {
                var canalCinta = CrearCanal(connection);

                {
                    var estado = oRobot.BEncendido + "-" + oRobot.BPrensa + "-" + oRobot.BCinta + "-" + oRobot.BPila + "-" + oRobot.Apilados;
                    var body = Encoding.UTF8.GetBytes(estado);

                    canalCinta.BasicPublish("", "Robot", null, body);
                }
            }
        }
    }
}