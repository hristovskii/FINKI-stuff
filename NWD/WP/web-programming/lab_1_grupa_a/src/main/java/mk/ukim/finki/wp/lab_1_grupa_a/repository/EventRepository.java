package mk.ukim.finki.wp.lab_1_grupa_a.repository;

import mk.ukim.finki.wp.lab_1_grupa_a.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_1_grupa_a.model.Event;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class EventRepository {
    public List<Event> findAll() {
        return DataHolder.events;
    }

    public List<Event> searchEvents(String text, int rating) {
        return DataHolder.events.stream()
                .filter(event -> (event.getName().contains(text) ||
                        event.getDescription().contains(text)) &&
                        event.getPopularityScore() >= rating)
                .toList();
    }
}
