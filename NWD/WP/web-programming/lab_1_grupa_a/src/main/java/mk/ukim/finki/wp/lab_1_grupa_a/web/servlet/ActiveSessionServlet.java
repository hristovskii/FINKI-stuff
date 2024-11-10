package mk.ukim.finki.wp.lab_1_grupa_a.web.servlet;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;

@WebServlet("/active-sessions")
public class ActiveSessionServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        int activeSessions = SessionCounterListener.getActiveSessions();
        response.getWriter().println("<html><body>");
        response.getWriter().println("<p>Number of active sessions: " + activeSessions + "</p>");
        response.getWriter().println("</body></html>");
    }
}
