namespace Game.dialoges{
    public class Text(){
        public static string zenon(int id){
            string sms;
            switch(id){
                case 1:
                    sms = "Що... що сталося? Все темне... Що я бачу?";
                    return sms;
                default:
                    return "Syntax eroor: wrong ID";
            }
        }
        public static string action(int id){
            string sms;
            switch(id){
                case 1:
                    sms = "Зенон Хелкс приходить до тями пiсля катастрофи. На екранi—повна темрява, але з часом його очi починають намагатися фокусуватися. Щось вiн бачить — розмитi контури та тiнi, але зiр все ще серйозно порушений.";
                    return sms;
                case 2:
                    sms = "Зенон намагається встати, але орiєнтується дуже важко. Всi кольори виглядають блякло, а навколишнi об'єкти здаються лише розмитими силуэтами.";
                    return sms;
                default:
                    return "Syntax eroor: wrong ID";
            }
        }
    }
}