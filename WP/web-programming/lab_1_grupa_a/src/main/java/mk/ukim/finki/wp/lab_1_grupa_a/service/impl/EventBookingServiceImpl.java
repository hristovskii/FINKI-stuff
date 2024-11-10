package mk.ukim.finki.wp.lab_1_grupa_a.service.impl;

import mk.ukim.finki.wp.lab_1_grupa_a.model.EventBooking;
import mk.ukim.finki.wp.lab_1_grupa_a.repository.EventRepository;
import mk.ukim.finki.wp.lab_1_grupa_a.service.EventBookingService;
import org.springframework.stereotype.Service;

@Service
public class EventBookingServiceImpl implements EventBookingService {

    private final EventRepository eventRepository;

    public EventBookingServiceImpl(EventRepository eventRepository) {
        this.eventRepository = eventRepository;
    }

    @Override
    public EventBooking placeBooking(String eventName, String attendeeName, String attendeeAddress, int numberOfTickets) {
        return new EventBooking(eventName, attendeeName, attendeeAddress, numberOfTickets);
    }
}
