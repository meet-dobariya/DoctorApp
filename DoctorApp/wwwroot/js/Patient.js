
$(document).ready(function () {
    $('#example').DataTable({
        "ajax": {
            "url": "/Patients/GetCompanyData",
            "type": "POST",
            "datatype": "json",
            "dataSrc": ""
        },
        "columns": [
            {
                "data": null, "title": "No.",
                "render": function (data, type, row, meta) {
                    var data = meta.row + 1;
                    return data;
                }
            },
            {
                "data": "amount"
            },
            {
                "data": "createdDate",
                "visible":false
            },
        ],
        "order": [[2, 'desc']]
    });
});


