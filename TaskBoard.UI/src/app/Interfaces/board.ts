import { IListNameId } from "./IListNameId";

export interface Board {
    id: number;
    name: string;
    lists: IListNameId[];
}
