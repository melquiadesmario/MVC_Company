var ValidaExclusao = function (id, evento) {
    if (confirm("Confirma exlusão?")) {
        return true;
    } else {
        evento.preventDefault();
        return false;
    }
}