export interface HistoryResponse {
        historyId: number
        drinkId: number
        dateTime: string
        userId: number
    }
    
    export type PostHistory = Omit<HistoryResponse, "historyId">;