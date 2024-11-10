package mk.ukim.finki.wp.lab_1_grupa_a.service.impl;

import mk.ukim.finki.wp.lab_1_grupa_a.model.Event;
import mk.ukim.finki.wp.lab_1_grupa_a.repository.EventRepository;
import mk.ukim.finki.wp.lab_1_grupa_a.service.EventService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class EventServiceImpl implements EventService {
    private final EventRepository eventRepository;

    public EventServiceImpl(EventRepository eventRepository) {
        this.eventRepository = eventRepository;
    }

    @Override
    public List<Event> listAll() {
        return eventRepository.findAll();
    }

    @Override
    public List<Event> searchEvents(String text, int rating) {
        return eventRepository.searchEvents(text, rating);
    }
}
