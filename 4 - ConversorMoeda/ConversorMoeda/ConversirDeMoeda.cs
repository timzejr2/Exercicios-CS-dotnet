class ConversirDeMoeda {

    public static double Iof = 0.06;

    public static double VPagar(double cotacao, double quantidade) {
        return cotacao * quantidade + ((cotacao * quantidade) * Iof);
    }

}

