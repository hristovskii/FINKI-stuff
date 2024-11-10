package mk.ukim.finki.wp.lab_1_grupa_a;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.web.servlet.ServletComponentScan;

@SpringBootApplication
@ServletComponentScan
public class Lab1GrupaAApplication {

    public static void main(String[] args) {
        SpringApplication.run(Lab1GrupaAApplication.class, args);
    }

}
