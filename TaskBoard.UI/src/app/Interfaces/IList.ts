import { ICard } from "./ICard";

export interface IList {
    id: number;
    name: string;
    cardsList: ICard[];
}