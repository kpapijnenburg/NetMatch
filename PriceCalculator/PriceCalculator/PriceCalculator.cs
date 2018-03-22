using System;
using System.Runtime.Remoting.Messaging;

namespace PriceCalculator
{

    public class PriceCalculator
    {
        private decimal PricePerAdult { get; }
        private decimal PricePerChild { get; }
        private int NumberOfRooms { get; }
        private decimal PriceExtraRoom { get; }
        private bool HasPlaneTicket { get; }
        private decimal PricePlaneTicket { get; }
        private bool HasTravelInsurance { get; }
        private decimal PriceTravelInsurance { get; }
        private bool HasCancellation { get; }
        private decimal PriceCancellation { get; }
        private decimal CalamityFund { get; }
        private decimal PriceReservation { get; }


        public PriceCalculator(decimal pricePerAdult, decimal pricePerChild, int numberOfRooms, decimal priceExtraRoom, bool hasPlaneTicket, decimal pricePlaneTicket, bool hasTravelInsurance, decimal priceTravelInsurance, bool hasCancellation, decimal priceCancellation)
        {
            PricePerAdult = pricePerAdult;
            PricePerChild = pricePerChild;
            NumberOfRooms = numberOfRooms;
            PriceExtraRoom = priceExtraRoom;
            HasPlaneTicket = hasPlaneTicket;
            PricePlaneTicket = pricePlaneTicket;
            HasTravelInsurance = hasTravelInsurance;
            PriceTravelInsurance = priceTravelInsurance;
            HasCancellation = hasCancellation;
            PriceCancellation = priceCancellation;
            CalamityFund = Convert.ToDecimal(2.50);
            PriceReservation = Convert.ToDecimal(18.50);
        }

        public decimal Calculate(decimal pricePerAdult, decimal pricePerChild, int numberOfRooms,
            decimal priceExtraRoom, bool hasPlaneTicket, decimal pricePlaneTicket, bool hasTravelInsurance,
            decimal priceTravelInsurance, bool hasCancellation, decimal priceCancellation)
        {
            decimal totalPrice = 0;

            //SubTotaal prijs voor de kamers is met deze variabele niet te berekenen. 
            //Er mist wat iedere kamer kost en hoeveel personen er van iedere soort zijn. 
            //Ook kan er niet worden aangegeven of er een extra kamer geboekt is of niet.
            
            //Vervoer sectie
            if (hasPlaneTicket)
            {
                totalPrice += pricePlaneTicket;
            }

            //cancel sectie
            if (hasCancellation)
            {
                totalPrice += priceCancellation;
            }

            //verzekering sectie
            if (hasTravelInsurance)
            {
                totalPrice += priceTravelInsurance;
            }

            //overige toevoegingen
            totalPrice += CalamityFund + PriceReservation;

            return totalPrice;
        }
    }
}