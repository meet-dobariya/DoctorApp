var chart1 = document.getElementById("linechart");

var myChart1 = new Chart(chart1, {
    type: 'line',
    data: {
        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
        datasets: [{
            data: ['1150', '1160', '1160', '1165', '1160', '1170', '1175', '1165', '1170', '1180', '1185', '1190'],
            backgroundColor: "rgba(48, 164, 255, 0.2)",
            borderColor: "rgba(48, 164, 255, 0.8)",
            fill: true,
            borderWidth: 1
        }]
    },
    options: {
        animation: {
            duration: 2000,
            easing: 'easeOutQuart',
        },
        plugins: {
            legend: {
                display: false,
                position: 'right',
            },
            title: {
                display: true,
                text: 'Sales volume',
                position: 'left',
            },
        },
    }
});