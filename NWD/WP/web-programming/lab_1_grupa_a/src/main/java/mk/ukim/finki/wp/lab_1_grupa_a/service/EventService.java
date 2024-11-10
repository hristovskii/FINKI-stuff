package mk.ukim.finki.wp.lab_1_grupa_a.service;

import mk.ukim.finki.wp.lab_1_grupa_a.model.Event;

import java.util.List;

public interface EventService {
    List<Event> listAll();
    List<Event> searchEvents(String text, int rating);
}
