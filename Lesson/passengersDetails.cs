using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class passengersDetails
    {
        private String passengerName;
        private String destination;
        private byte passengerAge;
        private int ticketPrice;
        private Boolean isMinor;

         public passengersDetails(String name, String dest, byte age, int price)
        {
            passengerName = name;
            destination = dest;
            passengerAge = age;
            isMinor = (passengerAge < 18);
            ticketPrice = price;
        }

        public int getTicketPrice()
        {
            if (isMinor)
            {
                ticketPrice = ticketPrice - ticketPrice*10/100;

            }
            return ticketPrice;
        }

        public void setTicketPrice(int ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }

        public String getName() { 
            return passengerName; 
        }

        public void setName(String name)
        {
            passengerName = name;
        }

        public String getDestination()
        {
            return destination;
        }

        public void setDestination(String destination)
        {
            this.destination = destination;
        }

        public byte getPassengerAge()
        {
            return passengerAge;
        }

        public void setPassengerAge(byte passengerAge)
        {
            this.passengerAge = passengerAge;
        }

      

    }
}
