namespace HackChange
{
    public class ChangeModel
    {
        /// <summary>
        ///  จำนวนเงินถอน
        /// </summary>
        public int Change { get; set; }
        /// <summary>
        /// จำนวนแบ่งที่ถอน 1000 500 100 50 20 5 1
        /// </summary>
        public int[] BankCards { get; set; }
        /// <summary>
        /// Example
        /// 0 = สำเร็จ
        /// 1 = ใส่ข้อมูลไม่ครบ
        /// 2 = เงินจ่ายไม่พอ
        /// </summary>
        public int StatusCode { get; set; }
    }
}