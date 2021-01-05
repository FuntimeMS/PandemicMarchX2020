var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
var startYear = 2020;
var startMonth = 2;
var startDay = 11;
var startDate  = new Date(startYear, startMonth, startDay);
var today = new Date();
var elapsed = today.getTime() - startDate.getTime(); // elapsed time in milliseconds
var elapsedDays = Math.floor(elapsed / (1000 * 60 * 60 * 24)); // elapsed time in days
var elapsedDaysWithOffset = elapsedDays + startDay;

function formatLongDate(date) {
  return date.toLocaleDateString("en-US", options);
}

function pandemicDateToString() {
  var monthName = startDate.toLocaleString('default', { month: 'long' });

  return monthName + ' ' + elapsedDaysWithOffset + ', ' + today.getFullYear();
}

function runApp() {
  document.getElementById("todayDateString").innerHTML = formatLongDate(today);
  document.getElementById("startDateString").innerHTML = formatLongDate(startDate);
  document.getElementById("pandemicDate").innerHTML = pandemicDateToString();
}
