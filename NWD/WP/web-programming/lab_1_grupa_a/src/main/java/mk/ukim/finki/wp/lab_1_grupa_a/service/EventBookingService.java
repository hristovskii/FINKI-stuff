package mk.ukim.finki.wp.lab_1_grupa_a.service;

import mk.ukim.finki.wp.lab_1_grupa_a.model.EventBooking;

public interface EventBookingService {
    EventBooking placeBooking(String eventName, String attendeeName, String attendeeAddress, int numberOfTickets);

}
