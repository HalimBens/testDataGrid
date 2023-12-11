$(document).ready(function () {
    $('#myTable').DataTable({
        "language": {
            "paginate": {
                "first": "Premier",
                "last": "Last",
                "next": "Suivant",
                "previous": "Précédent"
            }
        }
    });
});