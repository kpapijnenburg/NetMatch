using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
    class PrijsBerekeningsModule
    {
        decimal pricePerAdult;
        decimal pricePerChild;
        decimal priceAdditionalRoom;

        decimal pricePlaneTicket;
        decimal priceTravelInsurance;
        decimal priceCancellation;
        decimal calamityfund = 2.50m;
        decimal priceReservation = 18;

        int numberOfRooms;
        int numberOfAdults;
        int numberOfChilds;

        bool hasTravelInsurance;
        bool hasCancellation;

        decimal costTravelInsurance;
        decimal costCancellation;

        public decimal PrijsBerekening(decimal CostTravelInsurance, decimal CostCancellation)
        {
            if (hasTravelInsurance == true)
                costTravelInsurance = CostTravelInsurance;

            if (hasCancellation == true)
                costCancellation = CostCancellation;

            // Verander dit indien de vliegtickets voor kinderen andere prijzen hebben
            int numberOfPeople = numberOfAdults + numberOfChilds;

            decimal hotelKosten = (numberOfAdults * pricePerAdult) + (numberOfChilds * pricePerChild) + ((numberOfRooms - 1) * priceAdditionalRoom);

            decimal reisKosten = (numberOfPeople * pricePlaneTicket) + priceTravelInsurance + priceCancellation;

            decimal subtotaal = hotelKosten + reisKosten;

            decimal totaal = subtotaal + calamityfund + priceReservation;

            return totaal;
        }
    }
}
