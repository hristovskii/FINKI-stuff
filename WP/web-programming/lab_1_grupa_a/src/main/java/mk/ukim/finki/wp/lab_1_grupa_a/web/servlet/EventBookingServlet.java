package mk.ukim.finki.wp.lab_1_grupa_a.web.servlet;

import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import mk.ukim.finki.wp.lab_1_grupa_a.model.EventBooking;
import mk.ukim.finki.wp.lab_1_grupa_a.service.EventBookingService;
import org.thymeleaf.context.WebContext;
import org.thymeleaf.spring6.SpringTemplateEngine;
import org.thymeleaf.web.IWebExchange;
import org.thymeleaf.web.servlet.JakartaServletWebApplication;

import java.io.IOException;

import static java.lang.Integer.parseInt;

@WebServlet(name = "eventBooking", urlPatterns = "/eventBooking")
public class EventBookingServlet extends HttpServlet {
    public final SpringTemplateEngine springTemplateEngine;
    EventBookingService eventBookingService;

    public EventBookingServlet(SpringTemplateEngine springTemplateEngine, EventBookingService eventBookingService) {
        this.springTemplateEngine = springTemplateEngine;
        this.eventBookingService = eventBookingService;
    }

    public void doGet(HttpServletRequest req, HttpServletResponse resp) throws IOException {
        IWebExchange webExchange = JakartaServletWebApplication
                .buildApplication(getServletContext())
                .buildExchange(req, resp);

        WebContext webContext = new WebContext(webExchange);

        springTemplateEngine.process("bookingConfirmation.html", webContext, resp.getWriter());
    }

    public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException {

        EventBooking eventBooking = eventBookingService.placeBooking(
                request.getParameter("eventBook"),
                request.getServerName(),
                request.getLocalAddr(),
                parseInt(request.getParameter("numTickets"))
        );

        request.getSession().setAttribute("eventBooking", eventBooking);

        response.sendRedirect("/eventBooking");
    }
}
