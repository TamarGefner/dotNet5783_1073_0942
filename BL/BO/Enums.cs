﻿

namespace BO
{

    public enum Category { TABLE, CHAIR, CLOSET, SOFA, BED }
    public enum OrderStatus { Initiated, Ordered, Paid, Shipped, Delivered }
    public enum UpdateAction { increase, reduction, changing };
}