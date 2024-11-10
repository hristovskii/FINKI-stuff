package mk.ukim.finki.wp.lab_1_grupa_a.bootstrap;

import jakarta.annotation.PostConstruct;
import mk.ukim.finki.wp.lab_1_grupa_a.model.Event;
import mk.ukim.finki.wp.lab_1_grupa_a.model.EventBooking;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;

@Component
public class DataHolder {

    public static List<Event> events = null;
    public static List<EventBooking> eventBookings = null;

    @PostConstruct
    public void init() {
        events = new ArrayList<Event>();
        for (int i = 1; i < 5; i++){
            events.add(new Event("Event"+i, "desc"+i, i));
        }
        eventBookings = new ArrayList<>();
    }

}
