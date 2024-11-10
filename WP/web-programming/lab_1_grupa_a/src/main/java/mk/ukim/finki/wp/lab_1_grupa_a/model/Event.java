package mk.ukim.finki.wp.lab_1_grupa_a.model;


import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class Event {
    String name;
    String description;
    double popularityScore;
}
