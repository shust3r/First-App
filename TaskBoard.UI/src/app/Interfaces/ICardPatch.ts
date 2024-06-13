export interface ICardPatch {
    operationType: number;
    path: string;
    op: string;
    value: string | Date;
}
